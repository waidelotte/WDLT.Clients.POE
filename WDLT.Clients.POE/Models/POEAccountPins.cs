using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEAccountPins
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("entries")]
        public List<POEAccountPinEntry> Entries { get; set; }
    }
}