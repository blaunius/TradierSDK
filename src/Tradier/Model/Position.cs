using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Position
    {
        [JsonProperty("cost_basis")]
        public double? CostBasis { get; set; }

        [JsonProperty("date_acquired")]
        public DateTime? DateAcquired { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }
    }
}
