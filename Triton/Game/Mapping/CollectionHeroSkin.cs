namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionHeroSkin")]
    public class CollectionHeroSkin : MonoBehaviour
    {
        public CollectionHeroSkin(IntPtr address) : this(address, "CollectionHeroSkin")
        {
        }

        public CollectionHeroSkin(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void SetClass(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            base.method_8("SetClass", objArray1);
        }

        public void ShowCollectionManagerText()
        {
            base.method_8("ShowCollectionManagerText", Array.Empty<object>());
        }

        public void ShowFavoriteBanner(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowFavoriteBanner", objArray1);
        }

        public void ShowShadow(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowShadow", objArray1);
        }

        public void ShowSocketFX()
        {
            base.method_8("ShowSocketFX", Array.Empty<object>());
        }

        public MeshRenderer m_classIcon
        {
            get
            {
                return base.method_3<MeshRenderer>("m_classIcon");
            }
        }

        public UberText m_collectionManagerName
        {
            get
            {
                return base.method_3<UberText>("m_collectionManagerName");
            }
        }

        public GameObject m_favoriteBanner
        {
            get
            {
                return base.method_3<GameObject>("m_favoriteBanner");
            }
        }

        public UberText m_favoriteBannerText
        {
            get
            {
                return base.method_3<UberText>("m_favoriteBannerText");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }

        public GameObject m_nameShadow
        {
            get
            {
                return base.method_3<GameObject>("m_nameShadow");
            }
        }

        public GameObject m_shadow
        {
            get
            {
                return base.method_3<GameObject>("m_shadow");
            }
        }

        public Spell m_socketFX
        {
            get
            {
                return base.method_3<Spell>("m_socketFX");
            }
        }
    }
}

