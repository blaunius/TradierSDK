using Newtonsoft.Json;

namespace Tradier.Models
{
    public class Journal
    {
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }
    }
}
