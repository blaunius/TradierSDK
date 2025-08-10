using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tradier.Model;

namespace Tradier.Services
{
    public class MarketDataService : TradierService
    {
        public MarketDataService(ITradierClient client) : base(client) { }

        /// <summary>
        /// Get a list of symbols using a keyword lookup on the symbols description. Results are in descending order by average volume of the security. This can be used for simple search functions.
        /// </summary>
        /// <returns>List of Quotes</returns>
        public List<Quote> GetQuotes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all quotes in an option chain.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Option> GetOptionChains()
        {
            throw new NotImplementedException();
        }

        public object GetOptionStrikes()
        {
            throw new NotImplementedException();
        }

        public object GetOptionExpirations()
        {
            throw new NotImplementedException();
        }

        public object LookupOptionSymbols()
        {
            throw new NotImplementedException();
        }

        public object GetHistoricalQuotes()
        {
            throw new NotImplementedException();
        }

        public object GetTimeAndSales()
        {
            throw new NotImplementedException();
        }

        public object GetETBSecurities()
        {
            throw new NotImplementedException();
        }

        public object GetClock()
        {
            throw new NotImplementedException();
        }

        public object GetCalendar()
        {
            throw new NotImplementedException();
        }

        public object SearchCompanies()
        {
            throw new NotImplementedException();
        }

        public object LookupSymbol()
        {
            throw new NotImplementedException();
        }
    }
}
