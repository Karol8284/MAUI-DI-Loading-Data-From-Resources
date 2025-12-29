using MAUI_DI_Loading_Data_From_Resources.Shared.Services;
using MAUI_DI_Loading_Data_From_Resources.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MAUI_DI_Loading_Data_From_Resources.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
