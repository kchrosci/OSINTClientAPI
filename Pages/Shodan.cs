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
		string IpAddress { get; set; }
		private ShodanDto shodan;


		protected async Task BeginSearch()
		{	
			shodan = await ShodanData.GetSearchResponse(IpAddress);
		}
	}
}
