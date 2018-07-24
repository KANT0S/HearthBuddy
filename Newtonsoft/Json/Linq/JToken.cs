namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns19;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Numerics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;

    public abstract class JToken : IEnumerable<JToken>, IJEnumerable<JToken>, IEnumerable, ICloneable, IDynamicMetaObjectProvider, IJsonLineInfo
    {
        private JContainer jcontainer_0;
        private JToken jtoken_0;
        private JToken jtoken_1;
        private static JTokenEqualityComparer jtokenEqualityComparer_0;
        private static readonly JTokenType[] jtokenType_0 = new JTokenType[] { JTokenType.Integer, JTokenType.Float, JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Boolean };
        private static readonly JTokenType[] jtokenType_1 = new JTokenType[] { JTokenType.Integer, JTokenType.Float, JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Boolean };
        private static readonly JTokenType[] jtokenType_2 = new JTokenType[] { JTokenType.Integer, JTokenType.Float, JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Boolean, JTokenType.Bytes };
        private static readonly JTokenType[] jtokenType_3 = new JTokenType[] { JTokenType.Date, JTokenType.Integer, JTokenType.Float, JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Boolean, JTokenType.Bytes, JTokenType.Guid, JTokenType.TimeSpan, JTokenType.Uri };
        private static readonly JTokenType[] jtokenType_4 = new JTokenType[] { JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Guid, JTokenType.Bytes };
        private static readonly JTokenType[] jtokenType_5 = new JTokenType[] { JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.TimeSpan };
        private static readonly JTokenType[] jtokenType_6 = new JTokenType[] { JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Uri };
        private static readonly JTokenType[] jtokenType_7 = new JTokenType[] { JTokenType.Integer, JTokenType.Float, JTokenType.String, JTokenType.Comment, JTokenType.Raw };
        private static readonly JTokenType[] jtokenType_8 = new JTokenType[] { JTokenType.Date, JTokenType.String, JTokenType.Comment, JTokenType.Raw };
        private static readonly JTokenType[] jtokenType_9 = new JTokenType[] { JTokenType.Bytes, JTokenType.String, JTokenType.Comment, JTokenType.Raw, JTokenType.Integer };
        private int? nullable_0;
        private int? nullable_1;

        internal JToken()
        {
        }

        public void AddAfterSelf(object content)
        {
            if (this.jcontainer_0 == null)
            {
                throw new InvalidOperationException("The parent is missing.");
            }
            int num = this.jcontainer_0.method_6(this);
            this.jcontainer_0.method_8(num + 1, content, false);
        }

        public void AddBeforeSelf(object content)
        {
            if (this.jcontainer_0 == null)
            {
                throw new InvalidOperationException("The parent is missing.");
            }
            int num = this.jcontainer_0.method_6(this);
            this.jcontainer_0.method_8(num, content, false);
        }

        public IEnumerable<JToken> AfterSelf()
        {
            if (this.Parent == null)
            {
                goto Label_005E;
            }
            this.jtoken_2 = this.Next;
        Label_PostSwitchInIterator:;
            if (this.jtoken_2 != null)
            {
                yield return this.jtoken_2;
                this.jtoken_2 = this.jtoken_2.Next;
                goto Label_PostSwitchInIterator;
            }
        Label_005E:;
        }

        public IEnumerable<JToken> Ancestors()
        {
            this.jtoken_2 = this.Parent;
            while (true)
            {
                if (this.jtoken_2 == null)
                {
                    yield break;
                }
                yield return this.jtoken_2;
                this.jtoken_2 = this.jtoken_2.Parent;
            }
        }

        public IEnumerable<JToken> BeforeSelf()
        {
            this.jtoken_2 = this.Parent.First;
            while (true)
            {
                if (this.jtoken_2 == this)
                {
                    yield break;
                }
                yield return this.jtoken_2;
                this.jtoken_2 = this.jtoken_2.Next;
            }
        }

        public virtual JEnumerable<JToken> Children()
        {
            return JEnumerable<JToken>.Empty;
        }

        public JEnumerable<T> Children<T>() where T: JToken
        {
            return new JEnumerable<T>(this.Children().OfType<T>());
        }

        public JsonReader CreateReader()
        {
            return new JTokenReader(this);
        }

        public JToken DeepClone()
        {
            return this.Newtonsoft.Json.Linq.JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮();
        }

        public static bool DeepEquals(JToken t1, JToken t2)
        {
            return ((t1 == t2) || (((t1 != null) && (t2 != null)) && t1.Newtonsoft.Json.Linq.JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(t2)));
        }

        public static JToken FromObject(object o)
        {
            return smethod_5(o, JsonSerializer.CreateDefault());
        }

        public static JToken FromObject(object o, JsonSerializer jsonSerializer)
        {
            return smethod_5(o, jsonSerializer);
        }

        protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new Class143<JToken>(parameter, this, new Class85<JToken>(), true);
        }

        public static JToken Load(JsonReader reader)
        {
            return ReadFrom(reader);
        }

        internal void method_0(IJsonLineInfo ijsonLineInfo_0)
        {
            if ((ijsonLineInfo_0 != null) && ijsonLineInfo_0.HasLineInfo())
            {
                this.method_1(ijsonLineInfo_0.LineNumber, ijsonLineInfo_0.LinePosition);
            }
        }

        internal void method_1(int int_0, int int_1)
        {
            this.nullable_0 = new int?(int_0);
            this.nullable_1 = new int?(int_1);
        }

        bool IJsonLineInfo.HasLineInfo()
        {
            return (this.nullable_0.HasValue && this.nullable_1.HasValue);
        }

        internal abstract int Newtonsoft.Json.Linq.JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮();
        internal abstract bool Newtonsoft.Json.Linq.JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(JToken jtoken_2);
        internal abstract JToken Newtonsoft.Json.Linq.JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮();
        public static explicit operator bool(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_0, false))
            {
                throw new ArgumentException("Can not convert {0} to Boolean.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return Convert.ToBoolean((int) ((BigInteger) value2.Value));
            }
            return Convert.ToBoolean(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator byte(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Byte.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (byte) ((BigInteger) value2.Value);
            }
            return Convert.ToByte(value2.Value, CultureInfo.InvariantCulture);
        }

        [CLSCompliant(false)]
        public static explicit operator char(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_7, false))
            {
                throw new ArgumentException("Can not convert {0} to Char.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (char) ((ushort) ((BigInteger) value2.Value));
            }
            return Convert.ToChar(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator DateTime(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_8, false))
            {
                throw new ArgumentException("Can not convert {0} to DateTime.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (!(value2.Value is DateTimeOffset))
            {
                return Convert.ToDateTime(value2.Value, CultureInfo.InvariantCulture);
            }
            DateTimeOffset offset = (DateTimeOffset) value2.Value;
            return offset.DateTime;
        }

        public static explicit operator DateTimeOffset(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_8, false))
            {
                throw new ArgumentException("Can not convert {0} to DateTimeOffset.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is DateTimeOffset)
            {
                return (DateTimeOffset) value2.Value;
            }
            if (value2.Value is string)
            {
                return DateTimeOffset.Parse((string) value2.Value, CultureInfo.InvariantCulture);
            }
            return new DateTimeOffset(Convert.ToDateTime(value2.Value, CultureInfo.InvariantCulture));
        }

        public static explicit operator decimal(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Decimal.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (decimal) ((BigInteger) value2.Value);
            }
            return Convert.ToDecimal(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator double(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Double.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (double) ((BigInteger) value2.Value);
            }
            return Convert.ToDouble(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator Guid(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_4, false))
            {
                throw new ArgumentException("Can not convert {0} to Guid.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is byte[])
            {
                return new Guid((byte[]) value2.Value);
            }
            if (value2.Value is Guid)
            {
                return (Guid) value2.Value;
            }
            return new Guid(Convert.ToString(value2.Value, CultureInfo.InvariantCulture));
        }

        public static explicit operator short(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Int16.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (short) ((BigInteger) value2.Value);
            }
            return Convert.ToInt16(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator int(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Int32.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (int) ((BigInteger) value2.Value);
            }
            return Convert.ToInt32(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator long(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Int64.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (long) ((BigInteger) value2.Value);
            }
            return Convert.ToInt64(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator bool?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_0, true))
                {
                    throw new ArgumentException("Can not convert {0} to Boolean.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new bool?(Convert.ToBoolean((int) ((BigInteger) value2.Value)));
                }
                if (value2.Value != null)
                {
                    return new bool?(Convert.ToBoolean(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator byte?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Byte.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new byte?((byte) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new byte?(Convert.ToByte(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator char?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_7, true))
                {
                    throw new ArgumentException("Can not convert {0} to Char.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new char?((char) ((ushort) ((BigInteger) value2.Value)));
                }
                if (value2.Value != null)
                {
                    return new char?(Convert.ToChar(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator DateTime?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_8, true))
                {
                    throw new ArgumentException("Can not convert {0} to DateTime.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is DateTimeOffset)
                {
                    DateTimeOffset offset = (DateTimeOffset) value2.Value;
                    return new DateTime?(offset.DateTime);
                }
                if (value2.Value != null)
                {
                    return new DateTime?(Convert.ToDateTime(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator DateTimeOffset?(JToken value)
        {
            if (value == null)
            {
                return null;
            }
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_8, true))
            {
                throw new ArgumentException("Can not convert {0} to DateTimeOffset.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value == null)
            {
                return null;
            }
            if (value2.Value is DateTimeOffset)
            {
                return (DateTimeOffset?) value2.Value;
            }
            if (value2.Value is string)
            {
                return new DateTimeOffset?(DateTimeOffset.Parse((string) value2.Value, CultureInfo.InvariantCulture));
            }
            return new DateTimeOffset(Convert.ToDateTime(value2.Value, CultureInfo.InvariantCulture));
        }

        public static explicit operator decimal?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Decimal.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new decimal?((decimal) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new decimal?(Convert.ToDecimal(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator double?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Double.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new double?((double) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new double?(Convert.ToDouble(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator Guid?(JToken value)
        {
            if (value == null)
            {
                return null;
            }
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_4, true))
            {
                throw new ArgumentException("Can not convert {0} to Guid.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value == null)
            {
                return null;
            }
            if (value2.Value is byte[])
            {
                return new Guid((byte[]) value2.Value);
            }
            return new Guid?((value2.Value is Guid) ? ((Guid) value2.Value) : new Guid(Convert.ToString(value2.Value, CultureInfo.InvariantCulture)));
        }

        public static explicit operator short?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Int16.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new short?((short) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new short?(Convert.ToInt16(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator int?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Int32.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new int?((int) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new int?(Convert.ToInt32(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator long?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Int64.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new long?((long) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new long?(Convert.ToInt64(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator float?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to Single.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new float?((float) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new float?(Convert.ToSingle(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator TimeSpan?(JToken value)
        {
            if (value == null)
            {
                return null;
            }
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_5, true))
            {
                throw new ArgumentException("Can not convert {0} to TimeSpan.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value == null)
            {
                return null;
            }
            return new TimeSpan?((value2.Value is TimeSpan) ? ((TimeSpan) value2.Value) : Class181.smethod_4(Convert.ToString(value2.Value, CultureInfo.InvariantCulture)));
        }

        [CLSCompliant(false)]
        public static explicit operator ushort?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to UInt16.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new ushort?((ushort) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new ushort?(Convert.ToUInt16(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        [CLSCompliant(false)]
        public static explicit operator uint?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to UInt32.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new uint?((uint) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new uint?(Convert.ToUInt32(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        [CLSCompliant(false)]
        public static explicit operator ulong?(JToken value)
        {
            if (value != null)
            {
                JValue value2 = smethod_0(value);
                if ((value2 == null) || !smethod_2(value2, jtokenType_1, true))
                {
                    throw new ArgumentException("Can not convert {0} to UInt64.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
                }
                if (value2.Value is BigInteger)
                {
                    return new ulong?((ulong) ((BigInteger) value2.Value));
                }
                if (value2.Value != null)
                {
                    return new ulong?(Convert.ToUInt64(value2.Value, CultureInfo.InvariantCulture));
                }
            }
            return null;
        }

        public static explicit operator float(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to Single.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (float) ((BigInteger) value2.Value);
            }
            return Convert.ToSingle(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator string(JToken value)
        {
            if (value == null)
            {
                return null;
            }
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_3, true))
            {
                throw new ArgumentException("Can not convert {0} to String.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value == null)
            {
                return null;
            }
            if (value2.Value is byte[])
            {
                return Convert.ToBase64String((byte[]) value2.Value);
            }
            if (!(value2.Value is BigInteger))
            {
                return Convert.ToString(value2.Value, CultureInfo.InvariantCulture);
            }
            BigInteger integer = (BigInteger) value2.Value;
            return integer.ToString(CultureInfo.InvariantCulture);
        }

        public static explicit operator TimeSpan(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_5, false))
            {
                throw new ArgumentException("Can not convert {0} to TimeSpan.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is TimeSpan)
            {
                return (TimeSpan) value2.Value;
            }
            return Class181.smethod_4(Convert.ToString(value2.Value, CultureInfo.InvariantCulture));
        }

        [CLSCompliant(false)]
        public static explicit operator ushort(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to UInt16.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (ushort) ((BigInteger) value2.Value);
            }
            return Convert.ToUInt16(value2.Value, CultureInfo.InvariantCulture);
        }

        [CLSCompliant(false)]
        public static explicit operator uint(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to UInt32.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (uint) ((BigInteger) value2.Value);
            }
            return Convert.ToUInt32(value2.Value, CultureInfo.InvariantCulture);
        }

        [CLSCompliant(false)]
        public static explicit operator ulong(JToken value)
        {
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_1, false))
            {
                throw new ArgumentException("Can not convert {0} to UInt64.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is BigInteger)
            {
                return (ulong) ((BigInteger) value2.Value);
            }
            return Convert.ToUInt64(value2.Value, CultureInfo.InvariantCulture);
        }

        public static explicit operator byte[](JToken value)
        {
            if (value == null)
            {
                return null;
            }
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_9, false))
            {
                throw new ArgumentException("Can not convert {0} to byte array.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value is string)
            {
                return Convert.FromBase64String(Convert.ToString(value2.Value, CultureInfo.InvariantCulture));
            }
            if (value2.Value is BigInteger)
            {
                BigInteger integer = (BigInteger) value2.Value;
                return integer.ToByteArray();
            }
            if (!(value2.Value is byte[]))
            {
                throw new ArgumentException("Can not convert {0} to byte array.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            return (byte[]) value2.Value;
        }

        public static explicit operator Uri(JToken value)
        {
            if (value == null)
            {
                return null;
            }
            JValue value2 = smethod_0(value);
            if ((value2 == null) || !smethod_2(value2, jtokenType_6, true))
            {
                throw new ArgumentException("Can not convert {0} to Uri.".smethod_0(CultureInfo.InvariantCulture, smethod_1(value)));
            }
            if (value2.Value == null)
            {
                return null;
            }
            if (value2.Value is Uri)
            {
                return (Uri) value2.Value;
            }
            return new Uri(Convert.ToString(value2.Value, CultureInfo.InvariantCulture));
        }

        public static implicit operator JToken(bool value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(DateTime value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(DateTimeOffset value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(decimal value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(double value)
        {
            return new JValue(value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(short value)
        {
            return new JValue((long) value);
        }

        public static implicit operator JToken(int value)
        {
            return new JValue((long) value);
        }

        public static implicit operator JToken(long value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(bool? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(DateTime? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(DateTimeOffset? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(decimal? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(double? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(Guid? value)
        {
            return new JValue(value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(short? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(int? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(long? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(float? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(TimeSpan? value)
        {
            return new JValue(value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(ushort? value)
        {
            return new JValue(value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(uint? value)
        {
            return new JValue(value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(ulong? value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(float value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(string value)
        {
            return new JValue(value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(ushort value)
        {
            return new JValue((long) value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(uint value)
        {
            return new JValue((long) value);
        }

        [CLSCompliant(false)]
        public static implicit operator JToken(ulong value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(byte[] value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(Guid value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(TimeSpan value)
        {
            return new JValue(value);
        }

        public static implicit operator JToken(Uri value)
        {
            return new JValue(value);
        }

        public static JToken Parse(string json)
        {
            JsonReader reader = new JsonTextReader(new StringReader(json));
            JToken token = Load(reader);
            if (reader.Read() && (reader.JsonToken_0 != JsonToken.Comment))
            {
                throw JsonReaderException.smethod_1(reader, "Additional text found in JSON string after parsing content.");
            }
            return token;
        }

        public static JToken ReadFrom(JsonReader reader)
        {
            Class203.smethod_2(reader, "reader");
            if ((reader.JsonToken_0 == JsonToken.None) && !reader.Read())
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JToken from JsonReader.");
            }
            if (reader.JsonToken_0 == JsonToken.StartObject)
            {
                return JObject.Load(reader);
            }
            if (reader.JsonToken_0 == JsonToken.StartArray)
            {
                return JArray.Load(reader);
            }
            if (reader.JsonToken_0 == JsonToken.PropertyName)
            {
                return JProperty.Load(reader);
            }
            if (reader.JsonToken_0 == JsonToken.StartConstructor)
            {
                return JConstructor.Load(reader);
            }
            if (JsonReader.smethod_1(reader.JsonToken_0))
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JToken from JsonReader. Unexpected token: {0}".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            return new JValue(reader.Object_0);
        }

        public void Remove()
        {
            if (this.jcontainer_0 == null)
            {
                throw new InvalidOperationException("The parent is missing.");
            }
            this.jcontainer_0.Newtonsoft.Json.Linq.JContainer.‪⁯⁮‭‪‭⁬⁫‮‮⁫‍‏‪⁮‭‏⁮⁮⁯⁫​‏‪‌‍⁬‏⁪⁯​⁪‮⁪‍‌‮‪‏⁮‮(this);
        }

        public void Replace(JToken value)
        {
            if (this.jcontainer_0 == null)
            {
                throw new InvalidOperationException("The parent is missing.");
            }
            this.jcontainer_0.vmethod_1(this, value);
        }

        public JToken SelectToken(string path)
        {
            return this.SelectToken(path, false);
        }

        public JToken SelectToken(string path, bool errorWhenNoMatch)
        {
            Class88 class2 = new Class88(path);
            return class2.method_2(this, errorWhenNoMatch);
        }

        private static JValue smethod_0(JToken jtoken_2)
        {
            if (jtoken_2 == null)
            {
                throw new ArgumentNullException("value");
            }
            if (jtoken_2 is JProperty)
            {
                jtoken_2 = ((JProperty) jtoken_2).Value;
            }
            return (jtoken_2 as JValue);
        }

        private static string smethod_1(JToken jtoken_2)
        {
            Class203.smethod_2(jtoken_2, "token");
            if (jtoken_2 is JProperty)
            {
                jtoken_2 = ((JProperty) jtoken_2).Value;
            }
            return jtoken_2.Type.ToString();
        }

        private static bool smethod_2(JToken jtoken_2, JTokenType[] jtokenType_10, bool bool_0)
        {
            if (Array.IndexOf<JTokenType>(jtokenType_10, jtoken_2.Type) == -1)
            {
                if (!bool_0)
                {
                    return false;
                }
                if (jtoken_2.Type != JTokenType.Null)
                {
                    return (jtoken_2.Type == JTokenType.Undefined);
                }
            }
            return true;
        }

        private static BigInteger smethod_3(JToken jtoken_2)
        {
            JValue value2 = smethod_0(jtoken_2);
            if ((value2 == null) || !smethod_2(value2, jtokenType_2, false))
            {
                throw new ArgumentException("Can not convert {0} to BigInteger.".smethod_0(CultureInfo.InvariantCulture, smethod_1(jtoken_2)));
            }
            return Class181.smethod_6(value2.Value);
        }

        private static BigInteger? smethod_4(JToken jtoken_2)
        {
            JValue value2 = smethod_0(jtoken_2);
            if ((value2 == null) || !smethod_2(value2, jtokenType_2, true))
            {
                throw new ArgumentException("Can not convert {0} to BigInteger.".smethod_0(CultureInfo.InvariantCulture, smethod_1(jtoken_2)));
            }
            if (value2.Value != null)
            {
                return new BigInteger?(Class181.smethod_6(value2.Value));
            }
            return null;
        }

        internal static JToken smethod_5(object object_0, JsonSerializer jsonSerializer_0)
        {
            Class203.smethod_2(object_0, "o");
            Class203.smethod_2(jsonSerializer_0, "jsonSerializer");
            using (JTokenWriter writer = new JTokenWriter())
            {
                jsonSerializer_0.Serialize(writer, object_0);
                return writer.Token;
            }
        }

        IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
        {
            return this.Children().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<JToken>) this).GetEnumerator();
        }

        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
        {
            return this.GetMetaObject(parameter);
        }

        object ICloneable.Clone()
        {
            return this.DeepClone();
        }

        public T ToObject<T>()
        {
            return (T) this.ToObject(typeof(T));
        }

        public T ToObject<T>(JsonSerializer jsonSerializer)
        {
            return (T) this.ToObject(typeof(T), jsonSerializer);
        }

        public object ToObject(System.Type objectType)
        {
            if (JsonConvert.DefaultSettings == null)
            {
                switch (Class181.smethod_0(objectType))
                {
                    case Enum17.Char:
                        return (char) this;

                    case Enum17.CharNullable:
                        return (char?) this;

                    case Enum17.Boolean:
                        return (bool) this;

                    case Enum17.BooleanNullable:
                        return (bool?) this;

                    case Enum17.SByte:
                    {
                        short? nullable = (short?) this;
                        return (nullable.HasValue ? new sbyte?((sbyte) nullable.GetValueOrDefault()) : null);
                    }
                    case Enum17.SByteNullable:
                        return (sbyte) ((short) this);

                    case Enum17.Int16:
                        return (short) this;

                    case Enum17.Int16Nullable:
                        return (short?) this;

                    case Enum17.UInt16:
                        return (ushort) this;

                    case Enum17.UInt16Nullable:
                        return (ushort?) this;

                    case Enum17.Int32:
                        return (int) this;

                    case Enum17.Int32Nullable:
                        return (int?) this;

                    case Enum17.Byte:
                        return (byte) this;

                    case Enum17.ByteNullable:
                        return (byte?) this;

                    case Enum17.UInt32:
                        return (uint) this;

                    case Enum17.UInt32Nullable:
                        return (uint?) this;

                    case Enum17.Int64:
                        return (long) this;

                    case Enum17.Int64Nullable:
                        return (long?) this;

                    case Enum17.UInt64:
                        return (ulong) this;

                    case Enum17.UInt64Nullable:
                        return (ulong?) this;

                    case Enum17.Single:
                        return (float) this;

                    case Enum17.SingleNullable:
                        return (float?) this;

                    case Enum17.Double:
                        return (double) this;

                    case Enum17.DoubleNullable:
                        return (double?) this;

                    case Enum17.DateTime:
                        return (DateTime) this;

                    case Enum17.DateTimeNullable:
                        return (DateTime?) this;

                    case Enum17.DateTimeOffset:
                        return (DateTimeOffset) this;

                    case Enum17.DateTimeOffsetNullable:
                        return (DateTimeOffset?) this;

                    case Enum17.Decimal:
                        return (decimal) this;

                    case Enum17.DecimalNullable:
                        return (decimal?) this;

                    case Enum17.Guid:
                        return (Guid) this;

                    case Enum17.GuidNullable:
                        return (Guid?) this;

                    case Enum17.TimeSpan:
                        return (TimeSpan) this;

                    case Enum17.TimeSpanNullable:
                        return (TimeSpan?) this;

                    case Enum17.BigInteger:
                        return smethod_3(this);

                    case Enum17.BigIntegerNullable:
                        return smethod_4(this);

                    case Enum17.Uri:
                        return (Uri) this;

                    case Enum17.String:
                        return (string) this;
                }
            }
            return this.ToObject(objectType, JsonSerializer.CreateDefault());
        }

        public object ToObject(System.Type objectType, JsonSerializer jsonSerializer)
        {
            Class203.smethod_2(jsonSerializer, "jsonSerializer");
            using (JTokenReader reader = new JTokenReader(this))
            {
                return jsonSerializer.Deserialize(reader, objectType);
            }
        }

        public override string ToString()
        {
            return this.ToString(Formatting.Indented, new JsonConverter[0]);
        }

        public string ToString(Formatting formatting, params JsonConverter[] converters)
        {
            using (StringWriter writer = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonTextWriter writer2 = new JsonTextWriter(writer) {
                    Formatting = formatting
                };
                this.WriteTo(writer2, converters);
                return writer.ToString();
            }
        }

        public virtual T Value<T>(object key)
        {
            JToken token = this[key];
            return token.smethod_2<JToken, T>();
        }

        public virtual IEnumerable<T> Values<T>()
        {
            throw new InvalidOperationException("Cannot access child value on {0}.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
        }

        public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

        public static JTokenEqualityComparer EqualityComparer
        {
            get
            {
                if (jtokenEqualityComparer_0 == null)
                {
                    jtokenEqualityComparer_0 = new JTokenEqualityComparer();
                }
                return jtokenEqualityComparer_0;
            }
        }

        public virtual JToken First
        {
            get
            {
                throw new InvalidOperationException("Cannot access child value on {0}.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
            }
        }

        public abstract bool HasValues { get; }

        public virtual JToken this[object key]
        {
            get
            {
                throw new InvalidOperationException("Cannot access child value on {0}.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
            }
            set
            {
                throw new InvalidOperationException("Cannot set child value on {0}.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
            }
        }

        public virtual JToken Last
        {
            get
            {
                throw new InvalidOperationException("Cannot access child value on {0}.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
            }
        }

        int IJsonLineInfo.LineNumber
        {
            get
            {
                int? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    return 0;
                }
                return nullable.GetValueOrDefault();
            }
        }

        int IJsonLineInfo.LinePosition
        {
            get
            {
                int? nullable = this.nullable_1;
                if (!nullable.HasValue)
                {
                    return 0;
                }
                return nullable.GetValueOrDefault();
            }
        }

        IJEnumerable<JToken> IJEnumerable<JToken>.this[object key]
        {
            get
            {
                return this[key];
            }
        }

        public JToken Next
        {
            get
            {
                return this.jtoken_1;
            }
            internal set
            {
                this.jtoken_1 = value;
            }
        }

        public JContainer Parent
        {
            [DebuggerStepThrough]
            get
            {
                return this.jcontainer_0;
            }
            internal set
            {
                this.jcontainer_0 = value;
            }
        }

        public string Path
        {
            get
            {
                if (this.Parent == null)
                {
                    return string.Empty;
                }
                IList<JToken> list = this.Ancestors().Reverse<JToken>().ToList<JToken>();
                list.Add(this);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < list.Count; i++)
                {
                    JProperty property;
                    JToken token = list[i];
                    JToken item = ((i + 1) < list.Count) ? list[i + 1] : null;
                    if (item != null)
                    {
                        switch (token.Type)
                        {
                            case JTokenType.Array:
                            case JTokenType.Constructor:
                                builder.Append("[" + ((IList<JToken>) token).IndexOf(item) + "]");
                                break;

                            case JTokenType.Property:
                                goto Label_00A5;
                        }
                    }
                    continue;
                Label_00A5:
                    property = (JProperty) token;
                    if (builder.Length > 0)
                    {
                        builder.Append(".");
                    }
                    builder.Append(property.Name);
                }
                return builder.ToString();
            }
        }

        public JToken Previous
        {
            get
            {
                return this.jtoken_0;
            }
            internal set
            {
                this.jtoken_0 = value;
            }
        }

        public JToken Root
        {
            get
            {
                JContainer parent = this.Parent;
                if (parent != null)
                {
                    while (parent.Parent != null)
                    {
                        parent = parent.Parent;
                    }
                    return parent;
                }
                return this;
            }
        }

        public abstract JTokenType Type { get; }



    }
}

