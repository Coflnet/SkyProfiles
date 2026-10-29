using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Cassandra;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace Sky.PlayerInfo.Infrastructure;

public class DatabaseReadinessTests
{
    private Mock<ISession> session = null!;
    private Mock<IDistributedCache> cache = null!;
    private ServiceProvider services = null!;

    [SetUp]
    public void Setup()
    {
        session = new Mock<ISession>();
        session.Setup(s => s.ExecuteAsync(It.IsAny<IStatement>())).ReturnsAsync(new RowSet());
        cache = new Mock<IDistributedCache>();
        cache.Setup(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>())).ReturnsAsync((byte[]?)null);
        services = new ServiceCollection().AddSingleton(session.Object).AddSingleton(cache.Object).BuildServiceProvider();
    }

    [TearDown]
    public void Cleanup() => services.Dispose();

    [Test]
    public async Task EveryCheckQueriesCqlAndReadsAnUncachedProbeKeyWithoutWriting()
    {
        var keys = new List<string>();
        cache.Setup(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .Callback<string, CancellationToken>((key, _) => keys.Add(key)).ReturnsAsync((byte[]?)null);
        await DatabaseReadiness.CheckAsync(services);
        await DatabaseReadiness.CheckAsync(services);
        session.Verify(s => s.ExecuteAsync(It.Is<SimpleStatement>(q => q.QueryString == "SELECT key FROM system.local")), Times.Exactly(2));
        cache.Verify(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
        cache.VerifyNoOtherCalls();
        Assert.That(keys[0], Is.Not.EqualTo(keys[1]));
    }

    [TestCase(true)]
    [TestCase(false)]
    public void EitherUnavailableDependencyFailsReadiness(bool cql)
    {
        if (cql) session.Setup(s => s.ExecuteAsync(It.IsAny<IStatement>())).ThrowsAsync(new InvalidOperationException("synthetic CQL failure"));
        else cache.Setup(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>())).ThrowsAsync(new InvalidOperationException("synthetic cache failure"));
        Assert.ThrowsAsync<InvalidOperationException>(() => DatabaseReadiness.CheckAsync(services));
    }

    [TestCase(true)]
    [TestCase(false)]
    public void StalledDependencyHasOneFiveSecondDeadline(bool cql)
    {
        if (cql) session.Setup(s => s.ExecuteAsync(It.IsAny<IStatement>())).Returns(new TaskCompletionSource<RowSet>().Task);
        else cache.Setup(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>())).Returns(new TaskCompletionSource<byte[]?>().Task);
        var elapsed = Stopwatch.StartNew();
        Assert.ThrowsAsync<TimeoutException>(() => DatabaseReadiness.CheckAsync(services));
        Assert.That(elapsed.Elapsed, Is.InRange(TimeSpan.FromSeconds(4.9), TimeSpan.FromSeconds(7)));
    }

    [Test]
    public void StartupConnectionConstructionIsInsideTheDeadline()
    {
        using var unavailable = new ServiceCollection().AddSingleton<ISession>(_ =>
            throw new InvalidOperationException("synthetic startup connection failure")).BuildServiceProvider();
        Assert.ThrowsAsync<InvalidOperationException>(() => DatabaseReadiness.CheckAsync(unavailable));
    }
}
