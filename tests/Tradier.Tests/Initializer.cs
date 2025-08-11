using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Tests
{
    [TestClass]
    public class Initializer
    {
        public IConfigurationRoot config;
        public TradierClient? Client { get; set; }
        public TradierSandboxClient? SandboxClient { get; set; }
        public Initializer()
        {
            config = new ConfigurationBuilder()
                .AddUserSecrets(typeof(Initializer).Assembly)
                .Build();
        }

        [TestInitialize()]
        public void Init()
        {
            TradierConfig.RedirectUri = config["Tradier:RedirectUri"];
            this.SandboxClient = new TradierSandboxClient(new TradierAuthentication(config["Tradier:AccessTokens:Sandbox"], TradierConfig.RedirectUri));
            this.Client = new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri));

        }
    }
}
