using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
	public class SecurityTrialsDto
	{
		[JsonPropertyName("success")]
		public bool Success { get; set; }
	}
}
