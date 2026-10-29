using System;
using System.Threading;
using System.Threading.Tasks;
using Cassandra;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;

namespace Sky.PlayerInfo.Infrastructure;

internal static class DatabaseReadiness
{
    public static Task CheckAsync(IServiceProvider services, CancellationToken cancellationToken = default) =>
        Task.Run(async () =>
        {
            var session = services.GetRequiredService<ISession>();
            var cache = services.GetRequiredService<IDistributedCache>();
            await Task.WhenAll(
                session.ExecuteAsync(new SimpleStatement("SELECT key FROM system.local").SetReadTimeoutMillis(3000)),
                cache.GetAsync("pki-readiness:" + Guid.NewGuid().ToString("N"), cancellationToken));
        }, cancellationToken).WaitAsync(TimeSpan.FromSeconds(5), cancellationToken);
}
