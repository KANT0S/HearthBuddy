namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HashPrimeNumbers")]
    public class HashPrimeNumbers : MonoClass
    {
        public HashPrimeNumbers(IntPtr address) : this(address, "HashPrimeNumbers")
        {
        }

        public HashPrimeNumbers(IntPtr address, string className) : base(address, className)
        {
        }

        public static int CalcPrime(int x)
        {
            object[] objArray1 = new object[] { x };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "HashPrimeNumbers", "CalcPrime", objArray1);
        }

        public static bool TestPrime(int x)
        {
            object[] objArray1 = new object[] { x };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "HashPrimeNumbers", "TestPrime", objArray1);
        }

        public static int ToPrime(int x)
        {
            object[] objArray1 = new object[] { x };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "HashPrimeNumbers", "ToPrime", objArray1);
        }

        public static List<int> primeTbl
        {
            get
            {
                Class246<int> class2 = MonoClass.smethod_7<Class246<int>>(TritonHs.MainAssemblyPath, "", "HashPrimeNumbers", "primeTbl");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

