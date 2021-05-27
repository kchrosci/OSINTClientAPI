using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	interface IVirusTotal
	{
		public Task<VirusTotalDto> GetSearchResponse(string ip);
		public string GetBaseUrl();
	}
}
