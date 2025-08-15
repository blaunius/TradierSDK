using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Response
{
    public class BalanceResponse : TradierResponse
    {
        public Model.Balance? Balance { get; set; }
        internal override void Deserialize()
        {
                this.Balance = System.Text.Json.JsonSerializer.Deserialize<BalanceResponse>(this.RawResponse)?.Balance ?? new();
        }
    }
}
