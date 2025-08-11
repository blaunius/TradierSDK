namespace Tradier.Request
{
    public class  GetHistoryRequestOptions : PaginationRequest
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
    }
}
