using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Response
{
    public class PositionsResponse : TradierResponse
    {
        [JsonProperty("positions")]
        private string? positionsRaw { get; set; }
        public List<Model.Position> Positions { get; set; } = new();
        internal override void Deserialize()
        {
            if (this.Successful)
            {
                this.positionsRaw = Newtonsoft.Json.JsonConvert.DeserializeObject<PositionsResponse>(this.RawResponse)?.positionsRaw;
                if (positionsRaw == "null") 
                    Positions = new();
                else
                {
                    Positions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Position>>(positionsRaw!) ?? new();
                }
            }
        }
    }
}
