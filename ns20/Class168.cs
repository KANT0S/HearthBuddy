namespace ns20
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal class Class168 : Class166
    {
        private static readonly Class168 class168_0 = new Class168();

        private Expression method_2(Expression expression_0, Type type_0)
        {
            Type type = expression_0.Type;
            if ((type == type_0) || (!type.smethod_12() && type_0.IsAssignableFrom(type)))
            {
                return expression_0;
            }
            return Expression.Convert(expression_0, type_0);
        }

        public override Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(FieldInfo fieldInfo_0)
        {
            ParameterExpression expression;
            ParameterExpression expression2;
            Expression expression3;
            Class203.smethod_2(fieldInfo_0, "fieldInfo");
            if (fieldInfo_0.DeclaringType.smethod_12() || fieldInfo_0.IsInitOnly)
            {
                return Class169.Class166_0.ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(fieldInfo_0);
            }
            if (fieldInfo_0.IsStatic)
            {
                expression3 = Expression.Field(null, fieldInfo_0);
            }
            else
            {
                expression3 = Expression.Field(this.method_2(expression = Expression.Parameter(typeof(T), "source"), fieldInfo_0.DeclaringType), fieldInfo_0);
            }
            Expression right = this.method_2(expression2 = Expression.Parameter(typeof(object), "value"), expression3.Type);
            BinaryExpression body = Expression.Assign(expression3, right);
            return (Action<T, object>) Expression.Lambda(typeof(Action<T, object>), body, new ParameterExpression[] { expression, expression2 }).Compile();
        }

        public override Delegate3<T, object> ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<T>(MethodBase methodBase_0)
        {
            ParameterExpression expression2;
            Expression expression5;
            Class203.smethod_2(methodBase_0, "method");
            Type type = typeof(object);
            ParameterExpression expression = Expression.Parameter(type, "target");
            ParameterInfo[] parameters = methodBase_0.GetParameters();
            Expression[] arguments = new Expression[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                Expression index = Expression.Constant(i);
                Expression expression4 = Expression.ArrayIndex(expression2 = Expression.Parameter(typeof(object[]), "args"), index);
                arguments[i] = this.method_2(expression4, parameters[i].ParameterType);
            }
            if (methodBase_0.IsConstructor)
            {
                expression5 = Expression.New((ConstructorInfo) methodBase_0, arguments);
            }
            else if (methodBase_0.IsStatic)
            {
                expression5 = Expression.Call((MethodInfo) methodBase_0, arguments);
            }
            else
            {
                expression5 = Expression.Call(this.method_2(expression, methodBase_0.DeclaringType), (MethodInfo) methodBase_0, arguments);
            }
            if (methodBase_0 is MethodInfo)
            {
                MethodInfo info = (MethodInfo) methodBase_0;
                if (info.ReturnType != typeof(void))
                {
                    expression5 = this.method_2(expression5, type);
                }
                else
                {
                    expression5 = Expression.Block(expression5, Expression.Constant(null));
                }
            }
            return (Delegate3<T, object>) Expression.Lambda(typeof(Delegate3<T, object>), expression5, new ParameterExpression[] { expression, expression2 }).Compile();
        }

        public override Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(PropertyInfo propertyInfo_0)
        {
            Expression expression4;
            Class203.smethod_2(propertyInfo_0, "propertyInfo");
            if (propertyInfo_0.DeclaringType.smethod_12())
            {
                return Class169.Class166_0.ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(propertyInfo_0);
            }
            Type type = typeof(T);
            Type type2 = typeof(object);
            ParameterExpression expression = Expression.Parameter(type, "instance");
            ParameterExpression expression2 = Expression.Parameter(type2, "value");
            Expression expression3 = this.method_2(expression2, propertyInfo_0.PropertyType);
            MethodInfo setMethod = propertyInfo_0.GetSetMethod(true);
            if (setMethod.IsStatic)
            {
                expression4 = Expression.Call(setMethod, expression3);
            }
            else
            {
                expression4 = Expression.Call(this.method_2(expression, propertyInfo_0.DeclaringType), setMethod, new Expression[] { expression3 });
            }
            return (Action<T, object>) Expression.Lambda(typeof(Action<T, object>), expression4, new ParameterExpression[] { expression, expression2 }).Compile();
        }

        public override Func<T> ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<T>(Type type_0)
        {
            Func<T> func2 = null;
            Class170<T> class2 = new Class170<T> {
                type_0 = type_0
            };
            Class203.smethod_2(class2.type_0, "type");
            if (class2.type_0.smethod_10())
            {
                return new Func<T>(class2.method_0);
            }
            try
            {
                Type type = typeof(T);
                Expression expression = Expression.New(class2.type_0);
                expression = this.method_2(expression, type);
                return (Func<T>) Expression.Lambda(typeof(Func<T>), expression, new ParameterExpression[0]).Compile();
            }
            catch
            {
                if (func2 == null)
                {
                    func2 = new Func<T>(class2.method_1);
                }
                return func2;
            }
        }

        public override Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(FieldInfo fieldInfo_0)
        {
            ParameterExpression expression;
            Expression expression2;
            Class203.smethod_2(fieldInfo_0, "fieldInfo");
            if (fieldInfo_0.IsStatic)
            {
                expression2 = Expression.Field(null, fieldInfo_0);
            }
            else
            {
                expression2 = Expression.Field(this.method_2(expression = Expression.Parameter(typeof(T), "source"), fieldInfo_0.DeclaringType), fieldInfo_0);
            }
            return Expression.Lambda<Func<T, object>>(this.method_2(expression2, typeof(object)), new ParameterExpression[] { expression }).Compile();
        }

        public override Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(PropertyInfo propertyInfo_0)
        {
            Expression expression2;
            Class203.smethod_2(propertyInfo_0, "propertyInfo");
            Type type = typeof(T);
            Type type2 = typeof(object);
            ParameterExpression expression = Expression.Parameter(type, "instance");
            if (propertyInfo_0.GetGetMethod(true).IsStatic)
            {
                expression2 = Expression.MakeMemberAccess(null, propertyInfo_0);
            }
            else
            {
                expression2 = Expression.MakeMemberAccess(this.method_2(expression, propertyInfo_0.DeclaringType), propertyInfo_0);
            }
            expression2 = this.method_2(expression2, type2);
            return (Func<T, object>) Expression.Lambda(typeof(Func<T, object>), expression2, new ParameterExpression[] { expression }).Compile();
        }

        internal static Class166 Class166_0
        {
            get
            {
                return class168_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class170<T>
        {
            public Type type_0;

            public T method_0()
            {
                return (T) Activator.CreateInstance(this.type_0);
            }

            public T method_1()
            {
                return (T) Activator.CreateInstance(this.type_0);
            }
        }
    }
}

