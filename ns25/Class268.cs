namespace ns25
{
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class268 : MonoClass
    {
        internal Class268(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "List<" + typeof(string).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        public string method_24(int int_1)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { int_1 };
            return base.method_12("get_Item", enumArray1, objArray1);
        }

        public List<string> method_25()
        {
            List<string> list = new List<string>();
            int num = this.Int32_0;
            for (int i = 0; i < num; i++)
            {
                list.Add(this.method_24(i));
            }
            return list;
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

