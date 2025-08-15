namespace Tradier.Request
{
    public class GainLossOptions : PaginationRequest
    {
        public Enumerations.SortResult? SortBy { get; set; }
        public Enumerations.SortDirection? Sort { get; set; }
        public string? Symbol { get; set; }
        public override string ParseQueryString()
        {
            return string.Join("&", new[]
            {
                base.ParseQueryString(),
                SortBy.HasValue ? $"sort_by={SortBy.Value.ToString().ToLowerInvariant()}" : null,
                Sort.HasValue ? $"sort={Sort.Value.ToString().ToLowerInvariant()}" : null,
                !string.IsNullOrWhiteSpace(Symbol) ? $"symbol={Symbol}" : null
            }.Where(x => x != null));
        }
    }
}
