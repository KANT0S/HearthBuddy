namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckMaker")]
    public class DeckMaker : MonoClass
    {
        public DeckMaker(IntPtr address) : this(address, "DeckMaker")
        {
        }

        public DeckMaker(IntPtr address, string className) : base(address, className)
        {
        }

        public static DeckChoiceFill GetFillCardChoices(CollectionDeck deck, EntityDef referenceCard, int choices, DeckBuilder deckBuilder)
        {
            object[] objArray1 = new object[] { deck, referenceCard, choices, deckBuilder };
            return MonoClass.smethod_15<DeckChoiceFill>(TritonHs.MainAssemblyPath, "", "DeckMaker", "GetFillCardChoices", objArray1);
        }

        public static bool HasMaxCost(EntityDef e, int maxCost)
        {
            object[] objArray1 = new object[] { e, maxCost };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckMaker", "HasMaxCost", objArray1);
        }

        public static bool HasMinCost(EntityDef e, int minCost)
        {
            object[] objArray1 = new object[] { e, minCost };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckMaker", "HasMinCost", objArray1);
        }

        public static bool IsMinion(EntityDef e)
        {
            object[] objArray1 = new object[] { e };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckMaker", "IsMinion", objArray1);
        }

        public static bool IsSpell(EntityDef e)
        {
            object[] objArray1 = new object[] { e };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckMaker", "IsSpell", objArray1);
        }

        public static bool IsWeapon(EntityDef e)
        {
            object[] objArray1 = new object[] { e };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "DeckMaker", "IsWeapon", objArray1);
        }

        public static List<CardRequirements> s_OrderedCardRequirements
        {
            get
            {
                Class247<CardRequirements> class2 = MonoClass.smethod_7<Class247<CardRequirements>>(TritonHs.MainAssemblyPath, "", "DeckMaker", "s_OrderedCardRequirements");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static int s_preChoiceRandomizationMultipler
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckMaker", "s_preChoiceRandomizationMultipler");
            }
        }

        public static int s_priorityWeightDifference
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckMaker", "s_priorityWeightDifference");
            }
        }

        [Attribute38("DeckMaker.CardRequirements")]
        public class CardRequirements : MonoClass
        {
            public CardRequirements(IntPtr address) : this(address, "CardRequirements")
            {
            }

            public CardRequirements(IntPtr address, string className) : base(address, className)
            {
            }

            public string GetRequirementReason()
            {
                return base.method_13("GetRequirementReason", Array.Empty<object>());
            }

            public string m_reason
            {
                get
                {
                    return base.method_4("m_reason");
                }
            }

            public int m_requiredCount
            {
                get
                {
                    return base.method_2<int>("m_requiredCount");
                }
            }
        }

        [Attribute38("DeckMaker.DeckChoiceFill")]
        public class DeckChoiceFill : MonoClass
        {
            public DeckChoiceFill(IntPtr address) : this(address, "DeckChoiceFill")
            {
            }

            public DeckChoiceFill(IntPtr address, string className) : base(address, className)
            {
            }

            public DeckMaker.DeckFill GetDeckFillChoice(int idx)
            {
                object[] objArray1 = new object[] { idx };
                return base.method_14<DeckMaker.DeckFill>("GetDeckFillChoice", objArray1);
            }

            public List<EntityDef> m_addChoices
            {
                get
                {
                    Class267<EntityDef> class2 = base.method_3<Class267<EntityDef>>("m_addChoices");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public string m_reason
            {
                get
                {
                    return base.method_4("m_reason");
                }
            }

            public EntityDef m_removeTemplate
            {
                get
                {
                    return base.method_3<EntityDef>("m_removeTemplate");
                }
            }
        }

        [Attribute38("DeckMaker.DeckFill")]
        public class DeckFill : MonoClass
        {
            public DeckFill(IntPtr address) : this(address, "DeckFill")
            {
            }

            public DeckFill(IntPtr address, string className) : base(address, className)
            {
            }

            public EntityDef m_addCard
            {
                get
                {
                    return base.method_3<EntityDef>("m_addCard");
                }
            }

            public string m_reason
            {
                get
                {
                    return base.method_4("m_reason");
                }
            }

            public EntityDef m_removeTemplate
            {
                get
                {
                    return base.method_3<EntityDef>("m_removeTemplate");
                }
            }
        }

        [Attribute38("DeckMaker.SortableEntityDef")]
        public class SortableEntityDef : MonoClass
        {
            public SortableEntityDef(IntPtr address) : this(address, "SortableEntityDef")
            {
            }

            public SortableEntityDef(IntPtr address, string className) : base(address, className)
            {
            }

            public EntityDef m_entityDef
            {
                get
                {
                    return base.method_3<EntityDef>("m_entityDef");
                }
            }

            public int m_suggestWeight
            {
                get
                {
                    return base.method_2<int>("m_suggestWeight");
                }
            }
        }
    }
}

