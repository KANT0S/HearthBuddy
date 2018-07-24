namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PackOpeningCardRarityInfo")]
    public class PackOpeningCardRarityInfo : MonoBehaviour
    {
        public PackOpeningCardRarityInfo(IntPtr address) : this(address, "PackOpeningCardRarityInfo")
        {
        }

        public PackOpeningCardRarityInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_HiddenCardObject
        {
            get
            {
                return base.method_3<GameObject>("m_HiddenCardObject");
            }
        }

        public GameObject m_RarityObject
        {
            get
            {
                return base.method_3<GameObject>("m_RarityObject");
            }
        }

        public PackOpeningRarity m_RarityType
        {
            get
            {
                return base.method_2<PackOpeningRarity>("m_RarityType");
            }
        }

        public GameObject m_RevealedCardObject
        {
            get
            {
                return base.method_3<GameObject>("m_RevealedCardObject");
            }
        }
    }
}

