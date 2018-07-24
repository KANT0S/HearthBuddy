namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionManagerDisplay")]
    public class CollectionManagerDisplay : MonoBehaviour
    {
        public CollectionManagerDisplay(IntPtr address) : this(address, "CollectionManagerDisplay")
        {
        }

        public CollectionManagerDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelSelectNewDeckHeroMode()
        {
            base.method_8("CancelSelectNewDeckHeroMode", Array.Empty<object>());
        }

        public bool CanViewCardBacks()
        {
            return base.method_11<bool>("CanViewCardBacks", Array.Empty<object>());
        }

        public bool CanViewHeroSkins()
        {
            return base.method_11<bool>("CanViewHeroSkins", Array.Empty<object>());
        }

        public void DoBookClosingAnimations()
        {
            base.method_8("DoBookClosingAnimations", Array.Empty<object>());
        }

        public void DoEnterCollectionManagerEvents()
        {
            base.method_8("DoEnterCollectionManagerEvents", Array.Empty<object>());
        }

        public void EnableInput(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableInput", objArray1);
        }

        public void EnableSearchUI(ViewMode viewMode)
        {
            object[] objArray1 = new object[] { viewMode };
            base.method_8("EnableSearchUI", objArray1);
        }

        public void EnterSelectNewDeckHeroMode()
        {
            base.method_8("EnterSelectNewDeckHeroMode", Array.Empty<object>());
        }

        public void Exit()
        {
            base.method_8("Exit", Array.Empty<object>());
        }

        public void ExitSelectNewDeckHeroMode()
        {
            base.method_8("ExitSelectNewDeckHeroMode", Array.Empty<object>());
        }

        public void FilterByManaCost(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("FilterByManaCost", objArray1);
        }

        public static CollectionManagerDisplay Get()
        {
            return MonoClass.smethod_15<CollectionManagerDisplay>(TritonHs.MainAssemblyPath, "", "CollectionManagerDisplay", "Get", Array.Empty<object>());
        }

        public Material GetCardNotOwnedMeshMaterial()
        {
            return base.method_14<Material>("GetCardNotOwnedMeshMaterial", Array.Empty<object>());
        }

        public CollectionCardVisual GetCardVisualPrefab()
        {
            return base.method_14<CollectionCardVisual>("GetCardVisualPrefab", Array.Empty<object>());
        }

        public static string GetClassTextureName(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "CollectionManagerDisplay", "GetClassTextureName", objArray1);
        }

        public CollectionPageLayoutSettings.Variables GetCurrentPageLayoutSettings()
        {
            return base.method_14<CollectionPageLayoutSettings.Variables>("GetCurrentPageLayoutSettings", Array.Empty<object>());
        }

        public TAG_CLASS GetDeckHeroClass(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            return base.method_11<TAG_CLASS>("GetDeckHeroClass", objArray1);
        }

        public Material GetGoldenCardNotOwnedMeshMaterial()
        {
            return base.method_14<Material>("GetGoldenCardNotOwnedMeshMaterial", Array.Empty<object>());
        }

        public HeroPickerDisplay GetHeroPickerDisplay()
        {
            return base.method_14<HeroPickerDisplay>("GetHeroPickerDisplay", Array.Empty<object>());
        }

        public CollectionPageLayoutSettings.Variables GetPageLayoutSettings(ViewMode viewMode)
        {
            object[] objArray1 = new object[] { viewMode };
            return base.method_14<CollectionPageLayoutSettings.Variables>("GetPageLayoutSettings", objArray1);
        }

        public DeckTemplatePicker GetPhoneDeckTemplateTray()
        {
            return base.method_14<DeckTemplatePicker>("GetPhoneDeckTemplateTray", Array.Empty<object>());
        }

        public ViewMode GetViewMode()
        {
            return base.method_11<ViewMode>("GetViewMode", Array.Empty<object>());
        }

        public void GoToPageWithCard(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            base.method_8("GoToPageWithCard", objArray1);
        }

        public void HideAllTips()
        {
            base.method_8("HideAllTips", Array.Empty<object>());
        }

        public void HideCraftingTray()
        {
            base.method_8("HideCraftingTray", Array.Empty<object>());
        }

        public void HideDeckHelpPopup()
        {
            base.method_8("HideDeckHelpPopup", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void LoadAllClassTextures()
        {
            base.method_8("LoadAllClassTextures", Array.Empty<object>());
        }

        public bool NewDeckButtonAvailable()
        {
            return base.method_11<bool>("NewDeckButtonAvailable", Array.Empty<object>());
        }

        public void OnCardRewardInserted(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            base.method_8("OnCardRewardInserted", objArray1);
        }

        public void OnCardTileRightClicked(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileRightClicked", objArray1);
        }

        public void OnClassTextureLoaded(string assetName, object asset, object callbackData)
        {
            object[] objArray1 = new object[] { assetName, asset, callbackData };
            base.method_8("OnClassTextureLoaded", objArray1);
        }

        public void OnCollectionChanged()
        {
            base.method_8("OnCollectionChanged", Array.Empty<object>());
        }

        public void OnCollectionLoaded()
        {
            base.method_8("OnCollectionLoaded", Array.Empty<object>());
        }

        public void OnCoverLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnCoverLoaded", objArray1);
        }

        public void OnCoverOpened()
        {
            base.method_8("OnCoverOpened", Array.Empty<object>());
        }

        public void OnCraftingModeButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCraftingModeButtonReleased", objArray1);
        }

        public void OnCraftingTrayLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnCraftingTrayLoaded", objArray1);
        }

        public void OnDeckContents(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("OnDeckContents", objArray1);
        }

        public void OnDeckCreated(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("OnDeckCreated", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDoneEditingDeck()
        {
            base.method_8("OnDoneEditingDeck", Array.Empty<object>());
        }

        public void OnInputBlockerRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInputBlockerRelease", objArray1);
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnNewCardSeen(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            base.method_8("OnNewCardSeen", objArray1);
        }

        public void OnSearchActivated()
        {
            base.method_8("OnSearchActivated", Array.Empty<object>());
        }

        public void OnSearchCleared(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnSearchCleared", objArray1);
        }

        public void OnSearchDeactivated(string oldSearchText, string newSearchText)
        {
            object[] objArray1 = new object[] { oldSearchText, newSearchText };
            base.method_8("OnSearchDeactivated", objArray1);
        }

        public void OnShowAdvancedCMChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnShowAdvancedCMChanged", objArray1);
        }

        public void OnSwitchViewModeResponse(bool triggerResponse, ViewMode prevMode, ViewMode newMode, ViewModeData userdata)
        {
            object[] objArray1 = new object[] { triggerResponse, prevMode, newMode, userdata };
            base.method_8("OnSwitchViewModeResponse", objArray1);
        }

        public void OpenBookImmediately()
        {
            base.method_8("OpenBookImmediately", Array.Empty<object>());
        }

        public void RequestContentsToShowDeck(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("RequestContentsToShowDeck", objArray1);
        }

        public void ResetFilters(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("ResetFilters", objArray1);
        }

        public void SetTavernBrawlTexturesIfNecessary()
        {
            base.method_8("SetTavernBrawlTexturesIfNecessary", Array.Empty<object>());
        }

        public void SetViewMode(ViewMode mode, ViewModeData userdata)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Class };
            object[] objArray1 = new object[] { mode, userdata };
            base.method_9("SetViewMode", enumArray1, objArray1);
        }

        public void SetViewMode(ViewMode mode, bool triggerResponse, ViewModeData userdata)
        {
            object[] objArray1 = new object[] { mode, triggerResponse, userdata };
            base.method_9("SetViewMode", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public bool ShouldShowNewCardGlow(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<bool>("ShouldShowNewCardGlow", objArray1);
        }

        public void ShowAdvancedCollectionManager(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowAdvancedCollectionManager", objArray1);
        }

        public void ShowCompleteAchieve(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ShowCompleteAchieve", objArray1);
        }

        public void ShowCraftingTipIfNeeded()
        {
            base.method_8("ShowCraftingTipIfNeeded", Array.Empty<object>());
        }

        public void ShowDeck(long deckID, bool isNewDeck)
        {
            object[] objArray1 = new object[] { deckID, isNewDeck };
            base.method_8("ShowDeck", objArray1);
        }

        public void ShowInnkeeeprLClickHelp(bool isHero)
        {
            object[] objArray1 = new object[] { isHero };
            base.method_8("ShowInnkeeeprLClickHelp", objArray1);
        }

        public void ShowOnlyCardsIOwn()
        {
            base.method_9("ShowOnlyCardsIOwn", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ShowOnlyCardsIOwn(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            base.method_9("ShowOnlyCardsIOwn", enumArray1, objArray1);
        }

        public void ShowPhoneDeckTemplateTray()
        {
            base.method_8("ShowPhoneDeckTemplateTray", Array.Empty<object>());
        }

        public void ShowPremiumCardsNotOwned(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowPremiumCardsNotOwned", objArray1);
        }

        public void ShowPremiumCardsOnly()
        {
            base.method_8("ShowPremiumCardsOnly", Array.Empty<object>());
        }

        public void ShowSet(object data)
        {
            object[] objArray1 = new object[] { data };
            base.method_8("ShowSet", objArray1);
        }

        public void ShowTavernBrawlDeck(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("ShowTavernBrawlDeck", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void UnloadAllClassTextures()
        {
            base.method_8("UnloadAllClassTextures", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateCurrentPageCardLocks(bool playSound)
        {
            object[] objArray1 = new object[] { playSound };
            base.method_8("UpdateCurrentPageCardLocks", objArray1);
        }

        public static float CRAFTING_TRAY_SLIDE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionManagerDisplay", "CRAFTING_TRAY_SLIDE_IN_TIME");
            }
        }

        public GameObject m_activeSearchBone
        {
            get
            {
                return base.method_3<GameObject>("m_activeSearchBone");
            }
        }

        public GameObject m_activeSearchBone_Win8
        {
            get
            {
                return base.method_3<GameObject>("m_activeSearchBone_Win8");
            }
        }

        public GameObject m_bookBack
        {
            get
            {
                return base.method_3<GameObject>("m_bookBack");
            }
        }

        public List<Actor> m_cardActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_cardActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Actor> m_cardBackActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_cardBackActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Material m_cardNotOwnedMeshMaterial
        {
            get
            {
                return base.method_3<Material>("m_cardNotOwnedMeshMaterial");
            }
        }

        public CollectionCardVisual m_cardVisualPrefab
        {
            get
            {
                return base.method_3<CollectionCardVisual>("m_cardVisualPrefab");
            }
        }

        public List<Achievement> m_completeAchievesToDisplay
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_completeAchievesToDisplay");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_corkBackTexture
        {
            get
            {
                return base.method_4("m_corkBackTexture");
            }
        }

        public CollectionCoverDisplay m_cover
        {
            get
            {
                return base.method_3<CollectionCoverDisplay>("m_cover");
            }
        }

        public CraftingModeButton m_craftingModeButton
        {
            get
            {
                return base.method_3<CraftingModeButton>("m_craftingModeButton");
            }
        }

        public CraftingTray m_craftingTray
        {
            get
            {
                return base.method_3<CraftingTray>("m_craftingTray");
            }
        }

        public GameObject m_craftingTrayHiddenBone
        {
            get
            {
                return base.method_3<GameObject>("m_craftingTrayHiddenBone");
            }
        }

        public GameObject m_craftingTrayShownBone
        {
            get
            {
                return base.method_3<GameObject>("m_craftingTrayShownBone");
            }
        }

        public ViewMode m_currentViewMode
        {
            get
            {
                return base.method_2<ViewMode>("m_currentViewMode");
            }
        }

        public Triton.Game.Mapping.Notification m_deckHelpPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_deckHelpPopup");
            }
        }

        public Triton.Game.Mapping.Notification m_deckTemplateCardReplacePopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_deckTemplateCardReplacePopup");
            }
        }

        public Transform m_deckTemplateHiddenBone
        {
            get
            {
                return base.method_3<Transform>("m_deckTemplateHiddenBone");
            }
        }

        public DeckTemplatePicker m_deckTemplatePickerPhone
        {
            get
            {
                return base.method_3<DeckTemplatePicker>("m_deckTemplatePickerPhone");
            }
        }

        public Transform m_deckTemplateShownBone
        {
            get
            {
                return base.method_3<Transform>("m_deckTemplateShownBone");
            }
        }

        public Transform m_deckTemplateTutorialReminderBone
        {
            get
            {
                return base.method_3<Transform>("m_deckTemplateTutorialReminderBone");
            }
        }

        public Transform m_deckTemplateTutorialWelcomeBone
        {
            get
            {
                return base.method_3<Transform>("m_deckTemplateTutorialWelcomeBone");
            }
        }

        public int m_displayRequestID
        {
            get
            {
                return base.method_2<int>("m_displayRequestID");
            }
        }

        public Transform m_editDeckTutorialBone
        {
            get
            {
                return base.method_3<Transform>("m_editDeckTutorialBone");
            }
        }

        public ActiveFilterButton m_filterButton
        {
            get
            {
                return base.method_3<ActiveFilterButton>("m_filterButton");
            }
        }

        public Material m_goldenCardNotOwnedMeshMaterial
        {
            get
            {
                return base.method_3<Material>("m_goldenCardNotOwnedMeshMaterial");
            }
        }

        public HeroPickerDisplay m_heroPickerDisplay
        {
            get
            {
                return base.method_3<HeroPickerDisplay>("m_heroPickerDisplay");
            }
        }

        public Triton.Game.Mapping.Notification m_innkeeperLClickReminder
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_innkeeperLClickReminder");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public int m_inputBlockers
        {
            get
            {
                return base.method_2<int>("m_inputBlockers");
            }
        }

        public bool m_isCoverLoading
        {
            get
            {
                return base.method_2<bool>("m_isCoverLoading");
            }
        }

        public bool m_isReady
        {
            get
            {
                return base.method_2<bool>("m_isReady");
            }
        }

        public List<CardSetIconMatOffset> m_manaFilterCardSetIcons
        {
            get
            {
                Class267<CardSetIconMatOffset> class2 = base.method_3<Class267<CardSetIconMatOffset>>("m_manaFilterCardSetIcons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ManaFilterTabManager m_manaTabManager
        {
            get
            {
                return base.method_3<ManaFilterTabManager>("m_manaTabManager");
            }
        }

        public bool m_netCacheReady
        {
            get
            {
                return base.method_2<bool>("m_netCacheReady");
            }
        }

        public CollectionPageLayoutSettings m_pageLayoutSettings
        {
            get
            {
                return base.method_3<CollectionPageLayoutSettings>("m_pageLayoutSettings");
            }
        }

        public CollectionPageManager m_pageManager
        {
            get
            {
                return base.method_3<CollectionPageManager>("m_pageManager");
            }
        }

        public List<Actor> m_previousCardActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_previousCardActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Actor> m_previousCardBackActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_previousCardBackActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CollectionSearch m_search
        {
            get
            {
                return base.method_3<CollectionSearch>("m_search");
            }
        }

        public bool m_selectingNewDeckHero
        {
            get
            {
                return base.method_2<bool>("m_selectingNewDeckHero");
            }
        }

        public CollectionSetFilterDropdown m_setFilterDropdown
        {
            get
            {
                return base.method_3<CollectionSetFilterDropdown>("m_setFilterDropdown");
            }
        }

        public long m_showDeckContentsRequest
        {
            get
            {
                return base.method_2<long>("m_showDeckContentsRequest");
            }
        }

        public bool m_sortRibbonsInitialized
        {
            get
            {
                return base.method_2<bool>("m_sortRibbonsInitialized");
            }
        }

        public Mesh m_tavernBrawlBookBackMesh
        {
            get
            {
                return base.method_3<Mesh>("m_tavernBrawlBookBackMesh");
            }
        }

        public Material m_tavernBrawlElements
        {
            get
            {
                return base.method_3<Material>("m_tavernBrawlElements");
            }
        }

        public List<GameObject> m_tavernBrawlObjectsToSwap
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_tavernBrawlObjectsToSwap");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_unloading
        {
            get
            {
                return base.method_2<bool>("m_unloading");
            }
        }

        [Attribute38("CollectionManagerDisplay.CardSetIconMatOffset")]
        public class CardSetIconMatOffset : MonoClass
        {
            public CardSetIconMatOffset(IntPtr address) : this(address, "CardSetIconMatOffset")
            {
            }

            public CardSetIconMatOffset(IntPtr address, string className) : base(address, className)
            {
            }

            public TAG_CARD_SET m_cardSet
            {
                get
                {
                    return base.method_2<TAG_CARD_SET>("m_cardSet");
                }
            }

            public Vector2 m_offset
            {
                get
                {
                    return base.method_2<Vector2>("m_offset");
                }
            }
        }

        [Attribute38("CollectionManagerDisplay.TextureRequests")]
        public class TextureRequests : MonoClass
        {
            public TextureRequests(IntPtr address) : this(address, "TextureRequests")
            {
            }

            public TextureRequests(IntPtr address, string className) : base(address, className)
            {
            }

            public List<Request> m_requests
            {
                get
                {
                    Class267<Request> class2 = base.method_3<Class267<Request>>("m_requests");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            [Attribute38("CollectionManagerDisplay.TextureRequests.Request")]
            public class Request : MonoClass
            {
                public Request(IntPtr address) : this(address, "Request")
                {
                }

                public Request(IntPtr address, string className) : base(address, className)
                {
                }

                public object m_callbackData
                {
                    get
                    {
                        return base.method_3<object>("m_callbackData");
                    }
                }
            }
        }

        public enum ViewMode
        {
            CARDS,
            HERO_SKINS,
            CARD_BACKS,
            DECK_TEMPLATE,
            COUNT
        }

        [Attribute38("CollectionManagerDisplay.ViewModeData")]
        public class ViewModeData : MonoClass
        {
            public ViewModeData(IntPtr address) : this(address, "ViewModeData")
            {
            }

            public ViewModeData(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_pageTransitionCompleteData
            {
                get
                {
                    return base.method_3<object>("m_pageTransitionCompleteData");
                }
            }

            public string m_setPageByCard
            {
                get
                {
                    return base.method_4("m_setPageByCard");
                }
            }

            public TAG_PREMIUM m_setPageByPremium
            {
                get
                {
                    return base.method_2<TAG_PREMIUM>("m_setPageByPremium");
                }
            }
        }
    }
}

