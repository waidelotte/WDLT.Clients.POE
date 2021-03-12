using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchPrice
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}