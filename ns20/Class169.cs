namespace ns20
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal class Class169 : Class166
    {
        private static readonly Class169 class169_0 = new Class169();

        public override Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(FieldInfo fieldInfo_0)
        {
            Class176<T> class2 = new Class176<T> {
                fieldInfo_0 = fieldInfo_0
            };
            Class203.smethod_2(class2.fieldInfo_0, "fieldInfo");
            return new Action<T, object>(class2.method_0);
        }

        public override Delegate3<T, object> ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<T>(MethodBase methodBase_0)
        {
            Class172<T> class2 = new Class172<T> {
                methodBase_0 = methodBase_0
            };
            Class203.smethod_2(class2.methodBase_0, "method");
            class2.constructorInfo_0 = class2.methodBase_0 as ConstructorInfo;
            if (class2.constructorInfo_0 != null)
            {
                return new Delegate3<T, object>(class2.method_0);
            }
            return new Delegate3<T, object>(class2.method_1);
        }

        public override Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(PropertyInfo propertyInfo_0)
        {
            Class177<T> class2 = new Class177<T> {
                propertyInfo_0 = propertyInfo_0
            };
            Class203.smethod_2(class2.propertyInfo_0, "propertyInfo");
            return new Action<T, object>(class2.method_0);
        }

        public override Func<T> ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<T>(Type type_0)
        {
            Class173<T> class2 = new Class173<T> {
                type_0 = type_0
            };
            Class203.smethod_2(class2.type_0, "type");
            if (class2.type_0.smethod_12())
            {
                return new Func<T>(class2.method_0);
            }
            class2.constructorInfo_0 = Class194.smethod_8(class2.type_0, true);
            return new Func<T>(class2.method_1);
        }

        public override Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(FieldInfo fieldInfo_0)
        {
            Class175<T> class2 = new Class175<T> {
                fieldInfo_0 = fieldInfo_0
            };
            Class203.smethod_2(class2.fieldInfo_0, "fieldInfo");
            return new Func<T, object>(class2.method_0);
        }

        public override Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(PropertyInfo propertyInfo_0)
        {
            Class174<T> class2 = new Class174<T> {
                propertyInfo_0 = propertyInfo_0
            };
            Class203.smethod_2(class2.propertyInfo_0, "propertyInfo");
            return new Func<T, object>(class2.method_0);
        }

        internal static Class166 Class166_0
        {
            get
            {
                return class169_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class172<T>
        {
            public ConstructorInfo constructorInfo_0;
            public MethodBase methodBase_0;

            public object method_0(T gparam_0, object[] object_0)
            {
                return this.constructorInfo_0.Invoke(object_0);
            }

            public object method_1(T gparam_0, object[] object_0)
            {
                return this.methodBase_0.Invoke(gparam_0, object_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class173<T>
        {
            public ConstructorInfo constructorInfo_0;
            public Type type_0;

            public T method_0()
            {
                return (T) Activator.CreateInstance(this.type_0);
            }

            public T method_1()
            {
                return (T) this.constructorInfo_0.Invoke(null);
            }
        }

        [CompilerGenerated]
        private sealed class Class174<T>
        {
            public PropertyInfo propertyInfo_0;

            public object method_0(T gparam_0)
            {
                return this.propertyInfo_0.GetValue(gparam_0, null);
            }
        }

        [CompilerGenerated]
        private sealed class Class175<T>
        {
            public FieldInfo fieldInfo_0;

            public object method_0(T gparam_0)
            {
                return this.fieldInfo_0.GetValue(gparam_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class176<T>
        {
            public FieldInfo fieldInfo_0;

            public void method_0(T gparam_0, object object_0)
            {
                this.fieldInfo_0.SetValue(gparam_0, object_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class177<T>
        {
            public PropertyInfo propertyInfo_0;

            public void method_0(T gparam_0, object object_0)
            {
                this.propertyInfo_0.SetValue(gparam_0, object_0, null);
            }
        }
    }
}

