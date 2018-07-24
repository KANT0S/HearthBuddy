namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FontTable")]
    public class FontTable : MonoBehaviour
    {
        public FontTable(IntPtr address) : this(address, "FontTable")
        {
        }

        public FontTable(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FinishInitialization()
        {
            base.method_8("FinishInitialization", Array.Empty<object>());
        }

        public void FireInitializedCallbacks()
        {
            base.method_8("FireInitializedCallbacks", Array.Empty<object>());
        }

        public static FontTable Get()
        {
            return MonoClass.smethod_15<FontTable>(TritonHs.MainAssemblyPath, "", "FontTable", "Get", Array.Empty<object>());
        }

        public FontDef GetFontDef(string name)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { name };
            return base.method_15<FontDef>("GetFontDef", enumArray1, objArray1);
        }

        public string GetFontDefName(string fontName)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { fontName };
            return base.method_12("GetFontDefName", enumArray1, objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsInitialized()
        {
            return base.method_11<bool>("IsInitialized", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFontDefLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnFontDefLoaded", objArray1);
        }

        public void OnInitialDefLoaded()
        {
            base.method_8("OnInitialDefLoaded", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public List<FontTableEntry> m_Entries
        {
            get
            {
                Class267<FontTableEntry> class2 = base.method_3<Class267<FontTableEntry>>("m_Entries");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_initialDefsLoading
        {
            get
            {
                return base.method_2<int>("m_initialDefsLoading");
            }
        }

        public bool m_initialized
        {
            get
            {
                return base.method_2<bool>("m_initialized");
            }
        }
    }
}

