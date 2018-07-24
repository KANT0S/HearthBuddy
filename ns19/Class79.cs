namespace ns19
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using System.Runtime.InteropServices;

    internal class Class79 : Collection<JToken>
    {
        private Dictionary<string, JToken> dictionary_0;
        private static readonly IEqualityComparer<string> iequalityComparer_0 = StringComparer.Ordinal;

        private void method_0(string string_0, JToken jtoken_0)
        {
            this.method_4();
            this.dictionary_0[string_0] = jtoken_0;
        }

        protected void method_1(JToken jtoken_0, string string_0)
        {
            if (!this.method_3(jtoken_0))
            {
                throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
            }
            string x = this.method_5(jtoken_0);
            if (!iequalityComparer_0.Equals(x, string_0))
            {
                if (string_0 != null)
                {
                    this.method_0(string_0, jtoken_0);
                }
                if (x != null)
                {
                    this.method_7(x);
                }
            }
        }

        public bool method_2(string string_0)
        {
            if (string_0 == null)
            {
                throw new ArgumentNullException("key");
            }
            return ((this.dictionary_0 != null) && this.dictionary_0.ContainsKey(string_0));
        }

        private bool method_3(JToken jtoken_0)
        {
            JToken token;
            if (this.dictionary_0 == null)
            {
                return false;
            }
            string key = this.method_5(jtoken_0);
            return this.dictionary_0.TryGetValue(key, out token);
        }

        private void method_4()
        {
            if (this.dictionary_0 == null)
            {
                this.dictionary_0 = new Dictionary<string, JToken>(iequalityComparer_0);
            }
        }

        private string method_5(JToken jtoken_0)
        {
            return ((JProperty) jtoken_0).Name;
        }

        public bool method_6(string string_0)
        {
            if (string_0 == null)
            {
                throw new ArgumentNullException("key");
            }
            if (this.dictionary_0 == null)
            {
                return false;
            }
            return (this.dictionary_0.ContainsKey(string_0) && base.Remove(this.dictionary_0[string_0]));
        }

        private void method_7(string string_0)
        {
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Remove(string_0);
            }
        }

        public bool method_8(string string_0, out JToken jtoken_0)
        {
            if (this.dictionary_0 == null)
            {
                jtoken_0 = null;
                return false;
            }
            return this.dictionary_0.TryGetValue(string_0, out jtoken_0);
        }

        public bool method_9(Class79 class79_0)
        {
            if (this != class79_0)
            {
                Dictionary<string, JToken> dictionary = this.dictionary_0;
                Dictionary<string, JToken> dictionary2 = class79_0.dictionary_0;
                if ((dictionary == null) && (dictionary2 == null))
                {
                    return true;
                }
                if (dictionary == null)
                {
                    return (dictionary2.Count == 0);
                }
                if (dictionary2 == null)
                {
                    return (dictionary.Count == 0);
                }
                if (dictionary.Count != dictionary2.Count)
                {
                    return false;
                }
                foreach (KeyValuePair<string, JToken> pair in dictionary)
                {
                    JToken token;
                    if (!dictionary2.TryGetValue(pair.Key, out token))
                    {
                        return false;
                    }
                    JProperty property = (JProperty) pair.Value;
                    JProperty property2 = (JProperty) token;
                    if (!property.Value.Newtonsoft.Json.Linq.JToken.‎⁮‮⁬⁯⁫​‍⁮⁭⁭‫⁫⁯⁫⁮⁬⁮‌⁫⁭⁬⁪⁯‎‮⁬‌‬​‬⁫‏‎‌‬‌‪⁭⁮‮(property2.Value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        void Collection<JToken>.ClearItems()
        {
            base.ClearItems();
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
            }
        }

        void Collection<JToken>.InsertItem(int index, JToken item)
        {
            this.method_0(this.method_5(item), item);
            base.InsertItem(index, item);
        }

        void Collection<JToken>.RemoveItem(int index)
        {
            string str = this.method_5(base.Items[index]);
            this.method_7(str);
            base.RemoveItem(index);
        }

        void Collection<JToken>.SetItem(int index, JToken item)
        {
            string y = this.method_5(item);
            string x = this.method_5(base.Items[index]);
            if (iequalityComparer_0.Equals(x, y))
            {
                if (this.dictionary_0 != null)
                {
                    this.dictionary_0[y] = item;
                }
            }
            else
            {
                this.method_0(y, item);
                if (x != null)
                {
                    this.method_7(x);
                }
            }
            base.SetItem(index, item);
        }

        public ICollection<string> ICollection_0
        {
            get
            {
                this.method_4();
                return this.dictionary_0.Keys;
            }
        }

        public ICollection<JToken> ICollection_1
        {
            get
            {
                this.method_4();
                return this.dictionary_0.Values;
            }
        }

        public JToken this[string key]
        {
            get
            {
                if (key == null)
                {
                    throw new ArgumentNullException("key");
                }
                if (this.dictionary_0 == null)
                {
                    throw new KeyNotFoundException();
                }
                return this.dictionary_0[key];
            }
        }
    }
}

