using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchFilters
    {
        [JsonProperty("trade_filters")]
        public POESearchTradeFilters TradeFilters { get; set; }
    }
}