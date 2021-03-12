using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchQuery
    {
        [JsonProperty("status")]
        public POESearchStatus Status { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<POESearchStat> Stats { get; set; }
    }
}