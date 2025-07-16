using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Services
{
    public class TradingService : TradierService
    {
        public TradingService(ITradierClient client) : base(client) { }
    }
}
