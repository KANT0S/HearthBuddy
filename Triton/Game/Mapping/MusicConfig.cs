namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MusicConfig")]
    public class MusicConfig : MonoBehaviour
    {
        public MusicConfig(IntPtr address) : this(address, "MusicConfig")
        {
        }

        public MusicConfig(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public MusicPlaylist FindPlaylist(MusicPlaylistType type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<MusicPlaylist>("FindPlaylist", objArray1);
        }

        public static MusicConfig Get()
        {
            return MonoClass.smethod_15<MusicConfig>(TritonHs.MainAssemblyPath, "", "MusicConfig", "Get", Array.Empty<object>());
        }

        public MusicPlaylist GetPlaylist(MusicPlaylistType type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<MusicPlaylist>("GetPlaylist", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public List<MusicPlaylist> m_playlists
        {
            get
            {
                Class267<MusicPlaylist> class2 = base.method_3<Class267<MusicPlaylist>>("m_playlists");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

