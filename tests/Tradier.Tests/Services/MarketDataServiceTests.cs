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
            service = new MarketDataService(Client);
        }

        [TestMethod()]
        public void MarketDataServiceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetQuotesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetOptionChainsTest()
        {
            Assert.Fail();
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