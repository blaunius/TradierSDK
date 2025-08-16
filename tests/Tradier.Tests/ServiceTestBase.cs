using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tradier.Services;

namespace Tradier.Tests
{
    [TestClass]
    public class ServiceTestBase
    {
        public IConfigurationRoot config;
        public TradierClient? Client { get; set; }
        public TradierSandboxClient? SandboxClient { get; set; }
        public ServiceTestBase()
        {
            config = new ConfigurationBuilder()
                .AddUserSecrets(typeof(ServiceTestBase).Assembly)
                .Build();
        }

        [TestInitialize()]
        public void Init()
        {
            TradierConfig.RedirectUri = config["Tradier:RedirectUri"];
            this.SandboxClient = new TradierSandboxClient(new TradierAuthentication(config["Tradier:AccessTokens:Sandbox"], TradierConfig.RedirectUri));
            this.Client = new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri));
        }

        public virtual void SetService()
        {
        }

        public void AssertResponse(Response.TradierResponse rs)
        {
            Assert.IsNotNull(rs);
            Assert.IsTrue(rs.IsSuccessful, $"Response was not successful for {rs.GetType().Name}");
            Assert.IsNotNull(rs.RawResponse, $"Raw response was null for {rs.GetType().Name}");
            Assert.IsFalse(string.IsNullOrWhiteSpace(rs.RawResponse), $"Raw response was empty for {rs.GetType().Name}");
        }
    }
}
