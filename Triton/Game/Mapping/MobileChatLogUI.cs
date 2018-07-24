namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MobileChatLogUI")]
    public class MobileChatLogUI : MonoClass
    {
        public MobileChatLogUI(IntPtr address) : this(address, "MobileChatLogUI")
        {
        }

        public MobileChatLogUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void GoBack()
        {
            base.method_8("GoBack", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void ShowForPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("ShowForPlayer", objArray1);
        }

        public Triton.Game.Mapping.GameObject GameObject
        {
            get
            {
                return base.method_14<Triton.Game.Mapping.GameObject>("get_GameObject", Array.Empty<object>());
            }
        }

        public bool IsShowing
        {
            get
            {
                return base.method_11<bool>("get_IsShowing", Array.Empty<object>());
            }
        }

        public ChatFrames m_chatFrames
        {
            get
            {
                return base.method_3<ChatFrames>("m_chatFrames");
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

