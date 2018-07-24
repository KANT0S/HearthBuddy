namespace ns5
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    internal static class Class20
    {
        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
        public class Class21
        {
            public IntPtr intptr_0;
            public IntPtr intptr_1;
            public IntPtr intptr_2;
            public string string_0;
            public int int_0;
            public Class20.Delegate0 delegate0_0;
            public IntPtr intptr_3;
            public int int_1;
        }

        [SuppressUnmanagedCodeSecurity]
        internal static class Class22
        {
            [DllImport("shell32.dll", CharSet=CharSet.Auto)]
            public static extern IntPtr SHBrowseForFolder([In] Class20.Class21 class21_0);
            [DllImport("shell32.dll")]
            public static extern int SHGetMalloc([Out, MarshalAs(UnmanagedType.LPArray)] Class20.Interface0[] interface0_0);
            [DllImport("shell32.dll", CharSet=CharSet.Auto)]
            public static extern bool SHGetPathFromIDList(IntPtr intptr_0, IntPtr intptr_1);
            [DllImport("shell32.dll")]
            public static extern int SHGetSpecialFolderLocation(IntPtr intptr_0, int int_0, ref IntPtr intptr_1);
        }

        internal static class Class23
        {
            [DllImport("user32.dll", SetLastError=true)]
            public static extern IntPtr FindWindowEx(HandleRef handleRef_0, IntPtr intptr_0, string string_0, string string_1);
            [DllImport("user32.dll", CharSet=CharSet.Auto)]
            public static extern IntPtr SendMessage(HandleRef handleRef_0, int int_0, int int_1, string string_0);
            [DllImport("user32.dll", EntryPoint="SendMessage", CharSet=CharSet.Auto)]
            public static extern IntPtr SendMessage_1(HandleRef handleRef_0, int int_0, int int_1, int int_2);
            [DllImport("user32.dll", SetLastError=true)]
            public static extern bool SetWindowText(IntPtr intptr_0, string string_0);
        }

        public delegate int Delegate0(IntPtr hwnd, int msg, IntPtr lParam, IntPtr lpData);

        [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), SuppressUnmanagedCodeSecurity, Guid("00000002-0000-0000-c000-000000000046")]
        public interface Interface0
        {
            [PreserveSig]
            IntPtr Alloc(int cb);
            [PreserveSig]
            IntPtr Realloc(IntPtr pv, int cb);
            [PreserveSig]
            void Free(IntPtr pv);
            [PreserveSig]
            int GetSize(IntPtr pv);
            [PreserveSig]
            int DidAlloc(IntPtr pv);
            [PreserveSig]
            void HeapMinimize();
        }
    }
}

