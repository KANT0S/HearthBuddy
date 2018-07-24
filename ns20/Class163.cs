namespace ns20
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Resources;

    internal static class Class163
    {
        private static readonly Class165 class165_0 = new Class165();
        private static ModuleBuilder moduleBuilder_0;
        private static readonly object object_0 = new object();

        private static void smethod_0()
        {
            if (moduleBuilder_0 == null)
            {
                lock (object_0)
                {
                    if (moduleBuilder_0 == null)
                    {
                        AssemblyName name = new AssemblyName("Newtonsoft.Json.Dynamic") {
                            KeyPair = new StrongNameKeyPair(smethod_1())
                        };
                        moduleBuilder_0 = AppDomain.CurrentDomain.DefineDynamicAssembly(name, AssemblyBuilderAccess.Run).DefineDynamicModule("Newtonsoft.Json.DynamicModule", false);
                    }
                }
            }
        }

        private static byte[] smethod_1()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Newtonsoft.Json.Dynamic.snk"))
            {
                if (stream == null)
                {
                    throw new MissingManifestResourceException("Should have Newtonsoft.Json.Dynamic.snk as an embedded resource.");
                }
                int length = (int) stream.Length;
                byte[] buffer = new byte[length];
                stream.Read(buffer, 0, length);
                return buffer;
            }
        }

        public static Type smethod_2(Type type_0, Type type_1)
        {
            Type type = class165_0.method_0(type_0, type_1);
            if (type == null)
            {
                lock (object_0)
                {
                    type = class165_0.method_0(type_0, type_1);
                    if (type == null)
                    {
                        type = smethod_4(type_0, type_1);
                        class165_0.method_1(type_0, type_1, type);
                    }
                }
            }
            return type;
        }

        public static object smethod_3(object object_1)
        {
            Class162 class2 = object_1 as Class162;
            if (class2 == null)
            {
                throw new ArgumentException("Object is not a wrapper.", "wrapper");
            }
            return class2.object_0;
        }

        private static Type smethod_4(Type type_0, Type type_1)
        {
            TypeBuilder proxyBuilder = ModuleBuilder_0.DefineType("{0}_{1}_Wrapper".smethod_1(CultureInfo.InvariantCulture, type_0.Name, type_1.Name), TypeAttributes.Sealed, typeof(Class162), new Type[] { type_0 });
            Class164 class2 = new Class164(type_1, proxyBuilder);
            foreach (MethodInfo info in type_0.smethod_18())
            {
                class2.method_0(info);
            }
            return proxyBuilder.CreateType();
        }

        public static T smethod_5<T>(object object_1) where T: class
        {
            Class162 class2 = (Class162) Activator.CreateInstance(smethod_2(typeof(T), object_1.GetType()));
            class2.object_0 = object_1;
            return (class2 as T);
        }

        private static ModuleBuilder ModuleBuilder_0
        {
            get
            {
                smethod_0();
                return moduleBuilder_0;
            }
        }
    }
}

