using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchItemInfluence
    {
        [JsonProperty("redeemer")]
        public bool Redeemer { get; set; }

        [JsonProperty("warlord")]
        public bool Warlord { get; set; }

        [JsonProperty("elder")]
        public bool Elder { get; set; }

        [JsonProperty("hunter")]
        public bool Hunter { get; set; }

        [JsonProperty("crusader")]
        public bool Crusader { get; set; }

        [JsonProperty("shaper")]
        public bool Shaper { get; set; }
    }
}