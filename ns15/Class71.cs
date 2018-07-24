namespace ns15
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Class71 : Class70, IEnumerable<Class77>, IEnumerable
    {
        private readonly List<Class77> list_0 = new List<Class77>();

        public IEnumerator<Class77> GetEnumerator()
        {
            return this.list_0.GetEnumerator();
        }

        public void method_0(string string_0, Class70 class70_1)
        {
            Class77 item = new Class77 {
                Name = new Class74(string_0, false),
                Class70_0 = class70_1
            };
            this.list_0.Add(item);
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
                return Enum11.Object;
            }
        }
    }
}

