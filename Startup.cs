using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Sky.PlayerInfo.Service;
using Coflnet.Sky.Core;
using Coflnet.Sky.Proxy.Client.Api;
using StackExchange.Redis;

namespace Sky.PlayerInfo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private static string CORS_POLICY = "default";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddJsonOptions(option =>
            {
                option.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault;
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v0", new OpenApiInfo { Title = "SkyPlayerInfo", Version = "v1" });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SkyPlayerInfo", Version = "v1.0" });



            });
            services.AddStackExchangeRedisCache(options =>
            {
                var stringConfig = Configuration["redis_host"];
                var parsedOptions = ConfigurationOptions.Parse(stringConfig);
                if(parsedOptions.SyncTimeout < 500)
                {
                    parsedOptions.SyncTimeout = 500;
                }
                options.ConfigurationOptions = parsedOptions;
            });
            services.AddScoped<ProfileServie>();
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();
                options.MimeTypes =
                    ResponseCompressionDefaults.MimeTypes.Concat(
                        new[] { "application/json" });
            });

            services.AddSingleton<IProxyApi>(sp => new ProxyApi(Configuration["PROXY_BASE_URL"]));
            services.AddCors(c => c.AddPolicy(CORS_POLICY, p =>
            {
                p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            }));
            services.AddJaeger(Configuration, 0.05, 30);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            app.UseResponseCompression();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger(a =>
            {
                a.RouteTemplate = "api/profile/swagger/{documentName}/swagger.json";
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/api/profile/swagger/v1/swagger.json", "Sample API");
                c.RoutePrefix = "api/profile";
            });
            app.UseExceptionHandler(errorApp =>
                {

                    ErrorHandler.Add(logger, errorApp, "sky-profile");
                });

            app.UseRouting();

            app.UseCors(CORS_POLICY);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}