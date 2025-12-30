using MAUI_DI_Loading_Data_From_Resources.Services;
using MAUI_DI_Loading_Data_From_Resources.Services.LoadingData;
using MAUI_DI_Loading_Data_From_Resources.Shared.Services;
using Microsoft.Extensions.Logging;

namespace MAUI_DI_Loading_Data_From_Resources
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Add device-specific services used by the MAUI_DI_Loading_Data_From_Resources.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            builder.Services.AddSingleton<CountryLoader,LoadingService>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
