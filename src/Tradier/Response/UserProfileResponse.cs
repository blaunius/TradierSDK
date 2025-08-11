using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tradier.Response
{
    public class UserProfileResponse : TradierResponse
    {
        public Model.Profile? Profile { get; set; }
        internal override void Deserialize()
        {
            this.Profile = Newtonsoft.Json.JsonConvert.DeserializeObject<UserProfileResponse>(this.RawResponse)?.Profile;
        }
    }
}
