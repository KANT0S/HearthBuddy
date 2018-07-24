namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TextUtils")]
    public class TextUtils : MonoClass
    {
        public TextUtils(IntPtr address) : this(address, "TextUtils")
        {
        }

        public TextUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static int CountCharInString(string s, char c)
        {
            object[] objArray1 = new object[] { s, c };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "TextUtils", "CountCharInString", objArray1);
        }

        public static string DecodeWhitespaces(string text)
        {
            object[] objArray1 = new object[] { text };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TextUtils", "DecodeWhitespaces", objArray1);
        }

        public static string EncodeWhitespaces(string text)
        {
            object[] objArray1 = new object[] { text };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TextUtils", "EncodeWhitespaces", objArray1);
        }

        public static string FromHexString(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TextUtils", "FromHexString", objArray1);
        }

        public static int GetHexValue(char hex)
        {
            object[] objArray1 = new object[] { hex };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "TextUtils", "GetHexValue", objArray1);
        }

        public static bool HasBonusDamage(string powersText)
        {
            object[] objArray1 = new object[] { powersText };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "TextUtils", "HasBonusDamage", objArray1);
        }

        public static string Slice(string str, int start)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { str, start };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TextUtils", "Slice", enumArray1, objArray1);
        }

        public static string Slice(string str, int start, int end)
        {
            object[] objArray1 = new object[] { str, start, end };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TextUtils", "Slice", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public static string ToHexString(string str)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TextUtils", "ToHexString", enumArray1, objArray1);
        }

        public static string TransformCardText(Triton.Game.Mapping.Entity entity, GAME_TAG textTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entity, textTag };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TextUtils", "TransformCardText", enumArray1, objArray1);
        }

        public static string TransformCardText(EntityDef entityDef, GAME_TAG textTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entityDef, textTag };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TextUtils", "TransformCardText", enumArray1, objArray1);
        }

        public static string TransformCardText(int damageBonus, int damageBonusDouble, int healingDouble, string powersText)
        {
            object[] objArray1 = new object[] { damageBonus, damageBonusDouble, healingDouble, powersText };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TextUtils", "TransformCardText", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public static string TransformCardTextImpl(int damageBonus, int damageBonusDouble, int healingDouble, string powersText)
        {
            object[] objArray1 = new object[] { damageBonus, damageBonusDouble, healingDouble, powersText };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TextUtils", "TransformCardTextImpl", objArray1);
        }

        public static int DEFAULT_STRING_BUILDER_CAPACITY_FUDGE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TextUtils", "DEFAULT_STRING_BUILDER_CAPACITY_FUDGE");
            }
        }
    }
}

