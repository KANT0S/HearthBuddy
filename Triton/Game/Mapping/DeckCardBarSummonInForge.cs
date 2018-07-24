namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckCardBarSummonInForge")]
    public class DeckCardBarSummonInForge : SpellImpl
    {
        public DeckCardBarSummonInForge(IntPtr address) : this(address, "DeckCardBarSummonInForge")
        {
        }

        public DeckCardBarSummonInForge(IntPtr address, string className) : base(address, className)
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
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "COMMON_COLOR");
            }
        }

        public static Color COMMON_TINT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "COMMON_TINT_COLOR");
            }
        }

        public static Color EPIC_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "EPIC_COLOR");
            }
        }

        public static Color EPIC_TINT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "EPIC_TINT_COLOR");
            }
        }

        public static Color LEGENDARY_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "LEGENDARY_COLOR");
            }
        }

        public static Color LEGENDARY_TINT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "LEGENDARY_TINT_COLOR");
            }
        }

        public GameObject m_echoQuad
        {
            get
            {
                return base.method_3<GameObject>("m_echoQuad");
            }
        }

        public Material m_echoQuadMaterial
        {
            get
            {
                return base.method_3<Material>("m_echoQuadMaterial");
            }
        }

        public GameObject m_fxEvaporate
        {
            get
            {
                return base.method_3<GameObject>("m_fxEvaporate");
            }
        }

        public Material m_fxEvaporateMaterial
        {
            get
            {
                return base.method_3<Material>("m_fxEvaporateMaterial");
            }
        }

        public static Color RARE_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "RARE_COLOR");
            }
        }

        public static Color RARE_TINT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "DeckCardBarSummonInForge", "RARE_TINT_COLOR");
            }
        }
    }
}

