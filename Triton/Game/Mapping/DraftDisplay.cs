namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DraftDisplay")]
    public class DraftDisplay : MonoBehaviour
    {
        public DraftDisplay(IntPtr address) : this(address, "DraftDisplay")
        {
        }

        public DraftDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCardToManaCurve(EntityDef entityDef)
        {
            object[] objArray1 = new object[] { entityDef };
            base.method_8("AddCardToManaCurve", objArray1);
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

        public bool CanAutoDraft()
        {
            return base.method_11<bool>("CanAutoDraft", Array.Empty<object>());
        }

        public void CancelFindGame()
        {
            base.method_8("CancelFindGame", Array.Empty<object>());
        }

        public void DeckHeaderOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("DeckHeaderOut", objArray1);
        }

        public void DeckHeaderOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("DeckHeaderOver", objArray1);
        }

        public void DestroyChoiceOnSpellFinish(Spell spell, object actorObject)
        {
            object[] objArray1 = new object[] { spell, actorObject };
            base.method_8("DestroyChoiceOnSpellFinish", objArray1);
        }

        public void DestroyOldChoices()
        {
            base.method_8("DestroyOldChoices", Array.Empty<object>());
        }

        public void DoDeckCompleteAnims()
        {
            base.method_8("DoDeckCompleteAnims", Array.Empty<object>());
        }

        public void DoFirstTimeIntro()
        {
            base.method_8("DoFirstTimeIntro", Array.Empty<object>());
        }

        public void DoHeroCancelAnimation()
        {
            base.method_8("DoHeroCancelAnimation", Array.Empty<object>());
        }

        public void DoHeroSelectAnimation()
        {
            base.method_8("DoHeroSelectAnimation", Array.Empty<object>());
        }

        public void EnableBackButton(bool buttonEnabled)
        {
            object[] objArray1 = new object[] { buttonEnabled };
            base.method_8("EnableBackButton", objArray1);
        }

        public void ExitDraftScene()
        {
            base.method_8("ExitDraftScene", Array.Empty<object>());
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public static DraftDisplay Get()
        {
            return MonoClass.smethod_15<DraftDisplay>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "Get", Array.Empty<object>());
        }

        public Vector3 GetCardPosition(int cardChoice, bool isHero)
        {
            object[] objArray1 = new object[] { cardChoice, isHero };
            return base.method_11<Vector3>("GetCardPosition", objArray1);
        }

        public List<DraftCardVisual> GetCardVisuals()
        {
            Class267<DraftCardVisual> class2 = base.method_14<Class267<DraftCardVisual>>("GetCardVisuals", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public DraftMode GetDraftMode()
        {
            return base.method_11<DraftMode>("GetDraftMode", Array.Empty<object>());
        }

        public SpellType GetSpellTypeForRarity(TAG_RARITY rarity)
        {
            object[] objArray1 = new object[] { rarity };
            return base.method_11<SpellType>("GetSpellTypeForRarity", objArray1);
        }

        public void HandleGameStartupFailure()
        {
            base.method_8("HandleGameStartupFailure", Array.Empty<object>());
        }

        public bool HaveActorsForAllChoices()
        {
            return base.method_11<bool>("HaveActorsForAllChoices", Array.Empty<object>());
        }

        public void InitializeDraftScreen()
        {
            base.method_8("InitializeDraftScreen", Array.Empty<object>());
        }

        public void InitManaCurve()
        {
            base.method_8("InitManaCurve", Array.Empty<object>());
        }

        public bool IsHeroEmoteSpellReady(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_11<bool>("IsHeroEmoteSpellReady", objArray1);
        }

        public bool IsInHeroSelectMode()
        {
            return base.method_11<bool>("IsInHeroSelectMode", Array.Empty<object>());
        }

        public void LastArenaWinsLabelLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LastArenaWinsLabelLoaded", objArray1);
        }

        public void LoadAndPositionHeroCard()
        {
            base.method_8("LoadAndPositionHeroCard", Array.Empty<object>());
        }

        public void LoadHeroPowerCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("LoadHeroPowerCallback", objArray1);
        }

        public void ManaCurveOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ManaCurveOut", objArray1);
        }

        public void ManaCurveOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ManaCurveOver", objArray1);
        }

        public void OnActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void OnApplicationPause(bool pauseStatus)
        {
            object[] objArray1 = new object[] { pauseStatus };
            base.method_8("OnApplicationPause", objArray1);
        }

        public void OnCancelButtonClicked(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonClicked", objArray1);
        }

        public void OnCardDefLoaded(string cardID, GameObject cardObject, object callbackData)
        {
            object[] objArray1 = new object[] { cardID, cardObject, callbackData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void OnConfirmButtonClicked(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnConfirmButtonClicked", objArray1);
        }

        public void OnConfirmButtonLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnConfirmButtonLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFadeFinished()
        {
            base.method_8("OnFadeFinished", Array.Empty<object>());
        }

        public void OnFirstTimeIntroOkButtonPressed(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnFirstTimeIntroOkButtonPressed", objArray1);
        }

        public void OnFullDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnFullDefLoaded", objArray1);
        }

        public void OnFullHeroDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnFullHeroDefLoaded", objArray1);
        }

        public void OnHeroActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnHeroActorLoaded", objArray1);
        }

        public void OnHeroClicked(int heroChoice)
        {
            object[] objArray1 = new object[] { heroChoice };
            base.method_8("OnHeroClicked", objArray1);
        }

        public void OnHeroPowerFullDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnHeroPowerFullDefLoaded", objArray1);
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnNewQuestsShown()
        {
            base.method_8("OnNewQuestsShown", Array.Empty<object>());
        }

        public void OnOpenRewardsComplete()
        {
            base.method_8("OnOpenRewardsComplete", Array.Empty<object>());
        }

        public void OnPhoneBackButtonLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnPhoneBackButtonLoaded", objArray1);
        }

        public void OnRetirePopupResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnRetirePopupResponse", objArray1);
        }

        public void OnStartEmoteLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnStartEmoteLoaded", objArray1);
        }

        public void OnStoreBackButtonPressed(bool authorizationBackButtonPressed, object userData)
        {
            object[] objArray1 = new object[] { authorizationBackButtonPressed, userData };
            base.method_8("OnStoreBackButtonPressed", objArray1);
        }

        public void PhoneHeroAnimationFinished()
        {
            base.method_8("PhoneHeroAnimationFinished", Array.Empty<object>());
        }

        public void PlayButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("PlayButtonPress", objArray1);
        }

        public void PositionAndShowChoices()
        {
            base.method_8("PositionAndShowChoices", Array.Empty<object>());
        }

        public void RemoveListeners()
        {
            base.method_8("RemoveListeners", Array.Empty<object>());
        }

        public void RetireButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("RetireButtonPress", objArray1);
        }

        public void SetDraftMode(DraftMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetDraftMode", objArray1);
        }

        public void SetupBackButton()
        {
            base.method_8("SetupBackButton", Array.Empty<object>());
        }

        public void SetupRetireButton()
        {
            base.method_8("SetupRetireButton", Array.Empty<object>());
        }

        public void ShowCurrentlyDraftingScreen()
        {
            base.method_8("ShowCurrentlyDraftingScreen", Array.Empty<object>());
        }

        public void ShowDraftRewardsScreen()
        {
            base.method_8("ShowDraftRewardsScreen", Array.Empty<object>());
        }

        public void ShowHeroPowerBigCard()
        {
            base.method_8("ShowHeroPowerBigCard", Array.Empty<object>());
        }

        public void ShowNewQuests()
        {
            base.method_8("ShowNewQuests", Array.Empty<object>());
        }

        public void ShowNextCompletedQuestToast(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ShowNextCompletedQuestToast", objArray1);
        }

        public void ShowPhonePlayButton(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowPhonePlayButton", objArray1);
        }

        public void ShowPurchaseScreen()
        {
            base.method_8("ShowPurchaseScreen", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateInstructionText()
        {
            base.method_8("UpdateInstructionText", Array.Empty<object>());
        }

        public static Vector3 CHOICE_ACTOR_LOCAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "CHOICE_ACTOR_LOCAL_SCALE");
            }
        }

        public static Vector3 CHOICE_ACTOR_LOCAL_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "CHOICE_ACTOR_LOCAL_SCALE_PHONE");
            }
        }

        public static Vector3 HERO_ACTOR_LOCAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_ACTOR_LOCAL_SCALE");
            }
        }

        public static Vector3 HERO_ACTOR_LOCAL_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_ACTOR_LOCAL_SCALE_PHONE");
            }
        }

        public static Vector3 HERO_CONFIRM_BUTTON_POSITION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_CONFIRM_BUTTON_POSITION");
            }
        }

        public static Vector3 HERO_CONFIRM_BUTTON_POSITION_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_CONFIRM_BUTTON_POSITION_PHONE");
            }
        }

        public static Vector3 HERO_CONFIRM_BUTTON_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_CONFIRM_BUTTON_SCALE");
            }
        }

        public static Vector3 HERO_CONFIRM_BUTTON_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_CONFIRM_BUTTON_SCALE_PHONE");
            }
        }

        public static Vector3 HERO_LABEL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_LABEL_SCALE");
            }
        }

        public static Vector3 HERO_LABEL_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_LABEL_SCALE_PHONE");
            }
        }

        public static Vector3 HERO_POWER_POSITION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_POWER_POSITION");
            }
        }

        public static Vector3 HERO_POWER_POSITION_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_POWER_POSITION_PHONE");
            }
        }

        public static Vector3 HERO_POWER_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_POWER_SCALE");
            }
        }

        public static Vector3 HERO_POWER_SCALE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_POWER_SCALE_PHONE");
            }
        }

        public static Vector3 HERO_POWER_START_POSITION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_POWER_START_POSITION");
            }
        }

        public static Vector3 HERO_POWER_START_POSITION_PHONE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "DraftDisplay", "HERO_POWER_START_POSITION_PHONE");
            }
        }

        public bool m_animationsComplete
        {
            get
            {
                return base.method_2<bool>("m_animationsComplete");
            }
        }

        public UIBButton m_backButton
        {
            get
            {
                return base.method_3<UIBButton>("m_backButton");
            }
        }

        public Transform m_bigHeroBone
        {
            get
            {
                return base.method_3<Transform>("m_bigHeroBone");
            }
        }

        public List<DraftChoice> m_choices
        {
            get
            {
                Class267<DraftChoice> class2 = base.method_3<Class267<DraftChoice>>("m_choices");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Actor m_chosenHero
        {
            get
            {
                return base.method_3<Actor>("m_chosenHero");
            }
        }

        public NormalButton m_confirmButton
        {
            get
            {
                return base.method_3<NormalButton>("m_confirmButton");
            }
        }

        public List<HeroLabel> m_currentLabels
        {
            get
            {
                Class267<HeroLabel> class2 = base.method_3<Class267<HeroLabel>>("m_currentLabels");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public DraftMode m_currentMode
        {
            get
            {
                return base.method_2<DraftMode>("m_currentMode");
            }
        }

        public float m_DeckCardBarFlareUpDelay
        {
            get
            {
                return base.method_2<float>("m_DeckCardBarFlareUpDelay");
            }
        }

        public Spell m_DeckCompleteSpell
        {
            get
            {
                return base.method_3<Spell>("m_DeckCompleteSpell");
            }
        }

        public DraftDeckTray m_draftDeckTray
        {
            get
            {
                return base.method_3<DraftDeckTray>("m_draftDeckTray");
            }
        }

        public bool m_firstTimeIntroComplete
        {
            get
            {
                return base.method_2<bool>("m_firstTimeIntroComplete");
            }
        }

        public UberText m_forgeLabel
        {
            get
            {
                return base.method_3<UberText>("m_forgeLabel");
            }
        }

        public PegUIElement m_heroClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_heroClickCatcher");
            }
        }

        public List<CardSoundSpell> m_heroEmotes
        {
            get
            {
                Class247<CardSoundSpell> class2 = base.method_3<Class247<CardSoundSpell>>("m_heroEmotes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_heroLabel
        {
            get
            {
                return base.method_3<GameObject>("m_heroLabel");
            }
        }

        public Actor m_heroPower
        {
            get
            {
                return base.method_3<Actor>("m_heroPower");
            }
        }

        public List<FullDef> m_heroPowerDefs
        {
            get
            {
                Class247<FullDef> class2 = base.method_3<Class247<FullDef>>("m_heroPowerDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_instructionText
        {
            get
            {
                return base.method_3<UberText>("m_instructionText");
            }
        }

        public bool m_isHeroAnimating
        {
            get
            {
                return base.method_2<bool>("m_isHeroAnimating");
            }
        }

        public DraftManaCurve m_manaCurve
        {
            get
            {
                return base.method_3<DraftManaCurve>("m_manaCurve");
            }
        }

        public bool m_netCacheReady
        {
            get
            {
                return base.method_2<bool>("m_netCacheReady");
            }
        }

        public List<Achievement> m_newlyCompletedAchieves
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_newlyCompletedAchieves");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_Phone3WayButtonRoot
        {
            get
            {
                return base.method_3<GameObject>("m_Phone3WayButtonRoot");
            }
        }

        public Transform m_PhoneBackButtonBone
        {
            get
            {
                return base.method_3<Transform>("m_PhoneBackButtonBone");
            }
        }

        public GameObject m_PhoneChooseHero
        {
            get
            {
                return base.method_3<GameObject>("m_PhoneChooseHero");
            }
        }

        public ArenaPhoneControl m_PhoneDeckControl
        {
            get
            {
                return base.method_3<ArenaPhoneControl>("m_PhoneDeckControl");
            }
        }

        public Transform m_PhoneDeckTrayHiddenBone
        {
            get
            {
                return base.method_3<Transform>("m_PhoneDeckTrayHiddenBone");
            }
        }

        public GameObject m_PhoneLargeViewDeckButton
        {
            get
            {
                return base.method_3<GameObject>("m_PhoneLargeViewDeckButton");
            }
        }

        public GameObject m_PhonePlayButtonTray
        {
            get
            {
                return base.method_3<GameObject>("m_PhonePlayButtonTray");
            }
        }

        public Collider m_pickArea
        {
            get
            {
                return base.method_3<Collider>("m_pickArea");
            }
        }

        public PlayButton m_playButton
        {
            get
            {
                return base.method_3<PlayButton>("m_playButton");
            }
        }

        public bool m_questsHandled
        {
            get
            {
                return base.method_2<bool>("m_questsHandled");
            }
        }

        public StandardPegButtonNew m_retireButton
        {
            get
            {
                return base.method_3<StandardPegButtonNew>("m_retireButton");
            }
        }

        public bool m_skipHeroEmotes
        {
            get
            {
                return base.method_2<bool>("m_skipHeroEmotes");
            }
        }

        public Transform m_socketHeroBone
        {
            get
            {
                return base.method_3<Transform>("m_socketHeroBone");
            }
        }

        public bool m_wasDrafting
        {
            get
            {
                return base.method_2<bool>("m_wasDrafting");
            }
        }

        public DraftCardVisual m_zoomedHero
        {
            get
            {
                return base.method_3<DraftCardVisual>("m_zoomedHero");
            }
        }

        [Attribute38("DraftDisplay.ChoiceCallback")]
        public class ChoiceCallback : MonoClass
        {
            public ChoiceCallback(IntPtr address) : this(address, "ChoiceCallback")
            {
            }

            public ChoiceCallback(IntPtr address, string className) : base(address, className)
            {
            }

            public int choiceID
            {
                get
                {
                    return base.method_2<int>("choiceID");
                }
            }

            public FullDef fullDef
            {
                get
                {
                    return base.method_3<FullDef>("fullDef");
                }
            }

            public int slot
            {
                get
                {
                    return base.method_2<int>("slot");
                }
            }
        }

        [Attribute38("DraftDisplay.DraftChoice")]
        public class DraftChoice : MonoClass
        {
            public DraftChoice(IntPtr address) : this(address, "DraftChoice")
            {
            }

            public DraftChoice(IntPtr address, string className) : base(address, className)
            {
            }

            public Actor m_actor
            {
                get
                {
                    return base.method_3<Actor>("m_actor");
                }
            }

            public string m_cardID
            {
                get
                {
                    return base.method_4("m_cardID");
                }
            }

            public TAG_PREMIUM m_premium
            {
                get
                {
                    return base.method_2<TAG_PREMIUM>("m_premium");
                }
            }
        }

        public enum DraftMode
        {
            INVALID,
            NO_ACTIVE_DRAFT,
            DRAFTING,
            ACTIVE_DRAFT_DECK,
            IN_REWARDS
        }

        [Attribute38("DraftDisplay.LoadHeroActorCallbackInfo")]
        public class LoadHeroActorCallbackInfo : MonoClass
        {
            public LoadHeroActorCallbackInfo(IntPtr address) : this(address, "LoadHeroActorCallbackInfo")
            {
            }

            public LoadHeroActorCallbackInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public FullDef heroFullDef
            {
                get
                {
                    return base.method_3<FullDef>("heroFullDef");
                }
            }

            public TAG_PREMIUM premium
            {
                get
                {
                    return base.method_2<TAG_PREMIUM>("premium");
                }
            }
        }
    }
}

