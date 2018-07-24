namespace ns16
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using ns20;
    using System;
    using System.Globalization;

    internal class Class90 : IReferenceResolver
    {
        private int int_0;

        public void AddReference(object context, string reference, object value)
        {
            this.method_0(context).method_0(reference, value);
        }

        public string GetReference(object context, object value)
        {
            string str;
            Class179<string, object> class2 = this.method_0(context);
            if (!class2.method_2(value, out str))
            {
                this.int_0++;
                str = this.int_0.ToString(CultureInfo.InvariantCulture);
                class2.method_0(str, value);
            }
            return str;
        }

        public bool IsReferenced(object context, object value)
        {
            string str;
            return this.method_0(context).method_2(value, out str);
        }

        private Class179<string, object> method_0(object object_0)
        {
            Class135 class2;
            if (object_0 is Class135)
            {
                class2 = (Class135) object_0;
            }
            else
            {
                if (!(object_0 is Class112))
                {
                    throw new JsonException("The DefaultReferenceResolver can only be used internally.");
                }
                class2 = ((Class112) object_0).method_4();
            }
            return class2.Class179_0;
        }

        public object ResolveReference(object context, string reference)
        {
            object obj2;
            this.method_0(context).method_1(reference, out obj2);
            return obj2;
        }
    }
}

