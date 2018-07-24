namespace Hardcodet.Wpf.TaskbarNotification.Interop
{
    using ns1;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class WindowMessageSink : IDisposable
    {
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        public const int CallbackMessageId = 0x400;
        [CompilerGenerated]
        private IntPtr intptr_0;
        [CompilerGenerated]
        private NotifyIconVersion notifyIconVersion_0;
        [CompilerGenerated]
        private string string_0;
        private uint uint_0;
        private WindowProcedureHandler windowProcedureHandler_0;

        [field: CompilerGenerated]
        public event Action<bool> BallonToolTipChanged;

        [field: CompilerGenerated]
        public event Action<bool> ChangeToolTipStateRequest;

        [field: CompilerGenerated]
        public event Action<MouseEvent> MouseEventReceived;

        [field: CompilerGenerated]
        public event Action TaskbarCreated;

        private WindowMessageSink()
        {
        }

        public WindowMessageSink(NotifyIconVersion version)
        {
            this.Version = version;
            this.method_0();
        }

        public void Dispose()
        {
            this.method_3(true);
            GC.SuppressFinalize(this);
        }

        ~WindowMessageSink()
        {
            this.method_3(false);
        }

        private void method_0()
        {
            WindowClass class2;
            this.String_0 = "WPFTaskbarIcon_" + DateTime.Now.Ticks;
            this.windowProcedureHandler_0 = new WindowProcedureHandler(this.method_1);
            class2.style = 0;
            class2.lpfnWndProc = this.windowProcedureHandler_0;
            class2.cbClsExtra = 0;
            class2.cbWndExtra = 0;
            class2.hInstance = IntPtr.Zero;
            class2.hIcon = IntPtr.Zero;
            class2.hCursor = IntPtr.Zero;
            class2.hbrBackground = IntPtr.Zero;
            class2.lpszMenuName = "";
            class2.lpszClassName = this.String_0;
            Class5.RegisterClassW(ref class2);
            this.uint_0 = Class5.RegisterWindowMessageW("TaskbarCreated");
            this.IntPtr_0 = Class5.CreateWindowExW(0, this.String_0, "", 0, 0, 0, 1, 1, 0, 0, 0, 0);
            if (this.IntPtr_0 == IntPtr.Zero)
            {
                throw new Win32Exception();
            }
        }

        private long method_1(IntPtr intptr_1, uint uint_1, uint uint_2, uint uint_3)
        {
            if (uint_1 == this.uint_0)
            {
                this.action_3();
            }
            this.method_2(uint_1, uint_2, uint_3);
            return Class5.DefWindowProc(intptr_1, uint_1, uint_2, uint_3);
        }

        private void method_2(uint uint_1, uint uint_2, uint uint_3)
        {
            if (uint_1 == 0x400)
            {
                switch (uint_3)
                {
                    case 0x200:
                        this.action_1(MouseEvent.MouseMove);
                        return;

                    case 0x201:
                        this.action_1(MouseEvent.IconLeftMouseDown);
                        return;

                    case 0x202:
                        if (!this.bool_0)
                        {
                            this.action_1(MouseEvent.IconLeftMouseUp);
                        }
                        this.bool_0 = false;
                        return;

                    case 0x203:
                        this.bool_0 = true;
                        this.action_1(MouseEvent.IconDoubleClick);
                        return;

                    case 0x204:
                        this.action_1(MouseEvent.IconRightMouseDown);
                        return;

                    case 0x205:
                        this.action_1(MouseEvent.IconRightMouseUp);
                        return;

                    case 0x206:
                    case 0x209:
                        return;

                    case 0x207:
                        this.action_1(MouseEvent.IconMiddleMouseDown);
                        return;

                    case 520:
                        this.action_1(MouseEvent.IconMiddleMouseUp);
                        return;

                    case 0x402:
                        this.action_2(true);
                        return;

                    case 0x403:
                    case 0x404:
                        this.action_2(false);
                        return;

                    case 0x405:
                        this.action_1(MouseEvent.BalloonToolTipClicked);
                        return;

                    case 0x406:
                        this.action_0(true);
                        return;

                    case 0x407:
                        this.action_0(false);
                        return;
                }
            }
        }

        private void method_3(bool bool_2)
        {
            if (!this.IsDisposed && bool_2)
            {
                this.IsDisposed = true;
                Class5.DestroyWindow(this.IntPtr_0);
                this.windowProcedureHandler_0 = null;
            }
        }

        internal static WindowMessageSink smethod_0()
        {
            return new WindowMessageSink { IntPtr_0 = IntPtr.Zero, Version = NotifyIconVersion.Vista };
        }

        internal IntPtr IntPtr_0
        {
            [CompilerGenerated]
            get
            {
                return this.intptr_0;
            }
            [CompilerGenerated]
            private set
            {
                this.intptr_0 = value;
            }
        }

        public bool IsDisposed
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_1 = value;
            }
        }

        internal string String_0
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }

        public NotifyIconVersion Version
        {
            [CompilerGenerated]
            get
            {
                return this.notifyIconVersion_0;
            }
            [CompilerGenerated]
            set
            {
                this.notifyIconVersion_0 = value;
            }
        }
    }
}

