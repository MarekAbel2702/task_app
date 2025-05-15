using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TaskApp.Frontend;
using TaskApp.Frontend.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiUrl = builder.Configuration["apiUrl"] ?? "https://localhost:7211/api";

builder.Services.AddScoped(sp => new HttpClient
{ 
    BaseAddress = new Uri(apiUrl!) 
});

builder.Services.AddScoped<AuthService>();

await builder.Build().RunAsync();
