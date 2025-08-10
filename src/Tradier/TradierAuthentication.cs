using System.Net.Http.Headers;
using System.Text.Json;
namespace Tradier
{
    public class TradierAuthentication
    {
        public TradierAuthentication(Uri redirectUri)
        {
            RedirectUri = redirectUri;
        }
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public Uri RedirectUri { get; set; }
        public string? AuthorizationCode { get; set; }
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? AccessTokenExpiry { get; set; }

        private const string AUTH_ENDPOINT = "https://api.tradier.com/v1/oauth/authorize";
        private const string TOKEN_ENDPOINT = "https://api.tradier.com/v1/oauth/token";
        public async Task ExchangeCodeForTokenAsync()
        {
            using var client = new HttpClient();
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("code", AuthorizationCode ?? string.Empty),
                new KeyValuePair<string, string>("client_id", ClientId ?? string.Empty),
                new KeyValuePair<string, string>("client_secret", ClientSecret ?? string.Empty),
                new KeyValuePair<string, string>("redirect_uri", RedirectUri?.ToString() ?? string.Empty)
            });
            var response = await client.PostAsync(TOKEN_ENDPOINT, content);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(json);
            AccessToken = tokenResponse?.access_token;
            RefreshToken = tokenResponse?.refresh_token;
            AccessTokenExpiry = DateTime.UtcNow.AddSeconds(tokenResponse?.expires_in ?? 0);
        }

        public async Task RefreshAccessTokenAsync()
        {
            using var client = new HttpClient();
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("refresh_token", RefreshToken ?? string.Empty),
                new KeyValuePair<string, string>("client_id", ClientId ?? string.Empty),
                new KeyValuePair<string, string>("client_secret", ClientSecret ?? string.Empty)
            });
            var response = await client.PostAsync(TOKEN_ENDPOINT, content);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(json);
            AccessToken = tokenResponse?.access_token;
            AccessTokenExpiry = DateTime.UtcNow.AddSeconds(tokenResponse?.expires_in ?? 0);
        }

        public void ApplyAuthentication(HttpClient client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        }

        private class TokenResponse
        {
            public string? access_token { get; set; }
            public string? refresh_token { get; set; }
            public int expires_in { get; set; }
        }
    }
}