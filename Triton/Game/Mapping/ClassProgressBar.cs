namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ClassProgressBar")]
    public class ClassProgressBar : PegUIElement
    {
        public ClassProgressBar(IntPtr address) : this(address, "ClassProgressBar")
        {
        }

        public ClassProgressBar(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
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

        public void SetNextReward(NetCache.HeroLevel.NextLevelReward nextLevelReward)
        {
            object[] objArray1 = new object[] { nextLevelReward };
            base.method_8("SetNextReward", objArray1);
        }

        public void ShowTooltip()
        {
            base.method_8("ShowTooltip", Array.Empty<object>());
        }

        public TAG_CLASS m_class
        {
            get
            {
                return base.method_2<TAG_CLASS>("m_class");
            }
        }

        public GameObject m_classIcon
        {
            get
            {
                return base.method_3<GameObject>("m_classIcon");
            }
        }

        public GameObject m_classLockedGO
        {
            get
            {
                return base.method_3<GameObject>("m_classLockedGO");
            }
        }

        public UberText m_classNameText
        {
            get
            {
                return base.method_3<UberText>("m_classNameText");
            }
        }

        public UberText m_levelText
        {
            get
            {
                return base.method_3<UberText>("m_levelText");
            }
        }

        public UberText m_lockedText
        {
            get
            {
                return base.method_3<UberText>("m_lockedText");
            }
        }

        public NetCache.HeroLevel.NextLevelReward m_nextLevelReward
        {
            get
            {
                return base.method_3<NetCache.HeroLevel.NextLevelReward>("m_nextLevelReward");
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
    }
}

