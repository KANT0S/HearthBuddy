namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Medal")]
    public class Medal : MonoClass
    {
        public Medal(IntPtr address) : this(address, "Medal")
        {
        }

        public Medal(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetBaseMedalName()
        {
            return base.method_13("GetBaseMedalName", Array.Empty<object>());
        }

        public string GetMedalName()
        {
            return base.method_13("GetMedalName", Array.Empty<object>());
        }

        public Medal GetNextMedal()
        {
            return base.method_14<Medal>("GetNextMedal", Array.Empty<object>());
        }

        public string GetNextMedalName()
        {
            return base.method_13("GetNextMedalName", Array.Empty<object>());
        }

        public int GetNumStars()
        {
            return base.method_11<int>("GetNumStars", Array.Empty<object>());
        }

        public string GetStarString()
        {
            return base.method_13("GetStarString", Array.Empty<object>());
        }

        public bool IsGrandMaster()
        {
            return base.method_11<bool>("IsGrandMaster", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public static Type GRAND_MASTER_MEDAL_TYPE
        {
            get
            {
                return MonoClass.smethod_6<Type>(TritonHs.MainAssemblyPath, "", "Medal", "GRAND_MASTER_MEDAL_TYPE");
            }
        }

        public int GrandMasterRank
        {
            get
            {
                return base.method_11<int>("get_GrandMasterRank", Array.Empty<object>());
            }
        }

        public int m_grandMasterRank
        {
            get
            {
                return base.method_2<int>("m_grandMasterRank");
            }
        }

        public Type m_medalType
        {
            get
            {
                return base.method_2<Type>("m_medalType");
            }
        }

        public Type MedalType
        {
            get
            {
                return base.method_11<Type>("get_MedalType", Array.Empty<object>());
            }
        }

        public enum Type
        {
            MEDAL_NOVICE,
            MEDAL_JOURNEYMAN,
            MEDAL_COPPER_A,
            MEDAL_COPPER_B,
            MEDAL_COPPER_C,
            MEDAL_SILVER_A,
            MEDAL_SILVER_B,
            MEDAL_SILVER_C,
            MEDAL_GOLD_A,
            MEDAL_GOLD_B,
            MEDAL_GOLD_C,
            MEDAL_PLATINUM_A,
            MEDAL_PLATINUM_B,
            MEDAL_PLATINUM_C,
            MEDAL_DIAMOND_A,
            MEDAL_DIAMOND_B,
            MEDAL_DIAMOND_C,
            MEDAL_MASTER_A,
            MEDAL_MASTER_B,
            MEDAL_MASTER_C,
            MEDAL_APPRENTICE
        }
    }
}

