namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ChatBubbleFrame")]
    public class ChatBubbleFrame : MonoBehaviour
    {
        public ChatBubbleFrame(IntPtr address) : this(address, "ChatBubbleFrame")
        {
        }

        public ChatBubbleFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool DoesMessageFit()
        {
            return base.method_11<bool>("DoesMessageFit", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void UpdateWhisper()
        {
            base.method_8("UpdateWhisper", Array.Empty<object>());
        }

        public UberText m_MessageText
        {
            get
            {
                return base.method_3<UberText>("m_MessageText");
            }
        }

        public GameObject m_MyDecoration
        {
            get
            {
                return base.method_3<GameObject>("m_MyDecoration");
            }
        }

        public UberText m_NameText
        {
            get
            {
                return base.method_3<UberText>("m_NameText");
            }
        }

        public GameObject m_TheirDecoration
        {
            get
            {
                return base.method_3<GameObject>("m_TheirDecoration");
            }
        }

        public GameObject m_VisualRoot
        {
            get
            {
                return base.method_3<GameObject>("m_VisualRoot");
            }
        }
    }
}

