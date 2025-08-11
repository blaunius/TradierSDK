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
        internal static bool IsSandboxActive { get; set; }
        public static string AccessToken { get; set; }
        public static string AccessTokenSandbox { get; set; }
        public static string RedirectUri { get; set; }
    }
}
#nullable restore