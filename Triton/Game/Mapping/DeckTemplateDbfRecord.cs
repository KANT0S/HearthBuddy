namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckTemplateDbfRecord")]
    public class DeckTemplateDbfRecord : DbfRecord
    {
        public DeckTemplateDbfRecord(IntPtr address) : this(address, "DeckTemplateDbfRecord")
        {
        }

        public DeckTemplateDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetClassId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetClassId", objArray1);
        }

        public void SetDeckId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDeckId", objArray1);
        }

        public void SetDisplayTexture(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDisplayTexture", objArray1);
        }

        public void SetEvent(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetEvent", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int ClassId
        {
            get
            {
                return base.method_11<int>("get_ClassId", Array.Empty<object>());
            }
        }

        public int DeckId
        {
            get
            {
                return base.method_11<int>("get_DeckId", Array.Empty<object>());
            }
        }

        public string DisplayTexture
        {
            get
            {
                return base.method_13("get_DisplayTexture", Array.Empty<object>());
            }
        }

        public string Event
        {
            get
            {
                return base.method_13("get_Event", Array.Empty<object>());
            }
        }

        public int m_ClassId
        {
            get
            {
                return base.method_2<int>("m_ClassId");
            }
        }

        public int m_DeckId
        {
            get
            {
                return base.method_2<int>("m_DeckId");
            }
        }

        public string m_DisplayTexture
        {
            get
            {
                return base.method_4("m_DisplayTexture");
            }
        }

        public string m_Event
        {
            get
            {
                return base.method_4("m_Event");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }
    }
}

