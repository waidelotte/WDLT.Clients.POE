using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POESearchPayload
    {
        public POESearchPayload()
        {
            Query = new POESearchQuery
            {
                Status = new EPOEOption<EPOEOnlineStatus> { Option = EPOEOnlineStatus.Online },
                Stats = new List<POESearchStat>
                {
                    new POESearchStat
                    {
                        Filters = new List<object>(),
                        Type = EPOESearchStatType.And
                    }
                }
            };
        }

        [JsonProperty("query")]
        public POESearchQuery Query { get; set; }

        [JsonProperty("sort")]
        public POESearchSort Sort { get; set; }
    }
}