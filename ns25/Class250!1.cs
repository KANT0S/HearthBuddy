namespace ns25
{
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class250<T> : MonoClass where T: struct
    {
        internal Class250(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "Dictionary<" + typeof(T).FullName + ", " + typeof(string).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        private Class259<T> method_24()
        {
            return base.method_14<Class259<T>>(Class271.string_0, Array.Empty<object>());
        }

        public Dictionary<T, string> method_25()
        {
            Dictionary<T, string> dictionary = new Dictionary<T, string>();
            Class259<T> class2 = this.method_24();
            while (class2.method_26())
            {
                dictionary.Add(class2.Prop_0, class2.String_0);
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

