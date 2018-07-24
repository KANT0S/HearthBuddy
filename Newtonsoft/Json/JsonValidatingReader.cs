namespace Newtonsoft.Json
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;
    using ns20;
    using ns21;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Threading;

    public class JsonValidatingReader : JsonReader, IJsonLineInfo
    {
        private Class120 class120_0;
        private Class91 class91_0;
        [CompilerGenerated]
        private static Func<Class120, bool> func_0;
        [CompilerGenerated]
        private static Func<Class120, bool> func_1;
        [CompilerGenerated]
        private static Func<Class120, bool> func_2;
        [CompilerGenerated]
        private static Func<KeyValuePair<string, bool>, bool> func_3;
        [CompilerGenerated]
        private static Func<KeyValuePair<string, bool>, string> func_4;
        private static readonly IList<Class120> ilist_0 = new List<Class120>();
        private readonly JsonReader jsonReader_0;
        private JsonSchema jsonSchema_0;
        private readonly Stack<Class91> stack_0;

        public event Newtonsoft.Json.Schema.ValidationEventHandler ValidationEventHandler;

        public JsonValidatingReader(JsonReader reader)
        {
            Class203.smethod_2(reader, "reader");
            this.jsonReader_0 = reader;
            this.stack_0 = new Stack<Class91>();
        }

        private void method_14(Class91 class91_1)
        {
            this.stack_0.Push(class91_1);
            this.class91_0 = class91_1;
        }

        private Class91 method_15()
        {
            Class91 class2 = this.stack_0.Pop();
            this.class91_0 = (this.stack_0.Count != 0) ? this.stack_0.Peek() : null;
            return class2;
        }

        private void method_16(string string_0, Class120 class120_1)
        {
            IJsonLineInfo info = this;
            string message = info.HasLineInfo() ? (string_0 + " Line {0}, position {1}.".smethod_1(CultureInfo.InvariantCulture, info.LineNumber, info.LinePosition)) : string_0;
            this.method_17(new JsonSchemaException(message, null, this.String_0, info.LineNumber, info.LinePosition));
        }

        private void method_17(JsonSchemaException jsonSchemaException_0)
        {
            Newtonsoft.Json.Schema.ValidationEventHandler handler = this.validationEventHandler_0;
            if (handler == null)
            {
                throw jsonSchemaException_0;
            }
            handler(this, new ValidationEventArgs(jsonSchemaException_0));
        }

        private void method_18(Class120 class120_1)
        {
            if (class120_1 != null)
            {
                JsonSchemaType? nullable = this.method_19();
                if (nullable.HasValue && JsonSchemaGenerator.smethod_0(new JsonSchemaType?(class120_1.JsonSchemaType_1), nullable.Value))
                {
                    this.method_16("Type {0} is disallowed.".smethod_0(CultureInfo.InvariantCulture, nullable), class120_1);
                }
            }
        }

        private JsonSchemaType? method_19()
        {
            switch (this.jsonReader_0.JsonToken_0)
            {
                case JsonToken.StartObject:
                    return 0x10;

                case JsonToken.StartArray:
                    return 0x20;

                case JsonToken.Integer:
                    return 4;

                case JsonToken.Float:
                    return 2;

                case JsonToken.String:
                    return 1;

                case JsonToken.Boolean:
                    return 8;

                case JsonToken.Null:
                    return 0x40;
            }
            return null;
        }

        private void method_20()
        {
            if (this.class120_0 == null)
            {
                this.class120_0 = new Class121().method_0(this.jsonSchema_0);
                if (!JsonWriter.smethod_2(this.jsonReader_0.JsonToken_0))
                {
                    this.method_14(new Class91(JTokenType.None, this.IList_1));
                }
            }
            switch (this.jsonReader_0.JsonToken_0)
            {
                case JsonToken.None:
                    return;

                case JsonToken.StartObject:
                {
                    this.method_28();
                    IList<Class120> schemas = this.IList_1.Where<Class120>(new Func<Class120, bool>(this.method_33)).ToList<Class120>();
                    this.method_14(new Class91(JTokenType.Object, schemas));
                    this.method_21(this.IList_0);
                    return;
                }
                case JsonToken.StartArray:
                {
                    this.method_28();
                    IList<Class120> list2 = this.IList_1.Where<Class120>(new Func<Class120, bool>(this.method_32)).ToList<Class120>();
                    this.method_14(new Class91(JTokenType.Array, list2));
                    this.method_21(this.IList_0);
                    return;
                }
                case JsonToken.StartConstructor:
                    this.method_28();
                    this.method_14(new Class91(JTokenType.Constructor, null));
                    this.method_21(this.IList_0);
                    return;

                case JsonToken.PropertyName:
                    this.method_21(this.IList_0);
                    foreach (Class120 class3 in this.IList_0)
                    {
                        this.method_30(class3);
                    }
                    return;

                case JsonToken.Raw:
                    this.method_28();
                    return;

                case JsonToken.Integer:
                    this.method_28();
                    this.method_21(this.IList_1);
                    foreach (Class120 class4 in this.IList_1)
                    {
                        this.method_27(class4);
                    }
                    return;

                case JsonToken.Float:
                    this.method_28();
                    this.method_21(this.IList_1);
                    foreach (Class120 class5 in this.IList_1)
                    {
                        this.method_29(class5);
                    }
                    return;

                case JsonToken.String:
                    this.method_28();
                    this.method_21(this.IList_1);
                    foreach (Class120 class6 in this.IList_1)
                    {
                        this.method_26(class6);
                    }
                    return;

                case JsonToken.Boolean:
                    this.method_28();
                    this.method_21(this.IList_1);
                    foreach (Class120 class7 in this.IList_1)
                    {
                        this.method_25(class7);
                    }
                    return;

                case JsonToken.Null:
                    this.method_28();
                    this.method_21(this.IList_1);
                    foreach (Class120 class8 in this.IList_1)
                    {
                        this.method_24(class8);
                    }
                    return;

                case JsonToken.Undefined:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    this.method_21(this.IList_1);
                    return;

                case JsonToken.EndObject:
                    this.method_21(this.IList_0);
                    foreach (Class120 class9 in this.IList_0)
                    {
                        this.method_22(class9);
                    }
                    this.method_15();
                    return;

                case JsonToken.EndArray:
                    this.method_21(this.IList_0);
                    foreach (Class120 class10 in this.IList_0)
                    {
                        this.method_23(class10);
                    }
                    this.method_15();
                    return;

                case JsonToken.EndConstructor:
                    this.method_21(this.IList_0);
                    this.method_15();
                    return;
            }
            throw new ArgumentOutOfRangeException();
        }

        private void method_21(IList<Class120> ilist_1)
        {
            foreach (Class91 class2 in this.stack_0)
            {
                bool flag;
                if (!(flag = ((class2.JTokenType_0 == JTokenType.Array) && class2.Boolean_0) && (class2.Int32_0 > 0)) && !class2.Boolean_1)
                {
                    if (func_0 == null)
                    {
                        func_0 = new Func<Class120, bool>(JsonValidatingReader.smethod_4);
                    }
                    if (!ilist_1.Any<Class120>(func_0))
                    {
                        continue;
                    }
                }
                if (class2.JTokenWriter_0 == null)
                {
                    if (JsonWriter.smethod_1(this.jsonReader_0.JsonToken_0))
                    {
                        continue;
                    }
                    class2.JTokenWriter_0 = new JTokenWriter();
                }
                class2.JTokenWriter_0.WriteToken(this.jsonReader_0, false);
                if ((class2.JTokenWriter_0.Top == 0) && (this.jsonReader_0.JsonToken_0 != JsonToken.PropertyName))
                {
                    JToken token = class2.JTokenWriter_0.Token;
                    class2.JTokenWriter_0 = null;
                    if (flag)
                    {
                        if (class2.IList_0.Contains<JToken>(token, JToken.EqualityComparer))
                        {
                            if (func_1 == null)
                            {
                                func_1 = new Func<Class120, bool>(JsonValidatingReader.smethod_5);
                            }
                            this.method_16("Non-unique array item at index {0}.".smethod_0(CultureInfo.InvariantCulture, class2.Int32_0 - 1), class2.IList_1.First<Class120>(func_1));
                        }
                        class2.IList_0.Add(token);
                    }
                    else
                    {
                        if (!class2.Boolean_1)
                        {
                            if (func_2 == null)
                            {
                                func_2 = new Func<Class120, bool>(JsonValidatingReader.smethod_6);
                            }
                            if (!ilist_1.Any<Class120>(func_2))
                            {
                                continue;
                            }
                        }
                        foreach (Class120 class3 in ilist_1)
                        {
                            if ((class3.IList_2 != null) && !class3.IList_2.smethod_6<JToken>(token, JToken.EqualityComparer))
                            {
                                StringWriter textWriter = new StringWriter(CultureInfo.InvariantCulture);
                                token.WriteTo(new JsonTextWriter(textWriter), new JsonConverter[0]);
                                this.method_16("Value {0} is not defined in enum.".smethod_0(CultureInfo.InvariantCulture, textWriter.ToString()), class3);
                            }
                        }
                    }
                }
            }
        }

        private void method_22(Class120 class120_1)
        {
            if (class120_1 != null)
            {
                Dictionary<string, bool> source = this.class91_0.Dictionary_0;
                if (source != null)
                {
                    if (func_3 == null)
                    {
                        func_3 = new Func<KeyValuePair<string, bool>, bool>(JsonValidatingReader.smethod_7);
                    }
                    if (func_4 == null)
                    {
                        func_4 = new Func<KeyValuePair<string, bool>, string>(JsonValidatingReader.smethod_8);
                    }
                    List<string> list = source.Where<KeyValuePair<string, bool>>(func_3).Select<KeyValuePair<string, bool>, string>(func_4).ToList<string>();
                    if (list.Count > 0)
                    {
                        this.method_16("Required properties are missing from object: {0}.".smethod_0(CultureInfo.InvariantCulture, string.Join(", ", list.ToArray())), class120_1);
                    }
                }
            }
        }

        private void method_23(Class120 class120_1)
        {
            if (class120_1 != null)
            {
                int num = this.class91_0.Int32_0;
                if (class120_1.Nullable_6.HasValue)
                {
                    if (num > class120_1.Nullable_6)
                    {
                        this.method_16("Array item count {0} exceeds maximum count of {1}.".smethod_1(CultureInfo.InvariantCulture, num, class120_1.Nullable_6), class120_1);
                    }
                }
                if (class120_1.Nullable_5.HasValue)
                {
                    if (num < class120_1.Nullable_5)
                    {
                        this.method_16("Array item count {0} is less than minimum count of {1}.".smethod_1(CultureInfo.InvariantCulture, num, class120_1.Nullable_5), class120_1);
                    }
                }
            }
        }

        private void method_24(Class120 class120_1)
        {
            if ((class120_1 != null) && this.method_34(class120_1, JsonSchemaType.Null))
            {
                this.method_18(class120_1);
            }
        }

        private void method_25(Class120 class120_1)
        {
            if ((class120_1 != null) && this.method_34(class120_1, JsonSchemaType.Boolean))
            {
                this.method_18(class120_1);
            }
        }

        private void method_26(Class120 class120_1)
        {
            if ((class120_1 != null) && this.method_34(class120_1, JsonSchemaType.String))
            {
                this.method_18(class120_1);
                string str = this.jsonReader_0.Object_0.ToString();
                if (class120_1.Nullable_1.HasValue)
                {
                    if (str.Length > class120_1.Nullable_1)
                    {
                        this.method_16("String '{0}' exceeds maximum length of {1}.".smethod_1(CultureInfo.InvariantCulture, str, class120_1.Nullable_1), class120_1);
                    }
                }
                if (class120_1.Nullable_0.HasValue)
                {
                    if (str.Length < class120_1.Nullable_0)
                    {
                        this.method_16("String '{0}' is less than minimum length of {1}.".smethod_1(CultureInfo.InvariantCulture, str, class120_1.Nullable_0), class120_1);
                    }
                }
                if (class120_1.IList_0 != null)
                {
                    foreach (string str2 in class120_1.IList_0)
                    {
                        if (!Regex.IsMatch(str, str2))
                        {
                            this.method_16("String '{0}' does not match regex pattern '{1}'.".smethod_1(CultureInfo.InvariantCulture, str, str2), class120_1);
                        }
                    }
                }
            }
        }

        private void method_27(Class120 class120_1)
        {
            if ((class120_1 != null) && this.method_34(class120_1, JsonSchemaType.Integer))
            {
                this.method_18(class120_1);
                object obj2 = this.jsonReader_0.Object_0;
                if (class120_1.Nullable_4.HasValue)
                {
                    if (JValue.smethod_7(JTokenType.Integer, obj2, class120_1.Nullable_4) > 0)
                    {
                        this.method_16("Integer {0} exceeds maximum value of {1}.".smethod_1(CultureInfo.InvariantCulture, obj2, class120_1.Nullable_4), class120_1);
                    }
                    if (class120_1.Boolean_2 && (JValue.smethod_7(JTokenType.Integer, obj2, class120_1.Nullable_4) == 0))
                    {
                        this.method_16("Integer {0} equals maximum value of {1} and exclusive maximum is true.".smethod_1(CultureInfo.InvariantCulture, obj2, class120_1.Nullable_4), class120_1);
                    }
                }
                if (class120_1.Nullable_3.HasValue)
                {
                    if (JValue.smethod_7(JTokenType.Integer, obj2, class120_1.Nullable_3) < 0)
                    {
                        this.method_16("Integer {0} is less than minimum value of {1}.".smethod_1(CultureInfo.InvariantCulture, obj2, class120_1.Nullable_3), class120_1);
                    }
                    if (class120_1.Boolean_1 && (JValue.smethod_7(JTokenType.Integer, obj2, class120_1.Nullable_3) == 0))
                    {
                        this.method_16("Integer {0} equals minimum value of {1} and exclusive minimum is true.".smethod_1(CultureInfo.InvariantCulture, obj2, class120_1.Nullable_3), class120_1);
                    }
                }
                if (class120_1.Nullable_2.HasValue)
                {
                    bool flag;
                    if (obj2 is BigInteger)
                    {
                        BigInteger integer = (BigInteger) obj2;
                        if (!Math.Abs((double) (class120_1.Nullable_2.Value - Math.Truncate(class120_1.Nullable_2.Value))).Equals((double) 0.0))
                        {
                            flag = integer != 0L;
                        }
                        else
                        {
                            flag = (integer % new BigInteger(class120_1.Nullable_2.Value)) != 0L;
                        }
                    }
                    else
                    {
                        flag = !smethod_3(((double) Convert.ToInt64(obj2, CultureInfo.InvariantCulture)) % class120_1.Nullable_2.Value);
                    }
                    if (flag)
                    {
                        this.method_16("Integer {0} is not evenly divisible by {1}.".smethod_1(CultureInfo.InvariantCulture, JsonConvert.ToString(obj2), class120_1.Nullable_2), class120_1);
                    }
                }
            }
        }

        private void method_28()
        {
            if ((this.class91_0 != null) && (this.class91_0.JTokenType_0 == JTokenType.Array))
            {
                this.class91_0.Int32_0++;
                foreach (Class120 class2 in this.IList_0)
                {
                    if ((((class2 != null) && class2.Boolean_3) && !class2.Boolean_5) && ((class2.IList_1 == null) || ((this.class91_0.Int32_0 - 1) >= class2.IList_1.Count)))
                    {
                        this.method_16("Index {0} has not been defined and the schema does not allow additional items.".smethod_0(CultureInfo.InvariantCulture, this.class91_0.Int32_0), class2);
                    }
                }
            }
        }

        private void method_29(Class120 class120_1)
        {
            if ((class120_1 != null) && this.method_34(class120_1, JsonSchemaType.Float))
            {
                this.method_18(class120_1);
                double num = Convert.ToDouble(this.jsonReader_0.Object_0, CultureInfo.InvariantCulture);
                if (class120_1.Nullable_4.HasValue)
                {
                    if (num > class120_1.Nullable_4)
                    {
                        this.method_16("Float {0} exceeds maximum value of {1}.".smethod_1(CultureInfo.InvariantCulture, JsonConvert.ToString(num), class120_1.Nullable_4), class120_1);
                    }
                    if (class120_1.Boolean_2)
                    {
                        if (num == class120_1.Nullable_4)
                        {
                            this.method_16("Float {0} equals maximum value of {1} and exclusive maximum is true.".smethod_1(CultureInfo.InvariantCulture, JsonConvert.ToString(num), class120_1.Nullable_4), class120_1);
                        }
                    }
                }
                if (class120_1.Nullable_3.HasValue)
                {
                    if (num < class120_1.Nullable_3)
                    {
                        this.method_16("Float {0} is less than minimum value of {1}.".smethod_1(CultureInfo.InvariantCulture, JsonConvert.ToString(num), class120_1.Nullable_3), class120_1);
                    }
                    if (class120_1.Boolean_1)
                    {
                        if (num == class120_1.Nullable_3)
                        {
                            this.method_16("Float {0} equals minimum value of {1} and exclusive minimum is true.".smethod_1(CultureInfo.InvariantCulture, JsonConvert.ToString(num), class120_1.Nullable_3), class120_1);
                        }
                    }
                }
                if (class120_1.Nullable_2.HasValue && !smethod_3(smethod_2(num, class120_1.Nullable_2.Value)))
                {
                    this.method_16("Float {0} is not evenly divisible by {1}.".smethod_1(CultureInfo.InvariantCulture, JsonConvert.ToString(num), class120_1.Nullable_2), class120_1);
                }
            }
        }

        private void method_30(Class120 class120_1)
        {
            if (class120_1 != null)
            {
                string key = Convert.ToString(this.jsonReader_0.Object_0, CultureInfo.InvariantCulture);
                if (this.class91_0.Dictionary_0.ContainsKey(key))
                {
                    this.class91_0.Dictionary_0[key] = true;
                }
                if (!class120_1.Boolean_4 && !this.method_31(class120_1, key))
                {
                    this.method_16("Property '{0}' has not been defined and the schema does not allow additional properties.".smethod_0(CultureInfo.InvariantCulture, key), class120_1);
                }
                this.class91_0.String_0 = key;
            }
        }

        private bool method_31(Class120 class120_1, string string_0)
        {
            if ((class120_1.IDictionary_0 != null) && class120_1.IDictionary_0.ContainsKey(string_0))
            {
                return true;
            }
            if (class120_1.IDictionary_1 != null)
            {
                bool flag;
                using (IEnumerator<string> enumerator = class120_1.IDictionary_1.Keys.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        string current = enumerator.Current;
                        if (Regex.IsMatch(string_0, current))
                        {
                            goto Label_004E;
                        }
                    }
                    goto Label_005E;
                Label_004E:
                    flag = true;
                }
                return flag;
            }
        Label_005E:
            return false;
        }

        private bool method_32(Class120 class120_1)
        {
            return ((class120_1 == null) || this.method_34(class120_1, JsonSchemaType.Array));
        }

        private bool method_33(Class120 class120_1)
        {
            return ((class120_1 == null) || this.method_34(class120_1, JsonSchemaType.Object));
        }

        private bool method_34(Class120 class120_1, JsonSchemaType jsonSchemaType_0)
        {
            if (!JsonSchemaGenerator.smethod_0(new JsonSchemaType?(class120_1.JsonSchemaType_0), jsonSchemaType_0))
            {
                this.method_16("Invalid type. Expected {0} but got {1}.".smethod_1(CultureInfo.InvariantCulture, class120_1.JsonSchemaType_0, jsonSchemaType_0), class120_1);
                return false;
            }
            return true;
        }

        bool IJsonLineInfo.HasLineInfo()
        {
            IJsonLineInfo info = this.jsonReader_0 as IJsonLineInfo;
            return ((info != null) && info.HasLineInfo());
        }

        public override bool Read()
        {
            if (!this.jsonReader_0.Read())
            {
                return false;
            }
            if (this.jsonReader_0.JsonToken_0 != JsonToken.Comment)
            {
                this.method_20();
            }
            return true;
        }

        public override byte[] ReadAsBytes()
        {
            byte[] buffer = this.jsonReader_0.ReadAsBytes();
            this.method_20();
            return buffer;
        }

        public override DateTime? ReadAsDateTime()
        {
            DateTime? nullable = this.jsonReader_0.ReadAsDateTime();
            this.method_20();
            return nullable;
        }

        public override DateTimeOffset? ReadAsDateTimeOffset()
        {
            DateTimeOffset? nullable = this.jsonReader_0.ReadAsDateTimeOffset();
            this.method_20();
            return nullable;
        }

        public override decimal? ReadAsDecimal()
        {
            decimal? nullable = this.jsonReader_0.ReadAsDecimal();
            this.method_20();
            return nullable;
        }

        public override int? ReadAsInt32()
        {
            int? nullable = this.jsonReader_0.ReadAsInt32();
            this.method_20();
            return nullable;
        }

        public override string ReadAsString()
        {
            string str = this.jsonReader_0.ReadAsString();
            this.method_20();
            return str;
        }

        private static double smethod_2(double double_0, double double_1)
        {
            return (double_0 - (Math.Floor((double) (double_0 / double_1)) * double_1));
        }

        private static bool smethod_3(double double_0)
        {
            return (Math.Abs(double_0) < 2.2204460492503131E-15);
        }

        [CompilerGenerated]
        private static bool smethod_4(Class120 class120_1)
        {
            return (class120_1.IList_2 != null);
        }

        [CompilerGenerated]
        private static bool smethod_5(Class120 class120_1)
        {
            return class120_1.Boolean_6;
        }

        [CompilerGenerated]
        private static bool smethod_6(Class120 class120_1)
        {
            return (class120_1.IList_2 != null);
        }

        [CompilerGenerated]
        private static bool smethod_7(KeyValuePair<string, bool> keyValuePair_0)
        {
            return !keyValuePair_0.Value;
        }

        [CompilerGenerated]
        private static string smethod_8(KeyValuePair<string, bool> keyValuePair_0)
        {
            return keyValuePair_0.Key;
        }

        public override char Char_0
        {
            get
            {
                return this.jsonReader_0.Char_0;
            }
            protected internal set
            {
            }
        }

        private IList<Class120> IList_0
        {
            get
            {
                return this.class91_0.IList_1;
            }
        }

        private IList<Class120> IList_1
        {
            get
            {
                if (this.class91_0 == null)
                {
                    return new List<Class120>(new Class120[] { this.class120_0 });
                }
                if ((this.class91_0.IList_1 == null) || (this.class91_0.IList_1.Count == 0))
                {
                    return ilist_0;
                }
                switch (this.class91_0.JTokenType_0)
                {
                    case JTokenType.None:
                        return this.class91_0.IList_1;

                    case JTokenType.Object:
                    {
                        if (this.class91_0.String_0 == null)
                        {
                            throw new JsonReaderException("CurrentPropertyName has not been set on scope.");
                        }
                        IList<Class120> list = new List<Class120>();
                        foreach (Class120 class2 in this.IList_0)
                        {
                            Class120 class3;
                            if ((class2.IDictionary_0 != null) && class2.IDictionary_0.TryGetValue(this.class91_0.String_0, out class3))
                            {
                                list.Add(class3);
                            }
                            if (class2.IDictionary_1 != null)
                            {
                                foreach (KeyValuePair<string, Class120> pair in class2.IDictionary_1)
                                {
                                    if (Regex.IsMatch(this.class91_0.String_0, pair.Key))
                                    {
                                        list.Add(pair.Value);
                                    }
                                }
                            }
                            if (((list.Count == 0) && class2.Boolean_4) && (class2.Class120_0 != null))
                            {
                                list.Add(class2.Class120_0);
                            }
                        }
                        return list;
                    }
                    case JTokenType.Array:
                    {
                        IList<Class120> list2 = new List<Class120>();
                        foreach (Class120 class4 in this.IList_0)
                        {
                            if (!class4.Boolean_3)
                            {
                                if ((class4.IList_1 != null) && (class4.IList_1.Count > 0))
                                {
                                    list2.Add(class4.IList_1[0]);
                                }
                            }
                            else
                            {
                                if (((class4.IList_1 != null) && (class4.IList_1.Count > 0)) && (class4.IList_1.Count > (this.class91_0.Int32_0 - 1)))
                                {
                                    list2.Add(class4.IList_1[this.class91_0.Int32_0 - 1]);
                                }
                                if (class4.Boolean_5 && (class4.Class120_1 != null))
                                {
                                    list2.Add(class4.Class120_1);
                                }
                            }
                        }
                        return list2;
                    }
                    case JTokenType.Constructor:
                        return ilist_0;
                }
                throw new ArgumentOutOfRangeException("TokenType", "Unexpected token type: {0}".smethod_0(CultureInfo.InvariantCulture, this.class91_0.JTokenType_0));
            }
        }

        public override int Int32_0
        {
            get
            {
                return this.jsonReader_0.Int32_0;
            }
        }

        public override JsonToken JsonToken_0
        {
            get
            {
                return this.jsonReader_0.JsonToken_0;
            }
        }

        int IJsonLineInfo.LineNumber
        {
            get
            {
                IJsonLineInfo info = this.jsonReader_0 as IJsonLineInfo;
                if (info == null)
                {
                    return 0;
                }
                return info.LineNumber;
            }
        }

        int IJsonLineInfo.LinePosition
        {
            get
            {
                IJsonLineInfo info = this.jsonReader_0 as IJsonLineInfo;
                if (info == null)
                {
                    return 0;
                }
                return info.LinePosition;
            }
        }

        public override object Object_0
        {
            get
            {
                return this.jsonReader_0.Object_0;
            }
        }

        public JsonReader Reader
        {
            get
            {
                return this.jsonReader_0;
            }
        }

        public JsonSchema Schema
        {
            get
            {
                return this.jsonSchema_0;
            }
            set
            {
                if (this.JsonToken_0 != JsonToken.None)
                {
                    throw new InvalidOperationException("Cannot change schema while validating JSON.");
                }
                this.jsonSchema_0 = value;
                this.class120_0 = null;
            }
        }

        public override string String_0
        {
            get
            {
                return this.jsonReader_0.String_0;
            }
        }

        public override Type Type_0
        {
            get
            {
                return this.jsonReader_0.Type_0;
            }
        }

        private class Class91
        {
            [CompilerGenerated]
            private bool bool_0;
            [CompilerGenerated]
            private bool bool_1;
            private readonly Dictionary<string, bool> dictionary_0;
            [CompilerGenerated]
            private static Func<string, string> func_0;
            [CompilerGenerated]
            private static Func<string, bool> func_1;
            [CompilerGenerated]
            private static Func<Class120, bool> func_2;
            [CompilerGenerated]
            private static Func<KeyValuePair<string, Class120>, bool> func_3;
            [CompilerGenerated]
            private static Func<KeyValuePair<string, Class120>, string> func_4;
            private readonly IList<Class120> ilist_0;
            [CompilerGenerated]
            private IList<JToken> ilist_1;
            [CompilerGenerated]
            private int int_0;
            private readonly JTokenType jtokenType_0;
            [CompilerGenerated]
            private JTokenWriter jtokenWriter_0;
            [CompilerGenerated]
            private string string_0;

            public Class91(JTokenType tokenType, IList<Class120> schemas)
            {
                this.jtokenType_0 = tokenType;
                this.ilist_0 = schemas;
                if (func_0 == null)
                {
                    func_0 = new Func<string, string>(JsonValidatingReader.Class91.smethod_0);
                }
                if (func_1 == null)
                {
                    func_1 = new Func<string, bool>(JsonValidatingReader.Class91.smethod_1);
                }
                this.dictionary_0 = schemas.SelectMany<Class120, string>(new Func<Class120, IEnumerable<string>>(this.method_0)).Distinct<string>().ToDictionary<string, string, bool>(func_0, func_1);
                if (tokenType == JTokenType.Array)
                {
                    if (func_2 == null)
                    {
                        func_2 = new Func<Class120, bool>(JsonValidatingReader.Class91.smethod_2);
                    }
                    if (schemas.Any<Class120>(func_2))
                    {
                        this.Boolean_0 = true;
                        this.IList_0 = new List<JToken>();
                    }
                }
            }

            private IEnumerable<string> method_0(Class120 class120_0)
            {
                if ((class120_0 == null) || (class120_0.IDictionary_0 == null))
                {
                    return Enumerable.Empty<string>();
                }
                if (func_3 == null)
                {
                    func_3 = new Func<KeyValuePair<string, Class120>, bool>(JsonValidatingReader.Class91.smethod_3);
                }
                if (func_4 == null)
                {
                    func_4 = new Func<KeyValuePair<string, Class120>, string>(JsonValidatingReader.Class91.smethod_4);
                }
                return class120_0.IDictionary_0.Where<KeyValuePair<string, Class120>>(func_3).Select<KeyValuePair<string, Class120>, string>(func_4);
            }

            [CompilerGenerated]
            private static string smethod_0(string string_1)
            {
                return string_1;
            }

            [CompilerGenerated]
            private static bool smethod_1(string string_1)
            {
                return false;
            }

            [CompilerGenerated]
            private static bool smethod_2(Class120 class120_0)
            {
                return class120_0.Boolean_6;
            }

            [CompilerGenerated]
            private static bool smethod_3(KeyValuePair<string, Class120> keyValuePair_0)
            {
                return keyValuePair_0.Value.Boolean_0;
            }

            [CompilerGenerated]
            private static string smethod_4(KeyValuePair<string, Class120> keyValuePair_0)
            {
                return keyValuePair_0.Key;
            }

            public bool Boolean_0
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

            public bool Boolean_1
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

            public Dictionary<string, bool> Dictionary_0
            {
                get
                {
                    return this.dictionary_0;
                }
            }

            public IList<JToken> IList_0
            {
                [CompilerGenerated]
                get
                {
                    return this.ilist_1;
                }
                [CompilerGenerated]
                set
                {
                    this.ilist_1 = value;
                }
            }

            public IList<Class120> IList_1
            {
                get
                {
                    return this.ilist_0;
                }
            }

            public int Int32_0
            {
                [CompilerGenerated]
                get
                {
                    return this.int_0;
                }
                [CompilerGenerated]
                set
                {
                    this.int_0 = value;
                }
            }

            public JTokenType JTokenType_0
            {
                get
                {
                    return this.jtokenType_0;
                }
            }

            public JTokenWriter JTokenWriter_0
            {
                [CompilerGenerated]
                get
                {
                    return this.jtokenWriter_0;
                }
                [CompilerGenerated]
                set
                {
                    this.jtokenWriter_0 = value;
                }
            }

            public string String_0
            {
                [CompilerGenerated]
                get
                {
                    return this.string_0;
                }
                [CompilerGenerated]
                set
                {
                    this.string_0 = value;
                }
            }
        }
    }
}

