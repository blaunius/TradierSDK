using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class Quote
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("exch")]
        public string? Exch { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("last")]
        public double? Last { get; set; }

        [JsonProperty("change")]
        public double? Change { get; set; }

        [JsonProperty("volume")]
        public int? Volume { get; set; }

        [JsonProperty("open")]
        public double? Open { get; set; }

        [JsonProperty("high")]
        public double? High { get; set; }

        [JsonProperty("low")]
        public double? Low { get; set; }

        [JsonProperty("close")]
        public object? Close { get; set; }

        [JsonProperty("bid")]
        public double? Bid { get; set; }

        [JsonProperty("ask")]
        public double? Ask { get; set; }

        [JsonProperty("change_percentage")]
        public double? ChangePercentage { get; set; }

        [JsonProperty("average_volume")]
        public int? AverageVolume { get; set; }

        [JsonProperty("last_volume")]
        public int? LastVolume { get; set; }

        [JsonProperty("trade_date")]
        public long? TradeDate { get; set; }

        [JsonProperty("prevclose")]
        public double? Prevclose { get; set; }

        [JsonProperty("week_52_high")]
        public double? Week52High { get; set; }

        [JsonProperty("week_52_low")]
        public double? Week52Low { get; set; }

        [JsonProperty("bidsize")]
        public int? Bidsize { get; set; }

        [JsonProperty("bidexch")]
        public string? Bidexch { get; set; }

        [JsonProperty("bid_date")]
        public object? BidDate { get; set; }

        [JsonProperty("asksize")]
        public int? Asksize { get; set; }

        [JsonProperty("askexch")]
        public string? Askexch { get; set; }

        [JsonProperty("ask_date")]
        public object? AskDate { get; set; }

        [JsonProperty("root_symbols")]
        public string? RootSymbols { get; set; }

        [JsonProperty("underlying")]
        public string? Underlying { get; set; }

        [JsonProperty("strike")]
        public double? Strike { get; set; }

        [JsonProperty("open_interest")]
        public int? OpenInterest { get; set; }

        [JsonProperty("contract_size")]
        public int? ContractSize { get; set; }

        [JsonProperty("expiration_date")]
        public string? ExpirationDate { get; set; }

        [JsonProperty("expiration_type")]
        public string? ExpirationType { get; set; }

        [JsonProperty("option_type")]
        public string? OptionType { get; set; }

        [JsonProperty("root_symbol")]
        public string? RootSymbol { get; set; }
    }

}
