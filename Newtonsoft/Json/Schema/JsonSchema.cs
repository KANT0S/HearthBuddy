namespace Newtonsoft.Json.Schema
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ns20;
    using ns21;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Runtime.CompilerServices;

    public class JsonSchema
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private bool bool_2;
        [CompilerGenerated]
        private bool bool_3;
        [CompilerGenerated]
        private bool bool_4;
        [CompilerGenerated]
        private IDictionary<string, JsonSchema> idictionary_0;
        [CompilerGenerated]
        private IDictionary<string, JsonSchema> idictionary_1;
        [CompilerGenerated]
        private IList<JsonSchema> ilist_0;
        [CompilerGenerated]
        private IList<JToken> ilist_1;
        [CompilerGenerated]
        private IList<JsonSchema> ilist_2;
        [CompilerGenerated]
        private JsonSchema jsonSchema_0;
        [CompilerGenerated]
        private JsonSchema jsonSchema_1;
        [CompilerGenerated]
        private JToken jtoken_0;
        [CompilerGenerated]
        private bool? nullable_0;
        [CompilerGenerated]
        private bool? nullable_1;
        [CompilerGenerated]
        private bool? nullable_10;
        [CompilerGenerated]
        private bool? nullable_11;
        [CompilerGenerated]
        private int? nullable_12;
        [CompilerGenerated]
        private int? nullable_13;
        [CompilerGenerated]
        private JsonSchemaType? nullable_14;
        [CompilerGenerated]
        private bool? nullable_2;
        [CompilerGenerated]
        private bool? nullable_3;
        [CompilerGenerated]
        private JsonSchemaType? nullable_4;
        [CompilerGenerated]
        private int? nullable_5;
        [CompilerGenerated]
        private int? nullable_6;
        [CompilerGenerated]
        private double? nullable_7;
        [CompilerGenerated]
        private double? nullable_8;
        [CompilerGenerated]
        private double? nullable_9;
        private readonly string string_0 = Guid.NewGuid().ToString("N");
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private string string_2;
        [CompilerGenerated]
        private string string_3;
        [CompilerGenerated]
        private string string_4;
        [CompilerGenerated]
        private string string_5;
        [CompilerGenerated]
        private string string_6;
        [CompilerGenerated]
        private string string_7;
        [CompilerGenerated]
        private string string_8;

        public JsonSchema()
        {
            this.AllowAdditionalProperties = true;
            this.AllowAdditionalItems = true;
        }

        public static JsonSchema Parse(string json)
        {
            return Parse(json, new JsonSchemaResolver());
        }

        public static JsonSchema Parse(string json, JsonSchemaResolver resolver)
        {
            Class203.smethod_2(json, "json");
            JsonReader reader = new JsonTextReader(new StringReader(json));
            return Read(reader, resolver);
        }

        public static JsonSchema Read(JsonReader reader)
        {
            return Read(reader, new JsonSchemaResolver());
        }

        public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
        {
            Class203.smethod_2(reader, "reader");
            Class203.smethod_2(resolver, "resolver");
            Class130 class2 = new Class130(resolver);
            return class2.method_2(reader);
        }

        public override string ToString()
        {
            StringWriter textWriter = new StringWriter(CultureInfo.InvariantCulture);
            JsonTextWriter writer = new JsonTextWriter(textWriter) {
                Formatting = Formatting.Indented
            };
            this.WriteTo(writer);
            return textWriter.ToString();
        }

        public void WriteTo(JsonWriter writer)
        {
            this.WriteTo(writer, new JsonSchemaResolver());
        }

        public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
        {
            Class203.smethod_2(writer, "writer");
            Class203.smethod_2(resolver, "resolver");
            new Class125(writer, resolver).method_1(this);
        }

        public JsonSchema AdditionalItems
        {
            [CompilerGenerated]
            get
            {
                return this.jsonSchema_0;
            }
            [CompilerGenerated]
            set
            {
                this.jsonSchema_0 = value;
            }
        }

        public JsonSchema AdditionalProperties
        {
            [CompilerGenerated]
            get
            {
                return this.jsonSchema_1;
            }
            [CompilerGenerated]
            set
            {
                this.jsonSchema_1 = value;
            }
        }

        public bool AllowAdditionalItems
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            set
            {
                this.bool_1 = value;
            }
        }

        public bool AllowAdditionalProperties
        {
            [CompilerGenerated]
            get
            {
                return this.bool_3;
            }
            [CompilerGenerated]
            set
            {
                this.bool_3 = value;
            }
        }

        internal bool Boolean_0
        {
            [CompilerGenerated]
            get
            {
                return this.bool_4;
            }
            [CompilerGenerated]
            set
            {
                this.bool_4 = value;
            }
        }

        public JToken Default
        {
            [CompilerGenerated]
            get
            {
                return this.jtoken_0;
            }
            [CompilerGenerated]
            set
            {
                this.jtoken_0 = value;
            }
        }

        public string Description
        {
            [CompilerGenerated]
            get
            {
                return this.string_3;
            }
            [CompilerGenerated]
            set
            {
                this.string_3 = value;
            }
        }

        public JsonSchemaType? Disallow
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_14;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_14 = value;
            }
        }

        public double? DivisibleBy
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_7;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_7 = value;
            }
        }

        public IList<JToken> Enum
        {
            [CompilerGenerated]
            get
            {
                return this.ilist_1;
            }
            [CompilerGenerated]
            set
            {
                this.ilist_1 = value;
            }
        }

        public bool? ExclusiveMaximum
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_11;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_11 = value;
            }
        }

        public bool? ExclusiveMinimum
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_10;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_10 = value;
            }
        }

        public IList<JsonSchema> Extends
        {
            [CompilerGenerated]
            get
            {
                return this.ilist_2;
            }
            [CompilerGenerated]
            set
            {
                this.ilist_2 = value;
            }
        }

        public string Format
        {
            [CompilerGenerated]
            get
            {
                return this.string_6;
            }
            [CompilerGenerated]
            set
            {
                this.string_6 = value;
            }
        }

        public bool? Hidden
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_2;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_2 = value;
            }
        }

        public string Id
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            set
            {
                this.string_1 = value;
            }
        }

        public IList<JsonSchema> Items
        {
            [CompilerGenerated]
            get
            {
                return this.ilist_0;
            }
            [CompilerGenerated]
            set
            {
                this.ilist_0 = value;
            }
        }

        public double? Maximum
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_9;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_9 = value;
            }
        }

        public int? MaximumItems
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_13;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_13 = value;
            }
        }

        public int? MaximumLength
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_6;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_6 = value;
            }
        }

        public double? Minimum
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_8;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_8 = value;
            }
        }

        public int? MinimumItems
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_12;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_12 = value;
            }
        }

        public int? MinimumLength
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_5;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_5 = value;
            }
        }

        public string Pattern
        {
            [CompilerGenerated]
            get
            {
                return this.string_4;
            }
            [CompilerGenerated]
            set
            {
                this.string_4 = value;
            }
        }

        public IDictionary<string, JsonSchema> PatternProperties
        {
            [CompilerGenerated]
            get
            {
                return this.idictionary_1;
            }
            [CompilerGenerated]
            set
            {
                this.idictionary_1 = value;
            }
        }

        public bool PositionalItemsValidation
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
            }
        }

        public IDictionary<string, JsonSchema> Properties
        {
            [CompilerGenerated]
            get
            {
                return this.idictionary_0;
            }
            [CompilerGenerated]
            set
            {
                this.idictionary_0 = value;
            }
        }

        public bool? ReadOnly
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_1;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_1 = value;
            }
        }

        public bool? Required
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_0;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_0 = value;
            }
        }

        public string Requires
        {
            [CompilerGenerated]
            get
            {
                return this.string_5;
            }
            [CompilerGenerated]
            set
            {
                this.string_5 = value;
            }
        }

        internal string String_0
        {
            [CompilerGenerated]
            get
            {
                return this.string_7;
            }
            [CompilerGenerated]
            set
            {
                this.string_7 = value;
            }
        }

        internal string String_1
        {
            get
            {
                return this.string_0;
            }
        }

        internal string String_2
        {
            [CompilerGenerated]
            get
            {
                return this.string_8;
            }
            [CompilerGenerated]
            set
            {
                this.string_8 = value;
            }
        }

        public string Title
        {
            [CompilerGenerated]
            get
            {
                return this.string_2;
            }
            [CompilerGenerated]
            set
            {
                this.string_2 = value;
            }
        }

        public bool? Transient
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_3;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_3 = value;
            }
        }

        public JsonSchemaType? Type
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_4;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_4 = value;
            }
        }

        public bool UniqueItems
        {
            [CompilerGenerated]
            get
            {
                return this.bool_2;
            }
            [CompilerGenerated]
            set
            {
                this.bool_2 = value;
            }
        }
    }
}

