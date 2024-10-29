using Microsoft.Extensions.Logging;
using PrototipoAppMovil.DataAccess;

namespace PrototipoAppMovil
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
                });
                
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddTransient<MainPage>();

            var dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
