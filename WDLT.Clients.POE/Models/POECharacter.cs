using Newtonsoft.Json;

namespace WDLT.Clients.POE.Models
{
    public class POECharacter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("ascendancyClass")]
        public int AscendancyClass { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("experience")]
        public long Experience { get; set; }
    }
}