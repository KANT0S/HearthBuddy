namespace ns3
{
    using GreyMagic;
    using Hearthbuddy.Windows;
    using log4net;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using Triton.Common;

    internal class Class9
    {
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();

        private static string smethod_0(ExternalProcessMemory externalProcessMemory_0)
        {
            return "(Hearthstone)";
        }

        private static Mutex smethod_1(int int_0, out bool bool_0)
        {
            return new Mutex(true, @"Local\" + (((Environment.MachineName.GetHashCode() ^ int_0.GetHashCode()) ^ TimeZone.CurrentTimeZone.StandardName.GetHashCode()) ^ ("Blizz_HS_BuddyTeam".GetHashCode() + 0x19)), out bool_0);
        }

        internal static bool smethod_2(out Mutex mutex_0, out Process process_0)
        {
            mutex_0 = null;
            process_0 = null;
            Arguments arguments = CommandLine.Arguments;
            if (arguments.Exists("pid"))
            {
                try
                {
                    bool flag2;
                    int processId = int.Parse(arguments.Single("pid"));
                    process_0 = Process.GetProcessById(processId);
                    if (!smethod_3(process_0))
                    {
                        ilog_0.Error("Invalid PID specifier passed to the command line: " + arguments.Single("pid") + ". This process is not a Hearthstone client.");
                        return false;
                    }
                    mutex_0 = smethod_1(processId, out flag2);
                    if (!flag2)
                    {
                        mutex_0 = null;
                        process_0 = null;
                        ilog_0.Error("Invalid PID specifier passed to the command line: " + arguments.Single("pid") + ". This process has already been attached to.");
                        return false;
                    }
                    return true;
                }
                catch
                {
                    ilog_0.Error("Invalid PID specifier passed to the command line: " + arguments.Single("pid"));
                    return false;
                }
            }
            if (arguments.Exists("pname"))
            {
                try
                {
                    string processName = arguments.Single("pname");
                    process_0 = Process.GetProcessesByName(processName).FirstOrDefault<Process>();
                    if ((process_0 != null) && smethod_3(process_0))
                    {
                        bool flag3;
                        mutex_0 = smethod_1(process_0.Id, out flag3);
                        if (!flag3)
                        {
                            mutex_0 = null;
                            process_0 = null;
                            ilog_0.Error("Invalid PNAME specifier passed to the command line: " + arguments.Single("pname") + ". This process has already been attached to.");
                            return false;
                        }
                        return true;
                    }
                    ilog_0.Error("Invalid PNAME specifier passed to the command line: " + arguments.Single("pname") + ". This process is not a Hearthstone client.");
                    return false;
                }
                catch
                {
                    ilog_0.Error("Invalid PNAME specifier passed to the command line: " + arguments.Single("pname"));
                    return false;
                }
            }
            List<Process> list = smethod_4().ToList<Process>();
            if (list.Count != 0)
            {
                if (!arguments.Exists("noautoattach") && (list.Count == 1))
                {
                    bool flag4;
                    mutex_0 = smethod_1(list[0].Id, out flag4);
                    if (flag4)
                    {
                        process_0 = list[0];
                        return true;
                    }
                    mutex_0.Dispose();
                }
                Dictionary<Process, string> availableProcs = new Dictionary<Process, string>();
                foreach (Process process in list)
                {
                    bool flag5;
                    mutex_0 = smethod_1(process.Id, out flag5);
                    if (flag5 && (mutex_0 != null))
                    {
                        using (ExternalProcessMemory memory = new ExternalProcessMemory(process, false, false, false))
                        {
                            availableProcs.Add(process, smethod_0(memory));
                            mutex_0.ReleaseMutex();
                            mutex_0.Dispose();
                        }
                    }
                }
                ProcessSelectorWindow window = new ProcessSelectorWindow(availableProcs) {
                    Topmost = true
                };
                bool? nullable = window.ShowDialog();
                if (nullable.GetValueOrDefault() ? nullable.HasValue : false)
                {
                    bool flag6;
                    process_0 = window.Selected;
                    mutex_0 = smethod_1(process_0.Id, out flag6);
                    return true;
                }
            }
            return false;
        }

        private static bool smethod_3(Process process_0)
        {
            try
            {
                if (X509Certificate.CreateFromSignedFile(process_0.MainModule.FileName).Subject.Contains("Blizzard Entertainment, Inc.") && Directory.Exists(Path.Combine(Path.GetDirectoryName(process_0.MainModule.FileName), "Hearthstone_Data")))
                {
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        [IteratorStateMachine(typeof(rX@phK"4A_#va6moOtz6\<%\\rBaFs~U44;sDP\<Gw\\\\t)`T'.)^mUu!0hM\]%/xvtq=n/AFz>>))]
        private static IEnumerable<Process> smethod_4()
        {
            return new Class10(-2);
        }

        [CompilerGenerated]
        private sealed class Class10 : IEnumerable<Process>, IEnumerator<Process>, IDisposable, IEnumerable, IEnumerator
        {
            private int int_0;
            private int int_1;
            private int int_2;
            private Process process_0;
            private Process[] process_1;

            [DebuggerHidden]
            public Class10(int <>1__state)
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
                    goto Label_004A;
                }
                this.int_0 = -1;
                this.process_1 = Process.GetProcesses();
                this.int_2 = 0;
                while (this.int_2 < this.process_1.Length)
                {
                    Process process = this.process_1[this.int_2];
                    if (Class9.smethod_3(process))
                    {
                        this.process_0 = process;
                        this.int_0 = 1;
                        return true;
                    }
                Label_004A:
                    this.int_2++;
                }
                this.process_1 = null;
                return false;
            }

            [DebuggerHidden]
            IEnumerator<Process> IEnumerable<Process>.GetEnumerator()
            {
                if ((this.int_0 == -2) && (this.int_1 == Environment.CurrentManagedThreadId))
                {
                    this.int_0 = 0;
                    return this;
                }
                return new Class9.Class10(0);
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.System.Collections.Generic.IEnumerable<System.Diagnostics.Process>.GetEnumerator();
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

            Process IEnumerator<Process>.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.process_0;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return this.process_0;
                }
            }
        }
    }
}

