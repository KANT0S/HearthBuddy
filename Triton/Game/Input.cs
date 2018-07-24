namespace Triton.Game
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;
    using Triton.Common;

    public static class Input
    {
        [CompilerGenerated]
        private static bool bool_0;
        public static int InputEventMsDelay = 50;
        private static readonly Stopwatch stopwatch_0 = Stopwatch.StartNew();

        static Input()
        {
            DebugMouseCursorPos = false;
            Hotkeys.Register("TritonHs.Input.DebugMouseCursorPos", Keys.X, ModifierKeys.Shift | ModifierKeys.Alt, new Action<Hotkey>(Class237.<>9.method_0));
            Hotkeys.Register("TritonHs.ProcessHookManager.Disable", Keys.D, ModifierKeys.Shift | ModifierKeys.Alt, new Action<Hotkey>(Class237.<>9.method_1));
            Hotkeys.Register("TritonHs.ProcessHookManager.Enable", Keys.E, ModifierKeys.Shift | ModifierKeys.Alt, new Action<Hotkey>(Class237.<>9.method_2));
            Hotkeys.Register("TritonHs.ProcessHookManager.Reset", Keys.R, ModifierKeys.Shift | ModifierKeys.Alt, new Action<Hotkey>(Class237.<>9.method_3));
        }

        public static void DblClickLMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x203, (IntPtr) 1, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void DblClickMMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x209, (IntPtr) 0x10, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void DblClickRMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x206, (IntPtr) 2, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void DblClickXB1()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x20d, (IntPtr) 0x10020, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void DblClickXB2()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x20d, (IntPtr) 0x20040, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void MoveMouse(int cx, int cy)
        {
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                Interop.SendMessage(IntPtr_0, 0x20, IntPtr_0, (IntPtr) 0x2000001);
                Interop.SendMessage(IntPtr_0, 0x200, IntPtr.Zero, (IntPtr) ((cx & 0xffff) | ((cy & 0xffff) << 0x10)));
            }
        }

        public static void PressKey(Keys key, bool downOnly = true)
        {
            smethod_1((IntPtr) key, (IntPtr) Interop.MapVirtualKeyW(key), downOnly);
        }

        public static void PressKey(Keys key, char keyCode, bool downOnly = true)
        {
            smethod_1((IntPtr) key, (IntPtr) keyCode, downOnly);
        }

        public static void PressLMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x201, (IntPtr) 1, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void PressMMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x207, (IntPtr) 0x10, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void PressRMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x204, (IntPtr) 2, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void PressXB1()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x20b, (IntPtr) 0x10020, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void PressXB2()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x20b, (IntPtr) 0x20040, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void ReleaseKey(Keys key)
        {
            smethod_0((IntPtr) key, (IntPtr) Interop.MapVirtualKeyW(key));
        }

        public static void ReleaseKey(Keys key, char keyCode)
        {
            smethod_0((IntPtr) key, (IntPtr) keyCode);
        }

        public static void ReleaseLMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x202, (IntPtr) 1, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void ReleaseMMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 520, (IntPtr) 0x10, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void ReleaseRMB()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x205, (IntPtr) 2, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void ReleaseXB1()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x20c, (IntPtr) 0x10020, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void ReleaseXB2()
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x20c, (IntPtr) 0x20040, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        public static void SetMousePos(int cx, int cy)
        {
            RectWin32 client = ProcessHookManager.WindowInfo.Client;
            ProcessHookManager.ScreenToClient(cx, cy, 1);
            ProcessHookManager.SetCursorPos(cx + client.Left, cy + client.Top, 1);
            MoveMouse(cx, cy);
            if (DebugMouseCursorPos)
            {
                Interop.SetCursorPos(cx + client.Left, cy + client.Top);
            }
        }

        internal static void smethod_0(IntPtr intptr_0, IntPtr intptr_1)
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x101, intptr_0, IntPtr.Zero);
            }
            stopwatch_0.Restart();
        }

        internal static void smethod_1(IntPtr intptr_0, IntPtr intptr_1, bool bool_1)
        {
            int millisecondsTimeout = InputEventMsDelay - ((int) stopwatch_0.ElapsedMilliseconds);
            using (TritonHs.Memory.ReleaseFrame(true))
            {
                if (millisecondsTimeout > 0)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
                Interop.SendMessage(IntPtr_0, 0x100, intptr_0, IntPtr.Zero);
                if (!bool_1)
                {
                    Interop.SendMessage(IntPtr_0, 0x102, intptr_1, IntPtr.Zero);
                    Interop.SendMessage(IntPtr_0, 0x101, intptr_0, IntPtr.Zero);
                }
            }
            stopwatch_0.Restart();
        }

        public static bool DebugMouseCursorPos
        {
            [CompilerGenerated]
            get
            {
                return bool_0;
            }
            [CompilerGenerated]
            set
            {
                bool_0 = value;
            }
        }

        private static IntPtr IntPtr_0
        {
            get
            {
                return TritonHs.ClientWindowHandle;
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class237
        {
            public static readonly Input.Class237 <>9 = new Input.Class237();

            internal void method_0(Hotkey hotkey_0)
            {
                Input.DebugMouseCursorPos = !Input.DebugMouseCursorPos;
            }

            internal void method_1(Hotkey hotkey_0)
            {
                ProcessHookManager.Disable();
            }

            internal void method_2(Hotkey hotkey_0)
            {
                ProcessHookManager.Enable();
            }

            internal void method_3(Hotkey hotkey_0)
            {
                ProcessHookManager.Reset();
            }
        }
    }
}

