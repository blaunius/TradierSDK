using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Model
{
    public class Expiration
    {
        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("contract_size")]
        public int? ContractSize { get; set; }

        [JsonProperty("expiration_type")]
        public string? ExpirationType { get; set; }

        [JsonProperty("strikes")]
        public IEnumerable<double>? Strikes { get; set; }
    }
}
