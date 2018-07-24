namespace Newtonsoft.Json.Linq
{
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public static class Extensions
    {
        [CompilerGenerated]
        private static Func<JObject, IEnumerable<JProperty>> func_0;

        public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T: JToken
        {
            Class203.smethod_2(source, "source");
            return source.SelectMany<T, JToken>(new Func<T, IEnumerable<JToken>>(Extensions.smethod_3<T>)).AsJEnumerable();
        }

        public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
        {
            return source.AsJEnumerable<JToken>();
        }

        public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T: JToken
        {
            if (source == null)
            {
                return null;
            }
            if (source is IJEnumerable<T>)
            {
                return (IJEnumerable<T>) source;
            }
            return new JEnumerable<T>(source);
        }

        public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T: JToken
        {
            return source.Children<T, JToken>().AsJEnumerable();
        }

        public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T: JToken
        {
            Class203.smethod_2(source, "source");
            return source.SelectMany<T, JToken>(new Func<T, IEnumerable<JToken>>(Extensions.smethod_6<T, U>)).smethod_1<JToken, U>();
        }

        public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T: JContainer
        {
            Class203.smethod_2(source, "source");
            return source.SelectMany<T, JToken>(new Func<T, IEnumerable<JToken>>(Extensions.smethod_4<T>)).AsJEnumerable();
        }

        public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
        {
            Class203.smethod_2(source, "source");
            if (func_0 == null)
            {
                func_0 = new Func<JObject, IEnumerable<JProperty>>(Extensions.smethod_5);
            }
            return source.SelectMany<JObject, JProperty>(func_0).AsJEnumerable<JProperty>();
        }

        internal static IEnumerable<U> smethod_0<T, U>(this IEnumerable<T> ienumerable_0, object object_0) where T: JToken
        {
            Class203.smethod_2(ienumerable_0, "source");
            this.ienumerator_0 = ienumerable_0.GetEnumerator();
        Label_00FB:
            while (this.ienumerator_0.MoveNext())
            {
                this.jtoken_0 = this.ienumerator_0.Current;
                if (object_0 == null)
                {
                    if (this.jtoken_0 is JValue)
                    {
                        goto Label_0115;
                    }
                    this.ienumerator_1 = this.jtoken_0.Children().GetEnumerator();
                    while (this.ienumerator_1.MoveNext())
                    {
                        this.jtoken_1 = this.ienumerator_1.Current;
                        yield return this.jtoken_1.smethod_2<JToken, U>();
                    }
                    this.method_1();
                    continue;
                }
                this.jtoken_2 = this.jtoken_0[object_0];
                if (this.jtoken_2 != null)
                {
                    yield return this.jtoken_2.smethod_2<JToken, U>();
                    continue;
                }
            }
            this.method_0();
        Label_0115:
            yield return ((JValue) this.jtoken_0).smethod_2<JValue, U>();
            goto Label_00FB;
        }

        internal static IEnumerable<U> smethod_1<T, U>(this IEnumerable<T> ienumerable_0) where T: JToken
        {
            Class203.smethod_2(ienumerable_0, "source");
            this.ienumerator_0 = ienumerable_0.GetEnumerator();
            while (true)
            {
                if (!this.ienumerator_0.MoveNext())
                {
                    this.method_0();
                }
                this.gparam_1 = this.ienumerator_0.Current;
                yield return this.gparam_1.smethod_2<JToken, U>();
            }
        }

        internal static U smethod_2<T, U>(this T gparam_0) where T: JToken
        {
            if (gparam_0 == null)
            {
                return default(U);
            }
            if (((gparam_0 is U) && (typeof(U) != typeof(IComparable))) && (typeof(U) != typeof(IFormattable)))
            {
                return (U) gparam_0;
            }
            JValue value2 = gparam_0 as JValue;
            if (value2 == null)
            {
                throw new InvalidCastException("Cannot cast {0} to {1}.".smethod_1(CultureInfo.InvariantCulture, gparam_0.GetType(), typeof(T)));
            }
            if (value2.Value is U)
            {
                return (U) value2.Value;
            }
            Type underlyingType = typeof(U);
            if (Class194.smethod_10(underlyingType))
            {
                if (value2.Value == null)
                {
                    return default(U);
                }
                underlyingType = Nullable.GetUnderlyingType(underlyingType);
            }
            return (U) Convert.ChangeType(value2.Value, underlyingType, CultureInfo.InvariantCulture);
        }

        [CompilerGenerated]
        private static IEnumerable<JToken> smethod_3<T>(T gparam_0) where T: JToken
        {
            return gparam_0.Ancestors();
        }

        [CompilerGenerated]
        private static IEnumerable<JToken> smethod_4<T>(T gparam_0) where T: JContainer
        {
            return gparam_0.Descendants();
        }

        [CompilerGenerated]
        private static IEnumerable<JProperty> smethod_5(JObject jobject_0)
        {
            return jobject_0.Properties();
        }

        [CompilerGenerated]
        private static IEnumerable<JToken> smethod_6<T, U>(T gparam_0) where T: JToken
        {
            return gparam_0.Children();
        }

        public static U Value<U>(this IEnumerable<JToken> value)
        {
            return value.Value<JToken, U>();
        }

        public static U Value<T, U>(this IEnumerable<T> value) where T: JToken
        {
            Class203.smethod_2(value, "source");
            JToken token = value as JToken;
            if (token == null)
            {
                throw new ArgumentException("Source value must be a JToken.");
            }
            return token.smethod_2<JToken, U>();
        }

        public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
        {
            return source.Values(null);
        }

        public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
        {
            return source.smethod_0<JToken, U>(null);
        }

        public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, object key)
        {
            return source.smethod_0<JToken, JToken>(key).AsJEnumerable();
        }

        public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key)
        {
            return source.smethod_0<JToken, U>(key);
        }

        [CompilerGenerated]
        private sealed class Class113<T, U> : IDisposable, IEnumerable<U>, IEnumerator<U>, IEnumerable, IEnumerator where T: JToken
        {
            private U gparam_0;
            public IEnumerable<T> ienumerable_0;
            public IEnumerable<T> ienumerable_1;
            public IEnumerator<T> ienumerator_0;
            public IEnumerator<JToken> ienumerator_1;
            private int int_0;
            private int int_1;
            public JToken jtoken_0;
            public JToken jtoken_1;
            public JToken jtoken_2;
            public object object_0;
            public object object_1;

            [DebuggerHidden]
            public Class113(int <>1__state)
            {
                this.int_0 = <>1__state;
                this.int_1 = Thread.CurrentThread.ManagedThreadId;
            }

            private void method_0()
            {
                this.int_0 = -1;
                if (this.ienumerator_0 != null)
                {
                    this.ienumerator_0.Dispose();
                }
            }

            private void method_1()
            {
                this.int_0 = 1;
                if (this.ienumerator_1 != null)
                {
                    this.ienumerator_1.Dispose();
                }
            }

            private bool MoveNext()
            {
                try
                {
                    switch (this.int_0)
                    {
                        case 0:
                            this.int_0 = -1;
                            Class203.smethod_2(this.ienumerable_0, "source");
                            this.ienumerator_0 = this.ienumerable_0.GetEnumerator();
                            this.int_0 = 1;
                            goto Label_00FB;

                        case 2:
                            this.int_0 = 1;
                            goto Label_00FB;

                        case 4:
                            this.int_0 = 3;
                            goto Label_00C7;

                        case 5:
                            this.int_0 = 1;
                            goto Label_00FB;

                        default:
                            goto Label_0111;
                    }
                Label_007C:
                    this.jtoken_0 = this.ienumerator_0.Current;
                    if (this.object_0 != null)
                    {
                        goto Label_00DC;
                    }
                    if (this.jtoken_0 is JValue)
                    {
                        goto Label_0115;
                    }
                    this.ienumerator_1 = this.jtoken_0.Children().GetEnumerator();
                    this.int_0 = 3;
                Label_00C7:
                    if (this.ienumerator_1.MoveNext())
                    {
                        goto Label_0136;
                    }
                    this.method_1();
                    goto Label_00FB;
                Label_00DC:
                    this.jtoken_2 = this.jtoken_0[this.object_0];
                    if (this.jtoken_2 != null)
                    {
                        goto Label_0163;
                    }
                Label_00FB:
                    if (this.ienumerator_0.MoveNext())
                    {
                        goto Label_007C;
                    }
                    this.method_0();
                Label_0111:
                    return false;
                Label_0115:
                    this.gparam_0 = ((JValue) this.jtoken_0).smethod_2<JValue, U>();
                    this.int_0 = 2;
                    return true;
                Label_0136:
                    this.jtoken_1 = this.ienumerator_1.Current;
                    this.gparam_0 = this.jtoken_1.smethod_2<JToken, U>();
                    this.int_0 = 4;
                    return true;
                Label_0163:
                    this.gparam_0 = this.jtoken_2.smethod_2<JToken, U>();
                    this.int_0 = 5;
                    return true;
                }
                fault
                {
                    this.System.IDisposable.Dispose();
                }
            }

            [DebuggerHidden]
            IEnumerator<U> IEnumerable<U>.GetEnumerator()
            {
                Extensions.Class113<T, U> class2;
                if ((Thread.CurrentThread.ManagedThreadId == this.int_1) && (this.int_0 == -2))
                {
                    this.int_0 = 0;
                    class2 = (Extensions.Class113<T, U>) this;
                }
                else
                {
                    class2 = new Extensions.Class113<T, U>(0);
                }
                class2.ienumerable_0 = this.ienumerable_1;
                class2.object_0 = this.object_1;
                return class2;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.System.Collections.Generic.IEnumerable<U>.GetEnumerator();
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {
                switch (this.int_0)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        try
                        {
                            switch (this.int_0)
                            {
                                case 3:
                                case 4:
                                    try
                                    {
                                    }
                                    finally
                                    {
                                        this.method_1();
                                    }
                                    return;
                            }
                        }
                        finally
                        {
                            this.method_0();
                        }
                        break;

                    default:
                        return;
                }
            }

            U IEnumerator<U>.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.gparam_0;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.gparam_0;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class114<T, U> : IDisposable, IEnumerable<U>, IEnumerator<U>, IEnumerable, IEnumerator where T: JToken
        {
            private U gparam_0;
            public T gparam_1;
            public IEnumerable<T> ienumerable_0;
            public IEnumerable<T> ienumerable_1;
            public IEnumerator<T> ienumerator_0;
            private int int_0;
            private int int_1;

            [DebuggerHidden]
            public Class114(int <>1__state)
            {
                this.int_0 = <>1__state;
                this.int_1 = Thread.CurrentThread.ManagedThreadId;
            }

            private void method_0()
            {
                this.int_0 = -1;
                if (this.ienumerator_0 != null)
                {
                    this.ienumerator_0.Dispose();
                }
            }

            private bool MoveNext()
            {
                try
                {
                    switch (this.int_0)
                    {
                        case 0:
                            this.int_0 = -1;
                            Class203.smethod_2(this.ienumerable_0, "source");
                            this.ienumerator_0 = this.ienumerable_0.GetEnumerator();
                            this.int_0 = 1;
                            break;

                        case 2:
                            this.int_0 = 1;
                            break;

                        default:
                            goto Label_0066;
                    }
                    if (this.ienumerator_0.MoveNext())
                    {
                        goto Label_006A;
                    }
                    this.method_0();
                Label_0066:
                    return false;
                Label_006A:
                    this.gparam_1 = this.ienumerator_0.Current;
                    this.gparam_0 = this.gparam_1.smethod_2<JToken, U>();
                    this.int_0 = 2;
                    return true;
                }
                fault
                {
                    this.System.IDisposable.Dispose();
                }
            }

            [DebuggerHidden]
            IEnumerator<U> IEnumerable<U>.GetEnumerator()
            {
                Extensions.Class114<T, U> class2;
                if ((Thread.CurrentThread.ManagedThreadId == this.int_1) && (this.int_0 == -2))
                {
                    this.int_0 = 0;
                    class2 = (Extensions.Class114<T, U>) this;
                }
                else
                {
                    class2 = new Extensions.Class114<T, U>(0);
                }
                class2.ienumerable_0 = this.ienumerable_1;
                return class2;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.System.Collections.Generic.IEnumerable<U>.GetEnumerator();
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {
                switch (this.int_0)
                {
                    case 1:
                    case 2:
                        try
                        {
                        }
                        finally
                        {
                            this.method_0();
                        }
                        return;
                }
            }

            U IEnumerator<U>.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.gparam_0;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.gparam_0;
                }
            }
        }
    }
}

