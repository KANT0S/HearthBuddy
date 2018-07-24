namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameStringTable")]
    public class GameStringTable : MonoClass
    {
        public GameStringTable(IntPtr address) : this(address, "GameStringTable")
        {
        }

        public GameStringTable(IntPtr address, string className) : base(address, className)
        {
        }

        public string Get(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_13("Get", objArray1);
        }

        public static string GetAudioFilePathFromCategory(GameStringCategory cat, Locale locale)
        {
            object[] objArray1 = new object[] { cat, locale };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStringTable", "GetAudioFilePathFromCategory", objArray1);
        }

        public GameStringCategory GetCategory()
        {
            return base.method_11<GameStringCategory>("GetCategory", Array.Empty<object>());
        }

        public static string GetFilePathFromCategory(GameStringCategory cat, Locale locale)
        {
            object[] objArray1 = new object[] { cat, locale };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStringTable", "GetFilePathFromCategory", objArray1);
        }

        public bool Load(GameStringCategory cat)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cat };
            return base.method_10<bool>("Load", enumArray1, objArray1);
        }

        public bool Load(GameStringCategory cat, Locale locale)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cat, locale };
            return base.method_10<bool>("Load", enumArray1, objArray1);
        }

        public bool Load(GameStringCategory cat, string path, string audioPath)
        {
            object[] objArray1 = new object[] { cat, path, audioPath };
            return base.method_10<bool>("Load", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public static string KEY_FIELD_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameStringTable", "KEY_FIELD_NAME");
            }
        }

        public GameStringCategory m_category
        {
            get
            {
                return base.method_2<GameStringCategory>("m_category");
            }
        }

        public static string VALUE_FIELD_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameStringTable", "VALUE_FIELD_NAME");
            }
        }

        [Attribute38("GameStringTable.Entry")]
        public class Entry : MonoClass
        {
            public Entry(IntPtr address) : this(address, "Entry")
            {
            }

            public Entry(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_key
            {
                get
                {
                    return base.method_4("m_key");
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
    }
}

