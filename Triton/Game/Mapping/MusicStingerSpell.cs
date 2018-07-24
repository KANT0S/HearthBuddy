namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MusicStingerSpell")]
    public class MusicStingerSpell : CardSoundSpell
    {
        public MusicStingerSpell(IntPtr address) : this(address, "MusicStingerSpell")
        {
        }

        public MusicStingerSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanPlay()
        {
            return base.method_11<bool>("CanPlay", Array.Empty<object>());
        }

        public MusicStingerData m_MusicStingerData
        {
            get
            {
                return base.method_3<MusicStingerData>("m_MusicStingerData");
            }
        }
    }
}

