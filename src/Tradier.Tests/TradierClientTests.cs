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
                new Core.TradierAuthentication()
                {
                     
                });

            Assert.Fail();
        }
    }
}