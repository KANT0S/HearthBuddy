namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionPageManager")]
    public class CollectionPageManager : MonoBehaviour
    {
        public CollectionPageManager(IntPtr address) : this(address, "CollectionPageManager")
        {
        }

        public CollectionPageManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateArrows(bool leftArrow, bool rightArrow)
        {
            object[] objArray1 = new object[] { leftArrow, rightArrow };
            base.method_8("ActivateArrows", objArray1);
        }

        public bool ArePagesTurning()
        {
            return base.method_11<bool>("ArePagesTurning", Array.Empty<object>());
        }

        public bool AssembleBasePage(TransitionReadyCallbackData transitionReadyCallbackData, bool emptyPage)
        {
            object[] objArray1 = new object[] { transitionReadyCallbackData, emptyPage };
            return base.method_11<bool>("AssembleBasePage", objArray1);
        }

        public void AssembleCardBackPage(TransitionReadyCallbackData transitionReadyCallbackData)
        {
            object[] objArray1 = new object[] { transitionReadyCallbackData };
            base.method_8("AssembleCardBackPage", objArray1);
        }

        public void AssembleDeckTemplatePage(TransitionReadyCallbackData transitionReadyCallbackData)
        {
            object[] objArray1 = new object[] { transitionReadyCallbackData };
            base.method_8("AssembleDeckTemplatePage", objArray1);
        }

        public void AssembleEmptyPageUI(CollectionPageDisplay page, bool displayNoMatchesText)
        {
            object[] objArray1 = new object[] { page, displayNoMatchesText };
            base.method_8("AssembleEmptyPageUI", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChangeSearchTextFilter(string newSearchText, bool updateVisuals)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { newSearchText, updateVisuals };
            base.method_9("ChangeSearchTextFilter", enumArray1, objArray1);
        }

        public void DeselectCurrentClassTab()
        {
            base.method_8("DeselectCurrentClassTab", Array.Empty<object>());
        }

        public void FilterByManaCost(int cost)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { cost };
            base.method_9("FilterByManaCost", enumArray1, objArray1);
        }

        public CollectionPageDisplay GetAlternatePage()
        {
            return base.method_14<CollectionPageDisplay>("GetAlternatePage", Array.Empty<object>());
        }

        public CollectionCardVisual GetCardVisual(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_14<CollectionCardVisual>("GetCardVisual", objArray1);
        }

        public CollectionPageDisplay GetCurrentPage()
        {
            return base.method_14<CollectionPageDisplay>("GetCurrentPage", Array.Empty<object>());
        }

        public DeckTemplatePicker GetDeckTemplatePicker()
        {
            return base.method_14<DeckTemplatePicker>("GetDeckTemplatePicker", Array.Empty<object>());
        }

        public int GetLastPageInCurrentMode()
        {
            return base.method_11<int>("GetLastPageInCurrentMode", Array.Empty<object>());
        }

        public int GetMassDisenchantAmount()
        {
            return base.method_11<int>("GetMassDisenchantAmount", Array.Empty<object>());
        }

        public int GetNumNewCardsForClass(TAG_CLASS tagClass)
        {
            object[] objArray1 = new object[] { tagClass };
            return base.method_11<int>("GetNumNewCardsForClass", objArray1);
        }

        public int GetNumPagesForClass(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return base.method_11<int>("GetNumPagesForClass", objArray1);
        }

        public void HideMassDisenchant()
        {
            base.method_8("HideMassDisenchant", Array.Empty<object>());
        }

        public bool HideNonDeckTemplateTabs(bool hide, bool updateTabs)
        {
            object[] objArray1 = new object[] { hide, updateTabs };
            return base.method_11<bool>("HideNonDeckTemplateTabs", objArray1);
        }

        public bool IsFullyLoaded()
        {
            return base.method_11<bool>("IsFullyLoaded", Array.Empty<object>());
        }

        public bool IsNonDeckTemplateTabsHidden()
        {
            return base.method_11<bool>("IsNonDeckTemplateTabsHidden", Array.Empty<object>());
        }

        public bool IsShowingMassDisenchant()
        {
            return base.method_11<bool>("IsShowingMassDisenchant", Array.Empty<object>());
        }

        public void JumpToCollectionClassPage(TAG_CLASS pageClass)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { pageClass };
            base.method_9("JumpToCollectionClassPage", enumArray1, objArray1);
        }

        public bool JumpToPageWithCard(string cardID, TAG_PREMIUM premium)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_10<bool>("JumpToPageWithCard", enumArray1, objArray1);
        }

        public void LoadMassDisenchantScreen()
        {
            base.method_8("LoadMassDisenchantScreen", Array.Empty<object>());
        }

        public void LoadPagingArrows()
        {
            base.method_8("LoadPagingArrows", Array.Empty<object>());
        }

        public void NotifyOfCollectionChanged()
        {
            base.method_8("NotifyOfCollectionChanged", Array.Empty<object>());
        }

        public void OnBookOpening()
        {
            base.method_8("OnBookOpening", Array.Empty<object>());
        }

        public void OnCardBacksTabPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCardBacksTabPressed", objArray1);
        }

        public void OnClassTabPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClassTabPressed", objArray1);
        }

        public void OnCollectionLoaded()
        {
            base.method_8("OnCollectionLoaded", Array.Empty<object>());
        }

        public void OnCollectionManagerViewModeChanged(CollectionManagerDisplay.ViewMode prevMode, CollectionManagerDisplay.ViewMode mode, CollectionManagerDisplay.ViewModeData userdata)
        {
            object[] objArray1 = new object[] { prevMode, mode, userdata };
            base.method_8("OnCollectionManagerViewModeChanged", objArray1);
        }

        public void OnDeckTemplateTabPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckTemplateTabPressed", objArray1);
        }

        public void OnDefaultCardbackChanged(int newDefaultCardBackID, object userData)
        {
            object[] objArray1 = new object[] { newDefaultCardBackID, userData };
            base.method_8("OnDefaultCardbackChanged", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDoneEditingDeck()
        {
            base.method_8("OnDoneEditingDeck", Array.Empty<object>());
        }

        public void OnFavoriteHeroChanged(TAG_CLASS heroClass, NetCache.CardDefinition favoriteHero, object userData)
        {
            object[] objArray1 = new object[] { heroClass, favoriteHero, userData };
            base.method_8("OnFavoriteHeroChanged", objArray1);
        }

        public void OnHeroSkinsTabPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnHeroSkinsTabPressed", objArray1);
        }

        public void OnPageFlip()
        {
            base.method_8("OnPageFlip", Array.Empty<object>());
        }

        public void OnPageLeftPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPageLeftPressed", objArray1);
        }

        public void OnPageRightPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPageRightPressed", objArray1);
        }

        public void OnPageTurnComplete(object callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("OnPageTurnComplete", objArray1);
        }

        public void OnPagingArrowLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnPagingArrowLoaded", objArray1);
        }

        public void OnTabOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabOut", objArray1);
        }

        public void OnTabOut_Touch(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabOut_Touch", objArray1);
        }

        public void OnTabOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabOver", objArray1);
        }

        public void OnTabOver_Touch(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTabOver_Touch", objArray1);
        }

        public void PositionClassTabs(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("PositionClassTabs", objArray1);
        }

        public void PositionCurrentPage(CollectionPageDisplay page)
        {
            object[] objArray1 = new object[] { page };
            base.method_8("PositionCurrentPage", objArray1);
        }

        public void PositionFixedTab(bool showTab, CollectionClassTab tab, Vector3 originalPos, bool animate)
        {
            object[] objArray1 = new object[] { showTab, tab, originalPos, animate };
            base.method_8("PositionFixedTab", objArray1);
        }

        public void PositionNextPage(CollectionPageDisplay page)
        {
            object[] objArray1 = new object[] { page };
            base.method_8("PositionNextPage", objArray1);
        }

        public void RefreshCurrentPageContents()
        {
            base.method_9("RefreshCurrentPageContents", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void RemoveAllClassFilters()
        {
            base.method_9("RemoveAllClassFilters", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void RemoveSearchTextFilter()
        {
            base.method_9("RemoveSearchTextFilter", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void SetDeckBuilder(DeckBuilder deckBuilder)
        {
            object[] objArray1 = new object[] { deckBuilder };
            base.method_8("SetDeckBuilder", objArray1);
        }

        public void SetUpClassTabs()
        {
            base.method_8("SetUpClassTabs", Array.Empty<object>());
        }

        public bool ShouldShowTab(CollectionClassTab tab)
        {
            object[] objArray1 = new object[] { tab };
            return base.method_11<bool>("ShouldShowTab", objArray1);
        }

        public void ShowArrow(GameObject arrow, bool show, bool isRightArrow)
        {
            object[] objArray1 = new object[] { arrow, show, isRightArrow };
            base.method_8("ShowArrow", objArray1);
        }

        public void ShowCardsNotOwned(bool includePremiums)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { includePremiums };
            base.method_9("ShowCardsNotOwned", enumArray1, objArray1);
        }

        public void ShowCraftableCardsOnly(bool showCraftableCardsOnly)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { showCraftableCardsOnly };
            base.method_9("ShowCraftableCardsOnly", enumArray1, objArray1);
        }

        public void ShowCraftingModeCards(bool showCraftableCardsOnly, bool showGolden, bool updatePage)
        {
            object[] objArray1 = new object[] { showCraftableCardsOnly, showGolden, updatePage };
            base.method_9("ShowCraftingModeCards", new Class272.Enum20[] { Class272.Enum20.Boolean }, objArray1);
        }

        public void ShowMassDisenchant()
        {
            base.method_8("ShowMassDisenchant", Array.Empty<object>());
        }

        public void ShowOnlyCardsIOwn()
        {
            base.method_9("ShowOnlyCardsIOwn", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ShowPremiumCardsOnly()
        {
            base.method_9("ShowPremiumCardsOnly", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SwapCurrentAndAltPages()
        {
            base.method_8("SwapCurrentAndAltPages", Array.Empty<object>());
        }

        public void TransitionPage(object callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("TransitionPage", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateClassTabNewCardCounts()
        {
            base.method_8("UpdateClassTabNewCardCounts", Array.Empty<object>());
        }

        public void UpdateCraftingModeButtonDustBottleVisibility()
        {
            base.method_8("UpdateCraftingModeButtonDustBottleVisibility", Array.Empty<object>());
        }

        public void UpdateCurrentPageCardLocks(bool playSound)
        {
            object[] objArray1 = new object[] { playSound };
            base.method_8("UpdateCurrentPageCardLocks", objArray1);
        }

        public void UpdateDeckTemplate(DeckTemplatePicker deckTemplatePicker)
        {
            object[] objArray1 = new object[] { deckTemplatePicker };
            base.method_8("UpdateDeckTemplate", objArray1);
        }

        public void UpdateFilteredCards()
        {
            base.method_8("UpdateFilteredCards", Array.Empty<object>());
        }

        public void UpdateFilteredHeroes()
        {
            base.method_8("UpdateFilteredHeroes", Array.Empty<object>());
        }

        public void UpdateMassDisenchant()
        {
            base.method_8("UpdateMassDisenchant", Array.Empty<object>());
        }

        public void UpdateVisibleTabs()
        {
            base.method_8("UpdateVisibleTabs", Array.Empty<object>());
        }

        public static string ANIMATE_TABS_COROUTINE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "ANIMATE_TABS_COROUTINE_NAME");
            }
        }

        public static float ARROW_SCALE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "ARROW_SCALE_TIME");
            }
        }

        public static Vector3 CLASS_TAB_LOCAL_EULERS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "CLASS_TAB_LOCAL_EULERS");
            }
        }

        public static List<TAG_CLASS> CLASS_TAB_ORDER
        {
            get
            {
                Class246<TAG_CLASS> class2 = MonoClass.smethod_7<Class246<TAG_CLASS>>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "CLASS_TAB_ORDER");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static Vector3 CURRENT_PAGE_LOCAL_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "CURRENT_PAGE_LOCAL_POS");
            }
        }

        public static float HIDDEN_TAB_LOCAL_Z_POS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "HIDDEN_TAB_LOCAL_Z_POS");
            }
        }

        public List<CollectionClassTab> m_allTabs
        {
            get
            {
                Class267<CollectionClassTab> class2 = base.method_3<Class267<CollectionClassTab>>("m_allTabs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CollectionClassTab m_cardBacksTab
        {
            get
            {
                return base.method_3<CollectionClassTab>("m_cardBacksTab");
            }
        }

        public Vector3 m_cardBacksTabPos
        {
            get
            {
                return base.method_2<Vector3>("m_cardBacksTabPos");
            }
        }

        public CollectibleCardClassFilter m_cardsCollection
        {
            get
            {
                return base.method_3<CollectibleCardClassFilter>("m_cardsCollection");
            }
        }

        public ClassFilterHeaderButton m_classFilterHeader
        {
            get
            {
                return base.method_3<ClassFilterHeaderButton>("m_classFilterHeader");
            }
        }

        public GameObject m_classTabContainer
        {
            get
            {
                return base.method_3<GameObject>("m_classTabContainer");
            }
        }

        public CollectionClassTab m_classTabPrefab
        {
            get
            {
                return base.method_3<CollectionClassTab>("m_classTabPrefab");
            }
        }

        public List<CollectionClassTab> m_classTabs
        {
            get
            {
                Class267<CollectionClassTab> class2 = base.method_3<Class267<CollectionClassTab>>("m_classTabs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CollectionClassTab m_currentClassTab
        {
            get
            {
                return base.method_3<CollectionClassTab>("m_currentClassTab");
            }
        }

        public bool m_currentPageIsPageA
        {
            get
            {
                return base.method_2<bool>("m_currentPageIsPageA");
            }
        }

        public int m_currentPageNum
        {
            get
            {
                return base.method_2<int>("m_currentPageNum");
            }
        }

        public DeckTemplatePicker m_deckTemplatePicker
        {
            get
            {
                return base.method_3<DeckTemplatePicker>("m_deckTemplatePicker");
            }
        }

        public string m_deckTemplatePickerPrefab
        {
            get
            {
                return base.method_4("m_deckTemplatePickerPrefab");
            }
        }

        public CollectionClassTab m_deckTemplateTab
        {
            get
            {
                return base.method_3<CollectionClassTab>("m_deckTemplateTab");
            }
        }

        public bool m_delayShowingArrows
        {
            get
            {
                return base.method_2<bool>("m_delayShowingArrows");
            }
        }

        public float m_deselectedClassTabHalfWidth
        {
            get
            {
                return base.method_2<float>("m_deselectedClassTabHalfWidth");
            }
        }

        public bool m_fullyLoaded
        {
            get
            {
                return base.method_2<bool>("m_fullyLoaded");
            }
        }

        public CollectibleCardHeroesFilter m_heroesCollection
        {
            get
            {
                return base.method_3<CollectibleCardHeroesFilter>("m_heroesCollection");
            }
        }

        public CollectionClassTab m_heroSkinsTab
        {
            get
            {
                return base.method_3<CollectionClassTab>("m_heroSkinsTab");
            }
        }

        public Vector3 m_heroSkinsTabPos
        {
            get
            {
                return base.method_2<Vector3>("m_heroSkinsTabPos");
            }
        }

        public bool m_hideNonDeckTemplateTabs
        {
            get
            {
                return base.method_2<bool>("m_hideNonDeckTemplateTabs");
            }
        }

        public bool m_initializedTabPositions
        {
            get
            {
                return base.method_2<bool>("m_initializedTabPositions");
            }
        }

        public CollectibleCard m_lastCardAnchor
        {
            get
            {
                return base.method_3<CollectibleCard>("m_lastCardAnchor");
            }
        }

        public int m_lastPageNum
        {
            get
            {
                return base.method_2<int>("m_lastPageNum");
            }
        }

        public bool m_leftArrowShown
        {
            get
            {
                return base.method_2<bool>("m_leftArrowShown");
            }
        }

        public MassDisenchant m_massDisenchant
        {
            get
            {
                return base.method_3<MassDisenchant>("m_massDisenchant");
            }
        }

        public CollectionPageDisplay m_pageA
        {
            get
            {
                return base.method_3<CollectionPageDisplay>("m_pageA");
            }
        }

        public CollectionPageDisplay m_pageB
        {
            get
            {
                return base.method_3<CollectionPageDisplay>("m_pageB");
            }
        }

        public CollectionPageDisplay m_pageDisplayPrefab
        {
            get
            {
                return base.method_3<CollectionPageDisplay>("m_pageDisplayPrefab");
            }
        }

        public PegUIElement m_pageDraggableRegion
        {
            get
            {
                return base.method_3<PegUIElement>("m_pageDraggableRegion");
            }
        }

        public GameObject m_pageLeftArrow
        {
            get
            {
                return base.method_3<GameObject>("m_pageLeftArrow");
            }
        }

        public GameObject m_pageLeftArrowBone
        {
            get
            {
                return base.method_3<GameObject>("m_pageLeftArrowBone");
            }
        }

        public PegUIElement m_pageLeftClickableRegion
        {
            get
            {
                return base.method_3<PegUIElement>("m_pageLeftClickableRegion");
            }
        }

        public GameObject m_pageRightArrow
        {
            get
            {
                return base.method_3<GameObject>("m_pageRightArrow");
            }
        }

        public GameObject m_pageRightArrowBone
        {
            get
            {
                return base.method_3<GameObject>("m_pageRightArrowBone");
            }
        }

        public PegUIElement m_pageRightClickableRegion
        {
            get
            {
                return base.method_3<PegUIElement>("m_pageRightClickableRegion");
            }
        }

        public bool m_pagesCurrentlyTurning
        {
            get
            {
                return base.method_2<bool>("m_pagesCurrentlyTurning");
            }
        }

        public PageTurn m_pageTurn
        {
            get
            {
                return base.method_3<PageTurn>("m_pageTurn");
            }
        }

        public bool m_rightArrowShown
        {
            get
            {
                return base.method_2<bool>("m_rightArrowShown");
            }
        }

        public bool m_skipNextPageTurn
        {
            get
            {
                return base.method_2<bool>("m_skipNextPageTurn");
            }
        }

        public float m_spaceBetweenTabs
        {
            get
            {
                return base.method_2<float>("m_spaceBetweenTabs");
            }
        }

        public bool m_tabsAreAnimating
        {
            get
            {
                return base.method_2<bool>("m_tabsAreAnimating");
            }
        }

        public float m_turnLeftPageSwapTiming
        {
            get
            {
                return base.method_2<float>("m_turnLeftPageSwapTiming");
            }
        }

        public bool m_useLastPage
        {
            get
            {
                return base.method_2<bool>("m_useLastPage");
            }
        }

        public bool m_wasTouchModeEnabled
        {
            get
            {
                return base.method_2<bool>("m_wasTouchModeEnabled");
            }
        }

        public static int MASS_DISENCHANT_PAGE_NUM
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "MASS_DISENCHANT_PAGE_NUM");
            }
        }

        public static Vector3 NEXT_PAGE_LOCAL_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "NEXT_PAGE_LOCAL_POS");
            }
        }

        public static int NUM_PAGE_FLIPS_BEFORE_STOP_SHOWING_ARROWS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "NUM_PAGE_FLIPS_BEFORE_STOP_SHOWING_ARROWS");
            }
        }

        public static float SELECT_TAB_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "SELECT_TAB_ANIM_TIME");
            }
        }

        public static string SELECT_TAB_COROUTINE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "SELECT_TAB_COROUTINE_NAME");
            }
        }

        public static string SHOW_ARROWS_COROUTINE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "SHOW_ARROWS_COROUTINE_NAME");
            }
        }

        public static List<CollectionManagerDisplay.ViewMode> TAG_ORDERING
        {
            get
            {
                Class246<CollectionManagerDisplay.ViewMode> class2 = MonoClass.smethod_7<Class246<CollectionManagerDisplay.ViewMode>>(TritonHs.MainAssemblyPath, "", "CollectionPageManager", "TAG_ORDERING");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public enum ArrowClickType
        {
            DISABLED,
            ENABLED,
            SWITCH_MODE
        }

        public enum PageTransitionType
        {
            NONE,
            SINGLE_PAGE_RIGHT,
            SINGLE_PAGE_LEFT,
            MANY_PAGE_RIGHT,
            MANY_PAGE_LEFT
        }

        [Attribute38("CollectionPageManager.TransitionReadyCallbackData")]
        public class TransitionReadyCallbackData : MonoClass
        {
            public TransitionReadyCallbackData(IntPtr address) : this(address, "TransitionReadyCallbackData")
            {
            }

            public TransitionReadyCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public CollectionPageDisplay m_assembledPage
            {
                get
                {
                    return base.method_3<CollectionPageDisplay>("m_assembledPage");
                }
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }

            public CollectionPageDisplay m_otherPage
            {
                get
                {
                    return base.method_3<CollectionPageDisplay>("m_otherPage");
                }
            }

            public CollectionPageManager.PageTransitionType m_transitionType
            {
                get
                {
                    return base.method_2<CollectionPageManager.PageTransitionType>("m_transitionType");
                }
            }
        }
    }
}

