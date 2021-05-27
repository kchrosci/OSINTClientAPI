using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public interface ISecurityTrials
	{
		Task<SecurityTrialsDto> GetSearchResponse();
		public string GetBaseUrl();
	}
}
