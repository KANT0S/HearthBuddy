namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStoreHeroesContent")]
    public class GeneralStoreHeroesContent : GeneralStoreContent
    {
        public GeneralStoreHeroesContent(IntPtr address) : this(address, "GeneralStoreHeroesContent")
        {
        }

        public GeneralStoreHeroesContent(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateAndUpdateDisplays(string heroID, int cardBackIdx, CollectionHeroDef heroDef, bool purchased)
        {
            object[] objArray1 = new object[] { heroID, cardBackIdx, heroDef, purchased };
            base.method_8("AnimateAndUpdateDisplays", objArray1);
        }

        public bool AnimateEntranceEnd()
        {
            return base.method_11<bool>("AnimateEntranceEnd", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public GeneralStoreHeroesContentDisplay GetCurrentDisplay()
        {
            return base.method_14<GeneralStoreHeroesContentDisplay>("GetCurrentDisplay", Array.Empty<object>());
        }

        public GameObject GetCurrentDisplayContainer()
        {
            return base.method_14<GameObject>("GetCurrentDisplayContainer", Array.Empty<object>());
        }

        public string GetHeroDescriptionString()
        {
            return base.method_13("GetHeroDescriptionString", Array.Empty<object>());
        }

        public string GetMoneyDisplayOwnedText()
        {
            return base.method_13("GetMoneyDisplayOwnedText", Array.Empty<object>());
        }

        public GameObject GetNextDisplayContainer()
        {
            return base.method_14<GameObject>("GetNextDisplayContainer", Array.Empty<object>());
        }

        public bool IsPurchaseDisabled()
        {
            return base.method_11<bool>("IsPurchaseDisabled", Array.Empty<object>());
        }

        public void OnRefresh()
        {
            base.method_8("OnRefresh", Array.Empty<object>());
        }

        public void PlayCurrentHeroPurchaseEmote()
        {
            base.method_8("PlayCurrentHeroPurchaseEmote", Array.Empty<object>());
        }

        public void PlayHeroMusic()
        {
            base.method_8("PlayHeroMusic", Array.Empty<object>());
        }

        public void PostStoreFlipIn(bool animatedFlipIn)
        {
            object[] objArray1 = new object[] { animatedFlipIn };
            base.method_8("PostStoreFlipIn", objArray1);
        }

        public void PreStoreFlipIn()
        {
            base.method_8("PreStoreFlipIn", Array.Empty<object>());
        }

        public void ResetHeroPreview()
        {
            base.method_8("ResetHeroPreview", Array.Empty<object>());
        }

        public void SelectHero(string heroID, bool animate)
        {
            object[] objArray1 = new object[] { heroID, animate };
            base.method_8("SelectHero", objArray1);
        }

        public void StoreShown(bool isCurrent)
        {
            object[] objArray1 = new object[] { isCurrent };
            base.method_8("StoreShown", objArray1);
        }

        public void UpdateHeroDescription(bool purchased)
        {
            object[] objArray1 = new object[] { purchased };
            base.method_8("UpdateHeroDescription", objArray1);
        }

        public string m_backgroundFlipSound
        {
            get
            {
                return base.method_4("m_backgroundFlipSound");
            }
        }

        public int m_currentCardBackPreview
        {
            get
            {
                return base.method_2<int>("m_currentCardBackPreview");
            }
        }

        public HeroDbfRecord m_currentDbfRecord
        {
            get
            {
                return base.method_3<HeroDbfRecord>("m_currentDbfRecord");
            }
        }

        public int m_currentDisplay
        {
            get
            {
                return base.method_2<int>("m_currentDisplay");
            }
        }

        public string m_currentHero
        {
            get
            {
                return base.method_4("m_currentHero");
            }
        }

        public CollectionHeroDef m_currentHeroDef
        {
            get
            {
                return base.method_3<CollectionHeroDef>("m_currentHeroDef");
            }
        }

        public GeneralStoreHeroesContentDisplay m_heroDisplay
        {
            get
            {
                return base.method_3<GeneralStoreHeroesContentDisplay>("m_heroDisplay");
            }
        }

        public GeneralStoreHeroesContentDisplay m_heroDisplay1
        {
            get
            {
                return base.method_3<GeneralStoreHeroesContentDisplay>("m_heroDisplay1");
            }
        }

        public GeneralStoreHeroesContentDisplay m_heroDisplay2
        {
            get
            {
                return base.method_3<GeneralStoreHeroesContentDisplay>("m_heroDisplay2");
            }
        }

        public GameObject m_heroEmptyDisplay
        {
            get
            {
                return base.method_3<GameObject>("m_heroEmptyDisplay");
            }
        }

        public string m_keyArtAppearAnim
        {
            get
            {
                return base.method_4("m_keyArtAppearAnim");
            }
        }

        public string m_keyArtAppearSound
        {
            get
            {
                return base.method_4("m_keyArtAppearSound");
            }
        }

        public string m_keyArtFadeAnim
        {
            get
            {
                return base.method_4("m_keyArtFadeAnim");
            }
        }

        public string m_keyArtFadeSound
        {
            get
            {
                return base.method_4("m_keyArtFadeSound");
            }
        }

        public string m_previewButtonClick
        {
            get
            {
                return base.method_4("m_previewButtonClick");
            }
        }

        public MeshRenderer m_renderQuad1
        {
            get
            {
                return base.method_3<MeshRenderer>("m_renderQuad1");
            }
        }

        public MeshRenderer m_renderQuad2
        {
            get
            {
                return base.method_3<MeshRenderer>("m_renderQuad2");
            }
        }

        public GameObject m_renderToTexture1
        {
            get
            {
                return base.method_3<GameObject>("m_renderToTexture1");
            }
        }

        public GameObject m_renderToTexture2
        {
            get
            {
                return base.method_3<GameObject>("m_renderToTexture2");
            }
        }
    }
}

