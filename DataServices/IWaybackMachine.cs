using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public interface IWaybackMachine
	{
		Task<WaybackDto> GetSearchResponse(string url, string timestamp);
		Task<WaybackDto> GetSearchResponse(string url);
		public string GetBaseUrl();
	}
}
