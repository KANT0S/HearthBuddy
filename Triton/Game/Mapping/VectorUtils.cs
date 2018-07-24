namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("VectorUtils")]
    public class VectorUtils : MonoClass
    {
        public VectorUtils(IntPtr address) : this(address, "VectorUtils")
        {
        }

        public VectorUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static Vector2 Abs(Vector2 vector)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { vector };
            return MonoClass.smethod_11<Vector2>(TritonHs.MainAssemblyPath, "", "VectorUtils", "Abs", enumArray1, objArray1);
        }

        public static Vector3 Abs(Vector3 vector)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { vector };
            return MonoClass.smethod_11<Vector3>(TritonHs.MainAssemblyPath, "", "VectorUtils", "Abs", enumArray1, objArray1);
        }

        public static Vector2 CreateFromAngle(float degrees)
        {
            object[] objArray1 = new object[] { degrees };
            return MonoClass.smethod_14<Vector2>(TritonHs.MainAssemblyPath, "", "VectorUtils", "CreateFromAngle", objArray1);
        }
    }
}

