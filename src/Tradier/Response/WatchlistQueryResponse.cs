using System.Text.Json;
using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class WatchlistQueryResponse : TradierResponse
    {
        [JsonPropertyName("watchlists")]
        public WatchListArrayContainer? Data { get; set; }
        public class WatchListArrayContainer
        {
            [JsonPropertyName("watchlist")]
            public List<WatchList>? Watchlist { get; set; }
        }
        internal override void Deserialize()
        {
            this.Data = JsonSerializer.Deserialize<WatchlistQueryResponse>(this.RawResponse)?.Data ?? new();
        }
    }
}
