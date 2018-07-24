namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MusicStingerData")]
    public class MusicStingerData : MonoClass
    {
        public MusicStingerData(IntPtr address) : this(address, "MusicStingerData")
        {
        }

        public MusicStingerData(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

