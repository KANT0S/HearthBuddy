namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroDbfRecord")]
    public class HeroDbfRecord : DbfRecord
    {
        public HeroDbfRecord(IntPtr address) : this(address, "HeroDbfRecord")
        {
        }

        public HeroDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetCardBackId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardBackId", objArray1);
        }

        public void SetCardId(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCardId", objArray1);
        }

        public void SetDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDescription", objArray1);
        }

        public void SetHerodefAssetPath(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetHerodefAssetPath", objArray1);
        }

        public void SetStoreBought(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreBought", objArray1);
        }

        public void SetStoreDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreDescription", objArray1);
        }

        public void SetStoreTitle(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetStoreTitle", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public int CardBackId
        {
            get
            {
                return base.method_11<int>("get_CardBackId", Array.Empty<object>());
            }
        }

        public string CardId
        {
            get
            {
                return base.method_13("get_CardId", Array.Empty<object>());
            }
        }

        public DbfLocValue Description
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Description", Array.Empty<object>());
            }
        }

        public string HerodefAssetPath
        {
            get
            {
                return base.method_13("get_HerodefAssetPath", Array.Empty<object>());
            }
        }

        public int m_CardBackId
        {
            get
            {
                return base.method_2<int>("m_CardBackId");
            }
        }

        public string m_CardId
        {
            get
            {
                return base.method_4("m_CardId");
            }
        }

        public DbfLocValue m_Description
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Description");
            }
        }

        public string m_HerodefAssetPath
        {
            get
            {
                return base.method_4("m_HerodefAssetPath");
            }
        }

        public bool m_StoreBought
        {
            get
            {
                return base.method_2<bool>("m_StoreBought");
            }
        }

        public DbfLocValue m_StoreDescription
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreDescription");
            }
        }

        public DbfLocValue m_StoreTitle
        {
            get
            {
                return base.method_3<DbfLocValue>("m_StoreTitle");
            }
        }

        public bool StoreBought
        {
            get
            {
                return base.method_11<bool>("get_StoreBought", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreDescription
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreDescription", Array.Empty<object>());
            }
        }

        public DbfLocValue StoreTitle
        {
            get
            {
                return base.method_14<DbfLocValue>("get_StoreTitle", Array.Empty<object>());
            }
        }
    }
}

