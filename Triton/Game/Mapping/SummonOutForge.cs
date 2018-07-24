namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SummonOutForge")]
    public class SummonOutForge : SpellImpl
    {
        public SummonOutForge(IntPtr address) : this(address, "SummonOutForge")
        {
        }

        public SummonOutForge(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public static Color COMMON_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "SummonOutForge", "COMMON_COLOR");
            }
        }

        public static Color EPIC_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "SummonOutForge", "EPIC_COLOR");
            }
        }

        public static Color LEGENDARY_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "SummonOutForge", "LEGENDARY_COLOR");
            }
        }

        public GameObject m_burstMotes
        {
            get
            {
                return base.method_3<GameObject>("m_burstMotes");
            }
        }

        public GameObject m_scryLines
        {
            get
            {
                return base.method_3<GameObject>("m_scryLines");
            }
        }

        public Material m_scryLinesMaterial
        {
            get
            {
                return base.method_3<Material>("m_scryLinesMaterial");
            }
        }

        public static Color RARE_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "SummonOutForge", "RARE_COLOR");
            }
        }
    }
}

