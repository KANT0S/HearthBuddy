namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckBuilder")]
    public class DeckBuilder : MonoClass
    {
        public DeckBuilder(IntPtr address) : this(address, "DeckBuilder")
        {
        }

        public DeckBuilder(IntPtr address, string className) : base(address, className)
        {
        }

        public static DeckBuilder BuildStandardRuleSet()
        {
            return MonoClass.smethod_15<DeckBuilder>(TritonHs.MainAssemblyPath, "", "DeckBuilder", "BuildStandardRuleSet", Array.Empty<object>());
        }

        public bool Filter(EntityDef entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("Filter", objArray1);
        }

        public static DeckBuilder GetDeckBuilder(int id)
        {
            object[] objArray1 = new object[] { id };
            return MonoClass.smethod_15<DeckBuilder>(TritonHs.MainAssemblyPath, "", "DeckBuilder", "GetDeckBuilder", objArray1);
        }

        public int GetDeckSize()
        {
            return base.method_11<int>("GetDeckSize", Array.Empty<object>());
        }

        public static DeckBuilder GetStandardRuleSet()
        {
            return MonoClass.smethod_15<DeckBuilder>(TritonHs.MainAssemblyPath, "", "DeckBuilder", "GetStandardRuleSet", Array.Empty<object>());
        }

        public bool IsDeckValid(CollectionDeck deck)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deck };
            return base.method_10<bool>("IsDeckValid", enumArray1, objArray1);
        }

        public int Id
        {
            get
            {
                return base.method_11<int>("get_Id", Array.Empty<object>());
            }
        }

        public CollectionDeck m_editingDeck
        {
            get
            {
                return base.method_3<CollectionDeck>("m_editingDeck");
            }
        }

        public int m_id
        {
            get
            {
                return base.method_2<int>("m_id");
            }
        }

        public List<DeckRule> m_rules
        {
            get
            {
                Class267<DeckRule> class2 = base.method_3<Class267<DeckRule>>("m_rules");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<DeckRule> Rules
        {
            get
            {
                Class267<DeckRule> class2 = base.method_14<Class267<DeckRule>>("get_Rules", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static DeckBuilder s_standardRuleSet
        {
            get
            {
                return MonoClass.smethod_7<DeckBuilder>(TritonHs.MainAssemblyPath, "", "DeckBuilder", "s_standardRuleSet");
            }
        }

        public enum PredefinedRuleSet
        {
            StandardRuleSet = 1
        }
    }
}

