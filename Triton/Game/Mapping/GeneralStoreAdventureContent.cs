namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("GeneralStoreAdventureContent")]
    public class GeneralStoreAdventureContent : GeneralStoreContent
    {
        public GeneralStoreAdventureContent(IntPtr address) : this(address, "GeneralStoreAdventureContent")
        {
        }

        public GeneralStoreAdventureContent(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateAdventureRadioButtonBar()
        {
            base.method_8("AnimateAdventureRadioButtonBar", Array.Empty<object>());
        }

        public void AnimateAndUpdateDisplay(int id, bool forceImmediate)
        {
            object[] objArray1 = new object[] { id, forceImmediate };
            base.method_8("AnimateAndUpdateDisplay", objArray1);
        }

        public bool AnimateEntranceEnd()
        {
            return base.method_11<bool>("AnimateEntranceEnd", Array.Empty<object>());
        }

        public bool AnimateExitEnd()
        {
            return base.method_11<bool>("AnimateExitEnd", Array.Empty<object>());
        }

        public bool AnimateExitStart()
        {
            return base.method_11<bool>("AnimateExitStart", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public AdventureDbId GetAdventureType()
        {
            return base.method_11<AdventureDbId>("GetAdventureType", Array.Empty<object>());
        }

        public GeneralStoreAdventureContentDisplay GetCurrentDisplay()
        {
            return base.method_14<GeneralStoreAdventureContentDisplay>("GetCurrentDisplay", Array.Empty<object>());
        }

        public GameObject GetCurrentDisplayContainer()
        {
            return base.method_14<GameObject>("GetCurrentDisplayContainer", Array.Empty<object>());
        }

        public string GetMoneyDisplayOwnedText()
        {
            return base.method_13("GetMoneyDisplayOwnedText", Array.Empty<object>());
        }

        public GameObject GetNextDisplayContainer()
        {
            return base.method_14<GameObject>("GetNextDisplayContainer", Array.Empty<object>());
        }

        public StoreAdventureDef GetStoreAdventureDef(int advId)
        {
            object[] objArray1 = new object[] { advId };
            return base.method_14<StoreAdventureDef>("GetStoreAdventureDef", objArray1);
        }

        public void HidePreviewCardPanel()
        {
            base.method_8("HidePreviewCardPanel", Array.Empty<object>());
        }

        public bool IsPreOrder()
        {
            return base.method_11<bool>("IsPreOrder", Array.Empty<object>());
        }

        public bool IsPurchaseDisabled()
        {
            return base.method_11<bool>("IsPurchaseDisabled", Array.Empty<object>());
        }

        public void OnAdventureProgressUpdated(bool isStartupAction, AdventureMission.WingProgress oldProgress, AdventureMission.WingProgress newProgress, object userData)
        {
            object[] objArray1 = new object[] { isStartupAction, oldProgress, newProgress, userData };
            base.method_8("OnAdventureProgressUpdated", objArray1);
        }

        public void OnAdventuresHidePreviewCard(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnAdventuresHidePreviewCard", objArray1);
        }

        public void OnAdventuresShowPreviewCard(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnAdventuresShowPreviewCard", objArray1);
        }

        public void OnBundleChanged(NoGTAPPTransactionData goldBundle, Network.Bundle moneyBundle)
        {
            object[] objArray1 = new object[] { goldBundle, moneyBundle };
            base.method_8("OnBundleChanged", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnRefresh()
        {
            base.method_8("OnRefresh", Array.Empty<object>());
        }

        public void PostStoreFlipIn(bool animateIn)
        {
            object[] objArray1 = new object[] { animateIn };
            base.method_8("PostStoreFlipIn", objArray1);
        }

        public void PreStoreFlipIn()
        {
            base.method_8("PreStoreFlipIn", Array.Empty<object>());
        }

        public void PreStoreFlipOut()
        {
            base.method_8("PreStoreFlipOut", Array.Empty<object>());
        }

        public void SetAdventureType(AdventureDbId adventure, bool forceImmediate)
        {
            object[] objArray1 = new object[] { adventure, forceImmediate };
            base.method_8("SetAdventureType", objArray1);
        }

        public void ShowPreviewCardPanel()
        {
            base.method_8("ShowPreviewCardPanel", Array.Empty<object>());
        }

        public void StoreHidden(bool isCurrent)
        {
            object[] objArray1 = new object[] { isCurrent };
            base.method_8("StoreHidden", objArray1);
        }

        public void StoreShown(bool isCurrent)
        {
            object[] objArray1 = new object[] { isCurrent };
            base.method_8("StoreShown", objArray1);
        }

        public void UpdateAdventureDescription(Network.Bundle bundle)
        {
            object[] objArray1 = new object[] { bundle };
            base.method_8("UpdateAdventureDescription", objArray1);
        }

        public void UpdateAdventureTypeMusic()
        {
            base.method_8("UpdateAdventureTypeMusic", Array.Empty<object>());
        }

        public void UpdateRadioButtonText(Network.Bundle moneyBundle)
        {
            object[] objArray1 = new object[] { moneyBundle };
            base.method_8("UpdateRadioButtonText", objArray1);
        }

        public List<GameObject> m_adventureCardPreviewBones
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_adventureCardPreviewBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PegUIElement m_adventureCardPreviewOffClicker
        {
            get
            {
                return base.method_3<PegUIElement>("m_adventureCardPreviewOffClicker");
            }
        }

        public GameObject m_adventureCardPreviewPanel
        {
            get
            {
                return base.method_3<GameObject>("m_adventureCardPreviewPanel");
            }
        }

        public UberText m_adventureCardPreviewText
        {
            get
            {
                return base.method_3<UberText>("m_adventureCardPreviewText");
            }
        }

        public GeneralStoreAdventureContentDisplay m_adventureDisplay
        {
            get
            {
                return base.method_3<GeneralStoreAdventureContentDisplay>("m_adventureDisplay");
            }
        }

        public GeneralStoreAdventureContentDisplay m_adventureDisplay1
        {
            get
            {
                return base.method_3<GeneralStoreAdventureContentDisplay>("m_adventureDisplay1");
            }
        }

        public GeneralStoreAdventureContentDisplay m_adventureDisplay2
        {
            get
            {
                return base.method_3<GeneralStoreAdventureContentDisplay>("m_adventureDisplay2");
            }
        }

        public GameObject m_adventureEmptyDisplay
        {
            get
            {
                return base.method_3<GameObject>("m_adventureEmptyDisplay");
            }
        }

        public GameObject m_adventureOwnedCheckmark
        {
            get
            {
                return base.method_3<GameObject>("m_adventureOwnedCheckmark");
            }
        }

        public RadioButton m_adventureRadioButton
        {
            get
            {
                return base.method_3<RadioButton>("m_adventureRadioButton");
            }
        }

        public GameObject m_adventureRadioButtonContainer
        {
            get
            {
                return base.method_3<GameObject>("m_adventureRadioButtonContainer");
            }
        }

        public UberText m_adventureRadioButtonCostText
        {
            get
            {
                return base.method_3<UberText>("m_adventureRadioButtonCostText");
            }
        }

        public UberText m_adventureRadioButtonText
        {
            get
            {
                return base.method_3<UberText>("m_adventureRadioButtonText");
            }
        }

        public float m_backgroundFlipAnimTime
        {
            get
            {
                return base.method_2<float>("m_backgroundFlipAnimTime");
            }
        }

        public string m_backgroundFlipSound
        {
            get
            {
                return base.method_4("m_backgroundFlipSound");
            }
        }

        public int m_currentDisplay
        {
            get
            {
                return base.method_2<int>("m_currentDisplay");
            }
        }

        public GeneralStoreRewardsCardBack m_preorderCardBackReward
        {
            get
            {
                return base.method_3<GeneralStoreRewardsCardBack>("m_preorderCardBackReward");
            }
        }

        public AdventureDbId m_selectedAdventureType
        {
            get
            {
                return base.method_2<AdventureDbId>("m_selectedAdventureType");
            }
        }

        public bool m_showPreviewCards
        {
            get
            {
                return base.method_2<bool>("m_showPreviewCards");
            }
        }
    }
}

