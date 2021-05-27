using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OSINTClientAPI.DTOs
{
    public partial class TestCatsDto
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
