using Tradier.Enumerations;

namespace Tradier.Request
{
    public class TimeAndSalesOptions
    {
        public IntervalScope Interval { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public SessionFilter Session { get; set; }
    }
}