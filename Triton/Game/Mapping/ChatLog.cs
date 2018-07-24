namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ChatLog")]
    public class ChatLog : MonoBehaviour
    {
        public ChatLog(IntPtr address) : this(address, "ChatLog")
        {
        }

        public ChatLog(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddMyMessage(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("AddMyMessage", objArray1);
        }

        public void AddOfflineMessage()
        {
            base.method_8("AddOfflineMessage", Array.Empty<object>());
        }

        public void AddOnlineMessage()
        {
            base.method_8("AddOnlineMessage", Array.Empty<object>());
        }

        public void AddSystemMessage(string message, Color color)
        {
            object[] objArray1 = new object[] { message, color };
            base.method_8("AddSystemMessage", objArray1);
        }

        public void AssignMessageFrameNames()
        {
            base.method_8("AssignMessageFrameNames", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public MobileChatLogMessageFrame CreateMessage(MobileChatLogMessageFrame prefab, string message)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { prefab, message };
            return base.method_15<MobileChatLogMessageFrame>("CreateMessage", enumArray1, objArray1);
        }

        public MobileChatLogMessageFrame CreateMessage(MobileChatLogMessageFrame prefab, string message, Color color)
        {
            object[] objArray1 = new object[] { prefab, message, color };
            return base.method_15<MobileChatLogMessageFrame>("CreateMessage", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void CreateMessagesCamera()
        {
            base.method_8("CreateMessagesCamera", Array.Empty<object>());
        }

        public Bounds GetBoundsFromGameObject(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<Bounds>("GetBoundsFromGameObject", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnMessagesAdded()
        {
            base.method_8("OnMessagesAdded", Array.Empty<object>());
        }

        public void OnNotified(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("OnNotified", objArray1);
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void OnResize()
        {
            base.method_8("OnResize", Array.Empty<object>());
        }

        public void OnWhisperFailed()
        {
            base.method_8("OnWhisperFailed", Array.Empty<object>());
        }

        public void UpdateMessages()
        {
            base.method_8("UpdateMessages", Array.Empty<object>());
        }

        public void UpdateMessagesCamera()
        {
            base.method_8("UpdateMessagesCamera", Array.Empty<object>());
        }

        public GameObject cameraTarget
        {
            get
            {
                return base.method_3<GameObject>("cameraTarget");
            }
        }

        public static int maxMessageFrames
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ChatLog", "maxMessageFrames");
            }
        }

        public TouchList messageFrames
        {
            get
            {
                return base.method_3<TouchList>("messageFrames");
            }
        }

        public MessageInfo messageInfo
        {
            get
            {
                return base.method_3<MessageInfo>("messageInfo");
            }
        }

        public static GameLayer messageLayer
        {
            get
            {
                return MonoClass.smethod_6<GameLayer>(TritonHs.MainAssemblyPath, "", "ChatLog", "messageLayer");
            }
        }

        public Camera messagesCamera
        {
            get
            {
                return base.method_3<Camera>("messagesCamera");
            }
        }

        public MobileChatNotification notifications
        {
            get
            {
                return base.method_3<MobileChatNotification>("notifications");
            }
        }

        public Prefabs prefabs
        {
            get
            {
                return base.method_3<Prefabs>("prefabs");
            }
        }

        public BnetPlayer receiver
        {
            get
            {
                return base.method_3<BnetPlayer>("receiver");
            }
        }

        public BnetPlayer Receiver
        {
            get
            {
                return base.method_14<BnetPlayer>("get_Receiver", Array.Empty<object>());
            }
        }

        [Attribute38("ChatLog.MessageInfo")]
        public class MessageInfo : MonoClass
        {
            public MessageInfo(IntPtr address) : this(address, "MessageInfo")
            {
            }

            public MessageInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Color errorColor
            {
                get
                {
                    return base.method_2<Color>("errorColor");
                }
            }

            public Color infoColor
            {
                get
                {
                    return base.method_2<Color>("infoColor");
                }
            }

            public Color notificationColor
            {
                get
                {
                    return base.method_2<Color>("notificationColor");
                }
            }
        }

        [Attribute38("ChatLog.Prefabs")]
        public class Prefabs : MonoClass
        {
            public Prefabs(IntPtr address) : this(address, "Prefabs")
            {
            }

            public Prefabs(IntPtr address, string className) : base(address, className)
            {
            }

            public MobileChatLogMessageFrame myMessage
            {
                get
                {
                    return base.method_3<MobileChatLogMessageFrame>("myMessage");
                }
            }

            public MobileChatLogMessageFrame systemMessage
            {
                get
                {
                    return base.method_3<MobileChatLogMessageFrame>("systemMessage");
                }
            }

            public MobileChatLogMessageFrame theirMessage
            {
                get
                {
                    return base.method_3<MobileChatLogMessageFrame>("theirMessage");
                }
            }
        }
    }
}

