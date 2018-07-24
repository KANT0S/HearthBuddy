namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MusicTrack")]
    public class MusicTrack : MonoClass
    {
        public MusicTrack(IntPtr address) : this(address, "MusicTrack")
        {
        }

        public MusicTrack(IntPtr address, string className) : base(address, className)
        {
        }

        public MusicTrack Clone()
        {
            return base.method_14<MusicTrack>("Clone", Array.Empty<object>());
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public bool m_shuffle
        {
            get
            {
                return base.method_2<bool>("m_shuffle");
            }
        }

        public MusicTrackType m_trackType
        {
            get
            {
                return base.method_2<MusicTrackType>("m_trackType");
            }
        }

        public float m_volume
        {
            get
            {
                return base.method_2<float>("m_volume");
            }
        }
    }
}

