global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;

global using TinyMvvm;
global using Microsoft.Extensions.Logging;

global using SpotifyProject.Views;
global using SpotifyProject.ViewModels;

global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using Microsoft.Maui.Controls;
global using Microsoft.Extensions.Logging;

global using CommunityToolkit;
global using System.Text.Json.Serialization;
global using System;
global using System.Net;
global using System.Text;
global using System.Text.Json;
global using System.Windows.Input;
global using System.Collections.ObjectModel;
global using CommunityToolkit.Maui;

namespace SpotifyProject;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMediaElement()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
      
#if DEBUG
        builder.Logging.AddDebug();
#endif
		builder.Services.AddTransient<LoginView>();
		builder.Services.AddTransient<LoginViewModel>();

		return builder.Build();
	}
}
