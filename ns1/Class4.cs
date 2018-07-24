namespace ns1
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    internal class Class4
    {
        private const int int_0 = 3;
        private const int int_1 = 0;
        private const int int_2 = 2;
        private const int int_3 = 1;
        private const int int_4 = 5;
        private Struct0 struct0_0;
        private const uint uint_0 = 0x30;

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string string_0, string string_1);
        public void method_0(string string_0, string string_1)
        {
            this.struct0_0 = new Struct0();
            this.struct0_0.uint_0 = (uint) Marshal.SizeOf(this.struct0_0.GetType());
            if (FindWindow(string_0, string_1) == IntPtr.Zero)
            {
                throw new Exception("Failed to find an AppBar that matched the given criteria");
            }
            if (SHAppBarMessage(5, ref this.struct0_0) != 1)
            {
                throw new Exception("Failed to communicate with the given AppBar");
            }
        }

        public void method_1()
        {
            this.method_0("Shell_TrayWnd", null);
        }

        [DllImport("shell32.dll")]
        private static extern uint SHAppBarMessage(uint uint_1, ref Struct0 struct0_1);
        [DllImport("user32.dll")]
        private static extern int SystemParametersInfo(uint uint_1, uint uint_2, IntPtr intptr_0, uint uint_3);

        public Enum0 Enum0_0
        {
            get
            {
                return (Enum0) this.struct0_0.uint_2;
            }
        }

        public Rectangle Rectangle_0
        {
            get
            {
                Struct1 structure = new Struct1();
                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<Struct1>(structure));
                structure = (Struct1) Marshal.PtrToStructure(ptr, structure.GetType());
                if (SystemParametersInfo(0x30, 0, ptr, 0) == 1)
                {
                    Marshal.FreeHGlobal(ptr);
                    return new Rectangle(structure.int_0, structure.int_1, structure.int_2 - structure.int_0, structure.int_3 - structure.int_1);
                }
                return new Rectangle(0, 0, 0, 0);
            }
        }

        public enum Enum0
        {
            Bottom = 3,
            Left = 0,
            Right = 2,
            Top = 1,
            Undefined = -1
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct0
        {
            public uint uint_0;
            public IntPtr intptr_0;
            public uint uint_1;
            public uint uint_2;
            public Class4.Struct1 struct1_0;
            public int int_0;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct1
        {
            public int int_0;
            public int int_1;
            public int int_2;
            public int int_3;
        }
    }
}

