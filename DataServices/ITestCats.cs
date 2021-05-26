using OSINTClientAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSINTClientAPI.DataServices
{
	public interface ITestCats
	{
		public Task<TestCatsDto[]>GetCatInfo();
	}
}
