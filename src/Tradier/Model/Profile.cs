using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Profile
    {
        [JsonProperty("account")]
        public List<Account>? Account { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
