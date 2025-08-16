using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class OrdersResponse : TradierResponse
    {
        [JsonPropertyName("orders")]
        string? _orders { get; set; }
        public IList<Order>? Orders { get; set; }
        internal override void Deserialize()
        {
            _orders = System.Text.Json.JsonSerializer.Deserialize<OrdersResponse>(this.RawResponse)?._orders;
            if (_orders is null || _orders == "null")
            {
                Orders = [];
            }
            else
            {
                Orders = System.Text.Json.JsonSerializer.Deserialize<OrdersResponse>(this.RawResponse)?.Orders;
            }
        }
    }
}