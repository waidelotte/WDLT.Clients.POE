using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchItemSocket
    {
        [JsonProperty("group")]
        public int Group { get; set; }

        [JsonProperty("attr")]
        public EPOEAttribute Attr { get; set; }

        [JsonProperty("sColour")]
        public EPOESocketColor Colour { get; set; }
    }
}