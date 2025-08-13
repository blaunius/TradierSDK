using Tradier.Response;
using Tradier.Services;
#nullable disable
namespace Tradier
{
    public partial class TradierClient : ITradierClient
    {
        public Task<TResponse> GetResponse<TResponse>(string endpoint) where TResponse : TradierResponse, new()
        {
            TResponse response = new();
            var rq = new HttpRequestMessage(HttpMethod.Get, new Uri(client.BaseAddress, endpoint));
            var rs = this.client.SendAsync(rq).GetAwaiter().GetResult();
            response.Parse(rs).GetAwaiter().GetResult();
            return Task.FromResult(response);
        }
    }

    /// <summary>
    /// This client is used for production access only. 
    /// To use the sandbox environment, use the <see cref="TradierSandboxClient"/> instead.
    /// </summary>
    public partial class TradierClient : IDisposable
    {
        private readonly HttpClient client;
        private TradierAuthentication auth;
        internal virtual string BaseAddress => "https://api.tradier.com/v1/";
        internal virtual string StreamAddress => "https://stream.tradier.com/v1/";
        public TradierClient()
        {
            this.disposeClient = true;
            this.client = new HttpClient();
            InitializeClient();
        }
        public TradierClient(HttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            InitializeClient();
        }
        public TradierClient(TradierAuthentication authentication)
        {
            this.disposeClient = true;
            this.client = new HttpClient();
            this.auth = authentication ?? throw new ArgumentNullException(nameof(authentication));
            InitializeClient();
        }
        public TradierClient(HttpClient client, TradierAuthentication authentication)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.auth = authentication ?? throw new ArgumentNullException(nameof(authentication));
            InitializeClient();
        }
        internal void InitializeClient()
        {
            this.client.BaseAddress ??= new Uri(BaseAddress);
            this.auth ??= new TradierAuthentication();
            this.auth.ApplyAuthentication(this.client);
            TradierConfig.DefaultClient = this;
        }
        

        private bool disposeClient = false;
        public virtual void Dispose()
        {
            if (disposeClient)
                client?.Dispose();            
            TradierConfig.DefaultClient = null;
        }
    }
}
#nullable restore