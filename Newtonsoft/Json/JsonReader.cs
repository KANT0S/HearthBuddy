namespace Newtonsoft.Json
{
    using ns18;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public abstract class JsonReader : IDisposable
    {
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        internal char char_0;
        private CultureInfo cultureInfo_0;
        internal Newtonsoft.Json.DateParseHandling dateParseHandling_0 = Newtonsoft.Json.DateParseHandling.DateTime;
        private Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling_0 = Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
        internal Enum14 enum14_0;
        internal Newtonsoft.Json.FloatParseHandling floatParseHandling_0 = Newtonsoft.Json.FloatParseHandling.Double;
        private JsonToken jsonToken_0;
        private readonly List<Struct25> list_0 = new List<Struct25>(4);
        private int? nullable_0;
        private object object_0;
        internal State state_0 = State.Start;
        private Struct25 struct25_0;

        protected JsonReader()
        {
            this.CloseInput = true;
        }

        public virtual void Close()
        {
            this.state_0 = State.Closed;
            this.jsonToken_0 = JsonToken.None;
            this.object_0 = null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if ((this.state_0 != State.Closed) && disposing)
            {
                this.Close();
            }
        }

        internal Struct25 method_0(int int_0)
        {
            if (int_0 < this.list_0.Count)
            {
                return this.list_0[int_0];
            }
            return this.struct25_0;
        }

        private void method_1(Enum12 enum12_0)
        {
            this.method_11();
            if (this.struct25_0.enum12_0 == Enum12.None)
            {
                this.struct25_0 = new Struct25(enum12_0);
            }
            else
            {
                this.list_0.Add(this.struct25_0);
                this.struct25_0 = new Struct25(enum12_0);
                if (this.nullable_0.HasValue)
                {
                    int num = this.Int32_0 + 1;
                    if ((num > this.nullable_0) && !this.bool_0)
                    {
                        this.bool_0 = true;
                        throw JsonReaderException.smethod_1(this, "The reader's MaxDepth of {0} has been exceeded.".smethod_0(CultureInfo.InvariantCulture, this.nullable_0));
                    }
                }
            }
        }

        private bool method_10()
        {
            this.enum14_0 = Enum14.Read;
            if (this.JsonToken_0 != JsonToken.StartObject)
            {
                return false;
            }
            if (!this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                throw JsonReaderException.smethod_1(this, "Unexpected end when reading bytes.");
            }
            if (this.Object_0.ToString() == "$type")
            {
                this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮();
                if ((this.Object_0 != null) && this.Object_0.ToString().StartsWith("System.Byte[]"))
                {
                    this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮();
                    if (this.Object_0.ToString() == "$value")
                    {
                        return true;
                    }
                }
            }
            throw JsonReaderException.smethod_1(this, "Error reading bytes. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, JsonToken.StartObject));
        }

        private void method_11()
        {
            if (this.struct25_0.bool_0)
            {
                this.struct25_0.int_0++;
            }
        }

        private void method_12(JsonToken jsonToken_1)
        {
            Enum12 enum2 = this.method_2();
            if (this.method_13(jsonToken_1) != enum2)
            {
                throw JsonReaderException.smethod_1(this, "JsonToken {0} is not valid for closing JsonType {1}.".smethod_1(CultureInfo.InvariantCulture, jsonToken_1, enum2));
            }
            this.state_0 = (this.method_3() != Enum12.None) ? State.PostValue : State.Finished;
        }

        private Enum12 method_13(JsonToken jsonToken_1)
        {
            switch (jsonToken_1)
            {
                case JsonToken.EndObject:
                    return Enum12.Object;

                case JsonToken.EndArray:
                    return Enum12.Array;

                case JsonToken.EndConstructor:
                    return Enum12.Constructor;
            }
            throw JsonReaderException.smethod_1(this, "Not a valid close JsonToken: {0}".smethod_0(CultureInfo.InvariantCulture, jsonToken_1));
        }

        private Enum12 method_2()
        {
            Struct25 struct2;
            if (this.list_0.Count > 0)
            {
                struct2 = this.struct25_0;
                this.struct25_0 = this.list_0[this.list_0.Count - 1];
                this.list_0.RemoveAt(this.list_0.Count - 1);
            }
            else
            {
                struct2 = this.struct25_0;
                this.struct25_0 = new Struct25();
            }
            if (this.nullable_0.HasValue)
            {
                if (this.Int32_0 <= this.nullable_0)
                {
                    this.bool_0 = false;
                }
            }
            return struct2.enum12_0;
        }

        private Enum12 method_3()
        {
            return this.struct25_0.enum12_0;
        }

        internal DateTimeOffset? method_4()
        {
            this.enum14_0 = Enum14.ReadAsDateTimeOffset;
            while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                JsonToken token = this.JsonToken_0;
                if (token != JsonToken.Comment)
                {
                    switch (token)
                    {
                        case JsonToken.Date:
                            if (this.Object_0 is DateTime)
                            {
                                this.SetToken(JsonToken.Date, new DateTimeOffset((DateTime) this.Object_0));
                            }
                            return new DateTimeOffset?((DateTimeOffset) this.Object_0);

                        case JsonToken.Null:
                            return null;

                        case JsonToken.String:
                        {
                            DateTimeOffset offset;
                            string str = (string) this.Object_0;
                            if (string.IsNullOrEmpty(str))
                            {
                                this.SetToken(JsonToken.Null);
                                return null;
                            }
                            if (!DateTimeOffset.TryParse(str, this.Culture, DateTimeStyles.RoundtripKind, out offset))
                            {
                                throw JsonReaderException.smethod_1(this, "Could not convert string to DateTimeOffset: {0}.".smethod_0(CultureInfo.InvariantCulture, this.Object_0));
                            }
                            this.SetToken(JsonToken.Date, offset);
                            return new DateTimeOffset?(offset);
                        }
                    }
                    if (token != JsonToken.EndArray)
                    {
                        throw JsonReaderException.smethod_1(this, "Error reading date. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, token));
                    }
                    return null;
                }
            }
            this.SetToken(JsonToken.None);
            return null;
        }

        internal byte[] method_5()
        {
            this.enum14_0 = Enum14.ReadAsBytes;
            while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                JsonToken token = this.JsonToken_0;
                if (token != JsonToken.Comment)
                {
                    List<byte> list;
                    if (this.method_10())
                    {
                        byte[] buffer = this.ReadAsBytes();
                        this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮();
                        this.SetToken(JsonToken.Bytes, buffer);
                        return buffer;
                    }
                    switch (token)
                    {
                        case JsonToken.String:
                        {
                            string s = (string) this.Object_0;
                            byte[] buffer2 = (s.Length == 0) ? new byte[0] : Convert.FromBase64String(s);
                            this.SetToken(JsonToken.Bytes, buffer2);
                            return buffer2;
                        }
                        case JsonToken.Null:
                            return null;

                        case JsonToken.Bytes:
                            return (byte[]) this.Object_0;

                        default:
                            if (token != JsonToken.StartArray)
                            {
                                if (token != JsonToken.EndArray)
                                {
                                    throw JsonReaderException.smethod_1(this, "Error reading bytes. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, token));
                                }
                                return null;
                            }
                            list = new List<byte>();
                            break;
                    }
                    while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
                    {
                        token = this.JsonToken_0;
                        switch (token)
                        {
                            case JsonToken.Comment:
                            {
                                continue;
                            }
                            case JsonToken.Integer:
                            {
                                list.Add(Convert.ToByte(this.Object_0, CultureInfo.InvariantCulture));
                                continue;
                            }
                            case JsonToken.EndArray:
                            {
                                byte[] buffer3 = list.ToArray();
                                this.SetToken(JsonToken.Bytes, buffer3);
                                return buffer3;
                            }
                        }
                        throw JsonReaderException.smethod_1(this, "Unexpected token when reading bytes: {0}.".smethod_0(CultureInfo.InvariantCulture, token));
                    }
                    throw JsonReaderException.smethod_1(this, "Unexpected end when reading bytes.");
                }
            }
            this.SetToken(JsonToken.None);
            return null;
        }

        internal decimal? method_6()
        {
            this.enum14_0 = Enum14.ReadAsDecimal;
            while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                JsonToken token = this.JsonToken_0;
                if (token != JsonToken.Comment)
                {
                    switch (token)
                    {
                        case JsonToken.Integer:
                        case JsonToken.Float:
                            if (!(this.Object_0 is decimal))
                            {
                                this.SetToken(JsonToken.Float, Convert.ToDecimal(this.Object_0, CultureInfo.InvariantCulture));
                            }
                            return new decimal?((decimal) this.Object_0);

                        case JsonToken.Null:
                            return null;

                        case JsonToken.String:
                        {
                            decimal num;
                            string str = (string) this.Object_0;
                            if (string.IsNullOrEmpty(str))
                            {
                                this.SetToken(JsonToken.Null);
                                return null;
                            }
                            if (!decimal.TryParse(str, NumberStyles.Number, this.Culture, out num))
                            {
                                throw JsonReaderException.smethod_1(this, "Could not convert string to decimal: {0}.".smethod_0(CultureInfo.InvariantCulture, this.Object_0));
                            }
                            this.SetToken(JsonToken.Float, num);
                            return new decimal?(num);
                        }
                    }
                    if (token != JsonToken.EndArray)
                    {
                        throw JsonReaderException.smethod_1(this, "Error reading decimal. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, token));
                    }
                    return null;
                }
            }
            this.SetToken(JsonToken.None);
            return null;
        }

        internal int? method_7()
        {
            this.enum14_0 = Enum14.ReadAsInt32;
            while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                JsonToken token = this.JsonToken_0;
                if (token != JsonToken.Comment)
                {
                    switch (token)
                    {
                        case JsonToken.Integer:
                        case JsonToken.Float:
                            if (!(this.Object_0 is int))
                            {
                                this.SetToken(JsonToken.Integer, Convert.ToInt32(this.Object_0, CultureInfo.InvariantCulture));
                            }
                            return new int?((int) this.Object_0);

                        case JsonToken.Null:
                            return null;

                        case JsonToken.String:
                        {
                            int num;
                            string str = (string) this.Object_0;
                            if (string.IsNullOrEmpty(str))
                            {
                                this.SetToken(JsonToken.Null);
                                return null;
                            }
                            if (!int.TryParse(str, NumberStyles.Integer, this.Culture, out num))
                            {
                                throw JsonReaderException.smethod_1(this, "Could not convert string to integer: {0}.".smethod_0(CultureInfo.InvariantCulture, this.Object_0));
                            }
                            this.SetToken(JsonToken.Integer, num);
                            return new int?(num);
                        }
                    }
                    if (token != JsonToken.EndArray)
                    {
                        throw JsonReaderException.smethod_1(this, "Error reading integer. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, this.JsonToken_0));
                    }
                    return null;
                }
            }
            this.SetToken(JsonToken.None);
            return null;
        }

        internal string method_8()
        {
            this.enum14_0 = Enum14.ReadAsString;
            while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                JsonToken token = this.JsonToken_0;
                if (token != JsonToken.Comment)
                {
                    switch (token)
                    {
                        case JsonToken.String:
                            return (string) this.Object_0;

                        case JsonToken.Null:
                            return null;
                    }
                    if (smethod_0(token) && (this.Object_0 != null))
                    {
                        string str;
                        if (this.Object_0 is IFormattable)
                        {
                            str = ((IFormattable) this.Object_0).ToString(null, this.Culture);
                        }
                        else
                        {
                            str = this.Object_0.ToString();
                        }
                        this.SetToken(JsonToken.String, str);
                        return str;
                    }
                    if (token != JsonToken.EndArray)
                    {
                        throw JsonReaderException.smethod_1(this, "Error reading string. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, token));
                    }
                    return null;
                }
            }
            this.SetToken(JsonToken.None);
            return null;
        }

        internal DateTime? method_9()
        {
            this.enum14_0 = Enum14.ReadAsDateTime;
            while (this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                if (this.JsonToken_0 != JsonToken.Comment)
                {
                    if (this.JsonToken_0 == JsonToken.Date)
                    {
                        return new DateTime?((DateTime) this.Object_0);
                    }
                    if (this.JsonToken_0 != JsonToken.Null)
                    {
                        if (this.JsonToken_0 == JsonToken.String)
                        {
                            DateTime time;
                            string str = (string) this.Object_0;
                            if (string.IsNullOrEmpty(str))
                            {
                                this.SetToken(JsonToken.Null);
                                return null;
                            }
                            if (!DateTime.TryParse(str, this.Culture, DateTimeStyles.RoundtripKind, out time))
                            {
                                throw JsonReaderException.smethod_1(this, "Could not convert string to DateTime: {0}.".smethod_0(CultureInfo.InvariantCulture, this.Object_0));
                            }
                            time = Class184.smethod_2(time, this.DateTimeZoneHandling);
                            this.SetToken(JsonToken.Date, time);
                            return new DateTime?(time);
                        }
                        if (this.JsonToken_0 != JsonToken.EndArray)
                        {
                            throw JsonReaderException.smethod_1(this, "Error reading date. Unexpected token: {0}.".smethod_0(CultureInfo.InvariantCulture, this.JsonToken_0));
                        }
                    }
                    return null;
                }
            }
            this.SetToken(JsonToken.None);
            return null;
        }

        internal virtual bool Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮()
        {
            throw new NotImplementedException();
        }

        public abstract bool Read();
        public abstract byte[] ReadAsBytes();
        public abstract DateTime? ReadAsDateTime();
        public abstract DateTimeOffset? ReadAsDateTimeOffset();
        public abstract decimal? ReadAsDecimal();
        public abstract int? ReadAsInt32();
        public abstract string ReadAsString();
        protected void SetStateBasedOnCurrent()
        {
            Enum12 enum2 = this.method_3();
            switch (enum2)
            {
                case Enum12.None:
                    this.state_0 = State.Finished;
                    return;

                case Enum12.Object:
                    this.state_0 = State.Object;
                    return;

                case Enum12.Array:
                    this.state_0 = State.Array;
                    return;

                case Enum12.Constructor:
                    this.state_0 = State.Constructor;
                    return;
            }
            throw JsonReaderException.smethod_1(this, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".smethod_0(CultureInfo.InvariantCulture, enum2));
        }

        protected void SetToken(JsonToken newToken)
        {
            this.SetToken(newToken, null);
        }

        protected void SetToken(JsonToken newToken, object value)
        {
            this.jsonToken_0 = newToken;
            this.object_0 = value;
            switch (newToken)
            {
                case JsonToken.StartObject:
                    this.state_0 = State.ObjectStart;
                    this.method_1(Enum12.Object);
                    return;

                case JsonToken.StartArray:
                    this.state_0 = State.ArrayStart;
                    this.method_1(Enum12.Array);
                    return;

                case JsonToken.StartConstructor:
                    this.state_0 = State.ConstructorStart;
                    this.method_1(Enum12.Constructor);
                    return;

                case JsonToken.PropertyName:
                    this.state_0 = State.Property;
                    this.struct25_0.string_0 = (string) value;
                    return;

                case JsonToken.Comment:
                    break;

                case JsonToken.Raw:
                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Null:
                case JsonToken.Undefined:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    this.state_0 = (this.method_3() != Enum12.None) ? State.PostValue : State.Finished;
                    this.method_11();
                    break;

                case JsonToken.EndObject:
                    this.method_12(JsonToken.EndObject);
                    return;

                case JsonToken.EndArray:
                    this.method_12(JsonToken.EndArray);
                    return;

                case JsonToken.EndConstructor:
                    this.method_12(JsonToken.EndConstructor);
                    return;

                default:
                    return;
            }
        }

        public void Skip()
        {
            if (this.JsonToken_0 == JsonToken.PropertyName)
            {
                this.Read();
            }
            if (smethod_1(this.JsonToken_0))
            {
                int num = this.Int32_0;
                while (this.Read())
                {
                    if (num >= this.Int32_0)
                    {
                        break;
                    }
                }
            }
        }

        internal static bool smethod_0(JsonToken jsonToken_1)
        {
            switch (jsonToken_1)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Null:
                case JsonToken.Undefined:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    return true;
            }
            return false;
        }

        internal static bool smethod_1(JsonToken jsonToken_1)
        {
            switch (jsonToken_1)
            {
                case JsonToken.StartObject:
                case JsonToken.StartArray:
                case JsonToken.StartConstructor:
                    return true;
            }
            return false;
        }

        void IDisposable.Dispose()
        {
            this.Dispose(true);
        }

        public virtual char Char_0
        {
            get
            {
                return this.char_0;
            }
            protected internal set
            {
                this.char_0 = value;
            }
        }

        public bool CloseInput
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            set
            {
                this.bool_1 = value;
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

        protected State CurrentState
        {
            get
            {
                return this.state_0;
            }
        }

        public Newtonsoft.Json.DateParseHandling DateParseHandling
        {
            get
            {
                return this.dateParseHandling_0;
            }
            set
            {
                this.dateParseHandling_0 = value;
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

        public Newtonsoft.Json.FloatParseHandling FloatParseHandling
        {
            get
            {
                return this.floatParseHandling_0;
            }
            set
            {
                this.floatParseHandling_0 = value;
            }
        }

        public virtual int Int32_0
        {
            get
            {
                int count = this.list_0.Count;
                if (!smethod_1(this.JsonToken_0) && (this.struct25_0.enum12_0 != Enum12.None))
                {
                    return (count + 1);
                }
                return count;
            }
        }

        public virtual JsonToken JsonToken_0
        {
            get
            {
                return this.jsonToken_0;
            }
        }

        public int? MaxDepth
        {
            get
            {
                return this.nullable_0;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive.", "value");
                }
                this.nullable_0 = value;
            }
        }

        public virtual object Object_0
        {
            get
            {
                return this.object_0;
            }
        }

        public virtual string String_0
        {
            get
            {
                if (this.struct25_0.enum12_0 == Enum12.None)
                {
                    return string.Empty;
                }
                IEnumerable<Struct25> enumerable = (((this.state_0 == State.ArrayStart) || (this.state_0 == State.ConstructorStart)) || (this.state_0 == State.ObjectStart)) ? this.list_0 : this.list_0.Concat<Struct25>(new Struct25[1]);
                return Struct25.smethod_1(enumerable);
            }
        }

        public virtual Type Type_0
        {
            get
            {
                if (this.object_0 == null)
                {
                    return null;
                }
                return this.object_0.GetType();
            }
        }

        internal protected enum State
        {
            Start,
            Complete,
            Property,
            ObjectStart,
            Object,
            ArrayStart,
            Array,
            Closed,
            PostValue,
            ConstructorStart,
            Constructor,
            Error,
            Finished
        }
    }
}

