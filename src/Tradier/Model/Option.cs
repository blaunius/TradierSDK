using System.Text.Json.Serialization;

namespace Tradier.Model
{
    public class Option
    {
        [JsonPropertyName("option_type")]
        public string? OptionType { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }
    }
}
