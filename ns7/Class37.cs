namespace ns7
{
    using ns6;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal static class Class37
    {
        private const int int_0 = 0x80;
        private const int int_1 = 0x6f;
        private const int int_2 = 0x100;
        private const int int_3 = 8;

        [DllImport("iphlpapi.dll", CharSet=CharSet.Ansi)]
        public static extern int GetAdaptersInfo(IntPtr intptr_0, ref long long_0);
        [IteratorStateMachine(typeof(Class38))]
        internal static IEnumerable<Struct5> smethod_0()
        {
            return new Class38(-2);
        }

        [CompilerGenerated]
        private sealed class Class38 : IEnumerable<Class37.Struct5>, IEnumerator<Class37.Struct5>, IDisposable, IEnumerable, IEnumerator
        {
            private int int_0;
            private int int_1;
            private IntPtr intptr_0;
            private Class37.Struct5 struct5_0;
            private Class37.Struct5 struct5_1;

            [DebuggerHidden]
            public Class38(int <>1__state)
            {
                this.int_0 = <>1__state;
                this.int_1 = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            IEnumerator<Class37.Struct5> IEnumerable<Class37.Struct5>.GetEnumerator()
            {
                if ((this.int_0 == -2) && (this.int_1 == Environment.CurrentManagedThreadId))
                {
                    this.int_0 = 0;
                    return this;
                }
                return new Class37.Class38(0);
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.System.Collections.Generic.IEnumerable<ns7.Class37.Struct5>.GetEnumerator();
            }

            bool IEnumerator.MoveNext()
            {
                IntPtr ptr;
                int num = this.int_0;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return false;
                    }
                    this.int_0 = -1;
                    ptr = this.struct5_1.intptr_0;
                    this.struct5_1 = new Class37.Struct5();
                    if (ptr != IntPtr.Zero)
                    {
                        goto Label_00B7;
                    }
                    Marshal.FreeHGlobal(this.intptr_0);
                    goto Label_00F2;
                }
                this.int_0 = -1;
                long num2 = Marshal.SizeOf(typeof(Class37.Struct5));
                this.intptr_0 = Marshal.AllocHGlobal(new IntPtr(num2));
                int adaptersInfo = Class37.GetAdaptersInfo(this.intptr_0, ref num2);
                if (adaptersInfo == 0x6f)
                {
                    this.intptr_0 = Marshal.ReAllocHGlobal(this.intptr_0, new IntPtr(num2));
                    adaptersInfo = Class37.GetAdaptersInfo(this.intptr_0, ref num2);
                }
                if (adaptersInfo != 0)
                {
                    Marshal.FreeHGlobal(this.intptr_0);
                    goto Label_00F2;
                }
                ptr = this.intptr_0;
            Label_00B7:
                this.struct5_1 = (Class37.Struct5) Marshal.PtrToStructure(ptr, typeof(Class37.Struct5));
                this.struct5_0 = this.struct5_1;
                this.int_0 = 1;
                return true;
            Label_00F2:
                return false;
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

            Class37.Struct5 IEnumerator<Class37.Struct5>.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.struct5_0;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.struct5_0;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Struct5
        {
            public IntPtr intptr_0;
            public int int_0;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)]
            public string string_0;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x84)]
            public string string_1;
            public uint uint_0;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
            public byte[] byte_0;
            public int int_1;
            public Enum3 enum3_0;
            public uint uint_1;
            public IntPtr intptr_1;
            public Class37.Struct7 struct7_0;
            public Class37.Struct7 struct7_1;
            public Class37.Struct7 struct7_2;
            public bool bool_0;
            public Class37.Struct7 struct7_3;
            public Class37.Struct7 struct7_4;
            public int int_2;
            public int int_3;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Struct6
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x10)]
            public string string_0;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Struct7
        {
            public IntPtr intptr_0;
            public Class37.Struct6 struct6_0;
            public Class37.Struct6 struct6_1;
            public int int_0;
        }
    }
}

