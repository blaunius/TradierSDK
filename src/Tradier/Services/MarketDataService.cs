using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Services
{
    public class MarketDataService : TradierService
    {
        public MarketDataService(ITradierClient client) : base(client) { }
    }
}
