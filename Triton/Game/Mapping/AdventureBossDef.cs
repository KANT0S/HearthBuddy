namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureBossDef")]
    public class AdventureBossDef : MonoBehaviour
    {
        public AdventureBossDef(IntPtr address) : this(address, "AdventureBossDef")
        {
        }

        public AdventureBossDef(IntPtr address, string className) : base(address, className)
        {
        }

        public Material m_CoinPortraitMaterial
        {
            get
            {
                return base.method_3<Material>("m_CoinPortraitMaterial");
            }
        }

        public string m_IntroLine
        {
            get
            {
                return base.method_4("m_IntroLine");
            }
        }

        public IntroLinePlayTime m_IntroLinePlayTime
        {
            get
            {
                return base.method_2<IntroLinePlayTime>("m_IntroLinePlayTime");
            }
        }

        public MusicPlaylistType m_MissionMusic
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_MissionMusic");
            }
        }

        public string m_quotePrefabOverride
        {
            get
            {
                return base.method_4("m_quotePrefabOverride");
            }
        }

        public enum IntroLinePlayTime
        {
            MissionSelect,
            MissionStart
        }
    }
}

