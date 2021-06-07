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

			builder.Services.AddHttpClient<IShodanSearch, RESTShodanSearch>
				(client =>
				{
					client.BaseAddress = new Uri("https://api.shodan.io/");
				});

			builder.Services.AddHttpClient<IWaybackMachine, RESTWaybackMachine>
				(client =>
				{
					client.BaseAddress = new Uri("https://archive.org/");
				});

			builder.Services.AddHttpClient<ITestCats, RESTTestCats>
				(client =>
				{
					client.BaseAddress = new Uri("https://cat-fact.herokuapp.com/");
				});

			builder.Services.AddHttpClient<IVirusTotal, RESTVirusTotal>
				(client =>
				{
					client.BaseAddress = new Uri("https://www.virustotal.com/vtapi/v2/");

				});

			builder.Services.AddHttpClient<ISecurityTrials, RESTSecurityTrials>
				(client =>
				{

					client.BaseAddress = new Uri("https://api.securitytrails.com/v1/");

				});

			await builder.Build().RunAsync();
		}
	}
}
