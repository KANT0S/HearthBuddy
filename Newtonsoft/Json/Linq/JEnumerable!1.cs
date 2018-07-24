namespace Newtonsoft.Json.Linq
{
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct JEnumerable<T> : IEnumerable<T>, IJEnumerable<T>, IEnumerable where T: JToken
    {
        public static readonly JEnumerable<T> Empty;
        private readonly IEnumerable<T> ienumerable_0;
        public JEnumerable(IEnumerable<T> enumerable)
        {
            Class203.smethod_2(enumerable, "enumerable");
            this.ienumerable_0 = enumerable;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.ienumerable_0.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IJEnumerable<JToken> this[object key]
        {
            get
            {
                return new JEnumerable<JToken>(this.ienumerable_0.smethod_0<T, JToken>(key));
            }
        }
        public override bool Equals(object obj)
        {
            return ((obj is JEnumerable<T>) && this.ienumerable_0.Equals(((JEnumerable<T>) obj).ienumerable_0));
        }

        public override int GetHashCode()
        {
            return this.ienumerable_0.GetHashCode();
        }

        static JEnumerable()
        {
            JEnumerable<T>.Empty = new JEnumerable<T>(Enumerable.Empty<T>());
        }
    }
}

