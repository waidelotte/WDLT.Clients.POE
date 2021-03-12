using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POESearchStatus
    {
        [JsonProperty("option")]
        public EPOEOnlineStatus Option { get; set; }
    }
}