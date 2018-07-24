namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameStrings")]
    public class GameStrings : MonoClass
    {
        public GameStrings(IntPtr address) : this(address, "GameStrings")
        {
        }

        public GameStrings(IntPtr address, string className) : base(address, className)
        {
        }

        public static void CheckConflicts(GameStringTable table)
        {
            object[] objArray1 = new object[] { table };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameStrings", "CheckConflicts", objArray1);
        }

        public static string Find(string key)
        {
            object[] objArray1 = new object[] { key };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "Find", objArray1);
        }

        public static string Get(string key)
        {
            object[] objArray1 = new object[] { key };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "Get", objArray1);
        }

        public static string GetAssetPath(Locale locale, string fileName)
        {
            object[] objArray1 = new object[] { locale, fileName };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetAssetPath", objArray1);
        }

        public static string GetCardSetName(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardSetName", objArray1);
        }

        public static string GetCardSetNameInitials(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardSetNameInitials", objArray1);
        }

        public static string GetCardSetNameKey(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardSetNameKey", objArray1);
        }

        public static string GetCardSetNameKeyShortened(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardSetNameKeyShortened", objArray1);
        }

        public static string GetCardSetNameShortened(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardSetNameShortened", objArray1);
        }

        public static string GetCardTypeName(TAG_CARDTYPE tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardTypeName", objArray1);
        }

        public static string GetCardTypeNameKey(TAG_CARDTYPE tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetCardTypeNameKey", objArray1);
        }

        public static string GetClassName(TAG_CLASS tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetClassName", objArray1);
        }

        public static string GetClassNameKey(TAG_CLASS tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetClassNameKey", objArray1);
        }

        public static string GetKeywordName(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetKeywordName", objArray1);
        }

        public static string GetKeywordNameKey(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetKeywordNameKey", objArray1);
        }

        public static string GetKeywordText(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetKeywordText", objArray1);
        }

        public static string GetKeywordTextKey(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetKeywordTextKey", objArray1);
        }

        public static int GetPluralIndex(int number)
        {
            object[] objArray1 = new object[] { number };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameStrings", "GetPluralIndex", objArray1);
        }

        public static string GetRaceName(TAG_RACE tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRaceName", objArray1);
        }

        public static string GetRaceNameKey(TAG_RACE tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRaceNameKey", objArray1);
        }

        public static string GetRandomTip(TipCategory tipCategory)
        {
            object[] objArray1 = new object[] { tipCategory };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRandomTip", objArray1);
        }

        public static string GetRarityText(TAG_RARITY tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRarityText", objArray1);
        }

        public static string GetRarityTextKey(TAG_RARITY tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRarityTextKey", objArray1);
        }

        public static string GetRefKeywordText(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRefKeywordText", objArray1);
        }

        public static string GetRefKeywordTextKey(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetRefKeywordTextKey", objArray1);
        }

        public static string GetTip(TipCategory tipCategory, int progress, TipCategory randomTipCategory)
        {
            object[] objArray1 = new object[] { tipCategory, progress, randomTipCategory };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GameStrings", "GetTip", objArray1);
        }

        public static bool HasCardSetName(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasCardSetName", objArray1);
        }

        public static bool HasCardSetNameInitials(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasCardSetNameInitials", objArray1);
        }

        public static bool HasCardSetNameShortened(TAG_CARD_SET tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasCardSetNameShortened", objArray1);
        }

        public static bool HasCardTypeName(TAG_CARDTYPE tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasCardTypeName", objArray1);
        }

        public static bool HasClassName(TAG_CLASS tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasClassName", objArray1);
        }

        public static bool HasKey(string key)
        {
            object[] objArray1 = new object[] { key };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasKey", objArray1);
        }

        public static bool HasKeywordName(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasKeywordName", objArray1);
        }

        public static bool HasKeywordText(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasKeywordText", objArray1);
        }

        public static bool HasRaceName(TAG_RACE tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasRaceName", objArray1);
        }

        public static bool HasRarityText(TAG_RARITY tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasRarityText", objArray1);
        }

        public static bool HasRefKeywordText(GAME_TAG tag)
        {
            object[] objArray1 = new object[] { tag };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "HasRefKeywordText", objArray1);
        }

        public static void LoadAll()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameStrings", "LoadAll");
        }

        public static bool LoadCategory(GameStringCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "LoadCategory", objArray1);
        }

        public static string ParseLanguageRules(string str)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "GameStrings", "ParseLanguageRules", enumArray1, objArray1);
        }

        public static void ReloadAll()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameStrings", "ReloadAll");
        }

        public static bool UnloadCategory(GameStringCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GameStrings", "UnloadCategory", objArray1);
        }

        public static void WillReset()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameStrings", "WillReset");
        }

        public static List<char> LANGUAGE_RULE_ARG_DELIMITERS
        {
            get
            {
                Class246<char> class2 = MonoClass.smethod_7<Class246<char>>(TritonHs.MainAssemblyPath, "", "GameStrings", "LANGUAGE_RULE_ARG_DELIMITERS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string NUMBER_PATTERN
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameStrings", "NUMBER_PATTERN");
            }
        }

        public static string s_UnknownName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameStrings", "s_UnknownName");
            }
        }

        [Attribute38("GameStrings.PluralNumber")]
        public class PluralNumber : MonoClass
        {
            public PluralNumber(IntPtr address) : this(address, "PluralNumber")
            {
            }

            public PluralNumber(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_index
            {
                get
                {
                    return base.method_2<int>("m_index");
                }
            }

            public int m_number
            {
                get
                {
                    return base.method_2<int>("m_number");
                }
            }

            public bool m_useForOnlyThisIndex
            {
                get
                {
                    return base.method_2<bool>("m_useForOnlyThisIndex");
                }
            }
        }
    }
}

