using Tradier.Model;

namespace Tradier.Response
{
    public class MarketHistoricalQuotesResponse : TradierResponse
    {
        public List<HistoricalQuote>? Quotes { get; set; }
        internal string? quotes { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
        
    }
}