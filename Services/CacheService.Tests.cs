using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cassandra;
using Coflnet.Sky.Proxy.Client.Api;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace Sky.PlayerInfo.Service;

public class CacheServiceTests
{
    private readonly Guid player = Guid.Parse("11111111-1111-1111-1111-111111111111");
    private readonly Guid profile = Guid.Parse("22222222-2222-2222-2222-222222222222");

    [Test]
    public async Task RefreshPreservesLastKnownData(
        [Values("museum", "profile", "player")] string kind,
        [Values("transport", "rejected", "malformed", "fresh", "missing")] string scenario)
    {
        using var cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
        var clusterMock = new Mock<ICluster>();
        clusterMock.SetupGet(c => c.Configuration).Returns(cluster.Configuration);
        // Skip schema creation: these tables already exist in the fake session.
        clusterMock.SetupGet(c => c.Metadata).Throws(new AlreadyExistsException("cache_test", "profiles"));
        var session = new Mock<ISession>();
        session.SetupGet(s => s.Cluster).Returns(clusterMock.Object);
        session.SetupGet(s => s.Keyspace).Returns("cache_test");
        session.Setup(s => s.Execute(It.IsAny<IStatement>())).Returns(() => new RowSet());
        var statements = new Dictionary<IStatement, string>();
        session.Setup(s => s.PrepareAsync(It.IsAny<string>())).Returns((string query) =>
        {
            var prepared = new Mock<PreparedStatement>();
            prepared.Setup(p => p.Bind(It.IsAny<object[]>())).Returns(() =>
            {
                var bound = new BoundStatement();
                statements[bound] = query;
                return bound;
            });
            return Task.FromResult(prepared.Object);
        });
        var cachedAt = scenario == "fresh" ? DateTimeOffset.UtcNow : DateTimeOffset.UtcNow.AddDays(-1);
        var data = kind == "museum" ? "{\"value\":42,\"appraisal\":true,\"items\":{\"ASPECT_OF_THE_END\":{}}}" :
            kind == "player" ? "{\"success\":true,\"player\":{\"lastLogout\":42}}" : "{\"museum\":\"cached\"}";
        session.Setup(s => s.ExecuteAsync(It.IsAny<IStatement>(), It.IsAny<string>())).Returns((IStatement statement, string _) =>
        {
            // Model Cassandra filtering out stale rows in the original query.
            var query = statements[statement];
            Assert.That(query, Does.StartWith("SELECT"), "Fallback must not overwrite cached data");
            if (scenario == "missing" || (scenario != "fresh" && Regex.IsMatch(query, "(?:SavedAt|LastChange)\"?\\s*>", RegexOptions.IgnoreCase)))
                return Task.FromResult(new RowSet());
            return Task.FromResult<RowSet>(new CachedRows(new Dictionary<string, object>
            {
                ["PlayerId"] = player, ["ProfileId"] = profile, ["Part"] = player,
                ["SavedAt"] = cachedAt, ["LastChange"] = cachedAt, ["LastLogout"] = cachedAt,
                ["Content"] = data, ["Data"] = data
            }));
        });
        var proxy = new Mock<IProxyApi>();
        var upstream = proxy.Setup(p => p.ProxyHypixelGetAsync(It.IsAny<string>()));
        if (scenario == "rejected") upstream.ReturnsAsync("{\"success\":false,\"cause\":\"API disabled\"}");
        else if (scenario == "malformed") upstream.ReturnsAsync("\"upstream unavailable\"");
        else upstream.ThrowsAsync(new HttpRequestException("API unavailable"));
        var cache = new CacheService(new ConfigurationBuilder().Build(), proxy.Object, session.Object);
        var freshAfter = DateTimeOffset.UtcNow.AddMinutes(-2);
        if (scenario == "missing")
        {
            Assert.ThrowsAsync<HttpRequestException>(async () =>
            {
                if (kind == "museum") await cache.GetMuseum(player, profile, freshAfter);
                else if (kind == "profile") await cache.GetProfileJson(player, profile, freshAfter);
                else await cache.GetProfileData(player, freshAfter);
            });
        }
        else if (kind == "museum")
            Assert.That((await cache.GetMuseum(player, profile, freshAfter)).items.Keys, Does.Contain("ASPECT_OF_THE_END"));
        else if (kind == "profile")
            Assert.That(await cache.GetProfileJson(player, profile, freshAfter), Is.EqualTo(data));
        else
            Assert.That((await cache.GetProfileData(player, freshAfter)).lastLogout, Is.EqualTo(42));
        proxy.Verify(p => p.ProxyHypixelGetAsync(It.IsAny<string>()), scenario == "fresh" ? Times.Never() : Times.Once());
    }

    private class CachedRows : RowSet
    {
        public CachedRows(Dictionary<string, object> values)
        {
            Columns = values.Select((entry, index) => new CqlColumn { Name = entry.Key, Index = index, Type = entry.Value.GetType() }).ToArray();
            var row = new Mock<Row>();
            foreach (var column in Columns)
            {
                var value = values[column.Name];
                if (value is string text) row.Setup(r => r.GetValue<string>(column.Index)).Returns(text);
                if (value is Guid uuid) row.Setup(r => r.GetValue<Guid>(column.Index)).Returns(uuid);
                if (value is DateTimeOffset date) row.Setup(r => r.GetValue<DateTimeOffset>(column.Index)).Returns(date);
            }
            RowQueue.Enqueue(row.Object);
        }
    }
}
