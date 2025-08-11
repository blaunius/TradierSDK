using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Tradier
{
    public class TradierSandboxClient : TradierClient
    {
        public override string AccessToken => TradierConfig.AccessTokenSandbox;
        public override string BaseAddress => "https://sandbox.tradier.com/v1/";
        public override string StreamAddress => throw new NotImplementedException("Sandbox environment does not support streaming.");
        public TradierSandboxClient() : base() { }
        public TradierSandboxClient(HttpClient client) : base(client) { }
    }
}
#nullable restore
