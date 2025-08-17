using Tradier.Model;

namespace Tradier.Response
{
    public class MarketOptionExpirationResponse : TradierResponse
    {
        public List<Expiration>? Expirations { get; set; }
        internal string? expirations { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}