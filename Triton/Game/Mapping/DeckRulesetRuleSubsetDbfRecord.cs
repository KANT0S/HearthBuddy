namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRulesetRuleSubsetDbfRecord")]
    public class DeckRulesetRuleSubsetDbfRecord : DbfRecord
    {
        public DeckRulesetRuleSubsetDbfRecord(IntPtr address) : this(address, "DeckRulesetRuleSubsetDbfRecord")
        {
        }

        public DeckRulesetRuleSubsetDbfRecord(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetVar(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<object>("GetVar", objArray1);
        }

        public System.Type GetVarType(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<System.Type>("GetVarType", objArray1);
        }

        public void SetDeckRulesetRuleId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDeckRulesetRuleId", objArray1);
        }

        public void SetSubsetId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSubsetId", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int DeckRulesetRuleId
        {
            get
            {
                return base.method_11<int>("get_DeckRulesetRuleId", Array.Empty<object>());
            }
        }

        public int m_DeckRulesetRuleId
        {
            get
            {
                return base.method_2<int>("m_DeckRulesetRuleId");
            }
        }

        public int m_SubsetId
        {
            get
            {
                return base.method_2<int>("m_SubsetId");
            }
        }

        public int SubsetId
        {
            get
            {
                return base.method_11<int>("get_SubsetId", Array.Empty<object>());
            }
        }
    }
}

