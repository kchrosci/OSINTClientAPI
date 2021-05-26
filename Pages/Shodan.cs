using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class Shodan
	{
		[Inject]
		IShodanSearch ShodanData { get; set; }

		private ShodanDto[] shodan;


		protected override async Task OnInitializedAsync()
		{
			shodan = await ShodanData.GetQueryResponse();
		}
	}
}
