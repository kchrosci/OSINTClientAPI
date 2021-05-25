using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OSINTClientAPI.DataServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OSINTClientAPI
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.spacex.land/")});

			builder.Services.AddHttpClient<ISpaceXDataService, RESTSpaceXDataService>
				(sp => sp.BaseAddress = new Uri("https://api.spacex.land/"));
			await builder.Build().RunAsync();

			//builder.Services.AddHttpClient<ISpaceXDataService, RESTSpaceXDataService>
			//	(sp => sp.BaseAddress = new Uri("https://google-search3.p.rapidapi.com/api/v1/search/"));
			//await builder.Build().RunAsync();
		}
	}
}
