using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using System.Net.Mime;

namespace PMI_Site.Presentation.Extentions
{
    public static class HealthCheckConfigureExtension
    {
        public static IApplicationBuilder UseCustomHealthCheck(this IApplicationBuilder app,IConfiguration configuration)
        {
            string HealthCheckPath = configuration.GetSection("HealthCheck:Path").Value?? "/app/health";
             app.UseHealthChecks(HealthCheckPath, new HealthCheckOptions
            {
                ResponseWriter = async (context, healthReport) =>
                {
                    string result = JsonConvert.SerializeObject(new
                    {
                        status = healthReport.Status.ToString(),

                    });
                    context.Response.ContentType = MediaTypeNames.Application.Json;
                    await context.Response.WriteAsync(result);
                }
            });
            return app;
        }
    }
}
