using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Tradier
{
    public static class TradierConfig
    {
        private static bool IsUsingSandboxAndLiveClients = false;
        private static ITradierClient defaultClient;
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
        public static string AccessToken { get; set; }
        public static string RedirectUri { get; set; }
    }
}
#nullable restore