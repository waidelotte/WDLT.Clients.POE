using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POESearchQuery
    {
        [JsonProperty("status")]
        public EPOEOption<EPOEOnlineStatus> Status { get; set; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public POESearchFilters Filters { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public List<POESearchStat> Stats { get; set; }
    }
}