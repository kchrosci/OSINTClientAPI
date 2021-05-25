using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public class RESTGoogleSearch : IGoogleSearch
	{
		private readonly HttpClient _httpClient;

		public RESTGoogleSearch(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<ResultDto[]> GetQueryResponse()
		{
			return await _httpClient.GetFromJsonAsync<ResultDto[]>("q=elon+musk&num=100");
		}
	}
}
