namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MobileChatLogFrame")]
    public class MobileChatLogFrame : MonoBehaviour
    {
        public MobileChatLogFrame(IntPtr address) : this(address, "MobileChatLogFrame")
        {
        }

        public MobileChatLogFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Focus(bool focus)
        {
            object[] objArray1 = new object[] { focus };
            base.method_8("Focus", objArray1);
        }

        public bool IsFullScreenKeyboard()
        {
            return base.method_11<bool>("IsFullScreenKeyboard", Array.Empty<object>());
        }

        public void OnCloseButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCloseButtonReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnInputCanceled()
        {
            base.method_8("OnInputCanceled", Array.Empty<object>());
        }

        public void OnInputComplete(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputComplete", objArray1);
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void SetWorldRect(float x, float y, float width, float height)
        {
            object[] objArray1 = new object[] { x, y, width, height };
            base.method_8("SetWorldRect", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateBackgroundCollider()
        {
            base.method_8("UpdateBackgroundCollider", Array.Empty<object>());
        }

        public void UpdateFollowers()
        {
            base.method_8("UpdateFollowers", Array.Empty<object>());
        }

        public void UpdateReceiver()
        {
            base.method_8("UpdateReceiver", Array.Empty<object>());
        }

        public ChatLog chatLog
        {
            get
            {
                return base.method_3<ChatLog>("chatLog");
            }
        }

        public UIBButton closeButton
        {
            get
            {
                return base.method_3<UIBButton>("closeButton");
            }
        }

        public Followers followers
        {
            get
            {
                return base.method_3<Followers>("followers");
            }
        }

        public bool HasFocus
        {
            get
            {
                return base.method_11<bool>("get_HasFocus", Array.Empty<object>());
            }
        }

        public InputInfo inputInfo
        {
            get
            {
                return base.method_3<InputInfo>("inputInfo");
            }
        }

        public TextField inputTextField
        {
            get
            {
                return base.method_3<TextField>("inputTextField");
            }
        }

        public TournamentMedal medal
        {
            get
            {
                return base.method_3<TournamentMedal>("medal");
            }
        }

        public GameObject medalPatch
        {
            get
            {
                return base.method_3<GameObject>("medalPatch");
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

        public UberText nameText
        {
            get
            {
                return base.method_3<UberText>("nameText");
            }
        }

        public MobileChatNotification notifications
        {
            get
            {
                return base.method_3<MobileChatNotification>("notifications");
            }
        }

        public PlayerIcon playerIcon
        {
            get
            {
                return base.method_3<PlayerIcon>("playerIcon");
            }
        }

        public Spawner playerIconRef
        {
            get
            {
                return base.method_3<Spawner>("playerIconRef");
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

        public NineSliceElement window
        {
            get
            {
                return base.method_3<NineSliceElement>("window");
            }
        }

        [Attribute38("MobileChatLogFrame.Followers")]
        public class Followers : MonoClass
        {
            public Followers(IntPtr address) : this(address, "Followers")
            {
            }

            public Followers(IntPtr address, string className) : base(address, className)
            {
            }

            public void UpdateFollowPosition()
            {
                base.method_8("UpdateFollowPosition", Array.Empty<object>());
            }

            public UIBFollowObject bubbleFollower
            {
                get
                {
                    return base.method_3<UIBFollowObject>("bubbleFollower");
                }
            }

            public UIBFollowObject closeButtonFollower
            {
                get
                {
                    return base.method_3<UIBFollowObject>("closeButtonFollower");
                }
            }

            public UIBFollowObject playerInfoFollower
            {
                get
                {
                    return base.method_3<UIBFollowObject>("playerInfoFollower");
                }
            }
        }

        [Attribute38("MobileChatLogFrame.InputInfo")]
        public class InputInfo : MonoClass
        {
            public InputInfo(IntPtr address) : this(address, "InputInfo")
            {
            }

            public InputInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Transform inputBottomRight
            {
                get
                {
                    return base.method_3<Transform>("inputBottomRight");
                }
            }

            public Transform inputTopLeft
            {
                get
                {
                    return base.method_3<Transform>("inputTopLeft");
                }
            }
        }

        [Attribute38("MobileChatLogFrame.MessageInfo")]
        public class MessageInfo : MonoClass
        {
            public MessageInfo(IntPtr address) : this(address, "MessageInfo")
            {
            }

            public MessageInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Transform messagesBottomRight
            {
                get
                {
                    return base.method_3<Transform>("messagesBottomRight");
                }
            }

            public Transform messagesTopLeft
            {
                get
                {
                    return base.method_3<Transform>("messagesTopLeft");
                }
            }
        }
    }
}

