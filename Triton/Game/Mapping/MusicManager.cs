namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MusicManager")]
    public class MusicManager : MonoBehaviour
    {
        public MusicManager(IntPtr address) : this(address, "MusicManager")
        {
        }

        public MusicManager(IntPtr address, string className) : base(address, className)
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

        public static MusicManager Get()
        {
            return MonoClass.smethod_15<MusicManager>(TritonHs.MainAssemblyPath, "", "MusicManager", "Get", Array.Empty<object>());
        }

        public MusicPlaylistType GetCurrentPlaylist()
        {
            return base.method_11<MusicPlaylistType>("GetCurrentPlaylist", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool StartPlaylist(MusicPlaylistType type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_11<bool>("StartPlaylist", objArray1);
        }

        public bool StopPlaylist()
        {
            return base.method_11<bool>("StopPlaylist", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public MusicPlaylistType m_currentPlaylist
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_currentPlaylist");
            }
        }
    }
}

