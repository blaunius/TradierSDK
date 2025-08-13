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
            AssertResponse(myProfile);
            var id = myProfile.Profile.Id;

            var myBalance = await service.GetBalances(id);
            //AssertResponse(myBalance);

            var myPositions = await service.GetPositions(id);
            AssertResponse(myPositions);

            var history = await service.GetHistory(id);
            var historyWithQuery = await service.GetHistory(id, new Request.GetHistoryRequestOptions()
            {
                ActivityType = Enumerations.ActivityType.Trade,
                End = DateTime.Now,
                ExactMatch = true,
                Limit = "10",
                Start = DateTime.Now.AddDays(-30)
            });
            AssertResponse(history);
        }

        void AssertResponse(Response.TradierResponse rs)
        {
            Assert.IsNotNull(rs);
            Assert.IsTrue(rs.IsSuccessful, $"Response was not successful for {rs.GetType().Name}");
            Assert.IsNotNull(rs.RawResponse, $"Raw response was null for {rs.GetType().Name}");
            Assert.IsFalse(string.IsNullOrWhiteSpace(rs.RawResponse), $"Raw response was empty for {rs.GetType().Name}");
        }
    }
}
#nullable restore