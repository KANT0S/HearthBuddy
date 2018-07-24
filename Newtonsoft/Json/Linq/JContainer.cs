namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public abstract class JContainer : JToken, IEnumerable<JToken>, IList<JToken>, ICollection<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection, INotifyCollectionChanged
    {
        private bool bool_0;
        private object object_0;

        public event AddingNewEventHandler AddingNew;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event ListChangedEventHandler ListChanged;

        internal JContainer()
        {
        }

        internal JContainer(JContainer other) : this()
        {
            Class203.smethod_2(other, "c");
            foreach (JToken token in (IEnumerable<JToken>) other)
            {
                this.Add(token);
            }
        }

        public virtual void Add(object content)
        {
            this.method_8(this.ChildrenTokens.Count, content, false);
        }

        public void AddFirst(object content)
        {
            this.method_8(0, content, false);
        }

        public override JEnumerable<JToken> Children()
        {
            return new JEnumerable<JToken>(this.ChildrenTokens);
        }

        public JsonWriter CreateWriter()
        {
            return new JTokenWriter(this);
        }

        public IEnumerable<JToken> Descendants()
        {
            this.ienumerator_0 = this.ChildrenTokens.GetEnumerator();
        Label_00A5:
            if (!this.ienumerator_0.MoveNext())
            {
                this.method_0();
            }
            this.jtoken_1 = this.ienumerator_0.Current;
            yield return this.jtoken_1;
            this.jcontainer_1 = this.jtoken_1 as JContainer;
            if (this.jcontainer_1 == null)
            {
                goto Label_00A5;
            }
            this.ienumerator_1 = this.jcontainer_1.Descendants().GetEnumerator();
        Label_PostSwitchInIterator:;
            if (this.ienumerator_1.MoveNext())
            {
                this.jtoken_2 = this.ienumerator_1.Current;
                yield return this.jtoken_2;
                goto Label_PostSwitchInIterator;
            }
            this.method_1();
            goto Label_00A5;
        }

        internal void method_10(JsonReader jsonReader_0)
        {
            int num = jsonReader_0.Int32_0;
            if (!jsonReader_0.Read())
            {
                throw JsonReaderException.smethod_1(jsonReader_0, "Error reading {0} from JsonReader.".smethod_0(CultureInfo.InvariantCulture, base.GetType().Name));
            }
            this.method_11(jsonReader_0);
            if (jsonReader_0.Int32_0 > num)
            {
                throw JsonReaderException.smethod_1(jsonReader_0, "Unexpected end of content while loading {0}.".smethod_0(CultureInfo.InvariantCulture, base.GetType().Name));
            }
        }

        internal void method_11(JsonReader jsonReader_0)
        {
            JValue value2;
            JProperty property;
            Class203.smethod_2(jsonReader_0, "r");
            IJsonLineInfo info = jsonReader_0 as IJsonLineInfo;
            JContainer parent = this;
            goto Label_0204;
        Label_01D8:
            if (!jsonReader_0.Read())
            {
                return;
            }
        Label_0204:
            if ((parent is JProperty) && (((JProperty) parent).Value != null))
            {
                if (parent == this)
                {
                    return;
                }
                parent = parent.Parent;
            }
            switch (jsonReader_0.JsonToken_0)
            {
                case JsonToken.None:
                    goto Label_01D8;

                case JsonToken.StartObject:
                {
                    JObject content = new JObject();
                    content.method_0(info);
                    parent.Add(content);
                    parent = content;
                    goto Label_01D8;
                }
                case JsonToken.StartArray:
                {
                    JArray array = new JArray();
                    array.method_0(info);
                    parent.Add(array);
                    parent = array;
                    goto Label_01D8;
                }
                case JsonToken.StartConstructor:
                {
                    JConstructor constructor = new JConstructor(jsonReader_0.Object_0.ToString());
                    constructor.method_0(constructor);
                    parent.Add(constructor);
                    parent = constructor;
                    goto Label_01D8;
                }
                case JsonToken.PropertyName:
                {
                    string name = jsonReader_0.Object_0.ToString();
                    property = new JProperty(name);
                    property.method_0(info);
                    JProperty property2 = ((JObject) parent).Property(name);
                    if (property2 != null)
                    {
                        property2.Replace(property);
                        break;
                    }
                    parent.Add(property);
                    break;
                }
                case JsonToken.Comment:
                    value2 = JValue.CreateComment(jsonReader_0.Object_0.ToString());
                    value2.method_0(info);
                    parent.Add(value2);
                    goto Label_01D8;

                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    value2 = new JValue(jsonReader_0.Object_0);
                    value2.method_0(info);
                    parent.Add(value2);
                    goto Label_01D8;

                case JsonToken.Null:
                    value2 = new JValue(null, JTokenType.Null);
                    value2.method_0(info);
                    parent.Add(value2);
                    goto Label_01D8;

                case JsonToken.Undefined:
                    value2 = new JValue(null, JTokenType.Undefined);
                    value2.method_0(info);
                    parent.Add(value2);
                    goto Label_01D8;

                case JsonToken.EndObject:
                    if (parent != this)
                    {
                        parent = parent.Parent;
                        goto Label_01D8;
                    }
                    return;

                case JsonToken.EndArray:
                    if (parent != this)
                    {
                        parent = parent.Parent;
                        goto Label_01D8;
                    }
                    return;

                case JsonToken.EndConstructor:
                    if (parent != this)
                    {
                        parent = parent.Parent;
                        goto Label_01D8;
                    }
                    return;

                default:
                    throw new InvalidOperationException("The JsonReader should not be on a token of type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonReader_0.JsonToken_0));
            }
            parent = property;
            goto Label_01D8;
        }

        internal int method_12()
        {
            int num = 0;
            foreach (JToken token in this.ChildrenTokens)
            {
                num ^= token.Newtonsoft.Json.Linq.JToken.⁭⁪⁫‎‭‬‮⁭⁬‌‫⁭‭⁯‍‏‎‬⁬‭⁫‬⁭⁪‪‍⁫⁫‫⁫⁪⁭‭‮‬‫‬‌​⁮‮();
            }
            return num;
        }

        private JToken method_13(object object_1)
        {
            if (object_1 == null)
            {
                return null;
            }
            if (!(object_1 is JToken))
            {
                throw new ArgumentException("Argument is not a JToken.");
            }
            return (JToken) object_1;
        }

        internal void method_2()
        {
            if (this.bool_0)
            {
                throw new InvalidOperationException("Cannot change {0} during a collection change event.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
            }
        }

        internal bool method_3(JContainer jcontainer_1)
        {
            if (jcontainer_1 != this)
            {
                IList<JToken> childrenTokens = this.ChildrenTokens;
                IList<JToken> list2 = jcontainer_1.ChildrenTokens;
                if (childrenTokens.Count != list2.Count)
                {
                    return false;
                }
                for (int i = 0; i < childrenTokens.Count; i++)
                {
                    if (!childrenTokens[i].Newtonsoft.Json.Linq.JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(list2[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal bool method_4(object object_1)
        {
            return ((((object_1 is IEnumerable) && !(object_1 is string)) && !(object_1 is JToken)) && !(object_1 is byte[]));
        }

        internal JToken method_5(JToken jtoken_2, bool bool_1)
        {
            if (jtoken_2 == null)
            {
                return new JValue(null);
            }
            if (!bool_1)
            {
                if (((jtoken_2.Parent == null) && (jtoken_2 != this)) && (!jtoken_2.HasValues || (base.Root != jtoken_2)))
                {
                    return jtoken_2;
                }
                jtoken_2 = jtoken_2.Newtonsoft.Json.Linq.JToken.‎‪⁯‎‫‍⁭⁪‪‬‬⁫‬⁭​‭⁬‏​‭‪​⁫‌⁭‎‌‪‌‌‮‬‪‪⁭⁬⁯⁬‫‮‮();
            }
            return jtoken_2;
        }

        internal int method_6(JToken jtoken_2)
        {
            return this.ChildrenTokens.smethod_9<JToken>(jtoken_2, Class115.class115_0);
        }

        internal void method_7(JToken jtoken_2)
        {
            this.method_8(this.ChildrenTokens.Count, jtoken_2, true);
        }

        internal void method_8(int int_0, object object_1, bool bool_1)
        {
            if (this.method_4(object_1))
            {
                IEnumerable enumerable = (IEnumerable) object_1;
                int num = int_0;
                foreach (object obj2 in enumerable)
                {
                    this.method_8(num, obj2, bool_1);
                    num++;
                }
            }
            else
            {
                JToken token = this.method_9(object_1);
                this.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(int_0, token, bool_1);
            }
        }

        internal JToken method_9(object object_1)
        {
            if (object_1 is JToken)
            {
                return (JToken) object_1;
            }
            return new JValue(object_1);
        }

        internal virtual void Newtonsoft.Json.Linq.JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮()
        {
            this.method_2();
            foreach (JToken token in this.ChildrenTokens)
            {
                token.Parent = null;
                token.Previous = null;
                token.Next = null;
            }
            this.ChildrenTokens.Clear();
            if (this.listChangedEventHandler_0 != null)
            {
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            if (this.notifyCollectionChangedEventHandler_0 != null)
            {
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }

        internal virtual JToken Newtonsoft.Json.Linq.JContainer.‌⁭‏⁯‎‫⁭‍⁯⁬‫⁪⁬‮‎‫⁫‫‭⁭⁪‎⁮⁬‭‮⁬⁪‭‎‫⁭⁬‎‍⁯‏‏‭‏‮(int int_0)
        {
            return this.ChildrenTokens[int_0];
        }

        internal virtual void Newtonsoft.Json.Linq.JContainer.⁭⁬‭⁯‏‌‏‌⁫⁯‫‌‍⁭‌⁪‮‮‫⁬‎‫⁮‫⁪‬‌⁮‭‫​‏‮‪‮‪‌‍‭‪‮(JToken jtoken_2, JToken jtoken_3)
        {
            Class203.smethod_2(jtoken_2, "o");
            if (jtoken_2.Type == JTokenType.Property)
            {
                throw new ArgumentException("Can not add {0} to {1}.".smethod_1(CultureInfo.InvariantCulture, jtoken_2.GetType(), base.GetType()));
            }
        }

        internal virtual void Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(int int_0, JToken jtoken_2)
        {
            if (int_0 < 0)
            {
                throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
            }
            if (int_0 >= this.ChildrenTokens.Count)
            {
                throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
            }
            JToken token = this.ChildrenTokens[int_0];
            if (!smethod_6(token, jtoken_2))
            {
                this.method_2();
                jtoken_2 = this.method_5(jtoken_2, false);
                this.Newtonsoft.Json.Linq.JContainer.⁭⁬‭⁯‏‌‏‌⁫⁯‫‌‍⁭‌⁪‮‮‫⁬‎‫⁮‫⁪‬‌⁮‭‫​‏‮‪‮‪‌‍‭‪‮(jtoken_2, token);
                JToken token2 = (int_0 == 0) ? null : this.ChildrenTokens[int_0 - 1];
                JToken token3 = (int_0 == (this.ChildrenTokens.Count - 1)) ? null : this.ChildrenTokens[int_0 + 1];
                jtoken_2.Parent = this;
                jtoken_2.Previous = token2;
                if (token2 != null)
                {
                    token2.Next = jtoken_2;
                }
                jtoken_2.Next = token3;
                if (token3 != null)
                {
                    token3.Previous = jtoken_2;
                }
                this.ChildrenTokens[int_0] = jtoken_2;
                token.Parent = null;
                token.Previous = null;
                token.Next = null;
                if (this.listChangedEventHandler_0 != null)
                {
                    this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, int_0));
                }
                if (this.notifyCollectionChangedEventHandler_0 != null)
                {
                    this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, jtoken_2, token, int_0));
                }
            }
        }

        internal virtual bool Newtonsoft.Json.Linq.JContainer.‪⁯⁮‭‪‭⁬⁫‮‮⁫‍‏‪⁮‭‏⁮⁮⁯⁫​‏‪‌‍⁬‏⁪⁯​⁪‮⁪‍‌‮‪‏⁮‮(JToken jtoken_2)
        {
            int num = this.method_6(jtoken_2);
            if (num >= 0)
            {
                this.Newtonsoft.Json.Linq.JContainer.‎⁭⁪‬​⁫⁯​‪‎⁯⁭‮​⁮‮‮⁭​‭‫‏​⁫​⁮‬‪‌‌‬‮‎‬⁪‌⁫‭‌‮(num);
                return true;
            }
            return false;
        }

        internal virtual bool Newtonsoft.Json.Linq.JContainer.⁪​‌‫‭‮‫‬⁫‮⁪‬‫‬‍‫‭‍‍‍‏⁫‫‏‬‬‭‭‬⁪‮‍‏‫‍‫⁪​‫‌‮(JToken jtoken_2)
        {
            return (this.method_6(jtoken_2) != -1);
        }

        internal virtual void Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(int int_0, JToken jtoken_2, bool bool_1)
        {
            if (int_0 > this.ChildrenTokens.Count)
            {
                throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
            }
            this.method_2();
            jtoken_2 = this.method_5(jtoken_2, bool_1);
            JToken token = (int_0 == 0) ? null : this.ChildrenTokens[int_0 - 1];
            JToken token2 = (int_0 == this.ChildrenTokens.Count) ? null : this.ChildrenTokens[int_0];
            this.Newtonsoft.Json.Linq.JContainer.⁭⁬‭⁯‏‌‏‌⁫⁯‫‌‍⁭‌⁪‮‮‫⁬‎‫⁮‫⁪‬‌⁮‭‫​‏‮‪‮‪‌‍‭‪‮(jtoken_2, null);
            jtoken_2.Parent = this;
            jtoken_2.Previous = token;
            if (token != null)
            {
                token.Next = jtoken_2;
            }
            jtoken_2.Next = token2;
            if (token2 != null)
            {
                token2.Previous = jtoken_2;
            }
            this.ChildrenTokens.Insert(int_0, jtoken_2);
            if (this.listChangedEventHandler_0 != null)
            {
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, int_0));
            }
            if (this.notifyCollectionChangedEventHandler_0 != null)
            {
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, jtoken_2, int_0));
            }
        }

        internal virtual void Newtonsoft.Json.Linq.JContainer.‎⁭⁪‬​⁫⁯​‪‎⁯⁭‮​⁮‮‮⁭​‭‫‏​⁫​⁮‬‪‌‌‬‮‎‬⁪‌⁫‭‌‮(int int_0)
        {
            if (int_0 < 0)
            {
                throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
            }
            if (int_0 >= this.ChildrenTokens.Count)
            {
                throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
            }
            this.method_2();
            JToken changedItem = this.ChildrenTokens[int_0];
            JToken token2 = (int_0 == 0) ? null : this.ChildrenTokens[int_0 - 1];
            JToken token3 = (int_0 == (this.ChildrenTokens.Count - 1)) ? null : this.ChildrenTokens[int_0 + 1];
            if (token2 != null)
            {
                token2.Next = token3;
            }
            if (token3 != null)
            {
                token3.Previous = token2;
            }
            changedItem.Parent = null;
            changedItem.Previous = null;
            changedItem.Next = null;
            this.ChildrenTokens.RemoveAt(int_0);
            if (this.listChangedEventHandler_0 != null)
            {
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, int_0));
            }
            if (this.notifyCollectionChangedEventHandler_0 != null)
            {
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, changedItem, int_0));
            }
        }

        protected virtual void OnAddingNew(AddingNewEventArgs e)
        {
            AddingNewEventHandler handler = this.addingNewEventHandler_0;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler handler = this.notifyCollectionChangedEventHandler_0;
            if (handler != null)
            {
                this.bool_0 = true;
                try
                {
                    handler(this, e);
                }
                finally
                {
                    this.bool_0 = false;
                }
            }
        }

        protected virtual void OnListChanged(ListChangedEventArgs e)
        {
            ListChangedEventHandler handler = this.listChangedEventHandler_0;
            if (handler != null)
            {
                this.bool_0 = true;
                try
                {
                    handler(this, e);
                }
                finally
                {
                    this.bool_0 = false;
                }
            }
        }

        public void RemoveAll()
        {
            this.Newtonsoft.Json.Linq.JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮();
        }

        public void ReplaceAll(object content)
        {
            this.Newtonsoft.Json.Linq.JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮();
            this.Add(content);
        }

        internal static bool smethod_6(JToken jtoken_2, JToken jtoken_3)
        {
            JValue value2 = jtoken_2 as JValue;
            if (value2 == null)
            {
                return false;
            }
            return (((value2.Type == JTokenType.Null) && (jtoken_3 == null)) || value2.Equals(jtoken_3));
        }

        void ICollection<JToken>.Add(JToken item)
        {
            this.Add(item);
        }

        void ICollection<JToken>.Clear()
        {
            this.Newtonsoft.Json.Linq.JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮();
        }

        bool ICollection<JToken>.Contains(JToken item)
        {
            return this.Newtonsoft.Json.Linq.JContainer.⁪​‌‫‭‮‫‬⁫‮⁪‬‫‬‍‫‭‍‍‍‏⁫‫‏‬‬‭‭‬⁪‮‍‏‫‍‫⁪​‫‌‮(item);
        }

        void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
        {
            this.vmethod_2(array, arrayIndex);
        }

        bool ICollection<JToken>.Remove(JToken item)
        {
            return this.Newtonsoft.Json.Linq.JContainer.‪⁯⁮‭‪‭⁬⁫‮‮⁫‍‏‪⁮‭‏⁮⁮⁯⁫​‏‪‌‍⁬‏⁪⁯​⁪‮⁪‍‌‮‪‏⁮‮(item);
        }

        int IList<JToken>.IndexOf(JToken item)
        {
            return this.method_6(item);
        }

        void IList<JToken>.Insert(int index, JToken item)
        {
            this.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(index, item, false);
        }

        void IList<JToken>.RemoveAt(int index)
        {
            this.Newtonsoft.Json.Linq.JContainer.‎⁭⁪‬​⁫⁯​‪‎⁯⁭‮​⁮‮‮⁭​‭‫‏​⁫​⁮‬‪‌‌‬‮‎‬⁪‌⁫‭‌‮(index);
        }

        void ICollection.CopyTo(Array array, int index)
        {
            this.vmethod_2(array, index);
        }

        int IList.Add(object value)
        {
            this.Add(this.method_13(value));
            return (this.Count - 1);
        }

        void IList.Clear()
        {
            this.Newtonsoft.Json.Linq.JContainer.⁯‭‏‮‌‮‏⁪⁯‌‫‎‌⁪⁮⁬⁪⁬⁮‎‮⁭⁬⁯⁮⁭⁬⁭⁮‪⁬‬⁬‌⁯⁫‬‪‎‫‮();
        }

        bool IList.Contains(object value)
        {
            return this.Newtonsoft.Json.Linq.JContainer.⁪​‌‫‭‮‫‬⁫‮⁪‬‫‬‍‫‭‍‍‍‏⁫‫‏‬‬‭‭‬⁪‮‍‏‫‍‫⁪​‫‌‮(this.method_13(value));
        }

        int IList.IndexOf(object value)
        {
            return this.method_6(this.method_13(value));
        }

        void IList.Insert(int index, object value)
        {
            this.Newtonsoft.Json.Linq.JContainer.‎‎‮⁮‌⁪‪​⁯‬‎‭⁬‭⁮⁫⁫​‭⁫‌⁪‌‏‏‬‫‮‎⁭⁯‫⁪‫⁯⁪⁬⁫‫‫‮(index, this.method_13(value), false);
        }

        void IList.Remove(object value)
        {
            this.Newtonsoft.Json.Linq.JContainer.‪⁯⁮‭‪‭⁬⁫‮‮⁫‍‏‪⁮‭‏⁮⁮⁯⁫​‏‪‌‍⁬‏⁪⁯​⁪‮⁪‍‌‮‪‏⁮‮(this.method_13(value));
        }

        void IList.RemoveAt(int index)
        {
            this.Newtonsoft.Json.Linq.JContainer.‎⁭⁪‬​⁫⁯​‪‎⁯⁭‮​⁮‮‮⁭​‭‫‏​⁫​⁮‬‪‌‌‬‮‎‬⁪‌⁫‭‌‮(index);
        }

        void IBindingList.AddIndex(PropertyDescriptor property)
        {
        }

        object IBindingList.AddNew()
        {
            AddingNewEventArgs e = new AddingNewEventArgs();
            this.OnAddingNew(e);
            if (e.NewObject == null)
            {
                throw new JsonException("Could not determine new value to add to '{0}'.".smethod_0(CultureInfo.InvariantCulture, base.GetType()));
            }
            if (!(e.NewObject is JToken))
            {
                throw new JsonException("New item to be added to collection must be compatible with {0}.".smethod_0(CultureInfo.InvariantCulture, typeof(JToken)));
            }
            JToken newObject = (JToken) e.NewObject;
            this.Add(newObject);
            return newObject;
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotSupportedException();
        }

        int IBindingList.Find(PropertyDescriptor property, object key)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property)
        {
        }

        void IBindingList.RemoveSort()
        {
            throw new NotSupportedException();
        }

        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            ICustomTypeDescriptor first = this.First as ICustomTypeDescriptor;
            if (first != null)
            {
                return first.GetProperties();
            }
            return null;
        }

        string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
        {
            return string.Empty;
        }

        public override IEnumerable<T> Values<T>()
        {
            return this.ChildrenTokens.smethod_1<JToken, T>();
        }

        internal virtual IList<JToken> vmethod_0()
        {
            return new List<JToken>();
        }

        internal virtual void vmethod_1(JToken jtoken_2, JToken jtoken_3)
        {
            if ((jtoken_2 != null) && (jtoken_2.Parent == this))
            {
                int num = this.method_6(jtoken_2);
                this.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(num, jtoken_3);
            }
        }

        internal virtual void vmethod_2(Array array_0, int int_0)
        {
            if (array_0 == null)
            {
                throw new ArgumentNullException("array");
            }
            if (int_0 < 0)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
            }
            if ((int_0 >= array_0.Length) && (int_0 != 0))
            {
                throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
            }
            if (this.Count > (array_0.Length - int_0))
            {
                throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
            }
            int num = 0;
            foreach (JToken token in this.ChildrenTokens)
            {
                array_0.SetValue(token, (int) (int_0 + num));
                num++;
            }
        }

        protected abstract IList<JToken> ChildrenTokens { get; }

        public int Count
        {
            get
            {
                return this.ChildrenTokens.Count;
            }
        }

        public override JToken First
        {
            get
            {
                return this.ChildrenTokens.FirstOrDefault<JToken>();
            }
        }

        public override bool HasValues
        {
            get
            {
                return (this.ChildrenTokens.Count > 0);
            }
        }

        public override JToken Last
        {
            get
            {
                return this.ChildrenTokens.LastOrDefault<JToken>();
            }
        }

        bool ICollection<JToken>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        JToken IList<JToken>.this[int index]
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

        bool ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                if (this.object_0 == null)
                {
                    Interlocked.CompareExchange(ref this.object_0, new object(), null);
                }
                return this.object_0;
            }
        }

        bool IList.IsFixedSize
        {
            get
            {
                return false;
            }
        }

        bool IList.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        object IList.this[int index]
        {
            get
            {
                return this.Newtonsoft.Json.Linq.JContainer.‌⁭‏⁯‎‫⁭‍⁯⁬‫⁪⁬‮‎‫⁫‫‭⁭⁪‎⁮⁬‭‮⁬⁪‭‎‫⁭⁬‎‍⁯‏‏‭‏‮(index);
            }
            set
            {
                this.Newtonsoft.Json.Linq.JContainer.‌‍‌‮⁯‍⁭‍⁪‭⁪‬‏‏‫‎‫​‌⁭⁮‌⁫⁫⁬‮‌‬⁯‪⁯⁫‮‬‏‍‏⁮‮‏‮(index, this.method_13(value));
            }
        }

        bool IBindingList.AllowEdit
        {
            get
            {
                return true;
            }
        }

        bool IBindingList.AllowNew
        {
            get
            {
                return true;
            }
        }

        bool IBindingList.AllowRemove
        {
            get
            {
                return true;
            }
        }

        bool IBindingList.IsSorted
        {
            get
            {
                return false;
            }
        }

        ListSortDirection IBindingList.SortDirection
        {
            get
            {
                return ListSortDirection.Ascending;
            }
        }

        PropertyDescriptor IBindingList.SortProperty
        {
            get
            {
                return null;
            }
        }

        bool IBindingList.SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }

        bool IBindingList.SupportsSearching
        {
            get
            {
                return false;
            }
        }

        bool IBindingList.SupportsSorting
        {
            get
            {
                return false;
            }
        }

        private class Class115 : IEqualityComparer<JToken>
        {
            public static readonly JContainer.Class115 class115_0 = new JContainer.Class115();

            public bool Equals(JToken x, JToken y)
            {
                return object.ReferenceEquals(x, y);
            }

            public int GetHashCode(JToken obj)
            {
                if (obj == null)
                {
                    return 0;
                }
                return obj.GetHashCode();
            }
        }

    }
}

