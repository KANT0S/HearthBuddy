namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardDef")]
    public class CardDef : MonoBehaviour
    {
        public CardDef(IntPtr address) : this(address, "CardDef")
        {
        }

        public CardDef(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string DetermineActorNameForZone(Triton.Game.Mapping.Entity entity, TAG_ZONE zoneTag)
        {
            object[] objArray1 = new object[] { entity, zoneTag };
            return base.method_13("DetermineActorNameForZone", objArray1);
        }

        public SpellType DetermineSummonInSpell_HandToPlay(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<SpellType>("DetermineSummonInSpell_HandToPlay", objArray1);
        }

        public SpellType DetermineSummonOutSpell_HandToPlay(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<SpellType>("DetermineSummonOutSpell_HandToPlay", objArray1);
        }

        public Material GetCustomDeckPortrait()
        {
            return base.method_14<Material>("GetCustomDeckPortrait", Array.Empty<object>());
        }

        public Material GetDeckBoxPortrait()
        {
            return base.method_14<Material>("GetDeckBoxPortrait", Array.Empty<object>());
        }

        public Material GetDeckCardBarPortrait()
        {
            return base.method_14<Material>("GetDeckCardBarPortrait", Array.Empty<object>());
        }

        public Material GetDeckPickerPortrait()
        {
            return base.method_14<Material>("GetDeckPickerPortrait", Array.Empty<object>());
        }

        public Material GetEnchantmentPortrait()
        {
            return base.method_14<Material>("GetEnchantmentPortrait", Array.Empty<object>());
        }

        public Material GetHistoryTileFullPortrait()
        {
            return base.method_14<Material>("GetHistoryTileFullPortrait", Array.Empty<object>());
        }

        public Material GetHistoryTileHalfPortrait()
        {
            return base.method_14<Material>("GetHistoryTileHalfPortrait", Array.Empty<object>());
        }

        public CardPortraitQuality GetPortraitQuality()
        {
            return base.method_14<CardPortraitQuality>("GetPortraitQuality", Array.Empty<object>());
        }

        public Texture GetPortraitTexture()
        {
            return base.method_14<Texture>("GetPortraitTexture", Array.Empty<object>());
        }

        public Material GetPracticeAIPortrait()
        {
            return base.method_14<Material>("GetPracticeAIPortrait", Array.Empty<object>());
        }

        public Material GetPremiumPortraitMaterial()
        {
            return base.method_14<Material>("GetPremiumPortraitMaterial", Array.Empty<object>());
        }

        public bool IsPremiumLoaded()
        {
            return base.method_11<bool>("IsPremiumLoaded", Array.Empty<object>());
        }

        public void OnPortraitLoaded(Texture portrait, int quality)
        {
            object[] objArray1 = new object[] { portrait, quality };
            base.method_8("OnPortraitLoaded", objArray1);
        }

        public void OnPremiumMaterialLoaded(Material material, Texture portrait)
        {
            object[] objArray1 = new object[] { material, portrait };
            base.method_8("OnPremiumMaterialLoaded", objArray1);
        }

        public static int LARGE_MINION_COST
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CardDef", "LARGE_MINION_COST");
            }
        }

        public bool m_AlwaysRenderPremiumPortrait
        {
            get
            {
                return base.method_2<bool>("m_AlwaysRenderPremiumPortrait");
            }
        }

        public string m_AnnouncerLinePath
        {
            get
            {
                return base.method_4("m_AnnouncerLinePath");
            }
        }

        public CardEffectDef m_AttackEffectDef
        {
            get
            {
                return base.method_3<CardEffectDef>("m_AttackEffectDef");
            }
        }

        public string m_CustomDeathSpellPath
        {
            get
            {
                return base.method_4("m_CustomDeathSpellPath");
            }
        }

        public string m_CustomHeroArmorSpell
        {
            get
            {
                return base.method_4("m_CustomHeroArmorSpell");
            }
        }

        public string m_CustomHeroPhoneManaGem
        {
            get
            {
                return base.method_4("m_CustomHeroPhoneManaGem");
            }
        }

        public string m_CustomHeroPhoneTray
        {
            get
            {
                return base.method_4("m_CustomHeroPhoneTray");
            }
        }

        public string m_CustomHeroTray
        {
            get
            {
                return base.method_4("m_CustomHeroTray");
            }
        }

        public List<Board.CustomTraySettings> m_CustomHeroTraySettings
        {
            get
            {
                Class267<Board.CustomTraySettings> class2 = base.method_3<Class267<Board.CustomTraySettings>>("m_CustomHeroTraySettings");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_CustomKeywordSpellPath
        {
            get
            {
                return base.method_4("m_CustomKeywordSpellPath");
            }
        }

        public string m_CustomSpawnSpellPath
        {
            get
            {
                return base.method_4("m_CustomSpawnSpellPath");
            }
        }

        public string m_CustomSummonSpellPath
        {
            get
            {
                return base.method_4("m_CustomSummonSpellPath");
            }
        }

        public CardEffectDef m_DeathEffectDef
        {
            get
            {
                return base.method_3<CardEffectDef>("m_DeathEffectDef");
            }
        }

        public Material m_DeckBoxPortrait
        {
            get
            {
                return base.method_3<Material>("m_DeckBoxPortrait");
            }
        }

        public Material m_DeckCardBarPortrait
        {
            get
            {
                return base.method_3<Material>("m_DeckCardBarPortrait");
            }
        }

        public List<EmoteEntryDef> m_EmoteDefs
        {
            get
            {
                Class267<EmoteEntryDef> class2 = base.method_3<Class267<EmoteEntryDef>>("m_EmoteDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Material m_EnchantmentPortrait
        {
            get
            {
                return base.method_3<Material>("m_EnchantmentPortrait");
            }
        }

        public string m_GoldenCustomDeathSpellPath
        {
            get
            {
                return base.method_4("m_GoldenCustomDeathSpellPath");
            }
        }

        public string m_GoldenCustomSpawnSpellPath
        {
            get
            {
                return base.method_4("m_GoldenCustomSpawnSpellPath");
            }
        }

        public string m_GoldenCustomSummonSpellPath
        {
            get
            {
                return base.method_4("m_GoldenCustomSummonSpellPath");
            }
        }

        public Material m_HistoryTileFullPortrait
        {
            get
            {
                return base.method_3<Material>("m_HistoryTileFullPortrait");
            }
        }

        public Material m_HistoryTileHalfPortrait
        {
            get
            {
                return base.method_3<Material>("m_HistoryTileHalfPortrait");
            }
        }

        public CardEffectDef m_LifetimeEffectDef
        {
            get
            {
                return base.method_3<CardEffectDef>("m_LifetimeEffectDef");
            }
        }

        public Material m_LoadedCustomDeckPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedCustomDeckPortrait");
            }
        }

        public Material m_LoadedDeckBoxPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedDeckBoxPortrait");
            }
        }

        public Material m_LoadedDeckCardBarPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedDeckCardBarPortrait");
            }
        }

        public Material m_LoadedDeckPickerPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedDeckPickerPortrait");
            }
        }

        public Material m_LoadedEnchantmentPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedEnchantmentPortrait");
            }
        }

        public Material m_LoadedHistoryTileFullPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedHistoryTileFullPortrait");
            }
        }

        public Material m_LoadedHistoryTileHalfPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedHistoryTileHalfPortrait");
            }
        }

        public Texture m_LoadedPortraitTexture
        {
            get
            {
                return base.method_3<Texture>("m_LoadedPortraitTexture");
            }
        }

        public Material m_LoadedPracticeAIPortrait
        {
            get
            {
                return base.method_3<Material>("m_LoadedPracticeAIPortrait");
            }
        }

        public Material m_LoadedPremiumPortraitMaterial
        {
            get
            {
                return base.method_3<Material>("m_LoadedPremiumPortraitMaterial");
            }
        }

        public Texture m_LoadedPremiumPortraitTexture
        {
            get
            {
                return base.method_3<Texture>("m_LoadedPremiumPortraitTexture");
            }
        }

        public CardEffectDef m_PlayEffectDef
        {
            get
            {
                return base.method_3<CardEffectDef>("m_PlayEffectDef");
            }
        }

        public CardPortraitQuality m_portraitQuality
        {
            get
            {
                return base.method_3<CardPortraitQuality>("m_portraitQuality");
            }
        }

        public string m_PortraitTexturePath
        {
            get
            {
                return base.method_4("m_PortraitTexturePath");
            }
        }

        public Material m_PracticeAIPortrait
        {
            get
            {
                return base.method_3<Material>("m_PracticeAIPortrait");
            }
        }

        public string m_PremiumPortraitMaterialPath
        {
            get
            {
                return base.method_4("m_PremiumPortraitMaterialPath");
            }
        }

        public string m_PremiumPortraitTexturePath
        {
            get
            {
                return base.method_4("m_PremiumPortraitTexturePath");
            }
        }

        public string m_SocketInEffectFriendly
        {
            get
            {
                return base.method_4("m_SocketInEffectFriendly");
            }
        }

        public string m_SocketInEffectFriendlyPhone
        {
            get
            {
                return base.method_4("m_SocketInEffectFriendlyPhone");
            }
        }

        public string m_SocketInEffectOpponent
        {
            get
            {
                return base.method_4("m_SocketInEffectOpponent");
            }
        }

        public string m_SocketInEffectOpponentPhone
        {
            get
            {
                return base.method_4("m_SocketInEffectOpponentPhone");
            }
        }

        public bool m_SocketInOverrideHeroAnimation
        {
            get
            {
                return base.method_2<bool>("m_SocketInOverrideHeroAnimation");
            }
        }

        public bool m_SocketInParentEffectToHero
        {
            get
            {
                return base.method_2<bool>("m_SocketInParentEffectToHero");
            }
        }

        public List<CardEffectDef> m_SubOptionEffectDefs
        {
            get
            {
                Class267<CardEffectDef> class2 = base.method_3<Class267<CardEffectDef>>("m_SubOptionEffectDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_SuppressDeathrattleDeath
        {
            get
            {
                return base.method_2<bool>("m_SuppressDeathrattleDeath");
            }
        }

        public List<CardEffectDef> m_TriggerEffectDefs
        {
            get
            {
                Class267<CardEffectDef> class2 = base.method_3<Class267<CardEffectDef>>("m_TriggerEffectDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static int MEDIUM_MINION_COST
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CardDef", "MEDIUM_MINION_COST");
            }
        }
    }
}

