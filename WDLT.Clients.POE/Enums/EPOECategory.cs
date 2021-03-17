using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.POE.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EPOECategory
    {
        [EnumMember(Value = "weapon")]
        AnyWeapon,

        [EnumMember(Value = "weapon.one")]
        OneHandedWeapon,

        [EnumMember(Value = "weapon.onemelee")]
        OneHandedMeleeWeapon,

        [EnumMember(Value = "weapon.twomelee")]
        TwoHandedMeleeWeapon,

        [EnumMember(Value = "weapon.bow")]
        Bow,

        [EnumMember(Value = "weapon.claw")]
        Claw,

        [EnumMember(Value = "weapon.dagger")]
        AnyDagger,

        [EnumMember(Value = "weapon.basedagger")]
        BaseDagger,

        [EnumMember(Value = "weapon.runedagger")]
        RuneDagger,

        [EnumMember(Value = "weapon.oneaxe")]
        OneHandedAxe,

        [EnumMember(Value = "weapon.onemace")]
        OneHandedMace,

        [EnumMember(Value = "weapon.onesword")]
        OneHandedSword,

        [EnumMember(Value = "weapon.sceptre")]
        Sceptre,

        [EnumMember(Value = "weapon.staff")]
        AnyStaff,

        [EnumMember(Value = "weapon.basestaff")]
        BaseStaff,

        [EnumMember(Value = "weapon.warstaff")]
        Warstaff,

        [EnumMember(Value = "weapon.twoaxe")]
        TwoHandedAxe,

        [EnumMember(Value = "weapon.twomace")]
        TwoHandedMace,

        [EnumMember(Value = "weapon.twosword")]
        TwoHandedSword,

        [EnumMember(Value = "weapon.wand")]
        Wand,

        [EnumMember(Value = "weapon.rod")]
        FishingRod,

        [EnumMember(Value = "armour")]
        AnyArmour,

        [EnumMember(Value = "armour.chest")]
        BodyArmour,

        [EnumMember(Value = "armour.boots")]
        Boots,

        [EnumMember(Value = "armour.gloves")]
        Gloves,

        [EnumMember(Value = "armour.helmet")]
        Helmet,

        [EnumMember(Value = "armour.shield")]
        Shield,

        [EnumMember(Value = "armour.quiver")]
        Quiver,

        [EnumMember(Value = "accessory")]
        AnyAccessory,

        [EnumMember(Value = "accessory.amulet")]
        Amulet,

        [EnumMember(Value = "accessory.belt")]
        Belt,

        [EnumMember(Value = "accessory.ring")]
        Ring,

        [EnumMember(Value = "accessory.trinket")]
        Trinket,

        [EnumMember(Value = "gem")]
        AnyGem,

        [EnumMember(Value = "gem.activegem")]
        SkillGem,

        [EnumMember(Value = "gem.supportgem")]
        SupportGem,

        [EnumMember(Value = "gem.supportgemplus")]
        AwakenedSupportGem,

        [EnumMember(Value = "jewel")]
        AnyJewel,

        [EnumMember(Value = "jewel.base")]
        BaseJewel,

        [EnumMember(Value = "jewel.abyss")]
        AbyssJewel,

        [EnumMember(Value = "jewel.cluster")]
        ClusterJewel,

        [EnumMember(Value = "flask")]
        Flask,

        [EnumMember(Value = "map")]
        Map,

        [EnumMember(Value = "map.fragment")]
        MapFragment,

        [EnumMember(Value = "map.invitation")]
        MavensInvitation,

        [EnumMember(Value = "map.scarab")]
        Scarab,

        [EnumMember(Value = "watchstone")]
        Watchstone,

        [EnumMember(Value = "leaguestone")]
        Leaguestone,

        [EnumMember(Value = "prophecy")]
        Prophecy,

        [EnumMember(Value = "card")]
        DivinationCard,

        [EnumMember(Value = "monster.beast")]
        CapturedBeast,

        [EnumMember(Value = "monster.sample")]
        MetamorphSample,

        [EnumMember(Value = "heistequipment")]
        AnyHeistEquipment,

        [EnumMember(Value = "heistequipment.heistweapon")]
        HeistGear,

        [EnumMember(Value = "heistequipment.heisttool")]
        HeistTool,

        [EnumMember(Value = "heistequipment.heistutility")]
        HeistCloak,

        [EnumMember(Value = "heistequipment.heistreward")]
        HeistBrooch,

        [EnumMember(Value = "heistmission")]
        AnyHeistMission,

        [EnumMember(Value = "heistmission.contract")]
        HeistContract,

        [EnumMember(Value = "heistmission.blueprint")]
        HeistBlueprint,

        [EnumMember(Value = "currency")]
        AnyCurrency,

        [EnumMember(Value = "currency.piece")]
        UniqueFragment,

        [EnumMember(Value = "currency.resonator")]
        Resonator,

        [EnumMember(Value = "currency.fossil")]
        Fossil,

        [EnumMember(Value = "currency.incubator")]
        Incubator,

        [EnumMember(Value = "currency.heistobjective")]
        HeistTarget,
    }
}