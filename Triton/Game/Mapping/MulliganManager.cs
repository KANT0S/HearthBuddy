namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MulliganManager")]
    public class MulliganManager : MonoBehaviour
    {
        public MulliganManager(IntPtr address) : this(address, "MulliganManager")
        {
        }

        public MulliganManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AutomaticContinueMulligan()
        {
            base.method_8("AutomaticContinueMulligan", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BeginDealNewCards()
        {
            base.method_8("BeginDealNewCards", Array.Empty<object>());
        }

        public void BeginMulligan()
        {
            base.method_8("BeginMulligan", Array.Empty<object>());
        }

        public void BeginMulliganCountdown(float endTimeStamp)
        {
            object[] objArray1 = new object[] { endTimeStamp };
            base.method_8("BeginMulliganCountdown", objArray1);
        }

        public void CoinCardSummonFinishedCallback(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("CoinCardSummonFinishedCallback", objArray1);
        }

        public void CoinTossTextCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("CoinTossTextCallback", objArray1);
        }

        public MulliganReplaceLabel CreateNewUILabelAtCardPosition(MulliganReplaceLabel prefab, int cardPosition)
        {
            object[] objArray1 = new object[] { prefab, cardPosition };
            return base.method_14<MulliganReplaceLabel>("CreateNewUILabelAtCardPosition", objArray1);
        }

        public void DestoryHeroSkinSocketInEffects()
        {
            base.method_8("DestoryHeroSkinSocketInEffects", Array.Empty<object>());
        }

        public void DestroyButton(object buttonToDestroy)
        {
            object[] objArray1 = new object[] { buttonToDestroy };
            base.method_8("DestroyButton", objArray1);
        }

        public void DestroyChooseBanner()
        {
            base.method_8("DestroyChooseBanner", Array.Empty<object>());
        }

        public void DestroyMulliganTimer()
        {
            base.method_8("DestroyMulliganTimer", Array.Empty<object>());
        }

        public void DestroyXobjects()
        {
            base.method_8("DestroyXobjects", Array.Empty<object>());
        }

        public void EndMulligan()
        {
            base.method_8("EndMulligan", Array.Empty<object>());
        }

        public void FadeHeroPowerIn(Card heroPowerCard)
        {
            object[] objArray1 = new object[] { heroPowerCard };
            base.method_8("FadeHeroPowerIn", objArray1);
        }

        public void FadeOutMulliganMusicAndStartGameplayMusic()
        {
            base.method_8("FadeOutMulliganMusicAndStartGameplayMusic", Array.Empty<object>());
        }

        public void ForceMulliganActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ForceMulliganActive", objArray1);
        }

        public static MulliganManager Get()
        {
            return MonoClass.smethod_15<MulliganManager>(TritonHs.MainAssemblyPath, "", "MulliganManager", "Get", Array.Empty<object>());
        }

        public Card GetCoinCardFromFriendlyHand()
        {
            return base.method_14<Card>("GetCoinCardFromFriendlyHand", Array.Empty<object>());
        }

        public NormalButton GetMulliganButton()
        {
            return base.method_14<NormalButton>("GetMulliganButton", Array.Empty<object>());
        }

        public void GetStartingLists()
        {
            base.method_8("GetStartingLists", Array.Empty<object>());
        }

        public void HandleGameOverDuringMulligan()
        {
            base.method_8("HandleGameOverDuringMulligan", Array.Empty<object>());
        }

        public void HandleGameStart()
        {
            base.method_8("HandleGameStart", Array.Empty<object>());
        }

        public void InitZones()
        {
            base.method_8("InitZones", Array.Empty<object>());
        }

        public bool IsCoinCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCoinCard", objArray1);
        }

        public bool IsMulliganActive()
        {
            return base.method_11<bool>("IsMulliganActive", Array.Empty<object>());
        }

        public bool IsTaskListPuttingUsPastMulligan(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("IsTaskListPuttingUsPastMulligan", objArray1);
        }

        public void LoadHisHeroSkinSocketInEffect(CardDef cardDef)
        {
            object[] objArray1 = new object[] { cardDef };
            base.method_8("LoadHisHeroSkinSocketInEffect", objArray1);
        }

        public void LoadMyHeroSkinSocketInEffect(CardDef cardDef)
        {
            object[] objArray1 = new object[] { cardDef };
            base.method_8("LoadMyHeroSkinSocketInEffect", objArray1);
        }

        public void OnCreateGame(GameState.CreateGamePhase phase, object userData)
        {
            object[] objArray1 = new object[] { phase, userData };
            base.method_8("OnCreateGame", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnEntitiesChosenReceived(Network.EntitiesChosen chosen, Network.EntityChoices choices, object userData)
        {
            object[] objArray1 = new object[] { chosen, choices, userData };
            return base.method_11<bool>("OnEntitiesChosenReceived", objArray1);
        }

        public void OnGameOver(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnGameOver", objArray1);
        }

        public void OnHisHeroSkinSocketInEffectLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnHisHeroSkinSocketInEffectLoaded", objArray1);
        }

        public void OnMulliganButtonLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnMulliganButtonLoaded", objArray1);
        }

        public void OnMulliganButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnMulliganButtonReleased", objArray1);
        }

        public void OnMulliganTimerUpdate(TurnTimerUpdate update, object userData)
        {
            object[] objArray1 = new object[] { update, userData };
            base.method_8("OnMulliganTimerUpdate", objArray1);
        }

        public void OnMyHeroSkinSocketInEffectLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnMyHeroSkinSocketInEffectLoaded", objArray1);
        }

        public void OnVersusTextLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnVersusTextLoaded", objArray1);
        }

        public void OnVersusVoLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnVersusVoLoaded", objArray1);
        }

        public void PutCoinCardInSpawnPosition(Card coinCard)
        {
            object[] objArray1 = new object[] { coinCard };
            base.method_8("PutCoinCardInSpawnPosition", objArray1);
        }

        public void ServerHasDealtReplacementCards(bool isFriendlySide)
        {
            object[] objArray1 = new object[] { isFriendlySide };
            base.method_8("ServerHasDealtReplacementCards", objArray1);
        }

        public void SetAllMulliganCardsToHold()
        {
            base.method_8("SetAllMulliganCardsToHold", Array.Empty<object>());
        }

        public bool ShouldHandleCoinCard()
        {
            return base.method_11<bool>("ShouldHandleCoinCard", Array.Empty<object>());
        }

        public bool ShouldWaitForMulliganCardsToBeProcessed()
        {
            return base.method_11<bool>("ShouldWaitForMulliganCardsToBeProcessed", Array.Empty<object>());
        }

        public void ShuffleDeck()
        {
            base.method_8("ShuffleDeck", Array.Empty<object>());
        }

        public void SkipCardChoosing()
        {
            base.method_8("SkipCardChoosing", Array.Empty<object>());
        }

        public void SkipMulligan()
        {
            base.method_8("SkipMulligan", Array.Empty<object>());
        }

        public void SkipMulliganForDev()
        {
            base.method_8("SkipMulliganForDev", Array.Empty<object>());
        }

        public void SlideCard(GameObject topCard)
        {
            object[] objArray1 = new object[] { topCard };
            base.method_8("SlideCard", objArray1);
        }

        public void SortHand(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            base.method_8("SortHand", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleHoldState(int startingCardsIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { startingCardsIndex };
            base.method_9("ToggleHoldState", enumArray1, objArray1);
        }

        public void ToggleHoldState(Card toggleCard)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { toggleCard };
            base.method_9("ToggleHoldState", enumArray1, objArray1);
        }

        public static float ANIMATION_TIME_DEAL_CARD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MulliganManager", "ANIMATION_TIME_DEAL_CARD");
            }
        }

        public Vector3 coinLocation
        {
            get
            {
                return base.method_2<Vector3>("coinLocation");
            }
        }

        public GameObject coinObject
        {
            get
            {
                return base.method_3<GameObject>("coinObject");
            }
        }

        public GameObject coinPrefab
        {
            get
            {
                return base.method_3<GameObject>("coinPrefab");
            }
        }

        public GameObject coinTossText
        {
            get
            {
                return base.method_3<GameObject>("coinTossText");
            }
        }

        public static float DEFAULT_STARTING_TAUNT_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MulliganManager", "DEFAULT_STARTING_TAUNT_DURATION");
            }
        }

        public bool friendlyPlayerGoesFirst
        {
            get
            {
                return base.method_2<bool>("friendlyPlayerGoesFirst");
            }
        }

        public bool friendlyPlayerHasReplacementCards
        {
            get
            {
                return base.method_2<bool>("friendlyPlayerHasReplacementCards");
            }
        }

        public ZoneDeck friendlySideDeck
        {
            get
            {
                return base.method_3<ZoneDeck>("friendlySideDeck");
            }
        }

        public ZoneHand friendlySideHandZone
        {
            get
            {
                return base.method_3<ZoneHand>("friendlySideHandZone");
            }
        }

        public GameObject heroLabelPrefab
        {
            get
            {
                return base.method_3<GameObject>("heroLabelPrefab");
            }
        }

        public Actor hisHeroCardActor
        {
            get
            {
                return base.method_3<Actor>("hisHeroCardActor");
            }
        }

        public HeroLabel hisheroLabel
        {
            get
            {
                return base.method_3<HeroLabel>("hisheroLabel");
            }
        }

        public Actor hisHeroPowerCardActor
        {
            get
            {
                return base.method_3<Actor>("hisHeroPowerCardActor");
            }
        }

        public GameObject hisWeldEffect
        {
            get
            {
                return base.method_3<GameObject>("hisWeldEffect");
            }
        }

        public Triton.Game.Mapping.Notification innkeeperMulliganDialog
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("innkeeperMulliganDialog");
            }
        }

        public bool introComplete
        {
            get
            {
                return base.method_2<bool>("introComplete");
            }
        }

        public int m_bonusCardIndex
        {
            get
            {
                return base.method_2<int>("m_bonusCardIndex");
            }
        }

        public int m_coinCardIndex
        {
            get
            {
                return base.method_2<int>("m_coinCardIndex");
            }
        }

        public List<bool> m_handCardsMarkedForReplace
        {
            get
            {
                Class246<bool> class2 = base.method_3<Class246<bool>>("m_handCardsMarkedForReplace");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_HisCustomSocketInSpell
        {
            get
            {
                return base.method_3<Spell>("m_HisCustomSocketInSpell");
            }
        }

        public bool m_isLoadingHisCustomSocketIn
        {
            get
            {
                return base.method_2<bool>("m_isLoadingHisCustomSocketIn");
            }
        }

        public bool m_isLoadingMyCustomSocketIn
        {
            get
            {
                return base.method_2<bool>("m_isLoadingMyCustomSocketIn");
            }
        }

        public MulliganTimer m_mulliganTimer
        {
            get
            {
                return base.method_3<MulliganTimer>("m_mulliganTimer");
            }
        }

        public Spell m_MyCustomSocketInSpell
        {
            get
            {
                return base.method_3<Spell>("m_MyCustomSocketInSpell");
            }
        }

        public List<MulliganReplaceLabel> m_replaceLabels
        {
            get
            {
                Class267<MulliganReplaceLabel> class2 = base.method_3<Class267<MulliganReplaceLabel>>("m_replaceLabels");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_resuming
        {
            get
            {
                return base.method_2<bool>("m_resuming");
            }
        }

        public List<Card> m_startingCards
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_startingCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Card> m_startingOppCards
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_startingOppCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_waitingForUserInput
        {
            get
            {
                return base.method_2<bool>("m_waitingForUserInput");
            }
        }

        public List<GameObject> m_xLabels
        {
            get
            {
                Class247<GameObject> class2 = base.method_3<Class247<GameObject>>("m_xLabels");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool mulliganActive
        {
            get
            {
                return base.method_2<bool>("mulliganActive");
            }
        }

        public NormalButton mulliganButton
        {
            get
            {
                return base.method_3<NormalButton>("mulliganButton");
            }
        }

        public GameObject mulliganChooseBanner
        {
            get
            {
                return base.method_3<GameObject>("mulliganChooseBanner");
            }
        }

        public GameObject mulliganChooseBannerPrefab
        {
            get
            {
                return base.method_3<GameObject>("mulliganChooseBannerPrefab");
            }
        }

        public GameObject mulliganKeepLabelPrefab
        {
            get
            {
                return base.method_3<GameObject>("mulliganKeepLabelPrefab");
            }
        }

        public MulliganReplaceLabel mulliganReplaceLabelPrefab
        {
            get
            {
                return base.method_3<MulliganReplaceLabel>("mulliganReplaceLabelPrefab");
            }
        }

        public GameObject mulliganTimerPrefab
        {
            get
            {
                return base.method_3<GameObject>("mulliganTimerPrefab");
            }
        }

        public GameObject mulliganXlabelPrefab
        {
            get
            {
                return base.method_3<GameObject>("mulliganXlabelPrefab");
            }
        }

        public Actor myHeroCardActor
        {
            get
            {
                return base.method_3<Actor>("myHeroCardActor");
            }
        }

        public HeroLabel myheroLabel
        {
            get
            {
                return base.method_3<HeroLabel>("myheroLabel");
            }
        }

        public Actor myHeroPowerCardActor
        {
            get
            {
                return base.method_3<Actor>("myHeroPowerCardActor");
            }
        }

        public GameObject myWeldEffect
        {
            get
            {
                return base.method_3<GameObject>("myWeldEffect");
            }
        }

        public bool opponentPlayerHasReplacementCards
        {
            get
            {
                return base.method_2<bool>("opponentPlayerHasReplacementCards");
            }
        }

        public ZoneDeck opposingSideDeck
        {
            get
            {
                return base.method_3<ZoneDeck>("opposingSideDeck");
            }
        }

        public ZoneHand opposingSideHandZone
        {
            get
            {
                return base.method_3<ZoneHand>("opposingSideHandZone");
            }
        }

        public static float PHONE_CARD_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MulliganManager", "PHONE_CARD_SCALE");
            }
        }

        public static float PHONE_CARD_Z_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MulliganManager", "PHONE_CARD_Z_OFFSET");
            }
        }

        public static float PHONE_HEIGHT_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MulliganManager", "PHONE_HEIGHT_OFFSET");
            }
        }

        public static float PHONE_ZONE_SIZE_ADJUST
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MulliganManager", "PHONE_ZONE_SIZE_ADJUST");
            }
        }

        public bool skipCardChoosing
        {
            get
            {
                return base.method_2<bool>("skipCardChoosing");
            }
        }

        public GameObject startingHandZone
        {
            get
            {
                return base.method_3<GameObject>("startingHandZone");
            }
        }

        public GameObject versusTextObject
        {
            get
            {
                return base.method_3<GameObject>("versusTextObject");
            }
        }

        public bool waitingForVersusText
        {
            get
            {
                return base.method_2<bool>("waitingForVersusText");
            }
        }

        public bool waitingForVersusVo
        {
            get
            {
                return base.method_2<bool>("waitingForVersusVo");
            }
        }

        public GameObject weldPrefab
        {
            get
            {
                return base.method_3<GameObject>("weldPrefab");
            }
        }
    }
}

