namespace ns20
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Reflection.Emit;

    internal class Class167 : Class166
    {
        public static Class167 class167_0 = new Class167();

        private void method_2(MethodBase methodBase_0, ILGenerator ilgenerator_0)
        {
            ParameterInfo[] parameters = methodBase_0.GetParameters();
            Label label = ilgenerator_0.DefineLabel();
            ilgenerator_0.Emit(OpCodes.Ldarg_1);
            ilgenerator_0.Emit(OpCodes.Ldlen);
            ilgenerator_0.Emit(OpCodes.Ldc_I4, parameters.Length);
            ilgenerator_0.Emit(OpCodes.Beq, label);
            ilgenerator_0.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(Class194.type_0));
            ilgenerator_0.Emit(OpCodes.Throw);
            ilgenerator_0.MarkLabel(label);
            if (!methodBase_0.IsConstructor && !methodBase_0.IsStatic)
            {
                ilgenerator_0.smethod_0(methodBase_0.DeclaringType);
            }
            for (int i = 0; i < parameters.Length; i++)
            {
                ilgenerator_0.Emit(OpCodes.Ldarg_1);
                ilgenerator_0.Emit(OpCodes.Ldc_I4, i);
                ilgenerator_0.Emit(OpCodes.Ldelem_Ref);
                ilgenerator_0.smethod_2(parameters[i].ParameterType);
            }
            if (methodBase_0.IsConstructor)
            {
                ilgenerator_0.Emit(OpCodes.Newobj, (ConstructorInfo) methodBase_0);
            }
            else if (methodBase_0.IsFinal || !methodBase_0.IsVirtual)
            {
                ilgenerator_0.smethod_3((MethodInfo) methodBase_0);
            }
            Type type = methodBase_0.IsConstructor ? methodBase_0.DeclaringType : ((MethodInfo) methodBase_0).ReturnType;
            if (type != typeof(void))
            {
                ilgenerator_0.smethod_1(type);
            }
            else
            {
                ilgenerator_0.Emit(OpCodes.Ldnull);
            }
            ilgenerator_0.smethod_4();
        }

        private void method_3(Type type_0, ILGenerator ilgenerator_0)
        {
            if (type_0.smethod_12())
            {
                ilgenerator_0.DeclareLocal(type_0);
                ilgenerator_0.Emit(OpCodes.Ldloc_0);
                ilgenerator_0.Emit(OpCodes.Box, type_0);
            }
            else
            {
                ConstructorInfo con = type_0.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Class194.type_0, null);
                if (con == null)
                {
                    throw new ArgumentException("Could not get constructor for {0}.".smethod_0(CultureInfo.InvariantCulture, type_0));
                }
                ilgenerator_0.Emit(OpCodes.Newobj, con);
            }
            ilgenerator_0.smethod_4();
        }

        private void method_4(PropertyInfo propertyInfo_0, ILGenerator ilgenerator_0)
        {
            MethodInfo getMethod = propertyInfo_0.GetGetMethod(true);
            if (getMethod == null)
            {
                throw new ArgumentException("Property '{0}' does not have a getter.".smethod_0(CultureInfo.InvariantCulture, propertyInfo_0.Name));
            }
            if (!getMethod.IsStatic)
            {
                ilgenerator_0.smethod_0(propertyInfo_0.DeclaringType);
            }
            ilgenerator_0.smethod_3(getMethod);
            ilgenerator_0.smethod_1(propertyInfo_0.PropertyType);
            ilgenerator_0.smethod_4();
        }

        private void method_5(FieldInfo fieldInfo_0, ILGenerator ilgenerator_0)
        {
            if (!fieldInfo_0.IsStatic)
            {
                ilgenerator_0.smethod_0(fieldInfo_0.DeclaringType);
            }
            ilgenerator_0.Emit(OpCodes.Ldfld, fieldInfo_0);
            ilgenerator_0.smethod_1(fieldInfo_0.FieldType);
            ilgenerator_0.smethod_4();
        }

        public override Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(FieldInfo fieldInfo_0)
        {
            DynamicMethod method = smethod_0("Set" + fieldInfo_0.Name, null, new Type[] { typeof(T), typeof(object) }, fieldInfo_0.DeclaringType);
            ILGenerator iLGenerator = method.GetILGenerator();
            smethod_1(fieldInfo_0, iLGenerator);
            return (Action<T, object>) method.CreateDelegate(typeof(Action<T, object>));
        }

        public override Delegate3<T, object> ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<T>(MethodBase methodBase_0)
        {
            DynamicMethod method = smethod_0(methodBase_0.ToString(), typeof(object), new Type[] { typeof(object), typeof(object[]) }, methodBase_0.DeclaringType);
            ILGenerator iLGenerator = method.GetILGenerator();
            this.method_2(methodBase_0, iLGenerator);
            return (Delegate3<T, object>) method.CreateDelegate(typeof(Delegate3<T, object>));
        }

        public override Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(PropertyInfo propertyInfo_0)
        {
            DynamicMethod method = smethod_0("Set" + propertyInfo_0.Name, null, new Type[] { typeof(T), typeof(object) }, propertyInfo_0.DeclaringType);
            ILGenerator iLGenerator = method.GetILGenerator();
            smethod_2(propertyInfo_0, iLGenerator);
            return (Action<T, object>) method.CreateDelegate(typeof(Action<T, object>));
        }

        public override Func<T> ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<T>(Type type_0)
        {
            DynamicMethod method = smethod_0("Create" + type_0.FullName, typeof(T), Class194.type_0, type_0);
            method.InitLocals = true;
            ILGenerator iLGenerator = method.GetILGenerator();
            this.method_3(type_0, iLGenerator);
            return (Func<T>) method.CreateDelegate(typeof(Func<T>));
        }

        public override Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(FieldInfo fieldInfo_0)
        {
            DynamicMethod method = smethod_0("Get" + fieldInfo_0.Name, typeof(T), new Type[] { typeof(object) }, fieldInfo_0.DeclaringType);
            ILGenerator iLGenerator = method.GetILGenerator();
            this.method_5(fieldInfo_0, iLGenerator);
            return (Func<T, object>) method.CreateDelegate(typeof(Func<T, object>));
        }

        public override Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(PropertyInfo propertyInfo_0)
        {
            DynamicMethod method = smethod_0("Get" + propertyInfo_0.Name, typeof(T), new Type[] { typeof(object) }, propertyInfo_0.DeclaringType);
            ILGenerator iLGenerator = method.GetILGenerator();
            this.method_4(propertyInfo_0, iLGenerator);
            return (Func<T, object>) method.CreateDelegate(typeof(Func<T, object>));
        }

        private static DynamicMethod smethod_0(string string_0, Type type_0, Type[] type_1, Type type_2)
        {
            return (!type_2.smethod_3() ? new DynamicMethod(string_0, type_0, type_1, type_2, true) : new DynamicMethod(string_0, type_0, type_1, type_2.Module, true));
        }

        internal static void smethod_1(FieldInfo fieldInfo_0, ILGenerator ilgenerator_0)
        {
            if (!fieldInfo_0.IsStatic)
            {
                ilgenerator_0.smethod_0(fieldInfo_0.DeclaringType);
            }
            ilgenerator_0.Emit(OpCodes.Ldarg_1);
            ilgenerator_0.smethod_2(fieldInfo_0.FieldType);
            ilgenerator_0.Emit(OpCodes.Stfld, fieldInfo_0);
            ilgenerator_0.smethod_4();
        }

        internal static void smethod_2(PropertyInfo propertyInfo_0, ILGenerator ilgenerator_0)
        {
            MethodInfo setMethod = propertyInfo_0.GetSetMethod(true);
            if (!setMethod.IsStatic)
            {
                ilgenerator_0.smethod_0(propertyInfo_0.DeclaringType);
            }
            ilgenerator_0.Emit(OpCodes.Ldarg_1);
            ilgenerator_0.smethod_2(propertyInfo_0.PropertyType);
            ilgenerator_0.smethod_3(setMethod);
            ilgenerator_0.smethod_4();
        }
    }
}

