namespace ns21
{
    using Newtonsoft.Json.Schema;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Class121
    {
        private Class122 class122_0 = new Class122();
        private Class123 class123_0;
        private Dictionary<Class123, Class120> dictionary_0 = new Dictionary<Class123, Class120>();

        public Class120 method_0(JsonSchema jsonSchema_0)
        {
            this.class122_0 = new Class122();
            this.class123_0 = this.method_1(null, jsonSchema_0);
            this.dictionary_0 = new Dictionary<Class123, Class120>();
            return this.method_7(this.class123_0);
        }

        public Class123 method_1(Class123 class123_1, JsonSchema jsonSchema_0)
        {
            string str;
            if (class123_1 != null)
            {
                if (class123_1.ReadOnlyCollection_0.Contains(jsonSchema_0))
                {
                    return class123_1;
                }
                str = Class123.smethod_0(class123_1.ReadOnlyCollection_0.Union<JsonSchema>(new JsonSchema[] { jsonSchema_0 }));
            }
            else
            {
                str = Class123.smethod_0(new JsonSchema[] { jsonSchema_0 });
            }
            if (this.class122_0.Contains(str))
            {
                return this.class122_0[str];
            }
            Class123 item = (class123_1 != null) ? class123_1.method_0(jsonSchema_0) : new Class123(jsonSchema_0);
            this.class122_0.Add(item);
            this.method_2(jsonSchema_0.Properties, item.Dictionary_0);
            this.method_2(jsonSchema_0.PatternProperties, item.Dictionary_1);
            if (jsonSchema_0.Items != null)
            {
                for (int i = 0; i < jsonSchema_0.Items.Count; i++)
                {
                    this.method_4(item, i, jsonSchema_0.Items[i]);
                }
            }
            if (jsonSchema_0.AdditionalItems != null)
            {
                this.method_6(item, jsonSchema_0.AdditionalItems);
            }
            if (jsonSchema_0.AdditionalProperties != null)
            {
                this.method_5(item, jsonSchema_0.AdditionalProperties);
            }
            if (jsonSchema_0.Extends != null)
            {
                foreach (JsonSchema schema in jsonSchema_0.Extends)
                {
                    item = this.method_1(item, schema);
                }
            }
            return item;
        }

        public void method_2(IDictionary<string, JsonSchema> idictionary_0, IDictionary<string, Class123> idictionary_1)
        {
            if (idictionary_0 != null)
            {
                foreach (KeyValuePair<string, JsonSchema> pair in idictionary_0)
                {
                    this.method_3(idictionary_1, pair.Key, pair.Value);
                }
            }
        }

        public void method_3(IDictionary<string, Class123> idictionary_0, string string_0, JsonSchema jsonSchema_0)
        {
            Class123 class2;
            idictionary_0.TryGetValue(string_0, out class2);
            idictionary_0[string_0] = this.method_1(class2, jsonSchema_0);
        }

        public void method_4(Class123 class123_1, int int_0, JsonSchema jsonSchema_0)
        {
            Class123 class2 = (class123_1.List_0.Count > int_0) ? class123_1.List_0[int_0] : null;
            Class123 item = this.method_1(class2, jsonSchema_0);
            if (class123_1.List_0.Count <= int_0)
            {
                class123_1.List_0.Add(item);
            }
            else
            {
                class123_1.List_0[int_0] = item;
            }
        }

        public void method_5(Class123 class123_1, JsonSchema jsonSchema_0)
        {
            class123_1.Class123_0 = this.method_1(class123_1.Class123_0, jsonSchema_0);
        }

        public void method_6(Class123 class123_1, JsonSchema jsonSchema_0)
        {
            class123_1.Class123_1 = this.method_1(class123_1.Class123_1, jsonSchema_0);
        }

        private Class120 method_7(Class123 class123_1)
        {
            Class120 class2;
            if (!this.dictionary_0.TryGetValue(class123_1, out class2))
            {
                class2 = Class120.smethod_0(class123_1.ReadOnlyCollection_0);
                this.dictionary_0[class123_1] = class2;
                foreach (KeyValuePair<string, Class123> pair in class123_1.Dictionary_0)
                {
                    if (class2.IDictionary_0 == null)
                    {
                        class2.IDictionary_0 = new Dictionary<string, Class120>();
                    }
                    class2.IDictionary_0[pair.Key] = this.method_7(pair.Value);
                }
                foreach (KeyValuePair<string, Class123> pair2 in class123_1.Dictionary_1)
                {
                    if (class2.IDictionary_1 == null)
                    {
                        class2.IDictionary_1 = new Dictionary<string, Class120>();
                    }
                    class2.IDictionary_1[pair2.Key] = this.method_7(pair2.Value);
                }
                foreach (Class123 class3 in class123_1.List_0)
                {
                    if (class2.IList_1 == null)
                    {
                        class2.IList_1 = new List<Class120>();
                    }
                    class2.IList_1.Add(this.method_7(class3));
                }
                if (class123_1.Class123_0 != null)
                {
                    class2.Class120_0 = this.method_7(class123_1.Class123_0);
                }
                if (class123_1.Class123_1 != null)
                {
                    class2.Class120_1 = this.method_7(class123_1.Class123_1);
                }
            }
            return class2;
        }
    }
}

