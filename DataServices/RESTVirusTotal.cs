using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTVirusTotal : IVirusTotal
	{
		private readonly HttpClient _httpClient;

		private readonly string keyAPI = "32cc1e430fa3955c9c0d9faea60ed012b1ef1a17b73fd766a555899f00498c95";

		public RESTVirusTotal(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public string GetBaseUrl()
		{
			return _httpClient.BaseAddress.ToString();
		}

		public async Task<VirusTotalDto> GetSearchResponse(string ip)
		{
			return await _httpClient.GetFromJsonAsync<VirusTotalDto>($"ip-address/report?apikey={keyAPI}&ip={ip}");
		}
	}
}
