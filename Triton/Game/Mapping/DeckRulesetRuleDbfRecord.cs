namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRulesetRuleDbfRecord")]
    public class DeckRulesetRuleDbfRecord : DbfRecord
    {
        public DeckRulesetRuleDbfRecord(IntPtr address) : this(address, "DeckRulesetRuleDbfRecord")
        {
        }

        public DeckRulesetRuleDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAppliesToIsNot(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAppliesToIsNot", objArray1);
        }

        public void SetAppliesToSubsetId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAppliesToSubsetId", objArray1);
        }

        public void SetDeckRulesetId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDeckRulesetId", objArray1);
        }

        public void SetErrorString(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetErrorString", objArray1);
        }

        public void SetMaxValue(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetMaxValue", objArray1);
        }

        public void SetMinValue(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetMinValue", objArray1);
        }

        public void SetRuleIsNot(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRuleIsNot", objArray1);
        }

        public void SetRuleType(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetRuleType", objArray1);
        }

        public void SetStringValue(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStringValue", objArray1);
        }

        public void SetTag(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTag", objArray1);
        }

        public void SetTagMaxValue(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTagMaxValue", objArray1);
        }

        public void SetTagMinValue(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTagMinValue", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public bool AppliesToIsNot
        {
            get
            {
                return base.method_11<bool>("get_AppliesToIsNot", Array.Empty<object>());
            }
        }

        public int AppliesToSubsetId
        {
            get
            {
                return base.method_11<int>("get_AppliesToSubsetId", Array.Empty<object>());
            }
        }

        public int DeckRulesetId
        {
            get
            {
                return base.method_11<int>("get_DeckRulesetId", Array.Empty<object>());
            }
        }

        public DbfLocValue ErrorString
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ErrorString", Array.Empty<object>());
            }
        }

        public bool m_AppliesToIsNot
        {
            get
            {
                return base.method_2<bool>("m_AppliesToIsNot");
            }
        }

        public int m_AppliesToSubsetId
        {
            get
            {
                return base.method_2<int>("m_AppliesToSubsetId");
            }
        }

        public int m_DeckRulesetId
        {
            get
            {
                return base.method_2<int>("m_DeckRulesetId");
            }
        }

        public DbfLocValue m_ErrorString
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ErrorString");
            }
        }

        public int m_MaxValue
        {
            get
            {
                return base.method_2<int>("m_MaxValue");
            }
        }

        public int m_MinValue
        {
            get
            {
                return base.method_2<int>("m_MinValue");
            }
        }

        public bool m_RuleIsNot
        {
            get
            {
                return base.method_2<bool>("m_RuleIsNot");
            }
        }

        public string m_RuleType
        {
            get
            {
                return base.method_4("m_RuleType");
            }
        }

        public string m_StringValue
        {
            get
            {
                return base.method_4("m_StringValue");
            }
        }

        public int m_Tag
        {
            get
            {
                return base.method_2<int>("m_Tag");
            }
        }

        public int m_TagMaxValue
        {
            get
            {
                return base.method_2<int>("m_TagMaxValue");
            }
        }

        public int m_TagMinValue
        {
            get
            {
                return base.method_2<int>("m_TagMinValue");
            }
        }

        public int MaxValue
        {
            get
            {
                return base.method_11<int>("get_MaxValue", Array.Empty<object>());
            }
        }

        public int MinValue
        {
            get
            {
                return base.method_11<int>("get_MinValue", Array.Empty<object>());
            }
        }

        public bool RuleIsNot
        {
            get
            {
                return base.method_11<bool>("get_RuleIsNot", Array.Empty<object>());
            }
        }

        public string RuleType
        {
            get
            {
                return base.method_13("get_RuleType", Array.Empty<object>());
            }
        }

        public string StringValue
        {
            get
            {
                return base.method_13("get_StringValue", Array.Empty<object>());
            }
        }

        public int Tag
        {
            get
            {
                return base.method_11<int>("get_Tag", Array.Empty<object>());
            }
        }

        public int TagMaxValue
        {
            get
            {
                return base.method_11<int>("get_TagMaxValue", Array.Empty<object>());
            }
        }

        public int TagMinValue
        {
            get
            {
                return base.method_11<int>("get_TagMinValue", Array.Empty<object>());
            }
        }
    }
}

