using System.Text.Json.Serialization;
namespace Tradier.Response
{
    public class PositionsResponse : TradierResponse
    {
        [JsonPropertyName("positions")]
        private string? positionsRaw { get; set; }
        public IList<Model.Position>? Positions { get; internal set; }
        internal override void Deserialize()
        {
                this.positionsRaw = System.Text.Json.JsonSerializer.Deserialize<PositionsResponse>(this.RawResponse)?.positionsRaw;
                if (positionsRaw != null && positionsRaw != "null")
                    Positions = System.Text.Json.JsonSerializer.Deserialize<IList<Model.Position>>(positionsRaw) ?? [];
                else Positions = [];
        }
    }
}
