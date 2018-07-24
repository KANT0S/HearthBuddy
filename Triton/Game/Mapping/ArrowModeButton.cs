namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArrowModeButton")]
    public class ArrowModeButton : PegUIElement
    {
        public ArrowModeButton(IntPtr address) : this(address, "ArrowModeButton")
        {
        }

        public ArrowModeButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Activate(bool activate)
        {
            object[] objArray1 = new object[] { activate };
            base.method_8("Activate", objArray1);
        }

        public void ActivateHighlight(bool highlightOn)
        {
            object[] objArray1 = new object[] { highlightOn };
            base.method_8("ActivateHighlight", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Flip()
        {
            base.method_8("Flip", Array.Empty<object>());
        }

        public void OnFlipComplete()
        {
            base.method_8("OnFlipComplete", Array.Empty<object>());
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

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public bool m_isHighlighted
        {
            get
            {
                return base.method_2<bool>("m_isHighlighted");
            }
        }

        public int m_numFlips
        {
            get
            {
                return base.method_2<int>("m_numFlips");
            }
        }
    }
}

