namespace ns21
{
    using Newtonsoft.Json.Schema;
    using System;
    using System.Collections.Generic;

    internal static class Class132
    {
        public static readonly IDictionary<string, JsonSchemaType> idictionary_0;
        public const string string_0 = "type";
        public const string string_1 = "properties";
        public const string string_10 = "exclusiveMinimum";
        public const string string_11 = "exclusiveMaximum";
        public const string string_12 = "minItems";
        public const string string_13 = "maxItems";
        public const string string_14 = "pattern";
        public const string string_15 = "maxLength";
        public const string string_16 = "minLength";
        public const string string_17 = "enum";
        public const string string_18 = "readonly";
        public const string string_19 = "title";
        public const string string_2 = "items";
        public const string string_20 = "description";
        public const string string_21 = "format";
        public const string string_22 = "default";
        public const string string_23 = "transient";
        public const string string_24 = "divisibleBy";
        public const string string_25 = "hidden";
        public const string string_26 = "disallow";
        public const string string_27 = "extends";
        public const string string_28 = "id";
        public const string string_29 = "uniqueItems";
        public const string string_3 = "additionalItems";
        public const string string_30 = "value";
        public const string string_31 = "label";
        public const string string_32 = "$ref";
        public const string string_4 = "required";
        public const string string_5 = "patternProperties";
        public const string string_6 = "additionalProperties";
        public const string string_7 = "requires";
        public const string string_8 = "minimum";
        public const string string_9 = "maximum";

        static Class132()
        {
            Dictionary<string, JsonSchemaType> dictionary = new Dictionary<string, JsonSchemaType>();
            dictionary.Add("string", JsonSchemaType.String);
            dictionary.Add("object", JsonSchemaType.Object);
            dictionary.Add("integer", JsonSchemaType.Integer);
            dictionary.Add("number", JsonSchemaType.Float);
            dictionary.Add("null", JsonSchemaType.Null);
            dictionary.Add("boolean", JsonSchemaType.Boolean);
            dictionary.Add("array", JsonSchemaType.Array);
            dictionary.Add("any", JsonSchemaType.Any);
            idictionary_0 = dictionary;
        }
    }
}

