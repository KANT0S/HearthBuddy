namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroXPBar")]
    public class HeroXPBar : PegUIElement
    {
        public HeroXPBar(IntPtr address) : this(address, "HeroXPBar")
        {
        }

        public HeroXPBar(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateBar(NetCache.HeroLevel.LevelInfo previousLevelInfo, NetCache.HeroLevel.LevelInfo currentLevelInfo)
        {
            object[] objArray1 = new object[] { previousLevelInfo, currentLevelInfo };
            base.method_8("AnimateBar", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EmptyLevelUpFunction()
        {
            base.method_8("EmptyLevelUpFunction", Array.Empty<object>());
        }

        public void OnProgressBarOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnProgressBarOut", objArray1);
        }

        public void OnProgressBarOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnProgressBarOver", objArray1);
        }

        public void SetBarText(string barText)
        {
            object[] objArray1 = new object[] { barText };
            base.method_8("SetBarText", objArray1);
        }

        public void SetBarValue(float barValue)
        {
            object[] objArray1 = new object[] { barValue };
            base.method_8("SetBarValue", objArray1);
        }

        public void ShowTooltip()
        {
            base.method_8("ShowTooltip", Array.Empty<object>());
        }

        public void UpdateDisplay()
        {
            base.method_8("UpdateDisplay", Array.Empty<object>());
        }

        public UberText m_barText
        {
            get
            {
                return base.method_3<UberText>("m_barText");
            }
        }

        public float m_delay
        {
            get
            {
                return base.method_2<float>("m_delay");
            }
        }

        public GameObject m_heroFrame
        {
            get
            {
                return base.method_3<GameObject>("m_heroFrame");
            }
        }

        public NetCache.HeroLevel m_heroLevel
        {
            get
            {
                return base.method_3<NetCache.HeroLevel>("m_heroLevel");
            }
        }

        public UberText m_heroLevelText
        {
            get
            {
                return base.method_3<UberText>("m_heroLevelText");
            }
        }

        public bool m_isAnimated
        {
            get
            {
                return base.method_2<bool>("m_isAnimated");
            }
        }

        public bool m_isOnDeck
        {
            get
            {
                return base.method_2<bool>("m_isOnDeck");
            }
        }

        public ProgressBar m_progressBar
        {
            get
            {
                return base.method_3<ProgressBar>("m_progressBar");
            }
        }

        public string m_rewardText
        {
            get
            {
                return base.method_4("m_rewardText");
            }
        }

        public GameObject m_simpleFrame
        {
            get
            {
                return base.method_3<GameObject>("m_simpleFrame");
            }
        }

        public int m_soloLevelLimit
        {
            get
            {
                return base.method_2<int>("m_soloLevelLimit");
            }
        }
    }
}

