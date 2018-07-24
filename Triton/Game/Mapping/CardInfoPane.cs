namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardInfoPane")]
    public class CardInfoPane : MonoBehaviour
    {
        public CardInfoPane(IntPtr address) : this(address, "CardInfoPane")
        {
        }

        public CardInfoPane(IntPtr address, string className) : base(address, className)
        {
        }

        public void AssignRarityColors(TAG_RARITY rarity, TAG_CARD_SET cardSet)
        {
            object[] objArray1 = new object[] { rarity, cardSet };
            base.method_8("AssignRarityColors", objArray1);
        }

        public void UpdateText()
        {
            base.method_8("UpdateText", Array.Empty<object>());
        }

        public UberText m_artistName
        {
            get
            {
                return base.method_3<UberText>("m_artistName");
            }
        }

        public UberText m_flavorText
        {
            get
            {
                return base.method_3<UberText>("m_flavorText");
            }
        }

        public RarityGem m_rarityGem
        {
            get
            {
                return base.method_3<RarityGem>("m_rarityGem");
            }
        }

        public UberText m_rarityLabel
        {
            get
            {
                return base.method_3<UberText>("m_rarityLabel");
            }
        }

        public UberText m_setName
        {
            get
            {
                return base.method_3<UberText>("m_setName");
            }
        }
    }
}

