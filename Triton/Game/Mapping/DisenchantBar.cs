namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DisenchantBar")]
    public class DisenchantBar : MonoClass
    {
        public DisenchantBar(IntPtr address) : this(address, "DisenchantBar")
        {
        }

        public DisenchantBar(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCards(int count, int sellAmount, TAG_PREMIUM premiumType)
        {
            object[] objArray1 = new object[] { count, sellAmount, premiumType };
            base.method_8("AddCards", objArray1);
        }

        public int GetAmountDust()
        {
            return base.method_11<int>("GetAmountDust", Array.Empty<object>());
        }

        public int GetNumCards()
        {
            return base.method_11<int>("GetNumCards", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void UpdateVisuals(int totalNumCards)
        {
            object[] objArray1 = new object[] { totalNumCards };
            base.method_8("UpdateVisuals", objArray1);
        }

        public int m_amount
        {
            get
            {
                return base.method_2<int>("m_amount");
            }
        }

        public GameObject m_amountBar
        {
            get
            {
                return base.method_3<GameObject>("m_amountBar");
            }
        }

        public UberText m_amountText
        {
            get
            {
                return base.method_3<UberText>("m_amountText");
            }
        }

        public MeshRenderer m_barFrameMesh
        {
            get
            {
                return base.method_3<MeshRenderer>("m_barFrameMesh");
            }
        }

        public GameObject m_dustJar
        {
            get
            {
                return base.method_3<GameObject>("m_dustJar");
            }
        }

        public GameObject m_glow
        {
            get
            {
                return base.method_3<GameObject>("m_glow");
            }
        }

        public int m_numCards
        {
            get
            {
                return base.method_2<int>("m_numCards");
            }
        }

        public UberText m_numCardsText
        {
            get
            {
                return base.method_3<UberText>("m_numCardsText");
            }
        }

        public int m_numGoldCards
        {
            get
            {
                return base.method_2<int>("m_numGoldCards");
            }
        }

        public UberText m_numGoldText
        {
            get
            {
                return base.method_3<UberText>("m_numGoldText");
            }
        }

        public TAG_PREMIUM m_premiumType
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premiumType");
            }
        }

        public TAG_RARITY m_rarity
        {
            get
            {
                return base.method_2<TAG_RARITY>("m_rarity");
            }
        }

        public GameObject m_rarityGem
        {
            get
            {
                return base.method_3<GameObject>("m_rarityGem");
            }
        }

        public UberText m_typeText
        {
            get
            {
                return base.method_3<UberText>("m_typeText");
            }
        }

        public static float NUM_CARDS_TEXT_CENTER_X
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DisenchantBar", "NUM_CARDS_TEXT_CENTER_X");
            }
        }

        public static float NUM_CARDS_TEXT_OFFSET_X
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DisenchantBar", "NUM_CARDS_TEXT_OFFSET_X");
            }
        }
    }
}

