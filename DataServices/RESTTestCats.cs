using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTTestCats : ITestCats
	{
		private readonly HttpClient _httpClient;

		public RESTTestCats(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		async Task<TestCatsDto[]> ITestCats.GetCatInfo()
		{
			return await _httpClient.GetFromJsonAsync<TestCatsDto[]>("facts/random?animal_type=cat&amount=2");
		}
	}
}
