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
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    using System.Security;

    internal class Class137 : Class135
    {
        private Class112 class112_0;
        private JsonContract jsonContract_0;
        private readonly List<object> list_0;

        public Class137(JsonSerializer serializer) : base(serializer)
        {
            this.list_0 = new List<object>();
        }

        private bool method_10(object object_0, JsonProperty jsonProperty_0)
        {
            if ((((NullValueHandling) jsonProperty_0.NullValueHandling.GetValueOrDefault(base.jsonSerializer_0.nullValueHandling_0)) == NullValueHandling.Ignore) && (object_0 == null))
            {
                return false;
            }
            if (this.method_22(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(base.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Ignore) && Class193.smethod_0(object_0, jsonProperty_0.method_1()))
            {
                return false;
            }
            return true;
        }

        private bool method_11(JsonWriter jsonWriter_0, object object_0, JsonProperty jsonProperty_0, JsonContract jsonContract_1, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            if (((object_0 != null) && (jsonContract_1.enum15_0 != Enum15.Primitive)) && (jsonContract_1.enum15_0 != Enum15.String))
            {
                ReferenceLoopHandling? referenceLoopHandling = null;
                if (jsonProperty_0 != null)
                {
                    referenceLoopHandling = jsonProperty_0.ReferenceLoopHandling;
                }
                if (!referenceLoopHandling.HasValue && (jsonProperty_1 != null))
                {
                    referenceLoopHandling = jsonProperty_1.ItemReferenceLoopHandling;
                }
                if (!referenceLoopHandling.HasValue && (jsonContainerContract_0 != null))
                {
                    referenceLoopHandling = jsonContainerContract_0.ItemReferenceLoopHandling;
                }
                if (this.list_0.IndexOf(object_0) != -1)
                {
                    string str = "Self referencing loop detected";
                    if (jsonProperty_0 != null)
                    {
                        str = str + " for property '{0}'".smethod_0(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName);
                    }
                    str = str + " with type '{0}'.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType());
                    switch (referenceLoopHandling.GetValueOrDefault(base.jsonSerializer_0.referenceLoopHandling_0))
                    {
                        case ReferenceLoopHandling.Error:
                            throw JsonSerializationException.smethod_3(null, jsonWriter_0.String_0, str, null);

                        case ReferenceLoopHandling.Ignore:
                            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                            {
                                base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(null, jsonWriter_0.Path, str + ". Skipping serializing self referenced value."), null);
                            }
                            return false;

                        case ReferenceLoopHandling.Serialize:
                            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
                            {
                                base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(null, jsonWriter_0.Path, str + ". Serializing self referenced value."), null);
                            }
                            return true;
                    }
                }
            }
            return true;
        }

        private void method_12(JsonWriter jsonWriter_0, object object_0)
        {
            string str = this.method_13(jsonWriter_0, object_0);
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(null, jsonWriter_0.Path, "Writing object reference to Id '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, str, object_0.GetType())), null);
            }
            jsonWriter_0.WriteStartObject();
            jsonWriter_0.WritePropertyName("$ref", false);
            jsonWriter_0.WriteValue(str);
            jsonWriter_0.WriteEndObject();
        }

        private string method_13(JsonWriter jsonWriter_0, object object_0)
        {
            string reference;
            try
            {
                reference = base.jsonSerializer_0.method_1().GetReference(this, object_0);
            }
            catch (Exception exception)
            {
                throw JsonSerializationException.smethod_3(null, jsonWriter_0.String_0, "Error writing object reference for '{0}'.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType()), exception);
            }
            return reference;
        }

        private void method_14(JsonWriter jsonWriter_0, object object_0, JsonStringContract jsonStringContract_0)
        {
            string str;
            this.method_15(jsonWriter_0, jsonStringContract_0, object_0);
            smethod_0(object_0, jsonStringContract_0.UnderlyingType, out str);
            jsonWriter_0.WriteValue(str);
            this.method_16(jsonWriter_0, jsonStringContract_0, object_0);
        }

        private void method_15(JsonWriter jsonWriter_0, JsonContract jsonContract_1, object object_0)
        {
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(null, jsonWriter_0.Path, "Started serializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_1.UnderlyingType)), null);
            }
            jsonContract_1.method_0(object_0, base.jsonSerializer_0.streamingContext_0);
        }

        private void method_16(JsonWriter jsonWriter_0, JsonContract jsonContract_1, object object_0)
        {
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
            {
                base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(null, jsonWriter_0.Path, "Finished serializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_1.UnderlyingType)), null);
            }
            jsonContract_1.method_1(object_0, base.jsonSerializer_0.streamingContext_0);
        }

        private void method_17(JsonWriter jsonWriter_0, object object_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            this.method_15(jsonWriter_0, jsonObjectContract_0, object_0);
            this.list_0.Add(object_0);
            this.method_19(jsonWriter_0, object_0, jsonObjectContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            int top = jsonWriter_0.Top;
            int num2 = 0;
            while (true)
            {
                if (num2 >= jsonObjectContract_0.Properties.Count)
                {
                    break;
                }
                JsonProperty property = jsonObjectContract_0.Properties[num2];
                try
                {
                    object obj2;
                    JsonContract contract;
                    if (this.method_18(jsonWriter_0, object_0, jsonObjectContract_0, jsonProperty_0, property, out contract, out obj2))
                    {
                        property.method_2(jsonWriter_0);
                        this.method_7(jsonWriter_0, obj2, contract, property, jsonObjectContract_0, jsonProperty_0);
                    }
                }
                catch (Exception exception)
                {
                    if (!base.method_2(object_0, jsonObjectContract_0, property.PropertyName, null, jsonWriter_0.String_0, exception))
                    {
                        throw;
                    }
                    this.method_36(jsonWriter_0, top);
                }
                num2++;
            }
            jsonWriter_0.WriteEndObject();
            this.list_0.RemoveAt(this.list_0.Count - 1);
            this.method_16(jsonWriter_0, jsonObjectContract_0, object_0);
        }

        private bool method_18(JsonWriter jsonWriter_0, object object_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0, JsonProperty jsonProperty_1, out JsonContract jsonContract_1, out object object_1)
        {
            if ((!jsonProperty_1.Ignored && jsonProperty_1.Readable) && (this.method_37(jsonWriter_0, jsonProperty_1, object_0) && this.method_38(jsonWriter_0, jsonProperty_1, object_0)))
            {
                if (jsonProperty_1.JsonContract_0 == null)
                {
                    jsonProperty_1.JsonContract_0 = base.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonProperty_1.PropertyType);
                }
                object_1 = jsonProperty_1.ValueProvider.GetValue(object_0);
                jsonContract_1 = jsonProperty_1.JsonContract_0.bool_2 ? jsonProperty_1.JsonContract_0 : this.method_5(object_1);
                if (this.method_10(object_1, jsonProperty_1))
                {
                    if (this.method_9(object_1, jsonProperty_1, jsonContract_1, jsonContainerContract_0, jsonProperty_0))
                    {
                        jsonProperty_1.method_2(jsonWriter_0);
                        this.method_12(jsonWriter_0, object_1);
                        return false;
                    }
                    if (!this.method_11(jsonWriter_0, object_1, jsonProperty_1, jsonContract_1, jsonContainerContract_0, jsonProperty_0))
                    {
                        return false;
                    }
                    if (object_1 == null)
                    {
                        Required? nullable3;
                        JsonObjectContract contract = jsonContainerContract_0 as JsonObjectContract;
                        Required? nullable = jsonProperty_1.nullable_0;
                        if (!nullable.HasValue)
                        {
                            nullable3 = (contract != null) ? contract.ItemRequired : null;
                        }
                        Required required = nullable3.HasValue ? nullable.GetValueOrDefault() : Required.Default;
                        if (required == Required.Always)
                        {
                            throw JsonSerializationException.smethod_3(null, jsonWriter_0.String_0, "Cannot write a null value for property '{0}'. Property requires a value.".smethod_0(CultureInfo.InvariantCulture, jsonProperty_1.PropertyName), null);
                        }
                    }
                    return true;
                }
            }
            jsonContract_1 = null;
            object_1 = null;
            return false;
        }

        private void method_19(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_1, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            jsonWriter_0.WriteStartObject();
            bool? nullable = this.method_8(jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            if (nullable.HasValue ? nullable.GetValueOrDefault() : this.method_23(base.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Objects))
            {
                this.method_20(jsonWriter_0, jsonContract_1.UnderlyingType, object_0);
            }
            if (this.method_33(TypeNameHandling.Objects, jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1))
            {
                this.method_21(jsonWriter_0, jsonContract_1.UnderlyingType);
            }
        }

        private void method_20(JsonWriter jsonWriter_0, Type type_0, object object_0)
        {
            string str = this.method_13(jsonWriter_0, object_0);
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
            {
                base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(null, jsonWriter_0.Path, "Writing object reference Id '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, str, type_0)), null);
            }
            jsonWriter_0.WritePropertyName("$id", false);
            jsonWriter_0.WriteValue(str);
        }

        private void method_21(JsonWriter jsonWriter_0, Type type_0)
        {
            string str = Class194.smethod_4(type_0, base.jsonSerializer_0.formatterAssemblyStyle_0, base.jsonSerializer_0.serializationBinder_0);
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
            {
                base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(null, jsonWriter_0.Path, "Writing type name '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, str, type_0)), null);
            }
            jsonWriter_0.WritePropertyName("$type", false);
            jsonWriter_0.WriteValue(str);
        }

        private bool method_22(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
        {
            return ((defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1);
        }

        private bool method_23(PreserveReferencesHandling preserveReferencesHandling_0, PreserveReferencesHandling preserveReferencesHandling_1)
        {
            return ((preserveReferencesHandling_0 & preserveReferencesHandling_1) == preserveReferencesHandling_1);
        }

        private bool method_24(TypeNameHandling typeNameHandling_0, TypeNameHandling typeNameHandling_1)
        {
            return ((typeNameHandling_0 & typeNameHandling_1) == typeNameHandling_1);
        }

        private void method_25(JsonWriter jsonWriter_0, JsonConverter jsonConverter_0, object object_0, JsonContract jsonContract_1, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0)
        {
            if (this.method_9(object_0, null, jsonContract_1, jsonContainerContract_0, jsonProperty_0))
            {
                this.method_12(jsonWriter_0, object_0);
            }
            else if (this.method_11(jsonWriter_0, object_0, null, jsonContract_1, jsonContainerContract_0, jsonProperty_0))
            {
                this.list_0.Add(object_0);
                if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
                {
                    base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(null, jsonWriter_0.Path, "Started serializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType(), jsonConverter_0.GetType())), null);
                }
                jsonConverter_0.WriteJson(jsonWriter_0, object_0, this.method_4());
                if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Info))
                {
                    base.itraceWriter_0.Trace(TraceLevel.Info, Struct25.smethod_2(null, jsonWriter_0.Path, "Finished serializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType(), jsonConverter_0.GetType())), null);
                }
                this.list_0.RemoveAt(this.list_0.Count - 1);
            }
        }

        private void method_26(JsonWriter jsonWriter_0, IEnumerable ienumerable_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            Interface15 interface2 = ienumerable_0 as Interface15;
            object obj2 = (interface2 != null) ? interface2.Object_0 : ienumerable_0;
            this.method_15(jsonWriter_0, jsonArrayContract_0, obj2);
            this.list_0.Add(obj2);
            bool flag = this.method_29(jsonWriter_0, obj2, jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            jsonWriter_0.WriteStartArray();
            int top = jsonWriter_0.Top;
            int num2 = 0;
            foreach (object obj3 in ienumerable_0)
            {
                try
                {
                    JsonContract contract = jsonArrayContract_0.JsonContract_1 ?? this.method_5(obj3);
                    if (this.method_9(obj3, null, contract, jsonArrayContract_0, jsonProperty_0))
                    {
                        this.method_12(jsonWriter_0, obj3);
                    }
                    else if (this.method_11(jsonWriter_0, obj3, null, contract, jsonArrayContract_0, jsonProperty_0))
                    {
                        this.method_7(jsonWriter_0, obj3, contract, null, jsonArrayContract_0, jsonProperty_0);
                    }
                }
                catch (Exception exception)
                {
                    if (!base.method_2(obj2, jsonArrayContract_0, num2, null, jsonWriter_0.String_0, exception))
                    {
                        throw;
                    }
                    this.method_36(jsonWriter_0, top);
                }
                finally
                {
                    num2++;
                }
            }
            jsonWriter_0.WriteEndArray();
            if (flag)
            {
                jsonWriter_0.WriteEndObject();
            }
            this.list_0.RemoveAt(this.list_0.Count - 1);
            this.method_16(jsonWriter_0, jsonArrayContract_0, obj2);
        }

        private void method_27(JsonWriter jsonWriter_0, Array array_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            this.method_15(jsonWriter_0, jsonArrayContract_0, array_0);
            this.list_0.Add(array_0);
            bool flag = this.method_29(jsonWriter_0, array_0, jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            this.method_28(jsonWriter_0, array_0, jsonArrayContract_0, jsonProperty_0, jsonWriter_0.Top, new int[0]);
            if (flag)
            {
                jsonWriter_0.WriteEndObject();
            }
            this.list_0.RemoveAt(this.list_0.Count - 1);
            this.method_16(jsonWriter_0, jsonArrayContract_0, array_0);
        }

        private void method_28(JsonWriter jsonWriter_0, Array array_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, int int_0, int[] int_1)
        {
            int length = int_1.Length;
            int[] indices = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                indices[i] = int_1[i];
            }
            jsonWriter_0.WriteStartArray();
            int num3 = 0;
            while (true)
            {
                if (num3 >= array_0.GetLength(length))
                {
                    break;
                }
                indices[length] = num3;
                if (indices.Length == array_0.Rank)
                {
                    object obj2 = array_0.GetValue(indices);
                    try
                    {
                        JsonContract contract = jsonArrayContract_0.JsonContract_1 ?? this.method_5(obj2);
                        if (this.method_9(obj2, null, contract, jsonArrayContract_0, jsonProperty_0))
                        {
                            this.method_12(jsonWriter_0, obj2);
                        }
                        else if (this.method_11(jsonWriter_0, obj2, null, contract, jsonArrayContract_0, jsonProperty_0))
                        {
                            this.method_7(jsonWriter_0, obj2, contract, null, jsonArrayContract_0, jsonProperty_0);
                        }
                    }
                    catch (Exception exception)
                    {
                        if (!base.method_2(array_0, jsonArrayContract_0, num3, null, jsonWriter_0.String_0, exception))
                        {
                            throw;
                        }
                        this.method_36(jsonWriter_0, int_0 + 1);
                    }
                }
                else
                {
                    this.method_28(jsonWriter_0, array_0, jsonArrayContract_0, jsonProperty_0, int_0 + 1, indices);
                }
                num3++;
            }
            jsonWriter_0.WriteEndArray();
        }

        private bool method_29(JsonWriter jsonWriter_0, object object_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            bool flag3;
            bool? nullable = this.method_8(jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            bool flag = nullable.HasValue ? nullable.GetValueOrDefault() : this.method_23(base.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Arrays);
            bool flag2 = this.method_33(TypeNameHandling.Arrays, jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            if (flag3 = flag || flag2)
            {
                jsonWriter_0.WriteStartObject();
                if (flag)
                {
                    this.method_20(jsonWriter_0, jsonArrayContract_0.UnderlyingType, object_0);
                }
                if (flag2)
                {
                    this.method_21(jsonWriter_0, object_0.GetType());
                }
                jsonWriter_0.WritePropertyName("$values", false);
            }
            if (jsonArrayContract_0.JsonContract_0 == null)
            {
                jsonArrayContract_0.JsonContract_0 = base.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonArrayContract_0.CollectionItemType ?? typeof(object));
            }
            return flag3;
        }

        public void method_3(JsonWriter jsonWriter_0, object object_0, Type type_0)
        {
            if (jsonWriter_0 == null)
            {
                throw new ArgumentNullException("jsonWriter");
            }
            if (type_0 != null)
            {
                this.jsonContract_0 = base.jsonSerializer_0.icontractResolver_0.ResolveContract(type_0);
            }
            this.method_7(jsonWriter_0, object_0, this.method_5(object_0), null, null, null);
        }

        [SecuritySafeCritical]
        private void method_30(JsonWriter jsonWriter_0, ISerializable iserializable_0, JsonISerializableContract jsonISerializableContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            if (!Class139.Boolean_1)
            {
                throw JsonSerializationException.smethod_3(null, jsonWriter_0.String_0, "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data.\r\nTo fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true.".smethod_0(CultureInfo.InvariantCulture, iserializable_0.GetType()), null);
            }
            this.method_15(jsonWriter_0, jsonISerializableContract_0, iserializable_0);
            this.list_0.Add(iserializable_0);
            this.method_19(jsonWriter_0, iserializable_0, jsonISerializableContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            SerializationInfo info = new SerializationInfo(jsonISerializableContract_0.UnderlyingType, new FormatterConverter());
            iserializable_0.GetObjectData(info, base.jsonSerializer_0.streamingContext_0);
            SerializationInfoEnumerator enumerator = info.GetEnumerator();
            while (enumerator.MoveNext())
            {
                SerializationEntry current = enumerator.Current;
                JsonContract contract = this.method_5(current.Value);
                if (this.method_11(jsonWriter_0, current.Value, null, contract, jsonISerializableContract_0, jsonProperty_0))
                {
                    jsonWriter_0.WritePropertyName(current.Name);
                    this.method_7(jsonWriter_0, current.Value, contract, null, jsonISerializableContract_0, jsonProperty_0);
                }
            }
            jsonWriter_0.WriteEndObject();
            this.list_0.RemoveAt(this.list_0.Count - 1);
            this.method_16(jsonWriter_0, jsonISerializableContract_0, iserializable_0);
        }

        private void method_31(JsonWriter jsonWriter_0, IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, JsonDynamicContract jsonDynamicContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            this.method_15(jsonWriter_0, jsonDynamicContract_0, idynamicMetaObjectProvider_0);
            this.list_0.Add(idynamicMetaObjectProvider_0);
            this.method_19(jsonWriter_0, idynamicMetaObjectProvider_0, jsonDynamicContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            int top = jsonWriter_0.Top;
            int num2 = 0;
            while (true)
            {
                if (num2 >= jsonDynamicContract_0.Properties.Count)
                {
                    break;
                }
                JsonProperty property = jsonDynamicContract_0.Properties[num2];
                if (property.HasMemberAttribute)
                {
                    try
                    {
                        object obj2;
                        JsonContract contract;
                        if (this.method_18(jsonWriter_0, idynamicMetaObjectProvider_0, jsonDynamicContract_0, jsonProperty_0, property, out contract, out obj2))
                        {
                            property.method_2(jsonWriter_0);
                            this.method_7(jsonWriter_0, obj2, contract, property, jsonDynamicContract_0, jsonProperty_0);
                        }
                    }
                    catch (Exception exception)
                    {
                        if (!base.method_2(idynamicMetaObjectProvider_0, jsonDynamicContract_0, property.PropertyName, null, jsonWriter_0.String_0, exception))
                        {
                            throw;
                        }
                        this.method_36(jsonWriter_0, top);
                    }
                }
                num2++;
            }
            foreach (string str in idynamicMetaObjectProvider_0.smethod_0())
            {
                object obj3;
                if (jsonDynamicContract_0.method_5(idynamicMetaObjectProvider_0, str, out obj3))
                {
                    try
                    {
                        JsonContract contract2 = this.method_5(obj3);
                        if (this.method_32(obj3) && this.method_11(jsonWriter_0, obj3, null, contract2, jsonDynamicContract_0, jsonProperty_0))
                        {
                            string name = (jsonDynamicContract_0.PropertyNameResolver != null) ? jsonDynamicContract_0.PropertyNameResolver(str) : str;
                            jsonWriter_0.WritePropertyName(name);
                            this.method_7(jsonWriter_0, obj3, contract2, null, jsonDynamicContract_0, jsonProperty_0);
                        }
                    }
                    catch (Exception exception2)
                    {
                        if (!base.method_2(idynamicMetaObjectProvider_0, jsonDynamicContract_0, str, null, jsonWriter_0.String_0, exception2))
                        {
                            throw;
                        }
                        this.method_36(jsonWriter_0, top);
                    }
                }
            }
            jsonWriter_0.WriteEndObject();
            this.list_0.RemoveAt(this.list_0.Count - 1);
            this.method_16(jsonWriter_0, jsonDynamicContract_0, idynamicMetaObjectProvider_0);
        }

        private bool method_32(object object_0)
        {
            if ((base.jsonSerializer_0.nullValueHandling_0 == NullValueHandling.Ignore) && (object_0 == null))
            {
                return false;
            }
            return (!this.method_22(base.jsonSerializer_0.defaultValueHandling_0, DefaultValueHandling.Ignore) || ((object_0 != null) && !Class193.smethod_0(object_0, Class194.smethod_41(object_0.GetType()))));
        }

        private bool method_33(TypeNameHandling typeNameHandling_0, JsonContract jsonContract_1, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            TypeNameHandling? nullable6;
            TypeNameHandling? nullable2 = (jsonProperty_0 != null) ? jsonProperty_0.TypeNameHandling : null;
            if (!nullable2.HasValue)
            {
                TypeNameHandling? nullable4 = (jsonProperty_1 != null) ? jsonProperty_1.ItemTypeNameHandling : null;
                if (!nullable4.HasValue)
                {
                    nullable6 = (jsonContainerContract_0 != null) ? jsonContainerContract_0.ItemTypeNameHandling : null;
                }
            }
            TypeNameHandling handling = nullable6.HasValue ? nullable2.GetValueOrDefault() : base.jsonSerializer_0.typeNameHandling_0;
            if (this.method_24(handling, typeNameHandling_0))
            {
                return true;
            }
            if (this.method_24(handling, TypeNameHandling.Auto))
            {
                if (jsonProperty_0 != null)
                {
                    if (jsonContract_1.UnderlyingType != jsonProperty_0.JsonContract_0.CreatedType)
                    {
                        return true;
                    }
                }
                else if (jsonContainerContract_0 != null)
                {
                    if ((jsonContainerContract_0.JsonContract_0 == null) || (jsonContract_1.UnderlyingType != jsonContainerContract_0.JsonContract_0.CreatedType))
                    {
                        return true;
                    }
                }
                else if (((this.jsonContract_0 != null) && (this.list_0.Count == 1)) && (jsonContract_1.UnderlyingType != this.jsonContract_0.CreatedType))
                {
                    return true;
                }
            }
            return false;
        }

        private void method_34(JsonWriter jsonWriter_0, IDictionary idictionary_0, JsonDictionaryContract jsonDictionaryContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            Interface16 interface2 = idictionary_0 as Interface16;
            object obj2 = (interface2 != null) ? interface2.Object_0 : idictionary_0;
            this.method_15(jsonWriter_0, jsonDictionaryContract_0, obj2);
            this.list_0.Add(obj2);
            this.method_19(jsonWriter_0, obj2, jsonDictionaryContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            if (jsonDictionaryContract_0.JsonContract_0 == null)
            {
                jsonDictionaryContract_0.JsonContract_0 = base.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonDictionaryContract_0.DictionaryValueType ?? typeof(object));
            }
            if (jsonDictionaryContract_0.JsonContract_2 == null)
            {
                jsonDictionaryContract_0.JsonContract_2 = base.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonDictionaryContract_0.DictionaryKeyType ?? typeof(object));
            }
            int top = jsonWriter_0.Top;
            foreach (DictionaryEntry entry in idictionary_0)
            {
                bool flag;
                string arg = this.method_35(jsonWriter_0, entry, jsonDictionaryContract_0.JsonContract_2, out flag);
                arg = (jsonDictionaryContract_0.PropertyNameResolver != null) ? jsonDictionaryContract_0.PropertyNameResolver(arg) : arg;
                try
                {
                    object obj3 = entry.Value;
                    JsonContract contract = jsonDictionaryContract_0.JsonContract_1 ?? this.method_5(obj3);
                    if (this.method_9(obj3, null, contract, jsonDictionaryContract_0, jsonProperty_0))
                    {
                        jsonWriter_0.WritePropertyName(arg, flag);
                        this.method_12(jsonWriter_0, obj3);
                    }
                    else if (this.method_11(jsonWriter_0, obj3, null, contract, jsonDictionaryContract_0, jsonProperty_0))
                    {
                        jsonWriter_0.WritePropertyName(arg, flag);
                        this.method_7(jsonWriter_0, obj3, contract, null, jsonDictionaryContract_0, jsonProperty_0);
                    }
                }
                catch (Exception exception)
                {
                    if (!base.method_2(obj2, jsonDictionaryContract_0, arg, null, jsonWriter_0.String_0, exception))
                    {
                        throw;
                    }
                    this.method_36(jsonWriter_0, top);
                }
            }
            jsonWriter_0.WriteEndObject();
            this.list_0.RemoveAt(this.list_0.Count - 1);
            this.method_16(jsonWriter_0, jsonDictionaryContract_0, obj2);
        }

        private string method_35(JsonWriter jsonWriter_0, DictionaryEntry dictionaryEntry_0, JsonContract jsonContract_1, out bool bool_1)
        {
            string str;
            object key = dictionaryEntry_0.Key;
            JsonPrimitiveContract contract = jsonContract_1 as JsonPrimitiveContract;
            if (contract != null)
            {
                if ((contract.Enum17_0 != Enum17.DateTime) && (contract.Enum17_0 != Enum17.DateTimeNullable))
                {
                    if ((contract.Enum17_0 != Enum17.DateTimeOffset) && (contract.Enum17_0 != Enum17.DateTimeOffsetNullable))
                    {
                        bool_1 = true;
                        return Convert.ToString(key, CultureInfo.InvariantCulture);
                    }
                    bool_1 = false;
                    StringWriter writer2 = new StringWriter(CultureInfo.InvariantCulture);
                    Class184.smethod_21(writer2, (DateTimeOffset) key, jsonWriter_0.DateFormatHandling, jsonWriter_0.DateFormatString, jsonWriter_0.Culture);
                    return writer2.ToString();
                }
                bool_1 = false;
                StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);
                Class184.smethod_16(writer, (DateTime) key, jsonWriter_0.DateFormatHandling, jsonWriter_0.DateFormatString, jsonWriter_0.Culture);
                return writer.ToString();
            }
            if (smethod_0(key, key.GetType(), out str))
            {
                bool_1 = true;
                return str;
            }
            bool_1 = true;
            return key.ToString();
        }

        private void method_36(JsonWriter jsonWriter_0, int int_0)
        {
            base.method_1();
            if (jsonWriter_0.WriteState == WriteState.Property)
            {
                jsonWriter_0.WriteNull();
            }
            while (jsonWriter_0.Top > int_0)
            {
                jsonWriter_0.WriteEnd();
            }
        }

        private bool method_37(JsonWriter jsonWriter_0, JsonProperty jsonProperty_0, object object_0)
        {
            if (jsonProperty_0.ShouldSerialize == null)
            {
                return true;
            }
            bool flag = jsonProperty_0.ShouldSerialize(object_0);
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
            {
                base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(null, jsonWriter_0.Path, "ShouldSerialize result for property '{0}' on {1}: {2}".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType, flag)), null);
            }
            return flag;
        }

        private bool method_38(JsonWriter jsonWriter_0, JsonProperty jsonProperty_0, object object_0)
        {
            if (jsonProperty_0.GetIsSpecified == null)
            {
                return true;
            }
            bool flag = jsonProperty_0.GetIsSpecified(object_0);
            if ((base.itraceWriter_0 != null) && (base.itraceWriter_0.LevelFilter >= TraceLevel.Verbose))
            {
                base.itraceWriter_0.Trace(TraceLevel.Verbose, Struct25.smethod_2(null, jsonWriter_0.Path, "IsSpecified result for property '{0}' on {1}: {2}".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType, flag)), null);
            }
            return flag;
        }

        private Class112 method_4()
        {
            if (this.class112_0 == null)
            {
                this.class112_0 = new Class112(this);
            }
            return this.class112_0;
        }

        private JsonContract method_5(object object_0)
        {
            if (object_0 == null)
            {
                return null;
            }
            return base.jsonSerializer_0.icontractResolver_0.ResolveContract(object_0.GetType());
        }

        private void method_6(JsonWriter jsonWriter_0, object object_0, JsonPrimitiveContract jsonPrimitiveContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            if ((jsonPrimitiveContract_0.Enum17_0 == Enum17.Bytes) && this.method_33(TypeNameHandling.Objects, jsonPrimitiveContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1))
            {
                jsonWriter_0.WriteStartObject();
                this.method_21(jsonWriter_0, jsonPrimitiveContract_0.CreatedType);
                jsonWriter_0.WritePropertyName("$value", false);
                JsonWriter.smethod_3(jsonWriter_0, jsonPrimitiveContract_0.Enum17_0, object_0);
                jsonWriter_0.WriteEndObject();
            }
            else
            {
                JsonWriter.smethod_3(jsonWriter_0, jsonPrimitiveContract_0.Enum17_0, object_0);
            }
        }

        private void method_7(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_1, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            if (object_0 == null)
            {
                jsonWriter_0.WriteNull();
            }
            else
            {
                JsonConverter converter;
                if ((((((converter = (jsonProperty_0 != null) ? jsonProperty_0.Converter : null) != null) || ((converter = (jsonProperty_1 != null) ? jsonProperty_1.ItemConverter : null) != null)) || ((converter = (jsonContainerContract_0 != null) ? jsonContainerContract_0.ItemConverter : null) != null)) || ((((converter = jsonContract_1.Converter) != null) || ((converter = base.jsonSerializer_0.method_2(jsonContract_1.UnderlyingType)) != null)) || ((converter = jsonContract_1.JsonConverter_0) != null))) && converter.CanWrite)
                {
                    this.method_25(jsonWriter_0, converter, object_0, jsonContract_1, jsonContainerContract_0, jsonProperty_1);
                }
                else
                {
                    switch (jsonContract_1.enum15_0)
                    {
                        case Enum15.Object:
                            this.method_17(jsonWriter_0, object_0, (JsonObjectContract) jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                            return;

                        case Enum15.Array:
                        {
                            JsonArrayContract contract = (JsonArrayContract) jsonContract_1;
                            if (contract.IsMultidimensionalArray)
                            {
                                this.method_27(jsonWriter_0, (Array) object_0, contract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                                return;
                            }
                            this.method_26(jsonWriter_0, (IEnumerable) object_0, contract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                            return;
                        }
                        case Enum15.Primitive:
                            this.method_6(jsonWriter_0, object_0, (JsonPrimitiveContract) jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                            return;

                        case Enum15.String:
                            this.method_14(jsonWriter_0, object_0, (JsonStringContract) jsonContract_1);
                            return;

                        case Enum15.Dictionary:
                        {
                            JsonDictionaryContract contract2 = (JsonDictionaryContract) jsonContract_1;
                            this.method_34(jsonWriter_0, (object_0 is IDictionary) ? ((IDictionary) object_0) : contract2.method_5(object_0), contract2, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                            return;
                        }
                        case Enum15.Dynamic:
                            this.method_31(jsonWriter_0, (IDynamicMetaObjectProvider) object_0, (JsonDynamicContract) jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                            return;

                        case Enum15.Serializable:
                            this.method_30(jsonWriter_0, (ISerializable) object_0, (JsonISerializableContract) jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
                            return;

                        case Enum15.Linq:
                            ((JToken) object_0).WriteTo(jsonWriter_0, base.jsonSerializer_0.JsonConverterCollection_0.ToArray<JsonConverter>());
                            return;
                    }
                }
            }
        }

        private bool? method_8(JsonContract jsonContract_1, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            bool? isReference = null;
            if (jsonProperty_0 != null)
            {
                isReference = jsonProperty_0.IsReference;
            }
            if (!isReference.HasValue && (jsonProperty_1 != null))
            {
                isReference = jsonProperty_1.ItemIsReference;
            }
            if (!isReference.HasValue && (jsonContainerContract_0 != null))
            {
                isReference = jsonContainerContract_0.ItemIsReference;
            }
            if (!isReference.HasValue)
            {
                isReference = jsonContract_1.IsReference;
            }
            return isReference;
        }

        private bool method_9(object object_0, JsonProperty jsonProperty_0, JsonContract jsonContract_1, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
        {
            if (object_0 == null)
            {
                return false;
            }
            if ((jsonContract_1.enum15_0 == Enum15.Primitive) || (jsonContract_1.enum15_0 == Enum15.String))
            {
                return false;
            }
            bool? nullable = this.method_8(jsonContract_1, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
            if (!nullable.HasValue)
            {
                if (jsonContract_1.enum15_0 == Enum15.Array)
                {
                    nullable = new bool?(this.method_23(base.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Arrays));
                }
                else
                {
                    nullable = new bool?(this.method_23(base.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Objects));
                }
            }
            if (!nullable.Value)
            {
                return false;
            }
            return base.jsonSerializer_0.method_1().IsReferenced(this, object_0);
        }

        internal static bool smethod_0(object object_0, Type type_0, out string string_0)
        {
            TypeConverter converter = Class181.smethod_13(type_0);
            if (((converter != null) && !(converter is ComponentConverter)) && ((converter.GetType() != typeof(TypeConverter)) && converter.CanConvertTo(typeof(string))))
            {
                string_0 = converter.ConvertToInvariantString(object_0);
                return true;
            }
            if (object_0 is Type)
            {
                string_0 = ((Type) object_0).AssemblyQualifiedName;
                return true;
            }
            string_0 = null;
            return false;
        }
    }
}

