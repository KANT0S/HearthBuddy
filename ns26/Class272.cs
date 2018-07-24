namespace ns26
{
    using GreyMagic;
    using log4net;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using T}"gzNUf_Q9JsG"ZD~:mcM1h;
    using Triton.Game;
    using Triton.Game.Mapping;
    using Triton.Game.Mono;

    internal class Class272
    {
        private readonly Dictionary<System.Type, IntPtr> dictionary_0 = new Dictionary<System.Type, IntPtr>();
        private readonly ExternalProcessMemory externalProcessMemory_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private readonly IntPtr intptr_0;
        private readonly IntPtr intptr_1;
        private readonly IntPtr intptr_10;
        private readonly IntPtr intptr_11;
        private readonly IntPtr intptr_12;
        private readonly IntPtr intptr_13;
        private readonly IntPtr intptr_14;
        private readonly IntPtr intptr_15;
        private readonly IntPtr intptr_16;
        private readonly IntPtr intptr_17;
        private readonly IntPtr intptr_18;
        private readonly IntPtr intptr_19;
        private readonly IntPtr intptr_2;
        private readonly IntPtr intptr_20;
        private readonly IntPtr intptr_21;
        private readonly IntPtr intptr_22;
        private readonly IntPtr intptr_23;
        private readonly IntPtr intptr_24;
        private readonly IntPtr intptr_25;
        private readonly IntPtr intptr_26;
        private readonly IntPtr intptr_27;
        private readonly IntPtr intptr_28;
        private readonly IntPtr intptr_29;
        private readonly IntPtr intptr_3;
        private readonly IntPtr intptr_30;
        private readonly IntPtr intptr_31;
        private readonly IntPtr intptr_32;
        private readonly IntPtr intptr_33;
        private readonly IntPtr intptr_34;
        private readonly IntPtr intptr_35;
        private readonly IntPtr intptr_36;
        private readonly IntPtr intptr_4;
        private readonly IntPtr intptr_5;
        private readonly IntPtr intptr_6;
        private readonly IntPtr intptr_7;
        private readonly IntPtr intptr_8;
        private readonly IntPtr intptr_9;

        internal Class272(ExternalProcessMemory memory)
        {
            this.externalProcessMemory_0 = memory;
            this.intptr_0 = this.method_18("mono.dll");
            this.intptr_31 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_9;
            this.intptr_28 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_17;
            this.intptr_13 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_22;
            this.intptr_16 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_16;
            this.intptr_6 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_7;
            this.intptr_1 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_15;
            this.intptr_15 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_24;
            this.intptr_14 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_21;
            this.intptr_7 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_5;
            this.intptr_19 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_10;
            this.intptr_29 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_35;
            this.intptr_17 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_1;
            this.intptr_25 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_30;
            this.intptr_24 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_25;
            this.intptr_32 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_31;
            this.intptr_34 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_28;
            this.intptr_36 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_0;
            this.intptr_35 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_29;
            this.intptr_23 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_34;
            this.intptr_33 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_33;
            this.intptr_27 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_32;
            this.intptr_12 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_4;
            this.intptr_10 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_3;
            this.intptr_4 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_6;
            this.intptr_8 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_11;
            this.intptr_21 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_23;
            this.intptr_18 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_8;
            this.intptr_5 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_2;
            this.intptr_30 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_19;
            this.intptr_2 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_12;
            this.intptr_9 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_18;
            this.intptr_3 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_14;
            this.intptr_26 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_27;
            this.intptr_22 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_26;
            this.intptr_20 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_13;
            this.intptr_11 = this.intptr_0 + TritonHs.class243_0.struct102_0.int_20;
            this.method_15<bool>("boolean");
            this.method_15<object>("object");
            this.method_15<sbyte>("sbyte");
            this.method_15<byte>("byte");
            this.method_15<short>("int16");
            this.method_15<ushort>("uint16");
            this.method_15<int>("int32");
            this.method_15<uint>("uint32");
            this.method_15<long>("int64");
            this.method_15<ulong>("uint64");
            this.method_15<float>("single");
            this.method_15<double>("double");
            this.method_15<char>("char");
            this.method_15<string>("string");
            this.method_15<Enum>("enum");
        }

        internal void method_0()
        {
            this.externalProcessMemory_0.CallInjected(this.intptr_17, CallingConvention.Cdecl, Array.Empty<object>());
        }

        internal int method_1(string string_0)
        {
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(string_0.Length + 1))
            {
                memory.WriteString(0, string_0, Encoding.ASCII);
                object[] objArray1 = new object[] { memory.Address };
                return this.method_17<int>(this.intptr_5, objArray1);
            }
        }

        internal uint method_10(IntPtr intptr_37, bool bool_0)
        {
            object[] objArray1 = new object[] { intptr_37, bool_0 ? 1 : 0 };
            return this.method_17<uint>(this.intptr_12, objArray1);
        }

        internal void method_11(uint uint_0)
        {
            object[] objArray1 = new object[] { uint_0 };
            this.method_17<int>(this.intptr_10, objArray1);
        }

        internal IntPtr method_12(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_16, objArray1);
        }

        internal IntPtr method_13(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_15, objArray1);
        }

        internal IntPtr method_14(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_20, objArray1);
        }

        private void method_15<T>(string string_0)
        {
            this.dictionary_0.Add(typeof(T), this.method_17<IntPtr>(this.method_19(string.Format("mono_get_{0}_class", string_0)), Array.Empty<object>()));
        }

        private void method_16(IntPtr intptr_37, string string_0)
        {
            if (intptr_37 == IntPtr.Zero)
            {
                throw new Exception(string_0);
            }
        }

        private T method_17<T>(IntPtr intptr_37, params object[] object_0) where T: struct
        {
            return this.externalProcessMemory_0.CallInjected<T>(intptr_37, CallingConvention.Cdecl, object_0);
        }

        internal IntPtr method_18(string string_0)
        {
            IntPtr procAddress = this.externalProcessMemory_0.GetProcAddress("kernel32.dll", "GetModuleHandleW");
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory((string_0.Length * 2) + 2))
            {
                memory.WriteString(0, string_0, Encoding.Unicode);
                object[] args = new object[] { memory.Address };
                return this.externalProcessMemory_0.CallInjected<IntPtr>(procAddress, CallingConvention.StdCall, args);
            }
        }

        internal IntPtr method_19(string string_0)
        {
            IntPtr procAddress = this.externalProcessMemory_0.GetProcAddress("kernel32.dll", "GetProcAddress");
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(string_0.Length + 1))
            {
                memory.WriteString(0, string_0, Encoding.ASCII);
                object[] args = new object[] { this.intptr_0, memory.Address };
                return this.externalProcessMemory_0.CallInjected<IntPtr>(procAddress, CallingConvention.StdCall, args);
            }
        }

        internal IntPtr method_2()
        {
            object[] objArray1 = new object[] { this.method_4() };
            return this.method_17<IntPtr>(this.intptr_31, objArray1);
        }

        internal Dictionary<string, IntPtr> method_20(string string_0, ref Dictionary<string, IntPtr> dictionary_1)
        {
            int num;
            Dictionary<string, IntPtr> dictionary = new Dictionary<string, IntPtr>();
            IntPtr ptr = this.method_30();
            bool flag1 = this.method_29() != ptr;
            if (ptr == IntPtr.Zero)
            {
                throw new Exception("Code is not running on a mono thread!");
            }
            IntPtr ptr2 = this.method_40(string_0, out num);
            this.method_16(ptr2, "Could not load assembly. Status: " + num);
            IntPtr ptr3 = this.method_39(ptr2);
            this.method_16(ptr3, "Could not open mono image. Status: " + num);
            foreach (IntPtr ptr4 in this.method_44(ptr3))
            {
                if (ptr4 != IntPtr.Zero)
                {
                    this.externalProcessMemory_0.Read<Struct107>(ptr4);
                    IntPtr ptr5 = this.method_14(ptr4);
                    string str = this.method_45(ptr4);
                    if (ptr5 != IntPtr.Zero)
                    {
                        str = this.method_44(ptr5) + "." + str;
                    }
                    string str2 = this.method_46(ptr4);
                    string[] textArray1 = new string[] { string_0, "~", str2, ".", str };
                    if (!dictionary.ContainsKey(string.Concat(textArray1)))
                    {
                        string[] textArray2 = new string[] { string_0, "~", str2, ".", str };
                        string key = string.Concat(textArray2);
                        dictionary.Add(key, ptr4);
                        dictionary_1.Add(key, this.method_12(ptr4));
                    }
                }
            }
            return dictionary;
        }

        internal IntPtr method_21(string string_0, string string_1, string string_2)
        {
            int num;
            IntPtr ptr = this.method_30();
            bool flag1 = this.method_29() != ptr;
            if (ptr == IntPtr.Zero)
            {
                throw new Exception("Code is not running on a mono thread!");
            }
            IntPtr ptr2 = this.method_40(string_0, out num);
            this.method_16(ptr2, "Could not load assembly. Status: " + num);
            IntPtr ptr3 = this.method_39(ptr2);
            this.method_16(ptr3, "Could not open mono image. Status: " + num);
            foreach (IntPtr ptr4 in this.method_44(ptr3))
            {
                if (ptr4 != IntPtr.Zero)
                {
                    string str = this.method_46(ptr4);
                    if ((this.method_45(ptr4) == string_2) && (str == string_1))
                    {
                        return ptr4;
                    }
                }
            }
            Debugger.Break();
            return IntPtr.Zero;
        }

        internal IntPtr method_22(IntPtr intptr_37, IntPtr intptr_38)
        {
            IntPtr ptr = this.method_27();
            object[] objArray1 = new object[] { ptr, intptr_38, intptr_37 };
            return this.method_17<IntPtr>(this.intptr_11, objArray1);
        }

        internal IntPtr method_23(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_24, objArray1);
        }

        internal string method_24(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            IntPtr address = this.method_17<IntPtr>(this.intptr_32, objArray1);
            return this.externalProcessMemory_0.ReadStringUTF8(address);
        }

        internal IntPtr method_25(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_28, objArray1);
        }

        internal IntPtr method_26(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_22, objArray1);
        }

        internal IntPtr method_27()
        {
            return this.method_17<IntPtr>(this.intptr_9, Array.Empty<object>());
        }

        internal IntPtr method_28(string string_0)
        {
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory((string_0.Length + 1) * 2))
            {
                if (string_0.Length > 0)
                {
                    memory.WriteString(0, string_0, Encoding.UTF8);
                }
                else
                {
                    memory.Write<ushort>(0, 0);
                }
                IntPtr ptr = this.method_27();
                object[] objArray1 = new object[] { ptr, memory.Address };
                return this.method_17<IntPtr>(this.intptr_25, objArray1);
            }
        }

        internal IntPtr method_29()
        {
            return this.method_17<IntPtr>(this.intptr_33, Array.Empty<object>());
        }

        internal void method_3(IntPtr intptr_37)
        {
            object[] args = new object[] { intptr_37 };
            this.externalProcessMemory_0.CallInjected(this.intptr_18, CallingConvention.Cdecl, args);
        }

        internal IntPtr method_30()
        {
            return this.method_17<IntPtr>(this.intptr_27, Array.Empty<object>());
        }

        internal Enum20[] method_31(IntPtr intptr_37)
        {
            List<Enum20> list = new List<Enum20>();
            IntPtr addr = this.method_13(intptr_37);
            Struct105 struct2 = this.externalProcessMemory_0.Read<Struct105>(addr);
            IntPtr ptr2 = addr + 12;
            for (int i = 1; i < (struct2.ushort_0 + 1); i++)
            {
                IntPtr ptr3 = this.externalProcessMemory_0.Read<IntPtr>(ptr2 + (i * 4));
                Enum20 item = (Enum20) this.externalProcessMemory_0.Read<Struct106>(ptr3).UInt32_1;
                list.Add(item);
            }
            return list.ToArray();
        }

        internal void method_32(IntPtr intptr_37)
        {
            string str = "";
            while (intptr_37 != IntPtr.Zero)
            {
                using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(0x100))
                {
                    IntPtr ptr;
                    memory.AllocateOfChunk<IntPtr>("Itr");
                    while ((ptr = this.method_35(intptr_37, memory["Itr"])) != IntPtr.Zero)
                    {
                        Struct104 struct2 = this.externalProcessMemory_0.Read<Struct104>(ptr);
                        IntPtr addr = this.method_13(ptr);
                        Struct105 struct3 = this.externalProcessMemory_0.Read<Struct105>(addr);
                        IntPtr ptr3 = addr + 12;
                        StringBuilder builder = new StringBuilder();
                        for (int i = 1; i < (struct3.ushort_0 + 1); i++)
                        {
                            IntPtr ptr4 = this.externalProcessMemory_0.Read<IntPtr>(ptr3 + (i * 4));
                            Enum20 enum2 = (Enum20) this.externalProcessMemory_0.Read<Struct106>(ptr4).UInt32_1;
                            builder.Append(enum2);
                            if (i != struct3.ushort_0)
                            {
                                builder.Append(", ");
                            }
                        }
                        string str2 = this.externalProcessMemory_0.ReadStringUTF8(struct2.intptr_2);
                        ilog_0.Debug(string.Concat(new object[] { str, str2, "(", builder, ")" }));
                    }
                    intptr_37 = this.method_25(intptr_37);
                    if (intptr_37 != IntPtr.Zero)
                    {
                        ilog_0.Debug("Base class: " + this.method_45(intptr_37));
                    }
                    continue;
                }
            }
        }

        internal IntPtr method_33(IntPtr intptr_37, string string_0, params Enum20[] enum20_0)
        {
            while (intptr_37 != IntPtr.Zero)
            {
                using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(0x100))
                {
                    IntPtr ptr;
                    memory.AllocateOfChunk<IntPtr>("Itr");
                    while ((ptr = this.method_35(intptr_37, memory["Itr"])) != IntPtr.Zero)
                    {
                        IntPtr address = this.method_37(ptr);
                        if (this.externalProcessMemory_0.ReadStringA(address) == string_0)
                        {
                            if (enum20_0 == null)
                            {
                                return ptr;
                            }
                            Enum20[] first = this.method_31(ptr);
                            if ((first.Length == enum20_0.Length) && first.SequenceEqual<Enum20>(enum20_0))
                            {
                                return ptr;
                            }
                        }
                    }
                    intptr_37 = this.method_25(intptr_37);
                    continue;
                }
            }
            return IntPtr.Zero;
        }

        internal IntPtr method_34(IntPtr intptr_37, string string_0)
        {
            while (intptr_37 != IntPtr.Zero)
            {
                using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(0x100))
                {
                    IntPtr ptr;
                    memory.AllocateOfChunk<IntPtr>("Itr");
                    while ((ptr = this.method_36(intptr_37, memory["Itr"])) != IntPtr.Zero)
                    {
                        IntPtr address = this.method_38(ptr);
                        if (this.externalProcessMemory_0.ReadStringA(address) == string_0)
                        {
                            return ptr;
                        }
                    }
                }
                intptr_37 = this.method_25(intptr_37);
            }
            return IntPtr.Zero;
        }

        internal IntPtr method_35(IntPtr intptr_37, IntPtr intptr_38)
        {
            object[] objArray1 = new object[] { intptr_37, intptr_38 };
            return this.method_17<IntPtr>(this.intptr_19, objArray1);
        }

        internal IntPtr method_36(IntPtr intptr_37, IntPtr intptr_38)
        {
            object[] objArray1 = new object[] { intptr_37, intptr_38 };
            return this.method_17<IntPtr>(this.intptr_8, objArray1);
        }

        internal IntPtr method_37(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_21, objArray1);
        }

        internal IntPtr method_38(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_30, objArray1);
        }

        internal IntPtr method_39(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<IntPtr>(this.intptr_4, objArray1);
        }

        internal IntPtr method_4()
        {
            return this.method_17<IntPtr>(this.intptr_29, Array.Empty<object>());
        }

        internal IntPtr method_40(string string_0, out int int_0)
        {
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(((string_0.Length * 2) + 2) + 4))
            {
                memory.WriteString(4, string_0, Encoding.UTF8);
                object[] objArray1 = new object[] { memory.Address + 4, memory.Address };
                int_0 = memory.Read<int>(0);
                return this.method_17<IntPtr>(this.intptr_6, objArray1);
            }
        }

        internal IntPtr method_41(byte[] byte_0, bool bool_0, bool bool_1, string string_0, out int int_0)
        {
            IntPtr ptr;
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(byte_0.Length))
            {
                memory.WriteBytes(0, byte_0);
                using (AllocatedMemory memory2 = this.externalProcessMemory_0.CreateAllocatedMemory((4 + string_0.Length) + 1))
                {
                    memory2.AllocateOfChunk<int>("Status");
                    memory2.AllocateOfChunk("Name", string_0.Length + 1);
                    memory2.WriteString("Name", string_0, Encoding.ASCII);
                    object[] objArray1 = new object[] { memory.Address, byte_0.Length, bool_0 ? 1 : 0, memory2["Status"], bool_1 ? 1 : 0, memory2["Name"] };
                    int_0 = memory2.Read<int>("Status");
                    ptr = this.method_17<IntPtr>(this.intptr_13, objArray1);
                }
            }
            return ptr;
        }

        internal IntPtr method_42(IntPtr intptr_37, string string_0, bool bool_0, out int int_0)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(string_0 + "\0");
            using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(bytes.Length + 4))
            {
                memory.AllocateOfChunk<int>("Status");
                memory.AllocateOfChunk("Name", bytes.Length);
                memory.WriteBytes("Name", bytes);
                object[] objArray1 = new object[] { intptr_37, memory["Name"], memory["Status"], bool_0 ? 1 : 0 };
                int_0 = memory.Read<int>("Status");
                return this.method_17<IntPtr>(this.intptr_7, objArray1);
            }
        }

        internal IntPtr method_43(IntPtr intptr_37, IntPtr intptr_38, params object[] object_0)
        {
            if ((object_0 != null) && (object_0.Length != 0))
            {
                using (AllocatedMemory memory = this.externalProcessMemory_0.CreateAllocatedMemory(0x800))
                {
                    memory.AllocateOfChunk("ArrayPtrs", 0x200);
                    memory.AllocateOfChunk("Args", 0x200);
                    int index = 0;
                    int offsetInBytes = 0;
                    foreach (object obj2 in object_0)
                    {
                        IntPtr ptr;
                        object classInstance = obj2;
                        if (MonoClass.IsOutParam(index, out ptr))
                        {
                            classInstance = ptr;
                        }
                        MonoClass class2 = obj2 as MonoClass;
                        if (class2 != null)
                        {
                            classInstance = class2.GetClassInstance();
                        }
                        else
                        {
                            string str = obj2 as string;
                            if (str != null)
                            {
                                classInstance = this.method_28(str);
                            }
                            else if (obj2.GetType().IsEnum)
                            {
                                classInstance = Convert.ChangeType(classInstance, ((Enum) classInstance).GetTypeCode());
                            }
                        }
                        int num4 = 4;
                        if (!(classInstance is IntPtr))
                        {
                            if (classInstance is long)
                            {
                                memory.Write<long>("Args", offsetInBytes, (long) classInstance);
                                num4 = 8;
                            }
                            else if (classInstance is ulong)
                            {
                                memory.Write<ulong>("Args", offsetInBytes, (ulong) classInstance);
                                num4 = 8;
                            }
                            else if (classInstance is uint)
                            {
                                memory.Write<uint>("Args", offsetInBytes, (uint) classInstance);
                            }
                            else if (classInstance is int)
                            {
                                memory.Write<int>("Args", offsetInBytes, (int) classInstance);
                            }
                            else if (classInstance is bool)
                            {
                                memory.Write<int>("Args", offsetInBytes, ((bool) classInstance) ? 1 : 0);
                            }
                            else if (classInstance is double)
                            {
                                memory.Write<double>("Args", offsetInBytes, (double) classInstance);
                                num4 = 8;
                            }
                            else if (classInstance is float)
                            {
                                memory.Write<float>("Args", offsetInBytes, (float) classInstance);
                            }
                            else if (classInstance is Vector3)
                            {
                                Vector3 vector = (Vector3) classInstance;
                                memory.Write<float>("Args", offsetInBytes + 0, vector.X);
                                memory.Write<float>("Args", offsetInBytes + 4, vector.Y);
                                memory.Write<float>("Args", offsetInBytes + 8, vector.Z);
                                num4 = 12;
                            }
                            else
                            {
                                if (!(classInstance is RaycastHit))
                                {
                                    throw new Exception("Unknown type passed as argument: " + classInstance.GetType());
                                }
                                RaycastHit hit = (RaycastHit) classInstance;
                                memory.Write<float>("Args", offsetInBytes + 0, hit.Point.X);
                                memory.Write<float>("Args", offsetInBytes + 4, hit.Point.Y);
                                memory.Write<float>("Args", offsetInBytes + 8, hit.Point.Z);
                                memory.Write<float>("Args", offsetInBytes + 12, hit.Normal.X);
                                memory.Write<float>("Args", offsetInBytes + 0x10, hit.Normal.Y);
                                memory.Write<float>("Args", offsetInBytes + 20, hit.Normal.Z);
                                memory.Write<int>("Args", offsetInBytes + 0x18, hit.FaceID);
                                memory.Write<float>("Args", offsetInBytes + 0x1c, hit.Distance);
                                memory.Write<float>("Args", offsetInBytes + 0x20, hit.UV.X);
                                memory.Write<float>("Args", offsetInBytes + 0x24, hit.UV.Y);
                                num4 = 40;
                            }
                        }
                        if (classInstance is IntPtr)
                        {
                            memory.Write<IntPtr>("ArrayPtrs", 4 * index, (IntPtr) classInstance);
                        }
                        else
                        {
                            memory.Write<IntPtr>("ArrayPtrs", 4 * index, memory["Args"] + offsetInBytes);
                        }
                        index++;
                        offsetInBytes += num4;
                    }
                    object[] objArray1 = new object[] { intptr_37, intptr_38, memory["ArrayPtrs"], IntPtr.Zero };
                    return this.method_17<IntPtr>(this.intptr_26, objArray1);
                }
            }
            object[] objArray2 = new object[] { intptr_37, intptr_38, IntPtr.Zero, IntPtr.Zero };
            return this.method_17<IntPtr>(this.intptr_26, objArray2);
        }

        [IteratorStateMachine(typeof(\*ySJ{?=`s!;vGlV7\\"i-@A\\(!.(>z0j<}TOkhGZoeO=WpX{I)u'))]
        internal IEnumerable<IntPtr> method_44(IntPtr intptr_37)
        {
            return new Class273(-2) { class272_0 = this, intptr_2 = intptr_37 };
        }

        internal string method_45(IntPtr intptr_37)
        {
            IntPtr ptr = this.method_14(intptr_37);
            string str = "";
            while (ptr != IntPtr.Zero)
            {
                str = this.method_45(ptr) + "." + str;
                ptr = this.method_14(ptr);
            }
            object[] objArray1 = new object[] { intptr_37 };
            return (str + this.externalProcessMemory_0.ReadStringA(this.method_17<IntPtr>(this.intptr_2, objArray1)));
        }

        internal string method_46(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.externalProcessMemory_0.ReadStringA(this.method_17<IntPtr>(this.intptr_3, objArray1));
        }

        internal IntPtr method_5(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { this.method_27(), intptr_37 };
            return this.method_17<IntPtr>(this.intptr_23, objArray1);
        }

        internal IntPtr method_6(IntPtr intptr_37, IntPtr intptr_38)
        {
            object[] objArray1 = new object[] { intptr_37, intptr_38 };
            return this.method_17<IntPtr>(this.intptr_36, objArray1);
        }

        internal int method_7(IntPtr intptr_37)
        {
            return this.externalProcessMemory_0.Read<int>(intptr_37 + 12);
        }

        internal int method_8(IntPtr intptr_37)
        {
            object[] objArray1 = new object[] { intptr_37 };
            return this.method_17<int>(this.intptr_35, objArray1);
        }

        internal IntPtr method_9(IntPtr intptr_37, int int_0, int int_1)
        {
            object[] objArray1 = new object[] { intptr_37, int_0, int_1 };
            return this.method_17<IntPtr>(this.intptr_34, objArray1);
        }

        [CompilerGenerated]
        private sealed class Class273 : IDisposable, IEnumerable, IEnumerator, IEnumerable<IntPtr>, IEnumerator<IntPtr>
        {
            public Class272 class272_0;
            private int int_0;
            private int int_1;
            private int int_2;
            private int int_3;
            private IntPtr intptr_0;
            private IntPtr intptr_1;
            public IntPtr intptr_2;

            [DebuggerHidden]
            public Class273(int <>1__state)
            {
                this.int_0 = <>1__state;
                this.int_1 = Environment.CurrentManagedThreadId;
            }

            private bool MoveNext()
            {
                int num = this.int_0;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return false;
                    }
                    this.int_0 = -1;
                    int num2 = this.int_2;
                    this.int_2 = num2 + 1;
                }
                else
                {
                    this.int_0 = -1;
                    object[] objArray1 = new object[] { this.intptr_1, 2 };
                    this.int_3 = this.class272_0.method_17<int>(this.class272_0.intptr_14, objArray1);
                    this.int_2 = 1;
                }
                if (this.int_2 >= (this.int_3 + 1))
                {
                    return false;
                }
                object[] args = new object[] { this.intptr_1, this.int_2 | 0x2000000 };
                this.intptr_0 = this.class272_0.externalProcessMemory_0.CallInjected<IntPtr>(this.class272_0.intptr_1, CallingConvention.Cdecl, args);
                this.int_0 = 1;
                return true;
            }

            [DebuggerHidden]
            IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
            {
                Class272.Class273 class2;
                if ((this.int_0 == -2) && (this.int_1 == Environment.CurrentManagedThreadId))
                {
                    this.int_0 = 0;
                    class2 = this;
                }
                else
                {
                    class2 = new Class272.Class273(0) {
                        class272_0 = this.class272_0
                    };
                }
                class2.intptr_1 = this.intptr_2;
                return class2;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator();
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            IntPtr IEnumerator<IntPtr>.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.intptr_0;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.intptr_0;
                }
            }
        }

        public enum Enum20 : uint
        {
            Array = 20,
            Boolean = 2,
            ByRef = 0x10,
            Char = 3,
            Class = 0x12,
            CmodOpt = 0x20,
            CmodReqd = 0x1f,
            End = 0,
            Enum = 0x55,
            FnPtr = 0x1b,
            GenericInst = 0x15,
            I = 0x18,
            I1 = 4,
            I2 = 6,
            I4 = 8,
            I8 = 10,
            Internal = 0x21,
            Modifier = 0x40,
            Mvar = 30,
            Object = 0x1c,
            Pinned = 0x45,
            Ptr = 15,
            R4 = 12,
            R8 = 13,
            Sentinel = 0x41,
            String = 14,
            SzArray = 0x1d,
            TypedByRef = 0x16,
            U = 0x19,
            U1 = 5,
            U2 = 7,
            U4 = 9,
            U8 = 11,
            ValueType = 0x11,
            Var = 0x13,
            Void = 1
        }

        private enum Enum21
        {
            MONO_TABLE_MODULE,
            MONO_TABLE_TYPEREF,
            MONO_TABLE_TYPEDEF,
            MONO_TABLE_FIELD_POINTER,
            MONO_TABLE_FIELD,
            MONO_TABLE_METHOD_POINTER,
            MONO_TABLE_METHOD,
            MONO_TABLE_PARAM_POINTER,
            MONO_TABLE_PARAM,
            MONO_TABLE_INTERFACEIMPL,
            MONO_TABLE_MEMBERREF,
            MONO_TABLE_CONSTANT,
            MONO_TABLE_CUSTOMATTRIBUTE,
            MONO_TABLE_FIELDMARSHAL,
            MONO_TABLE_DECLSECURITY,
            MONO_TABLE_CLASSLAYOUT,
            MONO_TABLE_FIELDLAYOUT,
            MONO_TABLE_STANDALONESIG,
            MONO_TABLE_EVENTMAP,
            MONO_TABLE_EVENT_POINTER,
            MONO_TABLE_EVENT,
            MONO_TABLE_PROPERTYMAP,
            MONO_TABLE_PROPERTY_POINTER,
            MONO_TABLE_PROPERTY,
            MONO_TABLE_METHODSEMANTICS,
            MONO_TABLE_METHODIMPL,
            MONO_TABLE_MODULEREF,
            MONO_TABLE_TYPESPEC,
            MONO_TABLE_IMPLMAP,
            MONO_TABLE_FIELDRVA,
            MONO_TABLE_UNUSED6,
            MONO_TABLE_UNUSED7,
            MONO_TABLE_ASSEMBLY,
            MONO_TABLE_ASSEMBLYPROCESSOR,
            MONO_TABLE_ASSEMBLYOS,
            MONO_TABLE_ASSEMBLYREF,
            MONO_TABLE_ASSEMBLYREFPROCESSOR,
            MONO_TABLE_ASSEMBLYREFOS,
            MONO_TABLE_FILE,
            MONO_TABLE_EXPORTEDTYPE,
            MONO_TABLE_MANIFESTRESOURCE,
            MONO_TABLE_NESTEDCLASS,
            MONO_TABLE_GENERICPARAM,
            MONO_TABLE_METHODSPEC,
            MONO_TABLE_GENERICPARAMCONSTRAINT
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Struct103
        {
            internal uint uint_0;
            internal uint UInt32_0
            {
                get
                {
                    return (this.uint_0 & 1);
                }
                set
                {
                    this.uint_0 = value | this.uint_0;
                }
            }
            internal uint UInt32_1
            {
                get
                {
                    return ((this.uint_0 & 0xfffffffe) / 2);
                }
                set
                {
                    this.uint_0 = (value * 2) | this.uint_0;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct104
        {
            internal ushort ushort_0;
            internal ushort ushort_1;
            internal uint uint_0;
            internal IntPtr intptr_0;
            internal IntPtr intptr_1;
            internal readonly IntPtr intptr_2;
            private readonly uint uint_1;
            internal uint UInt32_0
            {
                get
                {
                    return (this.uint_1 & 1);
                }
            }
            internal uint UInt32_1
            {
                get
                {
                    return ((this.uint_1 & 2) / 2);
                }
            }
            internal uint UInt32_2
            {
                get
                {
                    return ((this.uint_1 & 0x7c) / 4);
                }
            }
            internal uint UInt32_3
            {
                get
                {
                    return ((this.uint_1 & 0x80) / 0x80);
                }
            }
            internal uint UInt32_4
            {
                get
                {
                    return ((this.uint_1 & 0x100) / 0x100);
                }
            }
            internal uint UInt32_5
            {
                get
                {
                    return ((this.uint_1 & 0x200) / 0x200);
                }
            }
            internal uint UInt32_6
            {
                get
                {
                    return ((this.uint_1 & 0x400) / 0x400);
                }
            }
            internal uint UInt32_7
            {
                get
                {
                    return ((this.uint_1 & 0x800) / 0x800);
                }
            }
            internal uint UInt32_8
            {
                get
                {
                    return ((this.uint_1 & 0x1000) / 0x1000);
                }
            }
            internal uint UInt32_9
            {
                get
                {
                    return ((this.uint_1 & 0x2000) / 0x2000);
                }
            }
            internal uint UInt32_10
            {
                get
                {
                    return ((this.uint_1 & 0x4000) / 0x4000);
                }
            }
            internal uint UInt32_11
            {
                get
                {
                    return ((this.uint_1 & 0x8000) / 0x8000);
                }
            }
            internal uint UInt32_12
            {
                get
                {
                    return ((this.uint_1 & 0xffff0000) / 0x10000);
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        private struct Struct105
        {
            internal IntPtr intptr_0;
            internal ushort ushort_0;
            internal short short_0;
            internal uint uint_0;
            internal IntPtr intptr_1;
            internal uint UInt32_0
            {
                get
                {
                    return (this.uint_0 & 0xffff);
                }
                set
                {
                    this.uint_0 = value | this.uint_0;
                }
            }
            internal uint UInt32_1
            {
                get
                {
                    return ((this.uint_0 & 0x3f0000) / 0x10000);
                }
                set
                {
                    this.uint_0 = (value * 0x10000) | this.uint_0;
                }
            }
            internal uint UInt32_2
            {
                get
                {
                    return ((this.uint_0 & 0x400000) / 0x400000);
                }
                set
                {
                    this.uint_0 = (value * 0x400000) | this.uint_0;
                }
            }
            internal uint UInt32_3
            {
                get
                {
                    return ((this.uint_0 & 0x800000) / 0x800000);
                }
                set
                {
                    this.uint_0 = (value * 0x800000) | this.uint_0;
                }
            }
            internal uint UInt32_4
            {
                get
                {
                    return ((this.uint_0 & 0x1000000) / 0x1000000);
                }
                set
                {
                    this.uint_0 = (value * 0x1000000) | this.uint_0;
                }
            }
            internal uint UInt32_5
            {
                get
                {
                    return ((this.uint_0 & 0x2000000) / 0x2000000);
                }
                set
                {
                    this.uint_0 = (value * 0x2000000) | this.uint_0;
                }
            }
            internal uint UInt32_6
            {
                get
                {
                    return ((this.uint_0 & 0x4000000) / 0x4000000);
                }
                set
                {
                    this.uint_0 = (value * 0x4000000) | this.uint_0;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=2)]
        internal struct Struct106
        {
            internal IntPtr intptr_0;
            internal uint uint_0;
            internal Class272.Struct103 struct103_0;
            internal uint UInt32_0
            {
                get
                {
                    return (this.uint_0 & 0xffff);
                }
            }
            internal uint UInt32_1
            {
                get
                {
                    return ((this.uint_0 & 0xff0000) / 0x10000);
                }
            }
            internal uint UInt32_2
            {
                get
                {
                    return ((this.uint_0 & 0x3f000000) / 0x1000000);
                }
            }
            internal uint UInt32_3
            {
                get
                {
                    return ((this.uint_0 & 0x40000000) / 0x40000000);
                }
            }
            internal uint UInt32_4
            {
                get
                {
                    return ((this.uint_0 & 0x80000000) / 0x80000000);
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=2)]
        private struct Struct107
        {
            internal IntPtr intptr_0;
            internal IntPtr intptr_1;
            internal IntPtr intptr_2;
            internal ushort ushort_0;
            internal byte byte_0;
            internal int int_0;
            private uint uint_0;
            internal byte byte_1;
            private readonly uint uint_1;
            internal byte byte_2;
            internal IntPtr intptr_3;
            internal IntPtr intptr_4;
            internal IntPtr intptr_5;
            private readonly IntPtr intptr_6;
            private readonly IntPtr intptr_7;
            internal uint uint_2;
            internal int int_1;
            internal ushort ushort_1;
            internal ushort ushort_2;
            internal ushort ushort_3;
            internal ushort ushort_4;
            internal IntPtr intptr_8;
            internal IntPtr intptr_9;
            internal IntPtr intptr_10;
            internal IntPtr intptr_11;
            internal int int_2;
            internal uint uint_3;
            internal uint uint_4;
            internal uint uint_5;
            internal uint uint_6;
            internal uint uint_7;
            internal uint uint_8;
            internal IntPtr intptr_12;
            internal IntPtr intptr_13;
            internal IntPtr intptr_14;
            internal Class272.Struct106 struct106_0;
            internal Class272.Struct106 struct106_1;
            internal IntPtr intptr_15;
            internal IntPtr intptr_16;
            internal IntPtr intptr_17;
            internal IntPtr intptr_18;
            internal IntPtr intptr_19;
            internal IntPtr intptr_20;
            internal IntPtr intptr_21;
            internal uint UInt32_0
            {
                get
                {
                    return (this.uint_0 & 1);
                }
                set
                {
                    this.uint_0 = value | this.uint_0;
                }
            }
            internal uint UInt32_1
            {
                get
                {
                    return ((this.uint_0 & 2) / 2);
                }
            }
            internal uint UInt32_2
            {
                get
                {
                    return ((this.uint_0 & 4) / 4);
                }
            }
            internal uint UInt32_3
            {
                get
                {
                    return ((this.uint_0 & 8) / 8);
                }
            }
            internal uint UInt32_4
            {
                get
                {
                    return ((this.uint_0 & 0x10) / 0x10);
                }
            }
            internal uint UInt32_5
            {
                get
                {
                    return ((this.uint_0 & 0x20) / 0x20);
                }
            }
            internal uint UInt32_6
            {
                get
                {
                    return ((this.uint_0 & 0x40) / 0x40);
                }
            }
            internal uint UInt32_7
            {
                get
                {
                    return ((this.uint_0 & 0x80) / 0x80);
                }
            }
            internal uint UInt32_8
            {
                get
                {
                    return (this.uint_1 & 15);
                }
            }
            internal uint UInt32_9
            {
                get
                {
                    return ((this.uint_1 & 0x10) / 0x10);
                }
            }
            internal uint UInt32_10
            {
                get
                {
                    return ((this.uint_1 & 0x20) / 0x20);
                }
            }
            internal uint UInt32_11
            {
                get
                {
                    return ((this.uint_1 & 0x40) / 0x40);
                }
            }
            internal uint UInt32_12
            {
                get
                {
                    return ((this.uint_1 & 0x80) / 0x80);
                }
            }
            internal uint UInt32_13
            {
                get
                {
                    return ((this.uint_1 & 0x100) / 0x100);
                }
            }
            internal uint UInt32_14
            {
                get
                {
                    return ((this.uint_1 & 0x200) / 0x200);
                }
            }
            internal uint UInt32_15
            {
                get
                {
                    return ((this.uint_1 & 0x400) / 0x400);
                }
            }
            internal uint UInt32_16
            {
                get
                {
                    return ((this.uint_1 & 0x800) / 0x800);
                }
            }
            internal uint UInt32_17
            {
                get
                {
                    return ((this.uint_1 & 0x1000) / 0x1000);
                }
            }
            internal uint UInt32_18
            {
                get
                {
                    return ((this.uint_1 & 0x2000) / 0x2000);
                }
            }
            internal uint UInt32_19
            {
                get
                {
                    return ((this.uint_1 & 0x4000) / 0x4000);
                }
            }
            internal uint UInt32_20
            {
                get
                {
                    return ((this.uint_1 & 0x8000) / 0x8000);
                }
            }
            internal uint UInt32_21
            {
                get
                {
                    return ((this.uint_1 & 0x10000) / 0x10000);
                }
            }
            internal uint UInt32_22
            {
                get
                {
                    return ((this.uint_1 & 0x20000) / 0x20000);
                }
            }
            internal uint UInt32_23
            {
                get
                {
                    return ((this.uint_1 & 0x40000) / 0x40000);
                }
            }
            internal uint UInt32_24
            {
                get
                {
                    return ((this.uint_1 & 0x80000) / 0x80000);
                }
            }
            internal uint UInt32_25
            {
                get
                {
                    return ((this.uint_1 & 0x100000) / 0x100000);
                }
            }
            internal uint UInt32_26
            {
                get
                {
                    return ((this.uint_1 & 0x200000) / 0x200000);
                }
            }
            internal uint UInt32_27
            {
                get
                {
                    return ((this.uint_1 & 0x400000) / 0x400000);
                }
            }
        }
    }
}

