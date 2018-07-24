namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Numerics;
    using System.Runtime.InteropServices;

    public class JValue : JToken, IEquatable<JValue>, IComparable<JValue>, IFormattable, IComparable, IConvertible
    {
        private JTokenType jtokenType_10;
        private object object_0;

        public JValue(JValue other) : this(other.Value, other.Type)
        {
        }

        public JValue(bool value) : this(value, JTokenType.Boolean)
        {
        }

        public JValue(char value) : this(value, JTokenType.String)
        {
        }

        public JValue(DateTime value) : this(value, JTokenType.Date)
        {
        }

        public JValue(double value) : this(value, JTokenType.Float)
        {
        }

        public JValue(Guid value) : this(value, JTokenType.Guid)
        {
        }

        public JValue(long value) : this(value, JTokenType.Integer)
        {
        }

        public JValue(object value) : this(value, smethod_10(null, value))
        {
        }

        public JValue(float value) : this(value, JTokenType.Float)
        {
        }

        public JValue(string value) : this(value, JTokenType.String)
        {
        }

        public JValue(TimeSpan value) : this(value, JTokenType.TimeSpan)
        {
        }

        [CLSCompliant(false)]
        public JValue(ulong value) : this(value, JTokenType.Integer)
        {
        }

        public JValue(Uri value) : this(value, (value != null) ? JTokenType.Uri : JTokenType.Null)
        {
        }

        internal JValue(object value, JTokenType type)
        {
            this.object_0 = value;
            this.jtokenType_10 = type;
        }

        public int CompareTo(JValue obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return smethod_7(this.jtokenType_10, this.object_0, obj.object_0);
        }

        public static JValue CreateComment(string value)
        {
            return new JValue(value, JTokenType.Comment);
        }

        public static JValue CreateString(string value)
        {
            return new JValue(value, JTokenType.String);
        }

        public bool Equals(JValue other)
        {
            if (other == null)
            {
                return false;
            }
            return smethod_12(this, other);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            JValue other = obj as JValue;
            if (other != null)
            {
                return this.Equals(other);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            if (this.object_0 == null)
            {
                return 0;
            }
            return this.object_0.GetHashCode();
        }

        protected override DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new Class143<JValue>(parameter, this, new Class86(), true);
        }

        int JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮()
        {
            int num = (this.object_0 != null) ? this.object_0.GetHashCode() : 0;
            return (this.jtokenType_10.GetHashCode() ^ num);
        }

        bool JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(JToken jtoken_2)
        {
            JValue value2 = jtoken_2 as JValue;
            if (value2 == null)
            {
                return false;
            }
            return ((value2 == this) || smethod_12(this, value2));
        }

        JToken JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮()
        {
            return new JValue(this);
        }

        private static JTokenType smethod_10(JTokenType? nullable_2, object object_1)
        {
            if (object_1 == null)
            {
                return JTokenType.Null;
            }
            if (object_1 == DBNull.Value)
            {
                return JTokenType.Null;
            }
            if (object_1 is string)
            {
                return smethod_11(nullable_2);
            }
            if ((((object_1 is long) || (object_1 is int)) || ((object_1 is short) || (object_1 is sbyte))) || (((object_1 is ulong) || (object_1 is uint)) || ((object_1 is ushort) || (object_1 is byte))))
            {
                return JTokenType.Integer;
            }
            if (object_1 is Enum)
            {
                return JTokenType.Integer;
            }
            if (object_1 is BigInteger)
            {
                return JTokenType.Integer;
            }
            if (((object_1 is double) || (object_1 is float)) || (object_1 is decimal))
            {
                return JTokenType.Float;
            }
            if (object_1 is DateTime)
            {
                return JTokenType.Date;
            }
            if (object_1 is DateTimeOffset)
            {
                return JTokenType.Date;
            }
            if (object_1 is byte[])
            {
                return JTokenType.Bytes;
            }
            if (object_1 is bool)
            {
                return JTokenType.Boolean;
            }
            if (object_1 is Guid)
            {
                return JTokenType.Guid;
            }
            if (object_1 is Uri)
            {
                return JTokenType.Uri;
            }
            if (!(object_1 is TimeSpan))
            {
                throw new ArgumentException("Could not determine JSON object type for type {0}.".smethod_0(CultureInfo.InvariantCulture, object_1.GetType()));
            }
            return JTokenType.TimeSpan;
        }

        private static JTokenType smethod_11(JTokenType? nullable_2)
        {
            if (!nullable_2.HasValue)
            {
                return JTokenType.String;
            }
            JTokenType type = nullable_2.Value;
            if (((type != JTokenType.Comment) && (type != JTokenType.String)) && (type != JTokenType.Raw))
            {
                return JTokenType.String;
            }
            return nullable_2.Value;
        }

        private static bool smethod_12(JValue jvalue_0, JValue jvalue_1)
        {
            return ((jvalue_0 == jvalue_1) || ((jvalue_0.jtokenType_10 == jvalue_1.jtokenType_10) && (smethod_7(jvalue_0.jtokenType_10, jvalue_0.object_0, jvalue_1.object_0) == 0)));
        }

        private static int smethod_6(BigInteger bigInteger_0, object object_1)
        {
            int num = bigInteger_0.CompareTo(Class181.smethod_6(object_1));
            if (num != 0)
            {
                return num;
            }
            if (object_1 is decimal)
            {
                decimal num2 = (decimal) object_1;
                decimal num4 = 0M;
                return num4.CompareTo(Math.Abs((decimal) (num2 - Math.Truncate(num2))));
            }
            if (!(object_1 is double) && !(object_1 is float))
            {
                return num;
            }
            double d = Convert.ToDouble(object_1, CultureInfo.InvariantCulture);
            double num5 = 0.0;
            return num5.CompareTo(Math.Abs((double) (d - Math.Truncate(d))));
        }

        internal static int smethod_7(JTokenType jtokenType_11, object object_1, object object_2)
        {
            if ((object_1 == null) && (object_2 == null))
            {
                return 0;
            }
            if ((object_1 != null) && (object_2 == null))
            {
                return 1;
            }
            if ((object_1 == null) && (object_2 != null))
            {
                return -1;
            }
            switch (jtokenType_11)
            {
                case JTokenType.Comment:
                case JTokenType.String:
                case JTokenType.Raw:
                {
                    string strA = Convert.ToString(object_1, CultureInfo.InvariantCulture);
                    string strB = Convert.ToString(object_2, CultureInfo.InvariantCulture);
                    return string.CompareOrdinal(strA, strB);
                }
                case JTokenType.Integer:
                    if (object_1 is BigInteger)
                    {
                        return smethod_6((BigInteger) object_1, object_2);
                    }
                    if (object_2 is BigInteger)
                    {
                        return -smethod_6((BigInteger) object_2, object_1);
                    }
                    if (((object_1 is ulong) || (object_2 is ulong)) || ((object_1 is decimal) || (object_2 is decimal)))
                    {
                        return Convert.ToDecimal(object_1, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(object_2, CultureInfo.InvariantCulture));
                    }
                    if (((object_1 is float) || (object_2 is float)) || ((object_1 is double) || (object_2 is double)))
                    {
                        return smethod_8(object_1, object_2);
                    }
                    return Convert.ToInt64(object_1, CultureInfo.InvariantCulture).CompareTo(Convert.ToInt64(object_2, CultureInfo.InvariantCulture));

                case JTokenType.Float:
                    if (object_1 is BigInteger)
                    {
                        return smethod_6((BigInteger) object_1, object_2);
                    }
                    if (object_2 is BigInteger)
                    {
                        return -smethod_6((BigInteger) object_2, object_1);
                    }
                    return smethod_8(object_1, object_2);

                case JTokenType.Boolean:
                {
                    bool flag = Convert.ToBoolean(object_1, CultureInfo.InvariantCulture);
                    bool flag2 = Convert.ToBoolean(object_2, CultureInfo.InvariantCulture);
                    return flag.CompareTo(flag2);
                }
                case JTokenType.Date:
                {
                    DateTimeOffset offset2;
                    if (object_1 is DateTime)
                    {
                        DateTime dateTime;
                        DateTime time = (DateTime) object_1;
                        if (object_2 is DateTimeOffset)
                        {
                            DateTimeOffset offset3 = (DateTimeOffset) object_2;
                            dateTime = offset3.DateTime;
                        }
                        else
                        {
                            dateTime = Convert.ToDateTime(object_2, CultureInfo.InvariantCulture);
                        }
                        return time.CompareTo(dateTime);
                    }
                    DateTimeOffset offset = (DateTimeOffset) object_1;
                    if (object_2 is DateTimeOffset)
                    {
                        offset2 = (DateTimeOffset) object_2;
                    }
                    else
                    {
                        offset2 = new DateTimeOffset(Convert.ToDateTime(object_2, CultureInfo.InvariantCulture));
                    }
                    return offset.CompareTo(offset2);
                }
                case JTokenType.Bytes:
                {
                    if (!(object_2 is byte[]))
                    {
                        throw new ArgumentException("Object must be of type byte[].");
                    }
                    byte[] buffer = object_1 as byte[];
                    byte[] buffer2 = object_2 as byte[];
                    if (buffer == null)
                    {
                        return -1;
                    }
                    if (buffer2 == null)
                    {
                        return 1;
                    }
                    return Class193.smethod_3(buffer, buffer2);
                }
                case JTokenType.Guid:
                {
                    if (!(object_2 is Guid))
                    {
                        throw new ArgumentException("Object must be of type Guid.");
                    }
                    Guid guid = (Guid) object_1;
                    Guid guid2 = (Guid) object_2;
                    return guid.CompareTo(guid2);
                }
                case JTokenType.Uri:
                {
                    if (!(object_2 is Uri))
                    {
                        throw new ArgumentException("Object must be of type Uri.");
                    }
                    Uri uri = (Uri) object_1;
                    Uri uri2 = (Uri) object_2;
                    return Comparer<string>.Default.Compare(uri.ToString(), uri2.ToString());
                }
                case JTokenType.TimeSpan:
                {
                    if (!(object_2 is TimeSpan))
                    {
                        throw new ArgumentException("Object must be of type TimeSpan.");
                    }
                    TimeSpan span = (TimeSpan) object_1;
                    TimeSpan span2 = (TimeSpan) object_2;
                    return span.CompareTo(span2);
                }
            }
            throw Class193.smethod_1("valueType", jtokenType_11, "Unexpected value type: {0}".smethod_0(CultureInfo.InvariantCulture, jtokenType_11));
        }

        private static int smethod_8(object object_1, object object_2)
        {
            double num = Convert.ToDouble(object_1, CultureInfo.InvariantCulture);
            double num2 = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
            if (Class192.smethod_5(num, num2))
            {
                return 0;
            }
            return num.CompareTo(num2);
        }

        private static bool smethod_9(ExpressionType expressionType_0, object object_1, object object_2, out object object_3)
        {
            BigInteger integer;
            BigInteger integer2;
            decimal num;
            decimal num2;
            double num3;
            double num4;
            long num5;
            long num6;
            if (((object_1 is string) || (object_2 is string)) && ((expressionType_0 == ExpressionType.Add) || (expressionType_0 == ExpressionType.AddAssign)))
            {
                object_3 = ((object_1 != null) ? object_1.ToString() : null) + ((object_2 != null) ? object_2.ToString() : null);
                return true;
            }
            if ((object_1 is BigInteger) || (object_2 is BigInteger))
            {
                if ((object_1 == null) || (object_2 == null))
                {
                    object_3 = null;
                    return true;
                }
                integer = Class181.smethod_6(object_1);
                integer2 = Class181.smethod_6(object_2);
                ExpressionType type = expressionType_0;
                if (type <= ExpressionType.Multiply)
                {
                    switch (type)
                    {
                        case ExpressionType.Add:
                            goto Label_038F;

                        case ExpressionType.Divide:
                            goto Label_039F;

                        case ExpressionType.Multiply:
                            goto Label_03D0;
                    }
                }
                else if (type > ExpressionType.DivideAssign)
                {
                    switch (type)
                    {
                        case ExpressionType.MultiplyAssign:
                            goto Label_03D0;

                        case ExpressionType.SubtractAssign:
                            goto Label_03C0;
                    }
                }
                else
                {
                    switch (type)
                    {
                        case ExpressionType.AddAssign:
                            goto Label_038F;

                        case ExpressionType.DivideAssign:
                            goto Label_039F;

                        case ExpressionType.Subtract:
                            goto Label_03C0;
                    }
                }
            }
            else if (((object_1 is ulong) || (object_2 is ulong)) || ((object_1 is decimal) || (object_2 is decimal)))
            {
                if ((object_1 == null) || (object_2 == null))
                {
                    object_3 = null;
                    return true;
                }
                num = Convert.ToDecimal(object_1, CultureInfo.InvariantCulture);
                num2 = Convert.ToDecimal(object_2, CultureInfo.InvariantCulture);
                ExpressionType type2 = expressionType_0;
                if (type2 <= ExpressionType.Multiply)
                {
                    switch (type2)
                    {
                        case ExpressionType.Add:
                            goto Label_02DF;

                        case ExpressionType.Divide:
                            goto Label_02EF;

                        case ExpressionType.Multiply:
                            goto Label_0320;
                    }
                }
                else
                {
                    if (type2 > ExpressionType.DivideAssign)
                    {
                        if (type2 == ExpressionType.MultiplyAssign)
                        {
                            goto Label_0320;
                        }
                        if (type2 != ExpressionType.SubtractAssign)
                        {
                            goto Label_03BB;
                        }
                        goto Label_0310;
                    }
                    switch (type2)
                    {
                        case ExpressionType.AddAssign:
                            goto Label_02DF;

                        case ExpressionType.DivideAssign:
                            goto Label_02EF;

                        case ExpressionType.Subtract:
                            goto Label_0310;
                    }
                }
            }
            else if (((object_1 is float) || (object_2 is float)) || ((object_1 is double) || (object_2 is double)))
            {
                if ((object_1 == null) || (object_2 == null))
                {
                    object_3 = null;
                    return true;
                }
                num3 = Convert.ToDouble(object_1, CultureInfo.InvariantCulture);
                num4 = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
                ExpressionType type3 = expressionType_0;
                if (type3 <= ExpressionType.Multiply)
                {
                    switch (type3)
                    {
                        case ExpressionType.Add:
                            goto Label_0227;

                        case ExpressionType.Divide:
                            goto Label_0235;

                        case ExpressionType.Multiply:
                            goto Label_0262;
                    }
                }
                else
                {
                    if (type3 > ExpressionType.DivideAssign)
                    {
                        if (type3 == ExpressionType.MultiplyAssign)
                        {
                            goto Label_0262;
                        }
                        if (type3 != ExpressionType.SubtractAssign)
                        {
                            goto Label_03BB;
                        }
                        goto Label_0254;
                    }
                    switch (type3)
                    {
                        case ExpressionType.AddAssign:
                            goto Label_0227;

                        case ExpressionType.DivideAssign:
                            goto Label_0235;

                        case ExpressionType.Subtract:
                            goto Label_0254;
                    }
                }
            }
            else if (((((object_1 is int) || (object_1 is uint)) || ((object_1 is long) || (object_1 is short))) || (((object_1 is ushort) || (object_1 is sbyte)) || ((object_1 is byte) || (object_2 is int)))) || ((((object_2 is uint) || (object_2 is long)) || ((object_2 is short) || (object_2 is ushort))) || ((object_2 is sbyte) || (object_2 is byte))))
            {
                if ((object_1 == null) || (object_2 == null))
                {
                    object_3 = null;
                    return true;
                }
                num5 = Convert.ToInt64(object_1, CultureInfo.InvariantCulture);
                num6 = Convert.ToInt64(object_2, CultureInfo.InvariantCulture);
                ExpressionType type4 = expressionType_0;
                if (type4 <= ExpressionType.Multiply)
                {
                    switch (type4)
                    {
                        case ExpressionType.Add:
                            goto Label_016D;

                        case ExpressionType.Divide:
                            goto Label_017B;

                        case ExpressionType.Multiply:
                            goto Label_01A8;
                    }
                }
                else
                {
                    if (type4 > ExpressionType.DivideAssign)
                    {
                        if (type4 == ExpressionType.MultiplyAssign)
                        {
                            goto Label_01A8;
                        }
                        if (type4 != ExpressionType.SubtractAssign)
                        {
                            goto Label_03BB;
                        }
                        goto Label_019A;
                    }
                    switch (type4)
                    {
                        case ExpressionType.AddAssign:
                            goto Label_016D;

                        case ExpressionType.DivideAssign:
                            goto Label_017B;

                        case ExpressionType.Subtract:
                            goto Label_019A;
                    }
                }
            }
            goto Label_03BB;
        Label_016D:
            object_3 = num5 + num6;
            return true;
        Label_017B:
            object_3 = num5 / num6;
            return true;
        Label_019A:
            object_3 = num5 - num6;
            return true;
        Label_01A8:
            object_3 = num5 * num6;
            return true;
        Label_0227:
            object_3 = num3 + num4;
            return true;
        Label_0235:
            object_3 = num3 / num4;
            return true;
        Label_0254:
            object_3 = num3 - num4;
            return true;
        Label_0262:
            object_3 = num3 * num4;
            return true;
        Label_02DF:
            object_3 = num + num2;
            return true;
        Label_02EF:
            object_3 = num / num2;
            return true;
        Label_0310:
            object_3 = num - num2;
            return true;
        Label_0320:
            object_3 = num * num2;
            return true;
        Label_038F:
            object_3 = integer + integer2;
            return true;
        Label_039F:
            object_3 = integer / integer2;
            return true;
        Label_03BB:
            object_3 = null;
            return false;
        Label_03C0:
            object_3 = integer - integer2;
            return true;
        Label_03D0:
            object_3 = integer * integer2;
            return true;
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            object obj2 = (obj is JValue) ? ((JValue) obj).Value : obj;
            return smethod_7(this.jtokenType_10, this.object_0, obj2);
        }

        TypeCode IConvertible.GetTypeCode()
        {
            if (this.object_0 == null)
            {
                return TypeCode.Empty;
            }
            if (this.object_0 is DateTimeOffset)
            {
                return TypeCode.DateTime;
            }
            if (this.object_0 is BigInteger)
            {
                return TypeCode.Object;
            }
            return System.Type.GetTypeCode(this.object_0.GetType());
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return (bool) this;
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return (byte) this;
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return (char) this;
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            return (DateTime) this;
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return (decimal) this;
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return (double) this;
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return (short) this;
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return (int) this;
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return (long) this;
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return (sbyte) ((short) this);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return (float) this;
        }

        object IConvertible.ToType(System.Type conversionType, IFormatProvider provider)
        {
            return base.ToObject(conversionType);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return (ushort) this;
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return (uint) this;
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return (ulong) this;
        }

        public override string ToString()
        {
            if (this.object_0 == null)
            {
                return string.Empty;
            }
            return this.object_0.ToString();
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return this.ToString(null, formatProvider);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (this.object_0 == null)
            {
                return string.Empty;
            }
            IFormattable formattable = this.object_0 as IFormattable;
            if (formattable != null)
            {
                return formattable.ToString(format, formatProvider);
            }
            return this.object_0.ToString();
        }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
        {
            if (((converters != null) && (converters.Length > 0)) && (this.object_0 != null))
            {
                JsonConverter converter = JsonSerializer.smethod_1(converters, this.object_0.GetType());
                if (converter != null)
                {
                    converter.WriteJson(writer, this.object_0, JsonSerializer.CreateDefault());
                    return;
                }
            }
            switch (this.jtokenType_10)
            {
                case JTokenType.Comment:
                    writer.WriteComment((this.object_0 != null) ? this.object_0.ToString() : null);
                    return;

                case JTokenType.Integer:
                    if (!(this.object_0 is BigInteger))
                    {
                        writer.WriteValue(Convert.ToInt64(this.object_0, CultureInfo.InvariantCulture));
                        return;
                    }
                    writer.WriteValue((BigInteger) this.object_0);
                    return;

                case JTokenType.Float:
                    if (!(this.object_0 is decimal))
                    {
                        if (this.object_0 is double)
                        {
                            writer.WriteValue((double) this.object_0);
                            return;
                        }
                        if (this.object_0 is float)
                        {
                            writer.WriteValue((float) this.object_0);
                            return;
                        }
                        writer.WriteValue(Convert.ToDouble(this.object_0, CultureInfo.InvariantCulture));
                        return;
                    }
                    writer.WriteValue((decimal) this.object_0);
                    return;

                case JTokenType.String:
                    writer.WriteValue((this.object_0 != null) ? this.object_0.ToString() : null);
                    return;

                case JTokenType.Boolean:
                    writer.WriteValue(Convert.ToBoolean(this.object_0, CultureInfo.InvariantCulture));
                    return;

                case JTokenType.Null:
                    writer.WriteNull();
                    return;

                case JTokenType.Undefined:
                    writer.WriteUndefined();
                    return;

                case JTokenType.Date:
                    if (!(this.object_0 is DateTimeOffset))
                    {
                        writer.WriteValue(Convert.ToDateTime(this.object_0, CultureInfo.InvariantCulture));
                        return;
                    }
                    writer.WriteValue((DateTimeOffset) this.object_0);
                    return;

                case JTokenType.Raw:
                    writer.WriteRawValue((this.object_0 != null) ? this.object_0.ToString() : null);
                    return;

                case JTokenType.Bytes:
                    writer.WriteValue((byte[]) this.object_0);
                    return;

                case JTokenType.Guid:
                case JTokenType.Uri:
                case JTokenType.TimeSpan:
                    writer.WriteValue((this.object_0 != null) ? this.object_0.ToString() : null);
                    return;
            }
            throw Class193.smethod_1("TokenType", this.jtokenType_10, "Unexpected token type.");
        }

        public override bool HasValues
        {
            get
            {
                return false;
            }
        }

        public override JTokenType Type
        {
            get
            {
                return this.jtokenType_10;
            }
        }

        public object Value
        {
            get
            {
                return this.object_0;
            }
            set
            {
                System.Type type = (this.object_0 != null) ? this.object_0.GetType() : null;
                System.Type type2 = (value != null) ? value.GetType() : null;
                if (type != type2)
                {
                    this.jtokenType_10 = smethod_10(new JTokenType?(this.jtokenType_10), value);
                }
                this.object_0 = value;
            }
        }

        private class Class86 : Class85<JValue>
        {
            public override bool ns20.Class85<Newtonsoft.Json.Linq.JValue>.‭⁪⁫⁮‬⁭‮⁬⁪⁬⁬‍‍‬‭‎‮‍‍​⁫‌‎⁯‫‍⁭‪⁬‌‬‎⁬​‮⁯‬‏‫‪‮(JValue jvalue_0, ConvertBinder convertBinder_0, out object object_0)
            {
                if (convertBinder_0.Type == typeof(JValue))
                {
                    object_0 = jvalue_0;
                    return true;
                }
                if (jvalue_0.Value == null)
                {
                    object_0 = null;
                    return Class194.smethod_9(convertBinder_0.Type);
                }
                object_0 = Class181.smethod_8(jvalue_0.Value, CultureInfo.InvariantCulture, convertBinder_0.Type);
                return true;
            }

            public override bool ns20.Class85<Newtonsoft.Json.Linq.JValue>.⁭‫‬⁫‫‬⁪‎‬​‫‏‌⁫‬‬‍‮⁫⁪⁮‬⁫‪⁫⁫‏​‬⁫⁯⁮⁪⁪‏⁭⁬⁪‌⁬‮(JValue jvalue_0, BinaryOperationBinder binaryOperationBinder_0, object object_0, out object object_1)
            {
                object obj2 = (object_0 is JValue) ? ((JValue) object_0).Value : object_0;
                ExpressionType operation = binaryOperationBinder_0.Operation;
                if (operation <= ExpressionType.NotEqual)
                {
                    if (operation > ExpressionType.LessThanOrEqual)
                    {
                        if (operation != ExpressionType.Multiply)
                        {
                            if (operation == ExpressionType.NotEqual)
                            {
                                object_1 = JValue.smethod_7(jvalue_0.Type, jvalue_0.Value, obj2) != 0;
                                return true;
                            }
                            goto Label_018A;
                        }
                        goto Label_0167;
                    }
                    switch (operation)
                    {
                        case ExpressionType.Divide:
                        case ExpressionType.Add:
                            goto Label_0167;

                        case ExpressionType.Equal:
                            object_1 = JValue.smethod_7(jvalue_0.Type, jvalue_0.Value, obj2) == 0;
                            return true;

                        case ExpressionType.GreaterThan:
                            object_1 = JValue.smethod_7(jvalue_0.Type, jvalue_0.Value, obj2) > 0;
                            return true;

                        case ExpressionType.GreaterThanOrEqual:
                            object_1 = JValue.smethod_7(jvalue_0.Type, jvalue_0.Value, obj2) >= 0;
                            return true;

                        case ExpressionType.LessThan:
                            object_1 = JValue.smethod_7(jvalue_0.Type, jvalue_0.Value, obj2) < 0;
                            return true;

                        case ExpressionType.LessThanOrEqual:
                            object_1 = JValue.smethod_7(jvalue_0.Type, jvalue_0.Value, obj2) <= 0;
                            return true;
                    }
                    goto Label_018A;
                }
                if (operation <= ExpressionType.DivideAssign)
                {
                    switch (operation)
                    {
                        case ExpressionType.AddAssign:
                        case ExpressionType.DivideAssign:
                        case ExpressionType.Subtract:
                            goto Label_0167;
                    }
                    goto Label_018A;
                }
                if ((operation != ExpressionType.MultiplyAssign) && (operation != ExpressionType.SubtractAssign))
                {
                    goto Label_018A;
                }
            Label_0167:
                if (JValue.smethod_9(binaryOperationBinder_0.Operation, jvalue_0.Value, obj2, out object_1))
                {
                    object_1 = new JValue(object_1);
                    return true;
                }
            Label_018A:
                object_1 = null;
                return false;
            }
        }
    }
}

