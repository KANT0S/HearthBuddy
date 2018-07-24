namespace ns15
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Class72 : Class70, IEnumerable<Class70>, IEnumerable
    {
        private readonly List<Class70> list_0 = new List<Class70>();

        public IEnumerator<Class70> GetEnumerator()
        {
            return this.list_0.GetEnumerator();
        }

        public void method_0(Class70 class70_1)
        {
            this.list_0.Add(class70_1);
            class70_1.Class70_0 = this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override Enum11 Enum11_0
        {
            get
            {
                return Enum11.Array;
            }
        }
    }
}

