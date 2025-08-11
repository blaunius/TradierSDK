using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class TimeAndSales
    {
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("open")]
        public double? Open { get; set; }

        [JsonProperty("high")]
        public double? High { get; set; }

        [JsonProperty("low")]
        public double? Low { get; set; }

        [JsonProperty("close")]
        public double? Close { get; set; }

        [JsonProperty("volume")]
        public int? Volume { get; set; }

        [JsonProperty("vwap")]
        public double? VWAP { get; set; }
    }
}
