using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Event
    {
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("trade")]
        public Trade? Trade { get; set; }

        [JsonProperty("adjustment")]
        public Adjustment? Adjustment { get; set; }

        [JsonProperty("option")]
        public Option? Option { get; set; }

        [JsonProperty("journal")]
        public Journal? Journal { get; set; }
    }
}
