using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class FetchData
	{	
		[Inject]
		private HttpClient Http { get; set; }  

		private LaunchDto[] launches;

		protected override async Task OnInitializedAsync()
		{
			launches = await Http.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");
		}
	}
}
