using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class OptionChain
    {
        /// <summary>
        /// Option contract symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string? Symbol { get; init; }

        /// <summary>
        /// Description of the contract.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; init; }

        /// <summary>
        /// Exchange code.
        /// </summary>
        [JsonProperty("exch")]
        public string? Exch { get; init; }

        /// <summary>
        /// Security type (should be "option").
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; init; }

        /// <summary>
        /// Last traded price.
        /// </summary>
        [JsonProperty("last")]
        public decimal? Last { get; init; }

        /// <summary>
        /// Change in price from previous close.
        /// </summary>
        [JsonProperty("change")]
        public decimal? Change { get; init; }

        /// <summary>
        /// Trading volume.
        /// </summary>
        [JsonProperty("volume")]
        public long? Volume { get; init; }

        /// <summary>
        /// Opening price for the day.
        /// </summary>
        [JsonProperty("open")]
        public decimal? Open { get; init; }

        /// <summary>
        /// Highest price of the day.
        /// </summary>
        [JsonProperty("high")]
        public decimal? High { get; init; }

        /// <summary>
        /// Lowest price of the day.
        /// </summary>
        [JsonProperty("low")]
        public decimal? Low { get; init; }

        /// <summary>
        /// Closing price.
        /// </summary>
        [JsonProperty("close")]
        public decimal? Close { get; init; }

        /// <summary>
        /// Current bid price.
        /// </summary>
        [JsonProperty("bid")]
        public decimal? Bid { get; init; }

        /// <summary>
        /// Current ask price.
        /// </summary>
        [JsonProperty("ask")]
        public decimal? Ask { get; init; }

        /// <summary>
        /// Underlying security symbol.
        /// </summary>
        [JsonProperty("underlying")]
        public string? Underlying { get; init; }

        /// <summary>
        /// Strike price.
        /// </summary>
        [JsonProperty("strike")]
        public decimal? Strike { get; init; }

        /// <summary>
        /// Percentage change from previous close.
        /// </summary>
        [JsonProperty("change_percentage")]
        public decimal? ChangePercentage { get; init; }

        /// <summary>
        /// Average daily volume.
        /// </summary>
        [JsonProperty("average_volume")]
        public long? AverageVolume { get; init; }

        /// <summary>
        /// Volume of last trade.
        /// </summary>
        [JsonProperty("last_volume")]
        public long? LastVolume { get; init; }

        /// <summary>
        /// Trade date/time (epoch).
        /// </summary>
        [JsonProperty("trade_date")]
        public long? TradeDate { get; init; }

        /// <summary>
        /// Previous closing price.
        /// </summary>
        [JsonProperty("prevclose")]
        public decimal? PrevClose { get; init; }

        /// <summary>
        /// 52-week high price.
        /// </summary>
        [JsonProperty("week_52_high")]
        public decimal? Week52High { get; init; }

        /// <summary>
        /// 52-week low price.
        /// </summary>
        [JsonProperty("week_52_low")]
        public decimal? Week52Low { get; init; }

        /// <summary>
        /// Size of bid (in hundreds).
        /// </summary>
        [JsonProperty("bidsize")]
        public int? BidSize { get; init; }

        /// <summary>
        /// Bid exchange code.
        /// </summary>
        [JsonProperty("bidexch")]
        public string? BidExch { get; init; }

        /// <summary>
        /// Bid timestamp (epoch).
        /// </summary>
        [JsonProperty("bid_date")]
        public long? BidDate { get; init; }

        /// <summary>
        /// Size of ask (in hundreds).
        /// </summary>
        [JsonProperty("asksize")]
        public int? AskSize { get; init; }

        /// <summary>
        /// Ask exchange code.
        /// </summary>
        [JsonProperty("askexch")]
        public string? AskExch { get; init; }

        /// <summary>
        /// Ask timestamp (epoch).
        /// </summary>
        [JsonProperty("ask_date")]
        public long? AskDate { get; init; }

        /// <summary>
        /// Current open interest.
        /// </summary>
        [JsonProperty("open_interest")]
        public long? OpenInterest { get; init; }

        /// <summary>
        /// Contract size.
        /// </summary>
        [JsonProperty("contract_size")]
        public int? ContractSize { get; init; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        [JsonProperty("expiration_date")]
        public string? ExpirationDate { get; init; }

        /// <summary>
        /// Expiration type (e.g., standard, weekly).
        /// </summary>
        [JsonProperty("expiration_type")]
        public string? ExpirationType { get; init; }

        /// <summary>
        /// Option type (put or call).
        /// </summary>
        [JsonProperty("option_type")]
        public string? OptionType { get; init; }

        /// <summary>
        /// Root symbol.
        /// </summary>
        [JsonProperty("root_symbol")]
        public string? RootSymbol { get; init; }

        /// <summary>
        /// Option Greeks data.
        /// </summary>
        [JsonProperty("greeks")]
        public Greek? Greeks { get; init; }
    }
}
