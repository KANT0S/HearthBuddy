namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns16;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security;

    public class JsonObjectContract : JsonContainerContract
    {
        [CompilerGenerated]
        private ConstructorInfo constructorInfo_0;
        [CompilerGenerated]
        private ConstructorInfo constructorInfo_1;
        [CompilerGenerated]
        private Newtonsoft.Json.Serialization.ExtensionDataSetter extensionDataSetter_0;
        [CompilerGenerated]
        private JsonPropertyCollection jsonPropertyCollection_0;
        [CompilerGenerated]
        private JsonPropertyCollection jsonPropertyCollection_1;
        [CompilerGenerated]
        private Newtonsoft.Json.MemberSerialization memberSerialization_0;
        private bool? nullable_4;
        [CompilerGenerated]
        private Required? nullable_5;

        public JsonObjectContract(Type underlyingType) : base(underlyingType)
        {
            base.enum15_0 = Enum15.Object;
            this.Properties = new JsonPropertyCollection(base.UnderlyingType);
            this.ConstructorParameters = new JsonPropertyCollection(base.UnderlyingType);
        }

        [SecuritySafeCritical]
        internal object method_5()
        {
            if (!Class139.Boolean_1)
            {
                throw new JsonException("Insufficient permissions. Creating an uninitialized '{0}' type requires full trust.".smethod_0(CultureInfo.InvariantCulture, base.type_0));
            }
            return FormatterServices.GetUninitializedObject(base.type_0);
        }

        internal bool Boolean_0
        {
            get
            {
                if (!this.nullable_4.HasValue)
                {
                    this.nullable_4 = false;
                    if (((Required) this.ItemRequired.GetValueOrDefault(Required.Default)) != Required.Default)
                    {
                        this.nullable_4 = true;
                    }
                    else
                    {
                        using (IEnumerator<JsonProperty> enumerator = this.Properties.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                JsonProperty current = enumerator.Current;
                                if ((current.Required != Required.Default) || (((((DefaultValueHandling) current.DefaultValueHandling) & DefaultValueHandling.Populate) == DefaultValueHandling.Populate) && current.Writable))
                                {
                                    goto Label_00B0;
                                }
                            }
                            goto Label_00C8;
                        Label_00B0:
                            this.nullable_4 = true;
                        }
                    }
                }
            Label_00C8:
                return this.nullable_4.Value;
            }
        }

        public JsonPropertyCollection ConstructorParameters
        {
            [CompilerGenerated]
            get
            {
                return this.jsonPropertyCollection_1;
            }
            [CompilerGenerated]
            private set
            {
                this.jsonPropertyCollection_1 = value;
            }
        }

        public Newtonsoft.Json.Serialization.ExtensionDataSetter ExtensionDataSetter
        {
            [CompilerGenerated]
            get
            {
                return this.extensionDataSetter_0;
            }
            [CompilerGenerated]
            set
            {
                this.extensionDataSetter_0 = value;
            }
        }

        public Required? ItemRequired
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

        public Newtonsoft.Json.MemberSerialization MemberSerialization
        {
            [CompilerGenerated]
            get
            {
                return this.memberSerialization_0;
            }
            [CompilerGenerated]
            set
            {
                this.memberSerialization_0 = value;
            }
        }

        public ConstructorInfo OverrideConstructor
        {
            [CompilerGenerated]
            get
            {
                return this.constructorInfo_0;
            }
            [CompilerGenerated]
            set
            {
                this.constructorInfo_0 = value;
            }
        }

        public ConstructorInfo ParametrizedConstructor
        {
            [CompilerGenerated]
            get
            {
                return this.constructorInfo_1;
            }
            [CompilerGenerated]
            set
            {
                this.constructorInfo_1 = value;
            }
        }

        public JsonPropertyCollection Properties
        {
            [CompilerGenerated]
            get
            {
                return this.jsonPropertyCollection_0;
            }
            [CompilerGenerated]
            private set
            {
                this.jsonPropertyCollection_0 = value;
            }
        }
    }
}

