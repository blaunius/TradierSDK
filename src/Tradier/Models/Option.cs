using Newtonsoft.Json;

namespace Tradier.Models
{
    public class Option
    {
        [JsonProperty("option_type")]
        public string? OptionType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }
    }
}
