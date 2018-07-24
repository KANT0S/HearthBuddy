namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BackButton")]
    public class BackButton : PegUIElement
    {
        public BackButton(IntPtr address) : this(address, "BackButton")
        {
        }

        public BackButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public UberText m_backText
        {
            get
            {
                return base.method_3<UberText>("m_backText");
            }
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }
    }
}

