namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Login")]
    public class Login : Scene
    {
        public Login(IntPtr address) : this(address, "Login")
        {
        }

        public Login(IntPtr address, string className) : base(address, className)
        {
        }

        public void AssetsVersionCheckCompleted()
        {
            base.method_8("AssetsVersionCheckCompleted", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChangeMode()
        {
            base.method_8("ChangeMode", Array.Empty<object>());
        }

        public void ChangeMode_Hub()
        {
            base.method_8("ChangeMode_Hub", Array.Empty<object>());
        }

        public void ChangeMode_Resume(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("ChangeMode_Resume", objArray1);
        }

        public void ChangeMode_Tutorial()
        {
            base.method_8("ChangeMode_Tutorial", Array.Empty<object>());
        }

        public void DoSkippedBoxIntro()
        {
            base.method_8("DoSkippedBoxIntro", Array.Empty<object>());
        }

        public static Login Get()
        {
            return MonoClass.smethod_15<Login>(TritonHs.MainAssemblyPath, "", "Login", "Get", Array.Empty<object>());
        }

        public void HandleUnAckedRewardsAndCompletedQuests()
        {
            base.method_8("HandleUnAckedRewardsAndCompletedQuests", Array.Empty<object>());
        }

        public static bool IsLoginSceneActive()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Login", "IsLoginSceneActive", Array.Empty<object>());
        }

        public bool isWaitingForBattleNet()
        {
            return base.method_11<bool>("isWaitingForBattleNet", Array.Empty<object>());
        }

        public void LoginOk()
        {
            base.method_8("LoginOk", Array.Empty<object>());
        }

        public void OnAccountLicensesResponse()
        {
            base.method_8("OnAccountLicensesResponse", Array.Empty<object>());
        }

        public void OnAssetsVersion()
        {
            base.method_8("OnAssetsVersion", Array.Empty<object>());
        }

        public void OnCinematicFinished()
        {
            base.method_8("OnCinematicFinished", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnExistingAccountLoadedCallback(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnExistingAccountLoadedCallback", objArray1);
        }

        public void OnExistingAccountPopupResponse(bool hasAccount)
        {
            object[] objArray1 = new object[] { hasAccount };
            base.method_8("OnExistingAccountPopupResponse", objArray1);
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void OnGameLicensesResponse()
        {
            base.method_8("OnGameLicensesResponse", Array.Empty<object>());
        }

        public void OnMissionSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnMissionSceneLoaded", objArray1);
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public bool OnReconnectTimeout(object userData)
        {
            object[] objArray1 = new object[] { userData };
            return base.method_11<bool>("OnReconnectTimeout", objArray1);
        }

        public void OnRewardClicked(Reward reward, object userData)
        {
            object[] objArray1 = new object[] { reward, userData };
            base.method_8("OnRewardClicked", objArray1);
        }

        public void OnRewardObjectLoaded(Reward reward, object callbackData)
        {
            object[] objArray1 = new object[] { reward, callbackData };
            base.method_8("OnRewardObjectLoaded", objArray1);
        }

        public void OnRewardShown(object callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("OnRewardShown", objArray1);
        }

        public void OnSetProgressResponse()
        {
            base.method_8("OnSetProgressResponse", Array.Empty<object>());
        }

        public void OnStartButtonPressed(Box.ButtonType buttonType, object userData)
        {
            object[] objArray1 = new object[] { buttonType, userData };
            base.method_8("OnStartButtonPressed", objArray1);
        }

        public void OnStartupHubSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnStartupHubSpellFinished", objArray1);
        }

        public void OnStartupTutorialSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnStartupTutorialSpellFinished", objArray1);
        }

        public void OnTutorialPlaySpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnTutorialPlaySpellStateFinished", objArray1);
        }

        public void OnTutorialProgressScreenCallback(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTutorialProgressScreenCallback", objArray1);
        }

        public void OnUpdateLoginComplete()
        {
            base.method_8("OnUpdateLoginComplete", Array.Empty<object>());
        }

        public void OnWelcomeQuestsCallback()
        {
            base.method_8("OnWelcomeQuestsCallback", Array.Empty<object>());
        }

        public void PreloadActors()
        {
            base.method_8("PreloadActors", Array.Empty<object>());
        }

        public void ReconnectOrChangeMode()
        {
            base.method_8("ReconnectOrChangeMode", Array.Empty<object>());
        }

        public bool ShouldDoIntro()
        {
            return base.method_11<bool>("ShouldDoIntro", Array.Empty<object>());
        }

        public void ShowAlertDialogs()
        {
            base.method_8("ShowAlertDialogs", Array.Empty<object>());
        }

        public void ShowGoldCapAlert()
        {
            base.method_8("ShowGoldCapAlert", Array.Empty<object>());
        }

        public void ShowGraphicsDeviceWarning()
        {
            base.method_8("ShowGraphicsDeviceWarning", Array.Empty<object>());
        }

        public void ShowNerfedCards()
        {
            base.method_8("ShowNerfedCards", Array.Empty<object>());
        }

        public bool ShowNextCompletedQuest()
        {
            return base.method_11<bool>("ShowNextCompletedQuest", Array.Empty<object>());
        }

        public bool ShowNextUnAckedReward()
        {
            return base.method_11<bool>("ShowNextUnAckedReward", Array.Empty<object>());
        }

        public void ShowNextUnAckedRewardOrCompletedQuest()
        {
            base.method_8("ShowNextUnAckedRewardOrCompletedQuest", Array.Empty<object>());
        }

        public void ShowTextureCompressionWarning()
        {
            base.method_8("ShowTextureCompressionWarning", Array.Empty<object>());
        }

        public void ShowTutorialProgressScreen()
        {
            base.method_8("ShowTutorialProgressScreen", Array.Empty<object>());
        }

        public void ShowWelcomeQuests()
        {
            base.method_8("ShowWelcomeQuests", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartTutorial()
        {
            base.method_8("StartTutorial", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public List<Achievement> m_completedQuests
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_completedQuests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ExistingAccountPopup m_existingAccountPopup
        {
            get
            {
                return base.method_3<ExistingAccountPopup>("m_existingAccountPopup");
            }
        }

        public int m_nextMissionId
        {
            get
            {
                return base.method_2<int>("m_nextMissionId");
            }
        }

        public int m_numRewardsToLoad
        {
            get
            {
                return base.method_2<int>("m_numRewardsToLoad");
            }
        }

        public List<Reward> m_rewards
        {
            get
            {
                Class267<Reward> class2 = base.method_3<Class267<Reward>>("m_rewards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public TutorialProgress m_skipToTutorialProgress
        {
            get
            {
                return base.method_2<TutorialProgress>("m_skipToTutorialProgress");
            }
        }

        public bool m_waitingForBattleNet
        {
            get
            {
                return base.method_2<bool>("m_waitingForBattleNet");
            }
        }

        public bool m_waitingForSetProgress
        {
            get
            {
                return base.method_2<bool>("m_waitingForSetProgress");
            }
        }

        public bool m_waitingForUpdateLoginComplete
        {
            get
            {
                return base.method_2<bool>("m_waitingForUpdateLoginComplete");
            }
        }

        public static Vector3 REWARD_LOCAL_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "Login", "REWARD_LOCAL_POS");
            }
        }
    }
}

