namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("ConfigFile")]
    public class ConfigFile : MonoClass
    {
        public ConfigFile(IntPtr address) : this(address, "ConfigFile")
        {
        }

        public ConfigFile(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public bool Delete(string key, bool removeEmptySections)
        {
            object[] objArray1 = new object[] { key, removeEmptySections };
            return base.method_11<bool>("Delete", objArray1);
        }

        public Line FindEntry(string fullKey)
        {
            object[] objArray1 = new object[] { fullKey };
            return base.method_14<Line>("FindEntry", objArray1);
        }

        public int FindEntryIndex(string fullKey)
        {
            object[] objArray1 = new object[] { fullKey };
            return base.method_11<int>("FindEntryIndex", objArray1);
        }

        public int FindSectionIndex(string sectionName)
        {
            object[] objArray1 = new object[] { sectionName };
            return base.method_11<int>("FindSectionIndex", objArray1);
        }

        public bool FullLoad(string path)
        {
            object[] objArray1 = new object[] { path };
            return base.method_11<bool>("FullLoad", objArray1);
        }

        public string GenerateText()
        {
            return base.method_13("GenerateText", Array.Empty<object>());
        }

        public bool Get(string key, bool defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { key, defaultVal };
            return base.method_10<bool>("Get", enumArray1, objArray1);
        }

        public int Get(string key, int defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { key, defaultVal };
            return base.method_10<int>("Get", enumArray1, objArray1);
        }

        public float Get(string key, float defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { key, defaultVal };
            return base.method_10<float>("Get", enumArray1, objArray1);
        }

        public string Get(string key, string defaultVal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { key, defaultVal };
            return base.method_12("Get", enumArray1, objArray1);
        }

        public List<Line> GetLines()
        {
            Class267<Line> class2 = base.method_14<Class267<Line>>("GetLines", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public string GetPath()
        {
            return base.method_13("GetPath", Array.Empty<object>());
        }

        public bool Has(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("Has", objArray1);
        }

        public bool LightLoad(string path)
        {
            object[] objArray1 = new object[] { path };
            return base.method_11<bool>("LightLoad", objArray1);
        }

        public bool Load(string path, bool ignoreUselessLines)
        {
            object[] objArray1 = new object[] { path, ignoreUselessLines };
            return base.method_11<bool>("Load", objArray1);
        }

        public Line RegisterEntry(string fullKey)
        {
            object[] objArray1 = new object[] { fullKey };
            return base.method_14<Line>("RegisterEntry", objArray1);
        }

        public bool Save(string path)
        {
            object[] objArray1 = new object[] { path };
            return base.method_11<bool>("Save", objArray1);
        }

        public bool Set(string key, bool val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { key, val };
            return base.method_10<bool>("Set", enumArray1, objArray1);
        }

        public bool Set(string key, object val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Class };
            object[] objArray1 = new object[] { key, val };
            return base.method_10<bool>("Set", enumArray1, objArray1);
        }

        public bool Set(string key, string val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.String };
            object[] objArray1 = new object[] { key, val };
            return base.method_10<bool>("Set", enumArray1, objArray1);
        }

        public List<Line> m_lines
        {
            get
            {
                Class267<Line> class2 = base.method_3<Class267<Line>>("m_lines");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_path
        {
            get
            {
                return base.method_4("m_path");
            }
        }

        [Attribute38("ConfigFile.Line")]
        public class Line : MonoClass
        {
            public Line(IntPtr address) : this(address, "Line")
            {
            }

            public Line(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_fullKey
            {
                get
                {
                    return base.method_4("m_fullKey");
                }
            }

            public string m_lineKey
            {
                get
                {
                    return base.method_4("m_lineKey");
                }
            }

            public bool m_quoteValue
            {
                get
                {
                    return base.method_2<bool>("m_quoteValue");
                }
            }

            public string m_raw
            {
                get
                {
                    return base.method_4("m_raw");
                }
            }

            public string m_sectionName
            {
                get
                {
                    return base.method_4("m_sectionName");
                }
            }

            public ConfigFile.LineType m_type
            {
                get
                {
                    return base.method_2<ConfigFile.LineType>("m_type");
                }
            }

            public string m_value
            {
                get
                {
                    return base.method_4("m_value");
                }
            }
        }

        public enum LineType
        {
            UNKNOWN,
            COMMENT,
            SECTION,
            ENTRY
        }
    }
}

