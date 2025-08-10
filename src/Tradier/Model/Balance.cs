using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Balance
    {
        [JsonProperty("option_short_value")]
        public int? OptionShortValue { get; set; }

        [JsonProperty("total_equity")]
        public double? TotalEquity { get; set; }

        [JsonProperty("account_number")]
        public string? AccountNumber { get; set; }

        [JsonProperty("account_type")]
        public string? AccountType { get; set; }

        [JsonProperty("close_pl")]
        public double? ClosePl { get; set; }

        [JsonProperty("current_requirement")]
        public double? CurrentRequirement { get; set; }

        [JsonProperty("equity")]
        public int? Equity { get; set; }

        [JsonProperty("long_market_value")]
        public double? LongMarketValue { get; set; }

        [JsonProperty("market_value")]
        public double? MarketValue { get; set; }

        [JsonProperty("open_pl")]
        public double? OpenPl { get; set; }

        [JsonProperty("option_long_value")]
        public double? OptionLongValue { get; set; }

        [JsonProperty("option_requirement")]
        public int? OptionRequirement { get; set; }

        [JsonProperty("pending_orders_count")]
        public int? PendingOrdersCount { get; set; }

        [JsonProperty("short_market_value")]
        public int? ShortMarketValue { get; set; }

        [JsonProperty("stock_long_value")]
        public double? StockLongValue { get; set; }

        [JsonProperty("total_cash")]
        public double? TotalCash { get; set; }

        [JsonProperty("uncleared_funds")]
        public int? UnclearedFunds { get; set; }

        [JsonProperty("pending_cash")]
        public int? PendingCash { get; set; }

        [JsonProperty("margin")]
        public Margin? Margin { get; set; }

        [JsonProperty("cash")]
        public Cash? Cash { get; set; }

        [JsonProperty("pdt")]
        public Pdt? Pdt { get; set; }
    }
}
