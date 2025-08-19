namespace Tradier.Request
{
    public class  AccountHistoryRequest : PaginationRequest
    {
        /// <summary>
        /// Activity type
        /// </summary>
        public override string? Type => ActivityType.ToString().ToLowerInvariant();
        public Enumerations.ActivityType ActivityType { get; set; }
        /// <summary>
        /// Filter by security symbol
        /// </summary>
        public string? Symbol { get; set; }
        /// <summary>
        /// Filter using the exact match
        /// </summary>
        public bool ExactMatch { get; set; }

        public override string ParseQueryString()
        {
            string rtn = base.ParseQueryString();
            if (!string.IsNullOrWhiteSpace(Symbol))
            {
                rtn += string.IsNullOrWhiteSpace(rtn) ? "" : "&";
                rtn += $"symbol={Symbol}";
            }
            if (ExactMatch)
            {
                rtn += string.IsNullOrWhiteSpace(rtn) ? "" : "&";
                rtn += "exact=true";
            }
            return rtn;
        }
    }
}
