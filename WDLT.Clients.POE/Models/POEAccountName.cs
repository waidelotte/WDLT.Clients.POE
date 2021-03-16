using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEAccountName
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }
}