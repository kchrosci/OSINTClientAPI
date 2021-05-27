using OSINTClientAPI.DTOs;
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

		public string GetBaseUrl()
		{
			return _httpClient.BaseAddress.ToString();
		}

		public async Task<TestCatsDto[]> GetCatInfo()
		{
			return await _httpClient.GetFromJsonAsync<TestCatsDto[]>("facts/random?animal_type=cat&amount=8");
		}
	}
}
