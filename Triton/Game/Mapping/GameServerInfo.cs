namespace Triton.Game.Mapping
{
    using System;
    using Triton.Game.Mono;

    public class GameServerInfo : MonoClass
    {
        public GameServerInfo(IntPtr address) : this(address, "GameServerInfo")
        {
        }

        public GameServerInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public int GameHandle
        {
            get
            {
                return base.method_11<int>("get_GameHandle", Array.Empty<object>());
            }
        }
    }
}

