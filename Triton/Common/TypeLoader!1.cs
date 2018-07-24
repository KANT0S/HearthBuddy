namespace Triton.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class TypeLoader<T> : List<T>
    {
        private readonly Assembly assembly_0;
        private Func<object[]> func_0;

        public TypeLoader(Assembly asm = null, Func<object[]> constructorArguments = null)
        {
            this.assembly_0 = asm;
            if (constructorArguments == null)
            {
                this.func_0 = Class233<T>.<>9__2_0 ?? (Class233<T>.<>9__2_0 = new Func<object[]>(Class233<T>.<>9.method_0));
            }
            else
            {
                this.func_0 = constructorArguments;
            }
            this.Reload();
        }

        private void method_0(params Assembly[] assembly_1)
        {
            using (IEnumerator<Type> enumerator = assembly_1.SelectMany<Assembly, Type>((Class233<T>.<>9__3_0 ?? (Class233<T>.<>9__3_0 = new Func<Assembly, IEnumerable<Type>>(Class233<T>.<>9.method_1)))).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class234<T> class2 = new Class234<T> {
                        type_0 = enumerator.Current
                    };
                    if (!this.Any<T>(new Func<T, bool>(class2.method_0)))
                    {
                        base.Add((T) Activator.CreateInstance(class2.type_0, BindingFlags.CreateInstance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, this.func_0(), CultureInfo.InvariantCulture));
                    }
                }
            }
        }

        public void Reload()
        {
            base.Clear();
            if (this.assembly_0 == null)
            {
                this.method_0(AppDomain.CurrentDomain.GetAssemblies());
            }
            else
            {
                Assembly[] assemblyArray1 = new Assembly[] { this.assembly_0 };
                this.method_0(assemblyArray1);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class233
        {
            public static readonly TypeLoader<T>.Class233 <>9;
            public static Func<object[]> <>9__2_0;
            public static Func<Assembly, IEnumerable<Type>> <>9__3_0;
            public static Func<Type, bool> <>9__3_1;
            public static Func<Type, bool> <>9__3_2;

            static Class233()
            {
                TypeLoader<T>.Class233.<>9 = new TypeLoader<T>.Class233();
            }

            internal object[] method_0()
            {
                return null;
            }

            internal IEnumerable<Type> method_1(Assembly assembly_0)
            {
                return assembly_0.GetTypes().Where<Type>((TypeLoader<T>.Class233.<>9__3_1 ?? (TypeLoader<T>.Class233.<>9__3_1 = new Func<Type, bool>(TypeLoader<T>.Class233.<>9.method_2))));
            }

            internal bool method_2(Type type_0)
            {
                if (type_0.IsAbstract)
                {
                    return false;
                }
                return (type_0.IsSubclassOf(typeof(T)) || type_0.GetInterfaces().Any<Type>((TypeLoader<T>.Class233.<>9__3_2 ?? (TypeLoader<T>.Class233.<>9__3_2 = new Func<Type, bool>(TypeLoader<T>.Class233.<>9.method_3)))));
            }

            internal bool method_3(Type type_0)
            {
                return (type_0 == typeof(T));
            }
        }

        [CompilerGenerated]
        private sealed class Class234
        {
            public Type type_0;

            internal bool method_0(T gparam_0)
            {
                return (gparam_0.GetType().FullName == this.type_0.FullName);
            }
        }
    }
}

