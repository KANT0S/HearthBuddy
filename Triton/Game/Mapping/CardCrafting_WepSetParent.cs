namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardCrafting_WepSetParent")]
    public class CardCrafting_WepSetParent : MonoBehaviour
    {
        public CardCrafting_WepSetParent(IntPtr address) : this(address, "CardCrafting_WepSetParent")
        {
        }

        public CardCrafting_WepSetParent(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetBackToOrgParent()
        {
            base.method_8("SetBackToOrgParent", Array.Empty<object>());
        }

        public void SetParentDiscription()
        {
            base.method_8("SetParentDiscription", Array.Empty<object>());
        }

        public void SetParentManaGem()
        {
            base.method_8("SetParentManaGem", Array.Empty<object>());
        }

        public void SetParentNameBanner()
        {
            base.method_8("SetParentNameBanner", Array.Empty<object>());
        }

        public void SetParentPortrait()
        {
            base.method_8("SetParentPortrait", Array.Empty<object>());
        }

        public void SetParentRarityGem()
        {
            base.method_8("SetParentRarityGem", Array.Empty<object>());
        }

        public void SetParentShield()
        {
            base.method_8("SetParentShield", Array.Empty<object>());
        }

        public void SetParentSwords()
        {
            base.method_8("SetParentSwords", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_Discription
        {
            get
            {
                return base.method_3<GameObject>("m_Discription");
            }
        }

        public GameObject m_ManaGem
        {
            get
            {
                return base.method_3<GameObject>("m_ManaGem");
            }
        }

        public GameObject m_NameBanner
        {
            get
            {
                return base.method_3<GameObject>("m_NameBanner");
            }
        }

        public Transform m_OrgParent
        {
            get
            {
                return base.method_3<Transform>("m_OrgParent");
            }
        }

        public GameObject m_Parent
        {
            get
            {
                return base.method_3<GameObject>("m_Parent");
            }
        }

        public GameObject m_Portrait
        {
            get
            {
                return base.method_3<GameObject>("m_Portrait");
            }
        }

        public GameObject m_RarityGem
        {
            get
            {
                return base.method_3<GameObject>("m_RarityGem");
            }
        }

        public GameObject m_Shield
        {
            get
            {
                return base.method_3<GameObject>("m_Shield");
            }
        }

        public GameObject m_Swords
        {
            get
            {
                return base.method_3<GameObject>("m_Swords");
            }
        }
    }
}

