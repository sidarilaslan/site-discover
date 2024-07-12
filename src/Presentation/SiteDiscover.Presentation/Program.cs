using SiteDiscover.Application;
using SiteDiscover.Presentation.Extentions;
using System.Globalization;
using SiteDiscover.Persistence;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.AspNetCore.Localization;
using SiteDiscover.Presentation.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string envName = builder.Environment.EnvironmentName;
builder.Services.AddControllersWithViews().AddViewLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var defaultCulture = new CultureInfo("tr-TR");
    var supportedCultures = new[]
    {
        defaultCulture,
        new("en-US")
    };
    options.DefaultRequestCulture = new(defaultCulture);
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.ApplyCurrentCultureToResponseHeaders = true;

    options.RequestCultureProviders = new IRequestCultureProvider[]
    {
        new RouteDataRequestCultureProvider() {Options= options},
        new AcceptLanguageHeaderRequestCultureProvider()
    };

});



builder.Configuration.AddJsonFile($"appsettings.{envName}.json", optional: false, reloadOnChange: true);
builder.Services.AddPersistanceService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddHealthChecks();
builder.Services.AddMemoryCache();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseStatusCodePagesWithReExecute("/Error/{0}");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseCustomHealthCheck(builder.Configuration);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseRequestLocalization();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{ui-culture=en-US}/{controller=Home}/{action=Index}/{id?}");



app.Run();