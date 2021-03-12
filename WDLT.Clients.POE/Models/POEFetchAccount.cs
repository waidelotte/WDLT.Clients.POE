using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchAccount
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastCharacterName")]
        public string LastCharacterName { get; set; }

        [JsonProperty("online")]
        public POEFetchOnline Online { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}