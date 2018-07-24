namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckPickerTrayDisplay")]
    public class DeckPickerTrayDisplay : MonoBehaviour
    {
        public DeckPickerTrayDisplay(IntPtr address) : this(address, "DeckPickerTrayDisplay")
        {
        }

        public DeckPickerTrayDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BackButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("BackButtonPress", objArray1);
        }

        public static void BackOutToHub()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "BackOutToHub");
        }

        public void CollectionButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("CollectionButtonPress", objArray1);
        }

        public bool CustomPagesReady()
        {
            return base.method_11<bool>("CustomPagesReady", Array.Empty<object>());
        }

        public void Deselect()
        {
            base.method_8("Deselect", Array.Empty<object>());
        }

        public void DeselectLastSelectedHero()
        {
            base.method_8("DeselectLastSelectedHero", Array.Empty<object>());
        }

        public void DisableHeroButtons()
        {
            base.method_8("DisableHeroButtons", Array.Empty<object>());
        }

        public void EnableBackButton(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableBackButton", objArray1);
        }

        public void EnableExpoClickBlocker(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableExpoClickBlocker", objArray1);
        }

        public void EnableHeroButtons()
        {
            base.method_8("EnableHeroButtons", Array.Empty<object>());
        }

        public void EnablePlayButton(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnablePlayButton", objArray1);
        }

        public void FireDeckTrayLoadedEvent()
        {
            base.method_8("FireDeckTrayLoadedEvent", Array.Empty<object>());
        }

        public static DeckPickerTrayDisplay Get()
        {
            return MonoClass.smethod_15<DeckPickerTrayDisplay>(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "Get", Array.Empty<object>());
        }

        public HeroPickerButton GetPreconButtonForClass(TAG_CLASS classType)
        {
            object[] objArray1 = new object[] { classType };
            return base.method_14<HeroPickerButton>("GetPreconButtonForClass", objArray1);
        }

        public long GetSelectedDeckID()
        {
            return base.method_11<long>("GetSelectedDeckID", Array.Empty<object>());
        }

        public int GetSelectedHeroLevel()
        {
            return base.method_11<int>("GetSelectedHeroLevel", Array.Empty<object>());
        }

        public void GoBackUntilOnNavigateBackCalled()
        {
            base.method_8("GoBackUntilOnNavigateBackCalled", Array.Empty<object>());
        }

        public void HandleGameStartupFailure()
        {
            base.method_8("HandleGameStartupFailure", Array.Empty<object>());
        }

        public bool HaveDecksThatNeedNames()
        {
            return base.method_11<bool>("HaveDecksThatNeedNames", Array.Empty<object>());
        }

        public bool HaveUnseenBasicCards()
        {
            return base.method_11<bool>("HaveUnseenBasicCards", Array.Empty<object>());
        }

        public void HeroPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("HeroPressed", objArray1);
        }

        public void HideAllPreconHighlights()
        {
            base.method_8("HideAllPreconHighlights", Array.Empty<object>());
        }

        public void HideDemoQuotes()
        {
            base.method_8("HideDemoQuotes", Array.Empty<object>());
        }

        public void HideIntroQuote()
        {
            base.method_8("HideIntroQuote", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void InitCustomPages()
        {
            base.method_8("InitCustomPages", Array.Empty<object>());
        }

        public void InitExpoDemoMode()
        {
            base.method_8("InitExpoDemoMode", Array.Empty<object>());
        }

        public void InitForMode(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("InitForMode", objArray1);
        }

        public void InitHeroPickerButtons()
        {
            base.method_8("InitHeroPickerButtons", Array.Empty<object>());
        }

        public void InitMode()
        {
            base.method_8("InitMode", Array.Empty<object>());
        }

        public void InitRichPresence()
        {
            base.method_8("InitRichPresence", Array.Empty<object>());
        }

        public void InnkeeperCelebrationFinished()
        {
            base.method_8("InnkeeperCelebrationFinished", Array.Empty<object>());
        }

        public static bool IsBackingOut()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "IsBackingOut", Array.Empty<object>());
        }

        public bool IsChoosingHero()
        {
            return base.method_11<bool>("IsChoosingHero", Array.Empty<object>());
        }

        public bool IsChoosingHeroForTavernBrawlChallenge()
        {
            return base.method_11<bool>("IsChoosingHeroForTavernBrawlChallenge", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public bool IsShowingCollectionButton()
        {
            return base.method_11<bool>("IsShowingCollectionButton", Array.Empty<object>());
        }

        public bool IsShowingCustomDecks()
        {
            return base.method_11<bool>("IsShowingCustomDecks", Array.Empty<object>());
        }

        public void LoadGoldenHeroPower()
        {
            base.method_8("LoadGoldenHeroPower", Array.Empty<object>());
        }

        public void LoadGoldenHeroPowerCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadGoldenHeroPowerCallback", objArray1);
        }

        public void LoadHero()
        {
            base.method_8("LoadHero", Array.Empty<object>());
        }

        public void LoadHeroPower()
        {
            base.method_8("LoadHeroPower", Array.Empty<object>());
        }

        public void LoadHeroPowerCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadHeroPowerCallback", objArray1);
        }

        public void LowerHero()
        {
            base.method_8("LowerHero", Array.Empty<object>());
        }

        public void MouseOutHero(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MouseOutHero", objArray1);
        }

        public void MouseOutHeroPower(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MouseOutHeroPower", objArray1);
        }

        public void MouseOverHero(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MouseOverHero", objArray1);
        }

        public void MouseOverHeroPower(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MouseOverHeroPower", objArray1);
        }

        public void OnApplicationPause(bool pauseStatus)
        {
            object[] objArray1 = new object[] { pauseStatus };
            base.method_8("OnApplicationPause", objArray1);
        }

        public void OnBoxTransitionFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxTransitionFinished", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFriendChallengeChanged(FriendChallengeEvent challengeEvent, BnetPlayer player, object userData)
        {
            object[] objArray1 = new object[] { challengeEvent, player, userData };
            base.method_8("OnFriendChallengeChanged", objArray1);
        }

        public void OnFriendChallengeWaitingForOpponentDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnFriendChallengeWaitingForOpponentDialogResponse", objArray1);
        }

        public void OnGoldenHeroPowerActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnGoldenHeroPowerActorLoaded", objArray1);
        }

        public void OnHeroActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroActorLoaded", objArray1);
        }

        public void OnHeroFullDefLoaded(string cardId, FullDef fullDef, object userData)
        {
            object[] objArray1 = new object[] { cardId, fullDef, userData };
            base.method_8("OnHeroFullDefLoaded", objArray1);
        }

        public void OnHeroPowerActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroPowerActorLoaded", objArray1);
        }

        public void OnHeroPowerFullDefLoaded(string cardId, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnHeroPowerFullDefLoaded", objArray1);
        }

        public void OnMedalChanged(NetCache.NetCacheMedalInfo medalInfo)
        {
            object[] objArray1 = new object[] { medalInfo };
            base.method_8("OnMedalChanged", objArray1);
        }

        public static bool OnNavigateBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "OnNavigateBack", Array.Empty<object>());
        }

        public void OnServerGameCanceled()
        {
            base.method_8("OnServerGameCanceled", Array.Empty<object>());
        }

        public void OnServerGameStarted()
        {
            base.method_8("OnServerGameStarted", Array.Empty<object>());
        }

        public void OnShowFirstPage(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnShowFirstPage", objArray1);
        }

        public void OnShowSecondPage(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnShowSecondPage", objArray1);
        }

        public void OnSlidingTrayToggled(bool isShowing)
        {
            object[] objArray1 = new object[] { isShowing };
            base.method_8("OnSlidingTrayToggled", objArray1);
        }

        public void OnSwitchFormatButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnSwitchFormatButtonOut", objArray1);
        }

        public void OnSwitchFormatButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnSwitchFormatButtonOver", objArray1);
        }

        public void OnTransitionFromGameplayFinished(bool cutoff, object userData)
        {
            object[] objArray1 = new object[] { cutoff, userData };
            base.method_8("OnTransitionFromGameplayFinished", objArray1);
        }

        public void PlayGame()
        {
            base.method_8("PlayGame", Array.Empty<object>());
        }

        public void PlayGameButtonRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("PlayGameButtonRelease", objArray1);
        }

        public void PreUnload()
        {
            base.method_8("PreUnload", Array.Empty<object>());
        }

        public void RaiseHero()
        {
            base.method_8("RaiseHero", Array.Empty<object>());
        }

        public void RankedPlayButtonsLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("RankedPlayButtonsLoaded", objArray1);
        }

        public void ResetCurrentMode()
        {
            base.method_8("ResetCurrentMode", Array.Empty<object>());
        }

        public void SelectCustomDeck(CollectionDeckBoxVisual deckbox, bool showTrayForPhone)
        {
            object[] objArray1 = new object[] { deckbox, showTrayForPhone };
            base.method_8("SelectCustomDeck", objArray1);
        }

        public void SelectHero(HeroPickerButton button, bool showTrayForPhone)
        {
            object[] objArray1 = new object[] { button, showTrayForPhone };
            base.method_8("SelectHero", objArray1);
        }

        public void SelectHeroForCollectionManager()
        {
            base.method_8("SelectHeroForCollectionManager", Array.Empty<object>());
        }

        public void SetCustomTrayTexture(string name, object go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("SetCustomTrayTexture", objArray1);
        }

        public void SetDetailsTrayTexture(string name, object go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("SetDetailsTrayTexture", objArray1);
        }

        public void SetHeaderForTavernBrawl()
        {
            base.method_8("SetHeaderForTavernBrawl", Array.Empty<object>());
        }

        public void SetHeaderText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetHeaderText", objArray1);
        }

        public void SetPlayButtonText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetPlayButtonText", objArray1);
        }

        public void SetSelectionAndPageFromOptions()
        {
            base.method_8("SetSelectionAndPageFromOptions", Array.Empty<object>());
        }

        public void SetTexturesForTavernBrawl()
        {
            base.method_8("SetTexturesForTavernBrawl", Array.Empty<object>());
        }

        public void SetTrayTexture(string name, object go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("SetTrayTexture", objArray1);
        }

        public bool ShouldGlowCollectionButton()
        {
            return base.method_11<bool>("ShouldGlowCollectionButton", Array.Empty<object>());
        }

        public bool ShouldHandleBoxTransition()
        {
            return base.method_11<bool>("ShouldHandleBoxTransition", Array.Empty<object>());
        }

        public bool ShouldShowCustomDecks()
        {
            return base.method_11<bool>("ShouldShowCustomDecks", Array.Empty<object>());
        }

        public bool ShouldShowHeroPower()
        {
            return base.method_11<bool>("ShouldShowHeroPower", Array.Empty<object>());
        }

        public bool ShouldShowPreconDecks()
        {
            return base.method_11<bool>("ShouldShowPreconDecks", Array.Empty<object>());
        }

        public void ShowFirstPage()
        {
            base.method_8("ShowFirstPage", Array.Empty<object>());
        }

        public void ShowGoldenHeroPowerBigCard()
        {
            base.method_8("ShowGoldenHeroPowerBigCard", Array.Empty<object>());
        }

        public void ShowHero()
        {
            base.method_8("ShowHero", Array.Empty<object>());
        }

        public void ShowHeroPowerBigCard()
        {
            base.method_8("ShowHeroPowerBigCard", Array.Empty<object>());
        }

        public void ShowIntroQuote()
        {
            base.method_8("ShowIntroQuote", Array.Empty<object>());
        }

        public void ShowPreconHero(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowPreconHero", objArray1);
        }

        public void ShowPreconHighlights()
        {
            base.method_8("ShowPreconHighlights", Array.Empty<object>());
        }

        public void ShowSecondPage()
        {
            base.method_8("ShowSecondPage", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SuckInFinished()
        {
            base.method_8("SuckInFinished", Array.Empty<object>());
        }

        public void SuckInPreconDecks()
        {
            base.method_8("SuckInPreconDecks", Array.Empty<object>());
        }

        public void SwitchFormatButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("SwitchFormatButtonPress", objArray1);
        }

        public void ToggleRankedDetailsTray(bool shown)
        {
            object[] objArray1 = new object[] { shown };
            base.method_8("ToggleRankedDetailsTray", objArray1);
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void UpdateCustomHeroPowerBigCard(GameObject heroPowerBigCard)
        {
            object[] objArray1 = new object[] { heroPowerBigCard };
            base.method_8("UpdateCustomHeroPowerBigCard", objArray1);
        }

        public void UpdateHeroInfo(CollectionDeckBoxVisual deckBox)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deckBox };
            base.method_9("UpdateHeroInfo", enumArray1, objArray1);
        }

        public void UpdateHeroInfo(HeroPickerButton button)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { button };
            base.method_9("UpdateHeroInfo", enumArray1, objArray1);
        }

        public void UpdateHeroInfo(FullDef fullDef, string heroName, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { fullDef, heroName, premium };
            base.method_9("UpdateHeroInfo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdateHeroLockedTooltip(bool isLocked)
        {
            object[] objArray1 = new object[] { isLocked };
            base.method_8("UpdateHeroLockedTooltip", objArray1);
        }

        public void UpdateHeroPowerInfo(FullDef def, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { def, premium };
            base.method_8("UpdateHeroPowerInfo", objArray1);
        }

        public bool UpdateRankedClassWinsPlate()
        {
            return base.method_11<bool>("UpdateRankedClassWinsPlate", Array.Empty<object>());
        }

        public void UpdateRankedPlayDisplay()
        {
            base.method_8("UpdateRankedPlayDisplay", Array.Empty<object>());
        }

        public string gameMode
        {
            get
            {
                return base.method_4("gameMode");
            }
        }

        public List<TAG_CLASS> HERO_CLASSES
        {
            get
            {
                Class266<TAG_CLASS> class2 = base.method_3<Class266<TAG_CLASS>>("HERO_CLASSES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Mesh m_alternateDetailsTrayMesh
        {
            get
            {
                return base.method_3<Mesh>("m_alternateDetailsTrayMesh");
            }
        }

        public Material m_arrowButtonShadowMaterial
        {
            get
            {
                return base.method_3<Material>("m_arrowButtonShadowMaterial");
            }
        }

        public UIBButton m_backButton
        {
            get
            {
                return base.method_3<UIBButton>("m_backButton");
            }
        }

        public GameObject m_basicDeckPageContainer
        {
            get
            {
                return base.method_3<GameObject>("m_basicDeckPageContainer");
            }
        }

        public bool m_buttonAchievementsInitialized
        {
            get
            {
                return base.method_2<bool>("m_buttonAchievementsInitialized");
            }
        }

        public UIBButton m_collectionButton
        {
            get
            {
                return base.method_3<UIBButton>("m_collectionButton");
            }
        }

        public HighlightState m_collectionButtonGlow
        {
            get
            {
                return base.method_3<HighlightState>("m_collectionButtonGlow");
            }
        }

        public List<NestedPrefab> m_customDeckPageContainers
        {
            get
            {
                Class267<NestedPrefab> class2 = base.method_3<Class267<NestedPrefab>>("m_customDeckPageContainers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<CustomDeckPage> m_customPages
        {
            get
            {
                Class247<CustomDeckPage> class2 = base.method_3<Class247<CustomDeckPage>>("m_customPages");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public DeckPickerMode m_deckPickerMode
        {
            get
            {
                return base.method_2<DeckPickerMode>("m_deckPickerMode");
            }
        }

        public bool m_delayButtonAnims
        {
            get
            {
                return base.method_2<bool>("m_delayButtonAnims");
            }
        }

        public GameObject m_detailsTrayFrame
        {
            get
            {
                return base.method_3<GameObject>("m_detailsTrayFrame");
            }
        }

        public Texture m_emptyHeroTexture
        {
            get
            {
                return base.method_3<Texture>("m_emptyHeroTexture");
            }
        }

        public BoxCollider m_expoClickBlocker
        {
            get
            {
                return base.method_3<BoxCollider>("m_expoClickBlocker");
            }
        }

        public Triton.Game.Mapping.Notification m_expoIntroQuote
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_expoIntroQuote");
            }
        }

        public Triton.Game.Mapping.Notification m_expoThankQuote
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_expoThankQuote");
            }
        }

        public PegUIElement m_goldenHeroPower
        {
            get
            {
                return base.method_3<PegUIElement>("m_goldenHeroPower");
            }
        }

        public Actor m_goldenHeroPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_goldenHeroPowerActor");
            }
        }

        public Actor m_goldenHeroPowerBigCard
        {
            get
            {
                return base.method_3<Actor>("m_goldenHeroPowerBigCard");
            }
        }

        public Transform m_Hero_Bone
        {
            get
            {
                return base.method_3<Transform>("m_Hero_Bone");
            }
        }

        public Transform m_Hero_BoneDown
        {
            get
            {
                return base.method_3<Transform>("m_Hero_BoneDown");
            }
        }

        public Actor m_heroActor
        {
            get
            {
                return base.method_3<Actor>("m_heroActor");
            }
        }

        public List<HeroPickerButton> m_heroButtons
        {
            get
            {
                Class267<HeroPickerButton> class2 = base.method_3<Class267<HeroPickerButton>>("m_heroButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_heroChosen
        {
            get
            {
                return base.method_2<bool>("m_heroChosen");
            }
        }

        public int m_heroDefsLoading
        {
            get
            {
                return base.method_2<int>("m_heroDefsLoading");
            }
        }

        public UberText m_heroName
        {
            get
            {
                return base.method_3<UberText>("m_heroName");
            }
        }

        public float m_heroPickerButtonHorizontalSpacing
        {
            get
            {
                return base.method_2<float>("m_heroPickerButtonHorizontalSpacing");
            }
        }

        public Vector3 m_heroPickerButtonScale
        {
            get
            {
                return base.method_2<Vector3>("m_heroPickerButtonScale");
            }
        }

        public Vector3 m_heroPickerButtonStart
        {
            get
            {
                return base.method_2<Vector3>("m_heroPickerButtonStart");
            }
        }

        public float m_heroPickerButtonVerticalSpacing
        {
            get
            {
                return base.method_2<float>("m_heroPickerButtonVerticalSpacing");
            }
        }

        public PegUIElement m_heroPower
        {
            get
            {
                return base.method_3<PegUIElement>("m_heroPower");
            }
        }

        public Transform m_HeroPower_Bone
        {
            get
            {
                return base.method_3<Transform>("m_HeroPower_Bone");
            }
        }

        public Transform m_HeroPower_BoneDown
        {
            get
            {
                return base.method_3<Transform>("m_HeroPower_BoneDown");
            }
        }

        public Actor m_heroPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_heroPowerActor");
            }
        }

        public Actor m_heroPowerBigCard
        {
            get
            {
                return base.method_3<Actor>("m_heroPowerBigCard");
            }
        }

        public int m_heroPowerDefsLoading
        {
            get
            {
                return base.method_2<int>("m_heroPowerDefsLoading");
            }
        }

        public GameObject m_heroPowerShadowQuad
        {
            get
            {
                return base.method_3<GameObject>("m_heroPowerShadowQuad");
            }
        }

        public GameObject m_heroPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_heroPrefab");
            }
        }

        public GameObject m_hierarchyDeckTray
        {
            get
            {
                return base.method_3<GameObject>("m_hierarchyDeckTray");
            }
        }

        public GameObject m_hierarchyDetails
        {
            get
            {
                return base.method_3<GameObject>("m_hierarchyDetails");
            }
        }

        public bool m_innkeeperQuoteFinished
        {
            get
            {
                return base.method_2<bool>("m_innkeeperQuoteFinished");
            }
        }

        public Vector2 m_keyholeTextureOffset
        {
            get
            {
                return base.method_2<Vector2>("m_keyholeTextureOffset");
            }
        }

        public GameObject m_labelDecoration
        {
            get
            {
                return base.method_3<GameObject>("m_labelDecoration");
            }
        }

        public UIBButton m_leftArrow
        {
            get
            {
                return base.method_3<UIBButton>("m_leftArrow");
            }
        }

        public NestedPrefab m_leftArrowNestedPrefab
        {
            get
            {
                return base.method_3<NestedPrefab>("m_leftArrowNestedPrefab");
            }
        }

        public bool m_Loaded
        {
            get
            {
                return base.method_2<bool>("m_Loaded");
            }
        }

        public Transform m_medalBone_phone
        {
            get
            {
                return base.method_3<Transform>("m_medalBone_phone");
            }
        }

        public GameObject m_modeLabelBg
        {
            get
            {
                return base.method_3<GameObject>("m_modeLabelBg");
            }
        }

        public UberText m_modeName
        {
            get
            {
                return base.method_3<UberText>("m_modeName");
            }
        }

        public bool m_needUnlockAllHeroesTransition
        {
            get
            {
                return base.method_2<bool>("m_needUnlockAllHeroesTransition");
            }
        }

        public float m_numCardsPerClass
        {
            get
            {
                return base.method_2<float>("m_numCardsPerClass");
            }
        }

        public int m_numDecks
        {
            get
            {
                return base.method_2<int>("m_numDecks");
            }
        }

        public int m_numPagesToShow
        {
            get
            {
                return base.method_2<int>("m_numPagesToShow");
            }
        }

        public PlayButton m_playButton
        {
            get
            {
                return base.method_3<PlayButton>("m_playButton");
            }
        }

        public GameObject m_randomDeckPickerTray
        {
            get
            {
                return base.method_3<GameObject>("m_randomDeckPickerTray");
            }
        }

        public GameObject m_randomDecksHiddenBone
        {
            get
            {
                return base.method_3<GameObject>("m_randomDecksHiddenBone");
            }
        }

        public GameObject m_randomDecksShownBone
        {
            get
            {
                return base.method_3<GameObject>("m_randomDecksShownBone");
            }
        }

        public GameObject m_randomTray
        {
            get
            {
                return base.method_3<GameObject>("m_randomTray");
            }
        }

        public SlidingTray m_rankedDetailsTray
        {
            get
            {
                return base.method_3<SlidingTray>("m_rankedDetailsTray");
            }
        }

        public RankedPlayDisplay m_rankedPlayButtons
        {
            get
            {
                return base.method_3<RankedPlayDisplay>("m_rankedPlayButtons");
            }
        }

        public Transform m_rankedPlayButtonsBone
        {
            get
            {
                return base.method_3<Transform>("m_rankedPlayButtonsBone");
            }
        }

        public UberText m_rankedWins
        {
            get
            {
                return base.method_3<UberText>("m_rankedWins");
            }
        }

        public GameObject m_rankedWinsPlate
        {
            get
            {
                return base.method_3<GameObject>("m_rankedWinsPlate");
            }
        }

        public UIBButton m_rightArrow
        {
            get
            {
                return base.method_3<UIBButton>("m_rightArrow");
            }
        }

        public NestedPrefab m_rightArrowNestedPrefab
        {
            get
            {
                return base.method_3<NestedPrefab>("m_rightArrowNestedPrefab");
            }
        }

        public CollectionDeckBoxVisual m_selectedCustomDeckBox
        {
            get
            {
                return base.method_3<CollectionDeckBoxVisual>("m_selectedCustomDeckBox");
            }
        }

        public HeroPickerButton m_selectedHeroButton
        {
            get
            {
                return base.method_3<HeroPickerButton>("m_selectedHeroButton");
            }
        }

        public string m_selectedHeroName
        {
            get
            {
                return base.method_4("m_selectedHeroName");
            }
        }

        public FullDef m_selectedHeroPowerFullDef
        {
            get
            {
                return base.method_3<FullDef>("m_selectedHeroPowerFullDef");
            }
        }

        public bool m_showingSecondPage
        {
            get
            {
                return base.method_2<bool>("m_showingSecondPage");
            }
        }

        public SlidingTray m_slidingTray
        {
            get
            {
                return base.method_3<SlidingTray>("m_slidingTray");
            }
        }

        public GameObject m_suckedInRandomDecksBone
        {
            get
            {
                return base.method_3<GameObject>("m_suckedInRandomDecksBone");
            }
        }

        public SwitchFormatButton m_switchFormatButton
        {
            get
            {
                return base.method_3<SwitchFormatButton>("m_switchFormatButton");
            }
        }

        public GameObject m_switchFormatShadowExt
        {
            get
            {
                return base.method_3<GameObject>("m_switchFormatShadowExt");
            }
        }

        public Mesh m_switchFormatTrayFrameMesh
        {
            get
            {
                return base.method_3<Mesh>("m_switchFormatTrayFrameMesh");
            }
        }

        public KeywordHelpPanel m_tooltip
        {
            get
            {
                return base.method_3<KeywordHelpPanel>("m_tooltip");
            }
        }

        public Transform m_tooltipBone
        {
            get
            {
                return base.method_3<Transform>("m_tooltipBone");
            }
        }

        public GameObject m_tooltipPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_tooltipPrefab");
            }
        }

        public GameObject m_trayFrame
        {
            get
            {
                return base.method_3<GameObject>("m_trayFrame");
            }
        }

        public HeroXPBar m_xpBar
        {
            get
            {
                return base.method_3<HeroXPBar>("m_xpBar");
            }
        }

        public HeroXPBar m_xpBarPrefab
        {
            get
            {
                return base.method_3<HeroXPBar>("m_xpBarPrefab");
            }
        }

        public static int MAX_PRECON_DECKS_TO_DISPLAY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "MAX_PRECON_DECKS_TO_DISPLAY");
            }
        }

        public static float TRAY_SINK_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "TRAY_SINK_TIME");
            }
        }

        public static float TRAY_SLIDE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckPickerTrayDisplay", "TRAY_SLIDE_TIME");
            }
        }

        [Attribute38("DeckPickerTrayDisplay.HeroFullDefLoadedCallbackData")]
        public class HeroFullDefLoadedCallbackData : MonoClass
        {
            public HeroFullDefLoadedCallbackData(IntPtr address) : this(address, "HeroFullDefLoadedCallbackData")
            {
            }

            public HeroFullDefLoadedCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.HeroPickerButton HeroPickerButton
            {
                get
                {
                    return base.method_14<Triton.Game.Mapping.HeroPickerButton>("get_HeroPickerButton", Array.Empty<object>());
                }
            }

            public TAG_PREMIUM Premium
            {
                get
                {
                    return base.method_11<TAG_PREMIUM>("get_Premium", Array.Empty<object>());
                }
            }
        }
    }
}

