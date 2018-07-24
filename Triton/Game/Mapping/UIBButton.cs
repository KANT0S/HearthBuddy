namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIBButton")]
    public class UIBButton : PegUIElement
    {
        public UIBButton(IntPtr address) : this(address, "UIBButton")
        {
        }

        public UIBButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Depress()
        {
            base.method_8("Depress", Array.Empty<object>());
        }

        public void Deselect()
        {
            base.method_8("Deselect", Array.Empty<object>());
        }

        public void Flip(bool faceUp)
        {
            object[] objArray1 = new object[] { faceUp };
            base.method_8("Flip", objArray1);
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public void InitOriginalPosition()
        {
            base.method_8("InitOriginalPosition", Array.Empty<object>());
        }

        public void InitOriginalRotation()
        {
            base.method_8("InitOriginalRotation", Array.Empty<object>());
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

        public void Raise()
        {
            base.method_8("Raise", Array.Empty<object>());
        }

        public void Select()
        {
            base.method_8("Select", Array.Empty<object>());
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public void Wiggle()
        {
            base.method_8("Wiggle", Array.Empty<object>());
        }

        public UberText m_ButtonText
        {
            get
            {
                return base.method_3<UberText>("m_ButtonText");
            }
        }

        public Vector3 m_ClickDownOffset
        {
            get
            {
                return base.method_2<Vector3>("m_ClickDownOffset");
            }
        }

        public bool m_Depressed
        {
            get
            {
                return base.method_2<bool>("m_Depressed");
            }
        }

        public bool m_DepressOnOver
        {
            get
            {
                return base.method_2<bool>("m_DepressOnOver");
            }
        }

        public float m_DepressTime
        {
            get
            {
                return base.method_2<float>("m_DepressTime");
            }
        }

        public Vector3 m_DisabledRotation
        {
            get
            {
                return base.method_2<Vector3>("m_DisabledRotation");
            }
        }

        public float m_RaiseTime
        {
            get
            {
                return base.method_2<float>("m_RaiseTime");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }

        public Vector3 m_WiggleAmount
        {
            get
            {
                return base.method_2<Vector3>("m_WiggleAmount");
            }
        }

        public float m_WiggleTime
        {
            get
            {
                return base.method_2<float>("m_WiggleTime");
            }
        }
    }
}

