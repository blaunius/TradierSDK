#nullable disable
namespace Tradier
{
    public static class TradierConfig
    {
        private static bool IsUsingSandboxAndLiveClients = false;
        internal static ITradierClient DefaultClient
        {
            get
            {
                if (IsUsingSandboxAndLiveClients)
                    throw new InvalidOperationException("You cannot implicitly use both the Sandbox Client and the Live client in the same application. To use both, please explicitly pass in the client you want to use in each service.");
                else if (defaultClient is null)
                    throw new NotImplementedException("The default Tradier Client is not implemented. Please create an instance of the client before using any services.");
                return defaultClient;
            }
            set
            {
                if (!IsUsingSandboxAndLiveClients && defaultClient != null && value != null)
                {
                    if (defaultClient.GetType() != value.GetType())
                        IsUsingSandboxAndLiveClients = true;
                }
                defaultClient = value;
            }
        }
        private static ITradierClient defaultClient;
        public static string AccessToken { get; set; }
        public static string RedirectUri { get; set; }
    }
}
#nullable restore