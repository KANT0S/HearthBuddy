namespace Triton.Game
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    public static class Interop
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        public static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);
        [DllImport("user32.dll", SetLastError=true)]
        internal static extern IntPtr FindWindow(string string_0, string string_1);
        [DllImport("USER32.DLL", CharSet=CharSet.Unicode)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError=true)]
        public static extern bool GetWindowInfo(IntPtr hWnd, ref WindowInfoWin32 pwi);
        public static char MapVirtualKeyW(Keys key)
        {
            return (char) MapVirtualKeyW((uint) key, 2);
        }

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError=true)]
        public static extern bool SetCursorPos(int x, int y);
        internal static IntPtr smethod_0(Process process_0, string string_0)
        {
            foreach (IntPtr ptr in smethod_1(process_0))
            {
                StringBuilder lpClassName = new StringBuilder(0x400);
                GetClassName(ptr, lpClassName, lpClassName.Capacity);
                if (lpClassName.ToString() == string_0)
                {
                    return ptr;
                }
            }
            return IntPtr.Zero;
        }

        internal static IEnumerable<IntPtr> smethod_1(Process process_0)
        {
            Class241 class2 = new Class241 {
                list_0 = new List<IntPtr>()
            };
            using (IEnumerator enumerator = process_0.Threads.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    EnumThreadWindows(((ProcessThread) enumerator.Current).Id, class2.enumThreadDelegate_0 ?? (class2.enumThreadDelegate_0 = new EnumThreadDelegate(class2.method_0)), IntPtr.Zero);
                }
            }
            return class2.list_0;
        }

        [CompilerGenerated]
        private sealed class Class241
        {
            public Interop.EnumThreadDelegate enumThreadDelegate_0;
            public List<IntPtr> list_0;

            internal bool method_0(IntPtr intptr_0, IntPtr intptr_1)
            {
                this.list_0.Add(intptr_0);
                return true;
            }
        }

        public delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);
    }
}

