using Newtonsoft.Json;

namespace Tradier.Model
{
    public class Calendar
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("days")]
        public Days? Days { get; set; }
    }

    public class Day
    {
        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("premarket")]
        public Premarket? Premarket { get; set; }

        [JsonProperty("open")]
        public Open? Open { get; set; }

        [JsonProperty("postmarket")]
        public Postmarket? Postmarket { get; set; }
    }

    public class Days
    {
        [JsonProperty("day")]
        public List<Day>? Day { get; set; }
    }

    public class Open
    {
        [JsonProperty("start")]
        public string? Start { get; set; }

        [JsonProperty("end")]
        public string? End { get; set; }
    }

    public class Postmarket
    {
        [JsonProperty("start")]
        public string? Start { get; set; }

        [JsonProperty("end")]
        public string? End { get; set; }
    }

    public class Premarket
    {
        [JsonProperty("start")]
        public string? Start { get; set; }

        [JsonProperty("end")]
        public string? End { get; set; }
    }
}