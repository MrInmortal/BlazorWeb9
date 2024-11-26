using Blazored.LocalStorage; // Importar la librería
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tarea9;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuración de HttpClient (ya existente)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Configuración de Blazored.LocalStorage
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
