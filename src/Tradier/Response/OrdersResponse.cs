using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class OrdersResponse : TradierResponse
    {
        [JsonPropertyName("orders")]
        public IList<Order>? Orders { get; set; }
        internal override void Deserialize()
        {
            Orders = System.Text.Json.JsonSerializer.Deserialize<OrdersResponse>(this.RawResponse)?.Orders ?? [];
        }
    }
}