using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchFilters
    {
        [JsonProperty("trade_filters", NullValueHandling = NullValueHandling.Ignore)]
        public POESearchTradeFilters TradeFilters { get; set; }

        [JsonProperty("type_filters", NullValueHandling = NullValueHandling.Ignore)]
        public POESearchTradeFilters TypeFilters { get; set; }
    }
}