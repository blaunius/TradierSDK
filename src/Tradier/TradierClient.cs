using Tradier.Services;
#nullable disable

namespace Tradier
{
    /// <summary>
    /// This client is used for production access only. 
    /// To use the sandbox environment, use the <see cref="TradierSandboxClient"/> instead.
    /// </summary>
    public class TradierClient : ITradierClient, IDisposable
    {
        private readonly HttpClient client;
        private TradierAuthentication auth;
        public virtual string AccessToken => TradierConfig.AccessToken;
        public virtual string BaseAddress => "https://api.tradier.com/v1/";
        public virtual string StreamAddress => "https://stream.tradier.com/v1/";
        public TradierClient()
        {
            this.client = new HttpClient();
            disposeClient = true;
            InitializeClient();
        }
        public TradierClient(HttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            InitializeClient();
        }
        internal void InitializeClient()
        {
            ArgumentNullException.ThrowIfNull(AccessToken, "The access token should be set in the 'TradierConfig' class");
            this.client.BaseAddress ??= new Uri(BaseAddress);
            this.auth = new TradierAuthentication(this.AccessToken);
            this.auth.ApplyAuthentication(this.client);
        }
        public async Task<TData> GetDataAsync<TData>(string endpoint)
        {
            var rq = new HttpRequestMessage(HttpMethod.Get, new Uri(client.BaseAddress, endpoint));
            var rs = await this.client.SendAsync(rq);
            string content = await rs.Content.ReadAsStringAsync();
            if (!rs.IsSuccessStatusCode)
                throw new HttpRequestException($"Error fetching data from {endpoint}: ({rs.ReasonPhrase}) {content}");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TData>(content);
        }

        private bool disposeClient { get; }
        public virtual void Dispose()
        {
            if (disposeClient)
                client?.Dispose();
        }
    }
}
#nullable restore