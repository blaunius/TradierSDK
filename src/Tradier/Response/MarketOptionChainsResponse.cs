using Tradier.Model;

namespace Tradier.Response
{
    public class MarketOptionChainsResponse : TradierResponse
    {
        public List<Option>? Options { get; set; }
        internal string? options { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}