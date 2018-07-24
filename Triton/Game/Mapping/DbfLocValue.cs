namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DbfLocValue")]
    public class DbfLocValue : MonoClass
    {
        public DbfLocValue(IntPtr address) : this(address, "DbfLocValue")
        {
        }

        public DbfLocValue(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetLocId()
        {
            return base.method_11<int>("GetLocId", Array.Empty<object>());
        }

        public string GetString(bool defaultToLoadOrder)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { defaultToLoadOrder };
            return base.method_12("GetString", enumArray1, objArray1);
        }

        public string GetString(Locale loc, bool defaultToLoadOrder)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { loc, defaultToLoadOrder };
            return base.method_12("GetString", enumArray1, objArray1);
        }

        public static string op_Implicit(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "DbfLocValue", "op_Implicit", objArray1);
        }

        public void SetDebugInfo(int recordId, string recordColumn)
        {
            object[] objArray1 = new object[] { recordId, recordColumn };
            base.method_8("SetDebugInfo", objArray1);
        }

        public void SetLocId(int locId)
        {
            object[] objArray1 = new object[] { locId };
            base.method_8("SetLocId", objArray1);
        }

        public void SetString(string value)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { value };
            base.method_9("SetString", enumArray1, objArray1);
        }

        public void SetString(Locale loc, string value)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.String };
            object[] objArray1 = new object[] { loc, value };
            base.method_9("SetString", enumArray1, objArray1);
        }

        public bool m_hideDebugInfo
        {
            get
            {
                return base.method_2<bool>("m_hideDebugInfo");
            }
        }

        public int m_locId
        {
            get
            {
                return base.method_2<int>("m_locId");
            }
        }

        public string m_recordColumn
        {
            get
            {
                return base.method_4("m_recordColumn");
            }
        }

        public int m_recordId
        {
            get
            {
                return base.method_2<int>("m_recordId");
            }
        }
    }
}

