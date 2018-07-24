namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BeveledButton")]
    public class BeveledButton : PegUIElement
    {
        public BeveledButton(IntPtr address) : this(address, "BeveledButton")
        {
        }

        public BeveledButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText GetUberText()
        {
            return base.method_14<UberText>("GetUberText", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
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

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }

        public TextMesh m_label
        {
            get
            {
                return base.method_3<TextMesh>("m_label");
            }
        }

        public UberText m_uberLabel
        {
            get
            {
                return base.method_3<UberText>("m_uberLabel");
            }
        }
    }
}

