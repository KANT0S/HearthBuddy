namespace ns25
{
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class254 : MonoClass
    {
        internal Class254(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "Dictionary<" + typeof(string).FullName + ", " + typeof(string).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        private Class263 method_24()
        {
            return base.method_14<Class263>(Class271.string_0, Array.Empty<object>());
        }

        public Dictionary<string, string> method_25()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Class263 class2 = this.method_24();
            while (class2.method_26())
            {
                dictionary.Add(class2.String_0, class2.String_1);
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

