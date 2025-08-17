using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Services
{
    public class WatchlistService : TradingService
    {
        public WatchlistService(ITradierClient client) : base(client) { }
        public WatchlistService() : base() { }
    }
}
