using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.POE.Enums;

namespace WDLT.Clients.POE.Models
{
    public class POEFetchItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("w")]
        public int Width { get; set; }

        [JsonProperty("h")]
        public int Height { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("stackSize")]
        public int StackSize { get; set; }

        [JsonProperty("maxStackSize")]
        public int MaxStackSize { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeLine")]
        public string TypeLine { get; set; }

        [JsonProperty("identified")]
        public bool Identified { get; set; }

        [JsonProperty("thRaceReward")]
        public bool RaceReward { get; set; }

        [JsonProperty("isRelic")]
        public bool IsRelic { get; set; }

        [JsonProperty("ilvl")]
        public int ILVL { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("secDescrText")]
        public string SecDescrText { get; set; }

        [JsonProperty("frameType")]
        public EPOEFrameType FrameType { get; set; }

        [JsonProperty("requirements")]
        public List<POEFetchItemProperty> Requirements { get; set; }

        [JsonProperty("properties")]
        public List<POEFetchItemProperty> Properties { get; set; }

        [JsonProperty("explicitMods")]
        public List<string> ExplicitMods { get; set; }

        [JsonProperty("implicitMods")]
        public List<string> ImplicitMods { get; set; }

        [JsonProperty("utilityMods")]
        public List<string> UtilityMods { get; set; }

        [JsonProperty("enchantMods")]
        public List<string> EnchantMods { get; set; }

        [JsonProperty("fracturedMods")]
        public List<string> FracturedMods { get; set; }

        [JsonProperty("craftedMods")]
        public List<string> CraftedMods { get; set; }

        [JsonProperty("veiledMods")]
        public List<string> VeiledMods { get; set; }

        [JsonProperty("flavourText")]
        public List<string> FlavourText { get; set; }

        [JsonProperty("sockets")]
        public List<POEFetchItemSocket> Sockets { get; set; }

        [JsonProperty("influences")]
        public POEFetchItemInfluence Influences { get; set; }

        [JsonProperty("extended")]
        public POEFetchExtended Extended { get; set; }

        [JsonProperty("corrupted")]
        public bool Corrupted { get; set; }

        [JsonProperty("support")]
        public bool Support { get; set; }

        [JsonProperty("synthesised")]
        public bool Synthesised { get; set; }

        [JsonProperty("talismanTier")]
        public int? TalismanTier { get; set; }

        [JsonProperty("duplicated")]
        public bool Duplicated { get; set; }

        [JsonProperty("fractured")]
        public bool Fractured { get; set; }

        [JsonProperty("veiled")]
        public bool Veiled { get; set; }
    }
}