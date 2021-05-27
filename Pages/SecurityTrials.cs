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


		protected override async Task OnInitializedAsync()
		{
			security = await SecurityTrialsService.GetSearchResponse();
		}

		protected async Task SaveToTxt()
		{

		}
	}
}
