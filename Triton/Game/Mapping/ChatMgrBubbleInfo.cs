namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ChatMgrBubbleInfo")]
    public class ChatMgrBubbleInfo : MonoClass
    {
        public ChatMgrBubbleInfo(IntPtr address) : this(address, "ChatMgrBubbleInfo")
        {
        }

        public ChatMgrBubbleInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public iTween.EaseType m_FadeOutEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_FadeOutEaseType");
            }
        }

        public float m_FadeOutSec
        {
            get
            {
                return base.method_2<float>("m_FadeOutSec");
            }
        }

        public float m_HoldSec
        {
            get
            {
                return base.method_2<float>("m_HoldSec");
            }
        }

        public iTween.EaseType m_MoveOverEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_MoveOverEaseType");
            }
        }

        public float m_MoveOverSec
        {
            get
            {
                return base.method_2<float>("m_MoveOverSec");
            }
        }

        public Transform m_Parent
        {
            get
            {
                return base.method_3<Transform>("m_Parent");
            }
        }

        public iTween.EaseType m_ScaleInEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ScaleInEaseType");
            }
        }

        public float m_ScaleInSec
        {
            get
            {
                return base.method_2<float>("m_ScaleInSec");
            }
        }
    }
}

