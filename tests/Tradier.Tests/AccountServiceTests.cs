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
            var id = myProfile.Profile.Id;
            var myBalance = await service.GetBalances(id);
            var myPositions = await service.GetPositions(id);

            Assert.Fail();
        }
    }
}
#nullable restore