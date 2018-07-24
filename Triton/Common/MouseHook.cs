namespace Triton.Common
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    public static class MouseHook
    {
        private static volatile bool bool_0;
        private static Thread thread_0;

        [field: CompilerGenerated]
        public static  event MouseEventDelegate OnButtonDown;

        [field: CompilerGenerated]
        public static  event MouseEventDelegate OnButtonUp;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys keys_0);
        internal static void smethod_0()
        {
            if ((thread_0 == null) || !thread_0.IsAlive)
            {
                Thread thread1 = new Thread(new ThreadStart(MouseHook.smethod_1)) {
                    IsBackground = true,
                    Name = "Mouse Polling Thread"
                };
                thread_0 = thread1;
                thread_0.Start();
            }
        }

        private static void smethod_1()
        {
            while (true)
            {
                Thread.Sleep(100);
                if (!Hotkeys.Boolean_0)
                {
                    if (bool_0)
                    {
                        if (mouseEventDelegate_1 != null)
                        {
                            mouseEventDelegate_1();
                        }
                        bool_0 = false;
                    }
                }
                else if (Boolean_0)
                {
                    if (!bool_0)
                    {
                        if (mouseEventDelegate_0 != null)
                        {
                            mouseEventDelegate_0();
                        }
                        bool_0 = true;
                    }
                }
                else if (bool_0)
                {
                    if (mouseEventDelegate_1 != null)
                    {
                        mouseEventDelegate_1();
                    }
                    bool_0 = false;
                }
            }
        }

        private static bool Boolean_0
        {
            get
            {
                return (((GetAsyncKeyState(Keys.LButton) & 0x8001) != 0) || (((GetAsyncKeyState(Keys.RButton) & 0x8001) != 0) || ((GetAsyncKeyState(Keys.MButton) & 0x8001) != 0)));
            }
        }

        public delegate void MouseEventDelegate();
    }
}

