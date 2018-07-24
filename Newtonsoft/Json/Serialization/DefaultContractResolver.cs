namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ns16;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Dynamic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    public class DefaultContractResolver : IContractResolver
    {
        [CompilerGenerated]
        private BindingFlags bindingFlags_0;
        private readonly bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private bool bool_2;
        [CompilerGenerated]
        private bool bool_3;
        private static Dictionary<Struct27, JsonContract> dictionary_0;
        private Dictionary<Struct27, JsonContract> dictionary_1;
        [CompilerGenerated]
        private static Func<MemberInfo, bool> func_0;
        [CompilerGenerated]
        private static Func<MemberInfo, bool> func_1;
        [CompilerGenerated]
        private static Func<ConstructorInfo, bool> func_2;
        [CompilerGenerated]
        private static Func<JsonProperty, int> func_3;
        private static readonly IContractResolver icontractResolver_0 = new DefaultContractResolver(true);
        private static readonly IList<JsonConverter> ilist_0 = new List<JsonConverter> { new EntityKeyMemberConverter(), new ExpandoObjectConverter(), new XmlNodeConverter(), new BinaryConverter(), new DataSetConverter(), new DataTableConverter(), new KeyValuePairConverter(), new BsonObjectIdConverter(), new RegexConverter() };
        private static readonly object object_0 = new object();

        public DefaultContractResolver() : this(false)
        {
        }

        public DefaultContractResolver(bool shareCache)
        {
            this.DefaultMembersSearchFlags = BindingFlags.Public | BindingFlags.Instance;
            this.IgnoreSerializableAttribute = true;
            this.bool_0 = shareCache;
        }

        protected virtual JsonArrayContract CreateArrayContract(Type objectType)
        {
            JsonArrayContract contract = new JsonArrayContract(objectType);
            this.method_7(contract);
            return contract;
        }

        protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
        {
            ParameterInfo[] parameters = constructor.GetParameters();
            JsonPropertyCollection propertys = new JsonPropertyCollection(constructor.DeclaringType);
            foreach (ParameterInfo info in parameters)
            {
                JsonProperty matchingMemberProperty = (info.Name != null) ? memberProperties.GetClosestMatchProperty(info.Name) : null;
                if ((matchingMemberProperty != null) && (matchingMemberProperty.PropertyType != info.ParameterType))
                {
                    matchingMemberProperty = null;
                }
                JsonProperty property = this.CreatePropertyFromConstructorParameter(matchingMemberProperty, info);
                if (property != null)
                {
                    propertys.AddProperty(property);
                }
            }
            return propertys;
        }

        protected virtual JsonContract CreateContract(Type objectType)
        {
            Type type = Class194.smethod_11(objectType);
            if (smethod_0(objectType))
            {
                return this.CreatePrimitiveContract(objectType);
            }
            if (Class139.smethod_1(type) == null)
            {
                if (Class139.smethod_2(type) != null)
                {
                    return this.CreateArrayContract(objectType);
                }
                if (Class139.smethod_3(type) != null)
                {
                    return this.CreateDictionaryContract(objectType);
                }
                if ((type == typeof(JToken)) || type.IsSubclassOf(typeof(JToken)))
                {
                    return this.CreateLinqContract(objectType);
                }
                if (Class191.smethod_2(type))
                {
                    return this.CreateDictionaryContract(objectType);
                }
                if (typeof(IEnumerable).IsAssignableFrom(type))
                {
                    return this.CreateArrayContract(objectType);
                }
                if (smethod_2(type))
                {
                    return this.CreateStringContract(objectType);
                }
                if (!this.IgnoreSerializableInterface && typeof(ISerializable).IsAssignableFrom(type))
                {
                    return this.CreateISerializableContract(objectType);
                }
                if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type))
                {
                    return this.CreateDynamicContract(objectType);
                }
                if (smethod_1(type))
                {
                    return this.CreatePrimitiveContract(type);
                }
            }
            return this.CreateObjectContract(objectType);
        }

        protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
        {
            JsonDictionaryContract contract = new JsonDictionaryContract(objectType);
            this.method_7(contract);
            contract.PropertyNameResolver = new Func<string, string>(this.ResolvePropertyName);
            return contract;
        }

        protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
        {
            JsonDynamicContract contract = new JsonDynamicContract(objectType);
            this.method_7(contract);
            contract.PropertyNameResolver = new Func<string, string>(this.ResolvePropertyName);
            contract.Properties.smethod_1<JsonProperty>(this.CreateProperties(objectType, MemberSerialization.OptOut));
            return contract;
        }

        protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
        {
            JsonISerializableContract contract = new JsonISerializableContract(objectType);
            this.method_7(contract);
            ConstructorInfo info = contract.type_0.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(SerializationInfo), typeof(StreamingContext) }, null);
            if (info != null)
            {
                Class127 class2 = new Class127 {
                    delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(info)
                };
                contract.ISerializableCreator = new ObjectConstructor<object>(class2.method_0);
            }
            return contract;
        }

        protected virtual JsonLinqContract CreateLinqContract(Type objectType)
        {
            JsonLinqContract contract = new JsonLinqContract(objectType);
            this.method_7(contract);
            return contract;
        }

        protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
        {
            if (this.DynamicCodeGeneration)
            {
                return new DynamicValueProvider(member);
            }
            return new ReflectionValueProvider(member);
        }

        protected virtual JsonObjectContract CreateObjectContract(Type objectType)
        {
            JsonObjectContract contract = new JsonObjectContract(objectType);
            this.method_7(contract);
            bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
            contract.MemberSerialization = Class139.smethod_7(contract.type_0, ignoreSerializableAttribute);
            contract.Properties.smethod_1<JsonProperty>(this.CreateProperties(contract.type_0, contract.MemberSerialization));
            JsonObjectAttribute attribute = Class139.smethod_1(contract.type_0);
            if (attribute != null)
            {
                contract.ItemRequired = attribute.nullable_4;
            }
            ConstructorInfo constructor = this.method_4(contract.type_0);
            if (constructor != null)
            {
                contract.OverrideConstructor = constructor;
                contract.ConstructorParameters.smethod_1<JsonProperty>(this.CreateConstructorParameters(constructor, contract.Properties));
            }
            else if (contract.MemberSerialization == MemberSerialization.Fields)
            {
                if (Class139.Boolean_1)
                {
                    contract.DefaultCreator = new Func<object>(contract.method_5);
                }
            }
            else if ((contract.DefaultCreator == null) || contract.DefaultCreatorNonPublic)
            {
                ConstructorInfo info2 = this.method_5(contract.type_0);
                if (info2 != null)
                {
                    contract.ParametrizedConstructor = info2;
                    contract.ConstructorParameters.smethod_1<JsonProperty>(this.CreateConstructorParameters(info2, contract.Properties));
                }
            }
            contract.ExtensionDataSetter = this.method_3(contract.type_0);
            return contract;
        }

        protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
        {
            JsonPrimitiveContract contract = new JsonPrimitiveContract(objectType);
            this.method_7(contract);
            return contract;
        }

        protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            List<MemberInfo> serializableMembers = this.GetSerializableMembers(type);
            if (serializableMembers == null)
            {
                throw new JsonSerializationException("Null collection of seralizable members returned.");
            }
            JsonPropertyCollection source = new JsonPropertyCollection(type);
            foreach (MemberInfo info in serializableMembers)
            {
                JsonProperty property = this.CreateProperty(info, memberSerialization);
                if (property != null)
                {
                    source.AddProperty(property);
                }
            }
            if (func_3 == null)
            {
                func_3 = new Func<JsonProperty, int>(DefaultContractResolver.smethod_8);
            }
            return source.OrderBy<JsonProperty, int>(func_3).ToList<JsonProperty>();
        }

        protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            bool flag;
            JsonProperty property = new JsonProperty {
                PropertyType = Class194.smethod_20(member),
                DeclaringType = member.DeclaringType,
                ValueProvider = this.CreateMemberValueProvider(member)
            };
            this.method_11(property, member, member.Name, member.DeclaringType, memberSerialization, out flag);
            if (memberSerialization != MemberSerialization.Fields)
            {
                property.Readable = Class194.smethod_25(member, flag);
                property.Writable = Class194.smethod_26(member, flag, property.HasMemberAttribute);
            }
            else
            {
                property.Readable = true;
                property.Writable = true;
            }
            property.ShouldSerialize = this.method_12(member);
            this.method_13(property, member, flag);
            return property;
        }

        protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
        {
            bool flag;
            JsonProperty property = new JsonProperty {
                PropertyType = parameterInfo.ParameterType
            };
            this.method_11(property, parameterInfo, parameterInfo.Name, parameterInfo.Member.DeclaringType, MemberSerialization.OptOut, out flag);
            property.Readable = false;
            property.Writable = true;
            if (matchingMemberProperty != null)
            {
                property.PropertyName = (property.PropertyName != parameterInfo.Name) ? property.PropertyName : matchingMemberProperty.PropertyName;
                property.Converter = property.Converter ?? matchingMemberProperty.Converter;
                property.MemberConverter = property.MemberConverter ?? matchingMemberProperty.MemberConverter;
                if (!property.bool_0 && matchingMemberProperty.bool_0)
                {
                    property.DefaultValue = matchingMemberProperty.DefaultValue;
                }
                Required? nullable = property.nullable_0;
                property.nullable_0 = nullable.HasValue ? new Required?(nullable.GetValueOrDefault()) : matchingMemberProperty.nullable_0;
                bool? isReference = property.IsReference;
                property.IsReference = isReference.HasValue ? new bool?(isReference.GetValueOrDefault()) : matchingMemberProperty.IsReference;
                NullValueHandling? nullValueHandling = property.NullValueHandling;
                property.NullValueHandling = nullValueHandling.HasValue ? new NullValueHandling?(nullValueHandling.GetValueOrDefault()) : matchingMemberProperty.NullValueHandling;
                DefaultValueHandling? defaultValueHandling = property.DefaultValueHandling;
                property.DefaultValueHandling = defaultValueHandling.HasValue ? new DefaultValueHandling?(defaultValueHandling.GetValueOrDefault()) : matchingMemberProperty.DefaultValueHandling;
                ReferenceLoopHandling? referenceLoopHandling = property.ReferenceLoopHandling;
                property.ReferenceLoopHandling = referenceLoopHandling.HasValue ? new ReferenceLoopHandling?(referenceLoopHandling.GetValueOrDefault()) : matchingMemberProperty.ReferenceLoopHandling;
                ObjectCreationHandling? objectCreationHandling = property.ObjectCreationHandling;
                property.ObjectCreationHandling = objectCreationHandling.HasValue ? new ObjectCreationHandling?(objectCreationHandling.GetValueOrDefault()) : matchingMemberProperty.ObjectCreationHandling;
                TypeNameHandling? typeNameHandling = property.TypeNameHandling;
                property.TypeNameHandling = typeNameHandling.HasValue ? new TypeNameHandling?(typeNameHandling.GetValueOrDefault()) : matchingMemberProperty.TypeNameHandling;
            }
            return property;
        }

        protected virtual JsonStringContract CreateStringContract(Type objectType)
        {
            JsonStringContract contract = new JsonStringContract(objectType);
            this.method_7(contract);
            return contract;
        }

        public string GetResolvedPropertyName(string propertyName)
        {
            return this.ResolvePropertyName(propertyName);
        }

        protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
        {
            bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
            MemberSerialization serialization = Class139.smethod_7(objectType, ignoreSerializableAttribute);
            if (func_0 == null)
            {
                func_0 = new Func<MemberInfo, bool>(DefaultContractResolver.smethod_5);
            }
            List<MemberInfo> list = Class194.smethod_27(objectType, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).Where<MemberInfo>(func_0).ToList<MemberInfo>();
            List<MemberInfo> source = new List<MemberInfo>();
            if (serialization != MemberSerialization.Fields)
            {
                Type type;
                DataContractAttribute attribute = Class139.smethod_5(objectType);
                if (func_1 == null)
                {
                    func_1 = new Func<MemberInfo, bool>(DefaultContractResolver.smethod_6);
                }
                List<MemberInfo> list3 = Class194.smethod_27(objectType, this.DefaultMembersSearchFlags).Where<MemberInfo>(func_1).ToList<MemberInfo>();
                foreach (MemberInfo info in list)
                {
                    if (this.SerializeCompilerGeneratedMembers || !info.IsDefined(typeof(CompilerGeneratedAttribute), true))
                    {
                        if (list3.Contains(info))
                        {
                            source.Add(info);
                        }
                        else if (Class139.smethod_17<JsonPropertyAttribute>(info) != null)
                        {
                            source.Add(info);
                        }
                        else if ((attribute != null) && (Class139.smethod_17<DataMemberAttribute>(info) != null))
                        {
                            source.Add(info);
                        }
                        else if ((serialization == MemberSerialization.Fields) && (info.smethod_1() == MemberTypes.Field))
                        {
                            source.Add(info);
                        }
                    }
                }
                if (objectType.smethod_13("System.Data.Objects.DataClasses.EntityObject", out type))
                {
                    source = source.Where<MemberInfo>(new Func<MemberInfo, bool>(this.method_2)).ToList<MemberInfo>();
                }
                return source;
            }
            foreach (MemberInfo info2 in list)
            {
                FieldInfo info3 = info2 as FieldInfo;
                if ((info3 != null) && !info3.IsStatic)
                {
                    source.Add(info2);
                }
            }
            return source;
        }

        private Dictionary<Struct27, JsonContract> method_0()
        {
            if (this.bool_0)
            {
                return dictionary_0;
            }
            return this.dictionary_1;
        }

        private void method_1(Dictionary<Struct27, JsonContract> dictionary_2)
        {
            if (this.bool_0)
            {
                dictionary_0 = dictionary_2;
            }
            else
            {
                this.dictionary_1 = dictionary_2;
            }
        }

        private List<Type> method_10(Type type_0)
        {
            List<Type> list = new List<Type>();
            for (Type type = type_0; type != null; type = type.smethod_6())
            {
                if (!(type != typeof(object)))
                {
                    break;
                }
                list.Add(type);
            }
            list.Reverse();
            return list;
        }

        private void method_11(JsonProperty jsonProperty_0, object object_1, string string_0, Type type_0, MemberSerialization memberSerialization_0, out bool bool_4)
        {
            DataMemberAttribute attribute2;
            string propertyName;
            DataContractAttribute attribute = Class139.smethod_5(type_0);
            MemberInfo info = object_1 as MemberInfo;
            if ((attribute != null) && (info != null))
            {
                attribute2 = Class139.smethod_6(info);
            }
            else
            {
                attribute2 = null;
            }
            JsonPropertyAttribute attribute3 = Class139.smethod_17<JsonPropertyAttribute>(object_1);
            if (attribute3 != null)
            {
                jsonProperty_0.HasMemberAttribute = true;
            }
            if ((attribute3 != null) && (attribute3.PropertyName != null))
            {
                propertyName = attribute3.PropertyName;
            }
            else if ((attribute2 != null) && (attribute2.Name != null))
            {
                propertyName = attribute2.Name;
            }
            else
            {
                propertyName = string_0;
            }
            jsonProperty_0.PropertyName = this.ResolvePropertyName(propertyName);
            jsonProperty_0.UnderlyingName = string_0;
            bool flag = false;
            if (attribute3 != null)
            {
                jsonProperty_0.nullable_0 = attribute3.nullable_7;
                jsonProperty_0.Order = attribute3.nullable_6;
                jsonProperty_0.DefaultValueHandling = attribute3.nullable_1;
                flag = true;
            }
            else if (attribute2 != null)
            {
                jsonProperty_0.nullable_0 = new Required?(attribute2.IsRequired ? Required.AllowNull : Required.Default);
                jsonProperty_0.Order = (attribute2.Order != -1) ? new int?(attribute2.Order) : null;
                jsonProperty_0.DefaultValueHandling = !attribute2.EmitDefaultValue ? ((DefaultValueHandling?) 1) : null;
                flag = true;
            }
            bool flag2 = ((Class139.smethod_17<JsonIgnoreAttribute>(object_1) != null) || (Class139.smethod_17<JsonExtensionDataAttribute>(object_1) != null)) || (Class139.smethod_17<NonSerializedAttribute>(object_1) != null);
            if (memberSerialization_0 != MemberSerialization.OptIn)
            {
                bool flag3 = false;
                flag3 = Class139.smethod_17<IgnoreDataMemberAttribute>(object_1) != null;
                jsonProperty_0.Ignored = flag2 || flag3;
            }
            else
            {
                jsonProperty_0.Ignored = flag2 || !flag;
            }
            jsonProperty_0.Converter = Class139.smethod_10(object_1, jsonProperty_0.PropertyType);
            jsonProperty_0.MemberConverter = Class139.smethod_10(object_1, jsonProperty_0.PropertyType);
            DefaultValueAttribute attribute4 = Class139.smethod_17<DefaultValueAttribute>(object_1);
            if (attribute4 != null)
            {
                jsonProperty_0.DefaultValue = attribute4.Value;
            }
            jsonProperty_0.NullValueHandling = (attribute3 != null) ? attribute3.nullable_0 : null;
            jsonProperty_0.ReferenceLoopHandling = (attribute3 != null) ? attribute3.nullable_2 : null;
            jsonProperty_0.ObjectCreationHandling = (attribute3 != null) ? attribute3.nullable_3 : null;
            jsonProperty_0.TypeNameHandling = (attribute3 != null) ? attribute3.nullable_4 : null;
            jsonProperty_0.IsReference = (attribute3 != null) ? attribute3.nullable_5 : null;
            jsonProperty_0.ItemIsReference = (attribute3 != null) ? attribute3.nullable_8 : null;
            jsonProperty_0.ItemConverter = ((attribute3 == null) || (attribute3.ItemConverterType == null)) ? null : JsonConverterAttribute.smethod_0(attribute3.ItemConverterType);
            jsonProperty_0.ItemReferenceLoopHandling = (attribute3 != null) ? attribute3.nullable_9 : null;
            jsonProperty_0.ItemTypeNameHandling = (attribute3 != null) ? attribute3.nullable_10 : null;
            bool_4 = false;
            if ((this.DefaultMembersSearchFlags & BindingFlags.NonPublic) == BindingFlags.NonPublic)
            {
                bool_4 = true;
            }
            if (attribute3 != null)
            {
                bool_4 = true;
            }
            if (memberSerialization_0 == MemberSerialization.Fields)
            {
                bool_4 = true;
            }
            if (attribute2 != null)
            {
                bool_4 = true;
                jsonProperty_0.HasMemberAttribute = true;
            }
        }

        private Predicate<object> method_12(MemberInfo memberInfo_0)
        {
            Class128 class2 = new Class128();
            MethodInfo method = memberInfo_0.DeclaringType.GetMethod("ShouldSerialize" + memberInfo_0.Name, Class194.type_0);
            if ((method != null) && !(method.ReturnType != typeof(bool)))
            {
                class2.delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(method);
                return new Predicate<object>(class2.method_0);
            }
            return null;
        }

        private void method_13(JsonProperty jsonProperty_0, MemberInfo memberInfo_0, bool bool_4)
        {
            Class129 class2 = new Class129();
            MemberInfo property = memberInfo_0.DeclaringType.GetProperty(memberInfo_0.Name + "Specified");
            if (property == null)
            {
                property = memberInfo_0.DeclaringType.GetField(memberInfo_0.Name + "Specified");
            }
            if ((property != null) && (Class194.smethod_20(property) == typeof(bool)))
            {
                class2.func_0 = Class139.Class166_0.method_0<object>(property);
                jsonProperty_0.GetIsSpecified = new Predicate<object>(class2.method_0);
                if (Class194.smethod_26(property, bool_4, false))
                {
                    jsonProperty_0.SetIsSpecified = Class139.Class166_0.method_1<object>(property);
                }
            }
        }

        private bool method_2(MemberInfo memberInfo_0)
        {
            PropertyInfo info = memberInfo_0 as PropertyInfo;
            if (((info != null) && info.PropertyType.smethod_4()) && (info.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1"))
            {
                return false;
            }
            return true;
        }

        private ExtensionDataSetter method_3(Type type_0)
        {
            ExtensionDataSetter setter = null;
            foreach (Type type in this.method_10(type_0))
            {
                IList<MemberInfo> list = new List<MemberInfo>();
                list.smethod_1<MemberInfo>(type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
                list.smethod_1<MemberInfo>(type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
                using (IEnumerator<MemberInfo> enumerator2 = list.GetEnumerator())
                {
                    MemberInfo current;
                    while (enumerator2.MoveNext())
                    {
                        current = enumerator2.Current;
                        MemberTypes types = current.smethod_1();
                        if (((types == MemberTypes.Property) || (types == MemberTypes.Field)) && current.IsDefined(typeof(JsonExtensionDataAttribute), false))
                        {
                            Type type3;
                            Type type2 = Class194.smethod_20(current);
                            if (!Class194.smethod_14(type2, typeof(IDictionary<,>), out type3))
                            {
                                goto Label_01AF;
                            }
                            Type type4 = type3.GetGenericArguments()[0];
                            Type type5 = type3.GetGenericArguments()[1];
                            if (Class194.smethod_12(type2, typeof(IDictionary<,>)))
                            {
                                type2 = typeof(Dictionary<,>).MakeGenericType(new Type[] { type4, type5 });
                            }
                            if (!type4.IsAssignableFrom(typeof(string)) || !type5.IsAssignableFrom(typeof(JToken)))
                            {
                                goto Label_01AF;
                            }
                            Class126 class2 = new Class126();
                            MethodInfo method = type2.GetMethod("Add", new Type[] { type4, type5 });
                            class2.func_0 = Class139.Class166_0.method_0<object>(current);
                            class2.action_0 = Class139.Class166_0.method_1<object>(current);
                            class2.func_1 = Class139.Class166_0.ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<object>(type2);
                            class2.delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(method);
                            setter = new ExtensionDataSetter(class2.method_0);
                        }
                    }
                    continue;
                Label_01AF:
                    throw new JsonException("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".smethod_1(CultureInfo.InvariantCulture, smethod_4(current.DeclaringType), current.Name));
                }
            }
            return setter;
        }

        private ConstructorInfo method_4(Type type_0)
        {
            if (func_2 == null)
            {
                func_2 = new Func<ConstructorInfo, bool>(DefaultContractResolver.smethod_7);
            }
            IList<ConstructorInfo> list = type_0.GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Where<ConstructorInfo>(func_2).ToList<ConstructorInfo>();
            if (list.Count > 1)
            {
                throw new JsonException("Multiple constructors with the JsonConstructorAttribute.");
            }
            if (list.Count == 1)
            {
                return list[0];
            }
            if (type_0 == typeof(Version))
            {
                return type_0.GetConstructor(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) });
            }
            return null;
        }

        private ConstructorInfo method_5(Type type_0)
        {
            IList<ConstructorInfo> list = type_0.GetConstructors(BindingFlags.Public | BindingFlags.Instance).ToList<ConstructorInfo>();
            if (list.Count == 1)
            {
                return list[0];
            }
            return null;
        }

        private Func<object> method_6(Type type_0)
        {
            return Class139.Class166_0.ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<object>(type_0);
        }

        [SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId="System.Runtime.Serialization.DataContractAttribute.#get_IsReference()")]
        private void method_7(JsonContract jsonContract_0)
        {
            JsonContainerAttribute attribute = Class139.smethod_0(jsonContract_0.type_0);
            if (attribute != null)
            {
                jsonContract_0.IsReference = attribute.nullable_0;
            }
            else
            {
                DataContractAttribute attribute2 = Class139.smethod_5(jsonContract_0.type_0);
                if ((attribute2 != null) && attribute2.IsReference)
                {
                    jsonContract_0.IsReference = true;
                }
            }
            jsonContract_0.Converter = this.ResolveContractConverter(jsonContract_0.type_0);
            jsonContract_0.JsonConverter_0 = JsonSerializer.smethod_1(ilist_0, jsonContract_0.type_0);
            if (Class194.smethod_6(jsonContract_0.CreatedType, true) || jsonContract_0.CreatedType.smethod_12())
            {
                jsonContract_0.DefaultCreator = this.method_6(jsonContract_0.CreatedType);
                jsonContract_0.DefaultCreatorNonPublic = !jsonContract_0.CreatedType.smethod_12() && (Class194.smethod_7(jsonContract_0.CreatedType) == null);
            }
            this.method_8(jsonContract_0, jsonContract_0.type_0);
        }

        private void method_8(JsonContract jsonContract_0, Type type_0)
        {
            List<SerializationCallback> list;
            List<SerializationCallback> list2;
            List<SerializationCallback> list3;
            List<SerializationCallback> list4;
            List<SerializationErrorCallback> list5;
            this.method_9(type_0, out list, out list2, out list3, out list4, out list5);
            if (list != null)
            {
                jsonContract_0.OnSerializingCallbacks.smethod_1<SerializationCallback>(list);
            }
            if (list2 != null)
            {
                jsonContract_0.OnSerializedCallbacks.smethod_1<SerializationCallback>(list2);
            }
            if (list3 != null)
            {
                jsonContract_0.OnDeserializingCallbacks.smethod_1<SerializationCallback>(list3);
            }
            if ((list4 != null) && (!type_0.smethod_4() || (type_0.GetGenericTypeDefinition() != typeof(ConcurrentDictionary<,>))))
            {
                jsonContract_0.OnDeserializedCallbacks.smethod_1<SerializationCallback>(list4);
            }
            if (list5 != null)
            {
                jsonContract_0.OnErrorCallbacks.smethod_1<SerializationErrorCallback>(list5);
            }
        }

        private void method_9(Type type_0, out List<SerializationCallback> list_0, out List<SerializationCallback> list_1, out List<SerializationCallback> list_2, out List<SerializationCallback> list_3, out List<SerializationErrorCallback> list_4)
        {
            list_0 = null;
            list_1 = null;
            list_2 = null;
            list_3 = null;
            list_4 = null;
            foreach (Type type in this.method_10(type_0))
            {
                MethodInfo info = null;
                MethodInfo info2 = null;
                MethodInfo info3 = null;
                MethodInfo info4 = null;
                MethodInfo info5 = null;
                foreach (MethodInfo info6 in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    if (!info6.ContainsGenericParameters)
                    {
                        Type type2 = null;
                        ParameterInfo[] parameters = info6.GetParameters();
                        if (smethod_3(info6, parameters, typeof(OnSerializingAttribute), info, ref type2))
                        {
                            list_0 = list_0 ?? new List<SerializationCallback>();
                            list_0.Add(JsonContract.smethod_0(info6));
                            info = info6;
                        }
                        if (smethod_3(info6, parameters, typeof(OnSerializedAttribute), info2, ref type2))
                        {
                            list_1 = list_1 ?? new List<SerializationCallback>();
                            list_1.Add(JsonContract.smethod_0(info6));
                            info2 = info6;
                        }
                        if (smethod_3(info6, parameters, typeof(OnDeserializingAttribute), info3, ref type2))
                        {
                            list_2 = list_2 ?? new List<SerializationCallback>();
                            list_2.Add(JsonContract.smethod_0(info6));
                            info3 = info6;
                        }
                        if (smethod_3(info6, parameters, typeof(OnDeserializedAttribute), info4, ref type2))
                        {
                            list_3 = list_3 ?? new List<SerializationCallback>();
                            list_3.Add(JsonContract.smethod_0(info6));
                            info4 = info6;
                        }
                        if (smethod_3(info6, parameters, typeof(OnErrorAttribute), info5, ref type2))
                        {
                            list_4 = list_4 ?? new List<SerializationErrorCallback>();
                            list_4.Add(JsonContract.smethod_1(info6));
                            info5 = info6;
                        }
                    }
                }
            }
        }

        public virtual JsonContract ResolveContract(Type type)
        {
            JsonContract contract;
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            Struct27 key = new Struct27(base.GetType(), type);
            Dictionary<Struct27, JsonContract> dictionary = this.method_0();
            if ((dictionary == null) || !dictionary.TryGetValue(key, out contract))
            {
                contract = this.CreateContract(type);
                lock (object_0)
                {
                    dictionary = this.method_0();
                    Dictionary<Struct27, JsonContract> dictionary2 = (dictionary != null) ? new Dictionary<Struct27, JsonContract>(dictionary) : new Dictionary<Struct27, JsonContract>();
                    dictionary2[key] = contract;
                    this.method_1(dictionary2);
                }
            }
            return contract;
        }

        protected virtual JsonConverter ResolveContractConverter(Type objectType)
        {
            return Class139.smethod_10(objectType, objectType);
        }

        protected internal virtual string ResolvePropertyName(string propertyName)
        {
            return propertyName;
        }

        internal static bool smethod_0(Type type_0)
        {
            Enum17 enum2 = Class181.smethod_0(type_0);
            return ((enum2 != Enum17.Empty) && (enum2 != Enum17.Object));
        }

        internal static bool smethod_1(Type type_0)
        {
            return ((typeof(IConvertible).IsAssignableFrom(type_0) || (Class194.smethod_10(type_0) && typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(type_0)))) && !typeof(JToken).IsAssignableFrom(type_0));
        }

        internal static bool smethod_2(Type type_0)
        {
            TypeConverter converter = Class181.smethod_13(type_0);
            if (((((converter == null) || (converter is ComponentConverter)) || ((converter is ReferenceConverter) || (converter.GetType() == typeof(TypeConverter)))) || !converter.CanConvertTo(typeof(string))) && (!(type_0 == typeof(Type)) && !type_0.IsSubclassOf(typeof(Type))))
            {
                return false;
            }
            return true;
        }

        private static bool smethod_3(MethodInfo methodInfo_0, ParameterInfo[] parameterInfo_0, Type type_0, MethodInfo methodInfo_1, ref Type type_1)
        {
            if (!methodInfo_0.IsDefined(type_0, false))
            {
                return false;
            }
            if (methodInfo_1 != null)
            {
                throw new JsonException("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".smethod_3(CultureInfo.InvariantCulture, new object[] { methodInfo_0, methodInfo_1, smethod_4(methodInfo_0.DeclaringType), type_0 }));
            }
            if (type_1 != null)
            {
                throw new JsonException("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".smethod_3(CultureInfo.InvariantCulture, new object[] { type_1, type_0, smethod_4(methodInfo_0.DeclaringType), methodInfo_0 }));
            }
            if (methodInfo_0.IsVirtual)
            {
                throw new JsonException("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".smethod_2(CultureInfo.InvariantCulture, methodInfo_0, smethod_4(methodInfo_0.DeclaringType), type_0));
            }
            if (methodInfo_0.ReturnType != typeof(void))
            {
                throw new JsonException("Serialization Callback '{1}' in type '{0}' must return void.".smethod_1(CultureInfo.InvariantCulture, smethod_4(methodInfo_0.DeclaringType), methodInfo_0));
            }
            if (type_0 == typeof(OnErrorAttribute))
            {
                if (((parameterInfo_0 == null) || (parameterInfo_0.Length != 2)) || ((parameterInfo_0[0].ParameterType != typeof(StreamingContext)) || (parameterInfo_0[1].ParameterType != typeof(ErrorContext))))
                {
                    throw new JsonException("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".smethod_3(CultureInfo.InvariantCulture, new object[] { smethod_4(methodInfo_0.DeclaringType), methodInfo_0, typeof(StreamingContext), typeof(ErrorContext) }));
                }
            }
            else if (((parameterInfo_0 == null) || (parameterInfo_0.Length != 1)) || (parameterInfo_0[0].ParameterType != typeof(StreamingContext)))
            {
                throw new JsonException("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".smethod_2(CultureInfo.InvariantCulture, smethod_4(methodInfo_0.DeclaringType), methodInfo_0, typeof(StreamingContext)));
            }
            type_1 = type_0;
            return true;
        }

        internal static string smethod_4(Type type_0)
        {
            if (!type_0.smethod_5() && type_0.smethod_2())
            {
                return string.Format(CultureInfo.InvariantCulture, "{0}.{1}", new object[] { type_0.Namespace, type_0.Name });
            }
            return type_0.FullName;
        }

        [CompilerGenerated]
        private static bool smethod_5(MemberInfo memberInfo_0)
        {
            return !Class194.smethod_21(memberInfo_0);
        }

        [CompilerGenerated]
        private static bool smethod_6(MemberInfo memberInfo_0)
        {
            return !Class194.smethod_21(memberInfo_0);
        }

        [CompilerGenerated]
        private static bool smethod_7(ConstructorInfo constructorInfo_0)
        {
            return constructorInfo_0.IsDefined(typeof(JsonConstructorAttribute), true);
        }

        [CompilerGenerated]
        private static int smethod_8(JsonProperty jsonProperty_0)
        {
            int? order = jsonProperty_0.Order;
            if (!order.HasValue)
            {
                return -1;
            }
            return order.GetValueOrDefault();
        }

        public BindingFlags DefaultMembersSearchFlags
        {
            [CompilerGenerated]
            get
            {
                return this.bindingFlags_0;
            }
            [CompilerGenerated]
            set
            {
                this.bindingFlags_0 = value;
            }
        }

        public bool DynamicCodeGeneration
        {
            get
            {
                return Class139.Boolean_0;
            }
        }

        internal static IContractResolver IContractResolver_0
        {
            get
            {
                return icontractResolver_0;
            }
        }

        public bool IgnoreSerializableAttribute
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

        public bool IgnoreSerializableInterface
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

        public bool SerializeCompilerGeneratedMembers
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

        [CompilerGenerated]
        private sealed class Class126
        {
            public Action<object, object> action_0;
            public Delegate3<object, object> delegate3_0;
            public Func<object, object> func_0;
            public Func<object> func_1;

            public void method_0(object object_0, string string_0, JToken jtoken_0)
            {
                object obj2 = this.func_0(object_0);
                if (obj2 == null)
                {
                    obj2 = this.func_1();
                    this.action_0(object_0, obj2);
                }
                this.delegate3_0(obj2, new object[] { string_0, jtoken_0 });
            }
        }

        [CompilerGenerated]
        private sealed class Class127
        {
            public Delegate3<object, object> delegate3_0;

            public object method_0(object[] object_0)
            {
                return this.delegate3_0(null, object_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class128
        {
            public Delegate3<object, object> delegate3_0;

            public bool method_0(object object_0)
            {
                return (bool) this.delegate3_0(object_0, new object[0]);
            }
        }

        [CompilerGenerated]
        private sealed class Class129
        {
            public Func<object, object> func_0;

            public bool method_0(object object_0)
            {
                return (bool) this.func_0(object_0);
            }
        }
    }
}

