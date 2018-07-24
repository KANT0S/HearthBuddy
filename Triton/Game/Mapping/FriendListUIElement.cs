namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListUIElement")]
    public class FriendListUIElement : PegUIElement
    {
        public FriendListUIElement(IntPtr address) : this(address, "FriendListUIElement")
        {
        }

        public FriendListUIElement(IntPtr address, string className) : base(address, className)
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

        public void SetSelected(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetSelected", objArray1);
        }

        public bool ShouldBeHighlighted()
        {
            return base.method_11<bool>("ShouldBeHighlighted", Array.Empty<object>());
        }

        public bool ShouldChildBeHighlighted()
        {
            return base.method_11<bool>("ShouldChildBeHighlighted", Array.Empty<object>());
        }

        public void UpdateHighlight()
        {
            base.method_8("UpdateHighlight", Array.Empty<object>());
        }

        public void UpdateSelfHighlight(bool shouldHighlight)
        {
            object[] objArray1 = new object[] { shouldHighlight };
            base.method_8("UpdateSelfHighlight", objArray1);
        }

        public GameObject m_Highlight
        {
            get
            {
                return base.method_3<GameObject>("m_Highlight");
            }
        }

        public FriendListUIElement m_ParentElement
        {
            get
            {
                return base.method_3<FriendListUIElement>("m_ParentElement");
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

