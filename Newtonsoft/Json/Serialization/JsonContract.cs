namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns16;
    using ns18;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    public abstract class JsonContract
    {
        internal bool bool_0;
        internal bool bool_1;
        internal bool bool_2;
        internal bool bool_3;
        internal bool bool_4;
        internal bool bool_5;
        [CompilerGenerated]
        private bool bool_6;
        internal Enum14 enum14_0;
        internal Enum15 enum15_0;
        [CompilerGenerated]
        private Func<object> func_0;
        private IList<SerializationCallback> ilist_0;
        private IList<SerializationCallback> ilist_1;
        private IList<SerializationCallback> ilist_2;
        private IList<SerializationErrorCallback> ilist_3;
        [CompilerGenerated]
        private JsonConverter jsonConverter_0;
        [CompilerGenerated]
        private JsonConverter jsonConverter_1;
        private List<SerializationCallback> list_0;
        [CompilerGenerated]
        private bool? nullable_0;
        internal Type type_0;
        [CompilerGenerated]
        private Type type_1;
        [CompilerGenerated]
        private Type type_2;

        internal JsonContract(Type underlyingType)
        {
            Class203.smethod_2(underlyingType, "underlyingType");
            this.UnderlyingType = underlyingType;
            this.bool_2 = underlyingType.smethod_9();
            this.bool_5 = !underlyingType.smethod_3() && !underlyingType.smethod_10();
            this.bool_0 = Class194.smethod_9(underlyingType);
            this.type_0 = (!this.bool_0 || !Class194.smethod_10(underlyingType)) ? underlyingType : Nullable.GetUnderlyingType(underlyingType);
            this.CreatedType = this.type_0;
            this.bool_1 = Class181.smethod_3(this.type_0);
            this.bool_3 = this.type_0.smethod_7();
            if (this.type_0 == typeof(byte[]))
            {
                this.enum14_0 = Enum14.ReadAsBytes;
            }
            else if (this.type_0 == typeof(int))
            {
                this.enum14_0 = Enum14.ReadAsInt32;
            }
            else if (this.type_0 == typeof(decimal))
            {
                this.enum14_0 = Enum14.ReadAsDecimal;
            }
            else if (this.type_0 == typeof(string))
            {
                this.enum14_0 = Enum14.ReadAsString;
            }
            else if (this.type_0 == typeof(DateTime))
            {
                this.enum14_0 = Enum14.ReadAsDateTime;
            }
            else if (this.type_0 == typeof(DateTimeOffset))
            {
                this.enum14_0 = Enum14.ReadAsDateTimeOffset;
            }
            else
            {
                this.enum14_0 = Enum14.Read;
            }
        }

        internal void method_0(object object_0, StreamingContext streamingContext_0)
        {
            if (this.ilist_2 != null)
            {
                foreach (SerializationCallback callback in this.ilist_2)
                {
                    callback(object_0, streamingContext_0);
                }
            }
        }

        internal void method_1(object object_0, StreamingContext streamingContext_0)
        {
            if (this.ilist_1 != null)
            {
                foreach (SerializationCallback callback in this.ilist_1)
                {
                    callback(object_0, streamingContext_0);
                }
            }
        }

        internal void method_2(object object_0, StreamingContext streamingContext_0)
        {
            if (this.ilist_0 != null)
            {
                foreach (SerializationCallback callback in this.ilist_0)
                {
                    callback(object_0, streamingContext_0);
                }
            }
        }

        internal void method_3(object object_0, StreamingContext streamingContext_0)
        {
            if (this.list_0 != null)
            {
                foreach (SerializationCallback callback in this.list_0)
                {
                    callback(object_0, streamingContext_0);
                }
            }
        }

        internal void method_4(object object_0, StreamingContext streamingContext_0, ErrorContext errorContext_0)
        {
            if (this.ilist_3 != null)
            {
                foreach (SerializationErrorCallback callback in this.ilist_3)
                {
                    callback(object_0, streamingContext_0, errorContext_0);
                }
            }
        }

        internal static SerializationCallback smethod_0(MethodInfo methodInfo_0)
        {
            Class83 class2 = new Class83 {
                methodInfo_0 = methodInfo_0
            };
            return new SerializationCallback(class2.method_0);
        }

        internal static SerializationErrorCallback smethod_1(MethodInfo methodInfo_0)
        {
            Class84 class2 = new Class84 {
                methodInfo_0 = methodInfo_0
            };
            return new SerializationErrorCallback(class2.method_0);
        }

        public JsonConverter Converter
        {
            [CompilerGenerated]
            get
            {
                return this.jsonConverter_0;
            }
            [CompilerGenerated]
            set
            {
                this.jsonConverter_0 = value;
            }
        }

        public Type CreatedType
        {
            [CompilerGenerated]
            get
            {
                return this.type_2;
            }
            [CompilerGenerated]
            set
            {
                this.type_2 = value;
            }
        }

        public Func<object> DefaultCreator
        {
            [CompilerGenerated]
            get
            {
                return this.func_0;
            }
            [CompilerGenerated]
            set
            {
                this.func_0 = value;
            }
        }

        public bool DefaultCreatorNonPublic
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

        public bool? IsReference
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

        internal JsonConverter JsonConverter_0
        {
            [CompilerGenerated]
            get
            {
                return this.jsonConverter_1;
            }
            [CompilerGenerated]
            set
            {
                this.jsonConverter_1 = value;
            }
        }

        [Obsolete("This property is obsolete and has been replaced by the OnDeserializedCallbacks collection.")]
        public MethodInfo OnDeserialized
        {
            get
            {
                if (this.OnDeserializedCallbacks.Count <= 0)
                {
                    return null;
                }
                return this.OnDeserializedCallbacks[0].smethod_0();
            }
            set
            {
                this.OnDeserializedCallbacks.Clear();
                this.OnDeserializedCallbacks.Add(smethod_0(value));
            }
        }

        public IList<SerializationCallback> OnDeserializedCallbacks
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<SerializationCallback>();
                }
                return this.list_0;
            }
        }

        [Obsolete("This property is obsolete and has been replaced by the OnDeserializingCallbacks collection.")]
        public MethodInfo OnDeserializing
        {
            get
            {
                if (this.OnDeserializingCallbacks.Count <= 0)
                {
                    return null;
                }
                return this.OnDeserializingCallbacks[0].smethod_0();
            }
            set
            {
                this.OnDeserializingCallbacks.Clear();
                this.OnDeserializingCallbacks.Add(smethod_0(value));
            }
        }

        public IList<SerializationCallback> OnDeserializingCallbacks
        {
            get
            {
                if (this.ilist_0 == null)
                {
                    this.ilist_0 = new List<SerializationCallback>();
                }
                return this.ilist_0;
            }
        }

        [Obsolete("This property is obsolete and has been replaced by the OnErrorCallbacks collection.")]
        public MethodInfo OnError
        {
            get
            {
                if (this.OnErrorCallbacks.Count <= 0)
                {
                    return null;
                }
                return this.OnErrorCallbacks[0].smethod_0();
            }
            set
            {
                this.OnErrorCallbacks.Clear();
                this.OnErrorCallbacks.Add(smethod_1(value));
            }
        }

        public IList<SerializationErrorCallback> OnErrorCallbacks
        {
            get
            {
                if (this.ilist_3 == null)
                {
                    this.ilist_3 = new List<SerializationErrorCallback>();
                }
                return this.ilist_3;
            }
        }

        [Obsolete("This property is obsolete and has been replaced by the OnSerializedCallbacks collection.")]
        public MethodInfo OnSerialized
        {
            get
            {
                if (this.OnSerializedCallbacks.Count <= 0)
                {
                    return null;
                }
                return this.OnSerializedCallbacks[0].smethod_0();
            }
            set
            {
                this.OnSerializedCallbacks.Clear();
                this.OnSerializedCallbacks.Add(smethod_0(value));
            }
        }

        public IList<SerializationCallback> OnSerializedCallbacks
        {
            get
            {
                if (this.ilist_1 == null)
                {
                    this.ilist_1 = new List<SerializationCallback>();
                }
                return this.ilist_1;
            }
        }

        [Obsolete("This property is obsolete and has been replaced by the OnSerializingCallbacks collection.")]
        public MethodInfo OnSerializing
        {
            get
            {
                if (this.OnSerializingCallbacks.Count <= 0)
                {
                    return null;
                }
                return this.OnSerializingCallbacks[0].smethod_0();
            }
            set
            {
                this.OnSerializingCallbacks.Clear();
                this.OnSerializingCallbacks.Add(smethod_0(value));
            }
        }

        public IList<SerializationCallback> OnSerializingCallbacks
        {
            get
            {
                if (this.ilist_2 == null)
                {
                    this.ilist_2 = new List<SerializationCallback>();
                }
                return this.ilist_2;
            }
        }

        public Type UnderlyingType
        {
            [CompilerGenerated]
            get
            {
                return this.type_1;
            }
            [CompilerGenerated]
            private set
            {
                this.type_1 = value;
            }
        }

        [CompilerGenerated]
        private sealed class Class83
        {
            public MethodInfo methodInfo_0;

            public void method_0(object object_0, StreamingContext streamingContext_0)
            {
                this.methodInfo_0.Invoke(object_0, new object[] { streamingContext_0 });
            }
        }

        [CompilerGenerated]
        private sealed class Class84
        {
            public MethodInfo methodInfo_0;

            public void method_0(object object_0, StreamingContext streamingContext_0, ErrorContext errorContext_0)
            {
                this.methodInfo_0.Invoke(object_0, new object[] { streamingContext_0, errorContext_0 });
            }
        }
    }
}

