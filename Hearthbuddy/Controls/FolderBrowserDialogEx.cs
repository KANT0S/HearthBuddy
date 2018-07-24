namespace Hearthbuddy.Controls
{
    using ns5;
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Security.Permissions;
    using System.Threading;
    using System.Windows.Forms;

    public class FolderBrowserDialogEx : CommonDialog
    {
        private bool bool_0;
        private bool bool_1 = true;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5 = true;
        private bool bool_6;
        private Class20.Delegate0 delegate0_0;
        private static readonly int int_0 = 260;
        private int int_1;
        private IntPtr intptr_0;
        private IntPtr intptr_1;
        private Environment.SpecialFolder specialFolder_0;
        private string string_0;
        private string string_1;

        public event EventHandler HelpRequest
        {
            add
            {
                base.HelpRequest += value;
            }
            remove
            {
                base.HelpRequest -= value;
            }
        }

        public FolderBrowserDialogEx()
        {
            this.Reset();
        }

        public static FolderBrowserDialogEx ComputerBrowser()
        {
            FolderBrowserDialogEx ex1 = new FolderBrowserDialogEx();
            ex1.method_1();
            return ex1;
        }

        private void method_0()
        {
            this.int_1 += 0x2000;
            this.Description = "Select a printer:";
            Class20.Class22.SHGetSpecialFolderLocation(IntPtr.Zero, 4, ref this.intptr_1);
            this.ShowNewFolderButton = false;
            this.ShowEditBox = false;
        }

        private void method_1()
        {
            this.int_1 += 0x1000;
            this.Description = "Select a computer:";
            Class20.Class22.SHGetSpecialFolderLocation(IntPtr.Zero, 0x12, ref this.intptr_1);
            this.ShowNewFolderButton = false;
            this.ShowEditBox = false;
        }

        private int method_2(IntPtr intptr_2, int int_2, IntPtr intptr_3, IntPtr intptr_4)
        {
            if (int_2 != 1)
            {
                if (int_2 == 2)
                {
                    IntPtr ptr = intptr_3;
                    if (ptr != IntPtr.Zero)
                    {
                        if (((this.int_1 & 0x2000) != 0x2000) && ((this.int_1 & 0x1000) != 0x1000))
                        {
                            IntPtr ptr2 = Marshal.AllocHGlobal((int) (int_0 * Marshal.SystemDefaultCharSize));
                            bool flag = Class20.Class22.SHGetPathFromIDList(ptr, ptr2);
                            string str = Marshal.PtrToStringAuto(ptr2);
                            Marshal.FreeHGlobal(ptr2);
                            Class20.Class23.SendMessage_1(new HandleRef(null, intptr_2), 0x465, 0, flag ? 1 : 0);
                            if (flag && !string.IsNullOrEmpty(str))
                            {
                                if ((this.bool_4 && this.bool_5) && (this.intptr_0 != IntPtr.Zero))
                                {
                                    Class20.Class23.SetWindowText(this.intptr_0, str);
                                }
                                if ((this.int_1 & 4) == 4)
                                {
                                    Class20.Class23.SendMessage(new HandleRef(null, intptr_2), 0x464, 0, str);
                                }
                            }
                        }
                        else
                        {
                            Class20.Class23.SendMessage_1(new HandleRef(null, intptr_2), 0x465, 0, 1);
                        }
                    }
                }
            }
            else if (this.string_1.Length != 0)
            {
                Class20.Class23.SendMessage(new HandleRef(null, intptr_2), 0x467, 1, this.string_1);
                if (this.bool_4 && this.bool_5)
                {
                    this.intptr_0 = Class20.Class23.FindWindowEx(new HandleRef(null, intptr_2), IntPtr.Zero, "Edit", null);
                    Class20.Class23.SetWindowText(this.intptr_0, this.string_1);
                }
            }
            return 0;
        }

        public static FolderBrowserDialogEx PrinterBrowser()
        {
            FolderBrowserDialogEx ex1 = new FolderBrowserDialogEx();
            ex1.method_0();
            return ex1;
        }

        public override void Reset()
        {
            this.specialFolder_0 = Environment.SpecialFolder.Desktop;
            this.string_0 = string.Empty;
            this.string_1 = string.Empty;
            this.bool_2 = false;
            this.bool_6 = true;
            this.bool_4 = true;
            this.bool_1 = true;
            this.bool_0 = false;
            this.intptr_0 = IntPtr.Zero;
            this.intptr_1 = IntPtr.Zero;
        }

        protected override bool RunDialog(IntPtr hWndOwner)
        {
            bool flag = false;
            if (this.intptr_1 == IntPtr.Zero)
            {
                Class20.Class22.SHGetSpecialFolderLocation(hWndOwner, (int) this.specialFolder_0, ref this.intptr_1);
                if (this.intptr_1 == IntPtr.Zero)
                {
                    Class20.Class22.SHGetSpecialFolderLocation(hWndOwner, 0, ref this.intptr_1);
                    if (this.intptr_1 == IntPtr.Zero)
                    {
                        throw new InvalidOperationException("FolderBrowserDialogNoRootFolder");
                    }
                }
            }
            this.intptr_0 = IntPtr.Zero;
            if (this.bool_0)
            {
                this.int_1 += 2;
            }
            if (this.bool_1)
            {
                this.int_1 += 0x40;
            }
            if (!this.bool_6)
            {
                this.int_1 += 0x200;
            }
            if (this.bool_4)
            {
                this.int_1 += 0x10;
            }
            if (this.bool_3)
            {
                this.int_1 += 0x4000;
            }
            if (Control.CheckForIllegalCrossThreadCalls && (Application.OleRequired() != ApartmentState.STA))
            {
                throw new ThreadStateException("DebuggingException: ThreadMustBeSTA");
            }
            IntPtr zero = IntPtr.Zero;
            IntPtr hglobal = IntPtr.Zero;
            IntPtr ptr3 = IntPtr.Zero;
            try
            {
                Class20.Class21 class2 = new Class20.Class21();
                hglobal = Marshal.AllocHGlobal((int) (int_0 * Marshal.SystemDefaultCharSize));
                ptr3 = Marshal.AllocHGlobal((int) (int_0 * Marshal.SystemDefaultCharSize));
                this.delegate0_0 = new Class20.Delegate0(this.method_2);
                class2.intptr_1 = this.intptr_1;
                class2.intptr_0 = hWndOwner;
                class2.intptr_2 = hglobal;
                class2.string_0 = this.string_0;
                class2.int_0 = this.int_1;
                class2.delegate0_0 = this.delegate0_0;
                class2.intptr_3 = IntPtr.Zero;
                class2.int_1 = 0;
                zero = Class20.Class22.SHBrowseForFolder(class2);
                if (((this.int_1 & 0x2000) != 0x2000) && ((this.int_1 & 0x1000) != 0x1000))
                {
                    if (zero != IntPtr.Zero)
                    {
                        Class20.Class22.SHGetPathFromIDList(zero, ptr3);
                        this.bool_2 = true;
                        this.string_1 = Marshal.PtrToStringAuto(ptr3);
                        flag = true;
                    }
                    return flag;
                }
                this.string_1 = Marshal.PtrToStringAuto(class2.intptr_2);
                flag = true;
            }
            finally
            {
                Class20.Interface0 interface2 = smethod_0();
                interface2.Free(this.intptr_1);
                this.intptr_1 = IntPtr.Zero;
                if (zero != IntPtr.Zero)
                {
                    interface2.Free(zero);
                }
                if (ptr3 != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(ptr3);
                }
                if (hglobal != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(hglobal);
                }
                this.delegate0_0 = null;
            }
            return flag;
        }

        private static Class20.Interface0 smethod_0()
        {
            Class20.Interface0[] interfaceArray1 = new Class20.Interface0[1];
            Class20.Class22.SHGetMalloc(interfaceArray1);
            return interfaceArray1[0];
        }

        public string Description
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = (value == null) ? string.Empty : value;
            }
        }

        public bool DontIncludeNetworkFoldersBelowDomainLevel
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        public bool NewStyle
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        public Environment.SpecialFolder RootFolder
        {
            get
            {
                return this.specialFolder_0;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Environment.SpecialFolder), value))
                {
                    throw new InvalidEnumArgumentException("value", (int) value, typeof(Environment.SpecialFolder));
                }
                this.specialFolder_0 = value;
            }
        }

        public string SelectedPath
        {
            get
            {
                if (((this.string_1 != null) && (this.string_1.Length != 0)) && this.bool_2)
                {
                    new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.string_1).Demand();
                    this.bool_2 = false;
                }
                return this.string_1;
            }
            set
            {
                this.string_1 = (value == null) ? string.Empty : value;
                this.bool_2 = true;
            }
        }

        public bool ShowBothFilesAndFolders
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        public bool ShowEditBox
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        public bool ShowFullPathInEditBox
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        public bool ShowNewFolderButton
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                this.bool_6 = value;
            }
        }

        private class Class17
        {
            public const int int_0 = 0;
            public const int int_1 = 0x1000;
            public const int int_10 = 1;
            public const int int_11 = 0x8000;
            public const int int_12 = 4;
            public const int int_13 = 0x100;
            public const int int_14 = 0x20;
            public const int int_15 = 0x400;
            public const int int_2 = 0x2000;
            public const int int_3 = 0x4000;
            public const int int_4 = 0x80;
            public const int int_5 = 2;
            public const int int_6 = 0x10;
            public const int int_7 = 0x40;
            public const int int_8 = 0x200;
            public const int int_9 = 8;
        }

        private static class Class18
        {
            public const int int_0 = 1;
            public const int int_1 = 2;
            public const int int_2 = 3;
            public const int int_3 = 4;
            public const int int_4 = 5;
            public const int int_5 = 0x464;
            public const int int_6 = 0x465;
            public const int int_7 = 0x466;
            public const int int_8 = 0x467;
        }

        private class Class19
        {
            public const int int_0 = 4;
            public const int int_1 = 0x12;
        }
    }
}

