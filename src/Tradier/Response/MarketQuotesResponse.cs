using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Tradier.Model;

namespace Tradier.Response
{
    public class MarketQuotesResponse : TradierResponse
    {
        [JsonPropertyName("quotes")]
        public QuotesContainer? Quotes { get; set; }

        public class QuotesContainer
        {
            [JsonPropertyName("quote")]
            public List<Quote> Quote { get; set; } = new();
        }


        internal override void Deserialize()
        {
            this.Quotes = System.Text.Json.JsonSerializer.Deserialize<MarketQuotesResponse>(this.RawResponse)?.Quotes ?? new();
        }
    }
}
