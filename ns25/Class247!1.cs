namespace ns25
{
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class247<T> : MonoClass where T: class
    {
        internal Class247(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Array", "Array<" + typeof(T).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        public T method_24(int int_1)
        {
            return base.method_21<T>(int_1);
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
                return base.method_17();
            }
        }
    }
}

