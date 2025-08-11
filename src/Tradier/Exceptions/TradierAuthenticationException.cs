using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Exceptions
{
    public class TradierAuthenticationException : System.Exception
    {
        public TradierAuthenticationException() : base("An Authentication Error has occurred")
        {
        }
        public TradierAuthenticationException(string message) : base(message)
        {
        }
    }
}
