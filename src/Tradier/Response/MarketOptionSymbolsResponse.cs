using Tradier.Model;

namespace Tradier.Response
{
    public class MarketOptionSymbolsResponse : TradierResponse
    {
        public List<OptionSymbol>? Symbols { get; set; }
        internal string? symbols { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}