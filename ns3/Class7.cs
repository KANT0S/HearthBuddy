namespace ns3
{
    using ns2;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    internal class Class7
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError=true)]
        private static extern bool CloseHandle(IntPtr intptr_0);
        [DllImport("kernel32.dll", CharSet=CharSet.Unicode, SetLastError=true)]
        private static extern IntPtr CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.U4)] uint uint_0, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] uint uint_2, [MarshalAs(UnmanagedType.U4)] uint uint_3, IntPtr intptr_1);
        [return: MarshalAs(UnmanagedType.I1)]
        [DllImport("kernel32.dll", SetLastError=true)]
        private static extern bool CreateSymbolicLink(string string_0, string string_1, Enum2 enum2_0);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentProcess();
        [DllImport("Kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        private static extern uint GetFinalPathNameByHandle(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, uint uint_0, uint uint_1);
        [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        private static extern uint GetLogicalDriveStrings(uint uint_0, [Out] char[] char_0);
        [DllImport("psapi.dll")]
        private static extern uint GetProcessImageFileName(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In, MarshalAs(UnmanagedType.U4)] int int_0);
        public Class6 method_0(string string_0)
        {
            for (int i = 0; i < 100; i++)
            {
                bool flag;
                if (i != 0)
                {
                    Thread.Sleep(100);
                }
                using (new Mutex(true, string_0 + "-Startup", out flag))
                {
                    if (flag)
                    {
                        string str;
                        string str2;
                        if (!smethod_4(out str))
                        {
                            return Class6.smethod_2("Could not get image file name");
                        }
                        if (!File.Exists(str))
                        {
                            string location = Assembly.GetEntryAssembly().Location;
                            if (!File.Exists(location))
                            {
                                string str5;
                                string str4 = Path.Combine(Path.GetDirectoryName(str), string_0 + ".exe");
                                if (!this.method_1(str4, out str5))
                                {
                                    return Class6.smethod_2("Someone else won the rename race but the sym link could not be resolved");
                                }
                                smethod_5(string_0, str);
                                return Class6.smethod_0(str5);
                            }
                            str = location;
                        }
                        if (!this.method_1(str, out str2))
                        {
                            return Class6.smethod_2("Could not get final path for image file name");
                        }
                        if (!string.Equals(str, str2, StringComparison.OrdinalIgnoreCase))
                        {
                            return Class6.smethod_1(str);
                        }
                        Class6 class1 = smethod_0(str, string_0);
                        if (class1.Enum1_0 == Enum1.Success)
                        {
                            smethod_5(string_0, str);
                        }
                        return class1;
                    }
                }
            }
            return Class6.smethod_2("Failed to rename after several tries");
        }

        private bool method_1(string string_0, out string string_1)
        {
            string_1 = null;
            IntPtr ptr = CreateFileW(string_0, 0x80000000, 1, IntPtr.Zero, 3, 0x80, IntPtr.Zero);
            if (ptr == new IntPtr(-1))
            {
                return false;
            }
            try
            {
                uint num;
                StringBuilder builder = new StringBuilder(260);
                goto Label_0050;
            Label_003E:
                if (num < builder.Capacity)
                {
                    goto Label_0066;
                }
                builder.Capacity = (int) num;
            Label_0050:
                num = GetFinalPathNameByHandle(ptr, builder, (uint) builder.Capacity, 0);
                if (num != 0)
                {
                    goto Label_003E;
                }
                return false;
            Label_0066:
                string_1 = builder.ToString();
                if (string_1.StartsWith(@"\\?\"))
                {
                    string_1 = string_1.Substring(4);
                }
            }
            finally
            {
                CloseHandle(ptr);
            }
            return true;
        }

        [DllImport("kernel32.dll")]
        private static extern uint QueryDosDevice(string string_0, StringBuilder stringBuilder_0, uint uint_0);
        private static Class6 smethod_0(string string_0, string string_1)
        {
            string path = Path.Combine(Path.GetDirectoryName(string_0), string_1 + ".exe");
            File.Delete(path);
            string fileName = Path.GetFileName(smethod_1(string_0));
            if (!CreateSymbolicLink(path, fileName, Enum2.File))
            {
                if (Marshal.GetLastWin32Error() == 1)
                {
                    throw new Exception("Could not setup new sym link - the device does not support symbolic links.\r\n" + string.Format("Please make sure the drive you are attempting to use {0} on is ", string_1) + string.Format("formatted with the NTFS file system, or copy {0} to the system drive.", string_1));
                }
                Win32Exception exception = new Win32Exception();
                throw new Exception(string.Format("Could not setup new sym link - {0} ({1:x8}", exception.Message, exception.NativeErrorCode));
            }
            if (string.Equals(string_0, path, StringComparison.OrdinalIgnoreCase))
            {
                return Class6.smethod_1(path);
            }
            return Class6.smethod_0(path);
        }

        private static string smethod_1(string string_0)
        {
            string destFileName = smethod_2(Path.GetDirectoryName(string_0));
            File.Move(string_0, destFileName);
            string path = Path.ChangeExtension(string_0, ".exe.config");
            if (File.Exists(path))
            {
                File.Move(path, Path.Combine(Path.GetDirectoryName(destFileName), Path.GetFileNameWithoutExtension(destFileName) + ".exe.config"));
            }
            return destFileName;
        }

        private static string smethod_2(string string_0)
        {
            Random random = new Random(smethod_3(Environment.UserName + "unique"));
            StringBuilder builder = new StringBuilder(10);
            while (true)
            {
                builder.Clear();
                for (int i = 0; i < builder.Capacity; i++)
                {
                    builder.Append("abcdefghijklmnopqrstuvxyz"[random.Next("abcdefghijklmnopqrstuvxyz".Length)]);
                }
                if (!Process.GetProcessesByName(builder.ToString()).Any<Process>())
                {
                    string path = Path.Combine(string_0, builder + ".exe");
                    if (!File.Exists(path))
                    {
                        return path;
                    }
                }
            }
        }

        private static int smethod_3(string string_0)
        {
            uint num = 0x811c9dc5;
            foreach (char ch in string_0)
            {
                num *= 0x1000193;
                num ^= (byte) ch;
                num *= 0x1000193;
                num ^= (byte) (ch >> 8);
            }
            return (int) num;
        }

        private static bool smethod_4(out string string_0)
        {
            string_0 = null;
            StringBuilder builder = new StringBuilder(260);
            if (GetProcessImageFileName(GetCurrentProcess(), builder, 260) != 0)
            {
                char[] chArray = new char[0x1000];
                if (GetLogicalDriveStrings(0xfff, chArray) == 0)
                {
                    return false;
                }
                for (int i = 0; i < chArray.Length; i++)
                {
                    string str = chArray[i].ToString() + ":";
                    StringBuilder builder2 = new StringBuilder(260);
                    if ((QueryDosDevice(str, builder2, 260) == 0) || !builder.ToString().StartsWith(builder2.ToString()))
                    {
                        goto Label_0092;
                    }
                    string_0 = str + builder.ToString(builder2.Length, builder.Length - builder2.Length);
                    return true;
                Label_008E:
                    i++;
                Label_0092:
                    if (chArray[i] != '\0')
                    {
                        goto Label_008E;
                    }
                }
            }
            return false;
        }

        private static void smethod_5(string string_0, string string_1)
        {
            Class8 class1 = new Class8 {
                string_0 = string_1,
                string_1 = string_0
            };
            Task.Run(new Func<Task>(class1.method_0));
        }

        [CompilerGenerated]
        private sealed class Class8
        {
            public string string_0;
            public string string_1;

            [AsyncStateMachine(typeof(Struct2))]
            internal Task method_0()
            {
                Struct2 struct2;
                struct2.class8_0 = this;
                struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
                struct2.int_0 = -1;
                struct2.asyncTaskMethodBuilder_0.Start<Struct2>(ref struct2);
                return struct2.asyncTaskMethodBuilder_0.Task;
            }

            private struct Struct2 : IAsyncStateMachine
            {
                public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
                public Class7.Class8 class8_0;
                public int int_0;
                private TaskAwaiter taskAwaiter_0;

                private void MoveNext()
                {
                    int num = this.int_0;
                    try
                    {
                        if (num != 0)
                        {
                            goto Label_0035;
                        }
                        TaskAwaiter awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter();
                        num = -1;
                        this.int_0 = -1;
                    Label_0026:
                        awaiter.GetResult();
                        awaiter = new TaskAwaiter();
                    Label_0035:
                        if (File.Exists(this.class8_0.string_0))
                        {
                            try
                            {
                                EventLog log = new EventLog("Application");
                                try
                                {
                                    log.Source = this.class8_0.string_1;
                                    log.WriteEntry(string.Format("{0} detected a dangerous file rename and terminated itself for safety.", this.class8_0.string_1), EventLogEntryType.Error);
                                }
                                finally
                                {
                                    if ((num < 0) && (log != null))
                                    {
                                        log.Dispose();
                                    }
                                }
                            }
                            catch
                            {
                            }
                            goto Label_00B2;
                        }
                    Label_0094:
                        awaiter = Task.Delay(250).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto Label_0026;
                        }
                        goto Label_00BE;
                    Label_00B2:
                        Process.GetCurrentProcess().Kill();
                        goto Label_0094;
                    Label_00BE:
                        num = 0;
                        this.int_0 = 0;
                        this.taskAwaiter_0 = awaiter;
                        this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class7.Class8.Struct2>(ref awaiter, ref this);
                    }
                    catch (Exception exception)
                    {
                        this.int_0 = -2;
                        this.asyncTaskMethodBuilder_0.SetException(exception);
                    }
                }

                [DebuggerHidden]
                private void SetStateMachine(IAsyncStateMachine stateMachine)
                {
                    this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
                }
            }
        }

        private enum Enum2
        {
            File,
            Directory
        }
    }
}

