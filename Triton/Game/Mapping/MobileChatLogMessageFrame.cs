namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MobileChatLogMessageFrame")]
    public class MobileChatLogMessageFrame : MonoBehaviour
    {
        public MobileChatLogMessageFrame(IntPtr address) : this(address, "MobileChatLogMessageFrame")
        {
        }

        public MobileChatLogMessageFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void UpdateLocalBounds()
        {
            base.method_8("UpdateLocalBounds", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Color Color
        {
            get
            {
                return base.method_11<Triton.Game.Mapping.Color>("get_Color", Array.Empty<object>());
            }
        }

        public bool IsHeader
        {
            get
            {
                return base.method_11<bool>("get_IsHeader", Array.Empty<object>());
            }
        }

        public Bounds localBounds
        {
            get
            {
                return base.method_2<Bounds>("localBounds");
            }
        }

        public Bounds LocalBounds
        {
            get
            {
                return base.method_11<Bounds>("get_LocalBounds", Array.Empty<object>());
            }
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public string Message
        {
            get
            {
                return base.method_13("get_Message", Array.Empty<object>());
            }
        }

        public UberText text
        {
            get
            {
                return base.method_3<UberText>("text");
            }
        }

        public bool Visible
        {
            get
            {
                return base.method_11<bool>("get_Visible", Array.Empty<object>());
            }
        }

        public float Width
        {
            get
            {
                return base.method_11<float>("get_Width", Array.Empty<object>());
            }
        }
    }
}

