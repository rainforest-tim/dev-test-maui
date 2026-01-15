using GeoDraw.App.Services;
using GeoDraw.App.ViewModels;
using Microsoft.Extensions.Logging;

namespace GeoDraw.App
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .Services
                    .AddTransient<MainPageViewModel>()
                    .AddSingleton<IObjectSelectionService, MockObjectSelectionService>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
