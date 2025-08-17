namespace Tradier.Response
{
    public class MarketOptionStikesResponse : TradierResponse
    {
        public List<decimal>? Strikes { get; set; }
        internal string? strikes { get; set; }
        internal override void Deserialize()
        {
            base.Deserialize();
        }
    }
}