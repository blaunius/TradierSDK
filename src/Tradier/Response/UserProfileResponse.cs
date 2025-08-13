using System.Text.Json.Serialization;

namespace Tradier.Response
{
    public class UserProfileResponse : TradierResponse
    {
        [JsonPropertyName("profile")]
        public Model.Profile? Profile { get; set; } = new();
        internal override void Deserialize()
        {
            if (this.IsSuccessful)
                this.Profile = System.Text.Json.JsonSerializer.Deserialize<UserProfileResponse>(this.RawResponse)?.Profile;
        }
    }
}
