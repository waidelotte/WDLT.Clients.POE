using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchTradeFilters
    {
        [JsonProperty("filters")]
        public POESearchFilter Filters { get; set; }
    }
}