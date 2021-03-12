using System;
using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchListing
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("indexed")]
        public DateTimeOffset Indexed { get; set; }

        [JsonProperty("stash")]
        public POEFetchStash Stash { get; set; }

        [JsonProperty("whisper")]
        public string Whisper { get; set; }

        [JsonProperty("account")]
        public POEFetchAccount Account { get; set; }

        [JsonProperty("price")]
        public POEFetchPrice Price { get; set; }
    }
}