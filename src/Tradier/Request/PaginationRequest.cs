namespace Tradier.Request
{
    public class PaginationRequest
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
        /// Start date
        /// </summary>
        public DateTime? Start { get; set; }
        /// <summary>
        /// End date
        /// </summary>
        public DateTime? End { get; set; }
        public virtual string ParseQueryString()
        {
            var query = new List<string>();
            if (!string.IsNullOrWhiteSpace(Page))
                query.Add($"page={Page}");
            if (!string.IsNullOrWhiteSpace(Limit))
                query.Add($"limit={Limit}");
            if (Start.HasValue)
                query.Add($"start={Start.Value:yyyy-MM-dd}");
            if (End.HasValue)
                query.Add($"end={End.Value:yyyy-MM-dd}");
            if (!string.IsNullOrWhiteSpace(Type))
                query.Add($"type={Type}");
            return string.Join("&", query);
        }
    }
}
