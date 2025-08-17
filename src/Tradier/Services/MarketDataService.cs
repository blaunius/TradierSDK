using Tradier.Model;
using Tradier.Request;
using Tradier.Response;

namespace Tradier.Services
{
    public class MarketDataService : TradierService
    {
        public MarketDataService(ITradierClient client) : base(client) { }
        public MarketDataService() : base() { }

        /// <summary>
        /// Get a list of symbols using a keyword lookup on the symbols description. Results are in descending order by average volume of the security. This can be used for simple search functions.
        /// </summary>
        public Task<MarketQuotesResponse> GetQuotes(bool showGreeks, params string[] symbols)
        {
            return client.GetResponse<MarketQuotesResponse>($"markets/quotes?greeks={showGreeks.ToString().ToLower()}&symbols={string.Join(',', symbols ?? [])}");
        }
        /// <summary>
        /// Get all quotes in an option chain.
        /// </summary>
        public Task<MarketOptionChainsResponse> GetOptionChains(string symbol, DateTime expiration, bool includeAllGreeks = false)
        {
            return client.GetResponse<MarketOptionChainsResponse>($"markets/options/chains?symbol={symbol}&expiration={expiration:yyyy-MM-dd}&greeks={includeAllGreeks.ToString().ToLower()}");
        }
        /// <summary>
        /// Get an options strike prices for a specified expiration date.
        /// </summary>
        public Task<MarketOptionStikesResponse> GetOptionStrikes(string symbol, DateTime expiration, bool includeAllRoots = false)
        {
            return client.GetResponse<MarketOptionStikesResponse>($"markets/options/strikes?symbol={symbol}&expiration={expiration:yyyy-MM-dd}&includeAllRoots={includeAllRoots.ToString().ToLower()}");
        }
        /// <summary>
        /// Get expiration dates for a particular underlying. 
        /// Note that some underlying securities use a different symbol for their weekly options(RUT/RUTW, SPX/SPXW).
        /// To make sure you see all expirations, make sure to send the includeAllRoots parameter.
        /// This will also ensure any unique options due to corporate actions(AAPL1) are returned.
        /// </summary>
        public Task<MarketOptionExpirationResponse> GetOptionExpirations(string symbol, MarketOptionExpirationRequest? options = null)
        {
            options ??= new();
            return client.GetResponse<MarketOptionExpirationResponse>($"markets/options/expirations?symbol={symbol}&includeAllRoots={options.includeAllRoots}&contractSize={options.showContractSize}&expirationType={options.showExpirationType}&strikes={options.showStrikes}");
        }
        /// <summary>
        /// Get all options symbols for the given underlying. 
        /// This will include additional option roots (ex. SPXW, RUTW) if applicable.
        /// </summary>
        public Task<MarketOptionSymbolsResponse> LookupOptionSymbols(string underlying)
        {
            return client.GetResponse<MarketOptionSymbolsResponse>($"markets/options/lookup?underlying={underlying}");
        }
        /// <summary>
        /// Get historical pricing for a security.
        /// This data will usually cover the entire lifetime of the company if sending reasonable start/end times.
        /// You can fetch historical pricing for options by passing the OCC option symbol (ex. AAPL220617C00270000) as the symbol.
        /// </summary>
        /// <remarks>Notes: Historical data may not be dividend adjusted as this relies on the exchanges to report/adjust it properly.
        /// Historical options data is not available for expired options.
        /// </remarks>
        public Task<MarketHistoricalQuotesResponse> GetHistoricalQuotes(string symbol, MarketHistoricalQuotesRequest? options = null)
        {
            options ??= new();
            return client.GetResponse<MarketHistoricalQuotesResponse>($"markets/history?symbol={symbol}&{options.ParseQuery()}");
        }
        /// <summary>
        /// Time and Sales (timesales) is typically used for charting purposes.
        /// It captures pricing across a time slice at predefined intervals.
        /// </summary>
        /// <remarks>
        /// Tick data is also available through this endpoint.
        /// This results in a very large data set for high-volume symbols, so the time slice needs to be much smaller to keep downloads time reasonable.
        /// </remarks>
        public Task<MarketTimeAndSalesResponse> GetTimeAndSales(string symbol, MarketTimeAndSalesRequest? options = null)
        {
            options ??= new();
            return client.GetResponse<MarketTimeAndSalesResponse>($"markets/timesales?symbol={symbol}&{options.ParseQuery()}");
        }
        /// <summary>
        /// The ETB list contains securities that are able to be sold short with a Tradier Brokerage account.
        /// The list is quite comprehensive and can result in a long download response time.
        /// </summary>
        public Task<MarketETBSecuritiesResponse> GetETBSecurities(CancellationToken token = default)
        {
            return client.GetResponse<MarketETBSecuritiesResponse>("markets/etb", token);
        }
        /// <summary>
        /// Get the intraday market status. This call will change and return information pertaining to the current day.
        /// If programming logic on whether the market is open/closed – this API call should be used to determine the current state.
        /// </summary>        
        public Task<MarketClockResponse> GetClock(bool delayed = false)
        {
            return client.GetResponse<MarketClockResponse>($"markets/clock?delayed={delayed.ToString().ToLower()}");
        }
        /// <summary>
        /// Get the market calendar for the current or given month. This can be used to plan ahead regarding strategies.
        /// However, the Get Intraday Status should be used to determine the current status of the market.
        /// </summary>
        /// <param name="month">Defaults to current month</param>
        /// <param name="year">Defaults to current year</param>
        /// <exception cref="NotImplementedException"></exception>
        public Task<MarketCalendarResponse> GetCalendar(int? month = null, int? year = null)
        {
            month ??= DateTime.Now.Month;
            year ??= DateTime.Now.Year;
            return client.GetResponse<MarketCalendarResponse>($"markets/calendar?month={month.Value.ToString("00")}&year={year}");
        }
        /// <summary>
        /// Get a list of symbols using a keyword lookup on the symbols description. 
        /// Results are in descending order by average volume of the security. 
        /// This can be used for simple search functions.
        /// </summary>
        public Task<MarketSearchCompaniesResponse> SearchCompanies(string searchQuery, bool showIndexes = true)
        {
            return client.GetResponse<MarketSearchCompaniesResponse>($"markets/search?q={searchQuery}&indexes={showIndexes.ToString().ToLower()}");
        }
        /// <param name="exchanges">A CSV string of exchanges</param>
        /// <parm name="securityTypes">A CSV string of security types (Stock, option, etf, index, etc)</param>
        public Task<MarketLookupSymbolResponse> LookupSymbol(string symbol, string securityTypes = "All", string exchanges = "All")
        {
            return client.GetResponse<MarketLookupSymbolResponse>($"markets/lookup?symbol={symbol}&types={securityTypes}&exchanges={exchanges}");
        }
    }
}
