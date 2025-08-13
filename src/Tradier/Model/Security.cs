using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class Security
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("exchange")]
        public virtual string? Exchange { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
