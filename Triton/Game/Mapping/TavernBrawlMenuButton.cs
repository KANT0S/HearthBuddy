namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TavernBrawlMenuButton")]
    public class TavernBrawlMenuButton : BoxMenuButton
    {
        public TavernBrawlMenuButton(IntPtr address) : this(address, "TavernBrawlMenuButton")
        {
        }

        public TavernBrawlMenuButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void ClearHighlightAndTooltip()
        {
            base.method_8("ClearHighlightAndTooltip", Array.Empty<object>());
        }

        public void TriggerOut()
        {
            base.method_8("TriggerOut", Array.Empty<object>());
        }

        public void TriggerOver()
        {
            base.method_8("TriggerOver", Array.Empty<object>());
        }

        public void TriggerPress()
        {
            base.method_8("TriggerPress", Array.Empty<object>());
        }

        public void TriggerRelease()
        {
            base.method_8("TriggerRelease", Array.Empty<object>());
        }

        public void UpdateTimeText()
        {
            base.method_8("UpdateTimeText", Array.Empty<object>());
        }

        public bool isPoppedUp
        {
            get
            {
                return base.method_2<bool>("isPoppedUp");
            }
        }

        public float m_hoverDelay
        {
            get
            {
                return base.method_2<float>("m_hoverDelay");
            }
        }

        public UberText m_returnsInfo
        {
            get
            {
                return base.method_3<UberText>("m_returnsInfo");
            }
        }
    }
}

