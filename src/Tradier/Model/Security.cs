using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class Security
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("exchange")]
        public virtual string? Exchange { get; set; }
        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
