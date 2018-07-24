namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MedalInfoTranslator")]
    public class MedalInfoTranslator : MonoClass
    {
        public MedalInfoTranslator(IntPtr address) : this(address, "MedalInfoTranslator")
        {
        }

        public MedalInfoTranslator(IntPtr address, string className) : base(address, className)
        {
        }

        public RankChangeType GetChangeType()
        {
            return base.method_11<RankChangeType>("GetChangeType", Array.Empty<object>());
        }

        public TranslatedMedalInfo GetCurrentMedal()
        {
            return base.method_14<TranslatedMedalInfo>("GetCurrentMedal", Array.Empty<object>());
        }

        public TranslatedMedalInfo GetPreviousMedal()
        {
            return base.method_14<TranslatedMedalInfo>("GetPreviousMedal", Array.Empty<object>());
        }

        public bool IsDisplayable()
        {
            return base.method_11<bool>("IsDisplayable", Array.Empty<object>());
        }

        public bool IsPreviousMedalValid()
        {
            return base.method_11<bool>("IsPreviousMedalValid", Array.Empty<object>());
        }

        public bool ShowRewardChest()
        {
            return base.method_11<bool>("ShowRewardChest", Array.Empty<object>());
        }

        public void TestSetMedalInfo(TranslatedMedalInfo currMedal, TranslatedMedalInfo prevMedal)
        {
            object[] objArray1 = new object[] { currMedal, prevMedal };
            base.method_8("TestSetMedalInfo", objArray1);
        }

        public TranslatedMedalInfo Translate(NetCache.NetCacheMedalInfo medalInfo)
        {
            object[] objArray1 = new object[] { medalInfo };
            return base.method_14<TranslatedMedalInfo>("Translate", objArray1);
        }

        public static int LEGEND_RANK_VALUE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MedalInfoTranslator", "LEGEND_RANK_VALUE");
            }
        }

        public static int LOWEST_LEGEND_VALUE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MedalInfoTranslator", "LOWEST_LEGEND_VALUE");
            }
        }

        public TranslatedMedalInfo m_currMedalInfo
        {
            get
            {
                return base.method_3<TranslatedMedalInfo>("m_currMedalInfo");
            }
        }

        public TranslatedMedalInfo m_prevMedalInfo
        {
            get
            {
                return base.method_3<TranslatedMedalInfo>("m_prevMedalInfo");
            }
        }

        public bool m_vaidPrevMedal
        {
            get
            {
                return base.method_2<bool>("m_vaidPrevMedal");
            }
        }

        public static int MAX_RANK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MedalInfoTranslator", "MAX_RANK");
            }
        }

        public static string MEDAL_NAME_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "MedalInfoTranslator", "MEDAL_NAME_PREFIX");
            }
        }

        public static string MEDAL_TEXTURE_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "MedalInfoTranslator", "MEDAL_TEXTURE_PREFIX");
            }
        }

        public static int WORST_DISPLAYABLE_RANK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MedalInfoTranslator", "WORST_DISPLAYABLE_RANK");
            }
        }
    }
}

