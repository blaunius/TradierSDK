using Tradier.Model;

namespace Tradier.Response
{
    public class MarketTimeAndSalesResponse : TradierResponse
    {
        public List<TimeAndSales>? TimeAndSales { get; set; }
        internal string? timesales { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}