using System.Linq;
using Jaeger.Samplers;
using Jaeger.Senders;
using Jaeger.Senders.Thrift;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OpenTracing;
using OpenTracing.Util;
using Sky.PlayerInfo.Service;

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

            services.AddControllers().AddJsonOptions(option =>{
                option.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault;
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v0", new OpenApiInfo { Title = "SkyPlayerInfo", Version = "v1" });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SkyPlayerInfo", Version = "v1.0" });



            });
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration["redis_host"];
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

            services.AddSingleton<ITracer>(serviceProvider =>
            {
                ILoggerFactory loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
                IConfiguration iConfiguration = serviceProvider.GetRequiredService<IConfiguration>();

                Jaeger.Configuration.SenderConfiguration.DefaultSenderResolver = new SenderResolver(loggerFactory)
                    .RegisterSenderFactory<ThriftSenderFactory>();

                var samplingRate = 0.10d;
                var lowerBoundInSeconds = 30d;
                ISampler sampler = new GuaranteedThroughputSampler(samplingRate, lowerBoundInSeconds);
                var config = Jaeger.Configuration.FromIConfiguration(loggerFactory, iConfiguration);

                ITracer tracer = config.GetTracerBuilder()
                    .WithSampler(sampler)
                    .Build();

                GlobalTracer.Register(tracer);
                return tracer;
            });
            services.AddCors(c => c.AddPolicy(CORS_POLICY, p =>
            {
                p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            }));
            services.AddOpenTracing();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseHttpsRedirection();

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