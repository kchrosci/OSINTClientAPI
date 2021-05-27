using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class WaybackMachine
	{
		[Inject]
		IWaybackMachine WaybackMachineService { get; set; }
		string Url { get; set; }
		string Timestamp { get; set; }
		private WaybackDto wayback;

		protected async Task BeginSearch()
		{
			if (Timestamp == "")
			{
				wayback = await WaybackMachineService.GetSearchResponse(Url);
			}
			else
			{
				wayback = await WaybackMachineService.GetSearchResponse(Url, Timestamp);
			}
		}
		protected async Task SaveToTxt()
		{

		}
	}
}
