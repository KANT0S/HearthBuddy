namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RewardBanner")]
    public class RewardBanner : MonoBehaviour
    {
        public RewardBanner(IntPtr address) : this(address, "RewardBanner")
        {
        }

        public RewardBanner(IntPtr address, string className) : base(address, className)
        {
        }

        public void AlignHeadlineToCenterBone()
        {
            base.method_8("AlignHeadlineToCenterBone", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void SetText(string headline, string details, string source)
        {
            object[] objArray1 = new object[] { headline, details, source };
            base.method_8("SetText", objArray1);
        }

        public string DetailsText
        {
            get
            {
                return base.method_13("get_DetailsText", Array.Empty<object>());
            }
        }

        public string HeadlineText
        {
            get
            {
                return base.method_13("get_HeadlineText", Array.Empty<object>());
            }
        }

        public UberText m_detailsText
        {
            get
            {
                return base.method_3<UberText>("m_detailsText");
            }
        }

        public GameObject m_headlineCenterBone
        {
            get
            {
                return base.method_3<GameObject>("m_headlineCenterBone");
            }
        }

        public float m_headlineHeight
        {
            get
            {
                return base.method_2<float>("m_headlineHeight");
            }
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public UberText m_sourceText
        {
            get
            {
                return base.method_3<UberText>("m_sourceText");
            }
        }

        public string SourceText
        {
            get
            {
                return base.method_13("get_SourceText", Array.Empty<object>());
            }
        }
    }
}

