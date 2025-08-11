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
    public class TradierClientTests : Initializer
    {
        [TestMethod()]
        public async Task TradierClientTest()
        {
            var myProfile = await new Services.AccountService(Client).GetUserProfile();
            Assert.Fail();
        }
    }
}
#nullable restore