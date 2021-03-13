using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEStaticEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}