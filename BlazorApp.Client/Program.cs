using BlazorApp.Client;
using BlazorApp.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TipoDepartamentoService>();
builder.Services.AddScoped<TipoDirectorService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<EmpleadoService>(); 
await builder.Build().RunAsync();
