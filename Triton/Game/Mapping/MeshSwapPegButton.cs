namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MeshSwapPegButton")]
    public class MeshSwapPegButton : PegUIElement
    {
        public MeshSwapPegButton(IntPtr address) : this(address, "MeshSwapPegButton")
        {
        }

        public MeshSwapPegButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetButtonID()
        {
            return base.method_11<int>("GetButtonID", Array.Empty<object>());
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

        public void SetButtonID(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetButtonID", objArray1);
        }

        public void SetButtonText(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetButtonText", objArray1);
        }

        public void SetState(PegUIElement.InteractionState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("SetState", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public TextMesh buttonText
        {
            get
            {
                return base.method_3<TextMesh>("buttonText");
            }
        }

        public GameObject disabledState
        {
            get
            {
                return base.method_3<GameObject>("disabledState");
            }
        }

        public Vector3 downOffset
        {
            get
            {
                return base.method_2<Vector3>("downOffset");
            }
        }

        public GameObject downState
        {
            get
            {
                return base.method_3<GameObject>("downState");
            }
        }

        public int m_buttonID
        {
            get
            {
                return base.method_2<int>("m_buttonID");
            }
        }

        public Vector3 originalPosition
        {
            get
            {
                return base.method_2<Vector3>("originalPosition");
            }
        }

        public Vector3 originalScale
        {
            get
            {
                return base.method_2<Vector3>("originalScale");
            }
        }

        public GameObject overState
        {
            get
            {
                return base.method_3<GameObject>("overState");
            }
        }

        public GameObject upState
        {
            get
            {
                return base.method_3<GameObject>("upState");
            }
        }
    }
}

