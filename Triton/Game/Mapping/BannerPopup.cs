namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BannerPopup")]
    public class BannerPopup : MonoBehaviour
    {
        public BannerPopup(IntPtr address) : this(address, "BannerPopup")
        {
        }

        public BannerPopup(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CloseBannerPopup(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("CloseBannerPopup", objArray1);
        }

        public void DestroyAdventurePopup()
        {
            base.method_8("DestroyAdventurePopup", Array.Empty<object>());
        }

        public void EnableClickHandler()
        {
            base.method_8("EnableClickHandler", Array.Empty<object>());
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public void OnLoopingSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnLoopingSpellFinished", objArray1);
        }

        public void OnShowSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnShowSpellFinished", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Spell m_HideSpell
        {
            get
            {
                return base.method_3<Spell>("m_HideSpell");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public Spell m_LoopingSpell
        {
            get
            {
                return base.method_3<Spell>("m_LoopingSpell");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public Spell m_ShowSpell
        {
            get
            {
                return base.method_3<Spell>("m_ShowSpell");
            }
        }

        public bool m_showSpellComplete
        {
            get
            {
                return base.method_2<bool>("m_showSpellComplete");
            }
        }

        public UberText m_text
        {
            get
            {
                return base.method_3<UberText>("m_text");
            }
        }
    }
}

