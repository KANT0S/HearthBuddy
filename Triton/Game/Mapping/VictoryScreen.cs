namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("VictoryScreen")]
    public class VictoryScreen : EndGameScreen
    {
        public VictoryScreen(IntPtr address) : this(address, "VictoryScreen")
        {
        }

        public VictoryScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ContinueButtonPress_FirstTimeHub(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ContinueButtonPress_FirstTimeHub", objArray1);
        }

        public string GetGoldenHeroCardID()
        {
            return base.method_13("GetGoldenHeroCardID", Array.Empty<object>());
        }

        public void InitGoldRewardUI()
        {
            base.method_8("InitGoldRewardUI", Array.Empty<object>());
        }

        public bool JustEarnedGoldenHero()
        {
            return base.method_11<bool>("JustEarnedGoldenHero", Array.Empty<object>());
        }

        public void LoadGoldenHeroEvent()
        {
            base.method_8("LoadGoldenHeroEvent", Array.Empty<object>());
        }

        public void NotifyOfGoldenHeroAnimComplete()
        {
            base.method_8("NotifyOfGoldenHeroAnimComplete", Array.Empty<object>());
        }

        public void OnGoldenHeroCardDefLoaded(string cardId, CardDef def, object userData)
        {
            object[] objArray1 = new object[] { cardId, def, userData };
            base.method_8("OnGoldenHeroCardDefLoaded", objArray1);
        }

        public void OnGoldenHeroEventLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnGoldenHeroEventLoaded", objArray1);
        }

        public void OnTwoScoopHidden()
        {
            base.method_8("OnTwoScoopHidden", Array.Empty<object>());
        }

        public void OnTwoScoopShown()
        {
            base.method_8("OnTwoScoopShown", Array.Empty<object>());
        }

        public bool ShowGoldenHeroEvent()
        {
            return base.method_11<bool>("ShowGoldenHeroEvent", Array.Empty<object>());
        }

        public void ShowStandardFlow()
        {
            base.method_8("ShowStandardFlow", Array.Empty<object>());
        }

        public void UserPressedStartButton(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("UserPressedStartButton", objArray1);
        }

        public GamesWonIndicator m_gamesWonIndicator
        {
            get
            {
                return base.method_3<GamesWonIndicator>("m_gamesWonIndicator");
            }
        }

        public Achievement m_goldenHeroAchievement
        {
            get
            {
                return base.method_3<Achievement>("m_goldenHeroAchievement");
            }
        }

        public CardDef m_goldenHeroCardDef
        {
            get
            {
                return base.method_3<CardDef>("m_goldenHeroCardDef");
            }
        }

        public bool m_goldenHeroCardDefReady
        {
            get
            {
                return base.method_2<bool>("m_goldenHeroCardDefReady");
            }
        }

        public GoldenHeroEvent m_goldenHeroEvent
        {
            get
            {
                return base.method_3<GoldenHeroEvent>("m_goldenHeroEvent");
            }
        }

        public Transform m_goldenHeroEventBone
        {
            get
            {
                return base.method_3<Transform>("m_goldenHeroEventBone");
            }
        }

        public bool m_hasParsedCompletedQuests
        {
            get
            {
                return base.method_2<bool>("m_hasParsedCompletedQuests");
            }
        }

        public UberText m_noGoldRewardText
        {
            get
            {
                return base.method_3<UberText>("m_noGoldRewardText");
            }
        }

        public bool m_showGoldenHeroEvent
        {
            get
            {
                return base.method_2<bool>("m_showGoldenHeroEvent");
            }
        }

        public bool m_showNoGoldRewardText
        {
            get
            {
                return base.method_2<bool>("m_showNoGoldRewardText");
            }
        }

        public bool m_showWinProgress
        {
            get
            {
                return base.method_2<bool>("m_showWinProgress");
            }
        }

        public static string NO_GOLDEN_HERO
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "VictoryScreen", "NO_GOLDEN_HERO");
            }
        }
    }
}

