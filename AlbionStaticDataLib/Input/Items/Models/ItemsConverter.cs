﻿using System.Text.Json;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public static class ItemsConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                HidefromplayeroncontextConverter.Singleton,
                ShopConverter.Singleton,
                UispriteoverlayConverter.Singleton,
                ConsumablefrominventoryitemCraftingrequirementsConverter.Singleton,
                CraftingrequirementCraftresourceUnionConverter.Singleton,
                UniquenameConverter.Singleton,
                FactionConverter.Singleton,
                SlottypeEnumConverter.Singleton,
                EnchantmentUnionConverter.Singleton,
                NamelocatagConverter.Singleton,
                EquipmentitemDescriptionlocatagConverter.Singleton,
                FacestateConverter.Singleton,
                IontypeConverter.Singleton,
                ItempowerprogressiontypeEnumConverter.Singleton,
                EquipmentitemUicraftsoundfinishConverter.Singleton,
                EquipmentitemUicraftsoundstartConverter.Singleton,
                EquipmentitemCraftingrequirementsConverter.Singleton,
                StickyCraftspellConverter.Singleton,
                KindConverter.Singleton,
                FurnitureitemDescriptionlocatagConverter.Singleton,
                LabourerfurnituretypeConverter.Singleton,
                LabourersaffectedConverter.Singleton,
                FurnitureitemUicraftsoundfinishConverter.Singleton,
                FurnitureitemUicraftsoundstartConverter.Singleton,
                FurnitureitemCraftingrequirementsConverter.Singleton,
                PurpleCraftresourceConverter.Singleton,
                LootUnionConverter.Singleton,
                ForceddismountbuffConverter.Singleton,
                HostiledismountbuffConverter.Singleton,
                LonghostiledismountbuffConverter.Singleton,
                SlottypeConverter.Singleton,
                MountUicraftsoundfinishConverter.Singleton,
                MountUicraftsoundstartConverter.Singleton,
                FluffyCraftresourceConverter.Singleton,
                MountspellUnionConverter.Singleton,
                SpellslotConverter.Singleton,
                SimpleitemCraftingrequirementsConverter.Singleton,
                WeaponDescriptionlocatagConverter.Singleton,
                FxbonenameConverter.Singleton,
                FxboneoffsetConverter.Singleton,
                MainhandanimationtypeAttackConverter.Singleton,
                PrefabConverter.Singleton,
                SocketConverter.Singleton,
                TargetConverter.Singleton,
                VisibilityConverter.Singleton,
                WeaponCraftingrequirementsConverter.Singleton,
                IndigoCraftspellConverter.Singleton,
                TagConverter.Singleton,
                ProjectileUnionConverter.Singleton,
                StartsocketConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }
}
