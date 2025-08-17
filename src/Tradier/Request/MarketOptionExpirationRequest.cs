namespace Tradier.Request
{
    public class MarketOptionExpirationRequest
    {
        public bool IncludeAllRoots { get; set; }
        internal string includeAllRoots => IncludeAllRoots ? "true" : "false";
        public bool ShowStrikes { get; set; }
        internal string showStrikes => ShowStrikes ? "true" : "false";
        public bool ShowContractSize { get; set; }
        internal string showContractSize => ShowContractSize ? "true" : "false";
        public bool ShowExpirationType { get; set; }
        internal string showExpirationType => ShowExpirationType ? "true" : "false";
    }
}