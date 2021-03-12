using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POESearchStat
    {
        [JsonProperty("type")]
        public EPOESearchStatType Type { get; set; }

        [JsonProperty("filters")]
        public List<object> Filters { get; set; }
    }
}