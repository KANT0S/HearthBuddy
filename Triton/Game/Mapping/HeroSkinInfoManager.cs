namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HeroSkinInfoManager")]
    public class HeroSkinInfoManager : MonoBehaviour
    {
        public HeroSkinInfoManager(IntPtr address) : this(address, "HeroSkinInfoManager")
        {
        }

        public HeroSkinInfoManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AssignNewHeroPreviewMaterial(Material material, Texture portraitTexture)
        {
            object[] objArray1 = new object[] { material, portraitTexture };
            base.method_8("AssignNewHeroPreviewMaterial", objArray1);
        }

        public void AssignVanillaHeroPreviewMaterial(Material material, Texture portraitTexture)
        {
            object[] objArray1 = new object[] { material, portraitTexture };
            base.method_8("AssignVanillaHeroPreviewMaterial", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelPreview()
        {
            base.method_8("CancelPreview", Array.Empty<object>());
        }

        public void EnterPreview(CollectionCardVisual cardVisual)
        {
            object[] objArray1 = new object[] { cardVisual };
            base.method_8("EnterPreview", objArray1);
        }

        public static HeroSkinInfoManager Get()
        {
            return MonoClass.smethod_15<HeroSkinInfoManager>(TritonHs.MainAssemblyPath, "", "HeroSkinInfoManager", "Get", Array.Empty<object>());
        }

        public bool LoadHeroDef(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            return base.method_11<bool>("LoadHeroDef", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PlayHeroMusic()
        {
            base.method_8("PlayHeroMusic", Array.Empty<object>());
        }

        public void SetFavoriteHero()
        {
            base.method_8("SetFavoriteHero", Array.Empty<object>());
        }

        public void SetupUI()
        {
            base.method_8("SetupUI", Array.Empty<object>());
        }

        public void StopHeroMusic()
        {
            base.method_8("StopHeroMusic", Array.Empty<object>());
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public float m_animationTime
        {
            get
            {
                return base.method_2<float>("m_animationTime");
            }
        }

        public string m_currentCardId
        {
            get
            {
                return base.method_4("m_currentCardId");
            }
        }

        public EntityDef m_currentEntityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_currentEntityDef");
            }
        }

        public CollectionHeroDef m_currentHeroDef
        {
            get
            {
                return base.method_3<CollectionHeroDef>("m_currentHeroDef");
            }
        }

        public HeroDbfRecord m_currentHeroRecord
        {
            get
            {
                return base.method_3<HeroDbfRecord>("m_currentHeroRecord");
            }
        }

        public TAG_PREMIUM m_currentPremium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_currentPremium");
            }
        }

        public MusicPlaylistType m_defaultHeroMusic
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_defaultHeroMusic");
            }
        }

        public Material m_defaultPreviewMaterial
        {
            get
            {
                return base.method_3<Material>("m_defaultPreviewMaterial");
            }
        }

        public string m_enterPreviewSound
        {
            get
            {
                return base.method_4("m_enterPreviewSound");
            }
        }

        public string m_exitPreviewSound
        {
            get
            {
                return base.method_4("m_exitPreviewSound");
            }
        }

        public UberText m_newHeroDescription
        {
            get
            {
                return base.method_3<UberText>("m_newHeroDescription");
            }
        }

        public UIBButton m_newHeroFavoriteButton
        {
            get
            {
                return base.method_3<UIBButton>("m_newHeroFavoriteButton");
            }
        }

        public GameObject m_newHeroFrame
        {
            get
            {
                return base.method_3<GameObject>("m_newHeroFrame");
            }
        }

        public MeshRenderer m_newHeroPreviewQuad
        {
            get
            {
                return base.method_3<MeshRenderer>("m_newHeroPreviewQuad");
            }
        }

        public UberText m_newHeroTitle
        {
            get
            {
                return base.method_3<UberText>("m_newHeroTitle");
            }
        }

        public PegUIElement m_offClicker
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClicker");
            }
        }

        public GameObject m_previewPane
        {
            get
            {
                return base.method_3<GameObject>("m_previewPane");
            }
        }

        public MusicPlaylistType m_prevPlaylist
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_prevPlaylist");
            }
        }

        public UberText m_vanillaHeroDescription
        {
            get
            {
                return base.method_3<UberText>("m_vanillaHeroDescription");
            }
        }

        public UIBButton m_vanillaHeroFavoriteButton
        {
            get
            {
                return base.method_3<UIBButton>("m_vanillaHeroFavoriteButton");
            }
        }

        public GameObject m_vanillaHeroFrame
        {
            get
            {
                return base.method_3<GameObject>("m_vanillaHeroFrame");
            }
        }

        public Material m_vanillaHeroNonPremiumMaterial
        {
            get
            {
                return base.method_3<Material>("m_vanillaHeroNonPremiumMaterial");
            }
        }

        public MeshRenderer m_vanillaHeroPreviewQuad
        {
            get
            {
                return base.method_3<MeshRenderer>("m_vanillaHeroPreviewQuad");
            }
        }

        public UberText m_vanillaHeroTitle
        {
            get
            {
                return base.method_3<UberText>("m_vanillaHeroTitle");
            }
        }
    }
}

