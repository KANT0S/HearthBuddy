namespace ns21
{
    using Newtonsoft.Json.Schema;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal class Class123
    {
        [CompilerGenerated]
        private Class123 class123_0;
        [CompilerGenerated]
        private Class123 class123_1;
        [CompilerGenerated]
        private Dictionary<string, Class123> dictionary_0;
        [CompilerGenerated]
        private Dictionary<string, Class123> dictionary_1;
        [CompilerGenerated]
        private static Func<JsonSchema, string> func_0;
        [CompilerGenerated]
        private static Func<string, string> func_1;
        [CompilerGenerated]
        private List<Class123> list_0;
        [CompilerGenerated]
        private ReadOnlyCollection<JsonSchema> readOnlyCollection_0;
        [CompilerGenerated]
        private string string_0;

        public Class123(JsonSchema schema)
        {
            this.ReadOnlyCollection_0 = new ReadOnlyCollection<JsonSchema>(new JsonSchema[] { schema });
            this.Dictionary_0 = new Dictionary<string, Class123>();
            this.Dictionary_1 = new Dictionary<string, Class123>();
            this.List_0 = new List<Class123>();
            this.String_0 = smethod_0(this.ReadOnlyCollection_0);
        }

        private Class123(Class123 source, JsonSchema schema)
        {
            this.ReadOnlyCollection_0 = new ReadOnlyCollection<JsonSchema>(source.ReadOnlyCollection_0.Union<JsonSchema>(new JsonSchema[] { schema }).ToList<JsonSchema>());
            this.Dictionary_0 = new Dictionary<string, Class123>(source.Dictionary_0);
            this.Dictionary_1 = new Dictionary<string, Class123>(source.Dictionary_1);
            this.List_0 = new List<Class123>(source.List_0);
            this.Class123_0 = source.Class123_0;
            this.Class123_1 = source.Class123_1;
            this.String_0 = smethod_0(this.ReadOnlyCollection_0);
        }

        public Class123 method_0(JsonSchema jsonSchema_0)
        {
            return new Class123(this, jsonSchema_0);
        }

        public static string smethod_0(IEnumerable<JsonSchema> ienumerable_0)
        {
            if (func_0 == null)
            {
                func_0 = new Func<JsonSchema, string>(Class123.smethod_1);
            }
            if (func_1 == null)
            {
                func_1 = new Func<string, string>(Class123.smethod_2);
            }
            return string.Join("-", ienumerable_0.Select<JsonSchema, string>(func_0).OrderBy<string, string>(func_1, StringComparer.Ordinal).ToArray<string>());
        }

        [CompilerGenerated]
        private static string smethod_1(JsonSchema jsonSchema_0)
        {
            return jsonSchema_0.String_1;
        }

        [CompilerGenerated]
        private static string smethod_2(string string_1)
        {
            return string_1;
        }

        public Class123 Class123_0
        {
            [CompilerGenerated]
            get
            {
                return this.class123_0;
            }
            [CompilerGenerated]
            set
            {
                this.class123_0 = value;
            }
        }

        public Class123 Class123_1
        {
            [CompilerGenerated]
            get
            {
                return this.class123_1;
            }
            [CompilerGenerated]
            set
            {
                this.class123_1 = value;
            }
        }

        public Dictionary<string, Class123> Dictionary_0
        {
            [CompilerGenerated]
            get
            {
                return this.dictionary_0;
            }
            [CompilerGenerated]
            private set
            {
                this.dictionary_0 = value;
            }
        }

        public Dictionary<string, Class123> Dictionary_1
        {
            [CompilerGenerated]
            get
            {
                return this.dictionary_1;
            }
            [CompilerGenerated]
            private set
            {
                this.dictionary_1 = value;
            }
        }

        public List<Class123> List_0
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }

        public ReadOnlyCollection<JsonSchema> ReadOnlyCollection_0
        {
            [CompilerGenerated]
            get
            {
                return this.readOnlyCollection_0;
            }
            [CompilerGenerated]
            private set
            {
                this.readOnlyCollection_0 = value;
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
            private set
            {
                this.string_0 = value;
            }
        }
    }
}

