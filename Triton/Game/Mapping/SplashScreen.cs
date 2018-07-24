namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SplashScreen")]
    public class SplashScreen : MonoBehaviour
    {
        public SplashScreen(IntPtr address) : this(address, "SplashScreen")
        {
        }

        public SplashScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearLogin(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ClearLogin", objArray1);
        }

        public void DestroySplashScreen()
        {
            base.method_8("DestroySplashScreen", Array.Empty<object>());
        }

        public void FadeGlowsIn()
        {
            base.method_8("FadeGlowsIn", Array.Empty<object>());
        }

        public void FinishSplashScreen()
        {
            base.method_8("FinishSplashScreen", Array.Empty<object>());
        }

        public static SplashScreen Get()
        {
            return MonoClass.smethod_15<SplashScreen>(TritonHs.MainAssemblyPath, "", "SplashScreen", "Get", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideLogo()
        {
            base.method_8("HideLogo", Array.Empty<object>());
        }

        public void HideWebAuth()
        {
            base.method_8("HideWebAuth", Array.Empty<object>());
        }

        public void HideWebLoginCanvas()
        {
            base.method_8("HideWebLoginCanvas", Array.Empty<object>());
        }

        public bool IsFinished()
        {
            return base.method_11<bool>("IsFinished", Array.Empty<object>());
        }

        public bool IsRatingsScreenFinished()
        {
            return base.method_11<bool>("IsRatingsScreenFinished", Array.Empty<object>());
        }

        public void KoreaRatingsScreen()
        {
            base.method_8("KoreaRatingsScreen", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnKoreaRatingsScreenLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnKoreaRatingsScreenLoaded", objArray1);
        }

        public void QueueInfoHandler(Network.QueueInfo queueInfo)
        {
            object[] objArray1 = new object[] { queueInfo };
            base.method_8("QueueInfoHandler", objArray1);
        }

        public void QuitGame(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("QuitGame", objArray1);
        }

        public void RequestBreakingNews()
        {
            base.method_8("RequestBreakingNews", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowQueueInfo()
        {
            base.method_8("ShowQueueInfo", Array.Empty<object>());
        }

        public void ShowRatings()
        {
            base.method_8("ShowRatings", Array.Empty<object>());
        }

        public void StartPatching()
        {
            base.method_8("StartPatching", Array.Empty<object>());
        }

        public void StopPatching()
        {
            base.method_8("StopPatching", Array.Empty<object>());
        }

        public void UnHideWebAuth()
        {
            base.method_8("UnHideWebAuth", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdatePatching()
        {
            base.method_8("UpdatePatching", Array.Empty<object>());
        }

        public void UpdateWebAuth()
        {
            base.method_8("UpdateWebAuth", Array.Empty<object>());
        }

        public static float GLOW_FADE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SplashScreen", "GLOW_FADE_TIME");
            }
        }

        public static float KOREA_RATINGS_SCREEN_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SplashScreen", "KOREA_RATINGS_SCREEN_DISPLAY_TIME");
            }
        }

        public GameObject m_blizzardLogo
        {
            get
            {
                return base.method_3<GameObject>("m_blizzardLogo");
            }
        }

        public GameObject m_demoDisclaimer
        {
            get
            {
                return base.method_3<GameObject>("m_demoDisclaimer");
            }
        }

        public StandardPegButtonNew m_devClearLoginButton
        {
            get
            {
                return base.method_3<StandardPegButtonNew>("m_devClearLoginButton");
            }
        }

        public bool m_fadingStarted
        {
            get
            {
                return base.method_2<bool>("m_fadingStarted");
            }
        }

        public Glow m_glow1
        {
            get
            {
                return base.method_3<Glow>("m_glow1");
            }
        }

        public Glow m_glow2
        {
            get
            {
                return base.method_3<Glow>("m_glow2");
            }
        }

        public bool m_hasProvidedWebAuthToken
        {
            get
            {
                return base.method_2<bool>("m_hasProvidedWebAuthToken");
            }
        }

        public bool m_inputCameraSet
        {
            get
            {
                return base.method_2<bool>("m_inputCameraSet");
            }
        }

        public bool m_loginFinished
        {
            get
            {
                return base.method_2<bool>("m_loginFinished");
            }
        }

        public GameObject m_logo
        {
            get
            {
                return base.method_3<GameObject>("m_logo");
            }
        }

        public GameObject m_logoContainer
        {
            get
            {
                return base.method_3<GameObject>("m_logoContainer");
            }
        }

        public bool m_LogoFinished
        {
            get
            {
                return base.method_2<bool>("m_LogoFinished");
            }
        }

        public string m_logoPrefab
        {
            get
            {
                return base.method_4("m_logoPrefab");
            }
        }

        public bool m_patching
        {
            get
            {
                return base.method_2<bool>("m_patching");
            }
        }

        public ProgressBar m_patchingBar
        {
            get
            {
                return base.method_3<ProgressBar>("m_patchingBar");
            }
        }

        public float m_patchingBarShownTime
        {
            get
            {
                return base.method_2<float>("m_patchingBarShownTime");
            }
        }

        public GameObject m_patchingFrame
        {
            get
            {
                return base.method_3<GameObject>("m_patchingFrame");
            }
        }

        public bool m_queueFinished
        {
            get
            {
                return base.method_2<bool>("m_queueFinished");
            }
        }

        public Network.QueueInfo m_queueInfo
        {
            get
            {
                return base.method_3<Network.QueueInfo>("m_queueInfo");
            }
        }

        public bool m_queueShown
        {
            get
            {
                return base.method_2<bool>("m_queueShown");
            }
        }

        public GameObject m_queueSign
        {
            get
            {
                return base.method_3<GameObject>("m_queueSign");
            }
        }

        public UberText m_queueText
        {
            get
            {
                return base.method_3<UberText>("m_queueText");
            }
        }

        public UberText m_queueTime
        {
            get
            {
                return base.method_3<UberText>("m_queueTime");
            }
        }

        public UberText m_queueTitle
        {
            get
            {
                return base.method_3<UberText>("m_queueTitle");
            }
        }

        public StandardPegButtonNew m_quitButton
        {
            get
            {
                return base.method_3<StandardPegButtonNew>("m_quitButton");
            }
        }

        public GameObject m_quitButtonParent
        {
            get
            {
                return base.method_3<GameObject>("m_quitButtonParent");
            }
        }

        public bool m_RatingsFinished
        {
            get
            {
                return base.method_2<bool>("m_RatingsFinished");
            }
        }

        public bool m_triedToken
        {
            get
            {
                return base.method_2<bool>("m_triedToken");
            }
        }

        public WebAuth m_webAuth
        {
            get
            {
                return base.method_3<WebAuth>("m_webAuth");
            }
        }

        public bool m_webAuthHidden
        {
            get
            {
                return base.method_2<bool>("m_webAuthHidden");
            }
        }

        public string m_webAuthUrl
        {
            get
            {
                return base.method_4("m_webAuthUrl");
            }
        }

        public GameObject m_webLoginCanvas
        {
            get
            {
                return base.method_3<GameObject>("m_webLoginCanvas");
            }
        }

        public string m_webToken
        {
            get
            {
                return base.method_4("m_webToken");
            }
        }

        public static float MinPatchingBarDisplayTime
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SplashScreen", "MinPatchingBarDisplayTime");
            }
        }
    }
}

