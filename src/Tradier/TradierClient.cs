using Tradier.Services;
#nullable disable
namespace Tradier
{
    public partial class TradierClient : ITradierClient
    {
        public async Task<TData> GetDataAsync<TData>(string endpoint)
        {
            var rq = new HttpRequestMessage(HttpMethod.Get, new Uri(client.BaseAddress, endpoint));
            var rs = await this.client.SendAsync(rq);
            string content = await rs.Content.ReadAsStringAsync();
            if (!rs.IsSuccessStatusCode)
                throw new HttpRequestException($"Error fetching data from {endpoint}: ({rs.ReasonPhrase}) {content}");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TData>(content);
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