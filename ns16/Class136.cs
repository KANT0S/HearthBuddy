namespace ns16
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Serialization;
    using ns18;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Dynamic;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    internal class Class136 : Class135
    {
        private Class112 class112_0;
        private Class89 class89_0;
        [CompilerGenerated]
        private static Func<ParameterInfo, ParameterInfo> func_0;
        [CompilerGenerated]
        private static Func<ParameterInfo, object> func_1;
        [CompilerGenerated]
        private static Func<KeyValuePair<ParameterInfo, object>, string> func_2;
        [CompilerGenerated]
        private static Func<JsonProperty, JsonProperty> func_3;
        [CompilerGenerated]
        private static Func<JsonProperty, Enum16> func_4;

        public Class136(JsonSerializer serializer) : base(serializer)
        {
        }

        private object method_10(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0)
        {
            if ((jsonContract_0 == null) || (jsonContract_0.enum15_0 != Enum15.Linq))
            {
            Label_0020:
                switch (jsonReader_0.JsonToken_0)
                {
                    case JsonToken.StartObject:
                        return this.method_13(jsonReader_0, type_0, jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0);

                    case JsonToken.StartArray:
                        return this.method_17(jsonReader_0, type_0, jsonContract_0, jsonProperty_0, object_0, null);

                    case JsonToken.StartConstructor:
                    {
                        string str2 = jsonReader_0.Object_0.ToString();
                        return this.method_19(jsonReader_0, str2, CultureInfo.InvariantCulture, jsonContract_0, type_0);
                    }
                    case JsonToken.Comment:
                        if (!jsonReader_0.Read())
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when deserializing object.");
                        }
                        goto Label_0020;

                    case JsonToken.Raw:
                        return new JRaw((string) jsonReader_0.Object_0);

                    case JsonToken.Integer:
                    case JsonToken.Float:
                    case JsonToken.Boolean:
                    case JsonToken.Date:
                    case JsonToken.Bytes:
                        return this.method_19(jsonReader_0, jsonReader_0.Object_0, CultureInfo.InvariantCulture, jsonContract_0, type_0);

                    case JsonToken.String:
                    {
                        string str = (string) jsonReader_0.Object_0;
                        if (((!string.IsNullOrEmpty(str) || !(type_0 != typeof(string))) || (!(type_0 != typeof(object)) || (jsonContract_0 == null))) || !jsonContract_0.bool_0)
                        {
                            if (type_0 == typeof(byte[]))
                            {
                                return Convert.FromBase64String(str);
                            }
                            return this.method_19(jsonReader_0, str, CultureInfo.InvariantCulture, jsonContract_0, type_0);
                        }
                        return null;
                    }
                    case JsonToken.Null:
                    case JsonToken.Undefined:
                        if (!(type_0 == typeof(DBNull)))
                        {
                            return this.method_19(jsonReader_0, jsonReader_0.Object_0, CultureInfo.InvariantCulture, jsonContract_0, type_0);
                        }
                        return DBNull.Value;
                }
            }
            else
            {
                return this.method_8(jsonReader_0, jsonContract_0);
            }
            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token while deserializing object: " + jsonReader_0.JsonToken_0);
        }

        internal string method_11(JsonContract jsonContract_0)
        {
            switch (jsonContract_0.enum15_0)
            {
                case Enum15.Object:
                case Enum15.Dictionary:
                case Enum15.Dynamic:
                case Enum15.Serializable:
                    return "JSON object (e.g. {\"name\":\"value\"})";

                case Enum15.Array:
                    return "JSON array (e.g. [1,2,3])";

                case Enum15.Primitive:
                    return "JSON primitive value (e.g. string, number, boolean, null)";

                case Enum15.String:
                    return "JSON string value";
            }
            throw new ArgumentOutOfRangeException();
        }

        private JsonConverter method_12(JsonContract jsonContract_0, JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0)
        {
            JsonConverter converter = null;
            if (jsonConverter_0 != null)
            {
                return jsonConverter_0;
            }
            if ((jsonProperty_0 != null) && (jsonProperty_0.ItemConverter != null))
            {
                return jsonProperty_0.ItemConverter;
            }
            if ((jsonContainerContract_0 != null) && (jsonContainerContract_0.ItemConverter != null))
            {
                return jsonContainerContract_0.ItemConverter;
            }
            if (jsonContract_0 != null)
            {
                if (jsonContract_0.Converter != null)
                {
                    return jsonContract_0.Converter;
                }
                JsonConverter converter2 = base.jsonSerializer_0.method_2(jsonContract_0.UnderlyingType);
                if (converter2 != null)
                {
                    return converter2;
                }
                if (jsonContract_0.JsonConverter_0 != null)
                {
                    converter = jsonContract_0.JsonConverter_0;
                }
            }
            return converter;
        }

        private object method_13(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0)
        {
            string str;
            object obj2;
            bool flag;
            JsonObjectContract contract;
            object obj3;
            this.method_16(jsonReader_0);
            if (this.method_14(jsonReader_0, ref type_0, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0, out obj2, out str))
            {
                return obj2;
            }
            if (this.method_18(jsonContract_0))
            {
                return this.method_9(jsonReader_0);
            }
            switch (jsonContract_0.enum15_0)
            {
                case Enum15.Object:
                    flag = false;
                    contract = (JsonObjectContract) jsonContract_0;
                    if (object_0 == null)
                    {
                        obj3 = this.method_39(jsonReader_0, contract, jsonProperty_0, jsonProperty_1, str, out flag);
                        break;
                    }
                    obj3 = object_0;
                    break;

                case Enum15.Primitive:
                {
                    JsonPrimitiveContract contract2 = (JsonPrimitiveContract) jsonContract_0;
                    if ((jsonReader_0.JsonToken_0 == JsonToken.PropertyName) && string.Equals(jsonReader_0.Object_0.ToString(), "$value", StringComparison.Ordinal))
                    {
                        this.method_16(jsonReader_0);
                        if (jsonReader_0.JsonToken_0 == JsonToken.StartObject)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing primitive value: " + jsonReader_0.JsonToken_0);
                        }
                        object obj4 = this.method_10(jsonReader_0, type_0, contract2, jsonProperty_0, null, null, object_0);
                        this.method_16(jsonReader_0);
                        return obj4;
                    }
                    goto Label_010E;
                }
                case Enum15.Dictionary:
                {
                    JsonDictionaryContract contract3 = (JsonDictionaryContract) jsonContract_0;
                    if (object_0 == null)
                    {
                        bool flag2;
                        IDictionary dictionary = this.method_26(jsonReader_0, contract3, out flag2);
                        if ((str != null) && flag2)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
                        }
                        if ((jsonContract_0.OnSerializingCallbacks.Count > 0) && flag2)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
                        }
                        if ((jsonContract_0.OnErrorCallbacks.Count > 0) && flag2)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
                        }
                        this.method_29(dictionary, jsonReader_0, contract3, jsonProperty_0, str);
                        if (flag2)
                        {
                            return contract3.ConstructorInfo_0.Invoke(new object[] { dictionary });
                        }
                        if (dictionary is Interface16)
                        {
                            return ((Interface16) dictionary).Object_0;
                        }
                        return dictionary;
                    }
                    return this.method_29(contract3.Boolean_0 ? contract3.method_5(object_0) : ((IDictionary) object_0), jsonReader_0, contract3, jsonProperty_0, str);
                }
                case Enum15.Dynamic:
                {
                    JsonDynamicContract contract4 = (JsonDynamicContract) jsonContract_0;
                    return this.method_34(jsonReader_0, contract4, jsonProperty_0, str);
                }
                case Enum15.Serializable:
                {
                    JsonISerializableContract contract5 = (JsonISerializableContract) jsonContract_0;
                    return this.method_33(jsonReader_0, contract5, jsonProperty_0, str);
                }
                default:
                    goto Label_010E;
            }
            if (flag)
            {
                return obj3;
            }
            return this.method_40(obj3, jsonReader_0, contract, jsonProperty_0, str);
        Label_010E:
            throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly.\r\nTo fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.\r\n".smethod_1(CultureInfo.InvariantCulture, type_0, this.method_11(jsonContract_0)));
        }

        private bool method_14(JsonReader jsonReader_0, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0, out object object_1, out string string_0)
        {
            string_0 = null;
            object_1 = null;
            if (jsonReader_0.JsonToken_0 == JsonToken.PropertyName)
            {
                string a = jsonReader_0.Object_0.ToString();
                if ((a.Length > 0) && (a[0] == '$'))
                {
                    bool flag;
                    do
                    {
                        a = jsonReader_0.Object_0.ToString();
                        if (!string.Equals(a, "$ref", StringComparison.Ordinal))
                        {
                            if (string.Equals(a, "$type", StringComparison.Ordinal))
                            {
                                TypeNameHandling? nullable6;
                                this.method_16(jsonReader_0);
                                string str3 = jsonReader_0.Object_0.ToString();
                                TypeNameHandling? nullable2 = (jsonProperty_0 != null) ? jsonProperty_0.TypeNameHandling : null;
                                if (!nullable2.HasValue)
                                {
                                    TypeNameHandling? nullable4 = (jsonContainerContract_0 != null) ? jsonContainerContract_0.ItemTypeNameHandling : null;
                                    if (!nullable4.HasValue)
                                    {
                                        nullable6 = (jsonProperty_1 != null) ? jsonProperty_1.ItemTypeNameHandling : null;
                                    }
                                }
                                if (((TypeNameHandling) (nullable6.HasValue ? nullable2.GetValueOrDefault() : base.jsonSerializer_0.typeNameHandling_0)) != TypeNameHandling.None)
                                {
                                    string str4;
                                    string str5;
                                    Type type;
                                    Class194.smethod_32(str3, out str4, out str5);
                                    try
                                    {
                                        type = base.jsonSerializer_0.serializationBinder_0.BindToType(str5, str4);
                                    }
                                    catch (Exception exception)
                                    {
                                        throw JsonSerializationException.smethod_2(jsonReader_0, "Error resolving type specified in JSON '{0}'.".smethod_0(CultureInfo.InvariantCulture, str3), exception);
                                    }
                                    if (type == null)
                                    {
                                        throw JsonSerializationException.smethod_1(jsonReader_0, "Type specified in JSON '{0}' was not resolved.".smethod_0(CultureInfo.InvariantCulture, str3));
                                    }
                                    if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                                    {
                                        base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Resolved type '{0}' to {1}.".smethod_1(CultureInfo.InvariantCulture, str3, type)), null);
                                    }
                                    if (((type_0 != null) && (type_0 != typeof(IDynamicMetaObjectProvider))) && !type_0.IsAssignableFrom(type))
                                    {
                                        throw JsonSerializationException.smethod_1(jsonReader_0, "Type specified in JSON '{0}' is not compatible with '{1}'.".smethod_1(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, type_0.AssemblyQualifiedName));
                                    }
                                    type_0 = type;
                                    jsonContract_0 = this.method_4(type);
                                }
                                this.method_16(jsonReader_0);
                                flag = true;
                            }
                            else if (string.Equals(a, "$id", StringComparison.Ordinal))
                            {
                                this.method_16(jsonReader_0);
                                string_0 = (jsonReader_0.Object_0 != null) ? jsonReader_0.Object_0.ToString() : null;
                                this.method_16(jsonReader_0);
                                flag = true;
                            }
                            else
                            {
                                if (string.Equals(a, "$values", StringComparison.Ordinal))
                                {
                                    this.method_16(jsonReader_0);
                                    object obj2 = this.method_17(jsonReader_0, type_0, jsonContract_0, jsonProperty_0, object_0, string_0);
                                    this.method_16(jsonReader_0);
                                    object_1 = obj2;
                                    return true;
                                }
                                flag = false;
                            }
                        }
                        else
                        {
                            this.method_16(jsonReader_0);
                            if ((jsonReader_0.JsonToken_0 != JsonToken.String) && (jsonReader_0.JsonToken_0 != JsonToken.Null))
                            {
                                throw JsonSerializationException.smethod_1(jsonReader_0, "JSON reference {0} property must have a string or null value.".smethod_0(CultureInfo.InvariantCulture, "$ref"));
                            }
                            string reference = (jsonReader_0.Object_0 != null) ? jsonReader_0.Object_0.ToString() : null;
                            this.method_16(jsonReader_0);
                            if (reference != null)
                            {
                                if (jsonReader_0.JsonToken_0 == JsonToken.PropertyName)
                                {
                                    throw JsonSerializationException.smethod_1(jsonReader_0, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".smethod_0(CultureInfo.InvariantCulture, "$ref"));
                                }
                                object_1 = base.jsonSerializer_0.method_1().ResolveReference(this, reference);
                                if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
                                {
                                    base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Resolved object reference '{0}' to {1}.".smethod_1(CultureInfo.InvariantCulture, reference, object_1.GetType())), null);
                                }
                                return true;
                            }
                            flag = true;
                        }
                    }
                    while (flag && (jsonReader_0.JsonToken_0 == JsonToken.PropertyName));
                }
            }
            return false;
        }

        private JsonArrayContract method_15(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0)
        {
            if (jsonContract_0 == null)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Could not resolve type '{0}' to a JsonContract.".smethod_0(CultureInfo.InvariantCulture, type_0));
            }
            JsonArrayContract contract = jsonContract_0 as JsonArrayContract;
            if (contract == null)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly.\r\nTo fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array.\r\n".smethod_1(CultureInfo.InvariantCulture, type_0, this.method_11(jsonContract_0)));
            }
            return contract;
        }

        private void method_16(JsonReader jsonReader_0)
        {
            if (!jsonReader_0.Read())
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when deserializing object.");
            }
        }

        private object method_17(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, object object_0, string string_0)
        {
            if (this.method_18(jsonContract_0))
            {
                return this.method_8(jsonReader_0, jsonContract_0);
            }
            JsonArrayContract contract = this.method_15(jsonReader_0, type_0, jsonContract_0);
            if (object_0 == null)
            {
                bool flag;
                IList list = this.method_25(jsonReader_0, contract, out flag);
                if ((string_0 != null) && flag)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
                }
                if ((jsonContract_0.OnSerializingCallbacks.Count > 0) && flag)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
                }
                if ((jsonContract_0.OnErrorCallbacks.Count > 0) && flag)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
                }
                if (!contract.IsMultidimensionalArray)
                {
                    this.method_32(list, jsonReader_0, contract, jsonProperty_0, string_0);
                }
                else
                {
                    this.method_30(list, jsonReader_0, contract, jsonProperty_0, string_0);
                }
                if (flag)
                {
                    if (contract.IsMultidimensionalArray)
                    {
                        return Class191.smethod_13(list, contract.CollectionItemType, jsonContract_0.CreatedType.GetArrayRank());
                    }
                    if (jsonContract_0.CreatedType.IsArray)
                    {
                        Array array = Array.CreateInstance(contract.CollectionItemType, list.Count);
                        list.CopyTo(array, 0);
                        return array;
                    }
                    return contract.ConstructorInfo_0.Invoke(new object[] { list });
                }
                if (list is Interface15)
                {
                    return ((Interface15) list).Object_0;
                }
                return list;
            }
            return this.method_32(contract.Boolean_0 ? contract.method_5(object_0) : ((IList) object_0), jsonReader_0, contract, jsonProperty_0, string_0);
        }

        private bool method_18(JsonContract jsonContract_0)
        {
            if (((jsonContract_0 != null) && !(jsonContract_0.UnderlyingType == typeof(object))) && (jsonContract_0.enum15_0 != Enum15.Linq))
            {
                return (jsonContract_0.UnderlyingType == typeof(IDynamicMetaObjectProvider));
            }
            return true;
        }

        private object method_19(JsonReader jsonReader_0, object object_0, CultureInfo cultureInfo_0, JsonContract jsonContract_0, Type type_0)
        {
            object obj2;
            if (type_0 == null)
            {
                return object_0;
            }
            if (!(Class194.smethod_3(object_0) != type_0))
            {
                return object_0;
            }
            if ((object_0 == null) && jsonContract_0.bool_0)
            {
                return null;
            }
            try
            {
                if (jsonContract_0.bool_1)
                {
                    JsonPrimitiveContract contract = (JsonPrimitiveContract) jsonContract_0;
                    if (jsonContract_0.bool_3)
                    {
                        if (object_0 is string)
                        {
                            return Enum.Parse(jsonContract_0.type_0, object_0.ToString(), true);
                        }
                        if (Class181.smethod_14(contract.Enum17_0))
                        {
                            return Enum.ToObject(jsonContract_0.type_0, object_0);
                        }
                    }
                    if (object_0 is BigInteger)
                    {
                        return Class181.smethod_7((BigInteger) object_0, type_0);
                    }
                    return Convert.ChangeType(object_0, jsonContract_0.type_0, cultureInfo_0);
                }
                obj2 = Class181.smethod_10(object_0, cultureInfo_0, jsonContract_0.type_0);
            }
            catch (Exception exception)
            {
                throw JsonSerializationException.smethod_2(jsonReader_0, "Error converting value {0} to type '{1}'.".smethod_1(CultureInfo.InvariantCulture, Class193.smethod_7(object_0), type_0), exception);
            }
            return obj2;
        }

        private bool method_20(JsonProperty jsonProperty_0, JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, JsonReader jsonReader_0, object object_0)
        {
            object obj2;
            bool flag;
            JsonContract contract;
            bool flag2;
            object obj3;
            if (this.method_21(jsonProperty_0, ref jsonConverter_0, jsonContainerContract_0, jsonProperty_1, jsonReader_0, object_0, out flag, out obj2, out contract, out flag2))
            {
                return false;
            }
            if ((jsonConverter_0 != null) && jsonConverter_0.CanRead)
            {
                if ((!flag2 && (object_0 != null)) && jsonProperty_0.Readable)
                {
                    obj2 = jsonProperty_0.ValueProvider.GetValue(object_0);
                }
                obj3 = this.method_36(jsonConverter_0, jsonReader_0, jsonProperty_0.PropertyType, obj2);
            }
            else
            {
                obj3 = this.method_10(jsonReader_0, jsonProperty_0.PropertyType, contract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, flag ? obj2 : null);
            }
            if (flag && (obj3 == obj2))
            {
                return flag;
            }
            if (!this.method_24(jsonProperty_0, obj3))
            {
                return flag;
            }
            jsonProperty_0.ValueProvider.SetValue(object_0, obj3);
            if (jsonProperty_0.SetIsSpecified != null)
            {
                if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                {
                    base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "IsSpecified for property '{0}' on {1} set to true.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType)), null);
                }
                jsonProperty_0.SetIsSpecified(object_0, true);
            }
            return true;
        }

        private bool method_21(JsonProperty jsonProperty_0, ref JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, JsonReader jsonReader_0, object object_0, out bool bool_1, out object object_1, out JsonContract jsonContract_0, out bool bool_2)
        {
            object_1 = null;
            bool_1 = false;
            jsonContract_0 = null;
            bool_2 = false;
            if (jsonProperty_0.Ignored)
            {
                return true;
            }
            JsonToken token = jsonReader_0.JsonToken_0;
            if (jsonProperty_0.JsonContract_0 == null)
            {
                jsonProperty_0.JsonContract_0 = this.method_4(jsonProperty_0.PropertyType);
            }
            if (((((ObjectCreationHandling) jsonProperty_0.ObjectCreationHandling.GetValueOrDefault(base.jsonSerializer_0.objectCreationHandling_0)) != ObjectCreationHandling.Replace) && ((token == JsonToken.StartArray) || (token == JsonToken.StartObject))) && jsonProperty_0.Readable)
            {
                object_1 = jsonProperty_0.ValueProvider.GetValue(object_0);
                bool_2 = true;
                if (object_1 != null)
                {
                    jsonContract_0 = this.method_4(object_1.GetType());
                    bool_1 = !jsonContract_0.bool_4 && !jsonContract_0.UnderlyingType.smethod_12();
                }
            }
            if (!jsonProperty_0.Writable && !bool_1)
            {
                return true;
            }
            if ((((NullValueHandling) jsonProperty_0.NullValueHandling.GetValueOrDefault(base.jsonSerializer_0.nullValueHandling_0)) == NullValueHandling.Ignore) && (token == JsonToken.Null))
            {
                return true;
            }
            if ((this.method_23(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(base.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Ignore) && !this.method_23(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(base.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate)) && (JsonReader.smethod_0(token) && Class193.smethod_0(jsonReader_0.Object_0, jsonProperty_0.method_1())))
            {
                return true;
            }
            if (object_1 == null)
            {
                jsonContract_0 = jsonProperty_0.JsonContract_0;
            }
            else
            {
                jsonContract_0 = this.method_4(object_1.GetType());
                if (jsonContract_0 != jsonProperty_0.JsonContract_0)
                {
                    jsonConverter_0 = this.method_12(jsonContract_0, jsonProperty_0.MemberConverter, jsonContainerContract_0, jsonProperty_1);
                }
            }
            return false;
        }

        private void method_22(JsonReader jsonReader_0, string string_0, object object_0)
        {
            try
            {
                if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                {
                    base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Read object reference Id '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, string_0, object_0.GetType())), null);
                }
                base.jsonSerializer_0.method_1().AddReference(this, string_0, object_0);
            }
            catch (Exception exception)
            {
                throw JsonSerializationException.smethod_2(jsonReader_0, "Error reading object reference '{0}'.".smethod_0(CultureInfo.InvariantCulture, string_0), exception);
            }
        }

        private bool method_23(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
        {
            return ((defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1);
        }

        private bool method_24(JsonProperty jsonProperty_0, object object_0)
        {
            if ((((NullValueHandling) jsonProperty_0.NullValueHandling.GetValueOrDefault(base.jsonSerializer_0.nullValueHandling_0)) == NullValueHandling.Ignore) && (object_0 == null))
            {
                return false;
            }
            if ((this.method_23(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(base.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Ignore) && !this.method_23(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(base.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate)) && Class193.smethod_0(object_0, jsonProperty_0.method_1()))
            {
                return false;
            }
            if (!jsonProperty_0.Writable)
            {
                return false;
            }
            return true;
        }

        private IList method_25(JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, out bool bool_1)
        {
            if (!jsonArrayContract_0.Boolean_1)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot create and populate list type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonArrayContract_0.CreatedType));
            }
            if (jsonArrayContract_0.bool_4)
            {
                bool_1 = true;
                IList list = jsonArrayContract_0.method_6();
                if (jsonArrayContract_0.Boolean_0)
                {
                    list = jsonArrayContract_0.method_5(list);
                }
                return list;
            }
            if ((jsonArrayContract_0.DefaultCreator != null) && (!jsonArrayContract_0.DefaultCreatorNonPublic || (base.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor)))
            {
                object obj2 = jsonArrayContract_0.DefaultCreator();
                if (jsonArrayContract_0.Boolean_0)
                {
                    obj2 = jsonArrayContract_0.method_5(obj2);
                }
                bool_1 = false;
                return (IList) obj2;
            }
            if (jsonArrayContract_0.ConstructorInfo_0 == null)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unable to find a constructor to use for type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonArrayContract_0.UnderlyingType));
            }
            bool_1 = true;
            return jsonArrayContract_0.method_6();
        }

        private IDictionary method_26(JsonReader jsonReader_0, JsonDictionaryContract jsonDictionaryContract_0, out bool bool_1)
        {
            if (jsonDictionaryContract_0.bool_4)
            {
                bool_1 = true;
                return jsonDictionaryContract_0.method_6();
            }
            if ((jsonDictionaryContract_0.DefaultCreator != null) && (!jsonDictionaryContract_0.DefaultCreatorNonPublic || (base.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor)))
            {
                object obj2 = jsonDictionaryContract_0.DefaultCreator();
                if (jsonDictionaryContract_0.Boolean_0)
                {
                    obj2 = jsonDictionaryContract_0.method_5(obj2);
                }
                bool_1 = false;
                return (IDictionary) obj2;
            }
            if (jsonDictionaryContract_0.ConstructorInfo_0 == null)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unable to find a default constructor to use for type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonDictionaryContract_0.UnderlyingType));
            }
            bool_1 = true;
            return jsonDictionaryContract_0.method_6();
        }

        private void method_27(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0)
        {
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Started deserializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
            }
            jsonContract_0.method_2(object_0, base.jsonSerializer_0.streamingContext_0);
        }

        private void method_28(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0)
        {
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Finished deserializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
            }
            jsonContract_0.method_3(object_0, base.jsonSerializer_0.streamingContext_0);
        }

        private object method_29(IDictionary idictionary_0, JsonReader jsonReader_0, JsonDictionaryContract jsonDictionaryContract_0, JsonProperty jsonProperty_0, string string_0)
        {
            Interface16 interface2 = idictionary_0 as Interface16;
            object obj2 = (interface2 != null) ? interface2.Object_0 : idictionary_0;
            if (string_0 != null)
            {
                this.method_22(jsonReader_0, string_0, obj2);
            }
            this.method_27(jsonReader_0, jsonDictionaryContract_0, obj2);
            int num = jsonReader_0.Int32_0;
            if (jsonDictionaryContract_0.JsonContract_2 == null)
            {
                jsonDictionaryContract_0.JsonContract_2 = this.method_4(jsonDictionaryContract_0.DictionaryKeyType);
            }
            if (jsonDictionaryContract_0.JsonContract_0 == null)
            {
                jsonDictionaryContract_0.JsonContract_0 = this.method_4(jsonDictionaryContract_0.DictionaryValueType);
            }
            JsonConverter converter = jsonDictionaryContract_0.ItemConverter ?? this.method_12(jsonDictionaryContract_0.JsonContract_0, null, jsonDictionaryContract_0, jsonProperty_0);
            Enum17 enum2 = (jsonDictionaryContract_0.JsonContract_2 is JsonPrimitiveContract) ? ((JsonPrimitiveContract) jsonDictionaryContract_0.JsonContract_2).Enum17_0 : Enum17.Empty;
            bool flag = false;
            do
            {
                JsonToken token = jsonReader_0.JsonToken_0;
                switch (token)
                {
                    case JsonToken.PropertyName:
                    {
                        object obj3 = jsonReader_0.Object_0;
                        try
                        {
                            object obj5;
                            try
                            {
                                object obj4;
                                if (((enum2 == Enum17.DateTime) || (enum2 == Enum17.DateTimeNullable)) && Class184.smethod_13(obj3.ToString(), DateParseHandling.DateTime, jsonReader_0.DateTimeZoneHandling, out obj4))
                                {
                                    obj3 = obj4;
                                }
                                else if (((enum2 == Enum17.DateTimeOffset) || (enum2 == Enum17.DateTimeOffsetNullable)) && Class184.smethod_13(obj3.ToString(), DateParseHandling.DateTimeOffset, jsonReader_0.DateTimeZoneHandling, out obj4))
                                {
                                    obj3 = obj4;
                                }
                                else
                                {
                                    obj3 = this.method_19(jsonReader_0, obj3, CultureInfo.InvariantCulture, jsonDictionaryContract_0.JsonContract_2, jsonDictionaryContract_0.DictionaryKeyType);
                                }
                            }
                            catch (Exception exception)
                            {
                                throw JsonSerializationException.smethod_2(jsonReader_0, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".smethod_1(CultureInfo.InvariantCulture, jsonReader_0.Object_0, jsonDictionaryContract_0.DictionaryKeyType), exception);
                            }
                            if (!this.method_38(jsonReader_0, jsonDictionaryContract_0.JsonContract_0, converter != null))
                            {
                                throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when deserializing object.");
                            }
                            if ((converter != null) && converter.CanRead)
                            {
                                obj5 = this.method_36(converter, jsonReader_0, jsonDictionaryContract_0.DictionaryValueType, null);
                            }
                            else
                            {
                                obj5 = this.method_10(jsonReader_0, jsonDictionaryContract_0.DictionaryValueType, jsonDictionaryContract_0.JsonContract_0, null, jsonDictionaryContract_0, jsonProperty_0, null);
                            }
                            idictionary_0[obj3] = obj5;
                        }
                        catch (Exception exception2)
                        {
                            if (!base.method_2(obj2, jsonDictionaryContract_0, obj3, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception2))
                            {
                                throw;
                            }
                            this.method_44(jsonReader_0, true, num);
                        }
                        break;
                    }
                    case JsonToken.Comment:
                        break;

                    default:
                        if (token != JsonToken.EndObject)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.JsonToken_0);
                        }
                        flag = true;
                        break;
                }
            }
            while (!flag && jsonReader_0.Read());
            if (!flag)
            {
                this.method_31(jsonReader_0, jsonDictionaryContract_0, obj2, "Unexpected end when deserializing object.");
            }
            this.method_28(jsonReader_0, jsonDictionaryContract_0, obj2);
            return obj2;
        }

        public void method_3(JsonReader jsonReader_0, object object_0)
        {
            Class203.smethod_2(object_0, "target");
            Type type = object_0.GetType();
            JsonContract contract = base.jsonSerializer_0.icontractResolver_0.ResolveContract(type);
            if (jsonReader_0.JsonToken_0 == JsonToken.None)
            {
                jsonReader_0.Read();
            }
            if (jsonReader_0.JsonToken_0 == JsonToken.StartArray)
            {
                if (contract.enum15_0 != Enum15.Array)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot populate JSON array onto type '{0}'.".smethod_0(CultureInfo.InvariantCulture, type));
                }
                JsonArrayContract contract2 = (JsonArrayContract) contract;
                this.method_32(contract2.Boolean_0 ? contract2.method_5(object_0) : ((IList) object_0), jsonReader_0, contract2, null, null);
            }
            else
            {
                if (jsonReader_0.JsonToken_0 != JsonToken.StartObject)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".smethod_0(CultureInfo.InvariantCulture, jsonReader_0.JsonToken_0));
                }
                this.method_16(jsonReader_0);
                string str = null;
                if ((jsonReader_0.JsonToken_0 == JsonToken.PropertyName) && string.Equals(jsonReader_0.Object_0.ToString(), "$id", StringComparison.Ordinal))
                {
                    this.method_16(jsonReader_0);
                    str = (jsonReader_0.Object_0 != null) ? jsonReader_0.Object_0.ToString() : null;
                    this.method_16(jsonReader_0);
                }
                if (contract.enum15_0 == Enum15.Dictionary)
                {
                    JsonDictionaryContract contract3 = (JsonDictionaryContract) contract;
                    this.method_29(contract3.Boolean_0 ? contract3.method_5(object_0) : ((IDictionary) object_0), jsonReader_0, contract3, null, str);
                }
                else
                {
                    if (contract.enum15_0 != Enum15.Object)
                    {
                        throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot populate JSON object onto type '{0}'.".smethod_0(CultureInfo.InvariantCulture, type));
                    }
                    this.method_40(object_0, jsonReader_0, (JsonObjectContract) contract, null, str);
                }
            }
        }

        private object method_30(IList ilist_0, JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, string string_0)
        {
            int num2;
            int arrayRank = jsonArrayContract_0.UnderlyingType.GetArrayRank();
            if (string_0 != null)
            {
                this.method_22(jsonReader_0, string_0, ilist_0);
            }
            this.method_27(jsonReader_0, jsonArrayContract_0, ilist_0);
            JsonContract contract = this.method_4(jsonArrayContract_0.CollectionItemType);
            JsonConverter converter = this.method_12(contract, null, jsonArrayContract_0, jsonProperty_0);
            int? nullable = null;
            Stack<IList> stack = new Stack<IList>();
            stack.Push(ilist_0);
            IList list = ilist_0;
            bool flag = false;
        Label_0059:
            num2 = jsonReader_0.Int32_0;
            if (stack.Count != arrayRank)
            {
                if (!jsonReader_0.Read())
                {
                    goto Label_0214;
                }
                JsonToken token2 = jsonReader_0.JsonToken_0;
                switch (token2)
                {
                    case JsonToken.StartArray:
                    {
                        IList list2 = new List<object>();
                        list.Add(list2);
                        stack.Push(list2);
                        list = list2;
                        goto Label_01EF;
                    }
                    case JsonToken.Comment:
                        goto Label_01EF;
                }
                if (token2 != JsonToken.EndArray)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing multidimensional array: " + jsonReader_0.JsonToken_0);
                }
                stack.Pop();
                if (stack.Count > 0)
                {
                    list = stack.Peek();
                }
                else
                {
                    flag = true;
                }
            }
            else
            {
                try
                {
                    object obj2;
                    if (!this.method_38(jsonReader_0, contract, converter != null))
                    {
                        goto Label_0214;
                    }
                    switch (jsonReader_0.JsonToken_0)
                    {
                        case JsonToken.Comment:
                            goto Label_01EF;

                        case JsonToken.EndArray:
                            stack.Pop();
                            list = stack.Peek();
                            nullable = null;
                            goto Label_01EF;
                    }
                    if ((converter != null) && converter.CanRead)
                    {
                        obj2 = this.method_36(converter, jsonReader_0, jsonArrayContract_0.CollectionItemType, null);
                    }
                    else
                    {
                        obj2 = this.method_10(jsonReader_0, jsonArrayContract_0.CollectionItemType, contract, null, jsonArrayContract_0, jsonProperty_0, null);
                    }
                    list.Add(obj2);
                }
                catch (Exception exception)
                {
                    Struct25 struct2 = jsonReader_0.method_0(num2);
                    if (!base.method_2(ilist_0, jsonArrayContract_0, struct2.int_0, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                    {
                        throw;
                    }
                    this.method_44(jsonReader_0, true, num2);
                    if (nullable.HasValue)
                    {
                        int? nullable2 = nullable;
                        int num3 = struct2.int_0;
                        if ((nullable2.GetValueOrDefault() == num3) && nullable2.HasValue)
                        {
                            throw JsonSerializationException.smethod_2(jsonReader_0, "Infinite loop detected from error handling.", exception);
                        }
                    }
                    nullable = new int?(struct2.int_0);
                }
            }
        Label_01EF:
            if (!flag)
            {
                goto Label_0059;
            }
        Label_0214:
            if (!flag)
            {
                this.method_31(jsonReader_0, jsonArrayContract_0, ilist_0, "Unexpected end when deserializing array.");
            }
            this.method_28(jsonReader_0, jsonArrayContract_0, ilist_0);
            return ilist_0;
        }

        private void method_31(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0, string string_0)
        {
            try
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, string_0);
            }
            catch (Exception exception)
            {
                if (!base.method_2(object_0, jsonContract_0, null, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                {
                    throw;
                }
                this.method_44(jsonReader_0, false, 0);
            }
        }

        private object method_32(IList ilist_0, JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, string string_0)
        {
            Interface15 interface2 = ilist_0 as Interface15;
            object obj2 = (interface2 != null) ? interface2.Object_0 : ilist_0;
            if (string_0 != null)
            {
                this.method_22(jsonReader_0, string_0, obj2);
            }
            if (ilist_0.IsFixedSize)
            {
                jsonReader_0.Skip();
                return obj2;
            }
            this.method_27(jsonReader_0, jsonArrayContract_0, obj2);
            int num = jsonReader_0.Int32_0;
            JsonContract contract = this.method_4(jsonArrayContract_0.CollectionItemType);
            JsonConverter converter = this.method_12(contract, null, jsonArrayContract_0, jsonProperty_0);
            int? nullable = null;
            bool flag = false;
        Label_0067:
            try
            {
                object obj3;
                if (!this.method_38(jsonReader_0, contract, converter != null))
                {
                    goto Label_0166;
                }
                switch (jsonReader_0.JsonToken_0)
                {
                    case JsonToken.Comment:
                        goto Label_015F;

                    case JsonToken.EndArray:
                        flag = true;
                        goto Label_015F;
                }
                if ((converter != null) && converter.CanRead)
                {
                    obj3 = this.method_36(converter, jsonReader_0, jsonArrayContract_0.CollectionItemType, null);
                }
                else
                {
                    obj3 = this.method_10(jsonReader_0, jsonArrayContract_0.CollectionItemType, contract, null, jsonArrayContract_0, jsonProperty_0, null);
                }
                ilist_0.Add(obj3);
            }
            catch (Exception exception)
            {
                Struct25 struct2 = jsonReader_0.method_0(num);
                if (!base.method_2(obj2, jsonArrayContract_0, struct2.int_0, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                {
                    throw;
                }
                this.method_44(jsonReader_0, true, num);
                if (nullable.HasValue)
                {
                    int? nullable2 = nullable;
                    int num2 = struct2.int_0;
                    if ((nullable2.GetValueOrDefault() == num2) && nullable2.HasValue)
                    {
                        throw JsonSerializationException.smethod_2(jsonReader_0, "Infinite loop detected from error handling.", exception);
                    }
                }
                nullable = new int?(struct2.int_0);
            }
        Label_015F:
            if (!flag)
            {
                goto Label_0067;
            }
        Label_0166:
            if (!flag)
            {
                this.method_31(jsonReader_0, jsonArrayContract_0, obj2, "Unexpected end when deserializing array.");
            }
            this.method_28(jsonReader_0, jsonArrayContract_0, obj2);
            return obj2;
        }

        private object method_33(JsonReader jsonReader_0, JsonISerializableContract jsonISerializableContract_0, JsonProperty jsonProperty_0, string string_0)
        {
            JsonToken token;
            Type underlyingType = jsonISerializableContract_0.UnderlyingType;
            if (!Class139.Boolean_1)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data.\r\nTo fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true.\r\n".smethod_0(CultureInfo.InvariantCulture, underlyingType));
            }
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Deserializing {0} using ISerializable constructor.".smethod_0(CultureInfo.InvariantCulture, jsonISerializableContract_0.UnderlyingType)), null);
            }
            SerializationInfo info = new SerializationInfo(jsonISerializableContract_0.UnderlyingType, this.method_7());
            bool flag = false;
            goto Label_00E9;
        Label_0084:
            if (flag || !jsonReader_0.Read())
            {
                if (!flag)
                {
                    this.method_31(jsonReader_0, jsonISerializableContract_0, info, "Unexpected end when deserializing object.");
                }
                if (jsonISerializableContract_0.ISerializableCreator == null)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".smethod_0(CultureInfo.InvariantCulture, underlyingType));
                }
                object obj3 = jsonISerializableContract_0.ISerializableCreator(new object[] { info, base.jsonSerializer_0.streamingContext_0 });
                if (string_0 != null)
                {
                    this.method_22(jsonReader_0, string_0, obj3);
                }
                this.method_27(jsonReader_0, jsonISerializableContract_0, obj3);
                this.method_28(jsonReader_0, jsonISerializableContract_0, obj3);
                return obj3;
            }
        Label_00E9:
            switch (jsonReader_0.JsonToken_0)
            {
                case JsonToken.PropertyName:
                {
                    string str = jsonReader_0.Object_0.ToString();
                    if (!jsonReader_0.Read())
                    {
                        throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, str));
                    }
                    if (jsonReader_0.JsonToken_0 == JsonToken.StartObject)
                    {
                        object obj2 = this.method_13(jsonReader_0, null, null, null, jsonISerializableContract_0, jsonProperty_0, null);
                        info.AddValue(str, obj2);
                    }
                    else
                    {
                        info.AddValue(str, JToken.ReadFrom(jsonReader_0));
                    }
                    goto Label_0084;
                }
                case JsonToken.Comment:
                    goto Label_0084;
            }
            if (token != JsonToken.EndObject)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.JsonToken_0);
            }
            flag = true;
            goto Label_0084;
        }

        private object method_34(JsonReader jsonReader_0, JsonDynamicContract jsonDynamicContract_0, JsonProperty jsonProperty_0, string string_0)
        {
            JsonToken token;
            if (!jsonDynamicContract_0.bool_5)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonDynamicContract_0.UnderlyingType));
            }
            if ((jsonDynamicContract_0.DefaultCreator == null) || (jsonDynamicContract_0.DefaultCreatorNonPublic && (base.jsonSerializer_0.constructorHandling_0 != ConstructorHandling.AllowNonPublicDefaultConstructor)))
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unable to find a default constructor to use for type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonDynamicContract_0.UnderlyingType));
            }
            IDynamicMetaObjectProvider provider = (IDynamicMetaObjectProvider) jsonDynamicContract_0.DefaultCreator();
            if (string_0 != null)
            {
                this.method_22(jsonReader_0, string_0, provider);
            }
            this.method_27(jsonReader_0, jsonDynamicContract_0, provider);
            int num = jsonReader_0.Int32_0;
            bool flag = false;
        Label_0079:
            token = jsonReader_0.JsonToken_0;
            if (token != JsonToken.PropertyName)
            {
                goto Label_01CF;
            }
            string str = jsonReader_0.Object_0.ToString();
            try
            {
                if (!jsonReader_0.Read())
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, str));
                }
                JsonProperty closestMatchProperty = jsonDynamicContract_0.Properties.GetClosestMatchProperty(str);
                if (((closestMatchProperty != null) && closestMatchProperty.Writable) && !closestMatchProperty.Ignored)
                {
                    if (closestMatchProperty.JsonContract_0 == null)
                    {
                        closestMatchProperty.JsonContract_0 = this.method_4(closestMatchProperty.PropertyType);
                    }
                    JsonConverter converter = this.method_12(closestMatchProperty.JsonContract_0, closestMatchProperty.MemberConverter, null, null);
                    if (!this.method_20(closestMatchProperty, converter, null, jsonProperty_0, jsonReader_0, provider))
                    {
                        jsonReader_0.Skip();
                    }
                }
                else
                {
                    object obj2;
                    Type type = JsonReader.smethod_0(jsonReader_0.JsonToken_0) ? jsonReader_0.Type_0 : typeof(IDynamicMetaObjectProvider);
                    JsonContract contract = this.method_4(type);
                    JsonConverter converter2 = this.method_12(contract, null, null, jsonProperty_0);
                    if ((converter2 != null) && converter2.CanRead)
                    {
                        obj2 = this.method_36(converter2, jsonReader_0, type, null);
                    }
                    else
                    {
                        obj2 = this.method_10(jsonReader_0, type, contract, null, null, jsonProperty_0, null);
                    }
                    jsonDynamicContract_0.method_6(provider, str, obj2);
                }
            }
            catch (Exception exception)
            {
                if (!base.method_2(provider, jsonDynamicContract_0, str, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                {
                    throw;
                }
                this.method_44(jsonReader_0, true, num);
            }
            while (!flag)
            {
                if (jsonReader_0.Read())
                {
                    goto Label_0079;
                }
                break;
            Label_01CF:
                if (token != JsonToken.EndObject)
                {
                    throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.JsonToken_0);
                }
                flag = true;
            }
            if (!flag)
            {
                this.method_31(jsonReader_0, jsonDynamicContract_0, provider, "Unexpected end when deserializing object.");
            }
            this.method_28(jsonReader_0, jsonDynamicContract_0, provider);
            return provider;
        }

        private object method_35(JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, ConstructorInfo constructorInfo_0, string string_0)
        {
            Class203.smethod_2(constructorInfo_0, "constructorInfo");
            Type underlyingType = jsonObjectContract_0.UnderlyingType;
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Deserializing {0} using a non-default constructor '{1}'.".smethod_1(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType, constructorInfo_0)), null);
            }
            IDictionary<JsonProperty, object> dictionary = this.method_37(jsonObjectContract_0, jsonProperty_0, jsonReader_0, underlyingType);
            if (func_0 == null)
            {
                func_0 = new Func<ParameterInfo, ParameterInfo>(Class136.smethod_0);
            }
            if (func_1 == null)
            {
                func_1 = new Func<ParameterInfo, object>(Class136.smethod_1);
            }
            IDictionary<ParameterInfo, object> dictionary2 = constructorInfo_0.GetParameters().ToDictionary<ParameterInfo, ParameterInfo, object>(func_0, func_1);
            IDictionary<JsonProperty, object> dictionary3 = new Dictionary<JsonProperty, object>();
            foreach (KeyValuePair<JsonProperty, object> pair in dictionary)
            {
                if (func_2 == null)
                {
                    func_2 = new Func<KeyValuePair<ParameterInfo, object>, string>(Class136.smethod_2);
                }
                ParameterInfo key = dictionary2.smethod_9<KeyValuePair<ParameterInfo, object>>(func_2, pair.Key.UnderlyingName).Key;
                if (key != null)
                {
                    dictionary2[key] = pair.Value;
                }
                else
                {
                    dictionary3.Add(pair);
                }
            }
            object obj2 = constructorInfo_0.Invoke(dictionary2.Values.ToArray<object>());
            if (string_0 != null)
            {
                this.method_22(jsonReader_0, string_0, obj2);
            }
            this.method_27(jsonReader_0, jsonObjectContract_0, obj2);
            foreach (KeyValuePair<JsonProperty, object> pair2 in dictionary3)
            {
                JsonProperty property = pair2.Key;
                object obj3 = pair2.Value;
                if (this.method_24(pair2.Key, pair2.Value))
                {
                    property.ValueProvider.SetValue(obj2, obj3);
                }
                else if (!property.Writable && (obj3 != null))
                {
                    JsonContract contract = base.jsonSerializer_0.icontractResolver_0.ResolveContract(property.PropertyType);
                    if (contract.enum15_0 == Enum15.Array)
                    {
                        JsonArrayContract contract2 = (JsonArrayContract) contract;
                        object obj4 = property.ValueProvider.GetValue(obj2);
                        if (obj4 != null)
                        {
                            Interface15 interface2 = contract2.method_5(obj4);
                            foreach (object obj5 in contract2.method_5(obj3))
                            {
                                interface2.Add(obj5);
                            }
                        }
                    }
                    else if (contract.enum15_0 == Enum15.Dictionary)
                    {
                        JsonDictionaryContract contract3 = (JsonDictionaryContract) contract;
                        object obj6 = property.ValueProvider.GetValue(obj2);
                        if (obj6 != null)
                        {
                            IDictionary dictionary4 = contract3.Boolean_0 ? contract3.method_5(obj6) : ((IDictionary) obj6);
                            IDictionary dictionary5 = contract3.Boolean_0 ? contract3.method_5(obj3) : ((IDictionary) obj3);
                            foreach (DictionaryEntry entry in dictionary5)
                            {
                                dictionary4.Add(entry.Key, entry.Value);
                            }
                        }
                    }
                }
            }
            this.method_28(jsonReader_0, jsonObjectContract_0, obj2);
            return obj2;
        }

        private object method_36(JsonConverter jsonConverter_0, JsonReader jsonReader_0, Type type_0, object object_0)
        {
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Started deserializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, type_0, jsonConverter_0.GetType())), null);
            }
            object obj2 = jsonConverter_0.ReadJson(jsonReader_0, type_0, object_0, this.method_6());
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Finished deserializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, type_0, jsonConverter_0.GetType())), null);
            }
            return obj2;
        }

        private IDictionary<JsonProperty, object> method_37(JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonReader jsonReader_0, Type type_0)
        {
            JsonToken token;
            IDictionary<JsonProperty, object> dictionary = new Dictionary<JsonProperty, object>();
            bool flag = false;
            goto Label_0190;
        Label_000D:
            if (flag || !jsonReader_0.Read())
            {
                return dictionary;
            }
        Label_0190:
            switch (jsonReader_0.JsonToken_0)
            {
                case JsonToken.PropertyName:
                {
                    string propertyName = jsonReader_0.Object_0.ToString();
                    JsonProperty property = jsonObjectContract_0.ConstructorParameters.GetClosestMatchProperty(propertyName) ?? jsonObjectContract_0.Properties.GetClosestMatchProperty(propertyName);
                    if (property != null)
                    {
                        if (property.JsonContract_0 == null)
                        {
                            property.JsonContract_0 = this.method_4(property.PropertyType);
                        }
                        JsonConverter converter = this.method_12(property.JsonContract_0, property.MemberConverter, jsonObjectContract_0, jsonProperty_0);
                        if (!this.method_38(jsonReader_0, property.JsonContract_0, converter != null))
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, propertyName));
                        }
                        if (!property.Ignored)
                        {
                            object obj2;
                            if (property.JsonContract_0 == null)
                            {
                                property.JsonContract_0 = this.method_4(property.PropertyType);
                            }
                            if ((converter != null) && converter.CanRead)
                            {
                                obj2 = this.method_36(converter, jsonReader_0, property.PropertyType, null);
                            }
                            else
                            {
                                obj2 = this.method_10(jsonReader_0, property.PropertyType, property.JsonContract_0, property, jsonObjectContract_0, jsonProperty_0, null);
                            }
                            dictionary[property] = obj2;
                        }
                        else
                        {
                            jsonReader_0.Skip();
                        }
                    }
                    else
                    {
                        if (!jsonReader_0.Read())
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, propertyName));
                        }
                        if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                        {
                            base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Could not find member '{0}' on {1}.".smethod_1(CultureInfo.InvariantCulture, propertyName, jsonObjectContract_0.UnderlyingType)), null);
                        }
                        if (base.jsonSerializer_0.missingMemberHandling_0 == MissingMemberHandling.Error)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Could not find member '{0}' on object of type '{1}'".smethod_1(CultureInfo.InvariantCulture, propertyName, type_0.Name));
                        }
                        jsonReader_0.Skip();
                    }
                    goto Label_000D;
                }
                case JsonToken.Comment:
                    goto Label_000D;
            }
            if (token != JsonToken.EndObject)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.JsonToken_0);
            }
            flag = true;
            goto Label_000D;
        }

        private bool method_38(JsonReader jsonReader_0, JsonContract jsonContract_0, bool bool_1)
        {
            if (bool_1)
            {
                return jsonReader_0.Read();
            }
            switch (((jsonContract_0 != null) ? jsonContract_0.enum14_0 : Enum14.Read))
            {
                case Enum14.Read:
                    while (jsonReader_0.Read())
                    {
                        if (jsonReader_0.JsonToken_0 != JsonToken.Comment)
                        {
                            return true;
                        }
                    }
                    return false;

                case Enum14.ReadAsInt32:
                    jsonReader_0.ReadAsInt32();
                    break;

                case Enum14.ReadAsBytes:
                    jsonReader_0.ReadAsBytes();
                    break;

                case Enum14.ReadAsString:
                    jsonReader_0.ReadAsString();
                    break;

                case Enum14.ReadAsDecimal:
                    jsonReader_0.ReadAsDecimal();
                    break;

                case Enum14.ReadAsDateTime:
                    jsonReader_0.ReadAsDateTime();
                    break;

                case Enum14.ReadAsDateTimeOffset:
                    jsonReader_0.ReadAsDateTimeOffset();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            return (jsonReader_0.JsonToken_0 != JsonToken.None);
        }

        public object method_39(JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonProperty jsonProperty_1, string string_0, out bool bool_1)
        {
            object obj2 = null;
            if (!jsonObjectContract_0.bool_5)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType));
            }
            if (jsonObjectContract_0.OverrideConstructor != null)
            {
                if (jsonObjectContract_0.OverrideConstructor.GetParameters().Length > 0)
                {
                    bool_1 = true;
                    return this.method_35(jsonReader_0, jsonObjectContract_0, jsonProperty_0, jsonObjectContract_0.OverrideConstructor, string_0);
                }
                obj2 = jsonObjectContract_0.OverrideConstructor.Invoke(null);
            }
            else if ((jsonObjectContract_0.DefaultCreator != null) && ((!jsonObjectContract_0.DefaultCreatorNonPublic || (base.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor)) || (jsonObjectContract_0.ParametrizedConstructor == null)))
            {
                obj2 = jsonObjectContract_0.DefaultCreator();
            }
            else if (jsonObjectContract_0.ParametrizedConstructor != null)
            {
                bool_1 = true;
                return this.method_35(jsonReader_0, jsonObjectContract_0, jsonProperty_0, jsonObjectContract_0.ParametrizedConstructor, string_0);
            }
            if (obj2 == null)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".smethod_0(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType));
            }
            bool_1 = false;
            return obj2;
        }

        private JsonContract method_4(Type type_0)
        {
            if (type_0 == null)
            {
                return null;
            }
            return base.jsonSerializer_0.icontractResolver_0.ResolveContract(type_0);
        }

        private object method_40(object object_0, JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, string string_0)
        {
            this.method_27(jsonReader_0, jsonObjectContract_0, object_0);
            if (func_3 == null)
            {
                func_3 = new Func<JsonProperty, JsonProperty>(Class136.smethod_3);
            }
            if (func_4 == null)
            {
                func_4 = new Func<JsonProperty, Enum16>(Class136.smethod_4);
            }
            Dictionary<JsonProperty, Enum16> dictionary = (jsonObjectContract_0.Boolean_0 || this.method_23(base.jsonSerializer_0.defaultValueHandling_0, DefaultValueHandling.Populate)) ? jsonObjectContract_0.Properties.ToDictionary<JsonProperty, JsonProperty, Enum16>(func_3, func_4) : null;
            if (string_0 != null)
            {
                this.method_22(jsonReader_0, string_0, object_0);
            }
            int num = jsonReader_0.Int32_0;
            bool flag = false;
            do
            {
                JsonToken token = jsonReader_0.JsonToken_0;
                switch (token)
                {
                    case JsonToken.PropertyName:
                    {
                        string propertyName = jsonReader_0.Object_0.ToString();
                        try
                        {
                            JsonProperty closestMatchProperty = jsonObjectContract_0.Properties.GetClosestMatchProperty(propertyName);
                            if (closestMatchProperty == null)
                            {
                                if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                                {
                                    base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, "Could not find member '{0}' on {1}".smethod_1(CultureInfo.InvariantCulture, propertyName, jsonObjectContract_0.UnderlyingType)), null);
                                }
                                if (base.jsonSerializer_0.missingMemberHandling_0 == MissingMemberHandling.Error)
                                {
                                    throw JsonSerializationException.smethod_1(jsonReader_0, "Could not find member '{0}' on object of type '{1}'".smethod_1(CultureInfo.InvariantCulture, propertyName, jsonObjectContract_0.UnderlyingType.Name));
                                }
                                if (jsonReader_0.Read())
                                {
                                    this.method_41(jsonObjectContract_0, jsonReader_0, propertyName, object_0);
                                }
                            }
                            else
                            {
                                if (closestMatchProperty.JsonContract_0 == null)
                                {
                                    closestMatchProperty.JsonContract_0 = this.method_4(closestMatchProperty.PropertyType);
                                }
                                JsonConverter converter = this.method_12(closestMatchProperty.JsonContract_0, closestMatchProperty.MemberConverter, jsonObjectContract_0, jsonProperty_0);
                                if (!this.method_38(jsonReader_0, closestMatchProperty.JsonContract_0, converter != null))
                                {
                                    throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, propertyName));
                                }
                                this.method_43(jsonReader_0, closestMatchProperty, dictionary);
                                if (!this.method_20(closestMatchProperty, converter, jsonObjectContract_0, jsonProperty_0, jsonReader_0, object_0))
                                {
                                    this.method_41(jsonObjectContract_0, jsonReader_0, propertyName, object_0);
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            if (!base.method_2(object_0, jsonObjectContract_0, propertyName, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                            {
                                throw;
                            }
                            this.method_44(jsonReader_0, true, num);
                        }
                        break;
                    }
                    case JsonToken.Comment:
                        break;

                    default:
                        if (token != JsonToken.EndObject)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.JsonToken_0);
                        }
                        flag = true;
                        break;
                }
            }
            while (!flag && jsonReader_0.Read());
            if (!flag)
            {
                this.method_31(jsonReader_0, jsonObjectContract_0, object_0, "Unexpected end when deserializing object.");
            }
            this.method_42(object_0, jsonReader_0, jsonObjectContract_0, num, dictionary);
            this.method_28(jsonReader_0, jsonObjectContract_0, object_0);
            return object_0;
        }

        private void method_41(JsonObjectContract jsonObjectContract_0, JsonReader jsonReader_0, string string_0, object object_0)
        {
            if (jsonObjectContract_0.ExtensionDataSetter != null)
            {
                try
                {
                    JToken token = JToken.ReadFrom(jsonReader_0);
                    jsonObjectContract_0.ExtensionDataSetter(object_0, string_0, token);
                    return;
                }
                catch (Exception exception)
                {
                    throw JsonSerializationException.smethod_2(jsonReader_0, "Error setting value in extension data for type '{0}'.".smethod_0(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType), exception);
                }
            }
            jsonReader_0.Skip();
        }

        private void method_42(object object_0, JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, int int_0, Dictionary<JsonProperty, Enum16> dictionary_0)
        {
            if (dictionary_0 != null)
            {
                foreach (KeyValuePair<JsonProperty, Enum16> pair in dictionary_0)
                {
                    JsonProperty key = pair.Key;
                    Enum16 enum2 = pair.Value;
                    switch (enum2)
                    {
                        case Enum16.None:
                        case Enum16.Null:
                            try
                            {
                                Required? itemRequired;
                                Required? nullable = key.nullable_0;
                                if (!nullable.HasValue)
                                {
                                    itemRequired = jsonObjectContract_0.ItemRequired;
                                }
                                Required required = itemRequired.HasValue ? nullable.GetValueOrDefault() : Required.Default;
                                switch (enum2)
                                {
                                    case Enum16.None:
                                    {
                                        switch (required)
                                        {
                                            case Required.AllowNull:
                                            case Required.Always:
                                                throw JsonSerializationException.smethod_1(jsonReader_0, "Required property '{0}' not found in JSON.".smethod_0(CultureInfo.InvariantCulture, key.PropertyName));
                                        }
                                        if (key.JsonContract_0 == null)
                                        {
                                            key.JsonContract_0 = this.method_4(key.PropertyType);
                                        }
                                        if (this.method_23(key.DefaultValueHandling.GetValueOrDefault(base.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate) && key.Writable)
                                        {
                                            key.ValueProvider.SetValue(object_0, this.method_19(jsonReader_0, key.method_1(), CultureInfo.InvariantCulture, key.JsonContract_0, key.PropertyType));
                                        }
                                        continue;
                                    }
                                    case Enum16.Null:
                                    {
                                        if (required == Required.Always)
                                        {
                                            throw JsonSerializationException.smethod_1(jsonReader_0, "Required property '{0}' expects a value but got null.".smethod_0(CultureInfo.InvariantCulture, key.PropertyName));
                                        }
                                        continue;
                                    }
                                }
                            }
                            catch (Exception exception)
                            {
                                if (!base.method_2(object_0, jsonObjectContract_0, key.PropertyName, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                                {
                                    throw;
                                }
                                this.method_44(jsonReader_0, true, int_0);
                            }
                            break;
                    }
                }
            }
        }

        private void method_43(JsonReader jsonReader_0, JsonProperty jsonProperty_0, Dictionary<JsonProperty, Enum16> dictionary_0)
        {
            if ((jsonProperty_0 != null) && (dictionary_0 != null))
            {
                dictionary_0[jsonProperty_0] = ((jsonReader_0.JsonToken_0 == JsonToken.Null) || (jsonReader_0.JsonToken_0 == JsonToken.Undefined)) ? Enum16.Null : Enum16.Value;
            }
        }

        private void method_44(JsonReader jsonReader_0, bool bool_1, int int_0)
        {
            base.method_1();
            if (bool_1)
            {
                jsonReader_0.Skip();
                while (jsonReader_0.Int32_0 > (int_0 + 1))
                {
                    if (!jsonReader_0.Read())
                    {
                        return;
                    }
                }
            }
        }

        public object method_5(JsonReader jsonReader_0, Type type_0, bool bool_1)
        {
            if (jsonReader_0 == null)
            {
                throw new ArgumentNullException("reader");
            }
            JsonContract contract = this.method_4(type_0);
            try
            {
                object obj2;
                JsonConverter converter = this.method_12(contract, null, null, null);
                if ((jsonReader_0.JsonToken_0 == JsonToken.None) && !this.method_38(jsonReader_0, contract, converter != null))
                {
                    if ((contract != null) && !contract.bool_0)
                    {
                        throw JsonSerializationException.smethod_1(jsonReader_0, "No JSON content found and type '{0}' is not nullable.".smethod_0(CultureInfo.InvariantCulture, contract.UnderlyingType));
                    }
                    return null;
                }
                if ((converter != null) && converter.CanRead)
                {
                    obj2 = this.method_36(converter, jsonReader_0, type_0, null);
                }
                else
                {
                    obj2 = this.method_10(jsonReader_0, type_0, contract, null, null, null, null);
                }
                if ((bool_1 && jsonReader_0.Read()) && (jsonReader_0.JsonToken_0 != JsonToken.Comment))
                {
                    throw new JsonSerializationException("Additional text found in JSON string after finishing deserializing object.");
                }
                return obj2;
            }
            catch (Exception exception)
            {
                if (!base.method_2(null, contract, null, jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, exception))
                {
                    throw;
                }
                this.method_44(jsonReader_0, false, 0);
                return null;
            }
        }

        private Class112 method_6()
        {
            if (this.class112_0 == null)
            {
                this.class112_0 = new Class112(this);
            }
            return this.class112_0;
        }

        private Class89 method_7()
        {
            if (this.class89_0 == null)
            {
                this.class89_0 = new Class89(this.method_6());
            }
            return this.class89_0;
        }

        private JToken method_8(JsonReader jsonReader_0, JsonContract jsonContract_0)
        {
            Class203.smethod_2(jsonReader_0, "reader");
            if ((jsonContract_0 != null) && (jsonContract_0.UnderlyingType == typeof(JRaw)))
            {
                return JRaw.Create(jsonReader_0);
            }
            using (JTokenWriter writer = new JTokenWriter())
            {
                writer.WriteToken(jsonReader_0);
                return writer.Token;
            }
        }

        private JToken method_9(JsonReader jsonReader_0)
        {
            Class203.smethod_2(jsonReader_0, "reader");
            using (JTokenWriter writer = new JTokenWriter())
            {
                writer.WriteStartObject();
                if (jsonReader_0.JsonToken_0 == JsonToken.PropertyName)
                {
                    writer.method_5(jsonReader_0, jsonReader_0.Int32_0 - 1, true, true);
                }
                else
                {
                    writer.WriteEndObject();
                }
                return writer.Token;
            }
        }

        [CompilerGenerated]
        private static ParameterInfo smethod_0(ParameterInfo parameterInfo_0)
        {
            return parameterInfo_0;
        }

        [CompilerGenerated]
        private static object smethod_1(ParameterInfo parameterInfo_0)
        {
            return null;
        }

        [CompilerGenerated]
        private static string smethod_2(KeyValuePair<ParameterInfo, object> keyValuePair_0)
        {
            return keyValuePair_0.Key.Name;
        }

        [CompilerGenerated]
        private static JsonProperty smethod_3(JsonProperty jsonProperty_0)
        {
            return jsonProperty_0;
        }

        [CompilerGenerated]
        private static Enum16 smethod_4(JsonProperty jsonProperty_0)
        {
            return Enum16.None;
        }

        internal enum Enum16
        {
            None,
            Null,
            Value
        }
    }
}

