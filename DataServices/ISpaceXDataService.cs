using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public interface ISpaceXDataService
	{
		Task<LaunchDto[]> GetAllLaunches();
	}
}
