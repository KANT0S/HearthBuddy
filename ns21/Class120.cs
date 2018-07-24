namespace ns21
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    internal class Class120
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
        private bool bool_5;
        [CompilerGenerated]
        private bool bool_6;
        [CompilerGenerated]
        private Class120 class120_0;
        [CompilerGenerated]
        private Class120 class120_1;
        [CompilerGenerated]
        private IDictionary<string, Class120> idictionary_0;
        [CompilerGenerated]
        private IDictionary<string, Class120> idictionary_1;
        [CompilerGenerated]
        private IList<string> ilist_0;
        [CompilerGenerated]
        private IList<Class120> ilist_1;
        [CompilerGenerated]
        private IList<JToken> ilist_2;
        [CompilerGenerated]
        private JsonSchemaType jsonSchemaType_0;
        [CompilerGenerated]
        private JsonSchemaType jsonSchemaType_1;
        [CompilerGenerated]
        private int? nullable_0;
        [CompilerGenerated]
        private int? nullable_1;
        [CompilerGenerated]
        private double? nullable_2;
        [CompilerGenerated]
        private double? nullable_3;
        [CompilerGenerated]
        private double? nullable_4;
        [CompilerGenerated]
        private int? nullable_5;
        [CompilerGenerated]
        private int? nullable_6;

        public Class120()
        {
            this.JsonSchemaType_0 = JsonSchemaType.Any;
            this.Boolean_4 = true;
            this.Boolean_5 = true;
            this.Boolean_0 = false;
        }

        public static Class120 smethod_0(IList<JsonSchema> ilist_3)
        {
            Class120 class2 = new Class120();
            foreach (JsonSchema schema in ilist_3)
            {
                smethod_1(class2, schema);
            }
            return class2;
        }

        private static void smethod_1(Class120 class120_2, JsonSchema jsonSchema_0)
        {
            bool? required;
            bool? exclusiveMinimum;
            bool? exclusiveMaximum;
            if (!class120_2.Boolean_0)
            {
                required = jsonSchema_0.Required;
            }
            class120_2.Boolean_0 = required.HasValue;
            JsonSchemaType? type = jsonSchema_0.Type;
            class120_2.JsonSchemaType_0 &= (JsonSchemaType) (type.HasValue ? type.GetValueOrDefault() : JsonSchemaType.Any);
            class120_2.Nullable_0 = Class192.smethod_3(class120_2.Nullable_0, jsonSchema_0.MinimumLength);
            class120_2.Nullable_1 = Class192.smethod_2(class120_2.Nullable_1, jsonSchema_0.MaximumLength);
            class120_2.Nullable_2 = Class192.smethod_4(class120_2.Nullable_2, jsonSchema_0.DivisibleBy);
            class120_2.Nullable_3 = Class192.smethod_4(class120_2.Nullable_3, jsonSchema_0.Minimum);
            class120_2.Nullable_4 = Class192.smethod_4(class120_2.Nullable_4, jsonSchema_0.Maximum);
            if (!class120_2.Boolean_1)
            {
                exclusiveMinimum = jsonSchema_0.ExclusiveMinimum;
            }
            class120_2.Boolean_1 = exclusiveMinimum.HasValue;
            if (!class120_2.Boolean_2)
            {
                exclusiveMaximum = jsonSchema_0.ExclusiveMaximum;
            }
            class120_2.Boolean_2 = exclusiveMaximum.HasValue;
            class120_2.Nullable_5 = Class192.smethod_3(class120_2.Nullable_5, jsonSchema_0.MinimumItems);
            class120_2.Nullable_6 = Class192.smethod_2(class120_2.Nullable_6, jsonSchema_0.MaximumItems);
            class120_2.Boolean_3 = class120_2.Boolean_3 || jsonSchema_0.PositionalItemsValidation;
            class120_2.Boolean_4 = class120_2.Boolean_4 && jsonSchema_0.AllowAdditionalProperties;
            class120_2.Boolean_5 = class120_2.Boolean_5 && jsonSchema_0.AllowAdditionalItems;
            class120_2.Boolean_6 = class120_2.Boolean_6 || jsonSchema_0.UniqueItems;
            if (jsonSchema_0.Enum != null)
            {
                if (class120_2.IList_2 == null)
                {
                    class120_2.IList_2 = new List<JToken>();
                }
                class120_2.IList_2.smethod_7<JToken>(jsonSchema_0.Enum, JToken.EqualityComparer);
            }
            JsonSchemaType? disallow = jsonSchema_0.Disallow;
            class120_2.JsonSchemaType_1 |= (JsonSchemaType) (disallow.HasValue ? disallow.GetValueOrDefault() : JsonSchemaType.None);
            if (jsonSchema_0.Pattern != null)
            {
                if (class120_2.IList_0 == null)
                {
                    class120_2.IList_0 = new List<string>();
                }
                class120_2.IList_0.smethod_4<string>(jsonSchema_0.Pattern);
            }
        }

        public bool Boolean_0
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

        public bool Boolean_1
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

        public bool Boolean_2
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

        public bool Boolean_3
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

        public bool Boolean_4
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

        public bool Boolean_5
        {
            [CompilerGenerated]
            get
            {
                return this.bool_5;
            }
            [CompilerGenerated]
            set
            {
                this.bool_5 = value;
            }
        }

        public bool Boolean_6
        {
            [CompilerGenerated]
            get
            {
                return this.bool_6;
            }
            [CompilerGenerated]
            set
            {
                this.bool_6 = value;
            }
        }

        public Class120 Class120_0
        {
            [CompilerGenerated]
            get
            {
                return this.class120_0;
            }
            [CompilerGenerated]
            set
            {
                this.class120_0 = value;
            }
        }

        public Class120 Class120_1
        {
            [CompilerGenerated]
            get
            {
                return this.class120_1;
            }
            [CompilerGenerated]
            set
            {
                this.class120_1 = value;
            }
        }

        public IDictionary<string, Class120> IDictionary_0
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

        public IDictionary<string, Class120> IDictionary_1
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

        public IList<string> IList_0
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

        public IList<Class120> IList_1
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

        public IList<JToken> IList_2
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

        public JsonSchemaType JsonSchemaType_0
        {
            [CompilerGenerated]
            get
            {
                return this.jsonSchemaType_0;
            }
            [CompilerGenerated]
            set
            {
                this.jsonSchemaType_0 = value;
            }
        }

        public JsonSchemaType JsonSchemaType_1
        {
            [CompilerGenerated]
            get
            {
                return this.jsonSchemaType_1;
            }
            [CompilerGenerated]
            set
            {
                this.jsonSchemaType_1 = value;
            }
        }

        public int? Nullable_0
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

        public int? Nullable_1
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

        public double? Nullable_2
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

        public double? Nullable_3
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

        public double? Nullable_4
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

        public int? Nullable_5
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

        public int? Nullable_6
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
    }
}

