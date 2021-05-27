using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
	public class VirusTotalDto
	{
        [JsonPropertyName("response_code")]
        public long ResponseCode { get; set; }

        [JsonPropertyName("as_owner")]
        public string AsOwner { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("verbose_msg")]
        public string VerboseMsg { get; set; }

        [JsonPropertyName("asn")]
        public long Asn { get; set; }
    }
}
