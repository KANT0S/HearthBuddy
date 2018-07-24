namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;

    public class JProperty : JContainer
    {
        private readonly List<JToken> list_0;
        private readonly string string_0;

        public JProperty(JProperty other) : base(other)
        {
            this.list_0 = new List<JToken>();
            this.string_0 = other.Name;
        }

        internal JProperty(string name)
        {
            this.list_0 = new List<JToken>();
            Class203.smethod_2(name, "name");
            this.string_0 = name;
        }

        public JProperty(string name, params object[] content) : this(name, content)
        {
        }

        public JProperty(string name, object content)
        {
            this.list_0 = new List<JToken>();
            Class203.smethod_2(name, "name");
            this.string_0 = name;
            this.Value = base.method_4(content) ? new JArray(content) : base.method_9(content);
        }

        public static JProperty Load(JsonReader reader)
        {
            if ((reader.JsonToken_0 == JsonToken.None) && !reader.Read())
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JProperty from JsonReader.");
            }
            while (reader.JsonToken_0 == JsonToken.Comment)
            {
                reader.Read();
            }
            if (reader.JsonToken_0 != JsonToken.PropertyName)
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            JProperty property = new JProperty((string) reader.Object_0);
            property.method_0(reader as IJsonLineInfo);
            property.method_10(reader);
            return property;
        }

        void JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮()
        {
            throw new JsonException("Cannot add or remove items from {0}.".smethod_0(CultureInfo.InvariantCulture, typeof(JProperty)));
        }

        JToken JContainer.‌⁭‏⁯‎‫⁭‍⁯⁬‫⁪⁬‮‎‫⁫‫‭⁭⁪‎⁮⁬‭‮⁬⁪‭‎‫⁭⁬‎‍⁯‏‏‭‏‮(int int_0)
        {
            if (int_0 != 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.Value;
        }

        void JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(int int_0, JToken jtoken_2)
        {
            if (int_0 != 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (!JContainer.smethod_6(this.Value, jtoken_2))
            {
                if (base.Parent != null)
                {
                    ((JObject) base.Parent).method_15(this);
                }
                base.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(0, jtoken_2);
                if (base.Parent != null)
                {
                    ((JObject) base.Parent).method_14(this);
                }
            }
        }

        bool JContainer.‪⁯⁮‭‪‭⁬⁫‮‮⁫‍‏‪⁮‭‏⁮⁮⁯⁫​‏‪‌‍⁬‏⁪⁯​⁪‮⁪‍‌‮‪‏⁮‮(JToken jtoken_2)
        {
            throw new JsonException("Cannot add or remove items from {0}.".smethod_0(CultureInfo.InvariantCulture, typeof(JProperty)));
        }

        bool JContainer.⁪​‌‫‭‮‫‬⁫‮⁪‬‫‬‍‫‭‍‍‍‏⁫‫‏‬‬‭‭‬⁪‮‍‏‫‍‫⁪​‫‌‮(JToken jtoken_2)
        {
            return (this.Value == jtoken_2);
        }

        void JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(int int_0, JToken jtoken_2, bool bool_1)
        {
            if (this.Value != null)
            {
                throw new JsonException("{0} cannot have multiple values.".smethod_0(CultureInfo.InvariantCulture, typeof(JProperty)));
            }
            base.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(0, jtoken_2, false);
        }

        void JContainer.‎⁭⁪‬​⁫⁯​‪‎⁯⁭‮​⁮‮‮⁭​‭‫‏​⁫​⁮‬‪‌‌‬‮‎‬⁪‌⁫‭‌‮(int int_0)
        {
            throw new JsonException("Cannot add or remove items from {0}.".smethod_0(CultureInfo.InvariantCulture, typeof(JProperty)));
        }

        int JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮()
        {
            return (this.string_0.GetHashCode() ^ ((this.Value != null) ? this.Value.Newtonsoft.Json.Linq.JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮() : 0));
        }

        bool JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(JToken jtoken_2)
        {
            JProperty property = jtoken_2 as JProperty;
            return (((property != null) && (this.string_0 == property.Name)) && base.method_3(property));
        }

        JToken JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮()
        {
            return new JProperty(this);
        }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
        {
            writer.WritePropertyName(this.string_0);
            JToken token = this.Value;
            if (token != null)
            {
                token.WriteTo(writer, converters);
            }
            else
            {
                writer.WriteNull();
            }
        }

        protected override IList<JToken> ChildrenTokens
        {
            get
            {
                return this.list_0;
            }
        }

        public string Name
        {
            [DebuggerStepThrough]
            get
            {
                return this.string_0;
            }
        }

        public override JTokenType Type
        {
            [DebuggerStepThrough]
            get
            {
                return JTokenType.Property;
            }
        }

        public JToken Value
        {
            [DebuggerStepThrough]
            get
            {
                if (this.list_0.Count <= 0)
                {
                    return null;
                }
                return this.list_0[0];
            }
            set
            {
                base.method_2();
                JToken token = value ?? new JValue(null);
                if (this.list_0.Count == 0)
                {
                    this.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(0, token, false);
                }
                else
                {
                    this.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(0, token);
                }
            }
        }
    }
}

