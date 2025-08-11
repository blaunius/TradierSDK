namespace Tradier.Request
{
    public class HistoricalQuotesLookupOptions
    {
        public Enumerations.IntervalType Interval { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        /// <summary>
        /// Specify to retrieve aggregate data for all hours of the day (All) or only regular trading sessions (Open)
        /// </summary>
        public Enumerations.SessionFilter SessionFilter { get; set; }
    }
}