using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Pdt
    {
        [JsonProperty("fed_call")]
        public int? FedCall { get; set; }

        [JsonProperty("maintenance_call")]
        public int? MaintenanceCall { get; set; }

        [JsonProperty("option_buying_power")]
        public double? OptionBuyingPower { get; set; }

        [JsonProperty("stock_buying_power")]
        public double? StockBuyingPower { get; set; }

        [JsonProperty("stock_short_value")]
        public int? StockShortValue { get; set; }
    }
}
