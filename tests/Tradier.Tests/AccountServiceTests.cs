using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tradier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tradier.Services;
#nullable disable
namespace Tradier.Tests
{
    [TestClass()]
    public class AccountServiceTests : Initializer
    {
        private AccountService service;
        [TestInitialize()]
        public void SetService()
        {
            service = new AccountService(Client);
        }

        [TestMethod()]
        public async Task TradierClientTest()
        {
            var myProfile = await service.GetUserProfile();
            var test2 = await service.GetBalances(myProfile.Profile.Id);
            Assert.Fail();
        }
    }
}
#nullable restore