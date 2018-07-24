namespace ns25
{
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class266<T> : MonoClass where T: struct
    {
        internal Class266(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "List<" + typeof(T).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        public T method_24(int int_1)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { int_1 };
            return base.method_10<T>("get_Item", enumArray1, objArray1);
        }

        public List<T> method_25()
        {
            List<T> list = new List<T>();
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

