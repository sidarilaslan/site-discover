using PMI_Site.Persistence;
using PMI_Site.Application;
using System.Net;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using System.Net.Mime;
using Newtonsoft.Json;
using PMI_Site.Presentation.Extentions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string envName = builder.Environment.EnvironmentName;
builder.Services.AddControllersWithViews();
builder.Configuration.AddJsonFile($"appsettings.{envName}.json", optional: false, reloadOnChange: true);
builder.Services.AddPersistanceService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddHealthChecks();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
