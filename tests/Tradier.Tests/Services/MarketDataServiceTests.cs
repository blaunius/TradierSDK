using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tradier.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tradier.Tests;
#nullable disable
namespace Tradier.Services.Tests
{
    [TestClass()]
    public class MarketDataServiceTests : ServiceTestBase
    {
        public virtual MarketDataService service { get; set; }
        [TestInitialize()]
        public override void SetService()
        {
            this.service = new MarketDataService(base.Client);
        }

        [TestMethod()]
        public void GetQuotesTest()
        {
            var rs = this.service.GetQuotes(true, "AAPL", "GOOG", "MSFT").Result;
            this.AssertResponse(rs);
        }

        [TestMethod()]
        public void GetOptionChainsTest()
        {
            var rs = this.service.GetOptionChains("AAPL", new DateTime(2025, 8, 29), true).Result;
            this.AssertResponse(rs);
        }

        [TestMethod()]
        public void GetOptionStrikesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetOptionExpirationsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LookupOptionSymbolsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHistoricalQuotesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTimeAndSalesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetETBSecuritiesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetClockTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCalendarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchCompaniesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LookupSymbolTest()
        {
            Assert.Fail();
        }
    }
}
#nullable enable