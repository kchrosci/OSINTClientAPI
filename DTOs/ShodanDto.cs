using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
    public partial class ShodanDto
    {
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }

		[JsonPropertyName("country_name")]
		public string CountryName { get; set; }

		[JsonPropertyName("country_code")]
		public string CountryCode { get; set; }

		[JsonPropertyName("city")]
		public string City { get; set; }

		[JsonPropertyName("last_update")]
		public DateTimeOffset LastUpdate { get; set; }

		[JsonPropertyName("latitude")]
		public double Latitude { get; set; }

		[JsonPropertyName("hostnames")]
		public string[] Hostnames { get; set; }

		//[JsonPropertyName("org")]
		//public string Org { get; set; }

		//[JsonPropertyName("asn")]
		//public string Asn { get; set; }

		//[JsonPropertyName("isp")]
		//public string Isp { get; set; }

		//[JsonPropertyName("longitude")]
		//public double Longitude { get; set; }

		//[JsonPropertyName("country_code3")]
		//public object CountryCode3 { get; set; }

		//[JsonPropertyName("domains")]
		//public string[] Domains { get; set; }

		//[JsonPropertyName("ip_str")]
		//public string IpStr { get; set; }

		//[JsonPropertyName("os")]
		//public object Os { get; set; }

		//[JsonPropertyName("ports")]
		//public long[] Ports { get; set; }
	}
}
