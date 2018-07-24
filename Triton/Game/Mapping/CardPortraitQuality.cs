namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardPortraitQuality")]
    public class CardPortraitQuality : MonoClass
    {
        public CardPortraitQuality(IntPtr address) : this(address, "CardPortraitQuality")
        {
        }

        public CardPortraitQuality(IntPtr address, string className) : base(address, className)
        {
        }

        public static CardPortraitQuality GetDefault()
        {
            return MonoClass.smethod_15<CardPortraitQuality>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "GetDefault", Array.Empty<object>());
        }

        public static CardPortraitQuality GetFromDef(CardDef def)
        {
            object[] objArray1 = new object[] { def };
            return MonoClass.smethod_15<CardPortraitQuality>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "GetFromDef", objArray1);
        }

        public static CardPortraitQuality GetUnloaded()
        {
            return MonoClass.smethod_15<CardPortraitQuality>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "GetUnloaded", Array.Empty<object>());
        }

        public static bool op_GreaterThanOrEqual(CardPortraitQuality left, CardPortraitQuality right)
        {
            object[] objArray1 = new object[] { left, right };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "op_GreaterThanOrEqual", objArray1);
        }

        public static bool op_LessThanOrEqual(CardPortraitQuality left, CardPortraitQuality right)
        {
            object[] objArray1 = new object[] { left, right };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "op_LessThanOrEqual", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public static int HIGH
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "HIGH");
            }
        }

        public bool LoadPremium
        {
            get
            {
                return base.method_2<bool>("LoadPremium");
            }
        }

        public static int LOW
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "LOW");
            }
        }

        public static int MEDIUM
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "MEDIUM");
            }
        }

        public static int NOT_LOADED
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CardPortraitQuality", "NOT_LOADED");
            }
        }

        public int TextureQuality
        {
            get
            {
                return base.method_2<int>("TextureQuality");
            }
        }
    }
}

