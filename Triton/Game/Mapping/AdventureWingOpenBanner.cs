namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureWingOpenBanner")]
    public class AdventureWingOpenBanner : MonoBehaviour
    {
        public AdventureWingOpenBanner(IntPtr address) : this(address, "AdventureWingOpenBanner")
        {
        }

        public AdventureWingOpenBanner(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HideBanner()
        {
            base.method_8("HideBanner", Array.Empty<object>());
        }

        public PegUIElement m_clickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_clickCatcher");
            }
        }

        public string m_hideSound
        {
            get
            {
                return base.method_4("m_hideSound");
            }
        }

        public float m_hideTime
        {
            get
            {
                return base.method_2<float>("m_hideTime");
            }
        }

        public Vector3 m_originalScale
        {
            get
            {
                return base.method_2<Vector3>("m_originalScale");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public iTween.EaseType m_showEase
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_showEase");
            }
        }

        public string m_showSound
        {
            get
            {
                return base.method_4("m_showSound");
            }
        }

        public float m_showTime
        {
            get
            {
                return base.method_2<float>("m_showTime");
            }
        }

        public string m_VOQuoteLine
        {
            get
            {
                return base.method_4("m_VOQuoteLine");
            }
        }

        public Vector3 m_VOQuotePosition
        {
            get
            {
                return base.method_2<Vector3>("m_VOQuotePosition");
            }
        }

        public string m_VOQuotePrefab
        {
            get
            {
                return base.method_4("m_VOQuotePrefab");
            }
        }
    }
}

