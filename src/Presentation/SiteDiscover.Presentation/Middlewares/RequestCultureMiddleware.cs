using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Localization;

namespace SiteDiscover.Presentation.Middlewares
{
    public class RequestCultureMiddleware
    {
        readonly RequestDelegate _next;
      

        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        
        }
        public async Task InvokeAsync(HttpContext context)
        {

            IRequestCultureFeature? requestCultureFeature = context.Features.Get<IRequestCultureFeature>();
            string? uiCulture = requestCultureFeature.RequestCulture.UICulture.ToString();

            if (context.Request.Path == "/")
                context.Response.Redirect($"/{uiCulture}");
            
            await _next(context);
           
        }
    }
}
