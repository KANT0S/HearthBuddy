namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Reflection;

    public class JArray : JContainer, IEnumerable<JToken>, IList<JToken>, ICollection<JToken>, IEnumerable
    {
        private readonly List<JToken> list_0;

        public JArray()
        {
            this.list_0 = new List<JToken>();
        }

        public JArray(JArray other) : base(other)
        {
            this.list_0 = new List<JToken>();
        }

        public JArray(params object[] content) : this(content)
        {
        }

        public JArray(object content)
        {
            this.list_0 = new List<JToken>();
            this.Add(content);
        }

        public void Add(JToken item)
        {
            this.Add(item);
        }

        public void Clear()
        {
            this.Newtonsoft.Json.Linq.JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮();
        }

        public bool Contains(JToken item)
        {
            return this.Newtonsoft.Json.Linq.JContainer.⁪​‌‫‭‮‫‬⁫‮⁪‬‫‬‍‫‭‍‍‍‏⁫‫‏‬‬‭‭‬⁪‮‍‏‫‍‫⁪​‫‌‮(item);
        }

        public void CopyTo(JToken[] array, int arrayIndex)
        {
            this.vmethod_2(array, arrayIndex);
        }

        public static JArray FromObject(object o)
        {
            return FromObject(o, JsonSerializer.CreateDefault());
        }

        public static JArray FromObject(object o, JsonSerializer jsonSerializer)
        {
            JToken token = JToken.smethod_5(o, jsonSerializer);
            if (token.Type != JTokenType.Array)
            {
                throw new ArgumentException("Object serialized to {0}. JArray instance expected.".smethod_0(CultureInfo.InvariantCulture, token.Type));
            }
            return (JArray) token;
        }

        public IEnumerator<JToken> GetEnumerator()
        {
            return this.Children().GetEnumerator();
        }

        public int IndexOf(JToken item)
        {
            return base.method_6(item);
        }

        public void Insert(int index, JToken item)
        {
            this.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(index, item, false);
        }

        public static JArray Load(JsonReader reader)
        {
            if ((reader.JsonToken_0 == JsonToken.None) && !reader.Read())
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JArray from JsonReader.");
            }
            while (reader.JsonToken_0 == JsonToken.Comment)
            {
                reader.Read();
            }
            if (reader.JsonToken_0 != JsonToken.StartArray)
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            JArray array = new JArray();
            array.method_0(reader as IJsonLineInfo);
            array.method_10(reader);
            return array;
        }

        int JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮()
        {
            return base.method_12();
        }

        bool JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(JToken jtoken_2)
        {
            JArray array = jtoken_2 as JArray;
            return ((array != null) && base.method_3(array));
        }

        JToken JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮()
        {
            return new JArray(this);
        }

        public static JArray Parse(string json)
        {
            JsonReader reader = new JsonTextReader(new StringReader(json));
            JArray array = Load(reader);
            if (reader.Read() && (reader.JsonToken_0 != JsonToken.Comment))
            {
                throw JsonReaderException.smethod_1(reader, "Additional text found in JSON string after parsing content.");
            }
            return array;
        }

        public bool Remove(JToken item)
        {
            return this.Newtonsoft.Json.Linq.JContainer.‪⁯⁮‭‪‭⁬⁫‮‮⁫‍‏‪⁮‭‏⁮⁮⁯⁫​‏‪‌‍⁬‏⁪⁯​⁪‮⁪‍‌‮‪‏⁮‮(item);
        }

        public void RemoveAt(int index)
        {
            this.Newtonsoft.Json.Linq.JContainer.‎⁭⁪‬​⁫⁯​‪‎⁯⁭‮​⁮‮‮⁭​‭‫‏​⁫​⁮‬‪‌‌‬‮‎‬⁪‌⁫‭‌‮(index);
        }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
        {
            writer.WriteStartArray();
            for (int i = 0; i < this.list_0.Count; i++)
            {
                this.list_0[i].WriteTo(writer, converters);
            }
            writer.WriteEndArray();
        }

        protected override IList<JToken> ChildrenTokens
        {
            get
            {
                return this.list_0;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public override JToken this[object key]
        {
            get
            {
                Class203.smethod_2(key, "o");
                if (!(key is int))
                {
                    throw new ArgumentException("Accessed JArray values with invalid key value: {0}. Array position index expected.".smethod_0(CultureInfo.InvariantCulture, Class193.smethod_2(key)));
                }
                return this.Newtonsoft.Json.Linq.JContainer.‌⁭‏⁯‎‫⁭‍⁯⁬‫⁪⁬‮‎‫⁫‫‭⁭⁪‎⁮⁬‭‮⁬⁪‭‎‫⁭⁬‎‍⁯‏‏‭‏‮((int) key);
            }
            set
            {
                Class203.smethod_2(key, "o");
                if (!(key is int))
                {
                    throw new ArgumentException("Set JArray values with invalid key value: {0}. Array position index expected.".smethod_0(CultureInfo.InvariantCulture, Class193.smethod_2(key)));
                }
                this.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮((int) key, value);
            }
        }

        public JToken this[int index]
        {
            get
            {
                return this.Newtonsoft.Json.Linq.JContainer.‌⁭‏⁯‎‫⁭‍⁯⁬‫⁪⁬‮‎‫⁫‫‭⁭⁪‎⁮⁬‭‮⁬⁪‭‎‫⁭⁬‎‍⁯‏‏‭‏‮(index);
            }
            set
            {
                this.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(index, value);
            }
        }

        public override JTokenType Type
        {
            get
            {
                return JTokenType.Array;
            }
        }
    }
}

