using Newtonsoft.Json;

namespace Tradier.Model
{
    [JsonObject("profile")]
    public class Profile
    {
        [JsonProperty("account")]
        public Account? Account { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
