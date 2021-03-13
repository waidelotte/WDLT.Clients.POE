using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEAccountPinEntry
    {
        [JsonProperty("character_id")]
        public long? CharacterId { get; set; }

        [JsonProperty("foreign_id")]
        public string ForeignId { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}