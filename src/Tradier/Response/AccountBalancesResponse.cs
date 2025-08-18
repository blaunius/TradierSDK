using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Response
{
    public class AccountBalancesResponse : TradierResponse
    {
        public Model.Balance? Balance { get; set; }
        internal override void Deserialize()
        {
            this.Balance = System.Text.Json.JsonSerializer.Deserialize<AccountBalancesResponse>(this.RawResponse)?.Balance ?? new();
        }
    }
}
