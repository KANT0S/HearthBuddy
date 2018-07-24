namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStoreAdventureContentDisplay")]
    public class GeneralStoreAdventureContentDisplay : MonoBehaviour
    {
        public GeneralStoreAdventureContentDisplay(IntPtr address) : this(address, "GeneralStoreAdventureContentDisplay")
        {
        }

        public GeneralStoreAdventureContentDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnLeavingSoonButtonClicked()
        {
            base.method_8("OnLeavingSoonButtonClicked", Array.Empty<object>());
        }

        public void SetPreOrder(bool preorder)
        {
            object[] objArray1 = new object[] { preorder };
            base.method_8("SetPreOrder", objArray1);
        }

        public void UpdateAdventureType(StoreAdventureDef advDef, AdventureDbfRecord advRecord)
        {
            object[] objArray1 = new object[] { advDef, advRecord };
            base.method_8("UpdateAdventureType", objArray1);
        }

        public MeshRenderer m_keyArt
        {
            get
            {
                return base.method_3<MeshRenderer>("m_keyArt");
            }
        }

        public GameObject m_leavingSoonBanner
        {
            get
            {
                return base.method_3<GameObject>("m_leavingSoonBanner");
            }
        }

        public UIBButton m_leavingSoonButton
        {
            get
            {
                return base.method_3<UIBButton>("m_leavingSoonButton");
            }
        }

        public string m_leavingSoonInfoText
        {
            get
            {
                return base.method_4("m_leavingSoonInfoText");
            }
        }

        public MeshRenderer m_logo
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logo");
            }
        }

        public GameObject m_preorderFrame
        {
            get
            {
                return base.method_3<GameObject>("m_preorderFrame");
            }
        }

        public PegUIElement m_rewardChest
        {
            get
            {
                return base.method_3<PegUIElement>("m_rewardChest");
            }
        }

        public GameObject m_rewardsFrame
        {
            get
            {
                return base.method_3<GameObject>("m_rewardsFrame");
            }
        }
    }
}

