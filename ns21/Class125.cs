namespace ns21
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal class Class125
    {
        [CompilerGenerated]
        private static Func<JsonSchemaType, bool> func_0;
        private readonly JsonSchemaResolver jsonSchemaResolver_0;
        private readonly JsonWriter jsonWriter_0;

        public Class125(JsonWriter writer, JsonSchemaResolver resolver)
        {
            Class203.smethod_2(writer, "writer");
            this.jsonWriter_0 = writer;
            this.jsonSchemaResolver_0 = resolver;
        }

        private void method_0(JsonSchema jsonSchema_0)
        {
            if ((jsonSchema_0.Id != null) && (this.jsonSchemaResolver_0.GetSchema(jsonSchema_0.Id) != null))
            {
                this.jsonWriter_0.WriteStartObject();
                this.jsonWriter_0.WritePropertyName("$ref");
                this.jsonWriter_0.WriteValue(jsonSchema_0.Id);
                this.jsonWriter_0.WriteEndObject();
            }
            else
            {
                this.method_1(jsonSchema_0);
            }
        }

        public void method_1(JsonSchema jsonSchema_0)
        {
            Class203.smethod_2(jsonSchema_0, "schema");
            if (!this.jsonSchemaResolver_0.LoadedSchemas.Contains(jsonSchema_0))
            {
                this.jsonSchemaResolver_0.LoadedSchemas.Add(jsonSchema_0);
            }
            this.jsonWriter_0.WriteStartObject();
            this.method_5(this.jsonWriter_0, "id", jsonSchema_0.Id);
            this.method_5(this.jsonWriter_0, "title", jsonSchema_0.Title);
            this.method_5(this.jsonWriter_0, "description", jsonSchema_0.Description);
            this.method_5(this.jsonWriter_0, "required", jsonSchema_0.Required);
            this.method_5(this.jsonWriter_0, "readonly", jsonSchema_0.ReadOnly);
            this.method_5(this.jsonWriter_0, "hidden", jsonSchema_0.Hidden);
            this.method_5(this.jsonWriter_0, "transient", jsonSchema_0.Transient);
            if (jsonSchema_0.Type.HasValue)
            {
                this.method_4("type", this.jsonWriter_0, jsonSchema_0.Type.Value);
            }
            if (!jsonSchema_0.AllowAdditionalProperties)
            {
                this.jsonWriter_0.WritePropertyName("additionalProperties");
                this.jsonWriter_0.WriteValue(jsonSchema_0.AllowAdditionalProperties);
            }
            else if (jsonSchema_0.AdditionalProperties != null)
            {
                this.jsonWriter_0.WritePropertyName("additionalProperties");
                this.method_0(jsonSchema_0.AdditionalProperties);
            }
            if (!jsonSchema_0.AllowAdditionalItems)
            {
                this.jsonWriter_0.WritePropertyName("additionalItems");
                this.jsonWriter_0.WriteValue(jsonSchema_0.AllowAdditionalItems);
            }
            else if (jsonSchema_0.AdditionalItems != null)
            {
                this.jsonWriter_0.WritePropertyName("additionalItems");
                this.method_0(jsonSchema_0.AdditionalItems);
            }
            this.method_2(this.jsonWriter_0, "properties", jsonSchema_0.Properties);
            this.method_2(this.jsonWriter_0, "patternProperties", jsonSchema_0.PatternProperties);
            this.method_3(jsonSchema_0);
            this.method_5(this.jsonWriter_0, "minimum", jsonSchema_0.Minimum);
            this.method_5(this.jsonWriter_0, "maximum", jsonSchema_0.Maximum);
            this.method_5(this.jsonWriter_0, "exclusiveMinimum", jsonSchema_0.ExclusiveMinimum);
            this.method_5(this.jsonWriter_0, "exclusiveMaximum", jsonSchema_0.ExclusiveMaximum);
            this.method_5(this.jsonWriter_0, "minLength", jsonSchema_0.MinimumLength);
            this.method_5(this.jsonWriter_0, "maxLength", jsonSchema_0.MaximumLength);
            this.method_5(this.jsonWriter_0, "minItems", jsonSchema_0.MinimumItems);
            this.method_5(this.jsonWriter_0, "maxItems", jsonSchema_0.MaximumItems);
            this.method_5(this.jsonWriter_0, "divisibleBy", jsonSchema_0.DivisibleBy);
            this.method_5(this.jsonWriter_0, "format", jsonSchema_0.Format);
            this.method_5(this.jsonWriter_0, "pattern", jsonSchema_0.Pattern);
            if (jsonSchema_0.Enum != null)
            {
                this.jsonWriter_0.WritePropertyName("enum");
                this.jsonWriter_0.WriteStartArray();
                foreach (JToken token in jsonSchema_0.Enum)
                {
                    token.WriteTo(this.jsonWriter_0, new JsonConverter[0]);
                }
                this.jsonWriter_0.WriteEndArray();
            }
            if (jsonSchema_0.Default != null)
            {
                this.jsonWriter_0.WritePropertyName("default");
                jsonSchema_0.Default.WriteTo(this.jsonWriter_0, new JsonConverter[0]);
            }
            if (jsonSchema_0.Disallow.HasValue)
            {
                this.method_4("disallow", this.jsonWriter_0, jsonSchema_0.Disallow.Value);
            }
            if ((jsonSchema_0.Extends != null) && (jsonSchema_0.Extends.Count > 0))
            {
                this.jsonWriter_0.WritePropertyName("extends");
                if (jsonSchema_0.Extends.Count == 1)
                {
                    this.method_0(jsonSchema_0.Extends[0]);
                }
                else
                {
                    this.jsonWriter_0.WriteStartArray();
                    foreach (JsonSchema schema in jsonSchema_0.Extends)
                    {
                        this.method_0(schema);
                    }
                    this.jsonWriter_0.WriteEndArray();
                }
            }
            this.jsonWriter_0.WriteEndObject();
        }

        private void method_2(JsonWriter jsonWriter_1, string string_0, IDictionary<string, JsonSchema> idictionary_0)
        {
            if (idictionary_0 != null)
            {
                jsonWriter_1.WritePropertyName(string_0);
                jsonWriter_1.WriteStartObject();
                foreach (KeyValuePair<string, JsonSchema> pair in idictionary_0)
                {
                    jsonWriter_1.WritePropertyName(pair.Key);
                    this.method_0(pair.Value);
                }
                jsonWriter_1.WriteEndObject();
            }
        }

        private void method_3(JsonSchema jsonSchema_0)
        {
            if ((jsonSchema_0.Items != null) || jsonSchema_0.PositionalItemsValidation)
            {
                this.jsonWriter_0.WritePropertyName("items");
                if (!jsonSchema_0.PositionalItemsValidation)
                {
                    if ((jsonSchema_0.Items != null) && (jsonSchema_0.Items.Count > 0))
                    {
                        this.method_0(jsonSchema_0.Items[0]);
                    }
                    else
                    {
                        this.jsonWriter_0.WriteStartObject();
                        this.jsonWriter_0.WriteEndObject();
                    }
                }
                else
                {
                    this.jsonWriter_0.WriteStartArray();
                    if (jsonSchema_0.Items != null)
                    {
                        foreach (JsonSchema schema in jsonSchema_0.Items)
                        {
                            this.method_0(schema);
                        }
                    }
                    this.jsonWriter_0.WriteEndArray();
                }
            }
        }

        private void method_4(string string_0, JsonWriter jsonWriter_1, JsonSchemaType jsonSchemaType_0)
        {
            IList<JsonSchemaType> list;
            if (Enum.IsDefined(typeof(JsonSchemaType), jsonSchemaType_0))
            {
                list = new List<JsonSchemaType> {
                    jsonSchemaType_0
                };
            }
            else
            {
                if (func_0 == null)
                {
                    func_0 = new Func<JsonSchemaType, bool>(Class125.smethod_0);
                }
                list = Class186.smethod_0<JsonSchemaType>(jsonSchemaType_0).Where<JsonSchemaType>(func_0).ToList<JsonSchemaType>();
            }
            if (list.Count != 0)
            {
                jsonWriter_1.WritePropertyName(string_0);
                if (list.Count == 1)
                {
                    jsonWriter_1.WriteValue(Class130.smethod_1(list[0]));
                }
                else
                {
                    jsonWriter_1.WriteStartArray();
                    foreach (JsonSchemaType type in list)
                    {
                        jsonWriter_1.WriteValue(Class130.smethod_1(type));
                    }
                    jsonWriter_1.WriteEndArray();
                }
            }
        }

        private void method_5(JsonWriter jsonWriter_1, string string_0, object object_0)
        {
            if (object_0 != null)
            {
                jsonWriter_1.WritePropertyName(string_0);
                jsonWriter_1.WriteValue(object_0);
            }
        }

        [CompilerGenerated]
        private static bool smethod_0(JsonSchemaType jsonSchemaType_0)
        {
            return (jsonSchemaType_0 != JsonSchemaType.None);
        }
    }
}

