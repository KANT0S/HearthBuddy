namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardBackInfoManager")]
    public class CardBackInfoManager : MonoBehaviour
    {
        public CardBackInfoManager(IntPtr address) : this(address, "CardBackInfoManager")
        {
        }

        public CardBackInfoManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelPreview()
        {
            base.method_8("CancelPreview", Array.Empty<object>());
        }

        public void EnterPreview(CollectionCardVisual cardVisual)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { cardVisual };
            base.method_9("EnterPreview", enumArray1, objArray1);
        }

        public void EnterPreview(int cardBackIdx, CollectionCardVisual cardVisual)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.Class };
            object[] objArray1 = new object[] { cardBackIdx, cardVisual };
            base.method_9("EnterPreview", enumArray1, objArray1);
        }

        public static CardBackInfoManager Get()
        {
            return MonoClass.smethod_15<CardBackInfoManager>(TritonHs.MainAssemblyPath, "", "CardBackInfoManager", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetFavorite()
        {
            base.method_8("SetFavorite", Array.Empty<object>());
        }

        public void SetupUI()
        {
            base.method_8("SetupUI", Array.Empty<object>());
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public float m_animationTime
        {
            get
            {
                return base.method_2<float>("m_animationTime");
            }
        }

        public GameObject m_cardBackContainer
        {
            get
            {
                return base.method_3<GameObject>("m_cardBackContainer");
            }
        }

        public GameObject m_currentCardBack
        {
            get
            {
                return base.method_3<GameObject>("m_currentCardBack");
            }
        }

        public int m_currentCardBackIdx
        {
            get
            {
                return base.method_2<int>("m_currentCardBackIdx");
            }
        }

        public UberText m_description
        {
            get
            {
                return base.method_3<UberText>("m_description");
            }
        }

        public string m_enterPreviewSound
        {
            get
            {
                return base.method_4("m_enterPreviewSound");
            }
        }

        public string m_exitPreviewSound
        {
            get
            {
                return base.method_4("m_exitPreviewSound");
            }
        }

        public UIBButton m_favoriteButton
        {
            get
            {
                return base.method_3<UIBButton>("m_favoriteButton");
            }
        }

        public PegUIElement m_offClicker
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClicker");
            }
        }

        public GameObject m_previewPane
        {
            get
            {
                return base.method_3<GameObject>("m_previewPane");
            }
        }

        public UberText m_title
        {
            get
            {
                return base.method_3<UberText>("m_title");
            }
        }
    }
}

