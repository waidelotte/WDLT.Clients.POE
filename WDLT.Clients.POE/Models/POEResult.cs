using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POEResult<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}