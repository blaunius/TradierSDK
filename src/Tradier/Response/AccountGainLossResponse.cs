using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class AccountGainLossResponse : TradierResponse
    {
        [JsonPropertyName("closed_positions")]
        public IList<ClosedPosition>? ClosedPositions { get; set; }
        internal override void Deserialize()
        {
            ClosedPositions = System.Text.Json.JsonSerializer.Deserialize<AccountGainLossResponse>(this.RawResponse)?.ClosedPositions ?? [];
        }
    }
}
