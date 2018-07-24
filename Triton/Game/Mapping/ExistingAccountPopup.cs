namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ExistingAccountPopup")]
    public class ExistingAccountPopup : DialogBase
    {
        public ExistingAccountPopup(IntPtr address) : this(address, "ExistingAccountPopup")
        {
        }

        public ExistingAccountPopup(IntPtr address, string className) : base(address, className)
        {
        }

        public void DownScale()
        {
            base.method_8("DownScale", Array.Empty<object>());
        }

        public void FadeBubble()
        {
            base.method_8("FadeBubble", Array.Empty<object>());
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public void HaveAccountButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("HaveAccountButtonPress", objArray1);
        }

        public void HaveAccountButtonRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("HaveAccountButtonRelease", objArray1);
        }

        public void NoAccountButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("NoAccountButtonPress", objArray1);
        }

        public void NoAccountButtonRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("NoAccountButtonRelease", objArray1);
        }

        public void OnHideAnimFinished()
        {
            base.method_8("OnHideAnimFinished", Array.Empty<object>());
        }

        public void ScaleAway()
        {
            base.method_8("ScaleAway", Array.Empty<object>());
        }

        public void SetInfo(Info info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowBubble()
        {
            base.method_8("ShowBubble", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_bubble
        {
            get
            {
                return base.method_3<GameObject>("m_bubble");
            }
        }

        public Vector3 m_buttonOffset
        {
            get
            {
                return base.method_2<Vector3>("m_buttonOffset");
            }
        }

        public bool m_haveAccount
        {
            get
            {
                return base.method_2<bool>("m_haveAccount");
            }
        }

        public PegUIElement m_haveAccountButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_haveAccountButton");
            }
        }

        public PegUIElement m_noAccountButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_noAccountButton");
            }
        }

        public ExistingAccoundSound m_sound
        {
            get
            {
                return base.method_3<ExistingAccoundSound>("m_sound");
            }
        }

        [Attribute38("ExistingAccountPopup.Info")]
        public class Info : MonoClass
        {
            public Info(IntPtr address) : this(address, "Info")
            {
            }

            public Info(IntPtr address, string className) : base(address, className)
            {
            }
        }
    }
}

