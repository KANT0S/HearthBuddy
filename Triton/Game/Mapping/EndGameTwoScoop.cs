namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EndGameTwoScoop")]
    public class EndGameTwoScoop : MonoBehaviour
    {
        public EndGameTwoScoop(IntPtr address) : this(address, "EndGameTwoScoop")
        {
        }

        public EndGameTwoScoop(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EnableBannerLabel(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableBannerLabel", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideAll()
        {
            base.method_8("HideAll", Array.Empty<object>());
        }

        public void HideXpBar()
        {
            base.method_8("HideXpBar", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnAllHidden()
        {
            base.method_8("OnAllHidden", Array.Empty<object>());
        }

        public void OnHeroActorLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnHeroActorLoaded", objArray1);
        }

        public void PlayLevelUpEffect()
        {
            base.method_8("PlayLevelUpEffect", Array.Empty<object>());
        }

        public void PunchEndGameTwoScoop()
        {
            base.method_8("PunchEndGameTwoScoop", Array.Empty<object>());
        }

        public void ResetPositions()
        {
            base.method_8("ResetPositions", Array.Empty<object>());
        }

        public void SaveBannerText(string bannerText)
        {
            object[] objArray1 = new object[] { bannerText };
            base.method_8("SaveBannerText", objArray1);
        }

        public void SetBannerLabel(string label)
        {
            object[] objArray1 = new object[] { label };
            base.method_8("SetBannerLabel", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StopAnimating()
        {
            base.method_8("StopAnimating", Array.Empty<object>());
        }

        public static float AFTER_PUNCH_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EndGameTwoScoop", "AFTER_PUNCH_SCALE_VAL");
            }
        }

        public static float BAR_ANIMATION_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EndGameTwoScoop", "BAR_ANIMATION_DELAY");
            }
        }

        public static float END_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EndGameTwoScoop", "END_SCALE_VAL");
            }
        }

        public UberText m_bannerLabel
        {
            get
            {
                return base.method_3<UberText>("m_bannerLabel");
            }
        }

        public string m_bannerText
        {
            get
            {
                return base.method_4("m_bannerText");
            }
        }

        public Actor m_heroActor
        {
            get
            {
                return base.method_3<Actor>("m_heroActor");
            }
        }

        public bool m_heroActorLoaded
        {
            get
            {
                return base.method_2<bool>("m_heroActorLoaded");
            }
        }

        public GameObject m_heroBone
        {
            get
            {
                return base.method_3<GameObject>("m_heroBone");
            }
        }

        public bool m_isShown
        {
            get
            {
                return base.method_2<bool>("m_isShown");
            }
        }

        public GameObject m_levelUpTier1
        {
            get
            {
                return base.method_3<GameObject>("m_levelUpTier1");
            }
        }

        public GameObject m_levelUpTier2
        {
            get
            {
                return base.method_3<GameObject>("m_levelUpTier2");
            }
        }

        public GameObject m_levelUpTier3
        {
            get
            {
                return base.method_3<GameObject>("m_levelUpTier3");
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

        public static Vector3 START_POSITION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "EndGameTwoScoop", "START_POSITION");
            }
        }

        public static float START_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EndGameTwoScoop", "START_SCALE_VAL");
            }
        }
    }
}

