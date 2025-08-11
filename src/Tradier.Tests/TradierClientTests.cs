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
    public class TradierClientTests : IDisposable
    {
        public required TradierClient client { get; set; }
        HttpClient? httpClient;
        TradierAuthentication? auth;

        [TestInitialize()]
        public void Init()
        {
            httpClient = new HttpClient() { BaseAddress = new Uri(TradierClient.BASE_URL_V1) };
            auth = new TradierAuthentication(new Uri("https://example.com/redirect"));
            client = new TradierClient(httpClient, auth);
        }

        [TestMethod()]
        public async Task TradierClientTest()
        {
            var myProfile = await new Services.AccountService(client).GetUserProfile();
            Assert.Fail();
        }


        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }
}