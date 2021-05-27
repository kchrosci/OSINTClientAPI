using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
	public class WaybackDto
	{
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("archived_snapshots")]
        public ArchivedSnapshots ArchivedSnapshots { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
    public partial class ArchivedSnapshots
    {
        [JsonPropertyName("closest")]
        public Closest Closest { get; set; }
    }

    public partial class Closest
    {
        [JsonPropertyName("status")]
        public long Status { get; set; }

        [JsonPropertyName("available")]
        public bool Available { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
