namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Cheats")]
    public class Cheats : MonoClass
    {
        public Cheats(IntPtr address) : this(address, "Cheats")
        {
        }

        public Cheats(IntPtr address, string className) : base(address, className)
        {
        }

        public static string Cheat_ShowRewardBoxes(string parsableRewardBags)
        {
            object[] objArray1 = new object[] { parsableRewardBags };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Cheats", "Cheat_ShowRewardBoxes", objArray1);
        }

        public AlertPopup.PopupInfo GenerateAlertInfo(string rawArgs)
        {
            object[] objArray1 = new object[] { rawArgs };
            return base.method_14<AlertPopup.PopupInfo>("GenerateAlertInfo", objArray1);
        }

        public static Cheats Get()
        {
            return MonoClass.smethod_15<Cheats>(TritonHs.MainAssemblyPath, "", "Cheats", "Get", Array.Empty<object>());
        }

        public string GetBoard()
        {
            return base.method_13("GetBoard", Array.Empty<object>());
        }

        public string GetChallengeUrl(string type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_13("GetChallengeUrl", objArray1);
        }

        public QuickLaunchAvailability GetQuickLaunchAvailability()
        {
            return base.method_11<QuickLaunchAvailability>("GetQuickLaunchAvailability", Array.Empty<object>());
        }

        public string GetQuickPlayMissionName(int missionId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { missionId };
            return base.method_12("GetQuickPlayMissionName", enumArray1, objArray1);
        }

        public string GetQuickPlayMissionNameImpl(int missionId, string columnName)
        {
            object[] objArray1 = new object[] { missionId, columnName };
            return base.method_13("GetQuickPlayMissionNameImpl", objArray1);
        }

        public string GetQuickPlayMissionShortName(int missionId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { missionId };
            return base.method_12("GetQuickPlayMissionShortName", enumArray1, objArray1);
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public bool HandleQuickPlayInput()
        {
            return base.method_11<bool>("HandleQuickPlayInput", Array.Empty<object>());
        }

        public static void Initialize()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Cheats", "Initialize");
        }

        public void InitializeImpl()
        {
            base.method_8("InitializeImpl", Array.Empty<object>());
        }

        public bool IsLaunchingQuickGame()
        {
            return base.method_11<bool>("IsLaunchingQuickGame", Array.Empty<object>());
        }

        public bool IsYourMindFree()
        {
            return base.method_11<bool>("IsYourMindFree", Array.Empty<object>());
        }

        public void LaunchQuickGame(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            base.method_8("LaunchQuickGame", objArray1);
        }

        public bool OnAlertProcessed(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnAlertProcessed", objArray1);
        }

        public void OnAlertResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnAlertResponse", objArray1);
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnProcessCheat_utilservercmd_OnResponse()
        {
            base.method_8("OnProcessCheat_utilservercmd_OnResponse", Array.Empty<object>());
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void PositionLoginFixedReward(Reward reward)
        {
            object[] objArray1 = new object[] { reward };
            base.method_8("PositionLoginFixedReward", objArray1);
        }

        public void PrintQuickPlayLegend()
        {
            base.method_8("PrintQuickPlayLegend", Array.Empty<object>());
        }

        public bool QuickGameFlipHeroes()
        {
            return base.method_11<bool>("QuickGameFlipHeroes", Array.Empty<object>());
        }

        public bool QuickGameMirrorHeroes()
        {
            return base.method_11<bool>("QuickGameMirrorHeroes", Array.Empty<object>());
        }

        public string QuickGameOpponentHeroCardId()
        {
            return base.method_13("QuickGameOpponentHeroCardId", Array.Empty<object>());
        }

        public bool QuickGameSkipMulligan()
        {
            return base.method_11<bool>("QuickGameSkipMulligan", Array.Empty<object>());
        }

        public static void SubscribePartyEvents()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Cheats", "SubscribePartyEvents");
        }

        public AlertPopup m_alert
        {
            get
            {
                return base.method_3<AlertPopup>("m_alert");
            }
        }

        public string m_board
        {
            get
            {
                return base.method_4("m_board");
            }
        }

        public bool m_isYourMindFree
        {
            get
            {
                return base.method_2<bool>("m_isYourMindFree");
            }
        }

        public List<string> m_lastUtilServerCmd
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("m_lastUtilServerCmd");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_loadingStoreChallengePrompt
        {
            get
            {
                return base.method_2<bool>("m_loadingStoreChallengePrompt");
            }
        }

        public QuickLaunchState m_quickLaunchState
        {
            get
            {
                return base.method_3<QuickLaunchState>("m_quickLaunchState");
            }
        }

        public StoreChallengePrompt m_storeChallengePrompt
        {
            get
            {
                return base.method_3<StoreChallengePrompt>("m_storeChallengePrompt");
            }
        }

        public static Logger PartyLogger
        {
            get
            {
                return MonoClass.smethod_15<Logger>(TritonHs.MainAssemblyPath, "", "Cheats", "get_PartyLogger", Array.Empty<object>());
            }
        }

        public static bool s_hasSubscribedToPartyEvents
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "Cheats", "s_hasSubscribedToPartyEvents");
            }
        }

        public enum QuickLaunchAvailability
        {
            OK,
            FINDING_GAME,
            ACTIVE_GAME,
            SCENE_TRANSITION,
            COLLECTION_NOT_READY
        }

        [Attribute38("Cheats.QuickLaunchState")]
        public class QuickLaunchState : MonoClass
        {
            public QuickLaunchState(IntPtr address) : this(address, "QuickLaunchState")
            {
            }

            public QuickLaunchState(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_flipHeroes
            {
                get
                {
                    return base.method_2<bool>("m_flipHeroes");
                }
            }

            public bool m_launching
            {
                get
                {
                    return base.method_2<bool>("m_launching");
                }
            }

            public bool m_mirrorHeroes
            {
                get
                {
                    return base.method_2<bool>("m_mirrorHeroes");
                }
            }

            public string m_opponentHeroCardId
            {
                get
                {
                    return base.method_4("m_opponentHeroCardId");
                }
            }

            public bool m_skipMulligan
            {
                get
                {
                    return base.method_2<bool>("m_skipMulligan");
                }
            }
        }
    }
}

