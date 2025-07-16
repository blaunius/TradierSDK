using Newtonsoft.Json;

namespace Tradier.Models
{
    public class Cash
    {
        [JsonProperty("cash_available")]
        public double? CashAvailable { get; set; }

        [JsonProperty("sweep")]
        public int? Sweep { get; set; }

        [JsonProperty("unsettled_funds")]
        public double? UnsettledFunds { get; set; }
    }
}
