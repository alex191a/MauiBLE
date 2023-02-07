using BluetoothLE.Core;
#if ANDROID
using BluetoothLE.Droid;
#elif IOS
using MauiBLE.Platforms.iOS.bluetooth;
#elif MACCATALYST
using BluetoothLE.iOS
#endif


namespace MauiBLE;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		DependencyService.Register<IAdapter, Adapter>();

        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		
       

        return builder.Build();
	}
}
