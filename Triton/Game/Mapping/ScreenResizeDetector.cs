namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScreenResizeDetector")]
    public class ScreenResizeDetector : MonoBehaviour
    {
        public ScreenResizeDetector(IntPtr address) : this(address, "ScreenResizeDetector")
        {
        }

        public ScreenResizeDetector(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FireSizeChangedEvent()
        {
            base.method_8("FireSizeChangedEvent", Array.Empty<object>());
        }

        public void OnPreCull()
        {
            base.method_8("OnPreCull", Array.Empty<object>());
        }

        public void SaveScreenSize()
        {
            base.method_8("SaveScreenSize", Array.Empty<object>());
        }

        public float m_screenHeight
        {
            get
            {
                return base.method_2<float>("m_screenHeight");
            }
        }

        public float m_screenWidth
        {
            get
            {
                return base.method_2<float>("m_screenWidth");
            }
        }
    }
}

