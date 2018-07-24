namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BnetBarMenuButton")]
    public class BnetBarMenuButton : PegUIElement
    {
        public BnetBarMenuButton(IntPtr address) : this(address, "BnetBarMenuButton")
        {
        }

        public BnetBarMenuButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool IsSelected()
        {
            return base.method_11<bool>("IsSelected", Array.Empty<object>());
        }

        public void LockHighlight(bool isLocked)
        {
            object[] objArray1 = new object[] { isLocked };
            base.method_8("LockHighlight", objArray1);
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

        public void OnStatusBarUpdate()
        {
            base.method_8("OnStatusBarUpdate", Array.Empty<object>());
        }

        public void SetPhoneStatusBarState(int nElements)
        {
            object[] objArray1 = new object[] { nElements };
            base.method_8("SetPhoneStatusBarState", objArray1);
        }

        public void SetSelected(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetSelected", objArray1);
        }

        public bool ShouldBeHighlighted()
        {
            return base.method_11<bool>("ShouldBeHighlighted", Array.Empty<object>());
        }

        public void UpdateHighlight()
        {
            base.method_8("UpdateHighlight", Array.Empty<object>());
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }

        public GameObject m_phoneBar
        {
            get
            {
                return base.method_3<GameObject>("m_phoneBar");
            }
        }

        public Transform m_phoneBarOneElementBone
        {
            get
            {
                return base.method_3<Transform>("m_phoneBarOneElementBone");
            }
        }

        public int m_phoneBarStatus
        {
            get
            {
                return base.method_2<int>("m_phoneBarStatus");
            }
        }

        public Transform m_phoneBarTwoElementBone
        {
            get
            {
                return base.method_3<Transform>("m_phoneBarTwoElementBone");
            }
        }

        public bool m_selected
        {
            get
            {
                return base.method_2<bool>("m_selected");
            }
        }
    }
}

