namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ActorNames")]
    public class ActorNames : MonoClass
    {
        public ActorNames(IntPtr address) : this(address, "ActorNames")
        {
        }

        public ActorNames(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GetBigCardActor(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ActorNames", "GetBigCardActor", objArray1);
        }

        public static string GetHandActor(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHandActor", enumArray1, objArray1);
        }

        public static string GetHandActor(EntityDef entityDef)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entityDef };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHandActor", enumArray1, objArray1);
        }

        public static string GetHandActor(TAG_CARDTYPE cardType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardType };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHandActor", enumArray1, objArray1);
        }

        public static string GetHandActor(EntityDef entityDef, TAG_PREMIUM premiumType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entityDef, premiumType };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHandActor", enumArray1, objArray1);
        }

        public static string GetHandActor(TAG_CARDTYPE cardType, TAG_PREMIUM premiumType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardType, premiumType };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHandActor", enumArray1, objArray1);
        }

        public static string GetHeroSkinOrHandActor(TAG_CARDTYPE type, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { type, premium };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHeroSkinOrHandActor", objArray1);
        }

        public static string GetHistoryActor(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHistoryActor", objArray1);
        }

        public static string GetHistorySecretActor(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ActorNames", "GetHistorySecretActor", objArray1);
        }

        public static string GetNameWithPremiumType(string actorName, TAG_PREMIUM premiumType)
        {
            object[] objArray1 = new object[] { actorName, premiumType };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ActorNames", "GetNameWithPremiumType", objArray1);
        }

        public static string GetZoneActor(Triton.Game.Mapping.Entity entity, TAG_ZONE zoneTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entity, zoneTag };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetZoneActor", enumArray1, objArray1);
        }

        public static string GetZoneActor(EntityDef entityDef, TAG_ZONE zoneTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entityDef, zoneTag };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetZoneActor", enumArray1, objArray1);
        }

        public static string GetZoneActor(EntityDef entityDef, TAG_ZONE zoneTag, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { entityDef, zoneTag, premium };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetZoneActor", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static string GetZoneActor(TAG_CARDTYPE cardType, TAG_CLASS classTag, TAG_ZONE zoneTag, Player controller, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardType, classTag, zoneTag, controller, premium };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ActorNames", "GetZoneActor", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public static bool ShouldObfuscate(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ActorNames", "ShouldObfuscate", objArray1);
        }

        public static string COLLECTION_CARD_BACK
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "COLLECTION_CARD_BACK");
            }
        }

        public static string COLLECTION_DECK_TILE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "COLLECTION_DECK_TILE");
            }
        }

        public static string COLLECTION_DECK_TILE_PHONE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "COLLECTION_DECK_TILE_PHONE");
            }
        }

        public static string HAND_FATIGUE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HAND_FATIGUE");
            }
        }

        public static string HAND_MINION
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HAND_MINION");
            }
        }

        public static string HAND_SPELL
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HAND_SPELL");
            }
        }

        public static string HAND_WEAPON
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HAND_WEAPON");
            }
        }

        public static string HERO_SKIN
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HERO_SKIN");
            }
        }

        public static string HEROPICKER_HERO
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HEROPICKER_HERO");
            }
        }

        public static string HIDDEN
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HIDDEN");
            }
        }

        public static string HISTORY_HERO
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_HERO");
            }
        }

        public static string HISTORY_HERO_POWER
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_HERO_POWER");
            }
        }

        public static string HISTORY_HERO_POWER_OPPONENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_HERO_POWER_OPPONENT");
            }
        }

        public static string HISTORY_OBFUSCATED
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_OBFUSCATED");
            }
        }

        public static string HISTORY_SECRET_HUNTER
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_SECRET_HUNTER");
            }
        }

        public static string HISTORY_SECRET_MAGE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_SECRET_MAGE");
            }
        }

        public static string HISTORY_SECRET_PALADIN
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "HISTORY_SECRET_PALADIN");
            }
        }

        public static string INVISIBLE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "INVISIBLE");
            }
        }

        public static string PLAY_ENCHANTMENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "PLAY_ENCHANTMENT");
            }
        }

        public static string PLAY_HERO
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "PLAY_HERO");
            }
        }

        public static string PLAY_HERO_POWER
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "PLAY_HERO_POWER");
            }
        }

        public static string PLAY_MINION
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "PLAY_MINION");
            }
        }

        public static string PLAY_OBFUSCATED
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "PLAY_OBFUSCATED");
            }
        }

        public static string PLAY_WEAPON
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "PLAY_WEAPON");
            }
        }

        public static string SECRET
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "SECRET");
            }
        }

        public static string SECRET_HUNTER
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "SECRET_HUNTER");
            }
        }

        public static string SECRET_MAGE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "SECRET_MAGE");
            }
        }

        public static string SECRET_PALADIN
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "SECRET_PALADIN");
            }
        }

        public static string TOOLTIP
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ActorNames", "TOOLTIP");
            }
        }
    }
}

