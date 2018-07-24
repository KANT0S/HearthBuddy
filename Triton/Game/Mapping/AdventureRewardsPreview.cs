namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureRewardsPreview")]
    public class AdventureRewardsPreview : MonoBehaviour
    {
        public AdventureRewardsPreview(IntPtr address) : this(address, "AdventureRewardsPreview")
        {
        }

        public AdventureRewardsPreview(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCardBatch(int scenarioId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { scenarioId };
            base.method_9("AddCardBatch", enumArray1, objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FireHideEvent()
        {
            base.method_8("FireHideEvent", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void SetHeaderText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetHeaderText", objArray1);
        }

        public void SetHiddenCardCount(int hiddenCardCount)
        {
            object[] objArray1 = new object[] { hiddenCardCount };
            base.method_8("SetHiddenCardCount", objArray1);
        }

        public void Show(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("Show", objArray1);
        }

        public void UpdateCardPositions()
        {
            base.method_8("UpdateCardPositions", Array.Empty<object>());
        }

        public float CardClumpAngleIncrement
        {
            get
            {
                return base.method_11<float>("get_CardClumpAngleIncrement", Array.Empty<object>());
            }
        }

        public Vector3 CardClumpSpacing
        {
            get
            {
                return base.method_11<Vector3>("get_CardClumpSpacing", Array.Empty<object>());
            }
        }

        public float CardSpacing
        {
            get
            {
                return base.method_11<float>("get_CardSpacing", Array.Empty<object>());
            }
        }

        public float CardWidth
        {
            get
            {
                return base.method_11<float>("get_CardWidth", Array.Empty<object>());
            }
        }

        public PegUIElement m_BackButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_BackButton");
            }
        }

        public float m_CardClumpAngleIncrement
        {
            get
            {
                return base.method_2<float>("m_CardClumpAngleIncrement");
            }
        }

        public Vector3 m_CardClumpSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_CardClumpSpacing");
            }
        }

        public GameObject m_CardsContainer
        {
            get
            {
                return base.method_3<GameObject>("m_CardsContainer");
            }
        }

        public float m_CardSpacing
        {
            get
            {
                return base.method_2<float>("m_CardSpacing");
            }
        }

        public AdventureRewardsDisplayArea m_CardsPreviewDisplay
        {
            get
            {
                return base.method_3<AdventureRewardsDisplayArea>("m_CardsPreviewDisplay");
            }
        }

        public float m_CardWidth
        {
            get
            {
                return base.method_2<float>("m_CardWidth");
            }
        }

        public GameObject m_ClickBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_ClickBlocker");
            }
        }

        public UIBScrollable m_DisableScrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_DisableScrollbar");
            }
        }

        public UberText m_HeaderTextObject
        {
            get
            {
                return base.method_3<UberText>("m_HeaderTextObject");
            }
        }

        public int m_HiddenCardCount
        {
            get
            {
                return base.method_2<int>("m_HiddenCardCount");
            }
        }

        public UberText m_HiddenCardsLabel
        {
            get
            {
                return base.method_3<UberText>("m_HiddenCardsLabel");
            }
        }

        public GameObject m_HiddenCardsLabelObject
        {
            get
            {
                return base.method_3<GameObject>("m_HiddenCardsLabelObject");
            }
        }

        public string m_PreviewAppearSound
        {
            get
            {
                return base.method_4("m_PreviewAppearSound");
            }
        }

        public bool m_PreviewCardsExpandable
        {
            get
            {
                return base.method_2<bool>("m_PreviewCardsExpandable");
            }
        }

        public string m_PreviewShrinkSound
        {
            get
            {
                return base.method_4("m_PreviewShrinkSound");
            }
        }

        public float m_ShowHideAnimationTime
        {
            get
            {
                return base.method_2<float>("m_ShowHideAnimationTime");
            }
        }
    }
}

