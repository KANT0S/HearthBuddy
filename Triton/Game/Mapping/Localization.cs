namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Localization")]
    public class Localization : MonoClass
    {
        public Localization(IntPtr address) : this(address, "Localization")
        {
        }

        public Localization(IntPtr address, string className) : base(address, className)
        {
        }

        public static string ConvertLocaleToDotNet(string localeName)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { localeName };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "Localization", "ConvertLocaleToDotNet", enumArray1, objArray1);
        }

        public static string ConvertLocaleToDotNet(Locale locale)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { locale };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "Localization", "ConvertLocaleToDotNet", enumArray1, objArray1);
        }

        public static bool DoesLocaleUseDecimalPoint(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Localization", "DoesLocaleUseDecimalPoint", objArray1);
        }

        public static string GetBnetLocaleName()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Localization", "GetBnetLocaleName", Array.Empty<object>());
        }

        public static List<string> GetForeignLocaleNames()
        {
            Class268 class2 = MonoClass.smethod_15<Class268>(TritonHs.MainAssemblyPath, "", "Localization", "GetForeignLocaleNames", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Locale> GetForeignLocales()
        {
            Class266<Locale> class2 = MonoClass.smethod_15<Class266<Locale>>(TritonHs.MainAssemblyPath, "", "Localization", "GetForeignLocales", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Locale> GetLoadOrder(bool isCardTexture)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { isCardTexture };
            Class246<Locale> class2 = MonoClass.smethod_16<Class246<Locale>>(TritonHs.MainAssemblyPath, "", "Localization", "GetLoadOrder", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Locale> GetLoadOrder(AssetFamily family)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { family };
            Class246<Locale> class2 = MonoClass.smethod_16<Class246<Locale>>(TritonHs.MainAssemblyPath, "", "Localization", "GetLoadOrder", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Locale> GetLoadOrder(Locale locale, bool isCardTexture)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { locale, isCardTexture };
            Class246<Locale> class2 = MonoClass.smethod_16<Class246<Locale>>(TritonHs.MainAssemblyPath, "", "Localization", "GetLoadOrder", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static Locale GetLocale()
        {
            return MonoClass.smethod_14<Locale>(TritonHs.MainAssemblyPath, "", "Localization", "GetLocale", Array.Empty<object>());
        }

        public static string GetLocaleName()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Localization", "GetLocaleName", Array.Empty<object>());
        }

        public static void Initialize()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Localization", "Initialize");
        }

        public static bool IsForeignLocale(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Localization", "IsForeignLocale", objArray1);
        }

        public static bool IsForeignLocaleName(string localeName)
        {
            object[] objArray1 = new object[] { localeName };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Localization", "IsForeignLocaleName", objArray1);
        }

        public static bool IsIMELocale()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Localization", "IsIMELocale", Array.Empty<object>());
        }

        public static bool IsValidLocaleName(string localeName)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { localeName };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "Localization", "IsValidLocaleName", enumArray1, objArray1);
        }

        public static void SetLocale(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Localization", "SetLocale", objArray1);
        }

        public static bool SetLocaleName(string localeName)
        {
            object[] objArray1 = new object[] { localeName };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Localization", "SetLocaleName", objArray1);
        }

        public void SetPegLocale(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            base.method_8("SetPegLocale", objArray1);
        }

        public void SetPegLocaleName(string localeName)
        {
            object[] objArray1 = new object[] { localeName };
            base.method_8("SetPegLocaleName", objArray1);
        }

        public static Locale DEFAULT_LOCALE
        {
            get
            {
                return MonoClass.smethod_6<Locale>(TritonHs.MainAssemblyPath, "", "Localization", "DEFAULT_LOCALE");
            }
        }

        public static string DEFAULT_LOCALE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Localization", "DEFAULT_LOCALE_NAME");
            }
        }

        public List<string> m_foreignLocaleNames
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_foreignLocaleNames");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Locale> m_foreignLocales
        {
            get
            {
                Class266<Locale> class2 = base.method_3<Class266<Locale>>("m_foreignLocales");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Locale m_locale
        {
            get
            {
                return base.method_2<Locale>("m_locale");
            }
        }
    }
}

