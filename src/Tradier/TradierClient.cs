using Tradier.Services;
#nullable disable

namespace Tradier
{
    public class TradierClient : ITradierClient
    {
        private readonly HttpClient client;
        private readonly TradierAuthentication authentication;
        public const string BASE_URL_V1 = "https://api.tradier.com/v1/";

        public TradierClient(HttpClient client, TradierAuthentication auth)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.client.BaseAddress ??= new Uri(BASE_URL_V1);
            authentication = auth ?? throw new ArgumentNullException(nameof(auth));
            authentication.ApplyAuthentication(client);
        }

        public async Task<TData> GetResponseAsync<TData>(string endpoint)
        {
            var rq = new HttpRequestMessage(HttpMethod.Get, new Uri(client.BaseAddress, endpoint));
            var rs = await this.client.SendAsync(rq);
            string content = await rs.Content.ReadAsStringAsync();
            if (!rs.IsSuccessStatusCode)
                throw new HttpRequestException($"Error fetching data from {endpoint}: ({rs.ReasonPhrase}) {content}");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TData>(content);
        }
        public HttpResponseMessage GetAuthorizationCode()
        {
            throw new NotImplementedException("GetAuthorizationCode is not implemented.");
        }
        public HttpResponseMessage CreateAccessToken()
        {
            throw new NotImplementedException("CreateAccessToken is not implemented.");
        }
        public HttpResponseMessage RefreshAccessToken()
        {
            throw new NotImplementedException("RefreshAccessToken is not implemented.");
        }
    }
}
#nullable restore