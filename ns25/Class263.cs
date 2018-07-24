namespace ns25
{
    using System;
    using Triton.Game.Mono;

    internal class Class263 : MonoClass
    {
        internal Class263(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "IEnumerator<" + typeof(string).FullName + ", " + typeof(string).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        public void method_24()
        {
            base.method_8("Dispose", Array.Empty<object>());
        }

        public void method_25()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public bool method_26()
        {
            return base.method_11<bool>("MoveNext", Array.Empty<object>());
        }

        public string String_0
        {
            get
            {
                return base.method_13("get_Key", Array.Empty<object>());
            }
        }

        public string String_1
        {
            get
            {
                return base.method_13("get_Value", Array.Empty<object>());
            }
        }
    }
}

