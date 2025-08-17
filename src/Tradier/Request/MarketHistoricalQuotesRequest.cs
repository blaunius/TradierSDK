namespace Tradier.Request
{
    public class MarketHistoricalQuotesRequest
    {
        public Enumerations.IntervalType Interval { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        /// <summary>
        /// Specify to retrieve aggregate data for all hours of the day (All) or only regular trading sessions (Open)
        /// </summary>
        public Enumerations.SessionFilter SessionFilter { get; set; }
        internal string ParseQuery()
        {
            string rtn = $"interval={Interval.ToString().ToLower()}&session_filter={SessionFilter.ToString().ToLower()}";
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