using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class AccountHistoryResponse : TradierResponse
    {
        public IList<Event>? Events { get; set; }

        [JsonPropertyName("history")]
        public string? _events { get; set; }
        internal override void Deserialize()
        {
            _events = System.Text.Json.JsonSerializer.Deserialize<AccountHistoryResponse>(this.RawResponse)?._events;
            if (_events != null && _events != "null")
                Events = System.Text.Json.JsonSerializer.Deserialize<IList<Event>>(_events);
        }
    }
}
