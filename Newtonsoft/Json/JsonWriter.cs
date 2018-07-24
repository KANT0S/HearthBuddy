namespace Newtonsoft.Json
{
    using ns18;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    public abstract class JsonWriter : IDisposable
    {
        [CompilerGenerated]
        private bool bool_0;
        private CultureInfo cultureInfo_0;
        private Newtonsoft.Json.DateFormatHandling dateFormatHandling_0;
        private Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling_0 = Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
        private Newtonsoft.Json.FloatFormatHandling floatFormatHandling_0;
        private Newtonsoft.Json.Formatting formatting_0 = Newtonsoft.Json.Formatting.None;
        private readonly List<Struct25> list_0 = new List<Struct25>(4);
        private static readonly State[][] state_0;
        internal static readonly State[][] state_1;
        private State state_2 = State.Start;
        private string string_0;
        private Newtonsoft.Json.StringEscapeHandling stringEscapeHandling_0;
        private Struct25 struct25_0;

        static JsonWriter()
        {
            State[][] stateArray = new State[8][];
            stateArray[0] = new State[] { State.Error, State.Error, State.Error, State.Error, State.Error, State.Error, State.Error, State.Error, State.Error, State.Error };
            stateArray[1] = new State[] { State.ObjectStart, State.ObjectStart, State.Error, State.Error, State.ObjectStart, State.ObjectStart, State.ObjectStart, State.ObjectStart, State.Error, State.Error };
            stateArray[2] = new State[] { State.ArrayStart, State.ArrayStart, State.Error, State.Error, State.ArrayStart, State.ArrayStart, State.ArrayStart, State.ArrayStart, State.Error, State.Error };
            stateArray[3] = new State[] { State.ConstructorStart, State.ConstructorStart, State.Error, State.Error, State.ConstructorStart, State.ConstructorStart, State.ConstructorStart, State.ConstructorStart, State.Error, State.Error };
            stateArray[4] = new State[] { State.Property, State.Error, State.Property, State.Property, State.Error, State.Error, State.Error, State.Error, State.Error, State.Error };
            State[] stateArray7 = new State[10];
            stateArray7[1] = State.Property;
            stateArray7[2] = State.ObjectStart;
            stateArray7[3] = State.Object;
            stateArray7[4] = State.ArrayStart;
            stateArray7[5] = State.Array;
            stateArray7[6] = State.Constructor;
            stateArray7[7] = State.Constructor;
            stateArray7[8] = State.Error;
            stateArray7[9] = State.Error;
            stateArray[5] = stateArray7;
            State[] stateArray8 = new State[10];
            stateArray8[1] = State.Property;
            stateArray8[2] = State.ObjectStart;
            stateArray8[3] = State.Object;
            stateArray8[4] = State.ArrayStart;
            stateArray8[5] = State.Array;
            stateArray8[6] = State.Constructor;
            stateArray8[7] = State.Constructor;
            stateArray8[8] = State.Error;
            stateArray8[9] = State.Error;
            stateArray[6] = stateArray8;
            State[] stateArray9 = new State[10];
            stateArray9[1] = State.Object;
            stateArray9[2] = State.Error;
            stateArray9[3] = State.Error;
            stateArray9[4] = State.Array;
            stateArray9[5] = State.Array;
            stateArray9[6] = State.Constructor;
            stateArray9[7] = State.Constructor;
            stateArray9[8] = State.Error;
            stateArray9[9] = State.Error;
            stateArray[7] = stateArray9;
            state_1 = stateArray;
            state_0 = smethod_0();
        }

        protected JsonWriter()
        {
            this.CloseOutput = true;
        }

        public virtual void Close()
        {
            this.method_8();
        }

        public abstract void Flush();
        internal void method_0()
        {
            if (this.struct25_0.bool_0)
            {
                this.struct25_0.int_0++;
            }
        }

        private void method_1(Enum12 enum12_0)
        {
            if (this.struct25_0.enum12_0 != Enum12.None)
            {
                this.list_0.Add(this.struct25_0);
            }
            this.struct25_0 = new Struct25(enum12_0);
        }

        private void method_10(Enum12 enum12_0)
        {
            int num = 0;
            if (this.struct25_0.enum12_0 == enum12_0)
            {
                num = 1;
            }
            else
            {
                int num2 = this.Top - 2;
                for (int j = num2; j >= 0; j--)
                {
                    int num4 = num2 - j;
                    if (this.list_0[num4].enum12_0 == enum12_0)
                    {
                        num = j + 2;
                        break;
                    }
                }
            }
            if (num == 0)
            {
                throw JsonWriterException.smethod_1(this, "No token to close.", null);
            }
            for (int i = 0; i < num; i++)
            {
                JsonToken token = this.method_9(this.method_2());
                if (this.state_2 == State.Property)
                {
                    this.WriteNull();
                }
                if (((this.formatting_0 == Newtonsoft.Json.Formatting.Indented) && (this.state_2 != State.ObjectStart)) && (this.state_2 != State.ArrayStart))
                {
                    this.WriteIndent();
                }
                this.WriteEnd(token);
                Enum12 enum2 = this.method_3();
                switch (enum2)
                {
                    case Enum12.None:
                        this.state_2 = State.Start;
                        break;

                    case Enum12.Object:
                        this.state_2 = State.Object;
                        break;

                    case Enum12.Array:
                        this.state_2 = State.Array;
                        break;

                    case Enum12.Constructor:
                        this.state_2 = State.Array;
                        break;

                    default:
                        throw JsonWriterException.smethod_1(this, "Unknown JsonType: " + enum2, null);
                }
            }
        }

        internal void method_11(JsonToken jsonToken_0)
        {
            State state = state_0[(int) jsonToken_0][(int) this.state_2];
            if (state == State.Error)
            {
                throw JsonWriterException.smethod_1(this, "Token {0} in state {1} would result in an invalid JSON object.".smethod_1(CultureInfo.InvariantCulture, jsonToken_0.ToString(), this.state_2.ToString()), null);
            }
            if ((((this.state_2 == State.Object) || (this.state_2 == State.Array)) || (this.state_2 == State.Constructor)) && (jsonToken_0 != JsonToken.Comment))
            {
                this.WriteValueDelimiter();
            }
            if (this.formatting_0 == Newtonsoft.Json.Formatting.Indented)
            {
                if (this.state_2 == State.Property)
                {
                    this.WriteIndentSpace();
                }
                if (((this.state_2 == State.Array) || (this.state_2 == State.ArrayStart)) || (((this.state_2 == State.Constructor) || (this.state_2 == State.ConstructorStart)) || ((jsonToken_0 == JsonToken.PropertyName) && (this.state_2 != State.Start))))
                {
                    this.WriteIndent();
                }
            }
            this.state_2 = state;
        }

        private void method_12(bool bool_1)
        {
            if (this.state_2 != State.Closed)
            {
                this.Close();
            }
        }

        internal void method_13(Enum12 enum12_0)
        {
            this.method_10(enum12_0);
        }

        internal void method_14(string string_1)
        {
            this.struct25_0.string_0 = string_1;
            this.method_11(JsonToken.PropertyName);
        }

        internal void method_15()
        {
        }

        internal void method_16(JsonToken jsonToken_0, Enum12 enum12_0)
        {
            this.method_0();
            this.method_11(jsonToken_0);
            this.method_1(enum12_0);
        }

        internal void method_17(JsonToken jsonToken_0)
        {
            this.method_0();
            this.method_11(jsonToken_0);
        }

        internal void method_18(string string_1)
        {
            if ((string_1 != null) && !Class198.smethod_4(string_1))
            {
                throw JsonWriterException.smethod_1(this, "Only white space characters should be used.", null);
            }
        }

        internal void method_19()
        {
            this.method_11(JsonToken.Comment);
        }

        private Enum12 method_2()
        {
            Struct25 struct2 = this.struct25_0;
            if (this.list_0.Count > 0)
            {
                this.struct25_0 = this.list_0[this.list_0.Count - 1];
                this.list_0.RemoveAt(this.list_0.Count - 1);
            }
            else
            {
                this.struct25_0 = new Struct25();
            }
            return struct2.enum12_0;
        }

        private Enum12 method_3()
        {
            return this.struct25_0.enum12_0;
        }

        internal void method_4(JsonReader jsonReader_0, bool bool_1, bool bool_2)
        {
            int num;
            if (jsonReader_0.JsonToken_0 == JsonToken.None)
            {
                num = -1;
            }
            else if (!smethod_2(jsonReader_0.JsonToken_0))
            {
                num = jsonReader_0.Int32_0 + 1;
            }
            else
            {
                num = jsonReader_0.Int32_0;
            }
            this.method_5(jsonReader_0, num, bool_1, bool_2);
        }

        internal void method_5(JsonReader jsonReader_0, int int_0, bool bool_1, bool bool_2)
        {
            do
            {
                switch (jsonReader_0.JsonToken_0)
                {
                    case JsonToken.None:
                        break;

                    case JsonToken.StartObject:
                        this.WriteStartObject();
                        break;

                    case JsonToken.StartArray:
                        this.WriteStartArray();
                        break;

                    case JsonToken.StartConstructor:
                    {
                        string a = jsonReader_0.Object_0.ToString();
                        if (!bool_2 || !string.Equals(a, "Date", StringComparison.Ordinal))
                        {
                            this.WriteStartConstructor(jsonReader_0.Object_0.ToString());
                            break;
                        }
                        this.method_6(jsonReader_0);
                        break;
                    }
                    case JsonToken.PropertyName:
                        this.WritePropertyName(jsonReader_0.Object_0.ToString());
                        break;

                    case JsonToken.Comment:
                        this.WriteComment((jsonReader_0.Object_0 != null) ? jsonReader_0.Object_0.ToString() : null);
                        break;

                    case JsonToken.Raw:
                        this.WriteRawValue((jsonReader_0.Object_0 != null) ? jsonReader_0.Object_0.ToString() : null);
                        break;

                    case JsonToken.Integer:
                        if (!(jsonReader_0.Object_0 is BigInteger))
                        {
                            this.WriteValue(Convert.ToInt64(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
                            break;
                        }
                        this.WriteValue((BigInteger) jsonReader_0.Object_0);
                        break;

                    case JsonToken.Float:
                    {
                        object obj2 = jsonReader_0.Object_0;
                        if (!(obj2 is decimal))
                        {
                            if (obj2 is double)
                            {
                                this.WriteValue((double) obj2);
                            }
                            else if (obj2 is float)
                            {
                                this.WriteValue((float) obj2);
                            }
                            else
                            {
                                this.WriteValue(Convert.ToDouble(obj2, CultureInfo.InvariantCulture));
                            }
                            break;
                        }
                        this.WriteValue((decimal) obj2);
                        break;
                    }
                    case JsonToken.String:
                        this.WriteValue(jsonReader_0.Object_0.ToString());
                        break;

                    case JsonToken.Boolean:
                        this.WriteValue(Convert.ToBoolean(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
                        break;

                    case JsonToken.Null:
                        this.WriteNull();
                        break;

                    case JsonToken.Undefined:
                        this.WriteUndefined();
                        break;

                    case JsonToken.EndObject:
                        this.WriteEndObject();
                        break;

                    case JsonToken.EndArray:
                        this.WriteEndArray();
                        break;

                    case JsonToken.EndConstructor:
                        this.WriteEndConstructor();
                        break;

                    case JsonToken.Date:
                        if (!(jsonReader_0.Object_0 is DateTimeOffset))
                        {
                            this.WriteValue(Convert.ToDateTime(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
                            break;
                        }
                        this.WriteValue((DateTimeOffset) jsonReader_0.Object_0);
                        break;

                    case JsonToken.Bytes:
                        this.WriteValue((byte[]) jsonReader_0.Object_0);
                        break;

                    default:
                        throw Class193.smethod_1("TokenType", jsonReader_0.JsonToken_0, "Unexpected token type.");
                }
            }
            while ((((int_0 - 1) < (jsonReader_0.Int32_0 - (smethod_1(jsonReader_0.JsonToken_0) ? 1 : 0))) && bool_1) && jsonReader_0.Read());
        }

        private void method_6(JsonReader jsonReader_0)
        {
            if (!jsonReader_0.Read())
            {
                throw JsonWriterException.smethod_1(this, "Unexpected end when reading date constructor.", null);
            }
            if (jsonReader_0.JsonToken_0 != JsonToken.Integer)
            {
                throw JsonWriterException.smethod_1(this, "Unexpected token when reading date constructor. Expected Integer, got " + jsonReader_0.JsonToken_0, null);
            }
            long num = (long) jsonReader_0.Object_0;
            DateTime time = Class184.smethod_11(num);
            if (!jsonReader_0.Read())
            {
                throw JsonWriterException.smethod_1(this, "Unexpected end when reading date constructor.", null);
            }
            if (jsonReader_0.JsonToken_0 != JsonToken.EndConstructor)
            {
                throw JsonWriterException.smethod_1(this, "Unexpected token when reading date constructor. Expected EndConstructor, got " + jsonReader_0.JsonToken_0, null);
            }
            this.WriteValue(time);
        }

        private void method_7(Enum12 enum12_0)
        {
            switch (enum12_0)
            {
                case Enum12.Object:
                    this.WriteEndObject();
                    return;

                case Enum12.Array:
                    this.WriteEndArray();
                    return;

                case Enum12.Constructor:
                    this.WriteEndConstructor();
                    return;
            }
            throw JsonWriterException.smethod_1(this, "Unexpected type when writing end: " + enum12_0, null);
        }

        private void method_8()
        {
            while (this.Top > 0)
            {
                this.WriteEnd();
            }
        }

        private JsonToken method_9(Enum12 enum12_0)
        {
            switch (enum12_0)
            {
                case Enum12.Object:
                    return JsonToken.EndObject;

                case Enum12.Array:
                    return JsonToken.EndArray;

                case Enum12.Constructor:
                    return JsonToken.EndConstructor;
            }
            throw JsonWriterException.smethod_1(this, "No close token for type: " + enum12_0, null);
        }

        internal virtual void Newtonsoft.Json.JsonWriter.⁪‮‏‏‮‭⁭​​‎‍‮⁪‮‏⁫‪⁯‭‫⁭⁪‬‬⁮⁫‮⁮‏⁮‪⁯⁭​​‭⁫⁬‍⁮‮()
        {
        }

        protected void SetWriteState(JsonToken token, object value)
        {
            switch (token)
            {
                case JsonToken.StartObject:
                    this.method_16(token, Enum12.Object);
                    return;

                case JsonToken.StartArray:
                    this.method_16(token, Enum12.Array);
                    return;

                case JsonToken.StartConstructor:
                    this.method_16(token, Enum12.Constructor);
                    return;

                case JsonToken.PropertyName:
                    if (!(value is string))
                    {
                        throw new ArgumentException("A name is required when setting property name state.", "value");
                    }
                    this.method_14((string) value);
                    return;

                case JsonToken.Comment:
                    this.method_19();
                    return;

                case JsonToken.Raw:
                    this.method_15();
                    return;

                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Null:
                case JsonToken.Undefined:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    this.method_17(token);
                    return;

                case JsonToken.EndObject:
                    this.method_13(Enum12.Object);
                    return;

                case JsonToken.EndArray:
                    this.method_13(Enum12.Array);
                    return;

                case JsonToken.EndConstructor:
                    this.method_13(Enum12.Constructor);
                    return;
            }
            throw new ArgumentOutOfRangeException("token");
        }

        internal static State[][] smethod_0()
        {
            List<State[]> list = state_1.ToList<State[]>();
            State[] item = state_1[0];
            State[] stateArray2 = state_1[7];
            foreach (JsonToken token in Class186.smethod_3(typeof(JsonToken)))
            {
                if (list.Count > token)
                {
                    continue;
                }
                switch (token)
                {
                    case JsonToken.Integer:
                    case JsonToken.Float:
                    case JsonToken.String:
                    case JsonToken.Boolean:
                    case JsonToken.Null:
                    case JsonToken.Undefined:
                    case JsonToken.Date:
                    case JsonToken.Bytes:
                        break;

                    default:
                    {
                        list.Add(item);
                        continue;
                    }
                }
                list.Add(stateArray2);
            }
            return list.ToArray();
        }

        internal static bool smethod_1(JsonToken jsonToken_0)
        {
            switch (jsonToken_0)
            {
                case JsonToken.EndObject:
                case JsonToken.EndArray:
                case JsonToken.EndConstructor:
                    return true;
            }
            return false;
        }

        internal static bool smethod_2(JsonToken jsonToken_0)
        {
            switch (jsonToken_0)
            {
                case JsonToken.StartObject:
                case JsonToken.StartArray:
                case JsonToken.StartConstructor:
                    return true;
            }
            return false;
        }

        internal static void smethod_3(JsonWriter jsonWriter_0, Enum17 enum17_0, object object_0)
        {
            switch (enum17_0)
            {
                case Enum17.Char:
                    jsonWriter_0.WriteValue((char) object_0);
                    return;

                case Enum17.CharNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new char?((char) object_0));
                    return;

                case Enum17.Boolean:
                    jsonWriter_0.WriteValue((bool) object_0);
                    return;

                case Enum17.BooleanNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new bool?((bool) object_0));
                    return;

                case Enum17.SByte:
                    jsonWriter_0.WriteValue((sbyte) object_0);
                    return;

                case Enum17.SByteNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new sbyte?((sbyte) object_0));
                    return;

                case Enum17.Int16:
                    jsonWriter_0.WriteValue((short) object_0);
                    return;

                case Enum17.Int16Nullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new short?((short) object_0));
                    return;

                case Enum17.UInt16:
                    jsonWriter_0.WriteValue((ushort) object_0);
                    return;

                case Enum17.UInt16Nullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new ushort?((ushort) object_0));
                    return;

                case Enum17.Int32:
                    jsonWriter_0.WriteValue((int) object_0);
                    return;

                case Enum17.Int32Nullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new int?((int) object_0));
                    return;

                case Enum17.Byte:
                    jsonWriter_0.WriteValue((byte) object_0);
                    return;

                case Enum17.ByteNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new byte?((byte) object_0));
                    return;

                case Enum17.UInt32:
                    jsonWriter_0.WriteValue((uint) object_0);
                    return;

                case Enum17.UInt32Nullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new uint?((uint) object_0));
                    return;

                case Enum17.Int64:
                    jsonWriter_0.WriteValue((long) object_0);
                    return;

                case Enum17.Int64Nullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new long?((long) object_0));
                    return;

                case Enum17.UInt64:
                    jsonWriter_0.WriteValue((ulong) object_0);
                    return;

                case Enum17.UInt64Nullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new ulong?((ulong) object_0));
                    return;

                case Enum17.Single:
                    jsonWriter_0.WriteValue((float) object_0);
                    return;

                case Enum17.SingleNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new float?((float) object_0));
                    return;

                case Enum17.Double:
                    jsonWriter_0.WriteValue((double) object_0);
                    return;

                case Enum17.DoubleNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new double?((double) object_0));
                    return;

                case Enum17.DateTime:
                    jsonWriter_0.WriteValue((DateTime) object_0);
                    return;

                case Enum17.DateTimeNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new DateTime?((DateTime) object_0));
                    return;

                case Enum17.DateTimeOffset:
                    jsonWriter_0.WriteValue((DateTimeOffset) object_0);
                    return;

                case Enum17.DateTimeOffsetNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new DateTimeOffset?((DateTimeOffset) object_0));
                    return;

                case Enum17.Decimal:
                    jsonWriter_0.WriteValue((decimal) object_0);
                    return;

                case Enum17.DecimalNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new decimal?((decimal) object_0));
                    return;

                case Enum17.Guid:
                    jsonWriter_0.WriteValue((Guid) object_0);
                    return;

                case Enum17.GuidNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new Guid?((Guid) object_0));
                    return;

                case Enum17.TimeSpan:
                    jsonWriter_0.WriteValue((TimeSpan) object_0);
                    return;

                case Enum17.TimeSpanNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new TimeSpan?((TimeSpan) object_0));
                    return;

                case Enum17.BigInteger:
                    jsonWriter_0.WriteValue((BigInteger) object_0);
                    return;

                case Enum17.BigIntegerNullable:
                    jsonWriter_0.WriteValue((object_0 == null) ? null : new BigInteger?((BigInteger) object_0));
                    return;

                case Enum17.Uri:
                    jsonWriter_0.WriteValue((Uri) object_0);
                    return;

                case Enum17.String:
                    jsonWriter_0.WriteValue((string) object_0);
                    return;

                case Enum17.Bytes:
                    jsonWriter_0.WriteValue((byte[]) object_0);
                    return;

                case Enum17.DBNull:
                    jsonWriter_0.WriteNull();
                    return;
            }
            if (!(object_0 is IConvertible))
            {
                throw smethod_4(jsonWriter_0, object_0);
            }
            IConvertible convertible = (IConvertible) object_0;
            Class180 class2 = Class181.smethod_2(convertible);
            object obj2 = convertible.ToType(class2.Type_0, CultureInfo.InvariantCulture);
            smethod_3(jsonWriter_0, class2.Enum17_0, obj2);
        }

        private static JsonWriterException smethod_4(JsonWriter jsonWriter_0, object object_0)
        {
            return JsonWriterException.smethod_1(jsonWriter_0, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType()), null);
        }

        void IDisposable.Dispose()
        {
            this.method_12(true);
        }

        public virtual void WriteComment(string text)
        {
            this.method_19();
        }

        public virtual void WriteEnd()
        {
            this.method_7(this.method_3());
        }

        protected virtual void WriteEnd(JsonToken token)
        {
        }

        public virtual void WriteEndArray()
        {
            this.method_13(Enum12.Array);
        }

        public virtual void WriteEndConstructor()
        {
            this.method_13(Enum12.Constructor);
        }

        public virtual void WriteEndObject()
        {
            this.method_13(Enum12.Object);
        }

        protected virtual void WriteIndent()
        {
        }

        protected virtual void WriteIndentSpace()
        {
        }

        public virtual void WriteNull()
        {
            this.method_17(JsonToken.Null);
        }

        public virtual void WritePropertyName(string name)
        {
            this.method_14(name);
        }

        public virtual void WritePropertyName(string name, bool escape)
        {
            this.WritePropertyName(name);
        }

        public virtual void WriteRaw(string json)
        {
            this.method_15();
        }

        public virtual void WriteRawValue(string json)
        {
            this.method_0();
            this.method_11(JsonToken.Undefined);
            this.WriteRaw(json);
        }

        public virtual void WriteStartArray()
        {
            this.method_16(JsonToken.StartArray, Enum12.Array);
        }

        public virtual void WriteStartConstructor(string name)
        {
            this.method_16(JsonToken.StartConstructor, Enum12.Constructor);
        }

        public virtual void WriteStartObject()
        {
            this.method_16(JsonToken.StartObject, Enum12.Object);
        }

        public void WriteToken(JsonReader reader)
        {
            this.method_4(reader, true, true);
        }

        public void WriteToken(JsonReader reader, bool writeChildren)
        {
            Class203.smethod_2(reader, "reader");
            this.method_4(reader, writeChildren, true);
        }

        public virtual void WriteUndefined()
        {
            this.method_17(JsonToken.Undefined);
        }

        public virtual void WriteValue(bool value)
        {
            this.method_17(JsonToken.Boolean);
        }

        public virtual void WriteValue(byte value)
        {
            this.method_17(JsonToken.Integer);
        }

        public virtual void WriteValue(char value)
        {
            this.method_17(JsonToken.String);
        }

        public virtual void WriteValue(DateTime value)
        {
            this.method_17(JsonToken.Date);
        }

        public virtual void WriteValue(DateTimeOffset value)
        {
            this.method_17(JsonToken.Date);
        }

        public virtual void WriteValue(decimal value)
        {
            this.method_17(JsonToken.Float);
        }

        public virtual void WriteValue(double value)
        {
            this.method_17(JsonToken.Float);
        }

        public virtual void WriteValue(Guid value)
        {
            this.method_17(JsonToken.String);
        }

        public virtual void WriteValue(short value)
        {
            this.method_17(JsonToken.Integer);
        }

        public virtual void WriteValue(int value)
        {
            this.method_17(JsonToken.Integer);
        }

        public virtual void WriteValue(long value)
        {
            this.method_17(JsonToken.Integer);
        }

        public virtual void WriteValue(bool? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(byte? value)
        {
            byte? nullable = value;
            int? nullable3 = nullable.HasValue ? new int?(nullable.GetValueOrDefault()) : null;
            if (!nullable3.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(char? value)
        {
            char? nullable = value;
            int? nullable3 = nullable.HasValue ? new int?(nullable.GetValueOrDefault()) : null;
            if (!nullable3.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(DateTime? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(DateTimeOffset? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(decimal? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(double? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(Guid? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(short? value)
        {
            short? nullable = value;
            int? nullable3 = nullable.HasValue ? new int?(nullable.GetValueOrDefault()) : null;
            if (!nullable3.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(int? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(long? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(sbyte? value)
        {
            sbyte? nullable = value;
            int? nullable3 = nullable.HasValue ? new int?(nullable.GetValueOrDefault()) : null;
            if (!nullable3.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(float? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(TimeSpan? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(ushort? value)
        {
            ushort? nullable = value;
            int? nullable3 = nullable.HasValue ? new int?(nullable.GetValueOrDefault()) : null;
            if (!nullable3.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(uint? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(ulong? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                this.WriteValue(value.Value);
            }
        }

        public virtual void WriteValue(object value)
        {
            if (value == null)
            {
                this.WriteNull();
            }
            else
            {
                if (value is BigInteger)
                {
                    throw smethod_4(this, value);
                }
                smethod_3(this, Class181.smethod_1(value), value);
            }
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(sbyte value)
        {
            this.method_17(JsonToken.Integer);
        }

        public virtual void WriteValue(float value)
        {
            this.method_17(JsonToken.Float);
        }

        public virtual void WriteValue(string value)
        {
            this.method_17(JsonToken.String);
        }

        public virtual void WriteValue(TimeSpan value)
        {
            this.method_17(JsonToken.String);
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(ushort value)
        {
            this.method_17(JsonToken.Integer);
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(uint value)
        {
            this.method_17(JsonToken.Integer);
        }

        [CLSCompliant(false)]
        public virtual void WriteValue(ulong value)
        {
            this.method_17(JsonToken.Integer);
        }

        public virtual void WriteValue(byte[] value)
        {
            if (value == null)
            {
                this.WriteNull();
            }
            else
            {
                this.method_17(JsonToken.Bytes);
            }
        }

        public virtual void WriteValue(Uri value)
        {
            if (value == null)
            {
                this.WriteNull();
            }
            else
            {
                this.method_17(JsonToken.String);
            }
        }

        protected virtual void WriteValueDelimiter()
        {
        }

        public virtual void WriteWhitespace(string ws)
        {
            this.method_18(ws);
        }

        public bool CloseOutput
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
            }
        }

        public CultureInfo Culture
        {
            get
            {
                return (this.cultureInfo_0 ?? CultureInfo.InvariantCulture);
            }
            set
            {
                this.cultureInfo_0 = value;
            }
        }

        public Newtonsoft.Json.DateFormatHandling DateFormatHandling
        {
            get
            {
                return this.dateFormatHandling_0;
            }
            set
            {
                this.dateFormatHandling_0 = value;
            }
        }

        public string DateFormatString
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }

        public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling
        {
            get
            {
                return this.dateTimeZoneHandling_0;
            }
            set
            {
                this.dateTimeZoneHandling_0 = value;
            }
        }

        public Newtonsoft.Json.FloatFormatHandling FloatFormatHandling
        {
            get
            {
                return this.floatFormatHandling_0;
            }
            set
            {
                this.floatFormatHandling_0 = value;
            }
        }

        public Newtonsoft.Json.Formatting Formatting
        {
            get
            {
                return this.formatting_0;
            }
            set
            {
                this.formatting_0 = value;
            }
        }

        public string Path
        {
            get
            {
                if (this.struct25_0.enum12_0 == Enum12.None)
                {
                    return string.Empty;
                }
                IEnumerable<Struct25> enumerable = (((this.state_2 == State.ArrayStart) || (this.state_2 == State.ConstructorStart)) || (this.state_2 == State.ObjectStart)) ? this.list_0 : this.list_0.Concat<Struct25>(new Struct25[1]);
                return Struct25.smethod_1(enumerable);
            }
        }

        internal string String_0
        {
            get
            {
                if (this.struct25_0.enum12_0 == Enum12.None)
                {
                    return string.Empty;
                }
                return Struct25.smethod_1(this.list_0);
            }
        }

        public Newtonsoft.Json.StringEscapeHandling StringEscapeHandling
        {
            get
            {
                return this.stringEscapeHandling_0;
            }
            set
            {
                this.stringEscapeHandling_0 = value;
                this.Newtonsoft.Json.JsonWriter.⁪‮‏‏‮‭⁭​​‎‍‮⁪‮‏⁫‪⁯‭‫⁭⁪‬‬⁮⁫‮⁮‏⁮‪⁯⁭​​‭⁫⁬‍⁮‮();
            }
        }

        protected internal int Top
        {
            get
            {
                int count = this.list_0.Count;
                if (this.method_3() != Enum12.None)
                {
                    count++;
                }
                return count;
            }
        }

        public Newtonsoft.Json.WriteState WriteState
        {
            get
            {
                switch (this.state_2)
                {
                    case State.Start:
                        return Newtonsoft.Json.WriteState.Start;

                    case State.Property:
                        return Newtonsoft.Json.WriteState.Property;

                    case State.ObjectStart:
                    case State.Object:
                        return Newtonsoft.Json.WriteState.Object;

                    case State.ArrayStart:
                    case State.Array:
                        return Newtonsoft.Json.WriteState.Array;

                    case State.ConstructorStart:
                    case State.Constructor:
                        return Newtonsoft.Json.WriteState.Constructor;

                    case State.Closed:
                        return Newtonsoft.Json.WriteState.Closed;

                    case State.Error:
                        return Newtonsoft.Json.WriteState.Error;
                }
                throw JsonWriterException.smethod_1(this, "Invalid state: " + this.state_2, null);
            }
        }

        internal enum State
        {
            Start,
            Property,
            ObjectStart,
            Object,
            ArrayStart,
            Array,
            ConstructorStart,
            Constructor,
            Closed,
            Error
        }
    }
}

