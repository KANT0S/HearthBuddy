namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using ns20;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class JsonArrayContract : JsonContainerContract
    {
        [CompilerGenerated]
        private bool bool_10;
        private readonly bool bool_7;
        [CompilerGenerated]
        private bool bool_8;
        [CompilerGenerated]
        private bool bool_9;
        [CompilerGenerated]
        private ConstructorInfo constructorInfo_0;
        private Delegate3<object, object> delegate3_0;
        private Func<object> func_1;
        private readonly Type type_3;
        private Type type_4;
        [CompilerGenerated]
        private Type type_5;

        public JsonArrayContract(Type underlyingType) : base(underlyingType)
        {
            bool flag;
            base.enum15_0 = Enum15.Array;
            if (base.CreatedType.IsArray)
            {
                this.CollectionItemType = Class194.smethod_18(base.UnderlyingType);
                base.bool_4 = true;
                this.type_3 = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
                flag = true;
                this.IsMultidimensionalArray = base.UnderlyingType.IsArray && (base.UnderlyingType.GetArrayRank() > 1);
            }
            else if (typeof(IList).IsAssignableFrom(underlyingType))
            {
                if (Class194.smethod_14(underlyingType, typeof(ICollection<>), out this.type_3))
                {
                    this.CollectionItemType = this.type_3.GetGenericArguments()[0];
                }
                else
                {
                    this.CollectionItemType = Class194.smethod_18(underlyingType);
                }
                if (underlyingType == typeof(IList))
                {
                    base.CreatedType = typeof(List<object>);
                }
                if (this.CollectionItemType != null)
                {
                    this.ConstructorInfo_0 = Class191.smethod_3(underlyingType, this.CollectionItemType);
                }
                base.bool_4 = Class194.smethod_15(underlyingType, typeof(ReadOnlyCollection<>));
                flag = true;
            }
            else if (Class194.smethod_14(underlyingType, typeof(ICollection<>), out this.type_3))
            {
                this.CollectionItemType = this.type_3.GetGenericArguments()[0];
                if (Class194.smethod_12(underlyingType, typeof(ICollection<>)) || Class194.smethod_12(underlyingType, typeof(IList<>)))
                {
                    base.CreatedType = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
                }
                if (Class194.smethod_12(underlyingType, typeof(ISet<>)))
                {
                    base.CreatedType = typeof(HashSet<>).MakeGenericType(new Type[] { this.CollectionItemType });
                }
                this.ConstructorInfo_0 = Class191.smethod_3(underlyingType, this.CollectionItemType);
                flag = true;
                this.Boolean_0 = true;
            }
            else
            {
                Type type;
                if (Class194.smethod_14(underlyingType, typeof(IEnumerable<>), out type))
                {
                    this.CollectionItemType = type.GetGenericArguments()[0];
                    if (Class194.smethod_12(base.UnderlyingType, typeof(IEnumerable<>)))
                    {
                        base.CreatedType = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
                    }
                    this.ConstructorInfo_0 = Class191.smethod_3(underlyingType, this.CollectionItemType);
                    if (underlyingType.smethod_4() && (underlyingType.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
                    {
                        this.type_3 = type;
                        base.bool_4 = false;
                        this.Boolean_0 = false;
                        flag = true;
                    }
                    else
                    {
                        this.type_3 = typeof(List<>).MakeGenericType(new Type[] { this.CollectionItemType });
                        base.bool_4 = true;
                        this.Boolean_0 = true;
                        flag = this.ConstructorInfo_0 != null;
                    }
                }
                else
                {
                    flag = false;
                    this.Boolean_0 = true;
                }
            }
            this.Boolean_1 = flag;
            if (this.CollectionItemType != null)
            {
                this.bool_7 = Class194.smethod_10(this.CollectionItemType);
            }
        }

        internal Interface15 method_5(object object_0)
        {
            if (this.delegate3_0 == null)
            {
                Type type;
                this.type_4 = typeof(Class183<>).MakeGenericType(new Type[] { this.CollectionItemType });
                if (!Class194.smethod_15(this.type_3, typeof(List<>)) && !(this.type_3.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
                {
                    type = this.type_3;
                }
                else
                {
                    type = typeof(ICollection<>).MakeGenericType(new Type[] { this.CollectionItemType });
                }
                ConstructorInfo constructor = this.type_4.GetConstructor(new Type[] { type });
                this.delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(constructor);
            }
            return (Interface15) this.delegate3_0(null, new object[] { object_0 });
        }

        internal IList method_6()
        {
            if (this.func_1 == null)
            {
                Type type = this.IsMultidimensionalArray ? typeof(object) : this.CollectionItemType;
                Type type2 = typeof(List<>).MakeGenericType(new Type[] { type });
                this.func_1 = Class139.Class166_0.ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<object>(type2);
            }
            return (IList) this.func_1();
        }

        internal bool Boolean_0
        {
            [CompilerGenerated]
            get
            {
                return this.bool_9;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_9 = value;
            }
        }

        internal bool Boolean_1
        {
            [CompilerGenerated]
            get
            {
                return this.bool_10;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_10 = value;
            }
        }

        public Type CollectionItemType
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

        public bool IsMultidimensionalArray
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
    }
}

