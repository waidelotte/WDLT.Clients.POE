using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POELeague
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}