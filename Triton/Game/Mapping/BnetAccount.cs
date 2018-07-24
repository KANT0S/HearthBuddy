namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetAccount")]
    public class BnetAccount : MonoClass
    {
        public BnetAccount(IntPtr address) : this(address, "BnetAccount")
        {
        }

        public BnetAccount(IntPtr address, string className) : base(address, className)
        {
        }

        public BnetAccount Clone()
        {
            return base.method_14<BnetAccount>("Clone", Array.Empty<object>());
        }

        public bool Equals(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public ulong GetAwayTimeMicrosec()
        {
            return base.method_11<ulong>("GetAwayTimeMicrosec", Array.Empty<object>());
        }

        public BnetBattleTag GetBattleTag()
        {
            return base.method_14<BnetBattleTag>("GetBattleTag", Array.Empty<object>());
        }

        public string GetFullName()
        {
            return base.method_13("GetFullName", Array.Empty<object>());
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public ulong GetLastOnlineMicrosec()
        {
            return base.method_11<ulong>("GetLastOnlineMicrosec", Array.Empty<object>());
        }

        public bool IsAway()
        {
            return base.method_11<bool>("IsAway", Array.Empty<object>());
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public static bool op_Equality(BnetAccount a, BnetAccount b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetAccount", "op_Equality", objArray1);
        }

        public static bool op_Inequality(BnetAccount a, BnetAccount b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetAccount", "op_Inequality", objArray1);
        }

        public void SetAway(bool away)
        {
            object[] objArray1 = new object[] { away };
            base.method_8("SetAway", objArray1);
        }

        public void SetAwayTimeMicrosec(ulong awayTimeMicrosec)
        {
            object[] objArray1 = new object[] { awayTimeMicrosec };
            base.method_8("SetAwayTimeMicrosec", objArray1);
        }

        public void SetBattleTag(BnetBattleTag battleTag)
        {
            object[] objArray1 = new object[] { battleTag };
            base.method_8("SetBattleTag", objArray1);
        }

        public void SetBusy(bool busy)
        {
            object[] objArray1 = new object[] { busy };
            base.method_8("SetBusy", objArray1);
        }

        public void SetFullName(string fullName)
        {
            object[] objArray1 = new object[] { fullName };
            base.method_8("SetFullName", objArray1);
        }

        public void SetLastOnlineMicrosec(ulong microsec)
        {
            object[] objArray1 = new object[] { microsec };
            base.method_8("SetLastOnlineMicrosec", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool m_away
        {
            get
            {
                return base.method_2<bool>("m_away");
            }
        }

        public ulong m_awayTimeMicrosec
        {
            get
            {
                return base.method_2<ulong>("m_awayTimeMicrosec");
            }
        }

        public BnetBattleTag m_battleTag
        {
            get
            {
                return base.method_3<BnetBattleTag>("m_battleTag");
            }
        }

        public bool m_busy
        {
            get
            {
                return base.method_2<bool>("m_busy");
            }
        }

        public string m_fullName
        {
            get
            {
                return base.method_4("m_fullName");
            }
        }

        public ulong m_lastOnlineMicrosec
        {
            get
            {
                return base.method_2<ulong>("m_lastOnlineMicrosec");
            }
        }
    }
}

