using Tradier.Model;

namespace Tradier.Response
{
    public class MarketSearchCompaniesResponse : TradierResponse
    {
        public List<Security>? Securities { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}