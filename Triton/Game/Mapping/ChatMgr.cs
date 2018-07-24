namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ChatMgr")]
    public class ChatMgr : MonoBehaviour
    {
        public ChatMgr(IntPtr address) : this(address, "ChatMgr")
        {
        }

        public ChatMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddRecentWhisperPlayerToBottom(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("AddRecentWhisperPlayerToBottom", objArray1);
        }

        public void AddRecentWhisperPlayerToTop(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("AddRecentWhisperPlayerToTop", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public void CloseChatUI()
        {
            base.method_8("CloseChatUI", Array.Empty<object>());
        }

        public KeyboardState ComputeKeyboardState()
        {
            return base.method_11<KeyboardState>("ComputeKeyboardState", Array.Empty<object>());
        }

        public Triton.Game.Mapping.FriendListFrame CreateFriendsListUI()
        {
            return base.method_14<Triton.Game.Mapping.FriendListFrame>("CreateFriendsListUI", Array.Empty<object>());
        }

        public void DestroyFriendListFrame()
        {
            base.method_8("DestroyFriendListFrame", Array.Empty<object>());
        }

        public void FireChatInfoChangedEvent(PlayerChatInfo chatInfo)
        {
            object[] objArray1 = new object[] { chatInfo };
            base.method_8("FireChatInfoChangedEvent", objArray1);
        }

        public static ChatMgr Get()
        {
            return MonoClass.smethod_15<ChatMgr>(TritonHs.MainAssemblyPath, "", "ChatMgr", "Get", Array.Empty<object>());
        }

        public BnetPlayer GetMostRecentWhisperedPlayer()
        {
            return base.method_14<BnetPlayer>("GetMostRecentWhisperedPlayer", Array.Empty<object>());
        }

        public PlayerChatInfo GetPlayerChatInfo(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_14<PlayerChatInfo>("GetPlayerChatInfo", objArray1);
        }

        public List<BnetPlayer> GetRecentWhisperPlayers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetRecentWhisperPlayers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void GoBack()
        {
            base.method_8("GoBack", Array.Empty<object>());
        }

        public void HandleGUIInput()
        {
            base.method_8("HandleGUIInput", Array.Empty<object>());
        }

        public void HandleGUIInputForQuickChat()
        {
            base.method_8("HandleGUIInputForQuickChat", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void HideFriendsList()
        {
            base.method_8("HideFriendsList", Array.Empty<object>());
        }

        public void InitChatLogUI()
        {
            base.method_8("InitChatLogUI", Array.Empty<object>());
        }

        public void InitCloseCatcher()
        {
            base.method_8("InitCloseCatcher", Array.Empty<object>());
        }

        public bool IsChatLogFrameShown()
        {
            return base.method_11<bool>("IsChatLogFrameShown", Array.Empty<object>());
        }

        public bool IsFriendListShowing()
        {
            return base.method_11<bool>("IsFriendListShowing", Array.Empty<object>());
        }

        public bool IsMobilePlatform()
        {
            return base.method_11<bool>("IsMobilePlatform", Array.Empty<object>());
        }

        public void MoveChatBubbles(ChatBubbleFrame newBubbleFrame)
        {
            object[] objArray1 = new object[] { newBubbleFrame };
            base.method_8("MoveChatBubbles", objArray1);
        }

        public void OnChatBubbleFadeOutComplete(ChatBubbleFrame bubbleFrame)
        {
            object[] objArray1 = new object[] { bubbleFrame };
            base.method_8("OnChatBubbleFadeOutComplete", objArray1);
        }

        public void OnChatBubbleReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnChatBubbleReleased", objArray1);
        }

        public void OnChatBubbleScaleInComplete(ChatBubbleFrame bubbleFrame)
        {
            object[] objArray1 = new object[] { bubbleFrame };
            base.method_8("OnChatBubbleScaleInComplete", objArray1);
        }

        public void OnChatFramesMoved()
        {
            base.method_8("OnChatFramesMoved", Array.Empty<object>());
        }

        public void OnChatLogFrameHidden()
        {
            base.method_8("OnChatLogFrameHidden", Array.Empty<object>());
        }

        public void OnChatLogFrameShown()
        {
            base.method_8("OnChatLogFrameShown", Array.Empty<object>());
        }

        public void OnChatReceiverChanged(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("OnChatReceiverChanged", objArray1);
        }

        public void OnCloseCatcherRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCloseCatcherRelease", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public void OnFriendListClosed()
        {
            base.method_8("OnFriendListClosed", Array.Empty<object>());
        }

        public void OnFriendListFriendSelected(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            base.method_8("OnFriendListFriendSelected", objArray1);
        }

        public void OnFriendListOpened()
        {
            base.method_8("OnFriendListOpened", Array.Empty<object>());
        }

        public void OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnKeyboardHide()
        {
            base.method_8("OnKeyboardHide", Array.Empty<object>());
        }

        public void OnKeyboardShow()
        {
            base.method_8("OnKeyboardShow", Array.Empty<object>());
        }

        public PlayerChatInfo RegisterPlayerChatInfo(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_14<PlayerChatInfo>("RegisterPlayerChatInfo", objArray1);
        }

        public void RemoveAllChatBubbles()
        {
            base.method_8("RemoveAllChatBubbles", Array.Empty<object>());
        }

        public void ShowChatForPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("ShowChatForPlayer", objArray1);
        }

        public void ShowFriendsList()
        {
            base.method_8("ShowFriendsList", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateChatBubbleLayout()
        {
            base.method_8("UpdateChatBubbleLayout", Array.Empty<object>());
        }

        public void UpdateChatBubbleParentLayout()
        {
            base.method_8("UpdateChatBubbleParentLayout", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateLayoutForOnScreenKeyboard()
        {
            base.method_8("UpdateLayoutForOnScreenKeyboard", Array.Empty<object>());
        }

        public void UpdateLayoutForOnScreenKeyboardOnPhone()
        {
            base.method_8("UpdateLayoutForOnScreenKeyboardOnPhone", Array.Empty<object>());
        }

        public void UpdatePlayerFocusTime(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("UpdatePlayerFocusTime", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public Triton.Game.Mapping.FriendListFrame FriendListFrame
        {
            get
            {
                return base.method_14<Triton.Game.Mapping.FriendListFrame>("get_FriendListFrame", Array.Empty<object>());
            }
        }

        public Rect keyboardArea
        {
            get
            {
                return base.method_2<Rect>("keyboardArea");
            }
        }

        public Rect KeyboardRect
        {
            get
            {
                return base.method_11<Rect>("get_KeyboardRect", Array.Empty<object>());
            }
        }

        public KeyboardState keyboardState
        {
            get
            {
                return base.method_2<KeyboardState>("keyboardState");
            }
        }

        public List<ChatBubbleFrame> m_chatBubbleFrames
        {
            get
            {
                Class267<ChatBubbleFrame> class2 = base.method_3<Class267<ChatBubbleFrame>>("m_chatBubbleFrames");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ChatMgrBubbleInfo m_ChatBubbleInfo
        {
            get
            {
                return base.method_3<ChatMgrBubbleInfo>("m_ChatBubbleInfo");
            }
        }

        public bool m_chatLogFrameShown
        {
            get
            {
                return base.method_2<bool>("m_chatLogFrameShown");
            }
        }

        public float m_chatLogXOffset
        {
            get
            {
                return base.method_2<float>("m_chatLogXOffset");
            }
        }

        public PegUIElement m_closeCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_closeCatcher");
            }
        }

        public Triton.Game.Mapping.FriendListFrame m_friendListFrame
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.FriendListFrame>("m_friendListFrame");
            }
        }

        public ChatMgrPrefabs m_Prefabs
        {
            get
            {
                return base.method_3<ChatMgrPrefabs>("m_Prefabs");
            }
        }

        public List<BnetPlayer> m_recentWhisperPlayers
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_recentWhisperPlayers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public enum KeyboardState
        {
            None,
            Below,
            Above
        }
    }
}

