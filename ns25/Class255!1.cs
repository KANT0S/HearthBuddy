namespace ns25
{
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class255<T> : MonoClass where T: class
    {
        internal Class255(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "Dictionary<" + typeof(string).FullName + ", " + typeof(T).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        private Class264<T> method_24()
        {
            return base.method_14<Class264<T>>(Class271.string_0, Array.Empty<object>());
        }

        public Dictionary<string, T> method_25()
        {
            Dictionary<string, T> dictionary = new Dictionary<string, T>();
            Class264<T> class2 = this.method_24();
            while (class2.method_26())
            {
                dictionary.Add(class2.String_0, class2.Prop_0);
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

