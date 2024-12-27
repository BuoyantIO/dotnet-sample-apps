using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Prometheus;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Net8PacketTest.Api;

public class Startup
{
    private readonly IHostEnvironment _hostEnvironment;
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration, IHostEnvironment hostEnvironment)
    {
        Configuration = configuration;
        _hostEnvironment = hostEnvironment;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AnyOrigin", builder =>
            {
                builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });

        services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });


        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Net8PacketTest Service",
                    Version = "v1"
                });

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) || !_hostEnvironment.IsDevelopment())
            {
                var swaggerConfig = Configuration.GetSection("Swagger").Get<SwaggerConfig>();
                if (!string.IsNullOrEmpty(swaggerConfig?.IngressRoute))
                {
                    c.DocumentFilter<SwaggerDocumentFilter>(swaggerConfig.IngressRoute);
                }
            }

            // Incorporate XML comments into swagger
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Net8PacketTest.Api.xml");
            c.IncludeXmlComments(filePath);
        });
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env, IHostApplicationLifetime appLifetime)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseCors("AnyOrigin");
        }

        app.UseSwagger(x => x.SerializeAsV2 = true);
        app.UseSwaggerUI(x =>
        {
            x.SwaggerEndpoint("v1/swagger.json", $"Net8PacketTest Service");
        });

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapMetrics();
        });
    }

    private sealed class SwaggerConfig
    {
        /// <summary>
        /// The ingress path for the service
        /// </summary>
        public string IngressRoute { get; set; } = string.Empty;
    }

    private class SwaggerDocumentFilter : IDocumentFilter
    {
        private readonly string _ingressRoute;

        public SwaggerDocumentFilter(string ingressRoute)
        {
            if (!ingressRoute.StartsWith('/'))
            {
                ingressRoute = "/" + ingressRoute;
            }
            _ingressRoute = ingressRoute;
        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Servers.Add(new OpenApiServer() { Url = _ingressRoute });
        }
    }
}
