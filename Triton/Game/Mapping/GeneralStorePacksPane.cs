namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("GeneralStorePacksPane")]
    public class GeneralStorePacksPane : GeneralStorePane
    {
        public GeneralStorePacksPane(IntPtr address) : this(address, "GeneralStorePacksPane")
        {
        }

        public GeneralStorePacksPane(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnPackSelectorButtonClicked(GeneralStorePackSelectorButton btn, int boosterId)
        {
            object[] objArray1 = new object[] { btn, boosterId };
            base.method_8("OnPackSelectorButtonClicked", objArray1);
        }

        public void OnPurchaseFinished()
        {
            base.method_8("OnPurchaseFinished", Array.Empty<object>());
        }

        public void SetupInitialSelectedPack()
        {
            base.method_8("SetupInitialSelectedPack", Array.Empty<object>());
        }

        public bool ShouldResetPackSelection()
        {
            return base.method_11<bool>("ShouldResetPackSelection", Array.Empty<object>());
        }

        public void SortPackButtons()
        {
            base.method_8("SortPackButtons", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StoreShown(bool isCurrent)
        {
            object[] objArray1 = new object[] { isCurrent };
            base.method_8("StoreShown", objArray1);
        }

        public void UpdatePackButtonPositions()
        {
            base.method_8("UpdatePackButtonPositions", Array.Empty<object>());
        }

        public void UpdatePackButtonRecommendedIndicators()
        {
            base.method_8("UpdatePackButtonRecommendedIndicators", Array.Empty<object>());
        }

        public string m_boosterSelectionSound
        {
            get
            {
                return base.method_4("m_boosterSelectionSound");
            }
        }

        public bool m_initializeFirstPack
        {
            get
            {
                return base.method_2<bool>("m_initializeFirstPack");
            }
        }

        public List<GeneralStorePackSelectorButton> m_packButtons
        {
            get
            {
                Class267<GeneralStorePackSelectorButton> class2 = base.method_3<Class267<GeneralStorePackSelectorButton>>("m_packButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_packButtonSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_packButtonSpacing");
            }
        }

        public GeneralStorePacksContent m_packsContent
        {
            get
            {
                return base.method_3<GeneralStorePacksContent>("m_packsContent");
            }
        }

        public Vector3 PackButtonSpacing
        {
            get
            {
                return base.method_11<Vector3>("get_PackButtonSpacing", Array.Empty<object>());
            }
        }
    }
}

