using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
	public partial class ShodanDto
	{
		[JsonPropertyName("country_code")]
		public string CountryCode { get; set; }

		[JsonPropertyName("country_name")]
		public string CountryName { get; set; }
	}
}
