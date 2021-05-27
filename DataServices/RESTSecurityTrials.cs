using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTSecurityTrials : ISecurityTrials
	{
		private readonly HttpClient _httpClient;

		public RESTSecurityTrials(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public string GetBaseUrl()
		{
			return _httpClient.BaseAddress.ToString();
		}
		public async Task<SecurityTrialsDto> GetSearchResponse()
		{
			 _httpClient.DefaultRequestHeaders.Add("APIKEY", "wo3k4kCRx4XrOO2Tt8cySSE12UuuWdwb");
			return await _httpClient.GetFromJsonAsync<SecurityTrialsDto>($"ping");
		}
	}
}
