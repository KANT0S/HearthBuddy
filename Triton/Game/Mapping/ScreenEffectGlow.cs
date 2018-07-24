namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScreenEffectGlow")]
    public class ScreenEffectGlow : ScreenEffect
    {
        public ScreenEffectGlow(IntPtr address) : this(address, "ScreenEffectGlow")
        {
        }

        public ScreenEffectGlow(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void SetLayer()
        {
            base.method_8("SetLayer", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public int m_PreviousLayer
        {
            get
            {
                return base.method_2<int>("m_PreviousLayer");
            }
        }

        public bool m_PreviousRenderGlowOnly
        {
            get
            {
                return base.method_2<bool>("m_PreviousRenderGlowOnly");
            }
        }

        public bool m_RenderGlowOnly
        {
            get
            {
                return base.method_2<bool>("m_RenderGlowOnly");
            }
        }
    }
}

