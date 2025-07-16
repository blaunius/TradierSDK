namespace Tradier.Request
{
    public class QueryRequestParameters
    {
        /// <summary>
        /// Used for paginated results. Page to start results.
        /// </summary>
        public string? Page { get; set; }
        /// <summary>
        /// Number of results to return per page.
        /// </summary>
        public string? Limit { get; set; }
        public virtual string? Type { get; set; }
        /// <summary>
        /// Start date, yyyy-mm-dd format
        /// </summary>
        public string? Start { get; set; }
        /// <summary>
        /// End date, yyyy-mm-dd format
        /// </summary>
        public string? End { get; set; }
        public virtual string ParseQueryString()
        {
            throw new NotImplementedException(nameof(ParseQueryString));
        }
    }
}
