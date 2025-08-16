using System.Text.Json.Serialization;
using Tradier.Model;

namespace Tradier.Response
{
    public class AccountGainLossResponse : TradierResponse
    {
        [JsonPropertyName("gainloss")]
        public string? gainloss { get; set; }
        public IList<ClosedPosition>? GainLoss { get; set; }
        internal override void Deserialize()
        {
            gainloss = System.Text.Json.JsonSerializer.Deserialize<AccountGainLossResponse>(this.RawResponse)?.gainloss;
            if (gainloss != null && gainloss != "null")
            {
                GainLoss = System.Text.Json.JsonSerializer.Deserialize<IList<ClosedPosition>>(gainloss);
            }
            else
            {
                GainLoss = new List<ClosedPosition>();
            }
        }
    }
}
