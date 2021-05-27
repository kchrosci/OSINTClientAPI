using Microsoft.AspNetCore.Components;
using OSINTClientAPI.DataServices;
using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.Pages
{
	public partial class UserInfo
	{
		[Inject]
		IShodanSearch ShodanData { get; set; }

		private UserDto user;
	
		protected override async Task OnInitializedAsync()
		{
			user = await ShodanData.GetUserResponse();
		}
		
	}
}
