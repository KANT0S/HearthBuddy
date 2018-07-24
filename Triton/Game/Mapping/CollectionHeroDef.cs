namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionHeroDef")]
    public class CollectionHeroDef : MonoBehaviour
    {
        public CollectionHeroDef(IntPtr address) : this(address, "CollectionHeroDef")
        {
        }

        public CollectionHeroDef(IntPtr address, string className) : base(address, className)
        {
        }

        public EmoteType m_collectionManagerPreviewEmote
        {
            get
            {
                return base.method_2<EmoteType>("m_collectionManagerPreviewEmote");
            }
        }

        public Texture m_fauxPlateTexture
        {
            get
            {
                return base.method_3<Texture>("m_fauxPlateTexture");
            }
        }

        public MusicPlaylistType m_heroPlaylist
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_heroPlaylist");
            }
        }

        public Material m_previewTexture
        {
            get
            {
                return base.method_3<Material>("m_previewTexture");
            }
        }

        public EmoteType m_storePreviewEmote
        {
            get
            {
                return base.method_2<EmoteType>("m_storePreviewEmote");
            }
        }

        public EmoteType m_storePurchaseEmote
        {
            get
            {
                return base.method_2<EmoteType>("m_storePurchaseEmote");
            }
        }
    }
}

