namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DisableOnPlatform")]
    public class DisableOnPlatform : MonoBehaviour
    {
        public DisableOnPlatform(IntPtr address) : this(address, "DisableOnPlatform")
        {
        }

        public DisableOnPlatform(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public ScreenCategory m_screenCategory
        {
            get
            {
                return base.method_2<ScreenCategory>("m_screenCategory");
            }
        }
    }
}

