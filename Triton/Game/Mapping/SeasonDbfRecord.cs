namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SeasonDbfRecord")]
    public class SeasonDbfRecord : DbfRecord
    {
        public SeasonDbfRecord(IntPtr address) : this(address, "SeasonDbfRecord")
        {
        }

        public SeasonDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetName", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetSeasonStartName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSeasonStartName", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public DbfLocValue m_Name
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Name");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public DbfLocValue m_SeasonStartName
        {
            get
            {
                return base.method_3<DbfLocValue>("m_SeasonStartName");
            }
        }

        public DbfLocValue Name
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Name", Array.Empty<object>());
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public DbfLocValue SeasonStartName
        {
            get
            {
                return base.method_14<DbfLocValue>("get_SeasonStartName", Array.Empty<object>());
            }
        }
    }
}

