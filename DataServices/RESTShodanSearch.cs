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
		private readonly string key = "OOJcF5sGJFFAjbNju2XFYFSAT9JbPo20";

		public RESTShodanSearch(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public string GetBaseUrl()
		{
			return _httpClient.BaseAddress.ToString();
		}
		public async Task<ShodanDto> GetSearchResponse(string ip)
		{
			return await _httpClient.GetFromJsonAsync<ShodanDto>($"shodan/host/{ip}?key={key}");
		}

		public async Task<UserDto> GetUserResponse()
		{
			return await _httpClient.GetFromJsonAsync<UserDto>($"tools/httpheaders?key={key}");
		}
	}
}
