namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("GeneralStoreAdventurePane")]
    public class GeneralStoreAdventurePane : GeneralStorePane
    {
        public GeneralStoreAdventurePane(IntPtr address) : this(address, "GeneralStoreAdventurePane")
        {
        }

        public GeneralStoreAdventurePane(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnAdventureSelectorButtonClicked(GeneralStoreAdventureSelectorButton btn, AdventureDbId adventureType)
        {
            object[] objArray1 = new object[] { btn, adventureType };
            base.method_8("OnAdventureSelectorButtonClicked", objArray1);
        }

        public void OnRefresh()
        {
            base.method_8("OnRefresh", Array.Empty<object>());
        }

        public void SetupInitialSelectedAdventure()
        {
            base.method_8("SetupInitialSelectedAdventure", Array.Empty<object>());
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

        public void UpdateAdventureButtonPositions()
        {
            base.method_8("UpdateAdventureButtonPositions", Array.Empty<object>());
        }

        public Vector3 AdventureButtonSpacing
        {
            get
            {
                return base.method_11<Vector3>("get_AdventureButtonSpacing", Array.Empty<object>());
            }
        }

        public List<GeneralStoreAdventureSelectorButton> m_adventureButtons
        {
            get
            {
                Class267<GeneralStoreAdventureSelectorButton> class2 = base.method_3<Class267<GeneralStoreAdventureSelectorButton>>("m_adventureButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_adventureButtonSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_adventureButtonSpacing");
            }
        }

        public GeneralStoreAdventureContent m_adventureContent
        {
            get
            {
                return base.method_3<GeneralStoreAdventureContent>("m_adventureContent");
            }
        }

        public string m_adventureSelectionSound
        {
            get
            {
                return base.method_4("m_adventureSelectionSound");
            }
        }

        public bool m_initializeFirstAdv
        {
            get
            {
                return base.method_2<bool>("m_initializeFirstAdv");
            }
        }
    }
}

