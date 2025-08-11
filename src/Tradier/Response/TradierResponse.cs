using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Response
{
    public abstract class TradierResponse
    {
        public string RawResponse { get; internal set; } = null!;
        public bool Successful { get; internal set; }
        public HttpResponseMessage Response { get; private set; } = null!;
        internal Task Parse(HttpResponseMessage rs)
        {
            Response = rs;
            RawResponse = rs.Content.ReadAsStringAsync().Result;
            Successful = rs.IsSuccessStatusCode;
            if (Successful)
                Deserialize();
            return Task.CompletedTask;
        }
        internal virtual void Deserialize()
        {
            //this method should always be overriden
            throw new NotImplementedException(this.GetType() + " is not yet implemented for serialization");
        }
    }
}
