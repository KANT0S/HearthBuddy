namespace ns20
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    internal class Class178<T, U>
    {
        private Dictionary<T, U> dictionary_0;
        private readonly Func<T, U> func_0;
        private readonly object object_0;

        public Class178(Func<T, U> creator)
        {
            this.object_0 = new object();
            if (creator == null)
            {
                throw new ArgumentNullException("creator");
            }
            this.func_0 = creator;
            this.dictionary_0 = new Dictionary<T, U>();
        }

        public U method_0(T gparam_0)
        {
            U local;
            if (!this.dictionary_0.TryGetValue(gparam_0, out local))
            {
                return this.method_1(gparam_0);
            }
            return local;
        }

        private U method_1(T gparam_0)
        {
            U local = this.func_0(gparam_0);
            lock (this.object_0)
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<T, U>();
                    this.dictionary_0[gparam_0] = local;
                }
                else
                {
                    U local2;
                    if (this.dictionary_0.TryGetValue(gparam_0, out local2))
                    {
                        return local2;
                    }
                    Dictionary<T, U> dictionary = new Dictionary<T, U>(this.dictionary_0);
                    dictionary[gparam_0] = local;
                    Thread.MemoryBarrier();
                    this.dictionary_0 = dictionary;
                }
                return local;
            }
        }
    }
}

