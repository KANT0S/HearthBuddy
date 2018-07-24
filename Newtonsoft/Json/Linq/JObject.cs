namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns19;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;

    public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
    {
        private readonly Class79 class79_0;
        [CompilerGenerated]
        private static Func<JProperty, JToken> func_0;

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        public JObject()
        {
            this.class79_0 = new Class79();
        }

        public JObject(JObject other) : base(other)
        {
            this.class79_0 = new Class79();
        }

        public JObject(params object[] content) : this(content)
        {
        }

        public JObject(object content)
        {
            this.class79_0 = new Class79();
            this.Add(content);
        }

        public void Add(string propertyName, JToken value)
        {
            this.Add(new JProperty(propertyName, value));
        }

        public static JObject FromObject(object o)
        {
            return FromObject(o, JsonSerializer.CreateDefault());
        }

        public static JObject FromObject(object o, JsonSerializer jsonSerializer)
        {
            JToken token = JToken.smethod_5(o, jsonSerializer);
            if ((token != null) && (token.Type != JTokenType.Object))
            {
                throw new ArgumentException("Object serialized to {0}. JObject instance expected.".smethod_0(CultureInfo.InvariantCulture, token.Type));
            }
            return (JObject) token;
        }

        public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
        {
            this.ienumerator_0 = this.class79_0.GetEnumerator();
            while (true)
            {
                if (!this.ienumerator_0.MoveNext())
                {
                    this.method_0();
                }
                this.jproperty_0 = (JProperty) this.ienumerator_0.Current;
                yield return new KeyValuePair<string, JToken>(this.jproperty_0.Name, this.jproperty_0.Value);
            }
        }

        protected override DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new Class143<JObject>(parameter, this, new Class87(), true);
        }

        public JToken GetValue(string propertyName)
        {
            return this.GetValue(propertyName, StringComparison.Ordinal);
        }

        public JToken GetValue(string propertyName, StringComparison comparison)
        {
            if (propertyName == null)
            {
                return null;
            }
            JProperty property = this.Property(propertyName);
            if (property != null)
            {
                return property.Value;
            }
            if (comparison != StringComparison.Ordinal)
            {
                JToken token;
                using (IEnumerator<JToken> enumerator = this.class79_0.GetEnumerator())
                {
                    JProperty current;
                    while (enumerator.MoveNext())
                    {
                        current = (JProperty) enumerator.Current;
                        if (string.Equals(current.Name, propertyName, comparison))
                        {
                            goto Label_004F;
                        }
                    }
                    goto Label_0064;
                Label_004F:
                    token = current.Value;
                }
                return token;
            }
        Label_0064:
            return null;
        }

        public static JObject Load(JsonReader reader)
        {
            Class203.smethod_2(reader, "reader");
            if ((reader.JsonToken_0 == JsonToken.None) && !reader.Read())
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JObject from JsonReader.");
            }
            while (reader.JsonToken_0 == JsonToken.Comment)
            {
                reader.Read();
            }
            if (reader.JsonToken_0 != JsonToken.StartObject)
            {
                throw JsonReaderException.smethod_1(reader, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            JObject obj2 = new JObject();
            obj2.method_0(reader as IJsonLineInfo);
            obj2.method_10(reader);
            return obj2;
        }

        internal void method_14(JProperty jproperty_0)
        {
            this.OnPropertyChanged(jproperty_0.Name);
            if (base.listChangedEventHandler_0 != null)
            {
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, base.method_6(jproperty_0)));
            }
            if (base.notifyCollectionChangedEventHandler_0 != null)
            {
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, jproperty_0, jproperty_0, base.method_6(jproperty_0)));
            }
        }

        internal void method_15(JProperty jproperty_0)
        {
            this.OnPropertyChanging(jproperty_0.Name);
        }

        void JContainer.⁭⁬‭⁯‏‌‏‌⁫⁯‫‌‍⁭‌⁪‮‮‫⁬‎‫⁮‫⁪‬‌⁮‭‫​‏‮‪‮‪‌‍‭‪‮(JToken jtoken_2, JToken jtoken_3)
        {
            Class203.smethod_2(jtoken_2, "o");
            if (jtoken_2.Type != JTokenType.Property)
            {
                throw new ArgumentException("Can not add {0} to {1}.".smethod_1(CultureInfo.InvariantCulture, jtoken_2.GetType(), base.GetType()));
            }
            JProperty property = (JProperty) jtoken_2;
            if (jtoken_3 != null)
            {
                JProperty property2 = (JProperty) jtoken_3;
                if (property.Name == property2.Name)
                {
                    return;
                }
            }
            if (this.class79_0.method_8(property.Name, out jtoken_3))
            {
                throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".smethod_1(CultureInfo.InvariantCulture, property.Name, base.GetType()));
            }
        }

        void JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(int int_0, JToken jtoken_2, bool bool_1)
        {
            if ((jtoken_2 == null) || (jtoken_2.Type != JTokenType.Comment))
            {
                base.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(int_0, jtoken_2, bool_1);
            }
        }

        int JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮()
        {
            return base.method_12();
        }

        bool JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(JToken jtoken_2)
        {
            JObject obj2 = jtoken_2 as JObject;
            if (obj2 == null)
            {
                return false;
            }
            return this.class79_0.method_9(obj2.class79_0);
        }

        JToken JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮()
        {
            return new JObject(this);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.propertyChangedEventHandler_0 != null)
            {
                this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void OnPropertyChanging(string propertyName)
        {
            if (this.propertyChangingEventHandler_0 != null)
            {
                this.propertyChangingEventHandler_0(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        public static JObject Parse(string json)
        {
            JsonReader reader = new JsonTextReader(new StringReader(json));
            JObject obj2 = Load(reader);
            if (reader.Read() && (reader.JsonToken_0 != JsonToken.Comment))
            {
                throw JsonReaderException.smethod_1(reader, "Additional text found in JSON string after parsing content.");
            }
            return obj2;
        }

        public IEnumerable<JProperty> Properties()
        {
            return this.class79_0.Cast<JProperty>();
        }

        public JProperty Property(string name)
        {
            JToken token;
            if (name == null)
            {
                return null;
            }
            this.class79_0.method_8(name, out token);
            return (JProperty) token;
        }

        public JEnumerable<JToken> PropertyValues()
        {
            if (func_0 == null)
            {
                func_0 = new Func<JProperty, JToken>(JObject.smethod_8);
            }
            return new JEnumerable<JToken>(this.Properties().Select<JProperty, JToken>(func_0));
        }

        public bool Remove(string propertyName)
        {
            JProperty property = this.Property(propertyName);
            if (property == null)
            {
                return false;
            }
            property.Remove();
            return true;
        }

        private static System.Type smethod_7(JToken jtoken_2)
        {
            if (!(jtoken_2 is JValue))
            {
                return jtoken_2.GetType();
            }
            JValue value2 = (JValue) jtoken_2;
            if (value2.Value == null)
            {
                return typeof(object);
            }
            return value2.Value.GetType();
        }

        [CompilerGenerated]
        private static JToken smethod_8(JProperty jproperty_0)
        {
            return jproperty_0.Value;
        }

        void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item)
        {
            this.Add(new JProperty(item.Key, item.Value));
        }

        void ICollection<KeyValuePair<string, JToken>>.Clear()
        {
            base.RemoveAll();
        }

        bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item)
        {
            JProperty property = this.Property(item.Key);
            if (property == null)
            {
                return false;
            }
            return (property.Value == item.Value);
        }

        void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
            }
            if ((arrayIndex >= array.Length) && (arrayIndex != 0))
            {
                throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
            }
            if (base.Count > (array.Length - arrayIndex))
            {
                throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
            }
            int num = 0;
            foreach (JProperty property in this.class79_0)
            {
                array[arrayIndex + num] = new KeyValuePair<string, JToken>(property.Name, property.Value);
                num++;
            }
        }

        bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item)
        {
            if (!((ICollection<KeyValuePair<string, JToken>>) this).Contains(item))
            {
                return false;
            }
            this.Remove(item.Key);
            return true;
        }

        bool IDictionary<string, JToken>.ContainsKey(string key)
        {
            return this.class79_0.method_2(key);
        }

        AttributeCollection ICustomTypeDescriptor.GetAttributes()
        {
            return AttributeCollection.Empty;
        }

        string ICustomTypeDescriptor.GetClassName()
        {
            return null;
        }

        string ICustomTypeDescriptor.GetComponentName()
        {
            return null;
        }

        TypeConverter ICustomTypeDescriptor.GetConverter()
        {
            return new TypeConverter();
        }

        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
        {
            return null;
        }

        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
        {
            return null;
        }

        object ICustomTypeDescriptor.GetEditor(System.Type editorBaseType)
        {
            return null;
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return EventDescriptorCollection.Empty;
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
        {
            return EventDescriptorCollection.Empty;
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            return ((ICustomTypeDescriptor) this).GetProperties(null);
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection descriptors = new PropertyDescriptorCollection(null);
            foreach (KeyValuePair<string, JToken> pair in this)
            {
                descriptors.Add(new JPropertyDescriptor(pair.Key, smethod_7(pair.Value)));
            }
            return descriptors;
        }

        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
        {
            return null;
        }

        public bool TryGetValue(string propertyName, out JToken value)
        {
            JProperty property = this.Property(propertyName);
            if (property == null)
            {
                value = null;
                return false;
            }
            value = property.Value;
            return true;
        }

        public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value)
        {
            value = this.GetValue(propertyName, comparison);
            return (value != null);
        }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
        {
            writer.WriteStartObject();
            for (int i = 0; i < this.class79_0.Count; i++)
            {
                this.class79_0[i].WriteTo(writer, converters);
            }
            writer.WriteEndObject();
        }

        protected override IList<JToken> ChildrenTokens
        {
            get
            {
                return this.class79_0;
            }
        }

        public override JToken this[object key]
        {
            get
            {
                Class203.smethod_2(key, "o");
                string str = key as string;
                if (str == null)
                {
                    throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".smethod_0(CultureInfo.InvariantCulture, Class193.smethod_2(key)));
                }
                return this[str];
            }
            set
            {
                Class203.smethod_2(key, "o");
                string str = key as string;
                if (str == null)
                {
                    throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".smethod_0(CultureInfo.InvariantCulture, Class193.smethod_2(key)));
                }
                this[str] = value;
            }
        }

        public JToken this[string propertyName]
        {
            get
            {
                Class203.smethod_2(propertyName, "propertyName");
                JProperty property = this.Property(propertyName);
                if (property == null)
                {
                    return null;
                }
                return property.Value;
            }
            set
            {
                JProperty property = this.Property(propertyName);
                if (property != null)
                {
                    property.Value = value;
                }
                else
                {
                    this.OnPropertyChanging(propertyName);
                    this.Add(new JProperty(propertyName, value));
                    this.OnPropertyChanged(propertyName);
                }
            }
        }

        bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        ICollection<string> IDictionary<string, JToken>.Keys
        {
            get
            {
                return this.class79_0.ICollection_0;
            }
        }

        ICollection<JToken> IDictionary<string, JToken>.Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override JTokenType Type
        {
            get
            {
                return JTokenType.Object;
            }
        }


        private class Class87 : Class85<JObject>
        {
            [CompilerGenerated]
            private static Func<JProperty, string> func_0;

            public override IEnumerable<string> ns20.Class85<Newtonsoft.Json.Linq.JObject>.‏‎‪‫⁭‫‎⁮‮⁮‏‭‌‍‎‬‍‪⁯‭‍‌‬‌​‬⁬‍⁭‫‮‮⁬‏‫‫‎‮⁬‮‮(JObject jobject_0)
            {
                if (func_0 == null)
                {
                    func_0 = new Func<JProperty, string>(JObject.Class87.smethod_0);
                }
                return jobject_0.Properties().Select<JProperty, string>(func_0);
            }

            public override bool ns20.Class85<Newtonsoft.Json.Linq.JObject>.‏​⁫‪‭‍‎⁫‮‍‮‎‏‭‫​‪⁪‍​‬⁬⁪‎‏⁮‫‎‮‏⁭‏‫‎‎⁫‫‮‍⁮‮(JObject jobject_0, SetMemberBinder setMemberBinder_0, object object_0)
            {
                JToken token = object_0 as JToken;
                if (token == null)
                {
                    token = new JValue(object_0);
                }
                jobject_0[setMemberBinder_0.Name] = token;
                return true;
            }

            public override bool ns20.Class85<Newtonsoft.Json.Linq.JObject>.⁭⁬‍‌⁭‬‮‬⁫‎‎​‫​⁯⁮‮⁮⁪⁬‮⁫​⁮‬‏​⁯⁯‮⁫⁬‎‬​⁫​‍‍‮‮(JObject jobject_0, GetMemberBinder getMemberBinder_0, out object object_0)
            {
                object_0 = jobject_0[getMemberBinder_0.Name];
                return true;
            }

            [CompilerGenerated]
            private static string smethod_0(JProperty jproperty_0)
            {
                return jproperty_0.Name;
            }
        }
    }
}

