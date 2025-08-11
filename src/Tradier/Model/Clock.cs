using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Clock
    {
        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; }

        [JsonProperty("next_change")]
        public string? NextChange { get; set; }

        [JsonProperty("next_state")]
        public string? NextState { get; set; }
    }
}