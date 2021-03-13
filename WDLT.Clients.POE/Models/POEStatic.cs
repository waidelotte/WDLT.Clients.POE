using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POEStatic
    {
        [JsonProperty("id")]
        public EPOEStaicType Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("entries")]
        public List<POEStaticEntry> Entries { get; set; }
    }
}