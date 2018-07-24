namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ChatLogMessageFrame")]
    public class ChatLogMessageFrame : MonoBehaviour
    {
        public ChatLogMessageFrame(IntPtr address) : this(address, "ChatLogMessageFrame")
        {
        }

        public ChatLogMessageFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Color GetColor()
        {
            return base.method_11<Color>("GetColor", Array.Empty<object>());
        }

        public string GetMessage()
        {
            return base.method_13("GetMessage", Array.Empty<object>());
        }

        public void SetColor(Color color)
        {
            object[] objArray1 = new object[] { color };
            base.method_8("SetColor", objArray1);
        }

        public void SetMessage(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("SetMessage", objArray1);
        }

        public void UpdateBackground()
        {
            base.method_8("UpdateBackground", Array.Empty<object>());
        }

        public void UpdateText()
        {
            base.method_8("UpdateText", Array.Empty<object>());
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public float m_initialBackgroundHeight
        {
            get
            {
                return base.method_2<float>("m_initialBackgroundHeight");
            }
        }

        public float m_initialBackgroundLocalScaleY
        {
            get
            {
                return base.method_2<float>("m_initialBackgroundLocalScaleY");
            }
        }

        public float m_initialPadding
        {
            get
            {
                return base.method_2<float>("m_initialPadding");
            }
        }

        public UberText m_Text
        {
            get
            {
                return base.method_3<UberText>("m_Text");
            }
        }
    }
}

