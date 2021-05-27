using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class VirusTotal
	{
		[Inject]
		IVirusTotal VirusTotalService { get; set; }
		string IpAddress { get; set; }

		private VirusTotalDto virus;

		protected async Task BeginSearch()
		{
			virus = await VirusTotalService.GetSearchResponse(IpAddress);
		}

		protected async Task SaveToTxt()
		{

		}
	}
}
