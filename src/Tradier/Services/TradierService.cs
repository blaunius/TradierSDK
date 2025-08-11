using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Services
{
    public abstract class TradierService
    {
        protected readonly ITradierClient client;
        public TradierService(ITradierClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }
        public TradierService()
        {
            this.client = TradierConfig.DefaultClient 
                ?? throw new InvalidOperationException("Default client is not set. Please initialize a valid ITradierClient instance first.");
        }
    }
}
