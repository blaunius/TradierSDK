using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class MarketHistoricalQuotesResponse : TradierResponse
    {
        [JsonPropertyName("history")]
        public HistoricalQuoteContainer? Data { get; set; }
        public class HistoricalQuoteContainer
        {
            [JsonPropertyName("day")]
            public List<HistoricalQuote>? Quotes { get; set; }
        }
        internal override void Deserialize()
        {
            this.Data = System.Text.Json.JsonSerializer.Deserialize<MarketHistoricalQuotesResponse>(this.RawResponse)?.Data;
        }

    }
}