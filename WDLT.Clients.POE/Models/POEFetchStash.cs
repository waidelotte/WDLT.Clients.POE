using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchStash
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }
}