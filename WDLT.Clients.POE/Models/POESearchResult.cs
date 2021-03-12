using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POESearchResult : POEResult<List<string>>
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("complexity")]
        public int Complexity { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}