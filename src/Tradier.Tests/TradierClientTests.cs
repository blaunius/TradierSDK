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

        [TestInitialize()]
        public void Init()
        {
            client = new TradierClient();
        }

        [TestMethod()]
        public async Task TradierClientTest()
        {
            var myProfile = await new Services.AccountService(client).GetUserProfile();
            Assert.Fail();
        }
    }
}
#nullable restore