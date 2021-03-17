using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class EPOEOption<T>
    {
        [JsonProperty("option")]
        public T Option { get; set; }
    }
}