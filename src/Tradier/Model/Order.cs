using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Order
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("side")]
        public string? Side { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("duration")]
        public string? Duration { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("avg_fill_price")]
        public double? AvgFillPrice { get; set; }

        [JsonProperty("exec_quantity")]
        public double? ExecQuantity { get; set; }

        [JsonProperty("last_fill_price")]
        public double? LastFillPrice { get; set; }

        [JsonProperty("last_fill_quantity")]
        public double? LastFillQuantity { get; set; }

        [JsonProperty("remaining_quantity")]
        public double? RemainingQuantity { get; set; }

        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("transaction_date")]
        public DateTime? TransactionDate { get; set; }

        [JsonProperty("class")]
        public string? Class { get; set; }
    }
}
