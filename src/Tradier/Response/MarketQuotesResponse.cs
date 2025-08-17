using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tradier.Model;

namespace Tradier.Response
{
    public class MarketQuotesResponse : TradierResponse
    {
        public List<Quote>? Quotes { get; set; }
        public string? quotes { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}
