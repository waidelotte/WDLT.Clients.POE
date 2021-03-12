using System.Net.Sockets;
using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("listing")]
        public POEFetchListing Listing { get; set; }

        [JsonProperty("item")]
        public POEFetchItem Item { get; set; }
    }
}