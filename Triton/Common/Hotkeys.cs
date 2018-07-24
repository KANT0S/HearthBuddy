namespace Triton.Common
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;
    using System.Windows.Interop;

    public static class Hotkeys
    {
        private static bool bool_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private const int int_0 = 0x312;
        private static int int_1;
        private static IntPtr intptr_0;
        private static readonly List<Hotkey> list_0 = new List<Hotkey>();
        private static readonly Queue<Hotkey> queue_0 = new Queue<Hotkey>();
        private static readonly Queue<Hotkey> queue_1 = new Queue<Hotkey>();
        private static Thread thread_0;

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();
        public static void Initialize(IntPtr windowHandleToWatch)
        {
            if (!bool_0)
            {
                MouseHook.smethod_0();
                intptr_0 = windowHandleToWatch;
                bool_0 = true;
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        private static extern bool PeekMessage(out System.Windows.Interop.MSG msg_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2);
        public static Hotkey Register(string name, Keys key, ModifierKeys modifierKeys, Action<Hotkey> callback)
        {
            Hotkey item = new Hotkey(name, key, modifierKeys, int_1++, callback);
            queue_0.Enqueue(item);
            list_0.Add(item);
            smethod_2();
            return item;
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError=true)]
        private static extern bool RegisterHotKey(IntPtr intptr_1, int int_2, uint uint_0, uint uint_1);
        private static void smethod_0(Hotkey hotkey_0)
        {
            if (!hotkey_0.Boolean_0 && RegisterHotKey(IntPtr.Zero, hotkey_0.Id, (uint) hotkey_0.ModifierKeys, (uint) hotkey_0.Key))
            {
                hotkey_0.Boolean_0 = true;
            }
        }

        private static void smethod_1(Hotkey hotkey_0)
        {
            if (hotkey_0.Boolean_0 && UnregisterHotKey(IntPtr.Zero, hotkey_0.Id))
            {
                hotkey_0.Boolean_0 = false;
            }
        }

        private static void smethod_2()
        {
            if (thread_0 == null)
            {
                Thread thread1 = new Thread(new ThreadStart(Hotkeys.smethod_3)) {
                    Name = "Hotkey Processing Loop",
                    IsBackground = true
                };
                thread_0 = thread1;
                thread_0.Start();
            }
        }

        private static void smethod_3()
        {
            while (queue_0.Count != 0)
            {
                List<Hotkey>.Enumerator enumerator;
                smethod_0(queue_0.Dequeue());
                continue;
            Label_001A:
                smethod_1(queue_1.Dequeue());
            Label_0029:
                if (queue_1.Count != 0)
                {
                    goto Label_001A;
                }
                if (!Boolean_0)
                {
                    using (enumerator = list_0.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            smethod_1(enumerator.Current);
                        }
                        goto Label_00AC;
                    }
                }
                using (enumerator = list_0.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        smethod_0(enumerator.Current);
                    }
                }
                MouseHook.smethod_0();
                smethod_4();
            Label_00AC:
                Thread.Sleep(100);
            }
            goto Label_0029;
        }

        private static void smethod_4()
        {
            Class229 class2 = new Class229();
            while (PeekMessage(out class2.msg_0, IntPtr.Zero, 0x312, 0x312, 1))
            {
                Hotkey hotkey = RegisteredHotkeys.FirstOrDefault<Hotkey>(class2.func_0 ?? (class2.func_0 = new Func<Hotkey, bool>(class2.method_0)));
                if (hotkey != null)
                {
                    ilog_0.DebugFormat(hotkey.Name + " pressed.", Array.Empty<object>());
                    hotkey.Callback(hotkey);
                }
            }
        }

        public static void Unregister(string name)
        {
            Class228 class2 = new Class228 {
                string_0 = name
            };
            Unregister(list_0.FirstOrDefault<Hotkey>(new Func<Hotkey, bool>(class2.method_0)));
        }

        public static void Unregister(Hotkey hotkey)
        {
            if (hotkey != null)
            {
                queue_1.Enqueue(hotkey);
                list_0.Remove(hotkey);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr intptr_1, int int_2);

        internal static bool Boolean_0
        {
            get
            {
                return (GetForegroundWindow() == intptr_0);
            }
        }

        public static IEnumerable<Hotkey> RegisteredHotkeys
        {
            get
            {
                return list_0.AsReadOnly();
            }
        }

        [CompilerGenerated]
        private sealed class Class228
        {
            public string string_0;

            internal bool method_0(Hotkey hotkey_0)
            {
                return (hotkey_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class229
        {
            public Func<Hotkey, bool> func_0;
            public System.Windows.Interop.MSG msg_0;

            internal bool method_0(Hotkey hotkey_0)
            {
                return (hotkey_0.Id == ((int) this.msg_0.wParam));
            }
        }
    }
}

