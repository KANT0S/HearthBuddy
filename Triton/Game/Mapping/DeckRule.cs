namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckRule")]
    public class DeckRule : MonoClass
    {
        public DeckRule(IntPtr address) : this(address, "DeckRule")
        {
        }

        public DeckRule(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AppliesTo(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            return base.method_11<bool>("AppliesTo", objArray1);
        }

        public bool CanRemoveFromDeck(EntityDef def, CollectionDeck deck)
        {
            object[] objArray1 = new object[] { def, deck };
            return base.method_11<bool>("CanRemoveFromDeck", objArray1);
        }

        public static DeckRule CreateFromDBF(DeckRulesetRuleDbfRecord record)
        {
            object[] objArray1 = new object[] { record };
            return MonoClass.smethod_15<DeckRule>(TritonHs.MainAssemblyPath, "", "DeckRule", "CreateFromDBF", objArray1);
        }

        public bool Filter(EntityDef def)
        {
            object[] objArray1 = new object[] { def };
            return base.method_11<bool>("Filter", objArray1);
        }

        public bool GetResult(bool val)
        {
            object[] objArray1 = new object[] { val };
            return base.method_11<bool>("GetResult", objArray1);
        }

        public static DeckRule GetRule(DeckRulesetRuleDbfRecord record)
        {
            object[] objArray1 = new object[] { record };
            return MonoClass.smethod_15<DeckRule>(TritonHs.MainAssemblyPath, "", "DeckRule", "GetRule", objArray1);
        }

        public RuleType GetRuleType()
        {
            return base.method_11<RuleType>("GetRuleType", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool m_appliesToIsNot
        {
            get
            {
                return base.method_2<bool>("m_appliesToIsNot");
            }
        }

        public int m_appliesToSubsetId
        {
            get
            {
                return base.method_2<int>("m_appliesToSubsetId");
            }
        }

        public int m_deckBuilderId
        {
            get
            {
                return base.method_2<int>("m_deckBuilderId");
            }
        }

        public string m_errorString
        {
            get
            {
                return base.method_4("m_errorString");
            }
        }

        public int m_id
        {
            get
            {
                return base.method_2<int>("m_id");
            }
        }

        public int m_maxValue
        {
            get
            {
                return base.method_2<int>("m_maxValue");
            }
        }

        public int m_minValue
        {
            get
            {
                return base.method_2<int>("m_minValue");
            }
        }

        public bool m_ruleIsNot
        {
            get
            {
                return base.method_2<bool>("m_ruleIsNot");
            }
        }

        public RuleType m_ruleType
        {
            get
            {
                return base.method_2<RuleType>("m_ruleType");
            }
        }

        public string m_stringValue
        {
            get
            {
                return base.method_4("m_stringValue");
            }
        }

        public int m_tag
        {
            get
            {
                return base.method_2<int>("m_tag");
            }
        }

        public int m_tagMaxValue
        {
            get
            {
                return base.method_2<int>("m_tagMaxValue");
            }
        }

        public int m_tagMinValue
        {
            get
            {
                return base.method_2<int>("m_tagMinValue");
            }
        }

        public enum RuleType
        {
            IS_IN_ANY_SUBSET,
            COUNT_COPIES_OF_EACH_CARD,
            PLAYER_OWNS_EACH_COPY,
            IS_CLASS_CARD_OR_NEUTRAL,
            COUNT_CARDS_IN_DECK,
            HAS_TAG_VALUE,
            DECK_SIZE,
            UNKNOWN
        }
    }
}

