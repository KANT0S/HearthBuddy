namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ChatLogFrame")]
    public class ChatLogFrame : MonoBehaviour
    {
        public ChatLogFrame(IntPtr address) : this(address, "ChatLogFrame")
        {
        }

        public ChatLogFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void InitPlayerIcon()
        {
            base.method_8("InitPlayerIcon", Array.Empty<object>());
        }

        public void OnChallengeButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnChallengeButtonReleased", objArray1);
        }

        public void OnResize()
        {
            base.method_8("OnResize", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateReceiver()
        {
            base.method_8("UpdateReceiver", Array.Empty<object>());
        }

        public ChatLogFrameBones m_Bones
        {
            get
            {
                return base.method_3<ChatLogFrameBones>("m_Bones");
            }
        }

        public ChatLog m_chatLog
        {
            get
            {
                return base.method_3<ChatLog>("m_chatLog");
            }
        }

        public UberText m_NameText
        {
            get
            {
                return base.method_3<UberText>("m_NameText");
            }
        }

        public PlayerIcon m_playerIcon
        {
            get
            {
                return base.method_3<PlayerIcon>("m_playerIcon");
            }
        }

        public ChatLogFramePrefabs m_Prefabs
        {
            get
            {
                return base.method_3<ChatLogFramePrefabs>("m_Prefabs");
            }
        }

        public BnetPlayer m_receiver
        {
            get
            {
                return base.method_3<BnetPlayer>("m_receiver");
            }
        }

        public BnetPlayer Receiver
        {
            get
            {
                return base.method_14<BnetPlayer>("get_Receiver", Array.Empty<object>());
            }
        }
    }
}

