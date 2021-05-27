using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTWaybackMachine : IWaybackMachine
	{
		private readonly HttpClient _httpClient;

		public RESTWaybackMachine(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public string GetBaseUrl()
		{
			return _httpClient.BaseAddress.ToString();
		}
		public async Task<WaybackDto> GetSearchResponse(string url, string timestamp)
		{
			return await _httpClient.GetFromJsonAsync<WaybackDto>($"wayback/available?url={url}&timestamp={timestamp}");
		}

		public async Task<WaybackDto> GetSearchResponse(string url)
		{
			return await _httpClient.GetFromJsonAsync<WaybackDto>($"wayback/available?url={url}");
		}
	}
}
