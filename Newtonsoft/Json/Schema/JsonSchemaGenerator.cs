namespace Newtonsoft.Json.Schema
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;
    using ns16;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class JsonSchemaGenerator
    {
        private IContractResolver icontractResolver_0;
        private readonly IList<Class133> ilist_0 = new List<Class133>();
        private JsonSchema jsonSchema_0;
        private JsonSchemaResolver jsonSchemaResolver_0;
        [CompilerGenerated]
        private Newtonsoft.Json.Schema.UndefinedSchemaIdHandling undefinedSchemaIdHandling_0;

        public JsonSchema Generate(Type type)
        {
            return this.Generate(type, new JsonSchemaResolver(), false);
        }

        public JsonSchema Generate(Type type, JsonSchemaResolver resolver)
        {
            return this.Generate(type, resolver, false);
        }

        public JsonSchema Generate(Type type, bool rootSchemaNullable)
        {
            return this.Generate(type, new JsonSchemaResolver(), rootSchemaNullable);
        }

        public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
        {
            Class203.smethod_2(type, "type");
            Class203.smethod_2(resolver, "resolver");
            this.jsonSchemaResolver_0 = resolver;
            return this.method_5(type, !rootSchemaNullable ? Required.Always : Required.Default, false);
        }

        private void method_0(Class133 class133_0)
        {
            this.jsonSchema_0 = class133_0.JsonSchema_0;
            this.ilist_0.Add(class133_0);
            this.jsonSchemaResolver_0.LoadedSchemas.Add(class133_0.JsonSchema_0);
        }

        private Class133 method_1()
        {
            Class133 class2 = this.ilist_0[this.ilist_0.Count - 1];
            this.ilist_0.RemoveAt(this.ilist_0.Count - 1);
            Class133 class3 = this.ilist_0.LastOrDefault<Class133>();
            if (class3 != null)
            {
                this.jsonSchema_0 = class3.JsonSchema_0;
                return class2;
            }
            this.jsonSchema_0 = null;
            return class2;
        }

        private JsonSchemaType method_10(Type type_0, Required required_0)
        {
            JsonSchemaType none = JsonSchemaType.None;
            if ((required_0 != Required.Always) && Class194.smethod_9(type_0))
            {
                none = JsonSchemaType.Null;
                if (Class194.smethod_10(type_0))
                {
                    type_0 = Nullable.GetUnderlyingType(type_0);
                }
            }
            Enum17 enum2 = Class181.smethod_0(type_0);
            switch (enum2)
            {
                case Enum17.Empty:
                case Enum17.Object:
                    return (none | JsonSchemaType.String);

                case Enum17.Char:
                    return (none | JsonSchemaType.String);

                case Enum17.Boolean:
                    return (none | JsonSchemaType.Boolean);

                case Enum17.SByte:
                case Enum17.Int16:
                case Enum17.UInt16:
                case Enum17.Int32:
                case Enum17.Byte:
                case Enum17.UInt32:
                case Enum17.Int64:
                case Enum17.UInt64:
                case Enum17.BigInteger:
                    return (none | JsonSchemaType.Integer);

                case Enum17.Single:
                case Enum17.Double:
                case Enum17.Decimal:
                    return (none | JsonSchemaType.Float);

                case Enum17.DateTime:
                case Enum17.DateTimeOffset:
                    return (none | JsonSchemaType.String);

                case Enum17.Guid:
                case Enum17.TimeSpan:
                case Enum17.Uri:
                case Enum17.String:
                case Enum17.Bytes:
                    return (none | JsonSchemaType.String);

                case Enum17.DBNull:
                    return (none | JsonSchemaType.Null);
            }
            throw new JsonException("Unexpected type code '{0}' for type '{1}'.".smethod_1(CultureInfo.InvariantCulture, enum2, type_0));
        }

        private string method_2(Type type_0)
        {
            JsonContainerAttribute attribute = Class139.smethod_0(type_0);
            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Title))
            {
                return attribute.Title;
            }
            return null;
        }

        private string method_3(Type type_0)
        {
            JsonContainerAttribute attribute = Class139.smethod_0(type_0);
            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Description))
            {
                return attribute.Description;
            }
            DescriptionAttribute attribute2 = Class194.smethod_29<DescriptionAttribute>(type_0);
            if (attribute2 != null)
            {
                return attribute2.Description;
            }
            return null;
        }

        private string method_4(Type type_0, bool bool_0)
        {
            JsonContainerAttribute attribute = Class139.smethod_0(type_0);
            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Id))
            {
                return attribute.Id;
            }
            if (!bool_0)
            {
                switch (this.UndefinedSchemaIdHandling)
                {
                    case Newtonsoft.Json.Schema.UndefinedSchemaIdHandling.UseTypeName:
                        return type_0.FullName;

                    case Newtonsoft.Json.Schema.UndefinedSchemaIdHandling.UseAssemblyQualifiedName:
                        return type_0.AssemblyQualifiedName;
                }
            }
            return null;
        }

        private JsonSchema method_5(Type type_0, Required required_0, bool bool_0)
        {
            JsonConverter converter;
            Class134 class4 = new Class134 {
                type_0 = type_0
            };
            Class203.smethod_2(class4.type_0, "type");
            string str = this.method_4(class4.type_0, false);
            string str2 = this.method_4(class4.type_0, true);
            if (!string.IsNullOrEmpty(str))
            {
                JsonSchema schema = this.jsonSchemaResolver_0.GetSchema(str);
                if (schema != null)
                {
                    if ((required_0 != Required.Always) && !smethod_0(schema.Type, JsonSchemaType.Null))
                    {
                        schema.Type = ((JsonSchemaType) schema.Type) | JsonSchemaType.Null;
                    }
                    if (bool_0 && (schema.Required != true))
                    {
                        schema.Required = true;
                    }
                    return schema;
                }
            }
            if (this.ilist_0.Any<Class133>(new Func<Class133, bool>(class4.method_0)))
            {
                throw new JsonException("Unresolved circular reference for type '{0}'. Explicitly define an Id for the type using a JsonObject/JsonArray attribute or automatically generate a type Id using the UndefinedSchemaIdHandling property.".smethod_0(CultureInfo.InvariantCulture, class4.type_0));
            }
            JsonContract contract = this.ContractResolver.ResolveContract(class4.type_0);
            if (((converter = contract.Converter) != null) || ((converter = contract.JsonConverter_0) != null))
            {
                JsonSchema schema2 = converter.GetSchema();
                if (schema2 != null)
                {
                    return schema2;
                }
            }
            this.method_0(new Class133(class4.type_0, new JsonSchema()));
            if (str2 != null)
            {
                this.JsonSchema_0.Id = str2;
            }
            if (bool_0)
            {
                this.JsonSchema_0.Required = true;
            }
            this.JsonSchema_0.Title = this.method_2(class4.type_0);
            this.JsonSchema_0.Description = this.method_3(class4.type_0);
            if (converter != null)
            {
                this.JsonSchema_0.Type = 0x7f;
            }
            else
            {
                switch (contract.enum15_0)
                {
                    case Enum15.Object:
                        this.JsonSchema_0.Type = new JsonSchemaType?(this.method_6(JsonSchemaType.Object, required_0));
                        this.JsonSchema_0.Id = this.method_4(class4.type_0, false);
                        this.method_8(class4.type_0, (JsonObjectContract) contract);
                        goto Label_04CD;

                    case Enum15.Array:
                    {
                        this.JsonSchema_0.Type = new JsonSchemaType?(this.method_6(JsonSchemaType.Array, required_0));
                        this.JsonSchema_0.Id = this.method_4(class4.type_0, false);
                        JsonArrayAttribute attribute = Class139.smethod_0(class4.type_0) as JsonArrayAttribute;
                        bool flag = (attribute == null) || attribute.AllowNullItems;
                        Type type = Class194.smethod_18(class4.type_0);
                        if (type != null)
                        {
                            this.JsonSchema_0.Items = new List<JsonSchema>();
                            this.JsonSchema_0.Items.Add(this.method_5(type, !flag ? Required.Always : Required.Default, false));
                        }
                        goto Label_04CD;
                    }
                    case Enum15.Primitive:
                        this.JsonSchema_0.Type = new JsonSchemaType?(this.method_10(class4.type_0, required_0));
                        if (((((JsonSchemaType) this.JsonSchema_0.Type) == JsonSchemaType.Integer) && class4.type_0.smethod_7()) && !class4.type_0.IsDefined(typeof(FlagsAttribute), true))
                        {
                            this.JsonSchema_0.Enum = new List<JToken>();
                            foreach (Class187<long> class3 in Class186.smethod_2<long>(class4.type_0))
                            {
                                JToken item = JToken.FromObject(class3.Prop_0);
                                this.JsonSchema_0.Enum.Add(item);
                            }
                        }
                        goto Label_04CD;

                    case Enum15.String:
                    {
                        JsonSchemaType type2 = !Class194.smethod_9(contract.UnderlyingType) ? JsonSchemaType.String : this.method_6(JsonSchemaType.String, required_0);
                        this.JsonSchema_0.Type = new JsonSchemaType?(type2);
                        goto Label_04CD;
                    }
                    case Enum15.Dictionary:
                        Type type3;
                        Type type4;
                        this.JsonSchema_0.Type = new JsonSchemaType?(this.method_6(JsonSchemaType.Object, required_0));
                        Class194.smethod_19(class4.type_0, out type3, out type4);
                        if ((type3 != null) && (this.ContractResolver.ResolveContract(type3).enum15_0 == Enum15.Primitive))
                        {
                            this.JsonSchema_0.AdditionalProperties = this.method_5(type4, Required.Default, false);
                        }
                        goto Label_04CD;

                    case Enum15.Dynamic:
                    case Enum15.Linq:
                        this.JsonSchema_0.Type = 0x7f;
                        goto Label_04CD;

                    case Enum15.Serializable:
                        this.JsonSchema_0.Type = new JsonSchemaType?(this.method_6(JsonSchemaType.Object, required_0));
                        this.JsonSchema_0.Id = this.method_4(class4.type_0, false);
                        this.method_9(class4.type_0, (JsonISerializableContract) contract);
                        goto Label_04CD;
                }
                throw new JsonException("Unexpected contract type: {0}".smethod_0(CultureInfo.InvariantCulture, contract));
            }
        Label_04CD:
            return this.method_1().JsonSchema_0;
        }

        private JsonSchemaType method_6(JsonSchemaType jsonSchemaType_0, Required required_0)
        {
            if (required_0 != Required.Always)
            {
                return (jsonSchemaType_0 | JsonSchemaType.Null);
            }
            return jsonSchemaType_0;
        }

        private bool method_7(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
        {
            return ((defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1);
        }

        private void method_8(Type type_0, JsonObjectContract jsonObjectContract_0)
        {
            this.JsonSchema_0.Properties = new Dictionary<string, JsonSchema>();
            foreach (JsonProperty property in jsonObjectContract_0.Properties)
            {
                if (!property.Ignored)
                {
                    bool flag = (((((NullValueHandling) property.NullValueHandling) == NullValueHandling.Ignore) || this.method_7(property.DefaultValueHandling.GetValueOrDefault(), DefaultValueHandling.Ignore)) || (property.ShouldSerialize != null)) || (property.GetIsSpecified != null);
                    JsonSchema schema = this.method_5(property.PropertyType, property.Required, !flag);
                    if (property.DefaultValue != null)
                    {
                        schema.Default = JToken.FromObject(property.DefaultValue);
                    }
                    this.JsonSchema_0.Properties.Add(property.PropertyName, schema);
                }
            }
            if (type_0.smethod_9())
            {
                this.JsonSchema_0.AllowAdditionalProperties = false;
            }
        }

        private void method_9(Type type_0, JsonISerializableContract jsonISerializableContract_0)
        {
            this.JsonSchema_0.AllowAdditionalProperties = true;
        }

        internal static bool smethod_0(JsonSchemaType? nullable_0, JsonSchemaType jsonSchemaType_0)
        {
            if (!nullable_0.HasValue)
            {
                return true;
            }
            JsonSchemaType? nullable = nullable_0;
            JsonSchemaType type = jsonSchemaType_0;
            JsonSchemaType? nullable3 = nullable.HasValue ? new JsonSchemaType?(((JsonSchemaType) nullable.GetValueOrDefault()) & type) : null;
            JsonSchemaType type2 = jsonSchemaType_0;
            return (((((JsonSchemaType) nullable3.GetValueOrDefault()) == type2) && nullable3.HasValue) || ((((JsonSchemaType) nullable_0) == JsonSchemaType.Float) && (jsonSchemaType_0 == JsonSchemaType.Integer)));
        }

        public IContractResolver ContractResolver
        {
            get
            {
                if (this.icontractResolver_0 == null)
                {
                    return DefaultContractResolver.IContractResolver_0;
                }
                return this.icontractResolver_0;
            }
            set
            {
                this.icontractResolver_0 = value;
            }
        }

        private JsonSchema JsonSchema_0
        {
            get
            {
                return this.jsonSchema_0;
            }
        }

        public Newtonsoft.Json.Schema.UndefinedSchemaIdHandling UndefinedSchemaIdHandling
        {
            [CompilerGenerated]
            get
            {
                return this.undefinedSchemaIdHandling_0;
            }
            [CompilerGenerated]
            set
            {
                this.undefinedSchemaIdHandling_0 = value;
            }
        }

        private class Class133
        {
            [CompilerGenerated]
            private JsonSchema jsonSchema_0;
            [CompilerGenerated]
            private Type type_0;

            public Class133(Type type, JsonSchema schema)
            {
                Class203.smethod_2(type, "type");
                Class203.smethod_2(schema, "schema");
                this.Type_0 = type;
                this.JsonSchema_0 = schema;
            }

            public JsonSchema JsonSchema_0
            {
                [CompilerGenerated]
                get
                {
                    return this.jsonSchema_0;
                }
                [CompilerGenerated]
                private set
                {
                    this.jsonSchema_0 = value;
                }
            }

            public Type Type_0
            {
                [CompilerGenerated]
                get
                {
                    return this.type_0;
                }
                [CompilerGenerated]
                private set
                {
                    this.type_0 = value;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class134
        {
            public Type type_0;

            public bool method_0(JsonSchemaGenerator.Class133 class133_0)
            {
                return (class133_0.Type_0 == this.type_0);
            }
        }
    }
}

