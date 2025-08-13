using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class AccountHistoryResponse : TradierResponse
    {
        [JsonPropertyName("events")]
        public List<Event>? Events { get; set; }
        internal override void Deserialize()
        {
            if (IsSuccessful)
            {
                Events = System.Text.Json.JsonSerializer.Deserialize<AccountHistoryResponse>(this.RawResponse)?.Events ?? [];
            }
        }
    }
}
