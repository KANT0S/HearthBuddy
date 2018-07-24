namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RankMgr")]
    public class RankMgr : MonoClass
    {
        public RankMgr(IntPtr address) : this(address, "RankMgr")
        {
        }

        public RankMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public static RankMgr Get()
        {
            return MonoClass.smethod_15<RankMgr>(TritonHs.MainAssemblyPath, "", "RankMgr", "Get", Array.Empty<object>());
        }

        public MedalInfoTranslator GetRankPresenceField(BnetGameAccount gameAccount)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { gameAccount };
            return base.method_15<MedalInfoTranslator>("GetRankPresenceField", enumArray1, objArray1);
        }

        public MedalInfoTranslator GetRankPresenceField(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_15<MedalInfoTranslator>("GetRankPresenceField", enumArray1, objArray1);
        }

        public bool SetRankPresenceField(NetCache.NetCacheMedalInfo medalInfo)
        {
            object[] objArray1 = new object[] { medalInfo };
            return base.method_11<bool>("SetRankPresenceField", objArray1);
        }

        public static int INVALID_RANK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "RankMgr", "INVALID_RANK");
            }
        }

        public TranslatedMedalInfo m_medalInfo
        {
            get
            {
                return base.method_3<TranslatedMedalInfo>("m_medalInfo");
            }
        }
    }
}

