using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Trade
    {
        [JsonProperty("commission")]
        public double? Commission { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("trade_type")]
        public string? TradeType { get; set; }
    }
}
