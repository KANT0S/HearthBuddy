namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SeasonTimeRemainingToast")]
    public class SeasonTimeRemainingToast : GameToast
    {
        public SeasonTimeRemainingToast(IntPtr address) : this(address, "SeasonTimeRemainingToast")
        {
        }

        public SeasonTimeRemainingToast(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void UpdateDisplay(string title, string timeRemaining)
        {
            object[] objArray1 = new object[] { title, timeRemaining };
            base.method_8("UpdateDisplay", objArray1);
        }

        public GameObject m_background
        {
            get
            {
                return base.method_3<GameObject>("m_background");
            }
        }

        public UberText m_seasonTitle
        {
            get
            {
                return base.method_3<UberText>("m_seasonTitle");
            }
        }

        public UberText m_timeRemaining
        {
            get
            {
                return base.method_3<UberText>("m_timeRemaining");
            }
        }
    }
}

