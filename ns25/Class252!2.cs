namespace ns25
{
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class252<T, U> : MonoClass where T: class where U: struct
    {
        internal Class252(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "Dictionary<" + typeof(T).FullName + ", " + typeof(U).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        private Class261<T, U> method_24()
        {
            return base.method_14<Class261<T, U>>(Class271.string_0, Array.Empty<object>());
        }

        public Dictionary<T, U> method_25()
        {
            Dictionary<T, U> dictionary = new Dictionary<T, U>();
            Class261<T, U> class2 = this.method_24();
            while (class2.method_26())
            {
                dictionary.Add(class2.Prop_0, class2.Prop_1);
            }
            class2.method_24();
            return dictionary;
        }

        public int Int32_0
        {
            get
            {
                return base.method_11<int>("get_Count", Array.Empty<object>());
            }
        }
    }
}

