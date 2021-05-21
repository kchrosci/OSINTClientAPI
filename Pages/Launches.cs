using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class Launches
	{


		[Inject]
		ISpaceXDataService SpaceXDataService { get; set; }

		private LaunchDto[] launches;


		protected override async Task OnInitializedAsync()
		{
			launches = await SpaceXDataService.GetAllLaunches();
		}
	}
}
