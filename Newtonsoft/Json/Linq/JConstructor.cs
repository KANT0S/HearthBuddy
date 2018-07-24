namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;

    public class JConstructor : JContainer
    {
        private readonly List<JToken> list_0;
        private string string_0;

        public JConstructor()
        {
            this.list_0 = new List<JToken>();
        }

        public JConstructor(JConstructor other) : base(other)
        {
            this.list_0 = new List<JToken>();
            this.string_0 = other.Name;
        }

        public JConstructor(string name)
        {
            this.list_0 = new List<JToken>();
            Class203.smethod_0(name, "name");
            this.string_0 = name;
        }

        public JConstructor(string name, params object[] content) : this(name, content)
        {
        }

        public JConstructor(string name, object content) : this(name)
        {
            this.Add(content);
        }

        public static JConstructor Load(JsonReader reader)
        {
            if ((reader.JsonToken_0 == JsonToken.None) && !reader.Read())
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JConstructor from JsonReader.");
            }
            while (reader.JsonToken_0 == JsonToken.Comment)
            {
                reader.Read();
            }
            if (reader.JsonToken_0 != JsonToken.StartConstructor)
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            JConstructor constructor = new JConstructor((string) reader.Object_0);
            constructor.method_0(reader as IJsonLineInfo);
            constructor.method_10(reader);
            return constructor;
        }

        int JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮()
        {
            return (this.string_0.GetHashCode() ^ base.method_12());
        }

        bool JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(JToken jtoken_2)
        {
            JConstructor constructor = jtoken_2 as JConstructor;
            return (((constructor != null) && (this.string_0 == constructor.Name)) && base.method_3(constructor));
        }

        JToken JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮()
        {
            return new JConstructor(this);
        }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
        {
            writer.WriteStartConstructor(this.string_0);
            foreach (JToken token in this.Children())
            {
                token.WriteTo(writer, converters);
            }
            writer.WriteEndConstructor();
        }

        protected override IList<JToken> ChildrenTokens
        {
            get
            {
                return this.list_0;
            }
        }

        public override JToken this[object key]
        {
            get
            {
                Class203.smethod_2(key, "o");
                if (!(key is int))
                {
                    throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".smethod_0(CultureInfo.InvariantCulture, Class193.smethod_2(key)));
                }
                return this.Newtonsoft.Json.Linq.JContainer.‌⁭‏⁯‎‫⁭‍⁯⁬‫⁪⁬‮‎‫⁫‫‭⁭⁪‎⁮⁬‭‮⁬⁪‭‎‫⁭⁬‎‍⁯‏‏‭‏‮((int) key);
            }
            set
            {
                Class203.smethod_2(key, "o");
                if (!(key is int))
                {
                    throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".smethod_0(CultureInfo.InvariantCulture, Class193.smethod_2(key)));
                }
                this.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮((int) key, value);
            }
        }

        public string Name
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

        public override JTokenType Type
        {
            get
            {
                return JTokenType.Constructor;
            }
        }
    }
}

