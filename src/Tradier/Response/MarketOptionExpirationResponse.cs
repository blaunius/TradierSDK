using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class MarketOptionExpirationResponse : TradierResponse
    {
        [JsonPropertyName("expirations")]
        public ExpirationContainer? Data { get; set; }
        public class ExpirationContainer
        {
            [JsonPropertyName("expiration")]
            public List<Expiration> Expirations { get; set; } = new List<Expiration>();
        }
        internal string? expirations { get; set; }
        internal override void Deserialize()
        {
            this.Data = System.Text.Json.JsonSerializer.Deserialize<MarketOptionExpirationResponse>(this.RawResponse)?.Data ?? new ExpirationContainer();
        }
    }
}