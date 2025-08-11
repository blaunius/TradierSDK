using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tradier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Tradier.Tests
{
    [TestClass()]
    public class TradierClientTests
    {
        public TradierClient client { get; set; }
        public TradierSandboxClient sandboxClient { get; set; }

        [TestInitialize()]
        public void Init()
        {
            TradierConfig.RedirectUri = "https://localhost:5001/tradier-client/callback";
            TradierConfig.AccessToken = "AccessToken";
            client = new TradierClient();
            sandboxClient = new TradierSandboxClient();
        }

        [TestMethod()]
        public async Task TradierClientTest()
        {
            var myProfile = await new Services.AccountService(sandboxClient).GetUserProfile();
            Assert.Fail();
        }
    }
}
#nullable restore