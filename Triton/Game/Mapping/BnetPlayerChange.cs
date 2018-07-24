namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BnetPlayerChange")]
    public class BnetPlayerChange : MonoClass
    {
        public BnetPlayerChange(IntPtr address) : this(address, "BnetPlayerChange")
        {
        }

        public BnetPlayerChange(IntPtr address, string className) : base(address, className)
        {
        }

        public BnetPlayer GetNewPlayer()
        {
            return base.method_14<BnetPlayer>("GetNewPlayer", Array.Empty<object>());
        }

        public BnetPlayer GetOldPlayer()
        {
            return base.method_14<BnetPlayer>("GetOldPlayer", Array.Empty<object>());
        }

        public BnetPlayer GetPlayer()
        {
            return base.method_14<BnetPlayer>("GetPlayer", Array.Empty<object>());
        }

        public void SetNewPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SetNewPlayer", objArray1);
        }

        public void SetOldPlayer(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SetOldPlayer", objArray1);
        }

        public BnetPlayer m_newPlayer
        {
            get
            {
                return base.method_3<BnetPlayer>("m_newPlayer");
            }
        }

        public BnetPlayer m_oldPlayer
        {
            get
            {
                return base.method_3<BnetPlayer>("m_oldPlayer");
            }
        }
    }
}

