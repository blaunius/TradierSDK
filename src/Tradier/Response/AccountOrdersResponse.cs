using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class AccountOrdersResponse : TradierResponse
    {
        [JsonPropertyName("orders")]
        public AccountOrdersContainer? Data { get; set; }
        public class AccountOrdersContainer
        {
            [JsonPropertyName("order")]
            public List<Order> Orders { get; set; } = new();

        }
        internal override void Deserialize()
        {
            if (this.RawResponse == "{\"orders\":\"null\"}")
                Data = new();
            else
                Data = System.Text.Json.JsonSerializer.Deserialize<AccountOrdersResponse>(this.RawResponse)?.Data ?? new();
        }
    }
}