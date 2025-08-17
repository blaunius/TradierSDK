using Tradier.Model;

namespace Tradier.Response
{
    public class MarketETBSecuritiesResponse : TradierResponse
    {
        public List<ETBSecurity>? ETBSecurities { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}