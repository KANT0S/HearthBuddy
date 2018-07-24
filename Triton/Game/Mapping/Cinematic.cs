namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Cinematic")]
    public class Cinematic : MonoBehaviour
    {
        public Cinematic(IntPtr address) : this(address, "Cinematic")
        {
        }

        public Cinematic(IntPtr address, string className) : base(address, className)
        {
        }

        public void AudioLoaded(string name, GameObject obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("AudioLoaded", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool isPlaying()
        {
            return base.method_11<bool>("isPlaying", Array.Empty<object>());
        }

        public void MovieLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("MovieLoaded", objArray1);
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public static void PlayCinematic(string gameObjectName, string localeName)
        {
            object[] objArray1 = new object[] { gameObjectName, localeName };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Cinematic", "PlayCinematic", objArray1);
        }

        public static string CINEMATIC_FILE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Cinematic", "CINEMATIC_FILE_NAME");
            }
        }

        public bool m_isMovieAudioLoaded
        {
            get
            {
                return base.method_2<bool>("m_isMovieAudioLoaded");
            }
        }

        public bool m_isMovieLoaded
        {
            get
            {
                return base.method_2<bool>("m_isMovieLoaded");
            }
        }

        public bool m_isPlaying
        {
            get
            {
                return base.method_2<bool>("m_isPlaying");
            }
        }

        public SoundDucker m_soundDucker
        {
            get
            {
                return base.method_3<SoundDucker>("m_soundDucker");
            }
        }

        public static float MOVIE_LOAD_TIMEOUT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Cinematic", "MOVIE_LOAD_TIMEOUT");
            }
        }

        public PlayOptions options
        {
            get
            {
                return base.method_3<PlayOptions>("options");
            }
        }

        [Attribute38("Cinematic.PlayOptions")]
        public class PlayOptions : MonoClass
        {
            public PlayOptions(IntPtr address) : this(address, "PlayOptions")
            {
            }

            public PlayOptions(IntPtr address, string className) : base(address, className)
            {
            }
        }
    }
}

