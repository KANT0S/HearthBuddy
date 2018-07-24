namespace Newtonsoft.Json.Schema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class JsonSchemaResolver
    {
        [CompilerGenerated]
        private IList<JsonSchema> ilist_0;

        public JsonSchemaResolver()
        {
            this.LoadedSchemas = new List<JsonSchema>();
        }

        public virtual JsonSchema GetSchema(string reference)
        {
            Class124 class2 = new Class124 {
                string_0 = reference
            };
            JsonSchema schema = this.LoadedSchemas.SingleOrDefault<JsonSchema>(new Func<JsonSchema, bool>(class2.method_0));
            if (schema == null)
            {
                schema = this.LoadedSchemas.SingleOrDefault<JsonSchema>(new Func<JsonSchema, bool>(class2.method_1));
            }
            return schema;
        }

        public IList<JsonSchema> LoadedSchemas
        {
            [CompilerGenerated]
            get
            {
                return this.ilist_0;
            }
            [CompilerGenerated]
            protected set
            {
                this.ilist_0 = value;
            }
        }

        [CompilerGenerated]
        private sealed class Class124
        {
            public string string_0;

            public bool method_0(JsonSchema jsonSchema_0)
            {
                return string.Equals(jsonSchema_0.Id, this.string_0, StringComparison.Ordinal);
            }

            public bool method_1(JsonSchema jsonSchema_0)
            {
                return string.Equals(jsonSchema_0.String_0, this.string_0, StringComparison.Ordinal);
            }
        }
    }
}

