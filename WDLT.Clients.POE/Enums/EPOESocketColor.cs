using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.POE.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EPOESocketColor
    {
        [EnumMember(Value = "R")]
        Red,
        [EnumMember(Value = "G")]
        Green,
        [EnumMember(Value = "B")]
        Blue,
        [EnumMember(Value = "W")]
        White,
        A
    }
}