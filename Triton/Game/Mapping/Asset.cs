namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("Asset")]
    public class Asset : MonoClass
    {
        public Asset(IntPtr address) : this(address, "Asset")
        {
        }

        public Asset(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetDirectory()
        {
            return base.method_13("GetDirectory", Array.Empty<object>());
        }

        public List<string> GetExtensions()
        {
            Class245 class2 = base.method_14<Class245>("GetExtensions", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public AssetFamily GetFamily()
        {
            return base.method_11<AssetFamily>("GetFamily", Array.Empty<object>());
        }

        public Locale GetLocale()
        {
            return base.method_11<Locale>("GetLocale", Array.Empty<object>());
        }

        public string GetName()
        {
            return base.method_13("GetName", Array.Empty<object>());
        }

        public string GetPath()
        {
            return base.method_12("GetPath", new Class272.Enum20[0], Array.Empty<object>());
        }

        public string GetPath(Locale locale)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { locale };
            return base.method_12("GetPath", enumArray1, objArray1);
        }

        public bool IsPersistent()
        {
            return base.method_11<bool>("IsPersistent", Array.Empty<object>());
        }

        public void SetLocale(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            base.method_8("SetLocale", objArray1);
        }

        public AssetFamily m_family
        {
            get
            {
                return base.method_2<AssetFamily>("m_family");
            }
        }

        public Locale m_locale
        {
            get
            {
                return base.method_2<Locale>("m_locale");
            }
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public string m_path
        {
            get
            {
                return base.method_4("m_path");
            }
        }

        public bool m_persistent
        {
            get
            {
                return base.method_2<bool>("m_persistent");
            }
        }
    }
}

