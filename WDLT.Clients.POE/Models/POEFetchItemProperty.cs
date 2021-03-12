using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchItemProperty
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public List<List<string>> Values { get; set; }

        [JsonProperty("displayMode")]
        public int DisplayMode { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }
    }
}