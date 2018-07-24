namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("StoreAdventureDef")]
    public class StoreAdventureDef : MonoBehaviour
    {
        public StoreAdventureDef(IntPtr address) : this(address, "StoreAdventureDef")
        {
        }

        public StoreAdventureDef(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_accentTextureName
        {
            get
            {
                return base.method_4("m_accentTextureName");
            }
        }

        public Material m_keyArt
        {
            get
            {
                return base.method_3<Material>("m_keyArt");
            }
        }

        public string m_logoTextureName
        {
            get
            {
                return base.method_4("m_logoTextureName");
            }
        }

        public MusicPlaylistType m_playlist
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_playlist");
            }
        }

        public int m_preorderCardBackId
        {
            get
            {
                return base.method_2<int>("m_preorderCardBackId");
            }
        }

        public List<string> m_previewCards
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_previewCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_storeButtonPrefab
        {
            get
            {
                return base.method_4("m_storeButtonPrefab");
            }
        }
    }
}

