using IgniteUI.Blazor.Controls;
using KB13228_IgbDataChart_MarkerDisplay;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(
    typeof(IgbDataLegendModule),
    typeof(IgbScatterAreaSeriesModule),
    typeof(IgbCategoryChartModule)
    );

await builder.Build().RunAsync();
