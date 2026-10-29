This service exposes hypixel profile data in smal easy to consume chunks.  
It caches each profile (split into parts) seperatetly in redis to safe bandwith and time.



## Configuration
See appsettings.json all of the settings in there can be overwritten by enviroment variables.  
The container port is `8000` it runs as nonroot user.

## External CQL PEM migration

Core 0.7.5 accepts `CASSANDRA__TLS__CA_CERT_PATH`, `CASSANDRA__TLS__CERT_PATH`,
`CASSANDRA__TLS__KEY_PATH` and `CASSANDRA__TLS__SERVER_NAME`. Preserve existing
hosts, keyspace and authentication. Mount the explicitly issued `sky-client` identity's
complete chain/key and a trust bundle containing the existing CQL CA plus the shared
root; do not replace the legacy trust root. The PEM section takes precedence over
legacy PFX configuration and strictly validates the configured server name and roots.

Mount renewable PEM files without `subPath`. New physical connections reload them;
existing sessions continue uninterrupted. Core registers validated intermediates in
the workload user's CA store, without adding roots or changing machine trust. Keep
`HOME` writable and private (the container defaults to `/tmp`), and verify a fresh
connection after renewal or trust changes.

Startup and every `GET /health/ready` execute a fresh read-only CQL query against
`system.local` and read a unique absent key through the existing distributed cache.
Both operations share a five-second deadline, including initial connection creation.
Readiness returns 200 on success and 503 on failure; startup fails if its check fails.
The probes do not instantiate the business cache service or fetch upstream profiles.

Internal HTTP 8000, `redis_host` cache configuration, Proxy HTTP and public SkyCrypt
HTTPS behavior remain unchanged. No Kafka connection is used by this service.
Internal TLS activation is deferred because managed traffic already uses Cilium WireGuard.
The Docker build runs normal Debug tests before Release publication; Release excludes
the service's test sources.
