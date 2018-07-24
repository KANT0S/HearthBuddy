namespace Triton.Common
{
    using System;
    using System.Collections;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    public static class FastObjectFactory
    {
        private static readonly Hashtable hashtable_0 = Hashtable.Synchronized(new Hashtable());
        private static readonly Type type_0 = typeof(CreateObject);

        public static CreateObject CreateObjectFactory<T>()
        {
            return CreateObjectFactory(typeof(T));
        }

        public static CreateObject CreateObjectFactory(Type t)
        {
            CreateObject obj4;
            CreateObject obj2 = hashtable_0[t] as CreateObject;
            if (obj2 != null)
            {
                return obj2;
            }
            object syncRoot = hashtable_0.SyncRoot;
            lock (syncRoot)
            {
                obj2 = hashtable_0[t] as CreateObject;
                if (obj2 != null)
                {
                    return obj2;
                }
                Type[] parameterTypes = new Type[] { typeof(IntPtr) };
                DynamicMethod method = new DynamicMethod("DM$OBJ_FACTORY_" + t.Name, t, parameterTypes, true);
                ILGenerator iLGenerator = method.GetILGenerator();
                iLGenerator.Emit(OpCodes.Ldarg_0);
                Type[] types = new Type[] { typeof(IntPtr) };
                ConstructorInfo con = t.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, types, null);
                if (con == null)
                {
                    obj4 = null;
                }
                else
                {
                    iLGenerator.Emit(OpCodes.Newobj, con);
                    iLGenerator.Emit(OpCodes.Ret);
                    obj2 = (CreateObject) method.CreateDelegate(type_0);
                    hashtable_0.Add(t, obj2);
                    return obj2;
                }
            }
            return obj4;
        }

        public static T CreateObjectInstance<T>(IntPtr ptr)
        {
            return (T) CreateObjectFactory<T>()(ptr);
        }

        public delegate object CreateObject(IntPtr ptr);
    }
}

