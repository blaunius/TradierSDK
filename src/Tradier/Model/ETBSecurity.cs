using Newtonsoft.Json;

namespace Tradier.Model
{
    public class ETBSecurity
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("exchange")]
        public string? Exchange { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}