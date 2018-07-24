namespace ns20
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal sealed class Class143<T> : DynamicMetaObject
    {
        private readonly bool bool_0;
        private readonly Class85<T> class85_0;
        private static readonly Expression[] expression_0;
        [CompilerGenerated]
        private static Func<DynamicMetaObject, UnaryExpression> func_0;

        static Class143()
        {
            Class143<T>.expression_0 = new Expression[0];
        }

        internal Class143(Expression expression, T value, Class85<T> proxy, bool dontFallbackFirst) : base(expression, BindingRestrictions.Empty, value)
        {
            this.class85_0 = proxy;
            this.bool_0 = dontFallbackFirst;
        }

        private bool method_0(string string_0)
        {
            return Class194.smethod_40(this.class85_0.GetType(), typeof(Class85<T>), string_0);
        }

        private DynamicMetaObject method_1(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_1, Delegate2<T> delegate2_0, Delegate2<T> delegate2_1 = null)
        {
            DynamicMetaObject obj2 = delegate2_0(null);
            DynamicMetaObject errorSuggestion = this.method_2(string_0, dynamicMetaObjectBinder_0, expression_1, obj2, delegate2_1);
            if (!this.bool_0)
            {
                return delegate2_0(errorSuggestion);
            }
            return errorSuggestion;
        }

        private DynamicMetaObject method_2(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_1, DynamicMetaObject dynamicMetaObject_0, Delegate2<T> delegate2_0)
        {
            ParameterExpression item = Expression.Parameter(typeof(object), null);
            IList<Expression> list = new List<Expression> {
                Expression.Convert(base.Expression, typeof(T)),
                Class143<T>.smethod_3(dynamicMetaObjectBinder_0)
            };
            list.smethod_1<Expression>(expression_1);
            list.Add(item);
            DynamicMetaObject errorSuggestion = new DynamicMetaObject(item, BindingRestrictions.Empty);
            if (dynamicMetaObjectBinder_0.ReturnType != typeof(object))
            {
                errorSuggestion = new DynamicMetaObject(Expression.Convert(errorSuggestion.Expression, dynamicMetaObjectBinder_0.ReturnType), errorSuggestion.Restrictions);
            }
            if (delegate2_0 != null)
            {
                errorSuggestion = delegate2_0(errorSuggestion);
            }
            return new DynamicMetaObject(Expression.Block(new ParameterExpression[] { item }, new Expression[] { Expression.Condition(Expression.Call(Expression.Constant(this.class85_0), typeof(Class85<T>).GetMethod(string_0), list), errorSuggestion.Expression, dynamicMetaObject_0.Expression, dynamicMetaObjectBinder_0.ReturnType) }), this.method_5().Merge(errorSuggestion.Restrictions).Merge(dynamicMetaObject_0.Restrictions));
        }

        private DynamicMetaObject method_3(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_1, Delegate2<T> delegate2_0)
        {
            DynamicMetaObject obj2 = delegate2_0(null);
            ParameterExpression left = Expression.Parameter(typeof(object), null);
            IList<Expression> list = new List<Expression> {
                Expression.Convert(base.Expression, typeof(T)),
                Class143<T>.smethod_3(dynamicMetaObjectBinder_0)
            };
            list.smethod_1<Expression>(expression_1);
            list[expression_1.Length + 1] = Expression.Assign(left, list[expression_1.Length + 1]);
            DynamicMetaObject errorSuggestion = new DynamicMetaObject(Expression.Block(new ParameterExpression[] { left }, new Expression[] { Expression.Condition(Expression.Call(Expression.Constant(this.class85_0), typeof(Class85<T>).GetMethod(string_0), list), left, obj2.Expression, typeof(object)) }), this.method_5().Merge(obj2.Restrictions));
            if (!this.bool_0)
            {
                return delegate2_0(errorSuggestion);
            }
            return errorSuggestion;
        }

        private DynamicMetaObject method_4(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_1, Delegate2<T> delegate2_0)
        {
            DynamicMetaObject obj2 = delegate2_0(null);
            IList<Expression> list = new List<Expression> {
                Expression.Convert(base.Expression, typeof(T)),
                Class143<T>.smethod_3(dynamicMetaObjectBinder_0)
            };
            list.smethod_1<Expression>(expression_1);
            DynamicMetaObject errorSuggestion = new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(this.class85_0), typeof(Class85<T>).GetMethod(string_0), list), Expression.Empty(), obj2.Expression, typeof(void)), this.method_5().Merge(obj2.Restrictions));
            if (!this.bool_0)
            {
                return delegate2_0(errorSuggestion);
            }
            return errorSuggestion;
        }

        private BindingRestrictions method_5()
        {
            if ((this.Prop_0 == null) && base.HasValue)
            {
                return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
            }
            return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
        }

        private static Expression[] smethod_0(params DynamicMetaObject[] dynamicMetaObject_0)
        {
            if (Class143<T>.func_0 == null)
            {
                Class143<T>.func_0 = new Func<DynamicMetaObject, UnaryExpression>(Class143<T>.smethod_4);
            }
            return dynamicMetaObject_0.Select<DynamicMetaObject, UnaryExpression>(Class143<T>.func_0).ToArray<UnaryExpression>();
        }

        private static Expression[] smethod_1(DynamicMetaObject[] dynamicMetaObject_0)
        {
            return new NewArrayExpression[] { Expression.NewArrayInit(typeof(object), Class143<T>.smethod_0(dynamicMetaObject_0)) };
        }

        private static Expression[] smethod_2(DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1)
        {
            return new Expression[] { Expression.NewArrayInit(typeof(object), Class143<T>.smethod_0(dynamicMetaObject_0)), Expression.Convert(dynamicMetaObject_1.Expression, typeof(object)) };
        }

        private static ConstantExpression smethod_3(DynamicMetaObjectBinder dynamicMetaObjectBinder_0)
        {
            Type type = dynamicMetaObjectBinder_0.GetType();
            while (!type.smethod_11())
            {
                type = type.smethod_6();
            }
            return Expression.Constant(dynamicMetaObjectBinder_0, type);
        }

        [CompilerGenerated]
        private static UnaryExpression smethod_4(DynamicMetaObject dynamicMetaObject_0)
        {
            return Expression.Convert(dynamicMetaObject_0.Expression, typeof(object));
        }

        DynamicMetaObject DynamicMetaObject.BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
        {
            Class152<T> class2 = new Class152<T> {
                binaryOperationBinder_0 = binder,
                dynamicMetaObject_0 = arg,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryBinaryOperation"))
            {
                return base.BindBinaryOperation(class2.binaryOperationBinder_0, class2.dynamicMetaObject_0);
            }
            return this.method_1("TryBinaryOperation", class2.binaryOperationBinder_0, Class143<T>.smethod_0(new DynamicMetaObject[] { class2.dynamicMetaObject_0 }), new Delegate2<T>(class2.method_0), null);
        }

        DynamicMetaObject DynamicMetaObject.BindConvert(ConvertBinder binder)
        {
            Class148<T> class2 = new Class148<T> {
                convertBinder_0 = binder,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryConvert"))
            {
                return base.BindConvert(class2.convertBinder_0);
            }
            return this.method_1("TryConvert", class2.convertBinder_0, Class143<T>.expression_0, new Delegate2<T>(class2.method_0), null);
        }

        DynamicMetaObject DynamicMetaObject.BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
        {
            Class150<T> class2 = new Class150<T> {
                createInstanceBinder_0 = binder,
                dynamicMetaObject_0 = args,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryCreateInstance"))
            {
                return base.BindCreateInstance(class2.createInstanceBinder_0, class2.dynamicMetaObject_0);
            }
            return this.method_1("TryCreateInstance", class2.createInstanceBinder_0, Class143<T>.smethod_1(class2.dynamicMetaObject_0), new Delegate2<T>(class2.method_0), null);
        }

        DynamicMetaObject DynamicMetaObject.BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
        {
            Class156<T> class2 = new Class156<T> {
                deleteIndexBinder_0 = binder,
                dynamicMetaObject_0 = indexes,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryDeleteIndex"))
            {
                return base.BindDeleteIndex(class2.deleteIndexBinder_0, class2.dynamicMetaObject_0);
            }
            return this.method_4("TryDeleteIndex", class2.deleteIndexBinder_0, Class143<T>.smethod_1(class2.dynamicMetaObject_0), new Delegate2<T>(class2.method_0));
        }

        DynamicMetaObject DynamicMetaObject.BindDeleteMember(DeleteMemberBinder binder)
        {
            Class147<T> class2 = new Class147<T> {
                deleteMemberBinder_0 = binder,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryDeleteMember"))
            {
                return base.BindDeleteMember(class2.deleteMemberBinder_0);
            }
            return this.method_4("TryDeleteMember", class2.deleteMemberBinder_0, Class143<T>.expression_0, new Delegate2<T>(class2.method_0));
        }

        DynamicMetaObject DynamicMetaObject.BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
        {
            Class154<T> class2 = new Class154<T> {
                getIndexBinder_0 = binder,
                dynamicMetaObject_0 = indexes,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryGetIndex"))
            {
                return base.BindGetIndex(class2.getIndexBinder_0, class2.dynamicMetaObject_0);
            }
            return this.method_1("TryGetIndex", class2.getIndexBinder_0, Class143<T>.smethod_1(class2.dynamicMetaObject_0), new Delegate2<T>(class2.method_0), null);
        }

        DynamicMetaObject DynamicMetaObject.BindGetMember(GetMemberBinder binder)
        {
            Class145<T> class2 = new Class145<T> {
                getMemberBinder_0 = binder,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryGetMember"))
            {
                return base.BindGetMember(class2.getMemberBinder_0);
            }
            return this.method_1("TryGetMember", class2.getMemberBinder_0, Class143<T>.expression_0, new Delegate2<T>(class2.method_0), null);
        }

        DynamicMetaObject DynamicMetaObject.BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
        {
            Class151<T> class2 = new Class151<T> {
                invokeBinder_0 = binder,
                dynamicMetaObject_0 = args,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryInvoke"))
            {
                return base.BindInvoke(class2.invokeBinder_0, class2.dynamicMetaObject_0);
            }
            return this.method_1("TryInvoke", class2.invokeBinder_0, Class143<T>.smethod_1(class2.dynamicMetaObject_0), new Delegate2<T>(class2.method_0), null);
        }

        DynamicMetaObject DynamicMetaObject.BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
        {
            Class149<T> class2 = new Class149<T> {
                invokeMemberBinder_0 = binder,
                dynamicMetaObject_0 = args,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryInvokeMember"))
            {
                return base.BindInvokeMember(class2.invokeMemberBinder_0, class2.dynamicMetaObject_0);
            }
            Delegate2<T> delegate2 = new Delegate2<T>(class2.method_0);
            DynamicMetaObject errorSuggestion = this.method_2("TryInvokeMember", class2.invokeMemberBinder_0, Class143<T>.smethod_1(class2.dynamicMetaObject_0), this.method_2("TryGetMember", new Class144<T>(class2.invokeMemberBinder_0), Class143<T>.expression_0, delegate2(null), new Delegate2<T>(class2.method_1)), null);
            if (!this.bool_0)
            {
                return delegate2(errorSuggestion);
            }
            return errorSuggestion;
        }

        DynamicMetaObject DynamicMetaObject.BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
        {
            Class155<T> class2 = new Class155<T> {
                setIndexBinder_0 = binder,
                dynamicMetaObject_0 = indexes,
                dynamicMetaObject_1 = value,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TrySetIndex"))
            {
                return base.BindSetIndex(class2.setIndexBinder_0, class2.dynamicMetaObject_0, class2.dynamicMetaObject_1);
            }
            return this.method_3("TrySetIndex", class2.setIndexBinder_0, Class143<T>.smethod_2(class2.dynamicMetaObject_0, class2.dynamicMetaObject_1), new Delegate2<T>(class2.method_0));
        }

        DynamicMetaObject DynamicMetaObject.BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
        {
            Class146<T> class2 = new Class146<T> {
                setMemberBinder_0 = binder,
                dynamicMetaObject_0 = value,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TrySetMember"))
            {
                return base.BindSetMember(class2.setMemberBinder_0, class2.dynamicMetaObject_0);
            }
            return this.method_3("TrySetMember", class2.setMemberBinder_0, Class143<T>.smethod_0(new DynamicMetaObject[] { class2.dynamicMetaObject_0 }), new Delegate2<T>(class2.method_0));
        }

        DynamicMetaObject DynamicMetaObject.BindUnaryOperation(UnaryOperationBinder binder)
        {
            Class153<T> class2 = new Class153<T> {
                unaryOperationBinder_0 = binder,
                class143_0 = (Class143<T>) this
            };
            if (!this.method_0("TryUnaryOperation"))
            {
                return base.BindUnaryOperation(class2.unaryOperationBinder_0);
            }
            return this.method_1("TryUnaryOperation", class2.unaryOperationBinder_0, Class143<T>.expression_0, new Delegate2<T>(class2.method_0), null);
        }

        IEnumerable<string> DynamicMetaObject.GetDynamicMemberNames()
        {
            return this.class85_0.ns20.Class85<Newtonsoft.Json.Linq.JObject>.‏‎‪‫⁭‫‎⁮‮⁮‏‭‌‍‎‬‍‪⁯‭‍‌‬‌​‬⁬‍⁭‫‮‮⁬‏‫‫‎‮⁬‮‮(this.Prop_0);
        }

        private T Prop_0
        {
            get
            {
                return (T) base.Value;
            }
        }

        private sealed class Class144 : GetMemberBinder
        {
            internal Class144(InvokeMemberBinder binder) : base(binder.Name, binder.IgnoreCase)
            {
            }

            DynamicMetaObject GetMemberBinder.FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
            {
                throw new NotSupportedException();
            }
        }

        [CompilerGenerated]
        private sealed class Class145
        {
            public Class143<T> class143_0;
            public GetMemberBinder getMemberBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
            {
                return this.getMemberBinder_0.FallbackGetMember(this.class143_0, dynamicMetaObject_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class146
        {
            public Class143<T> class143_0;
            public DynamicMetaObject dynamicMetaObject_0;
            public SetMemberBinder setMemberBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.setMemberBinder_0.FallbackSetMember(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }
        }

        [CompilerGenerated]
        private sealed class Class147
        {
            public Class143<T> class143_0;
            public DeleteMemberBinder deleteMemberBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
            {
                return this.deleteMemberBinder_0.FallbackDeleteMember(this.class143_0, dynamicMetaObject_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class148
        {
            public Class143<T> class143_0;
            public ConvertBinder convertBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
            {
                return this.convertBinder_0.FallbackConvert(this.class143_0, dynamicMetaObject_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class149
        {
            public Class143<T> class143_0;
            public DynamicMetaObject[] dynamicMetaObject_0;
            public InvokeMemberBinder invokeMemberBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.invokeMemberBinder_0.FallbackInvokeMember(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }

            public DynamicMetaObject method_1(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.invokeMemberBinder_0.FallbackInvoke(dynamicMetaObject_1, this.dynamicMetaObject_0, null);
            }
        }

        [CompilerGenerated]
        private sealed class Class150
        {
            public Class143<T> class143_0;
            public CreateInstanceBinder createInstanceBinder_0;
            public DynamicMetaObject[] dynamicMetaObject_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.createInstanceBinder_0.FallbackCreateInstance(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }
        }

        [CompilerGenerated]
        private sealed class Class151
        {
            public Class143<T> class143_0;
            public DynamicMetaObject[] dynamicMetaObject_0;
            public InvokeBinder invokeBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.invokeBinder_0.FallbackInvoke(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }
        }

        [CompilerGenerated]
        private sealed class Class152
        {
            public BinaryOperationBinder binaryOperationBinder_0;
            public Class143<T> class143_0;
            public DynamicMetaObject dynamicMetaObject_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.binaryOperationBinder_0.FallbackBinaryOperation(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }
        }

        [CompilerGenerated]
        private sealed class Class153
        {
            public Class143<T> class143_0;
            public UnaryOperationBinder unaryOperationBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
            {
                return this.unaryOperationBinder_0.FallbackUnaryOperation(this.class143_0, dynamicMetaObject_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class154
        {
            public Class143<T> class143_0;
            public DynamicMetaObject[] dynamicMetaObject_0;
            public GetIndexBinder getIndexBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.getIndexBinder_0.FallbackGetIndex(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }
        }

        [CompilerGenerated]
        private sealed class Class155
        {
            public Class143<T> class143_0;
            public DynamicMetaObject[] dynamicMetaObject_0;
            public DynamicMetaObject dynamicMetaObject_1;
            public SetIndexBinder setIndexBinder_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_2)
            {
                return this.setIndexBinder_0.FallbackSetIndex(this.class143_0, this.dynamicMetaObject_0, this.dynamicMetaObject_1, dynamicMetaObject_2);
            }
        }

        [CompilerGenerated]
        private sealed class Class156
        {
            public Class143<T> class143_0;
            public DeleteIndexBinder deleteIndexBinder_0;
            public DynamicMetaObject[] dynamicMetaObject_0;

            public DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
            {
                return this.deleteIndexBinder_0.FallbackDeleteIndex(this.class143_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
            }
        }

        private delegate DynamicMetaObject Delegate2(DynamicMetaObject errorSuggestion);
    }
}

