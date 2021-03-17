using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchFilter
    {
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public POESearchAccountFilter Account { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public EPOEOption<string> Category { get; set; }
    }
}