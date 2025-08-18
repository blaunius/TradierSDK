using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class AccountHistoryResponse : TradierResponse
    {
        [JsonPropertyName("history")]
        public AccountHistoryResponseContainer? Data { get; set; }
        public class AccountHistoryResponseContainer
        {
            [JsonPropertyName("event")]
            public List<Event> Events { get; set; } = new();
        }
        internal override void Deserialize()
        {
            this.Data = System.Text.Json.JsonSerializer.Deserialize<AccountHistoryResponse>(this.RawResponse)?.Data ?? new();            
        }
    }
}
