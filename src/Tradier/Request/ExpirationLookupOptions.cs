namespace Tradier.Request
{
    public class ExpirationLookupOptions
    {
        public bool IncludeAllRoots { get; set; }
        public bool ShowStrikes { get; set; }
        public bool ShowContractSize { get; set; }
        public bool ShowExpirationType { get; set; }
    }
}