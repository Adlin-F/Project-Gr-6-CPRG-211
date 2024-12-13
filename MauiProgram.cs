using Microsoft.EntityFrameworkCore; 
using MauiApp1.Models; 
using Microsoft.Extensions.Logging;

namespace MauiApp1
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

			builder.Services.AddMauiBlazorWebView();

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
#endif

			// Add the connection string for your SQL Server database
			var connectionString = "Server=SAIT225925\\SQLEXPRESS;Database=Lab9;User Id=sa;Password=123456;Encrypt=True;TrustServerCertificate=True;";


			// Register the DbContext with the connection string
			builder.Services.AddDbContext<Lab9DbContext>(options =>
	options.UseSqlServer(connectionString)
		   .EnableSensitiveDataLogging() // Logs parameters
		   .LogTo(Console.WriteLine));   // Logs queries to console


			return builder.Build();
		}
	}
}

