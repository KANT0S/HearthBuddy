namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RankedRewardChest")]
    public class RankedRewardChest : MonoBehaviour
    {
        public RankedRewardChest(IntPtr address) : this(address, "RankedRewardChest")
        {
        }

        public RankedRewardChest(IntPtr address, string className) : base(address, className)
        {
        }

        public bool DoesChestVisualChange(int rank1, int rank2)
        {
            object[] objArray1 = new object[] { rank1, rank2 };
            return base.method_11<bool>("DoesChestVisualChange", objArray1);
        }

        public static string GetChestEarnedFromRank(int rank)
        {
            object[] objArray1 = new object[] { rank };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "RankedRewardChest", "GetChestEarnedFromRank", objArray1);
        }

        public static int GetChestIndexFromRank(int rank)
        {
            object[] objArray1 = new object[] { rank };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "RankedRewardChest", "GetChestIndexFromRank", objArray1);
        }

        public static string GetChestNameFromRank(int rank)
        {
            object[] objArray1 = new object[] { rank };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "RankedRewardChest", "GetChestNameFromRank", objArray1);
        }

        public ChestVisual GetChestVisualFromRank(int rank)
        {
            object[] objArray1 = new object[] { rank };
            return base.method_14<ChestVisual>("GetChestVisualFromRank", objArray1);
        }

        public void SetRank(int rank)
        {
            object[] objArray1 = new object[] { rank };
            base.method_8("SetRank", objArray1);
        }

        public MeshRenderer m_baseMeshRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_baseMeshRenderer");
            }
        }

        public List<ChestVisual> m_chests
        {
            get
            {
                Class267<ChestVisual> class2 = base.method_3<Class267<ChestVisual>>("m_chests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public MeshRenderer m_glowMeshRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_glowMeshRenderer");
            }
        }

        public GameObject m_legendaryGem
        {
            get
            {
                return base.method_3<GameObject>("m_legendaryGem");
            }
        }

        public UberText m_rankBanner
        {
            get
            {
                return base.method_3<UberText>("m_rankBanner");
            }
        }

        public UberText m_rankNumber
        {
            get
            {
                return base.method_3<UberText>("m_rankNumber");
            }
        }

        public GameObject m_starDestinationBone
        {
            get
            {
                return base.method_3<GameObject>("m_starDestinationBone");
            }
        }

        public static int NUM_REWARD_TIERS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "RankedRewardChest", "NUM_REWARD_TIERS");
            }
        }

        public static string s_rewardChestEarnedText
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RankedRewardChest", "s_rewardChestEarnedText");
            }
        }

        public static string s_rewardChestNameText
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RankedRewardChest", "s_rewardChestNameText");
            }
        }
    }
}

