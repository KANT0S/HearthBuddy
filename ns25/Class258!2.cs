namespace ns25
{
    using System;
    using Triton.Game.Mono;

    internal class Class258<T, U> : MonoClass where T: struct where U: class
    {
        internal Class258(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "IEnumerator<" + typeof(T).FullName + ", " + typeof(U).FullName + ">")
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

        public T Prop_0
        {
            get
            {
                return base.method_11<T>("get_Key", Array.Empty<object>());
            }
        }

        public U Prop_1
        {
            get
            {
                return base.method_14<U>("get_Value", Array.Empty<object>());
            }
        }
    }
}

