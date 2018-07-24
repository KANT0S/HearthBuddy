namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class JsonDictionaryContract : JsonContainerContract
    {
        private readonly bool bool_7;
        [CompilerGenerated]
        private bool bool_8;
        [CompilerGenerated]
        private ConstructorInfo constructorInfo_0;
        private Delegate3<object, object> delegate3_0;
        private Func<object> func_1;
        [CompilerGenerated]
        private Func<string, string> func_2;
        [CompilerGenerated]
        private JsonContract jsonContract_2;
        private readonly Type type_3;
        private Type type_4;
        [CompilerGenerated]
        private Type type_5;
        [CompilerGenerated]
        private Type type_6;

        public JsonDictionaryContract(Type underlyingType) : base(underlyingType)
        {
            Type type;
            Type type2;
            base.enum15_0 = Enum15.Dictionary;
            if (Class194.smethod_14(underlyingType, typeof(IDictionary<,>), out this.type_3))
            {
                type = this.type_3.GetGenericArguments()[0];
                type2 = this.type_3.GetGenericArguments()[1];
                if (Class194.smethod_12(base.UnderlyingType, typeof(IDictionary<,>)))
                {
                    base.CreatedType = typeof(Dictionary<,>).MakeGenericType(new Type[] { type, type2 });
                }
            }
            else
            {
                Class194.smethod_19(base.UnderlyingType, out type, out type2);
                if (base.UnderlyingType == typeof(IDictionary))
                {
                    base.CreatedType = typeof(Dictionary<object, object>);
                }
            }
            if ((type != null) && (type2 != null))
            {
                this.ConstructorInfo_0 = Class191.smethod_3(base.CreatedType, typeof(KeyValuePair<,>).MakeGenericType(new Type[] { type, type2 }));
            }
            this.Boolean_0 = !typeof(IDictionary).IsAssignableFrom(base.CreatedType);
            this.DictionaryKeyType = type;
            this.DictionaryValueType = type2;
            if (this.DictionaryValueType != null)
            {
                this.bool_7 = Class194.smethod_10(this.DictionaryValueType);
            }
        }

        internal Interface16 method_5(object object_0)
        {
            if (this.delegate3_0 == null)
            {
                this.type_4 = typeof(Class185<,>).MakeGenericType(new Type[] { this.DictionaryKeyType, this.DictionaryValueType });
                ConstructorInfo constructor = this.type_4.GetConstructor(new Type[] { this.type_3 });
                this.delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(constructor);
            }
            return (Interface16) this.delegate3_0(null, new object[] { object_0 });
        }

        internal IDictionary method_6()
        {
            if (this.func_1 == null)
            {
                Type type = typeof(Dictionary<,>).MakeGenericType(new Type[] { this.DictionaryKeyType, this.DictionaryValueType });
                this.func_1 = Class139.Class166_0.ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<object>(type);
            }
            return (IDictionary) this.func_1();
        }

        internal bool Boolean_0
        {
            [CompilerGenerated]
            get
            {
                return this.bool_8;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_8 = value;
            }
        }

        internal ConstructorInfo ConstructorInfo_0
        {
            [CompilerGenerated]
            get
            {
                return this.constructorInfo_0;
            }
            [CompilerGenerated]
            private set
            {
                this.constructorInfo_0 = value;
            }
        }

        public Type DictionaryKeyType
        {
            [CompilerGenerated]
            get
            {
                return this.type_5;
            }
            [CompilerGenerated]
            private set
            {
                this.type_5 = value;
            }
        }

        public Type DictionaryValueType
        {
            [CompilerGenerated]
            get
            {
                return this.type_6;
            }
            [CompilerGenerated]
            private set
            {
                this.type_6 = value;
            }
        }

        internal JsonContract JsonContract_2
        {
            [CompilerGenerated]
            get
            {
                return this.jsonContract_2;
            }
            [CompilerGenerated]
            set
            {
                this.jsonContract_2 = value;
            }
        }

        public Func<string, string> PropertyNameResolver
        {
            [CompilerGenerated]
            get
            {
                return this.func_2;
            }
            [CompilerGenerated]
            set
            {
                this.func_2 = value;
            }
        }
    }
}

