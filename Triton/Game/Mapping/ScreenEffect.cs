namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScreenEffect")]
    public class ScreenEffect : MonoBehaviour
    {
        public ScreenEffect(IntPtr address) : this(address, "ScreenEffect")
        {
        }

        public ScreenEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public ScreenEffectsMgr m_ScreenEffectsMgr
        {
            get
            {
                return base.method_3<ScreenEffectsMgr>("m_ScreenEffectsMgr");
            }
        }
    }
}

