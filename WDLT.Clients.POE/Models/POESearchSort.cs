using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POESearchSort
    {
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public EPOESort? Price { get; set; }

        [JsonProperty("stack_size", NullValueHandling = NullValueHandling.Ignore)]
        public EPOESort? StackSize { get; set; }
    }
}