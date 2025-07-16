using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tradier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Tests
{
    [TestClass()]
    public class TradierClientTests
    {
        [TestMethod()]
        public void TradierClientTest()
        {
            TradierClient client = new TradierClient(
                new HttpClient() { BaseAddress = new Uri(TradierClient.BASE_URL_V1) }, 
                new TradierAuthentication("some-token"));

            Assert.Fail();
        }
    }
}