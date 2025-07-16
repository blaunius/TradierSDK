namespace Tradier.Request
{
    public class QueryGainLossParameters : QueryRequestParameters
    {
        public Enumerations.SortResult? SortBy { get; set; }
        public Enumerations.SortDirection? Sort { get; set; }
        public string? Symbol { get; set; }
    }
}
