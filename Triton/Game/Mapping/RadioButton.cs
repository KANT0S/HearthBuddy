namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RadioButton")]
    public class RadioButton : PegUIElement
    {
        public RadioButton(IntPtr address) : this(address, "RadioButton")
        {
        }

        public RadioButton(IntPtr address, string className) : base(address, className)
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

        public object GetUserData()
        {
            return base.method_14<object>("GetUserData", Array.Empty<object>());
        }

        public bool IsSelected()
        {
            return base.method_11<bool>("IsSelected", Array.Empty<object>());
        }

        public void OnDoubleClick()
        {
            base.method_8("OnDoubleClick", Array.Empty<object>());
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

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void SetButtonID(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetButtonID", objArray1);
        }

        public void SetSelected(bool selected)
        {
            object[] objArray1 = new object[] { selected };
            base.method_8("SetSelected", objArray1);
        }

        public void SetUserData(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("SetUserData", objArray1);
        }

        public GameObject m_hoverGlow
        {
            get
            {
                return base.method_3<GameObject>("m_hoverGlow");
            }
        }

        public int m_id
        {
            get
            {
                return base.method_2<int>("m_id");
            }
        }

        public GameObject m_selectedGlow
        {
            get
            {
                return base.method_3<GameObject>("m_selectedGlow");
            }
        }

        public object m_userData
        {
            get
            {
                return base.method_3<object>("m_userData");
            }
        }
    }
}

