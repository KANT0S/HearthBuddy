namespace ns20
{
    using System;
    using System.Collections.Generic;

    internal class Class165
    {
        private readonly Dictionary<string, Type> dictionary_0 = new Dictionary<string, Type>();

        public Type method_0(Type type_0, Type type_1)
        {
            string key = smethod_0(type_0, type_1);
            if (this.dictionary_0.ContainsKey(key))
            {
                return this.dictionary_0[key];
            }
            return null;
        }

        public void method_1(Type type_0, Type type_1, Type type_2)
        {
            string key = smethod_0(type_0, type_1);
            if (this.dictionary_0.ContainsKey(key))
            {
                this.dictionary_0[key] = type_2;
            }
            else
            {
                this.dictionary_0.Add(key, type_2);
            }
        }

        private static string smethod_0(Type type_0, Type type_1)
        {
            return (type_0.Name + "_" + type_1.Name);
        }
    }
}

