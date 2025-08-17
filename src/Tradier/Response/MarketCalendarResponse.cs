using System.Globalization;

namespace Tradier.Response
{
    public class MarketCalendarResponse : TradierResponse
    {
        public Calendar? Calendar { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}