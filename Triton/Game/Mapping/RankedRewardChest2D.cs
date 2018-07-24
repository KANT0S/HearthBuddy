namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("RankedRewardChest2D")]
    public class RankedRewardChest2D : PegUIElement
    {
        public RankedRewardChest2D(IntPtr address) : this(address, "RankedRewardChest2D")
        {
        }

        public RankedRewardChest2D(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChestOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ChestOut", objArray1);
        }

        public void ChestOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ChestOver", objArray1);
        }

        public void SetRank(int rank)
        {
            object[] objArray1 = new object[] { rank };
            base.method_8("SetRank", objArray1);
        }

        public GameObject m_emptyRewardChest
        {
            get
            {
                return base.method_3<GameObject>("m_emptyRewardChest");
            }
        }

        public GameObject m_legendaryGem
        {
            get
            {
                return base.method_3<GameObject>("m_legendaryGem");
            }
        }

        public int m_rank
        {
            get
            {
                return base.method_2<int>("m_rank");
            }
        }

        public UberText m_rewardChestDescriptionText
        {
            get
            {
                return base.method_3<UberText>("m_rewardChestDescriptionText");
            }
        }

        public UberText m_rewardChestRankText
        {
            get
            {
                return base.method_3<UberText>("m_rewardChestRankText");
            }
        }

        public List<GameObject> m_rewardChests
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_rewardChests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

