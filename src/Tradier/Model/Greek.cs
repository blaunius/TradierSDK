using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class Greek
    {
        [JsonProperty("delta")]
        public decimal? Delta { get; init; }

        [JsonProperty("gamma")]
        public decimal? Gamma { get; init; }

        [JsonProperty("theta")]
        public decimal? Theta { get; init; }

        [JsonProperty("vega")]
        public decimal? Vega { get; init; }

        [JsonProperty("rho")]
        public decimal? Rho { get; init; }

        [JsonProperty("phi")]
        public decimal? Phi { get; init; }

        [JsonProperty("bid_iv")]
        public decimal? BidIv { get; init; }

        [JsonProperty("mid_iv")]
        public decimal? MidIv { get; init; }

        [JsonProperty("ask_iv")]
        public decimal? AskIv { get; init; }

        [JsonProperty("smv_vol")]
        public decimal? SmvVol { get; init; }

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; init; }
    }
}
