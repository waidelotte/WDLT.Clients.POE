using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchAccountFilter
    {
        [JsonProperty("input")]
        public string Input { get; set; }
    }
}