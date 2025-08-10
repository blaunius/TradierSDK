using Newtonsoft.Json;

namespace Tradier.Model
{
    public class ClosedPosition
    {
        [JsonProperty("close_date")]
        public DateTime? CloseDate { get; set; }

        [JsonProperty("cost")]
        public double? Cost { get; set; }

        [JsonProperty("gain_loss")]
        public double? GainLoss { get; set; }

        [JsonProperty("gain_loss_percent")]
        public double? GainLossPercent { get; set; }

        [JsonProperty("open_date")]
        public DateTime? OpenDate { get; set; }

        [JsonProperty("proceeds")]
        public double? Proceeds { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("term")]
        public int? Term { get; set; }
    }
}
