namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TavernBrawlDisplay")]
    public class TavernBrawlDisplay : MonoBehaviour
    {
        public TavernBrawlDisplay(IntPtr address) : this(address, "TavernBrawlDisplay")
        {
        }

        public TavernBrawlDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool BackFromDeckEdit(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            return base.method_11<bool>("BackFromDeckEdit", objArray1);
        }

        public void CreateDeck()
        {
            base.method_8("CreateDeck", Array.Empty<object>());
        }

        public void EditOrDeleteDeck(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("EditOrDeleteDeck", objArray1);
        }

        public void EnablePlayButton()
        {
            base.method_8("EnablePlayButton", Array.Empty<object>());
        }

        public static TavernBrawlDisplay Get()
        {
            return MonoClass.smethod_15<TavernBrawlDisplay>(TritonHs.MainAssemblyPath, "", "TavernBrawlDisplay", "Get", Array.Empty<object>());
        }

        public void HandleGameStartupFailure()
        {
            base.method_8("HandleGameStartupFailure", Array.Empty<object>());
        }

        public void HideReward(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("HideReward", objArray1);
        }

        public bool IsInDeckEditMode()
        {
            return base.method_11<bool>("IsInDeckEditMode", Array.Empty<object>());
        }

        public static bool IsTavernBrawlEditing()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "TavernBrawlDisplay", "IsTavernBrawlEditing", Array.Empty<object>());
        }

        public static bool IsTavernBrawlOpen()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "TavernBrawlDisplay", "IsTavernBrawlOpen", Array.Empty<object>());
        }

        public static bool IsTavernBrawlViewing()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "TavernBrawlDisplay", "IsTavernBrawlViewing", Array.Empty<object>());
        }

        public void NetCache_OnTavernBrawlRecord()
        {
            base.method_8("NetCache_OnTavernBrawlRecord", Array.Empty<object>());
        }

        public void OnBackButton()
        {
            base.method_8("OnBackButton", Array.Empty<object>());
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

        public void OnDeckDeleted(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("OnDeckDeleted", objArray1);
        }

        public void OnDeleteButtonConfirmationResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnDeleteButtonConfirmationResponse", objArray1);
        }

        public void OnDeleteButtonPressed()
        {
            base.method_8("OnDeleteButtonPressed", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
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

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void RefreshDataBasedUI(float animDelay)
        {
            object[] objArray1 = new object[] { animDelay };
            base.method_8("RefreshDataBasedUI", objArray1);
        }

        public void RefreshStateBasedUI(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("RefreshStateBasedUI", objArray1);
        }

        public void RefreshTavernBrawlInfo(float animDelay)
        {
            object[] objArray1 = new object[] { animDelay };
            base.method_8("RefreshTavernBrawlInfo", objArray1);
        }

        public void RefreshTavernBrawlInfo_ConfirmEnded(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("RefreshTavernBrawlInfo_ConfirmEnded", objArray1);
        }

        public void SetUIForFriendlyChallenge(bool isTavernBrawlChallenge)
        {
            object[] objArray1 = new object[] { isTavernBrawlChallenge };
            base.method_8("SetUIForFriendlyChallenge", objArray1);
        }

        public void ShowReward(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ShowReward", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartGame(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("StartGame", objArray1);
        }

        public bool SwitchToEditDeckMode(CollectionDeck deck)
        {
            object[] objArray1 = new object[] { deck };
            return base.method_11<bool>("SwitchToEditDeckMode", objArray1);
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void UpdateDeckPanels(bool animate)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { animate };
            base.method_9("UpdateDeckPanels", enumArray1, objArray1);
        }

        public void UpdateDeckPanels(bool hasDeck, bool animate)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { hasDeck, animate };
            base.method_9("UpdateDeckPanels", enumArray1, objArray1);
        }

        public void UpdateEditOrCreate()
        {
            base.method_8("UpdateEditOrCreate", Array.Empty<object>());
        }

        public void UpdateTimeText()
        {
            base.method_8("UpdateTimeText", Array.Empty<object>());
        }

        public void ValidateDeck()
        {
            base.method_8("ValidateDeck", Array.Empty<object>());
        }

        public string CARD_COUNT_PANEL_CLOSE_ANIM
        {
            get
            {
                return base.method_4("CARD_COUNT_PANEL_CLOSE_ANIM");
            }
        }

        public string CARD_COUNT_PANEL_OPEN_ANIM
        {
            get
            {
                return base.method_4("CARD_COUNT_PANEL_OPEN_ANIM");
            }
        }

        public UIBButton m_backButton
        {
            get
            {
                return base.method_3<UIBButton>("m_backButton");
            }
        }

        public bool m_cardCountPanelAnimOpen
        {
            get
            {
                return base.method_2<bool>("m_cardCountPanelAnimOpen");
            }
        }

        public SlidingTray m_cardListPanel
        {
            get
            {
                return base.method_3<SlidingTray>("m_cardListPanel");
            }
        }

        public GameObject m_chalkboard
        {
            get
            {
                return base.method_3<GameObject>("m_chalkboard");
            }
        }

        public UberText m_chalkboardEndInfo
        {
            get
            {
                return base.method_3<UberText>("m_chalkboardEndInfo");
            }
        }

        public UberText m_chalkboardHeader
        {
            get
            {
                return base.method_3<UberText>("m_chalkboardHeader");
            }
        }

        public UberText m_chalkboardInfo
        {
            get
            {
                return base.method_3<UberText>("m_chalkboardInfo");
            }
        }

        public Material m_chestOpenMaterial
        {
            get
            {
                return base.method_3<Material>("m_chestOpenMaterial");
            }
        }

        public UIBButton m_createDeckButton
        {
            get
            {
                return base.method_3<UIBButton>("m_createDeckButton");
            }
        }

        public HighlightState m_createDeckHighlight
        {
            get
            {
                return base.method_3<HighlightState>("m_createDeckHighlight");
            }
        }

        public long m_deckBeingEdited
        {
            get
            {
                return base.method_2<long>("m_deckBeingEdited");
            }
        }

        public GameObject m_deleteIcon
        {
            get
            {
                return base.method_3<GameObject>("m_deleteIcon");
            }
        }

        public Color m_disabledTextColor
        {
            get
            {
                return base.method_2<Color>("m_disabledTextColor");
            }
        }

        public bool m_doWipeAnimation
        {
            get
            {
                return base.method_2<bool>("m_doWipeAnimation");
            }
        }

        public UIBButton m_editDeckButton
        {
            get
            {
                return base.method_3<UIBButton>("m_editDeckButton");
            }
        }

        public HighlightState m_editDeckHighlight
        {
            get
            {
                return base.method_3<HighlightState>("m_editDeckHighlight");
            }
        }

        public GameObject m_editIcon
        {
            get
            {
                return base.method_3<GameObject>("m_editIcon");
            }
        }

        public UberText m_editText
        {
            get
            {
                return base.method_3<UberText>("m_editText");
            }
        }

        public GameObject m_fullPanel
        {
            get
            {
                return base.method_3<GameObject>("m_fullPanel");
            }
        }

        public UberText m_numWins
        {
            get
            {
                return base.method_3<UberText>("m_numWins");
            }
        }

        public GameObject m_panelWithCreateDeck
        {
            get
            {
                return base.method_3<GameObject>("m_panelWithCreateDeck");
            }
        }

        public PlayButton m_playButton
        {
            get
            {
                return base.method_3<PlayButton>("m_playButton");
            }
        }

        public PegUIElement m_rewardChest
        {
            get
            {
                return base.method_3<PegUIElement>("m_rewardChest");
            }
        }

        public GameObject m_rewardContainer
        {
            get
            {
                return base.method_3<GameObject>("m_rewardContainer");
            }
        }

        public HighlightState m_rewardHighlight
        {
            get
            {
                return base.method_3<HighlightState>("m_rewardHighlight");
            }
        }

        public GameObject m_rewardObject
        {
            get
            {
                return base.method_3<GameObject>("m_rewardObject");
            }
        }

        public PegUIElement m_rewardOffClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_rewardOffClickCatcher");
            }
        }

        public GameObject m_rewardsPreview
        {
            get
            {
                return base.method_3<GameObject>("m_rewardsPreview");
            }
        }

        public Vector3 m_rewardsScale
        {
            get
            {
                return base.method_2<Vector3>("m_rewardsScale");
            }
        }

        public UberText m_rewardsText
        {
            get
            {
                return base.method_3<UberText>("m_rewardsText");
            }
        }

        public SlidingTray m_tavernBrawlTray
        {
            get
            {
                return base.method_3<SlidingTray>("m_tavernBrawlTray");
            }
        }

        public GameObject m_winsBanner
        {
            get
            {
                return base.method_3<GameObject>("m_winsBanner");
            }
        }

        public float m_wipeAnimStartDelay
        {
            get
            {
                return base.method_2<float>("m_wipeAnimStartDelay");
            }
        }
    }
}

