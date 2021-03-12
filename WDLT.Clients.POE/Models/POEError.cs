using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEErrorResponse
    {
        [JsonProperty("error")]
        public POEError Error { get; set; }
    }

    public class POEError
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}