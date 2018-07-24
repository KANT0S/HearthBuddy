namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIBHighlightStateControl")]
    public class UIBHighlightStateControl : MonoBehaviour
    {
        public UIBHighlightStateControl(IntPtr address) : this(address, "UIBHighlightStateControl")
        {
        }

        public UIBHighlightStateControl(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void OnRollOut()
        {
            base.method_8("OnRollOut", Array.Empty<object>());
        }

        public void OnRollOver()
        {
            base.method_8("OnRollOver", Array.Empty<object>());
        }

        public void Select(bool selected, bool primary)
        {
            object[] objArray1 = new object[] { selected, primary };
            base.method_8("Select", objArray1);
        }

        public bool m_AllowSelection
        {
            get
            {
                return base.method_2<bool>("m_AllowSelection");
            }
        }

        public bool m_EnableResponse
        {
            get
            {
                return base.method_2<bool>("m_EnableResponse");
            }
        }

        public HighlightState m_HighlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_HighlightState");
            }
        }

        public bool m_MouseOver
        {
            get
            {
                return base.method_2<bool>("m_MouseOver");
            }
        }

        public ActorStateType m_MouseOverStateType
        {
            get
            {
                return base.method_2<ActorStateType>("m_MouseOverStateType");
            }
        }

        public PegUIElement m_PegUIElement
        {
            get
            {
                return base.method_3<PegUIElement>("m_PegUIElement");
            }
        }

        public ActorStateType m_PrimarySelectedStateType
        {
            get
            {
                return base.method_2<ActorStateType>("m_PrimarySelectedStateType");
            }
        }

        public ActorStateType m_SecondarySelectedStateType
        {
            get
            {
                return base.method_2<ActorStateType>("m_SecondarySelectedStateType");
            }
        }

        public bool m_UseMouseOver
        {
            get
            {
                return base.method_2<bool>("m_UseMouseOver");
            }
        }
    }
}

