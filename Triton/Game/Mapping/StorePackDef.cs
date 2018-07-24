namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StorePackDef")]
    public class StorePackDef : MonoBehaviour
    {
        public StorePackDef(IntPtr address) : this(address, "StorePackDef")
        {
        }

        public StorePackDef(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_accentTextureName
        {
            get
            {
                return base.method_4("m_accentTextureName");
            }
        }

        public Material m_background
        {
            get
            {
                return base.method_3<Material>("m_background");
            }
        }

        public string m_buttonPrefab
        {
            get
            {
                return base.method_4("m_buttonPrefab");
            }
        }

        public string m_logoTextureGlowName
        {
            get
            {
                return base.method_4("m_logoTextureGlowName");
            }
        }

        public string m_logoTextureName
        {
            get
            {
                return base.method_4("m_logoTextureName");
            }
        }

        public string m_lowPolyPrefab
        {
            get
            {
                return base.method_4("m_lowPolyPrefab");
            }
        }

        public MusicPlaylistType m_playlist
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_playlist");
            }
        }

        public string m_preorderAvailableDateString
        {
            get
            {
                return base.method_4("m_preorderAvailableDateString");
            }
        }
    }
}

