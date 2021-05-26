using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTShodanSearch : IShodanSearch
	{
		private readonly HttpClient _httpClient;

		public RESTShodanSearch(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<ShodanDto[]> GetQueryResponse()
		{
			return await _httpClient.GetFromJsonAsync<ShodanDto[]>("/shodan/host/8.8.8.8?key=OOJcF5sGJFFAjbNju2XFYFSAT9JbPo20");
		}
	}
}
