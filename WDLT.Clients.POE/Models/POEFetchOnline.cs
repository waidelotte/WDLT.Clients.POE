using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchOnline
    {
        [JsonProperty("league")]
        public string League { get; set; }
    }
}