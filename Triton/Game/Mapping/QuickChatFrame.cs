namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("QuickChatFrame")]
    public class QuickChatFrame : MonoBehaviour
    {
        public QuickChatFrame(IntPtr address) : this(address, "QuickChatFrame")
        {
        }

        public QuickChatFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CycleNextReceiver()
        {
            base.method_8("CycleNextReceiver", Array.Empty<object>());
        }

        public void CyclePrevReceiver()
        {
            base.method_8("CyclePrevReceiver", Array.Empty<object>());
        }

        public void DefaultChatTransform()
        {
            base.method_8("DefaultChatTransform", Array.Empty<object>());
        }

        public ChatLogFrame GetChatLogFrame()
        {
            return base.method_14<ChatLogFrame>("GetChatLogFrame", Array.Empty<object>());
        }

        public BnetPlayer GetReceiver()
        {
            return base.method_14<BnetPlayer>("GetReceiver", Array.Empty<object>());
        }

        public void HideChatLogFrame()
        {
            base.method_8("HideChatLogFrame", Array.Empty<object>());
        }

        public void HideLastMessage()
        {
            base.method_8("HideLastMessage", Array.Empty<object>());
        }

        public void InitChatLogFrame()
        {
            base.method_8("InitChatLogFrame", Array.Empty<object>());
        }

        public void InitInput()
        {
            base.method_8("InitInput", Array.Empty<object>());
        }

        public void InitInputBlocker()
        {
            base.method_8("InitInputBlocker", Array.Empty<object>());
        }

        public void InitLastMessage()
        {
            base.method_8("InitLastMessage", Array.Empty<object>());
        }

        public bool InitReceiver()
        {
            return base.method_11<bool>("InitReceiver", Array.Empty<object>());
        }

        public void InitRecentPlayerDropdown()
        {
            base.method_8("InitRecentPlayerDropdown", Array.Empty<object>());
        }

        public void InitRecentPlayers()
        {
            base.method_8("InitRecentPlayers", Array.Empty<object>());
        }

        public void InitTransform()
        {
            base.method_8("InitTransform", Array.Empty<object>());
        }

        public void OnChatLogButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnChatLogButtonReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnInputBlockerReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInputBlockerReleased", objArray1);
        }

        public void OnInputCanceled(bool userRequested, GameObject requester)
        {
            object[] objArray1 = new object[] { userRequested, requester };
            base.method_8("OnInputCanceled", objArray1);
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

        public void OnRecentPlayerDropdownItemChosen(object selection, object prevSelection)
        {
            object[] objArray1 = new object[] { selection, prevSelection };
            base.method_8("OnRecentPlayerDropdownItemChosen", objArray1);
        }

        public string OnRecentPlayerDropdownText(object val)
        {
            object[] objArray1 = new object[] { val };
            return base.method_13("OnRecentPlayerDropdownText", objArray1);
        }

        public void SetReceiver(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SetReceiver", objArray1);
        }

        public void ShowChatLogFrame()
        {
            base.method_8("ShowChatLogFrame", Array.Empty<object>());
        }

        public void ShowInput(bool fromAwake)
        {
            object[] objArray1 = new object[] { fromAwake };
            base.method_8("ShowInput", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TransformChatForKeyboard()
        {
            base.method_8("TransformChatForKeyboard", Array.Empty<object>());
        }

        public void UpdateLastMessage()
        {
            base.method_8("UpdateLastMessage", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateReceiver()
        {
            base.method_8("UpdateReceiver", Array.Empty<object>());
        }

        public void UpdateRecentPlayerDropdown()
        {
            base.method_8("UpdateRecentPlayerDropdown", Array.Empty<object>());
        }

        public void UpdateRecentPlayers()
        {
            base.method_8("UpdateRecentPlayers", Array.Empty<object>());
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public QuickChatFrameBones m_Bones
        {
            get
            {
                return base.method_3<QuickChatFrameBones>("m_Bones");
            }
        }

        public PegUIElement m_ChatLogButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_ChatLogButton");
            }
        }

        public ChatLogFrame m_chatLogFrame
        {
            get
            {
                return base.method_3<ChatLogFrame>("m_chatLogFrame");
            }
        }

        public float m_initialLastMessageShadowScaleZ
        {
            get
            {
                return base.method_2<float>("m_initialLastMessageShadowScaleZ");
            }
        }

        public float m_initialLastMessageTextHeight
        {
            get
            {
                return base.method_2<float>("m_initialLastMessageTextHeight");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public GameObject m_LastMessageShadow
        {
            get
            {
                return base.method_3<GameObject>("m_LastMessageShadow");
            }
        }

        public UberText m_LastMessageText
        {
            get
            {
                return base.method_3<UberText>("m_LastMessageText");
            }
        }

        public QuickChatFramePrefabs m_Prefabs
        {
            get
            {
                return base.method_3<QuickChatFramePrefabs>("m_Prefabs");
            }
        }

        public BnetPlayer m_receiver
        {
            get
            {
                return base.method_3<BnetPlayer>("m_receiver");
            }
        }

        public UberText m_ReceiverNameText
        {
            get
            {
                return base.method_3<UberText>("m_ReceiverNameText");
            }
        }

        public DropdownControl m_recentPlayerDropdown
        {
            get
            {
                return base.method_3<DropdownControl>("m_recentPlayerDropdown");
            }
        }

        public List<BnetPlayer> m_recentPlayers
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_recentPlayers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

