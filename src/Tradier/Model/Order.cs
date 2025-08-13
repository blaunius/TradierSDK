using System.Text.Json.Serialization;

namespace Tradier.Model
{
    public class Order
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("side")]
        public string? Side { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("price")]
        public double? Price { get; set; }

        [JsonPropertyName("avg_fill_price")]
        public double? AvgFillPrice { get; set; }

        [JsonPropertyName("exec_quantity")]
        public double? ExecQuantity { get; set; }

        [JsonPropertyName("last_fill_price")]
        public double? LastFillPrice { get; set; }

        [JsonPropertyName("last_fill_quantity")]
        public double? LastFillQuantity { get; set; }

        [JsonPropertyName("remaining_quantity")]
        public double? RemainingQuantity { get; set; }

        [JsonPropertyName("create_date")]
        public DateTime? CreateDate { get; set; }

        [JsonPropertyName("transaction_date")]
        public DateTime? TransactionDate { get; set; }

        [JsonPropertyName("class")]
        public string? Class { get; set; }
    }
}
