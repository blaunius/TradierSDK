using Tradier.Services;

namespace Tradier
{
    public partial class TradierClient : ITradierClient
    {
        private readonly HttpClient client;
        private readonly TradierAuthentication authentication;
        public TradierClient(HttpClient client, TradierAuthentication auth)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            if (this.client.BaseAddress is null)
                this.client.BaseAddress = new Uri("https://api.tradier.com/v1/");
            authentication = auth ?? throw new ArgumentNullException(nameof(auth));
            authentication.ApplyAuthentication(client);
        }
    }
    public partial class TradierClient
    {
        public const string BASE_URL_V1 = "https://api.tradier.com/v1/";
        public AccountService Account => new(this);
        public MarketDataService MarketData => new(this);
        public StreamingService Streaming => new(this);
        public TradingService Trading => new(this);
        public WatchlistService Watchlist => new(this);
    }
}