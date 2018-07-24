namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStoreHeroesContentDisplay")]
    public class GeneralStoreHeroesContentDisplay : MonoBehaviour
    {
        public GeneralStoreHeroesContentDisplay(IntPtr address) : this(address, "GeneralStoreHeroesContentDisplay")
        {
        }

        public GeneralStoreHeroesContentDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearEmotes()
        {
            base.method_8("ClearEmotes", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void PlayKeyArtAnimation(bool showPreview)
        {
            object[] objArray1 = new object[] { showPreview };
            base.method_8("PlayKeyArtAnimation", objArray1);
        }

        public void PlayPreviewEmote()
        {
            base.method_8("PlayPreviewEmote", Array.Empty<object>());
        }

        public void PlayPurchaseEmote()
        {
            base.method_8("PlayPurchaseEmote", Array.Empty<object>());
        }

        public void ResetPreview()
        {
            base.method_8("ResetPreview", Array.Empty<object>());
        }

        public void SetKeyArtRenderer(MeshRenderer keyArtRenderer)
        {
            object[] objArray1 = new object[] { keyArtRenderer };
            base.method_8("SetKeyArtRenderer", objArray1);
        }

        public void SetParent(GeneralStoreHeroesContent parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void ShowPurchasedCheckmark(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowPurchasedCheckmark", objArray1);
        }

        public void TogglePreview()
        {
            base.method_8("TogglePreview", Array.Empty<object>());
        }

        public void UpdateFrame(string heroID, int cardBackIdx, CollectionHeroDef heroDef)
        {
            object[] objArray1 = new object[] { heroID, cardBackIdx, heroDef };
            base.method_8("UpdateFrame", objArray1);
        }

        public GameObject m_cardBack
        {
            get
            {
                return base.method_3<GameObject>("m_cardBack");
            }
        }

        public GameObject m_cardBackContainer
        {
            get
            {
                return base.method_3<GameObject>("m_cardBackContainer");
            }
        }

        public MeshRenderer m_classIcon
        {
            get
            {
                return base.method_3<MeshRenderer>("m_classIcon");
            }
        }

        public UberText m_className
        {
            get
            {
                return base.method_3<UberText>("m_className");
            }
        }

        public CollectionHeroDef m_currentHeroAsset
        {
            get
            {
                return base.method_3<CollectionHeroDef>("m_currentHeroAsset");
            }
        }

        public MeshRenderer m_fauxPlateTexture
        {
            get
            {
                return base.method_3<MeshRenderer>("m_fauxPlateTexture");
            }
        }

        public Actor m_heroActor
        {
            get
            {
                return base.method_3<Actor>("m_heroActor");
            }
        }

        public GameObject m_heroContainer
        {
            get
            {
                return base.method_3<GameObject>("m_heroContainer");
            }
        }

        public UberText m_heroName
        {
            get
            {
                return base.method_3<UberText>("m_heroName");
            }
        }

        public Actor m_heroPowerActor
        {
            get
            {
                return base.method_3<Actor>("m_heroPowerActor");
            }
        }

        public GameObject m_heroPowerContainer
        {
            get
            {
                return base.method_3<GameObject>("m_heroPowerContainer");
            }
        }

        public MeshRenderer m_keyArt
        {
            get
            {
                return base.method_3<MeshRenderer>("m_keyArt");
            }
        }

        public bool m_keyArtShowing
        {
            get
            {
                return base.method_2<bool>("m_keyArtShowing");
            }
        }

        public GeneralStoreHeroesContent m_parent
        {
            get
            {
                return base.method_3<GeneralStoreHeroesContent>("m_parent");
            }
        }

        public GameObject m_previewButtonFX
        {
            get
            {
                return base.method_3<GameObject>("m_previewButtonFX");
            }
        }

        public CardSoundSpell m_previewEmote
        {
            get
            {
                return base.method_3<CardSoundSpell>("m_previewEmote");
            }
        }

        public UIBButton m_previewToggle
        {
            get
            {
                return base.method_3<UIBButton>("m_previewToggle");
            }
        }

        public GameObject m_purchasedCheckMark
        {
            get
            {
                return base.method_3<GameObject>("m_purchasedCheckMark");
            }
        }

        public CardSoundSpell m_purchaseEmote
        {
            get
            {
                return base.method_3<CardSoundSpell>("m_purchaseEmote");
            }
        }

        public GameObject m_renderArtQuad
        {
            get
            {
                return base.method_3<GameObject>("m_renderArtQuad");
            }
        }
    }
}

