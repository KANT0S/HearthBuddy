namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NormalButton")]
    public class NormalButton : PegUIElement
    {
        public NormalButton(IntPtr address) : this(address, "NormalButton")
        {
        }

        public NormalButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float GetBottom()
        {
            return base.method_11<float>("GetBottom", Array.Empty<object>());
        }

        public int GetButtonID()
        {
            return base.method_11<int>("GetButtonID", Array.Empty<object>());
        }

        public GameObject GetButtonTextGO()
        {
            return base.method_14<GameObject>("GetButtonTextGO", Array.Empty<object>());
        }

        public UberText GetButtonUberText()
        {
            return base.method_14<UberText>("GetButtonUberText", Array.Empty<object>());
        }

        public float GetLeft()
        {
            return base.method_11<float>("GetLeft", Array.Empty<object>());
        }

        public float GetRight()
        {
            return base.method_11<float>("GetRight", Array.Empty<object>());
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public float GetTextHeight()
        {
            return base.method_11<float>("GetTextHeight", Array.Empty<object>());
        }

        public float GetTextWidth()
        {
            return base.method_11<float>("GetTextWidth", Array.Empty<object>());
        }

        public float GetTop()
        {
            return base.method_11<float>("GetTop", Array.Empty<object>());
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

        public void SetButtonID(int newID)
        {
            object[] objArray1 = new object[] { newID };
            base.method_8("SetButtonID", objArray1);
        }

        public void SetOriginalButtonPosition()
        {
            base.method_8("SetOriginalButtonPosition", Array.Empty<object>());
        }

        public void SetText(string t)
        {
            object[] objArray1 = new object[] { t };
            base.method_8("SetText", objArray1);
        }

        public void SetUserOverYOffset(float userOverYOffset)
        {
            object[] objArray1 = new object[] { userOverYOffset };
            base.method_8("SetUserOverYOffset", objArray1);
        }

        public int buttonID
        {
            get
            {
                return base.method_2<int>("buttonID");
            }
        }

        public GameObject m_button
        {
            get
            {
                return base.method_3<GameObject>("m_button");
            }
        }

        public TextMesh m_buttonText
        {
            get
            {
                return base.method_3<TextMesh>("m_buttonText");
            }
        }

        public UberText m_buttonUberText
        {
            get
            {
                return base.method_3<UberText>("m_buttonUberText");
            }
        }

        public GameObject m_mouseOverBone
        {
            get
            {
                return base.method_3<GameObject>("m_mouseOverBone");
            }
        }

        public Vector3 m_originalButtonPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalButtonPosition");
            }
        }

        public float m_userOverYOffset
        {
            get
            {
                return base.method_2<float>("m_userOverYOffset");
            }
        }
    }
}

