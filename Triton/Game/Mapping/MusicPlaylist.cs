namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("MusicPlaylist")]
    public class MusicPlaylist : MonoClass
    {
        public MusicPlaylist(IntPtr address) : this(address, "MusicPlaylist")
        {
        }

        public MusicPlaylist(IntPtr address, string className) : base(address, className)
        {
        }

        public List<MusicTrack> GetAmbienceTracks()
        {
            Class267<MusicTrack> class2 = base.method_14<Class267<MusicTrack>>("GetAmbienceTracks", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<MusicTrack> GetMusicTracks()
        {
            Class267<MusicTrack> class2 = base.method_14<Class267<MusicTrack>>("GetMusicTracks", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<MusicTrack> m_tracks
        {
            get
            {
                Class267<MusicTrack> class2 = base.method_3<Class267<MusicTrack>>("m_tracks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public MusicPlaylistType m_type
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_type");
            }
        }
    }
}

