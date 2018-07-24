namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EntityDef")]
    public class EntityDef : EntityBase
    {
        public EntityDef(IntPtr address) : this(address, "EntityDef")
        {
        }

        public EntityDef(IntPtr address, string className) : base(address, className)
        {
        }

        public EntityDef Clone()
        {
            return base.method_14<EntityDef>("Clone", Array.Empty<object>());
        }

        public void FlushPower()
        {
            base.method_8("FlushPower", Array.Empty<object>());
        }

        public string GetArtistName()
        {
            return base.method_13("GetArtistName", Array.Empty<object>());
        }

        public Power GetAttackPower()
        {
            return base.method_14<Power>("GetAttackPower", Array.Empty<object>());
        }

        public string GetCardId()
        {
            return base.method_13("GetCardId", Array.Empty<object>());
        }

        public string GetCardTextInHand()
        {
            return base.method_13("GetCardTextInHand", Array.Empty<object>());
        }

        public TAG_CLASS GetClass()
        {
            return base.method_11<TAG_CLASS>("GetClass", Array.Empty<object>());
        }

        public string GetDebugName()
        {
            return base.method_13("GetDebugName", Array.Empty<object>());
        }

        public TAG_ENCHANTMENT_VISUAL GetEnchantmentBirthVisual()
        {
            return base.method_11<TAG_ENCHANTMENT_VISUAL>("GetEnchantmentBirthVisual", Array.Empty<object>());
        }

        public TAG_ENCHANTMENT_VISUAL GetEnchantmentIdleVisual()
        {
            return base.method_11<TAG_ENCHANTMENT_VISUAL>("GetEnchantmentIdleVisual", Array.Empty<object>());
        }

        public List<string> GetEntourageCardIDs()
        {
            Class268 class2 = base.method_14<Class268>("GetEntourageCardIDs", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public string GetFlavorText()
        {
            return base.method_13("GetFlavorText", Array.Empty<object>());
        }

        public string GetHowToEarnText(TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { premium };
            return base.method_13("GetHowToEarnText", objArray1);
        }

        public Power GetMasterPower()
        {
            return base.method_14<Power>("GetMasterPower", Array.Empty<object>());
        }

        public string GetName()
        {
            return base.method_13("GetName", Array.Empty<object>());
        }

        public PowerHistoryInfo GetPowerHistoryInfo(int effectIndex)
        {
            object[] objArray1 = new object[] { effectIndex };
            return base.method_14<PowerHistoryInfo>("GetPowerHistoryInfo", objArray1);
        }

        public TAG_RACE GetRace()
        {
            return base.method_11<TAG_RACE>("GetRace", Array.Empty<object>());
        }

        public string GetRaceText()
        {
            return base.method_13("GetRaceText", Array.Empty<object>());
        }

        public TAG_RARITY GetRarity()
        {
            return base.method_11<TAG_RARITY>("GetRarity", Array.Empty<object>());
        }

        public int GetReferencedTag(int tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_11<int>("GetReferencedTag", objArray1);
        }

        public TagSet GetReferencedTags()
        {
            return base.method_14<TagSet>("GetReferencedTags", Array.Empty<object>());
        }

        public string GetStringTag(int tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_13("GetStringTag", objArray1);
        }

        public bool LoadDataFromCardXml(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            return base.method_11<bool>("LoadDataFromCardXml", objArray1);
        }

        public static EntityDef LoadFromString(string cardId, string xmlText, bool overrideCardId)
        {
            object[] objArray1 = new object[] { cardId, xmlText, overrideCardId };
            return MonoClass.smethod_15<EntityDef>(TritonHs.MainAssemblyPath, "", "EntityDef", "LoadFromString", objArray1);
        }

        public void ReadEntourage(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            base.method_8("ReadEntourage", objArray1);
        }

        public void ReadMasterPower(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            base.method_8("ReadMasterPower", objArray1);
        }

        public void ReadPlayRequirement(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            base.method_8("ReadPlayRequirement", objArray1);
        }

        public void ReadPower(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            base.method_8("ReadPower", objArray1);
        }

        public void ReadReferencedTag(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            base.method_8("ReadReferencedTag", objArray1);
        }

        public void ReadStringTagWithAllLocales(XmlReader reader, int tag)
        {
            object[] objArray1 = new object[] { reader, tag };
            base.method_8("ReadStringTagWithAllLocales", objArray1);
        }

        public void ReadStringTagWithSingleLocale(XmlReader reader, int tag)
        {
            object[] objArray1 = new object[] { reader, tag };
            base.method_8("ReadStringTagWithSingleLocale", objArray1);
        }

        public bool ReadTag(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            return base.method_11<bool>("ReadTag", objArray1);
        }

        public void ReadTriggeredPowerHistoryInfo(XmlReader reader)
        {
            object[] objArray1 = new object[] { reader };
            base.method_8("ReadTriggeredPowerHistoryInfo", objArray1);
        }

        public void SetCardId(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            base.method_8("SetCardId", objArray1);
        }

        public void SetReferencedTag(int tag, int val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { tag, val };
            base.method_9("SetReferencedTag", enumArray1, objArray1);
        }

        public void SetReferencedTag(GAME_TAG enumTag, int val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { enumTag, val };
            base.method_9("SetReferencedTag", enumArray1, objArray1);
        }

        public void SetStringTag(int tag, string val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.String };
            object[] objArray1 = new object[] { tag, val };
            base.method_9("SetStringTag", enumArray1, objArray1);
        }

        public void SetStringTag(GAME_TAG enumTag, string val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.String };
            object[] objArray1 = new object[] { enumTag, val };
            base.method_9("SetStringTag", enumArray1, objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public string m_cardId
        {
            get
            {
                return base.method_4("m_cardId");
            }
        }

        public string m_currLoadingPowerDefinition
        {
            get
            {
                return base.method_4("m_currLoadingPowerDefinition");
            }
        }

        public List<Power.PowerInfo> m_currLoadingPowerInfos
        {
            get
            {
                Class266<Power.PowerInfo> class2 = base.method_3<Class266<Power.PowerInfo>>("m_currLoadingPowerInfos");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_entourageCardIDs
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_entourageCardIDs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_masterPower
        {
            get
            {
                return base.method_4("m_masterPower");
            }
        }

        public List<PowerHistoryInfo> m_powerHistoryInfoList
        {
            get
            {
                Class267<PowerHistoryInfo> class2 = base.method_3<Class267<PowerHistoryInfo>>("m_powerHistoryInfoList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public TagSet m_referencedTags
        {
            get
            {
                return base.method_3<TagSet>("m_referencedTags");
            }
        }
    }
}

