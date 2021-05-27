using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public interface IShodanSearch
	{
		Task<ShodanDto> GetSearchResponse(string ip);
		public string GetBaseUrl();
	}
}
