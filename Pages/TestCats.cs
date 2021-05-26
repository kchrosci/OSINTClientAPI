using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class TestCats
	{
		[Inject]
		ITestCats TestCatsService { get; set; }

		private TestCatsDto[] cats;

		protected override async Task OnInitializedAsync()
		{
			cats = await TestCatsService.GetCatInfo();
		}
	}
}
