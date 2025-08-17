using Tradier.Enumerations;

namespace Tradier.Request
{
    public class MarketTimeAndSalesRequest
    {
        public IntervalScope Interval { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public SessionFilter Session { get; set; }
        public string ParseQuery()
        {
            string rtn = $"interval={Interval.ToString().ToLower()}&session_filter={Session.ToString().ToLower()}";
            if (Start != null)
            {
                rtn += $"&start={Start.Value:yyyy-MM-dd}";
            }
            if (End != null)
            {
                rtn += $"&end={End.Value:yyyy-MM-dd}";
            }
            return rtn;
        }
    }
}