using Tradier.Enumerations;

namespace Tradier.Request
{
    public class MarketTimeAndSalesRequest
    {
        public IntervalScope Interval { get; set; }
        private string interval
        {
            get
            {
                if (Interval == IntervalScope.OneMinute)
                    return "1min";
                if (Interval == IntervalScope.FiveMinutes)
                    return "5min";
                if (Interval == IntervalScope.FifteenMinutes)
                    return "15min";
                return Interval.ToString().ToLower();
            }
        }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public SessionFilter Session { get; set; }
        public string ParseQuery()
        {
            string rtn = $"interval={interval}&session_filter={Session.ToString().ToLower()}";
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