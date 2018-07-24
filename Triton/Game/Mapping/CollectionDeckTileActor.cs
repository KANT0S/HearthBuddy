namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionDeckTileActor")]
    public class CollectionDeckTileActor : Actor
    {
        public CollectionDeckTileActor(IntPtr address) : this(address, "CollectionDeckTileActor")
        {
        }

        public CollectionDeckTileActor(IntPtr address, string className) : base(address, className)
        {
        }

        public void AssignCardCount()
        {
            base.method_8("AssignCardCount", Array.Empty<object>());
        }

        public void AssignSlider()
        {
            base.method_8("AssignSlider", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CloseSlider(bool useSliderAnimations)
        {
            object[] objArray1 = new object[] { useSliderAnimations };
            base.method_8("CloseSlider", objArray1);
        }

        public Material GetPortraitMaterial()
        {
            return base.method_14<Material>("GetPortraitMaterial", Array.Empty<object>());
        }

        public void OpenSlider(bool useSliderAnimations)
        {
            object[] objArray1 = new object[] { useSliderAnimations };
            base.method_8("OpenSlider", objArray1);
        }

        public void SetDesaturationAmount(Material material, DeckTileFrameColorSet colorSet)
        {
            object[] objArray1 = new object[] { material, colorSet };
            base.method_8("SetDesaturationAmount", objArray1);
        }

        public void SetGhosted(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetGhosted", objArray1);
        }

        public void SetPremium(TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { premium };
            base.method_8("SetPremium", objArray1);
        }

        public void UpdateDeckCardProperties(bool cardIsUnique, int numCards, bool useSliderAnimations)
        {
            object[] objArray1 = new object[] { cardIsUnique, numCards, useSliderAnimations };
            base.method_8("UpdateDeckCardProperties", objArray1);
        }

        public void UpdateFrameMaterial()
        {
            base.method_8("UpdateFrameMaterial", Array.Empty<object>());
        }

        public void UpdateGhostTileEffect()
        {
            base.method_8("UpdateGhostTileEffect", Array.Empty<object>());
        }

        public void UpdateMaterial(Material material)
        {
            object[] objArray1 = new object[] { material };
            base.method_8("UpdateMaterial", objArray1);
        }

        public UberText m_countText
        {
            get
            {
                return base.method_3<UberText>("m_countText");
            }
        }

        public UberText m_countTextMesh
        {
            get
            {
                return base.method_3<UberText>("m_countTextMesh");
            }
        }

        public GameObject m_frame
        {
            get
            {
                return base.method_3<GameObject>("m_frame");
            }
        }

        public bool m_ghosted
        {
            get
            {
                return base.method_2<bool>("m_ghosted");
            }
        }

        public DeckTileFrameColorSet m_ghostedColorSet
        {
            get
            {
                return base.method_3<DeckTileFrameColorSet>("m_ghostedColorSet");
            }
        }

        public Material m_ghostedFrameMaterial
        {
            get
            {
                return base.method_3<Material>("m_ghostedFrameMaterial");
            }
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }

        public MeshRenderer m_manaGem
        {
            get
            {
                return base.method_3<MeshRenderer>("m_manaGem");
            }
        }

        public Material m_manaGemGhostedMaterial
        {
            get
            {
                return base.method_3<Material>("m_manaGemGhostedMaterial");
            }
        }

        public Material m_manaGemNormalMaterial
        {
            get
            {
                return base.method_3<Material>("m_manaGemNormalMaterial");
            }
        }

        public DeckTileFrameColorSet m_normalColorSet
        {
            get
            {
                return base.method_3<DeckTileFrameColorSet>("m_normalColorSet");
            }
        }

        public Vector3 m_openSliderLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_openSliderLocalPos");
            }
        }

        public Vector3 m_originalSliderLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_originalSliderLocalPos");
            }
        }

        public Material m_premiumFrameMaterial
        {
            get
            {
                return base.method_3<Material>("m_premiumFrameMaterial");
            }
        }

        public MeshRenderer m_slider
        {
            get
            {
                return base.method_3<MeshRenderer>("m_slider");
            }
        }

        public bool m_sliderIsOpen
        {
            get
            {
                return base.method_2<bool>("m_sliderIsOpen");
            }
        }

        public Material m_standardFrameMaterial
        {
            get
            {
                return base.method_3<Material>("m_standardFrameMaterial");
            }
        }

        public GameObject m_uniqueStar
        {
            get
            {
                return base.method_3<GameObject>("m_uniqueStar");
            }
        }

        public static float SLIDER_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckTileActor", "SLIDER_ANIM_TIME");
            }
        }

        [Attribute38("CollectionDeckTileActor.DeckTileFrameColorSet")]
        public class DeckTileFrameColorSet : MonoClass
        {
            public DeckTileFrameColorSet(IntPtr address) : this(address, "DeckTileFrameColorSet")
            {
            }

            public DeckTileFrameColorSet(IntPtr address, string className) : base(address, className)
            {
            }

            public Color m_costTextColor
            {
                get
                {
                    return base.method_2<Color>("m_costTextColor");
                }
            }

            public Color m_countTextColor
            {
                get
                {
                    return base.method_2<Color>("m_countTextColor");
                }
            }

            public float m_desatAmount
            {
                get
                {
                    return base.method_2<float>("m_desatAmount");
                }
            }

            public Color m_desatColor
            {
                get
                {
                    return base.method_2<Color>("m_desatColor");
                }
            }

            public float m_desatContrast
            {
                get
                {
                    return base.method_2<float>("m_desatContrast");
                }
            }

            public Color m_nameTextColor
            {
                get
                {
                    return base.method_2<Color>("m_nameTextColor");
                }
            }

            public Color m_outlineColor
            {
                get
                {
                    return base.method_2<Color>("m_outlineColor");
                }
            }

            public Color m_sliderColor
            {
                get
                {
                    return base.method_2<Color>("m_sliderColor");
                }
            }
        }
    }
}

