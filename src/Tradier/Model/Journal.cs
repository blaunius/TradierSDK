using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Journal
    {
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }
    }
}
