namespace Triton.Game.Mono
{
    using GreyMagic;
    using log4net;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Triton.Common;
    using Triton.Game;

    public class MonoClass : IDisposable
    {
        private static readonly AllocatedMemory[] allocatedMemory_0 = new AllocatedMemory[0x20];
        private bool bool_0;
        internal static readonly Dictionary<string, Type> dictionary_0 = new Dictionary<string, Type>();
        internal static Dictionary<string, IntPtr> dictionary_1;
        internal static Dictionary<string, IntPtr> dictionary_2;
        private static readonly Dictionary<IntPtr, Dictionary<string, List<Class269>>> dictionary_3 = new Dictionary<IntPtr, Dictionary<string, List<Class269>>>();
        private static readonly Dictionary<IntPtr, Dictionary<string, IntPtr>> dictionary_4 = new Dictionary<IntPtr, Dictionary<string, IntPtr>>();
        private static readonly Dictionary<string, Dictionary<string, IntPtr>> dictionary_5 = new Dictionary<string, Dictionary<string, IntPtr>>();
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private const int int_0 = 0x20;
        [CompilerGenerated]
        private IntPtr intptr_0;
        private static readonly List<uint> list_0 = new List<uint>();
        private IntPtr? nullable_0;
        private IntPtr? nullable_1;
        public static readonly object OutLock = new object();
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private string string_2;
        [CompilerGenerated]
        private string string_3;
        [CompilerGenerated]
        private uint uint_0;

        static MonoClass()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsClass)
                {
                    foreach (Attribute38 attribute in type.GetCustomAttributes(typeof(Attribute38), false))
                    {
                        dictionary_0.Add(attribute.ClassName, type);
                    }
                }
            }
        }

        internal MonoClass(IntPtr address, string className) : this(TritonHs.MainAssemblyPath, "", className)
        {
            if (address == IntPtr.Zero)
            {
                throw new InvalidOperationException("Cannot create an instance of MonoClass with a backing pointer of Zero.");
            }
            this.Address = address;
            this.UInt32_0 = Class272_0.method_10(address, true);
            this.RealClassName = Class272_0.method_45(this.IntPtr_0);
        }

        internal MonoClass(string assembly, string classNamespace, string className)
        {
            this.AssemblyPath = assembly;
            this.ClassNamespace = classNamespace;
            this.ClassName = className;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.bool_0)
            {
                if (disposing)
                {
                    List<uint> list = list_0;
                    lock (list)
                    {
                        if (this.UInt32_0 != 0)
                        {
                            list_0.Add(this.UInt32_0);
                            this.UInt32_0 = 0;
                        }
                    }
                }
                this.bool_0 = true;
            }
        }

        ~MonoClass()
        {
            this.Dispose(true);
        }

        public virtual IntPtr GetClassInstance()
        {
            return this.Address;
        }

        public static bool IsOutParam(int index, out IntPtr addr)
        {
            addr = IntPtr.Zero;
            if (((index >= 0) && (index < 0x20)) && (allocatedMemory_0[index] != null))
            {
                addr = allocatedMemory_0[index].Address;
                return true;
            }
            return false;
        }

        internal IntPtr method_0(string string_4, Class272.Enum20[] enum20_0)
        {
            if (this.IntPtr_0 == IntPtr.Zero)
            {
                throw new InvalidOperationException("Cannot get a method pointer on an object that has no MonoClass pointer.");
            }
            return smethod_4(this.IntPtr_0, string_4, enum20_0);
        }

        internal IntPtr method_1(string string_4)
        {
            Dictionary<string, IntPtr> dictionary;
            IntPtr ptr;
            if (!dictionary_4.TryGetValue(this.IntPtr_0, out dictionary))
            {
                dictionary_4.Add(this.IntPtr_0, new Dictionary<string, IntPtr>());
                dictionary = dictionary_4[this.IntPtr_0];
            }
            if (!dictionary.TryGetValue(string_4, out ptr))
            {
                ptr = Class272_0.method_34(this.IntPtr_0, string_4);
                if (ptr != IntPtr.Zero)
                {
                    dictionary.Add(string_4, ptr);
                }
            }
            return ptr;
        }

        internal T method_10<T>(string string_4, Class272.Enum20[] enum20_0, params object[] object_0) where T: struct
        {
            IntPtr ptr = this.method_7(string_4, enum20_0, object_0);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            if (typeof(T) == typeof(bool))
            {
                IntPtr addr = Class272_0.method_26(ptr);
                return (T) (ExternalProcessMemory_0.Read<byte>(addr) > 0);
            }
            return ExternalProcessMemory_0.Read<T>(Class272_0.method_26(ptr));
        }

        internal T method_11<T>(string string_4, params object[] object_0) where T: struct
        {
            return this.method_10<T>(string_4, null, object_0);
        }

        internal string method_12(string string_4, Class272.Enum20[] enum20_0, params object[] object_0)
        {
            IntPtr ptr = this.method_7(string_4, enum20_0, object_0);
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            return Class272_0.method_24(ptr);
        }

        internal string method_13(string string_4, params object[] object_0)
        {
            return this.method_12(string_4, null, object_0);
        }

        internal T method_14<T>(string string_4, params object[] object_0) where T: class
        {
            return this.method_15<T>(string_4, null, object_0);
        }

        internal T method_15<T>(string string_4, Class272.Enum20[] enum20_0, params object[] object_0) where T: class
        {
            if (!typeof(T).IsClass)
            {
                object[] objArray1 = new object[] { typeof(T), " is not a class type. Please fix the method invocation for ", this.ClassName, ".", string_4, " to use Get<T> or GetString instead." };
                throw new InvalidOperationException(string.Concat(objArray1));
            }
            IntPtr ptr = this.method_7(string_4, enum20_0, object_0);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return FastObjectFactory.CreateObjectInstance<T>(ptr);
        }

        private int method_16()
        {
            return Class272_0.method_8(Class272_0.method_23(this.Address));
        }

        internal int method_17()
        {
            return Class272_0.method_7(this.Address);
        }

        private IntPtr method_18(int int_1)
        {
            return Class272_0.method_9(this.Address, this.method_16(), int_1);
        }

        private T method_19<T>(IntPtr intptr_1) where T: class
        {
            if (intptr_1 == IntPtr.Zero)
            {
                return default(T);
            }
            return FastObjectFactory.CreateObjectInstance<T>(intptr_1);
        }

        internal T method_2<T>(string string_4) where T: struct
        {
            IntPtr ptr = this.method_5(string_4);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return ExternalProcessMemory_0.Read<T>(Class272_0.method_26(ptr));
        }

        private T method_20<T>(IntPtr intptr_1) where T: struct
        {
            if (intptr_1 == IntPtr.Zero)
            {
                return default(T);
            }
            if (typeof(T) == typeof(bool))
            {
                IntPtr addr = Class272_0.method_26(intptr_1);
                return (T) (ExternalProcessMemory_0.Read<byte>(addr) > 0);
            }
            return ExternalProcessMemory_0.Read<T>(Class272_0.method_26(intptr_1));
        }

        internal T method_21<T>(int int_1) where T: class
        {
            if ((int_1 < 0) || (int_1 >= this.method_17()))
            {
                throw new InvalidOperationException(string.Format("The index {0} is invalid for this array.", int_1));
            }
            IntPtr addr = this.method_18(int_1);
            IntPtr ptr2 = ExternalProcessMemory_0.Read<IntPtr>(addr);
            return this.method_19<T>(ptr2);
        }

        internal T method_22<T>(int int_1) where T: struct
        {
            if ((int_1 < 0) || (int_1 >= this.method_17()))
            {
                throw new InvalidOperationException(string.Format("The index {0} is invalid for this array.", int_1));
            }
            IntPtr addr = this.method_18(int_1);
            return ExternalProcessMemory_0.Read<T>(addr);
        }

        internal string method_23(int int_1)
        {
            if ((int_1 < 0) || (int_1 >= this.method_17()))
            {
                throw new InvalidOperationException(string.Format("The index {0} is invalid for this array.", int_1));
            }
            IntPtr addr = this.method_18(int_1);
            IntPtr ptr2 = ExternalProcessMemory_0.Read<IntPtr>(addr);
            return Class272_0.method_24(ptr2);
        }

        internal T method_3<T>(string string_4) where T: class
        {
            IntPtr ptr = this.method_5(string_4);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return FastObjectFactory.CreateObjectInstance<T>(ptr);
        }

        internal string method_4(string string_4)
        {
            IntPtr ptr = this.method_5(string_4);
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            return Class272_0.method_24(ptr);
        }

        internal IntPtr method_5(string string_4)
        {
            IntPtr classInstance = this.GetClassInstance();
            if (classInstance == IntPtr.Zero)
            {
                throw new Exception("Cannot call a method on an object instance that has no address!");
            }
            IntPtr ptr2 = this.method_1(string_4);
            if (ptr2 == IntPtr.Zero)
            {
                throw new MissingFieldException(this.ClassName, string_4);
            }
            return Class272_0.method_22(classInstance, ptr2);
        }

        internal IntPtr method_6(string string_4, params object[] object_0)
        {
            return this.method_7(string_4, null, object_0);
        }

        internal IntPtr method_7(string string_4, Class272.Enum20[] enum20_0, params object[] object_0)
        {
            IntPtr classInstance = this.GetClassInstance();
            if (classInstance == IntPtr.Zero)
            {
                throw new Exception("Cannot call a method on an object instance that has no address!");
            }
            IntPtr ptr2 = this.method_0(string_4, enum20_0);
            if (ptr2 == IntPtr.Zero)
            {
                throw new MissingMethodException(this.ClassName, string_4);
            }
            return Class272_0.method_43(ptr2, classInstance, object_0);
        }

        internal void method_8(string string_4, params object[] object_0)
        {
            this.method_9(string_4, null, object_0);
        }

        internal void method_9(string string_4, Class272.Enum20[] enum20_0, params object[] object_0)
        {
            this.method_7(string_4, enum20_0, object_0);
        }

        public static T ReadOutParam<T>(int index) where T: struct
        {
            if ((index < 0) || (index >= 0x20))
            {
                throw new Exception(string.Format("index({0}) < 0 || index({0}) >= MaxOutParams({1})", index, 0x20));
            }
            return allocatedMemory_0[index].Read<T>(0);
        }

        public static IntPtr ReflectionTypeGetType(string type)
        {
            IntPtr ptr = smethod_2(type);
            if (ptr == IntPtr.Zero)
            {
                return IntPtr.Zero;
            }
            return Class272_0.method_5(ptr);
        }

        public static void ResetOutParams()
        {
            for (int i = 0; i < 0x20; i++)
            {
                if (allocatedMemory_0[i] != null)
                {
                    allocatedMemory_0[i].Dispose();
                    allocatedMemory_0[i] = null;
                }
            }
        }

        public static void SetOutParam(int index, int size)
        {
            if ((index < 0) || (index >= 0x20))
            {
                throw new Exception(string.Format("index({0}) < 0 || index({0}) >= MaxOutParams({1})", index, 0x20));
            }
            allocatedMemory_0[index] = new AllocatedMemory(ExternalProcessMemory_0, size);
        }

        internal static void smethod_0()
        {
            List<uint> list = list_0;
            lock (list)
            {
                int count = list_0.Count;
                foreach (uint num in list_0)
                {
                    Class272_0.method_11(num);
                }
                list_0.Clear();
            }
        }

        private static void smethod_1()
        {
            if (dictionary_1 == null)
            {
                dictionary_1 = new Dictionary<string, IntPtr>();
            }
            else
            {
                dictionary_1.Clear();
            }
            if (dictionary_2 == null)
            {
                dictionary_2 = new Dictionary<string, IntPtr>();
            }
            else
            {
                dictionary_2.Clear();
            }
            foreach (KeyValuePair<string, IntPtr> pair in TritonHs.Class272_0.method_20(TritonHs.UnityEngineAssemblyPath, ref dictionary_1))
            {
                dictionary_2.Add(pair.Key, pair.Value);
            }
            foreach (KeyValuePair<string, IntPtr> pair2 in TritonHs.Class272_0.method_20(TritonHs.MainAssemblyPath, ref dictionary_1))
            {
                dictionary_2.Add(pair2.Key, pair2.Value);
            }
        }

        internal static IntPtr smethod_10(string string_4, string string_5, string string_6, string string_7, Class272.Enum20[] enum20_0, params object[] object_0)
        {
            IntPtr ptr;
            string[] textArray1 = new string[] { string_4, "~", string_5, ".", string_6 };
            string key = string.Concat(textArray1);
            if (!Dictionary_1.TryGetValue(key, out ptr))
            {
                ptr = Class272_0.method_21(string_4, string_5, string_6);
                Dictionary_1.Add(key, ptr);
            }
            IntPtr ptr2 = smethod_4(ptr, string_7, enum20_0);
            if (ptr2 == IntPtr.Zero)
            {
                return IntPtr.Zero;
            }
            return Class272_0.method_43(ptr2, IntPtr.Zero, object_0);
        }

        internal static T smethod_11<T>(string string_4, string string_5, string string_6, string string_7, Class272.Enum20[] enum20_0, params object[] object_0) where T: struct
        {
            IntPtr ptr = smethod_10(string_4, string_5, string_6, string_7, enum20_0, object_0);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            if (typeof(T) == typeof(bool))
            {
                IntPtr addr = Class272_0.method_26(ptr);
                return (T) (ExternalProcessMemory_0.Read<byte>(addr) > 0);
            }
            return ExternalProcessMemory_0.Read<T>(Class272_0.method_26(ptr));
        }

        internal static string smethod_12(string string_4, string string_5, string string_6, string string_7, params object[] object_0)
        {
            return smethod_13(string_4, string_5, string_6, string_7, null, object_0);
        }

        internal static string smethod_13(string string_4, string string_5, string string_6, string string_7, Class272.Enum20[] enum20_0, params object[] object_0)
        {
            IntPtr ptr = smethod_10(string_4, string_5, string_6, string_7, enum20_0, object_0);
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            return Class272_0.method_24(ptr);
        }

        internal static T smethod_14<T>(string string_4, string string_5, string string_6, string string_7, params object[] object_0) where T: struct
        {
            return smethod_11<T>(string_4, string_5, string_6, string_7, null, object_0);
        }

        internal static T smethod_15<T>(string string_4, string string_5, string string_6, string string_7, params object[] object_0) where T: MonoClass
        {
            return smethod_16<T>(string_4, string_5, string_6, string_7, null, object_0);
        }

        internal static T smethod_16<T>(string string_4, string string_5, string string_6, string string_7, Class272.Enum20[] enum20_0, params object[] object_0) where T: MonoClass
        {
            IntPtr ptr = smethod_10(string_4, string_5, string_6, string_7, enum20_0, object_0);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return FastObjectFactory.CreateObjectInstance<T>(ptr);
        }

        internal static void smethod_17(string string_4, string string_5, string string_6, string string_7)
        {
            smethod_10(string_4, string_5, string_6, string_7, null, Array.Empty<object>());
        }

        internal static void smethod_18(string string_4, string string_5, string string_6, string string_7, params object[] object_0)
        {
            smethod_10(string_4, string_5, string_6, string_7, null, object_0);
        }

        internal static void smethod_19(string string_4, string string_5, string string_6, string string_7, Class272.Enum20[] enum20_0, params object[] object_0)
        {
            smethod_10(string_4, string_5, string_6, string_7, enum20_0, object_0);
        }

        private static IntPtr smethod_2(string string_4)
        {
            IntPtr ptr;
            if (Dictionary_0.TryGetValue(TritonHs.UnityEngineAssemblyPath + "~" + string_4, out ptr))
            {
                return ptr;
            }
            if (Dictionary_0.TryGetValue(TritonHs.MainAssemblyPath + "~." + string_4, out ptr))
            {
                return ptr;
            }
            return IntPtr.Zero;
        }

        internal static IntPtr smethod_3(string string_4, string string_5, string string_6)
        {
            IntPtr ptr;
            string[] textArray1 = new string[] { string_4, "~", string_5, ".", string_6 };
            string key = string.Concat(textArray1);
            if (!Dictionary_1.TryGetValue(key, out ptr))
            {
                ptr = Class272_0.method_21(string_4, string_5, string_6);
                if (ptr != IntPtr.Zero)
                {
                    Dictionary_1.Add(key, ptr);
                }
            }
            return ptr;
        }

        private static IntPtr smethod_4(IntPtr intptr_1, string string_4, Class272.Enum20[] enum20_0)
        {
            Dictionary<string, List<Class269>> dictionary;
            List<Class269> list;
            Class270 class2 = new Class270 {
                string_0 = string_4,
                enum20_0 = enum20_0
            };
            if (!dictionary_3.TryGetValue(intptr_1, out dictionary))
            {
                dictionary_3.Add(intptr_1, new Dictionary<string, List<Class269>>());
                dictionary = dictionary_3[intptr_1];
            }
            if (!dictionary.TryGetValue(class2.string_0, out list))
            {
                dictionary.Add(class2.string_0, new List<Class269>());
                list = dictionary[class2.string_0];
            }
            Class269 item = list.FirstOrDefault<Class269>(new Func<Class269, bool>(class2.method_0));
            if (item == null)
            {
                IntPtr address = Class272_0.method_33(intptr_1, class2.string_0, class2.enum20_0);
                if (address != IntPtr.Zero)
                {
                    item = new Class269(class2.string_0, address, class2.enum20_0);
                    list.Add(item);
                }
            }
            if (item == null)
            {
                return IntPtr.Zero;
            }
            return item.IntPtr_0;
        }

        internal static IntPtr smethod_5(string string_4, string string_5, string string_6, string string_7)
        {
            Dictionary<string, IntPtr> dictionary;
            IntPtr ptr2;
            string key = string_6 + "." + string_7;
            if (!dictionary_5.TryGetValue(key, out dictionary))
            {
                dictionary_5.Add(key, new Dictionary<string, IntPtr>());
                dictionary = dictionary_5[key];
            }
            IntPtr ptr = smethod_3(string_4, string_5, string_6);
            if (!dictionary.TryGetValue(string_7, out ptr2))
            {
                ptr2 = Class272_0.method_34(ptr, string_7);
                if (ptr2 != IntPtr.Zero)
                {
                    dictionary.Add(string_7, ptr2);
                }
            }
            return ptr2;
        }

        internal static T smethod_6<T>(string string_4, string string_5, string string_6, string string_7) where T: struct
        {
            IntPtr ptr = smethod_9(string_4, string_5, string_6, string_7);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return ExternalProcessMemory_0.Read<T>(Class272_0.method_26(ptr));
        }

        internal static T smethod_7<T>(string string_4, string string_5, string string_6, string string_7) where T: class
        {
            IntPtr ptr = smethod_9(string_4, string_5, string_6, string_7);
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return FastObjectFactory.CreateObjectInstance<T>(ptr);
        }

        internal static string smethod_8(string string_4, string string_5, string string_6, string string_7)
        {
            IntPtr ptr = smethod_9(string_4, string_5, string_6, string_7);
            if (ptr == IntPtr.Zero)
            {
                return null;
            }
            return Class272_0.method_24(ptr);
        }

        internal static IntPtr smethod_9(string string_4, string string_5, string string_6, string string_7)
        {
            IntPtr ptr = smethod_5(string_4, string_5, string_6, string_7);
            if (ptr == IntPtr.Zero)
            {
                throw new MissingFieldException(string_6, string_7);
            }
            return Class272_0.method_22(IntPtr.Zero, ptr);
        }

        internal virtual IntPtr vmethod_0(string string_4, string string_5, string string_6)
        {
            if (this.Address != IntPtr.Zero)
            {
                return Class272_0.method_23(this.Address);
            }
            return smethod_3(string_4, string_5, string_6);
        }

        public IntPtr Address
        {
            [CompilerGenerated]
            get
            {
                return this.intptr_0;
            }
            [CompilerGenerated]
            internal set
            {
                this.intptr_0 = value;
            }
        }

        public string AssemblyPath
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }

        internal static Class272 Class272_0
        {
            get
            {
                return TritonHs.Class272_0;
            }
        }

        public string ClassName
        {
            [CompilerGenerated]
            get
            {
                return this.string_2;
            }
            [CompilerGenerated]
            private set
            {
                this.string_2 = value;
            }
        }

        public string ClassNamespace
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }

        private static Dictionary<string, IntPtr> Dictionary_0
        {
            get
            {
                if (dictionary_1 == null)
                {
                    smethod_1();
                }
                return dictionary_1;
            }
        }

        private static Dictionary<string, IntPtr> Dictionary_1
        {
            get
            {
                if (dictionary_2 == null)
                {
                    smethod_1();
                }
                return dictionary_2;
            }
        }

        internal static ExternalProcessMemory ExternalProcessMemory_0
        {
            get
            {
                return TritonHs.Memory;
            }
        }

        internal IntPtr IntPtr_0
        {
            get
            {
                IntPtr? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    IntPtr? nullable2;
                    this.nullable_0 = nullable2 = new IntPtr?(this.vmethod_0(this.AssemblyPath, this.ClassNamespace, this.ClassName));
                    return nullable2.Value;
                }
                return nullable.GetValueOrDefault();
            }
        }

        internal IntPtr IntPtr_1
        {
            get
            {
                IntPtr? nullable = this.nullable_1;
                if (!nullable.HasValue)
                {
                    IntPtr? nullable2;
                    this.nullable_1 = nullable2 = new IntPtr?(this.vmethod_0(TritonHs.UnityEngineAssemblyPath, "UnityEngine", this.ClassName));
                    return nullable2.Value;
                }
                return nullable.GetValueOrDefault();
            }
        }

        public virtual bool IsNull
        {
            get
            {
                return (this.GetClassInstance() == IntPtr.Zero);
            }
        }

        public string RealClassName
        {
            [CompilerGenerated]
            get
            {
                return this.string_3;
            }
            [CompilerGenerated]
            private set
            {
                this.string_3 = value;
            }
        }

        internal uint UInt32_0
        {
            [CompilerGenerated]
            get
            {
                return this.uint_0;
            }
            [CompilerGenerated]
            set
            {
                this.uint_0 = value;
            }
        }

        internal class Class269
        {
            [CompilerGenerated]
            private Class272.Enum20[] enum20_0;
            [CompilerGenerated]
            private IntPtr intptr_0;
            [CompilerGenerated]
            private string string_0;

            public Class269(string name, IntPtr address, Class272.Enum20[] parameters)
            {
                this.Name = name;
                this.IntPtr_0 = address;
                this.Enum20_0 = parameters;
            }

            public bool method_0(string string_1, params Class272.Enum20[] enum20_1)
            {
                if (this.Name != string_1)
                {
                    return false;
                }
                if (enum20_1 == null)
                {
                    if ((this.Enum20_0 != null) && (this.Enum20_0.Length != 0))
                    {
                        return false;
                    }
                    return true;
                }
                if (enum20_1.Length != this.Enum20_0.Length)
                {
                    return false;
                }
                for (int i = 0; i < enum20_1.Length; i++)
                {
                    if (enum20_1[i] != this.Enum20_0[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public Class272.Enum20[] Enum20_0
            {
                [CompilerGenerated]
                get
                {
                    return this.enum20_0;
                }
                [CompilerGenerated]
                set
                {
                    this.enum20_0 = value;
                }
            }

            public IntPtr IntPtr_0
            {
                [CompilerGenerated]
                get
                {
                    return this.intptr_0;
                }
                [CompilerGenerated]
                set
                {
                    this.intptr_0 = value;
                }
            }

            public string Name
            {
                [CompilerGenerated]
                get
                {
                    return this.string_0;
                }
                [CompilerGenerated]
                internal set
                {
                    this.string_0 = value;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class270
        {
            public Class272.Enum20[] enum20_0;
            public string string_0;

            internal bool method_0(MonoClass.Class269 class269_0)
            {
                return class269_0.method_0(this.string_0, this.enum20_0);
            }
        }
    }
}

