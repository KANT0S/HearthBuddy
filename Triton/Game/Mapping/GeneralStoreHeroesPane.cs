namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("GeneralStoreHeroesPane")]
    public class GeneralStoreHeroesPane : GeneralStorePane
    {
        public GeneralStoreHeroesPane(IntPtr address) : this(address, "GeneralStoreHeroesPane")
        {
        }

        public GeneralStoreHeroesPane(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public GeneralStoreHeroesSelectorButton CreateNewHeroButton(string heroCardId, Network.Bundle heroBundle)
        {
            object[] objArray1 = new object[] { heroCardId, heroBundle };
            return base.method_14<GeneralStoreHeroesSelectorButton>("CreateNewHeroButton", objArray1);
        }

        public GeneralStoreHeroesSelectorButton CreatePurchasedHeroButton(string heroCardId, Network.Bundle heroBundle)
        {
            object[] objArray1 = new object[] { heroCardId, heroBundle };
            return base.method_14<GeneralStoreHeroesSelectorButton>("CreatePurchasedHeroButton", objArray1);
        }

        public GeneralStoreHeroesSelectorButton CreateUnpurchasedHeroButton(string heroCardId, Network.Bundle heroBundle)
        {
            object[] objArray1 = new object[] { heroCardId, heroBundle };
            return base.method_14<GeneralStoreHeroesSelectorButton>("CreateUnpurchasedHeroButton", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHeroPurchased(int heroDbId)
        {
            object[] objArray1 = new object[] { heroDbId };
            base.method_8("OnHeroPurchased", objArray1);
        }

        public void OnItemPurchased(Network.Bundle bundle, PaymentMethod purchaseMethod, object userData)
        {
            object[] objArray1 = new object[] { bundle, purchaseMethod, userData };
            base.method_8("OnItemPurchased", objArray1);
        }

        public void PopulateHeroes()
        {
            base.method_8("PopulateHeroes", Array.Empty<object>());
        }

        public void PositionAllHeroButtons()
        {
            base.method_8("PositionAllHeroButtons", Array.Empty<object>());
        }

        public void PositionPurchasedHeroButtons(bool sortAndSetSectionPos)
        {
            object[] objArray1 = new object[] { sortAndSetSectionPos };
            base.method_8("PositionPurchasedHeroButtons", objArray1);
        }

        public void PositionUnpurchasedHeroButtons()
        {
            base.method_8("PositionUnpurchasedHeroButtons", Array.Empty<object>());
        }

        public void PrePaneSwappedIn()
        {
            base.method_8("PrePaneSwappedIn", Array.Empty<object>());
        }

        public void RunHeroPurchaseAnimation(int btnIndex)
        {
            object[] objArray1 = new object[] { btnIndex };
            base.method_8("RunHeroPurchaseAnimation", objArray1);
        }

        public void SelectHero(GeneralStoreHeroesSelectorButton button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("SelectHero", objArray1);
        }

        public void SetupHeroButton(string heroCardId, GeneralStoreHeroesSelectorButton heroButton)
        {
            object[] objArray1 = new object[] { heroCardId, heroButton };
            base.method_8("SetupHeroButton", objArray1);
        }

        public void SetupInitialSelectedHero()
        {
            base.method_8("SetupInitialSelectedHero", Array.Empty<object>());
        }

        public void UpdatePurchasedSectionLayout()
        {
            base.method_8("UpdatePurchasedSectionLayout", Array.Empty<object>());
        }

        public string m_buttonsSlideUpSound
        {
            get
            {
                return base.method_4("m_buttonsSlideUpSound");
            }
        }

        public int m_currentPurchaseRemovalIdx
        {
            get
            {
                return base.method_2<int>("m_currentPurchaseRemovalIdx");
            }
        }

        public string m_heroAnimationFrame
        {
            get
            {
                return base.method_4("m_heroAnimationFrame");
            }
        }

        public GeneralStoreHeroesContent m_heroesContent
        {
            get
            {
                return base.method_3<GeneralStoreHeroesContent>("m_heroesContent");
            }
        }

        public string m_heroPurchasedFrame
        {
            get
            {
                return base.method_4("m_heroPurchasedFrame");
            }
        }

        public string m_heroSelectionSound
        {
            get
            {
                return base.method_4("m_heroSelectionSound");
            }
        }

        public string m_heroUnpurchasedFrame
        {
            get
            {
                return base.method_4("m_heroUnpurchasedFrame");
            }
        }

        public bool m_initializeFirstHero
        {
            get
            {
                return base.method_2<bool>("m_initializeFirstHero");
            }
        }

        public float m_maxPurchasedHeightAdd
        {
            get
            {
                return base.method_2<float>("m_maxPurchasedHeightAdd");
            }
        }

        public GameObject m_purchaseAnimationBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_purchaseAnimationBlocker");
            }
        }

        public GameObject m_purchaseAnimationEndBone
        {
            get
            {
                return base.method_3<GameObject>("m_purchaseAnimationEndBone");
            }
        }

        public Vector3 m_purchaseAnimationMidPointWorldOffset
        {
            get
            {
                return base.method_2<Vector3>("m_purchaseAnimationMidPointWorldOffset");
            }
        }

        public string m_purchaseAnimationName
        {
            get
            {
                return base.method_4("m_purchaseAnimationName");
            }
        }

        public GameObject m_purchasedButtonContainer
        {
            get
            {
                return base.method_3<GameObject>("m_purchasedButtonContainer");
            }
        }

        public float m_purchasedHeroButtonHeight
        {
            get
            {
                return base.method_2<float>("m_purchasedHeroButtonHeight");
            }
        }

        public float m_purchasedHeroButtonHeightPadding
        {
            get
            {
                return base.method_2<float>("m_purchasedHeroButtonHeightPadding");
            }
        }

        public Vector3 m_purchasedHeroButtonSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_purchasedHeroButtonSpacing");
            }
        }

        public List<GeneralStoreHeroesSelectorButton> m_purchasedHeroesButtons
        {
            get
            {
                Class267<GeneralStoreHeroesSelectorButton> class2 = base.method_3<Class267<GeneralStoreHeroesSelectorButton>>("m_purchasedHeroesButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public MultiSliceElement m_purchasedSection
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_purchasedSection");
            }
        }

        public GameObject m_purchasedSectionBottom
        {
            get
            {
                return base.method_3<GameObject>("m_purchasedSectionBottom");
            }
        }

        public List<GameObject> m_purchasedSectionMidMeshes
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_purchasedSectionMidMeshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_purchasedSectionMidTemplate
        {
            get
            {
                return base.method_3<GameObject>("m_purchasedSectionMidTemplate");
            }
        }

        public Vector3 m_purchasedSectionOffset
        {
            get
            {
                return base.method_2<Vector3>("m_purchasedSectionOffset");
            }
        }

        public GameObject m_purchasedSectionTop
        {
            get
            {
                return base.method_3<GameObject>("m_purchasedSectionTop");
            }
        }

        public UIBScrollable m_scrollUpdate
        {
            get
            {
                return base.method_3<UIBScrollable>("m_scrollUpdate");
            }
        }

        public float m_unpurchasedHeroButtonHeight
        {
            get
            {
                return base.method_2<float>("m_unpurchasedHeroButtonHeight");
            }
        }

        public Vector3 m_unpurchasedHeroButtonSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_unpurchasedHeroButtonSpacing");
            }
        }

        public List<GeneralStoreHeroesSelectorButton> m_unpurchasedHeroesButtons
        {
            get
            {
                Class267<GeneralStoreHeroesSelectorButton> class2 = base.method_3<Class267<GeneralStoreHeroesSelectorButton>>("m_unpurchasedHeroesButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 PurchasedHeroButtonSpacing
        {
            get
            {
                return base.method_11<Vector3>("get_PurchasedHeroButtonSpacing", Array.Empty<object>());
            }
        }

        public Vector3 UnpurchasedHeroButtonSpacing
        {
            get
            {
                return base.method_11<Vector3>("get_UnpurchasedHeroButtonSpacing", Array.Empty<object>());
            }
        }
    }
}

