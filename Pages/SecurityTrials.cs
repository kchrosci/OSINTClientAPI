using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class SecurityTrials
	{
		[Inject]
		ISecurityTrials SecurityTrialsService { get; set; }

		private SecurityTrialsDto security;
		string IpAddress { get; set; }


		protected async Task BeginSearch()
		{
			security = await SecurityTrialsService.GetSearchResponse();
		}

		protected async Task SaveToTxt()
		{

		}
	}
}
