using BlazorTestPanels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("DSMBMAY9C3t2VVhhQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkFiWH5ccXxXR2dcUUU=;NDSMBMAY9C3t2VVhhQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkFiWH5ccXxXR2dcUUU=;NjEyOTE2QDMyMzAyZTMxMmUzMEFmNEI0OU1RT05LY0tKRzd6SW5hd3VGKzdZc2MxZFVQMlJ0cVhLS1VzNkk9");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

await builder.Build().RunAsync();
