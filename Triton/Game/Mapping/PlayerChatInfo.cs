namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PlayerChatInfo")]
    public class PlayerChatInfo : MonoClass
    {
        public PlayerChatInfo(IntPtr address) : this(address, "PlayerChatInfo")
        {
        }

        public PlayerChatInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float GetLastFocusTime()
        {
            return base.method_11<float>("GetLastFocusTime", Array.Empty<object>());
        }

        public BnetPlayer GetPlayer()
        {
            return base.method_14<BnetPlayer>("GetPlayer", Array.Empty<object>());
        }

        public void SetLastFocusTime(float time)
        {
            object[] objArray1 = new object[] { time };
            base.method_8("SetLastFocusTime", objArray1);
        }

        public void SetPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SetPlayer", objArray1);
        }

        public float m_lastFocusTime
        {
            get
            {
                return base.method_2<float>("m_lastFocusTime");
            }
        }

        public BnetPlayer m_player
        {
            get
            {
                return base.method_3<BnetPlayer>("m_player");
            }
        }
    }
}

