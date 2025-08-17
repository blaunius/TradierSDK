using Tradier.Model;

namespace Tradier.Response
{
    public class MarketClockResponse : TradierResponse
    {
        public Clock? Clock { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}