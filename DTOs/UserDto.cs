using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
	public class UserDto
	{
        [JsonPropertyName("Content-Length")]
        public string ContentLength { get; set; }

        [JsonPropertyName("Cf-Visitor")]
        public string CfVisitor { get; set; }

        [JsonPropertyName("Accept-Encoding")]
        public string AcceptEncoding { get; set; }

        [JsonPropertyName("X-Forwarded-For")]
        public string XForwardedFor { get; set; }

        [JsonPropertyName("Host")]
        public string Host { get; set; }

        [JsonPropertyName("Cf-Request-Id")]
        public string CfRequestId { get; set; }

        [JsonPropertyName("User-Agent")]
        public string UserAgent { get; set; }

        [JsonPropertyName("Connection")]
        public string Connection { get; set; }

        [JsonPropertyName("X-Forwarded-Proto")]
        public string XForwardedProto { get; set; }

        [JsonPropertyName("Accept")]
        public string Accept { get; set; }

        [JsonPropertyName("Cdn-Loop")]
        public string CdnLoop { get; set; }

        [JsonPropertyName("Cf-Connecting-Ip")]
        public string CfConnectingIp { get; set; }

        [JsonPropertyName("Cf-Ray")]
        public string CfRay { get; set; }

        [JsonPropertyName("Content-Type")]
        public string ContentType { get; set; }
    }
}
