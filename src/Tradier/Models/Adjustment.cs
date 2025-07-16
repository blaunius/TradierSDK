using Newtonsoft.Json;

namespace Tradier.Models
{
    public class Adjustment
    {
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }
    }
}
