namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionPageDisplay")]
    public class CollectionPageDisplay : MonoBehaviour
    {
        public CollectionPageDisplay(IntPtr address) : this(address, "CollectionPageDisplay")
        {
        }

        public CollectionPageDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivatePageCountText(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ActivatePageCountText", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public CollectionCardVisual GetCardVisual(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_14<CollectionCardVisual>("GetCardVisual", objArray1);
        }

        public CollectionCardVisual GetCollectionCardVisual(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<CollectionCardVisual>("GetCollectionCardVisual", objArray1);
        }

        public static int GetMaxCardsPerPage()
        {
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "CollectionPageDisplay", "GetMaxCardsPerPage", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static int GetMaxCardsPerPage(CollectionManagerDisplay.ViewMode viewMode)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { viewMode };
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "CollectionPageDisplay", "GetMaxCardsPerPage", enumArray1, objArray1);
        }

        public void HideHeroSkinsDecor()
        {
            base.method_8("HideHeroSkinsDecor", Array.Empty<object>());
        }

        public void SetCardBacks()
        {
            base.method_8("SetCardBacks", Array.Empty<object>());
        }

        public static void SetClassFlavorTextures(GameObject header, HEADER_CLASS headerClass)
        {
            object[] objArray1 = new object[] { header, headerClass };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "CollectionPageDisplay", "SetClassFlavorTextures", objArray1);
        }

        public void SetClassNameText(string className)
        {
            object[] objArray1 = new object[] { className };
            base.method_8("SetClassNameText", objArray1);
        }

        public void SetDeckTemplates()
        {
            base.method_8("SetDeckTemplates", Array.Empty<object>());
        }

        public void SetHeroSkins(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            base.method_8("SetHeroSkins", objArray1);
        }

        public void SetPageCountText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetPageCountText", objArray1);
        }

        public void ShowNoMatchesFound(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowNoMatchesFound", objArray1);
        }

        public static HEADER_CLASS TagClassToHeaderClass(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return MonoClass.smethod_14<HEADER_CLASS>(TritonHs.MainAssemblyPath, "", "CollectionPageDisplay", "TagClassToHeaderClass", objArray1);
        }

        public void UpdateBasePage()
        {
            base.method_8("UpdateBasePage", Array.Empty<object>());
        }

        public void UpdateCurrentPageCardLocks(bool playSound)
        {
            object[] objArray1 = new object[] { playSound };
            base.method_8("UpdateCurrentPageCardLocks", objArray1);
        }

        public void UpdateDeckTemplatePage(Component deckTemplatePicker)
        {
            object[] objArray1 = new object[] { deckTemplatePicker };
            base.method_8("UpdateDeckTemplatePage", objArray1);
        }

        public void UpdateFavoriteCardBack(CollectionManagerDisplay.ViewMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("UpdateFavoriteCardBack", objArray1);
        }

        public void UpdateFavoriteHeroSkins(CollectionManagerDisplay.ViewMode mode, bool isMassDisenchanting)
        {
            object[] objArray1 = new object[] { mode, isMassDisenchanting };
            base.method_8("UpdateFavoriteHeroSkins", objArray1);
        }

        public void UpdateHeroSkinNames(CollectionManagerDisplay.ViewMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("UpdateHeroSkinNames", objArray1);
        }

        public GameObject m_basePage
        {
            get
            {
                return base.method_3<GameObject>("m_basePage");
            }
        }

        public Material m_basePageMaterial
        {
            get
            {
                return base.method_3<Material>("m_basePageMaterial");
            }
        }

        public GameObject m_cardStartPositionEightCards
        {
            get
            {
                return base.method_3<GameObject>("m_cardStartPositionEightCards");
            }
        }

        public GameObject m_classFlavorHeader
        {
            get
            {
                return base.method_3<GameObject>("m_classFlavorHeader");
            }
        }

        public UberText m_classNameText
        {
            get
            {
                return base.method_3<UberText>("m_classNameText");
            }
        }

        public List<CollectionCardVisual> m_collectionCardVisuals
        {
            get
            {
                Class267<CollectionCardVisual> class2 = base.method_3<Class267<CollectionCardVisual>>("m_collectionCardVisuals");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_deckTemplateContainer
        {
            get
            {
                return base.method_3<GameObject>("m_deckTemplateContainer");
            }
        }

        public Material m_deckTemplatePageMaterial
        {
            get
            {
                return base.method_3<Material>("m_deckTemplatePageMaterial");
            }
        }

        public GameObject m_heroSkinsDecor
        {
            get
            {
                return base.method_3<GameObject>("m_heroSkinsDecor");
            }
        }

        public UberText m_noMatchesFoundText
        {
            get
            {
                return base.method_3<UberText>("m_noMatchesFoundText");
            }
        }

        public UberText m_pageCountText
        {
            get
            {
                return base.method_3<UberText>("m_pageCountText");
            }
        }

        public static Color TAUPE_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "CollectionPageDisplay", "TAUPE_COLOR");
            }
        }

        public enum HEADER_CLASS
        {
            INVALID,
            SHAMAN,
            PALADIN,
            MAGE,
            DRUID,
            HUNTER,
            ROGUE,
            WARRIOR,
            PRIEST,
            WARLOCK,
            HEROSKINS,
            CARDBACKS
        }
    }
}

