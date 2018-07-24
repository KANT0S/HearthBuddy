namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("LocalOptions")]
    public class LocalOptions : MonoClass
    {
        public LocalOptions(IntPtr address) : this(address, "LocalOptions")
        {
        }

        public LocalOptions(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public void Delete(string key)
        {
            object[] objArray1 = new object[] { key };
            base.method_8("Delete", objArray1);
        }

        public static LocalOptions Get()
        {
            return MonoClass.smethod_15<LocalOptions>(TritonHs.MainAssemblyPath, "", "LocalOptions", "Get", Array.Empty<object>());
        }

        public bool GetBool(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("GetBool", objArray1);
        }

        public float GetFloat(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<float>("GetFloat", objArray1);
        }

        public int GetInt(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<int>("GetInt", objArray1);
        }

        public long GetLong(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<long>("GetLong", objArray1);
        }

        public string GetString(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_13("GetString", objArray1);
        }

        public ulong GetULong(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<ulong>("GetULong", objArray1);
        }

        public bool Has(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("Has", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public int KeyComparison(string key1, string key2)
        {
            object[] objArray1 = new object[] { key1, key2 };
            return base.method_11<int>("KeyComparison", objArray1);
        }

        public bool Load()
        {
            return base.method_11<bool>("Load", Array.Empty<object>());
        }

        public bool Save()
        {
            return base.method_10<bool>("Save", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool Save(string triggerKey)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { triggerKey };
            return base.method_10<bool>("Save", enumArray1, objArray1);
        }

        public void Set(string key, object val)
        {
            object[] objArray1 = new object[] { key, val };
            base.method_8("Set", objArray1);
        }

        public void SortKeys()
        {
            base.method_8("SortKeys", Array.Empty<object>());
        }

        public static int LOAD_LINE_FAIL_THRESHOLD
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "LocalOptions", "LOAD_LINE_FAIL_THRESHOLD");
            }
        }

        public int m_currentLineVersion
        {
            get
            {
                return base.method_2<int>("m_currentLineVersion");
            }
        }

        public bool m_dirty
        {
            get
            {
                return base.method_2<bool>("m_dirty");
            }
        }

        public List<LineParser> m_lineParsers
        {
            get
            {
                Class247<LineParser> class2 = base.method_3<Class247<LineParser>>("m_lineParsers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public LoadResult m_loadResult
        {
            get
            {
                return base.method_2<LoadResult>("m_loadResult");
            }
        }

        public string m_path
        {
            get
            {
                return base.method_4("m_path");
            }
        }

        public List<string> m_sortedKeys
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_sortedKeys");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string OPTIONS_FILE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "LocalOptions", "OPTIONS_FILE_NAME");
            }
        }

        [Attribute38("LocalOptions.LineParser")]
        public class LineParser : MonoClass
        {
            public LineParser(IntPtr address) : this(address, "LineParser")
            {
            }

            public LineParser(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_pattern
            {
                get
                {
                    return base.method_4("m_pattern");
                }
            }

            public Regex m_regex
            {
                get
                {
                    return base.method_3<Regex>("m_regex");
                }
            }
        }

        public enum LoadResult
        {
            INVALID,
            SUCCESS,
            FAIL
        }
    }
}

