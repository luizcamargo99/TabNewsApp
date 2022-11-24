using Microsoft.Extensions.Logging;
using TabNewsApp.Data;
using TabNewsApp.Interfaces;
using TabNewsApp.Services;

namespace TabNewsApp;

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

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddScoped<IHttpService, HttpService>();
        builder.Services.AddScoped<IContentService, ContentService>();
        builder.Services.AddScoped<ITabDateService, TabDateService>();

        return builder.Build();
	}
}
