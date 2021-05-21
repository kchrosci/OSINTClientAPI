using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTSpaceXDataService : ISpaceXDataService
	{
		private readonly HttpClient _httpClient;

		public RESTSpaceXDataService(HttpClient httpclient)
		{
			_httpClient = httpclient;
		}

		public async Task<LaunchDto[]> GetAllLaunches()
		{
			return  await _httpClient.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");
		}
	}
}
