using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchExtended
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}