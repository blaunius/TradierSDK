using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Account
    {
        [JsonProperty("account_number")]
        public string? AccountNumber { get; set; }

        [JsonProperty("classification")]
        public string? Classification { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("day_trader")]
        public bool? DayTrader { get; set; }

        [JsonProperty("option_level")]
        public int? OptionLevel { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("last_update_date")]
        public DateTime? LastUpdateDate { get; set; }
    }
}
