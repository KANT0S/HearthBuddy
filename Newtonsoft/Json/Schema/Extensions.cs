namespace Newtonsoft.Json.Schema
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public static class Extensions
    {
        public static bool IsValid(this JToken source, JsonSchema schema)
        {
            Class118 class2 = new Class118 {
                bool_0 = true
            };
            source.Validate(schema, new ValidationEventHandler(class2.method_0));
            return class2.bool_0;
        }

        public static bool IsValid(this JToken source, JsonSchema schema, out IList<string> errorMessages)
        {
            Class119 class2 = new Class119 {
                ilist_0 = new List<string>()
            };
            source.Validate(schema, new ValidationEventHandler(class2.method_0));
            errorMessages = class2.ilist_0;
            return (errorMessages.Count == 0);
        }

        public static void Validate(this JToken source, JsonSchema schema)
        {
            source.Validate(schema, null);
        }

        public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
        {
            Class203.smethod_2(source, "source");
            Class203.smethod_2(schema, "schema");
            using (JsonValidatingReader reader = new JsonValidatingReader(source.CreateReader()))
            {
                reader.Schema = schema;
                if (validationEventHandler != null)
                {
                    reader.ValidationEventHandler += validationEventHandler;
                }
                while (reader.Read())
                {
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class118
        {
            public bool bool_0;

            public void method_0(object sender, ValidationEventArgs e)
            {
                this.bool_0 = false;
            }
        }

        [CompilerGenerated]
        private sealed class Class119
        {
            public IList<string> ilist_0;

            public void method_0(object sender, ValidationEventArgs e)
            {
                this.ilist_0.Add(e.Message);
            }
        }
    }
}

