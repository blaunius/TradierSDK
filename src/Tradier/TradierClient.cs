using Tradier.Core;

namespace Tradier
{
    public class TradierClient : ITradierClient
    {
        const string BASE_URI = "https://api.tradier.com/v1/";
        private readonly HttpClient client;
        private readonly TradierAuthentication authentication;
        public TradierClient(TradierAuthentication auth)
        {
            client = new() { BaseAddress = new Uri(BASE_URI) };
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            authentication = auth ?? throw new ArgumentNullException(nameof(auth));
            authentication.ApplyAuthentication(client);
        }
    }
}
