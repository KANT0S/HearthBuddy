namespace ns21
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal class Class130
    {
        private readonly IDictionary<string, JsonSchema> idictionary_0 = new Dictionary<string, JsonSchema>();
        private readonly IList<JsonSchema> ilist_0 = new List<JsonSchema>();
        private JObject jobject_0;
        private JsonSchema jsonSchema_0;
        private readonly JsonSchemaResolver jsonSchemaResolver_0;

        public Class130(JsonSchemaResolver resolver)
        {
            this.jsonSchemaResolver_0 = resolver;
        }

        private void method_0(JsonSchema jsonSchema_1)
        {
            this.jsonSchema_0 = jsonSchema_1;
            this.ilist_0.Add(jsonSchema_1);
            this.jsonSchemaResolver_0.LoadedSchemas.Add(jsonSchema_1);
            this.idictionary_0.Add(jsonSchema_1.String_0, jsonSchema_1);
        }

        private JsonSchema method_1()
        {
            JsonSchema schema = this.jsonSchema_0;
            this.ilist_0.RemoveAt(this.ilist_0.Count - 1);
            this.jsonSchema_0 = this.ilist_0.LastOrDefault<JsonSchema>();
            return schema;
        }

        private void method_10(JToken jtoken_0)
        {
            if (jtoken_0.Type == JTokenType.Boolean)
            {
                this.JsonSchema_0.AllowAdditionalItems = (bool) jtoken_0;
            }
            else
            {
                this.JsonSchema_0.AdditionalItems = this.method_5(jtoken_0);
            }
        }

        private IDictionary<string, JsonSchema> method_11(JToken jtoken_0)
        {
            IDictionary<string, JsonSchema> dictionary = new Dictionary<string, JsonSchema>();
            if (jtoken_0.Type != JTokenType.Object)
            {
                throw JsonException.smethod_0(jtoken_0, jtoken_0.Path, "Expected Object token while parsing schema properties, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
            }
            foreach (JProperty property in (IEnumerable<JToken>) jtoken_0)
            {
                if (dictionary.ContainsKey(property.Name))
                {
                    throw new JsonException("Property {0} has already been defined in schema.".smethod_0(CultureInfo.InvariantCulture, property.Name));
                }
                dictionary.Add(property.Name, this.method_5(property.Value));
            }
            return dictionary;
        }

        private void method_12(JToken jtoken_0)
        {
            this.JsonSchema_0.Items = new List<JsonSchema>();
            switch (jtoken_0.Type)
            {
                case JTokenType.Object:
                    this.JsonSchema_0.Items.Add(this.method_5(jtoken_0));
                    this.JsonSchema_0.PositionalItemsValidation = false;
                    return;

                case JTokenType.Array:
                    this.JsonSchema_0.PositionalItemsValidation = true;
                    foreach (JToken token in (IEnumerable<JToken>) jtoken_0)
                    {
                        this.JsonSchema_0.Items.Add(this.method_5(token));
                    }
                    return;
            }
            throw JsonException.smethod_0(jtoken_0, jtoken_0.Path, "Expected array or JSON schema object, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
        }

        private JsonSchemaType? method_13(JToken jtoken_0)
        {
            JTokenType type = jtoken_0.Type;
            if (type != JTokenType.Array)
            {
                if (type != JTokenType.String)
                {
                    throw JsonException.smethod_0(jtoken_0, jtoken_0.Path, "Expected array or JSON schema type string token, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
                }
                return new JsonSchemaType?(smethod_0((string) jtoken_0));
            }
            JsonSchemaType? nullable = new JsonSchemaType?(JsonSchemaType.None);
            foreach (JToken token in (IEnumerable<JToken>) jtoken_0)
            {
                if (token.Type != JTokenType.String)
                {
                    throw JsonException.smethod_0(token, token.Path, "Exception JSON schema type string token, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
                }
                JsonSchemaType? nullable2 = nullable;
                JsonSchemaType type2 = smethod_0((string) token);
                nullable = nullable2.HasValue ? new JsonSchemaType?(((JsonSchemaType) nullable2.GetValueOrDefault()) | type2) : null;
            }
            return nullable;
        }

        internal JsonSchema method_2(JsonReader jsonReader_0)
        {
            JToken token = JToken.ReadFrom(jsonReader_0);
            this.jobject_0 = token as JObject;
            JsonSchema schema = this.method_5(token);
            this.method_4(schema);
            return schema;
        }

        private string method_3(string string_0)
        {
            return Uri.UnescapeDataString(string_0).Replace("~1", "/").Replace("~0", "~");
        }

        private JsonSchema method_4(JsonSchema jsonSchema_1)
        {
            if (jsonSchema_1.String_2 != null)
            {
                bool flag;
                string str = jsonSchema_1.String_2;
                if (flag = str.StartsWith("#", StringComparison.OrdinalIgnoreCase))
                {
                    str = this.method_3(str);
                }
                JsonSchema schema = this.jsonSchemaResolver_0.GetSchema(str);
                if (schema == null)
                {
                    if (flag)
                    {
                        string[] strArray = jsonSchema_1.String_2.TrimStart(new char[] { '#' }).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        JToken source = this.jobject_0;
                        foreach (string str2 in strArray)
                        {
                            string s = this.method_3(str2);
                            if (source.Type == JTokenType.Object)
                            {
                                source = source[s];
                            }
                            else if ((source.Type == JTokenType.Array) || (source.Type == JTokenType.Constructor))
                            {
                                int num;
                                if ((int.TryParse(s, out num) && (num >= 0)) && (num < source.Count<JToken>()))
                                {
                                    source = source[num];
                                }
                                else
                                {
                                    source = null;
                                }
                            }
                            if (source == null)
                            {
                                break;
                            }
                        }
                        if (source != null)
                        {
                            schema = this.method_5(source);
                        }
                    }
                    if (schema == null)
                    {
                        throw new JsonException("Could not resolve schema reference '{0}'.".smethod_0(CultureInfo.InvariantCulture, jsonSchema_1.String_2));
                    }
                }
                jsonSchema_1 = schema;
            }
            if (!jsonSchema_1.Boolean_0)
            {
                jsonSchema_1.Boolean_0 = true;
                if (jsonSchema_1.Extends != null)
                {
                    for (int i = 0; i < jsonSchema_1.Extends.Count; i++)
                    {
                        jsonSchema_1.Extends[i] = this.method_4(jsonSchema_1.Extends[i]);
                    }
                }
                if (jsonSchema_1.Items != null)
                {
                    for (int j = 0; j < jsonSchema_1.Items.Count; j++)
                    {
                        jsonSchema_1.Items[j] = this.method_4(jsonSchema_1.Items[j]);
                    }
                }
                if (jsonSchema_1.AdditionalItems != null)
                {
                    jsonSchema_1.AdditionalItems = this.method_4(jsonSchema_1.AdditionalItems);
                }
                if (jsonSchema_1.PatternProperties != null)
                {
                    foreach (KeyValuePair<string, JsonSchema> pair in jsonSchema_1.PatternProperties.ToList<KeyValuePair<string, JsonSchema>>())
                    {
                        jsonSchema_1.PatternProperties[pair.Key] = this.method_4(pair.Value);
                    }
                }
                if (jsonSchema_1.Properties != null)
                {
                    foreach (KeyValuePair<string, JsonSchema> pair2 in jsonSchema_1.Properties.ToList<KeyValuePair<string, JsonSchema>>())
                    {
                        jsonSchema_1.Properties[pair2.Key] = this.method_4(pair2.Value);
                    }
                }
                if (jsonSchema_1.AdditionalProperties != null)
                {
                    jsonSchema_1.AdditionalProperties = this.method_4(jsonSchema_1.AdditionalProperties);
                }
            }
            return jsonSchema_1;
        }

        private JsonSchema method_5(JToken jtoken_0)
        {
            JToken token;
            JsonSchema schema2;
            JObject obj2 = jtoken_0 as JObject;
            if (obj2 == null)
            {
                throw JsonException.smethod_0(jtoken_0, jtoken_0.Path, "Expected object while parsing schema object, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
            }
            if (obj2.TryGetValue("$ref", out token))
            {
                return new JsonSchema { String_2 = (string) token };
            }
            string str = jtoken_0.Path.Replace(".", "/").Replace("[", "/").Replace("]", string.Empty);
            if (!string.IsNullOrEmpty(str))
            {
                str = "/" + str;
            }
            str = "#" + str;
            if (this.idictionary_0.TryGetValue(str, out schema2))
            {
                return schema2;
            }
            JsonSchema schema3 = new JsonSchema {
                String_0 = str
            };
            this.method_0(schema3);
            this.method_6(obj2);
            return this.method_1();
        }

        private void method_6(JObject jobject_1)
        {
            foreach (KeyValuePair<string, JToken> pair in jobject_1)
            {
                string key = pair.Key;
                if (key != null)
                {
                    int num;
                    if (Class204.dictionary_0 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1d);
                        dictionary1.Add("type", 0);
                        dictionary1.Add("id", 1);
                        dictionary1.Add("title", 2);
                        dictionary1.Add("description", 3);
                        dictionary1.Add("properties", 4);
                        dictionary1.Add("items", 5);
                        dictionary1.Add("additionalProperties", 6);
                        dictionary1.Add("additionalItems", 7);
                        dictionary1.Add("patternProperties", 8);
                        dictionary1.Add("required", 9);
                        dictionary1.Add("requires", 10);
                        dictionary1.Add("minimum", 11);
                        dictionary1.Add("maximum", 12);
                        dictionary1.Add("exclusiveMinimum", 13);
                        dictionary1.Add("exclusiveMaximum", 14);
                        dictionary1.Add("maxLength", 15);
                        dictionary1.Add("minLength", 0x10);
                        dictionary1.Add("maxItems", 0x11);
                        dictionary1.Add("minItems", 0x12);
                        dictionary1.Add("divisibleBy", 0x13);
                        dictionary1.Add("disallow", 20);
                        dictionary1.Add("default", 0x15);
                        dictionary1.Add("hidden", 0x16);
                        dictionary1.Add("readonly", 0x17);
                        dictionary1.Add("format", 0x18);
                        dictionary1.Add("pattern", 0x19);
                        dictionary1.Add("enum", 0x1a);
                        dictionary1.Add("extends", 0x1b);
                        dictionary1.Add("uniqueItems", 0x1c);
                        Class204.dictionary_0 = dictionary1;
                    }
                    if (Class204.dictionary_0.TryGetValue(key, out num))
                    {
                        switch (num)
                        {
                            case 0:
                                this.JsonSchema_0.Type = this.method_13(pair.Value);
                                break;

                            case 1:
                                this.JsonSchema_0.Id = (string) pair.Value;
                                break;

                            case 2:
                                this.JsonSchema_0.Title = (string) pair.Value;
                                break;

                            case 3:
                                this.JsonSchema_0.Description = (string) pair.Value;
                                break;

                            case 4:
                                this.JsonSchema_0.Properties = this.method_11(pair.Value);
                                break;

                            case 5:
                                this.method_12(pair.Value);
                                break;

                            case 6:
                                this.method_9(pair.Value);
                                break;

                            case 7:
                                this.method_10(pair.Value);
                                break;

                            case 8:
                                this.JsonSchema_0.PatternProperties = this.method_11(pair.Value);
                                break;

                            case 9:
                                this.JsonSchema_0.Required = new bool?((bool) pair.Value);
                                break;

                            case 10:
                                this.JsonSchema_0.Requires = (string) pair.Value;
                                break;

                            case 11:
                                this.JsonSchema_0.Minimum = new double?((double) pair.Value);
                                break;

                            case 12:
                                this.JsonSchema_0.Maximum = new double?((double) pair.Value);
                                break;

                            case 13:
                                this.JsonSchema_0.ExclusiveMinimum = new bool?((bool) pair.Value);
                                break;

                            case 14:
                                this.JsonSchema_0.ExclusiveMaximum = new bool?((bool) pair.Value);
                                break;

                            case 15:
                                this.JsonSchema_0.MaximumLength = new int?((int) pair.Value);
                                break;

                            case 0x10:
                                this.JsonSchema_0.MinimumLength = new int?((int) pair.Value);
                                break;

                            case 0x11:
                                this.JsonSchema_0.MaximumItems = new int?((int) pair.Value);
                                break;

                            case 0x12:
                                this.JsonSchema_0.MinimumItems = new int?((int) pair.Value);
                                break;

                            case 0x13:
                                this.JsonSchema_0.DivisibleBy = new double?((double) pair.Value);
                                break;

                            case 20:
                                this.JsonSchema_0.Disallow = this.method_13(pair.Value);
                                break;

                            case 0x15:
                                this.JsonSchema_0.Default = pair.Value.DeepClone();
                                break;

                            case 0x16:
                                this.JsonSchema_0.Hidden = new bool?((bool) pair.Value);
                                break;

                            case 0x17:
                                this.JsonSchema_0.ReadOnly = new bool?((bool) pair.Value);
                                break;

                            case 0x18:
                                this.JsonSchema_0.Format = (string) pair.Value;
                                break;

                            case 0x19:
                                this.JsonSchema_0.Pattern = (string) pair.Value;
                                break;

                            case 0x1a:
                                this.method_8(pair.Value);
                                break;

                            case 0x1b:
                                this.method_7(pair.Value);
                                break;

                            case 0x1c:
                                this.JsonSchema_0.UniqueItems = (bool) pair.Value;
                                break;
                        }
                    }
                }
            }
        }

        private void method_7(JToken jtoken_0)
        {
            IList<JsonSchema> list = new List<JsonSchema>();
            if (jtoken_0.Type == JTokenType.Array)
            {
                foreach (JToken token in (IEnumerable<JToken>) jtoken_0)
                {
                    list.Add(this.method_5(token));
                }
            }
            else
            {
                JsonSchema item = this.method_5(jtoken_0);
                if (item != null)
                {
                    list.Add(item);
                }
            }
            if (list.Count > 0)
            {
                this.JsonSchema_0.Extends = list;
            }
        }

        private void method_8(JToken jtoken_0)
        {
            if (jtoken_0.Type != JTokenType.Array)
            {
                throw JsonException.smethod_0(jtoken_0, jtoken_0.Path, "Expected Array token while parsing enum values, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
            }
            this.JsonSchema_0.Enum = new List<JToken>();
            foreach (JToken token in (IEnumerable<JToken>) jtoken_0)
            {
                this.JsonSchema_0.Enum.Add(token.DeepClone());
            }
        }

        private void method_9(JToken jtoken_0)
        {
            if (jtoken_0.Type == JTokenType.Boolean)
            {
                this.JsonSchema_0.AllowAdditionalProperties = (bool) jtoken_0;
            }
            else
            {
                this.JsonSchema_0.AdditionalProperties = this.method_5(jtoken_0);
            }
        }

        internal static JsonSchemaType smethod_0(string string_0)
        {
            JsonSchemaType type;
            if (!Class132.idictionary_0.TryGetValue(string_0, out type))
            {
                throw new JsonException("Invalid JSON schema type: {0}".smethod_0(CultureInfo.InvariantCulture, string_0));
            }
            return type;
        }

        internal static string smethod_1(JsonSchemaType jsonSchemaType_0)
        {
            Class131 class2 = new Class131 {
                jsonSchemaType_0 = jsonSchemaType_0
            };
            return Class132.idictionary_0.Single<KeyValuePair<string, JsonSchemaType>>(new Func<KeyValuePair<string, JsonSchemaType>, bool>(class2.method_0)).Key;
        }

        private JsonSchema JsonSchema_0
        {
            get
            {
                return this.jsonSchema_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class131
        {
            public JsonSchemaType jsonSchemaType_0;

            public bool method_0(KeyValuePair<string, JsonSchemaType> keyValuePair_0)
            {
                return (((JsonSchemaType) keyValuePair_0.Value) == this.jsonSchemaType_0);
            }
        }
    }
}

