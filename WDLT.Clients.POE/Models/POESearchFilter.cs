using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchFilter
    {
        [JsonProperty("account")]
        public POESearchAccountFilter Account { get; set; }
    }
}