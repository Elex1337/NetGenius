using NetGenius.Models;
using Serilog;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Net;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
//Логирование в файл
IHostBuilder hostBuilder = builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
{
    loggerConfiguration
        .MinimumLevel.Information()
        .WriteTo.Console()
        .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day);
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Home/login";
    });
builder.Services.AddControllersWithViews();
builder.Services.AddMvc().AddMvcLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix);
builder.Services.Configure<RequestLocalizationOptions>(
    options =>
    {
        var cultures = new[] {
            new CultureInfo("ru-Ru"),
            new CultureInfo("en-Us") };
        options.DefaultRequestCulture = new RequestCulture(culture: "en-Us", uiCulture: "en-Us");
        options.SupportedCultures = cultures;
        options.SupportedUICultures = cultures;
    });
builder.Services.AddLocalization(option =>
option.ResourcesPath = "Resources");

builder.WebHost.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddDebug().
    AddConsole().
    AddSeq();
});
    
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

var localOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(localOptions.Value);

app.UseAuthorization();
app.UseAuthentication();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

