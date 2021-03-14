using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.POE.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EPOEAttribute
    {
        [EnumMember(Value = "D")]
        Dexterity,
        [EnumMember(Value = "S")]
        Strength,
        [EnumMember(Value = "I")]
        Intelligence,
        G,
        A
    }
}