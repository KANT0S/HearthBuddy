namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DraftManaCurve")]
    public class DraftManaCurve : MonoBehaviour
    {
        public DraftManaCurve(IntPtr address) : this(address, "DraftManaCurve")
        {
        }

        public DraftManaCurve(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCardOfCost(int cost)
        {
            object[] objArray1 = new object[] { cost };
            base.method_8("AddCardOfCost", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ResetBars()
        {
            base.method_8("ResetBars", Array.Empty<object>());
        }

        public void UpdateBars()
        {
            base.method_8("UpdateBars", Array.Empty<object>());
        }

        public List<ManaCostBar> m_bars
        {
            get
            {
                Class267<ManaCostBar> class2 = base.method_3<Class267<ManaCostBar>>("m_bars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<int> m_manaCosts
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_manaCosts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static int MAX_CARDS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DraftManaCurve", "MAX_CARDS");
            }
        }

        public static float SIZE_PER_CARD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DraftManaCurve", "SIZE_PER_CARD");
            }
        }
    }
}

