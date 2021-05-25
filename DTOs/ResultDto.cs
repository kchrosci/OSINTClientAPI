using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
	public class ResultDto
	{
		//[JsonPropertyName("anwsers")]
		//public string Id { get; set; }
		//[JsonPropertyName("is_tentative")]
		//public bool IsTentative { get; set; }
		//[JsonPropertyName("launch_date_local")]
		//public DateTimeOffset LaunchDateLocal { get; set; }
		[JsonPropertyName("total")]
		public string Total { get; set; }
	}
}
