using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.POE.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EPOEStaicType
    {
        Currency,
        Splinters,
        Fragments,
        DeliriumOrbs,
        Catalysts,
        Oils,
        Incubators,
        Scarabs,
        DelveResonators,
        DelveFossils,
        Essences,
        Cards,
        MapsTier1,
        MapsTier2,
        MapsTier3,
        MapsTier4,
        MapsTier5,
        MapsTier6,
        MapsTier7,
        MapsTier8,
        MapsTier9,
        MapsTier10,
        MapsTier11,
        MapsTier12,
        MapsTier13,
        MapsTier14,
        MapsTier15,
        MapsTier16,
        MapsBlighted,
        Misc
    }
}