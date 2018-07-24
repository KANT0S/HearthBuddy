namespace Hardcodet.Wpf.TaskbarNotification
{
    using Hardcodet.Wpf.TaskbarNotification.Interop;
    using ns0;
    using ns1;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Threading;

    public class TaskbarIcon : FrameworkElement, IDisposable
    {
        private Action action_0;
        public static readonly RoutedEvent BalloonClosingEvent = EventManager.RegisterRoutedEvent("BalloonClosing", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent BalloonShowingEvent = EventManager.RegisterRoutedEvent("BalloonShowing", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        public const string CategoryName = "NotifyIcon";
        public static readonly DependencyProperty CustomBalloonProperty = dependencyPropertyKey_2.DependencyProperty;
        private static readonly DependencyPropertyKey dependencyPropertyKey_0 = DependencyProperty.RegisterReadOnly("TrayPopupResolved", typeof(Popup), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        private static readonly DependencyPropertyKey dependencyPropertyKey_1 = DependencyProperty.RegisterReadOnly("TrayToolTipResolved", typeof(ToolTip), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        private static readonly DependencyPropertyKey dependencyPropertyKey_2 = DependencyProperty.RegisterReadOnly("CustomBalloon", typeof(Popup), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty DoubleClickCommandParameterProperty = DependencyProperty.Register("DoubleClickCommandParameter", typeof(object), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty DoubleClickCommandProperty = DependencyProperty.Register("DoubleClickCommand", typeof(ICommand), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty DoubleClickCommandTargetProperty = DependencyProperty.Register("DoubleClickCommandTarget", typeof(IInputElement), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        private System.Drawing.Icon icon_0;
        public static readonly DependencyProperty IconSourceProperty = DependencyProperty.Register("IconSource", typeof(ImageSource), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(TaskbarIcon.smethod_0)));
        public static readonly DependencyProperty LeftClickCommandParameterProperty = DependencyProperty.Register("LeftClickCommandParameter", typeof(object), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty LeftClickCommandProperty = DependencyProperty.Register("LeftClickCommand", typeof(ICommand), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty LeftClickCommandTargetProperty = DependencyProperty.Register("LeftClickCommandTarget", typeof(IInputElement), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty MenuActivationProperty = DependencyProperty.Register("MenuActivation", typeof(PopupActivationMode), typeof(TaskbarIcon), new FrameworkPropertyMetadata(PopupActivationMode.RightClick));
        private NotifyIconData notifyIconData_0;
        public static readonly DependencyProperty ParentTaskbarIconProperty = DependencyProperty.RegisterAttached("ParentTaskbarIcon", typeof(TaskbarIcon), typeof(TaskbarIcon));
        public static readonly DependencyProperty PopupActivationProperty = DependencyProperty.Register("PopupActivation", typeof(PopupActivationMode), typeof(TaskbarIcon), new FrameworkPropertyMetadata(PopupActivationMode.LeftClick));
        public static readonly RoutedEvent PopupOpenedEvent = EventManager.RegisterRoutedEvent("PopupOpened", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent PreviewTrayContextMenuOpenEvent = EventManager.RegisterRoutedEvent("PreviewTrayContextMenuOpen", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent PreviewTrayPopupOpenEvent = EventManager.RegisterRoutedEvent("PreviewTrayPopupOpen", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent PreviewTrayToolTipCloseEvent = EventManager.RegisterRoutedEvent("PreviewTrayToolTipClose", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent PreviewTrayToolTipOpenEvent = EventManager.RegisterRoutedEvent("PreviewTrayToolTipOpen", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        private readonly Timer timer_0;
        private readonly Timer timer_1;
        public static readonly RoutedEvent ToolTipCloseEvent = EventManager.RegisterRoutedEvent("ToolTipClose", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent ToolTipOpenedEvent = EventManager.RegisterRoutedEvent("ToolTipOpened", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly DependencyProperty ToolTipTextProperty = DependencyProperty.Register("ToolTipText", typeof(string), typeof(TaskbarIcon), new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(TaskbarIcon.smethod_1)));
        public static readonly RoutedEvent TrayBalloonTipClickedEvent = EventManager.RegisterRoutedEvent("TrayBalloonTipClicked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayBalloonTipClosedEvent = EventManager.RegisterRoutedEvent("TrayBalloonTipClosed", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayBalloonTipShownEvent = EventManager.RegisterRoutedEvent("TrayBalloonTipShown", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayContextMenuOpenEvent = EventManager.RegisterRoutedEvent("TrayContextMenuOpen", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayLeftMouseDownEvent = EventManager.RegisterRoutedEvent("TrayLeftMouseDown", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayLeftMouseUpEvent = EventManager.RegisterRoutedEvent("TrayLeftMouseUp", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayMiddleMouseDownEvent = EventManager.RegisterRoutedEvent("TrayMiddleMouseDown", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayMiddleMouseUpEvent = EventManager.RegisterRoutedEvent("TrayMiddleMouseUp", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayMouseDoubleClickEvent = EventManager.RegisterRoutedEvent("TrayMouseDoubleClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayMouseMoveEvent = EventManager.RegisterRoutedEvent("TrayMouseMove", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayPopupOpenEvent = EventManager.RegisterRoutedEvent("TrayPopupOpen", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly DependencyProperty TrayPopupProperty = DependencyProperty.Register("TrayPopup", typeof(UIElement), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(TaskbarIcon.smethod_3)));
        public static readonly DependencyProperty TrayPopupResolvedProperty = dependencyPropertyKey_0.DependencyProperty;
        public static readonly RoutedEvent TrayRightMouseDownEvent = EventManager.RegisterRoutedEvent("TrayRightMouseDown", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayRightMouseUpEvent = EventManager.RegisterRoutedEvent("TrayRightMouseUp", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayToolTipCloseEvent = EventManager.RegisterRoutedEvent("TrayToolTipClose", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly RoutedEvent TrayToolTipOpenEvent = EventManager.RegisterRoutedEvent("TrayToolTipOpen", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TaskbarIcon));
        public static readonly DependencyProperty TrayToolTipProperty = DependencyProperty.Register("TrayToolTip", typeof(UIElement), typeof(TaskbarIcon), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(TaskbarIcon.smethod_2)));
        public static readonly DependencyProperty TrayToolTipResolvedProperty = dependencyPropertyKey_1.DependencyProperty;
        private readonly WindowMessageSink windowMessageSink_0 = (Class3.Boolean_0 ? WindowMessageSink.smethod_0() : new WindowMessageSink(NotifyIconVersion.Win95));

        public event RoutedEventHandler PreviewTrayContextMenuOpen
        {
            add
            {
                base.AddHandler(PreviewTrayContextMenuOpenEvent, value);
            }
            remove
            {
                base.RemoveHandler(PreviewTrayContextMenuOpenEvent, value);
            }
        }

        public event RoutedEventHandler PreviewTrayPopupOpen
        {
            add
            {
                base.AddHandler(PreviewTrayPopupOpenEvent, value);
            }
            remove
            {
                base.RemoveHandler(PreviewTrayPopupOpenEvent, value);
            }
        }

        public event RoutedEventHandler PreviewTrayToolTipClose
        {
            add
            {
                base.AddHandler(PreviewTrayToolTipCloseEvent, value);
            }
            remove
            {
                base.RemoveHandler(PreviewTrayToolTipCloseEvent, value);
            }
        }

        public event RoutedEventHandler PreviewTrayToolTipOpen
        {
            add
            {
                base.AddHandler(PreviewTrayToolTipOpenEvent, value);
            }
            remove
            {
                base.RemoveHandler(PreviewTrayToolTipOpenEvent, value);
            }
        }

        public event RoutedEventHandler TrayBalloonTipClicked
        {
            add
            {
                base.AddHandler(TrayBalloonTipClickedEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayBalloonTipClickedEvent, value);
            }
        }

        public event RoutedEventHandler TrayBalloonTipClosed
        {
            add
            {
                base.AddHandler(TrayBalloonTipClosedEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayBalloonTipClosedEvent, value);
            }
        }

        public event RoutedEventHandler TrayBalloonTipShown
        {
            add
            {
                base.AddHandler(TrayBalloonTipShownEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayBalloonTipShownEvent, value);
            }
        }

        public event RoutedEventHandler TrayContextMenuOpen
        {
            add
            {
                base.AddHandler(TrayContextMenuOpenEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayContextMenuOpenEvent, value);
            }
        }

        [Category("NotifyIcon")]
        public event RoutedEventHandler TrayLeftMouseDown
        {
            add
            {
                base.AddHandler(TrayLeftMouseDownEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayLeftMouseDownEvent, value);
            }
        }

        public event RoutedEventHandler TrayLeftMouseUp
        {
            add
            {
                base.AddHandler(TrayLeftMouseUpEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayLeftMouseUpEvent, value);
            }
        }

        public event RoutedEventHandler TrayMiddleMouseDown
        {
            add
            {
                base.AddHandler(TrayMiddleMouseDownEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayMiddleMouseDownEvent, value);
            }
        }

        public event RoutedEventHandler TrayMiddleMouseUp
        {
            add
            {
                base.AddHandler(TrayMiddleMouseUpEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayMiddleMouseUpEvent, value);
            }
        }

        public event RoutedEventHandler TrayMouseDoubleClick
        {
            add
            {
                base.AddHandler(TrayMouseDoubleClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayMouseDoubleClickEvent, value);
            }
        }

        public event RoutedEventHandler TrayMouseMove
        {
            add
            {
                base.AddHandler(TrayMouseMoveEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayMouseMoveEvent, value);
            }
        }

        public event RoutedEventHandler TrayPopupOpen
        {
            add
            {
                base.AddHandler(TrayPopupOpenEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayPopupOpenEvent, value);
            }
        }

        public event RoutedEventHandler TrayRightMouseDown
        {
            add
            {
                base.AddHandler(TrayRightMouseDownEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayRightMouseDownEvent, value);
            }
        }

        public event RoutedEventHandler TrayRightMouseUp
        {
            add
            {
                base.AddHandler(TrayRightMouseUpEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayRightMouseUpEvent, value);
            }
        }

        public event RoutedEventHandler TrayToolTipClose
        {
            add
            {
                base.AddHandler(TrayToolTipCloseEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayToolTipCloseEvent, value);
            }
        }

        public event RoutedEventHandler TrayToolTipOpen
        {
            add
            {
                base.AddHandler(TrayToolTipOpenEvent, value);
            }
            remove
            {
                base.RemoveHandler(TrayToolTipOpenEvent, value);
            }
        }

        static TaskbarIcon()
        {
            PropertyMetadata typeMetadata = new PropertyMetadata(Visibility.Visible, new PropertyChangedCallback(TaskbarIcon.smethod_4));
            UIElement.VisibilityProperty.OverrideMetadata(typeof(TaskbarIcon), typeMetadata);
            typeMetadata = new FrameworkPropertyMetadata(new PropertyChangedCallback(TaskbarIcon.smethod_5));
            FrameworkElement.DataContextProperty.OverrideMetadata(typeof(TaskbarIcon), typeMetadata);
            typeMetadata = new FrameworkPropertyMetadata(new PropertyChangedCallback(TaskbarIcon.smethod_6));
            FrameworkElement.ContextMenuProperty.OverrideMetadata(typeof(TaskbarIcon), typeMetadata);
        }

        public TaskbarIcon()
        {
            this.notifyIconData_0 = NotifyIconData.CreateDefault(this.windowMessageSink_0.IntPtr_0);
            this.method_13();
            this.windowMessageSink_0.MouseEventReceived += new Action<MouseEvent>(this.method_1);
            this.windowMessageSink_0.TaskbarCreated += new Action(this.method_12);
            this.windowMessageSink_0.ChangeToolTipStateRequest += new Action<bool>(this.method_2);
            this.windowMessageSink_0.BallonToolTipChanged += new Action<bool>(this.method_8);
            this.timer_0 = new Timer(new TimerCallback(this.method_10));
            this.timer_1 = new Timer(new TimerCallback(this.method_0));
            if (Application.Current != null)
            {
                Application.Current.Exit += new ExitEventHandler(this.method_16);
            }
        }

        public static void AddBalloonClosingHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_1(element, BalloonClosingEvent, handler);
        }

        public static void AddBalloonShowingHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_1(element, BalloonShowingEvent, handler);
        }

        public static void AddPopupOpenedHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_1(element, PopupOpenedEvent, handler);
        }

        public static void AddToolTipCloseHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_1(element, ToolTipCloseEvent, handler);
        }

        public static void AddToolTipOpenedHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_1(element, ToolTipOpenedEvent, handler);
        }

        public void CloseBalloon()
        {
            if (!this.IsDisposed)
            {
                if (!Application.Current.Dispatcher.CheckAccess())
                {
                    Action method = new Action(this.CloseBalloon);
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, method);
                }
                else
                {
                    TaskbarIcon icon = this;
                    lock (icon)
                    {
                        this.timer_1.Change(-1, -1);
                        Popup customBalloon = this.CustomBalloon;
                        if (customBalloon != null)
                        {
                            UIElement child = customBalloon.Child;
                            if (!smethod_30(child, this).Handled)
                            {
                                customBalloon.IsOpen = false;
                                if (child != null)
                                {
                                    SetParentTaskbarIcon(child, null);
                                }
                            }
                            this.SetCustomBalloon(null);
                        }
                    }
                }
            }
        }

        public void Dispose()
        {
            this.method_17(true);
            GC.SuppressFinalize(this);
        }

        ~TaskbarIcon()
        {
            this.method_17(false);
        }

        public static TaskbarIcon GetParentTaskbarIcon(DependencyObject d)
        {
            return (TaskbarIcon) d.GetValue(ParentTaskbarIconProperty);
        }

        public void HideBalloonTip()
        {
            this.method_15();
            this.notifyIconData_0.BalloonText = this.notifyIconData_0.BalloonTitle = string.Empty;
            Class3.smethod_2(ref this.notifyIconData_0, NotifyCommand.Modify, IconDataMembers.Info);
        }

        private void method_0(object object_0)
        {
            if (!this.IsDisposed)
            {
                Action callback = new Action(this.CloseBalloon);
                Application.Current.Dispatcher.Invoke(callback);
            }
        }

        private void method_1(MouseEvent mouseEvent_0)
        {
            Class2 class2 = new Class2 {
                taskbarIcon_0 = this
            };
            if (!this.IsDisposed)
            {
                switch (mouseEvent_0)
                {
                    case MouseEvent.MouseMove:
                        this.RaiseTrayMouseMoveEvent();
                        return;

                    case MouseEvent.IconRightMouseDown:
                        this.RaiseTrayRightMouseDownEvent();
                        break;

                    case MouseEvent.IconLeftMouseDown:
                        this.RaiseTrayLeftMouseDownEvent();
                        break;

                    case MouseEvent.IconRightMouseUp:
                        this.RaiseTrayRightMouseUpEvent();
                        break;

                    case MouseEvent.IconLeftMouseUp:
                        this.RaiseTrayLeftMouseUpEvent();
                        break;

                    case MouseEvent.IconMiddleMouseDown:
                        this.RaiseTrayMiddleMouseDownEvent();
                        break;

                    case MouseEvent.IconMiddleMouseUp:
                        this.RaiseTrayMiddleMouseUpEvent();
                        break;

                    case MouseEvent.IconDoubleClick:
                        this.timer_0.Change(-1, -1);
                        this.RaiseTrayMouseDoubleClickEvent();
                        break;

                    case MouseEvent.BalloonToolTipClicked:
                        this.RaiseTrayBalloonTipClickedEvent();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("me", "Missing handler for mouse event flag: " + mouseEvent_0);
                }
                class2.point_0 = new Hardcodet.Wpf.TaskbarNotification.Interop.Point();
                Class5.GetCursorPos(ref class2.point_0);
                bool flag = false;
                if (mouseEvent_0.smethod_6(this.PopupActivation))
                {
                    if (mouseEvent_0 == MouseEvent.IconLeftMouseUp)
                    {
                        this.action_0 = new Action(class2.method_0);
                        this.timer_0.Change(Class5.GetDoubleClickTime(), -1);
                        flag = true;
                    }
                    else
                    {
                        this.method_6(class2.point_0);
                    }
                }
                if (mouseEvent_0.smethod_6(this.MenuActivation))
                {
                    if (mouseEvent_0 == MouseEvent.IconLeftMouseUp)
                    {
                        this.action_0 = new Action(class2.method_1);
                        this.timer_0.Change(Class5.GetDoubleClickTime(), -1);
                        flag = true;
                    }
                    else
                    {
                        this.method_7(class2.point_0);
                    }
                }
                if ((mouseEvent_0 == MouseEvent.IconLeftMouseUp) && !flag)
                {
                    this.action_0 = new Action(this.method_26);
                    this.timer_0.Change(Class5.GetDoubleClickTime(), -1);
                }
            }
        }

        private void method_10(object object_0)
        {
            if (!this.IsDisposed)
            {
                Action callback = this.action_0;
                if (callback != null)
                {
                    this.action_0 = null;
                    Application.Current.Dispatcher.Invoke(callback);
                }
            }
        }

        private void method_11()
        {
            bool flag;
            this.notifyIconData_0.VersionOrTimeout = 4;
            if (!(flag = Class5.Shell_NotifyIcon(NotifyCommand.SetVersion, ref this.notifyIconData_0)))
            {
                this.notifyIconData_0.VersionOrTimeout = 3;
                flag = Class3.smethod_1(ref this.notifyIconData_0, NotifyCommand.SetVersion);
            }
            if (!flag)
            {
                this.notifyIconData_0.VersionOrTimeout = 0;
                flag = Class3.smethod_1(ref this.notifyIconData_0, NotifyCommand.SetVersion);
            }
        }

        private void method_12()
        {
            this.IsTaskbarIconCreated = false;
            this.method_13();
        }

        private void method_13()
        {
            TaskbarIcon icon = this;
            lock (icon)
            {
                if (!this.IsTaskbarIconCreated)
                {
                    if (!Class3.smethod_2(ref this.notifyIconData_0, NotifyCommand.Add, IconDataMembers.Tip | IconDataMembers.Icon | IconDataMembers.Message))
                    {
                        throw new Win32Exception("Could not create icon data");
                    }
                    this.method_11();
                    this.windowMessageSink_0.Version = (NotifyIconVersion) this.notifyIconData_0.VersionOrTimeout;
                    this.IsTaskbarIconCreated = true;
                }
            }
        }

        private void method_14()
        {
            TaskbarIcon icon = this;
            lock (icon)
            {
                if (this.IsTaskbarIconCreated)
                {
                    Class3.smethod_2(ref this.notifyIconData_0, NotifyCommand.Delete, IconDataMembers.Message);
                    this.IsTaskbarIconCreated = false;
                }
            }
        }

        private void method_15()
        {
            if (this.IsDisposed)
            {
                throw new ObjectDisposedException(base.Name ?? base.GetType().FullName);
            }
        }

        private void method_16(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void method_17(bool bool_2)
        {
            if (!this.IsDisposed && bool_2)
            {
                TaskbarIcon icon = this;
                lock (icon)
                {
                    this.IsDisposed = true;
                    Application.Current.Exit -= new ExitEventHandler(this.method_16);
                    this.timer_0.Dispose();
                    this.timer_1.Dispose();
                    this.windowMessageSink_0.Dispose();
                    this.method_14();
                }
            }
        }

        private void method_18(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ImageSource newValue = (ImageSource) dependencyPropertyChangedEventArgs_0.NewValue;
            if (!Class3.Boolean_0)
            {
                this.Icon = newValue.smethod_4();
            }
        }

        private void method_19(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            if ((this.TrayToolTipResolved == null) || (this.TrayToolTipResolved.Content is string))
            {
                this.method_3();
            }
            this.method_4();
        }

        private void method_2(bool bool_2)
        {
            if (this.TrayToolTipResolved != null)
            {
                if (bool_2)
                {
                    if (!this.Boolean_0 && !this.RaisePreviewTrayToolTipOpenEvent().Handled)
                    {
                        this.TrayToolTipResolved.IsOpen = true;
                        if (this.TrayToolTip != null)
                        {
                            smethod_27(this.TrayToolTip);
                        }
                        this.RaiseTrayToolTipOpenEvent();
                    }
                }
                else if (!this.RaisePreviewTrayToolTipCloseEvent().Handled)
                {
                    if (this.TrayToolTip != null)
                    {
                        smethod_28(this.TrayToolTip);
                    }
                    this.TrayToolTipResolved.IsOpen = false;
                    this.RaiseTrayToolTipCloseEvent();
                }
            }
        }

        private void method_20(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            this.method_3();
            if (dependencyPropertyChangedEventArgs_0.OldValue != null)
            {
                SetParentTaskbarIcon((DependencyObject) dependencyPropertyChangedEventArgs_0.OldValue, null);
            }
            if (dependencyPropertyChangedEventArgs_0.NewValue != null)
            {
                SetParentTaskbarIcon((DependencyObject) dependencyPropertyChangedEventArgs_0.NewValue, this);
            }
            this.method_4();
        }

        private void method_21(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            if (dependencyPropertyChangedEventArgs_0.OldValue != null)
            {
                SetParentTaskbarIcon((DependencyObject) dependencyPropertyChangedEventArgs_0.OldValue, null);
            }
            if (dependencyPropertyChangedEventArgs_0.NewValue != null)
            {
                SetParentTaskbarIcon((DependencyObject) dependencyPropertyChangedEventArgs_0.NewValue, this);
            }
            this.method_5();
        }

        private void method_22(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            if (((Visibility) dependencyPropertyChangedEventArgs_0.NewValue) == Visibility.Visible)
            {
                this.method_13();
            }
            else
            {
                this.method_14();
            }
        }

        private void method_23(FrameworkElement frameworkElement_0, object object_0, object object_1)
        {
            if (((frameworkElement_0 != null) && !frameworkElement_0.smethod_8()) && ((this == frameworkElement_0.DataContext) || object.Equals(object_0, frameworkElement_0.DataContext)))
            {
                frameworkElement_0.DataContext = object_1 ?? this;
            }
        }

        private void method_24(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            object newValue = dependencyPropertyChangedEventArgs_0.NewValue;
            object oldValue = dependencyPropertyChangedEventArgs_0.OldValue;
            this.method_23(this.TrayPopupResolved, oldValue, newValue);
            this.method_23(this.TrayToolTipResolved, oldValue, newValue);
            this.method_23(base.ContextMenu, oldValue, newValue);
        }

        private void method_25(DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            if (dependencyPropertyChangedEventArgs_0.OldValue != null)
            {
                SetParentTaskbarIcon((DependencyObject) dependencyPropertyChangedEventArgs_0.OldValue, null);
            }
            if (dependencyPropertyChangedEventArgs_0.NewValue != null)
            {
                SetParentTaskbarIcon((DependencyObject) dependencyPropertyChangedEventArgs_0.NewValue, this);
            }
            this.method_23((ContextMenu) dependencyPropertyChangedEventArgs_0.NewValue, null, base.DataContext);
        }

        [CompilerGenerated]
        private void method_26()
        {
            this.LeftClickCommand.smethod_7(this.LeftClickCommandParameter, this.LeftClickCommandTarget ?? this);
        }

        private void method_3()
        {
            ToolTip trayToolTip = this.TrayToolTip as ToolTip;
            if ((trayToolTip == null) && (this.TrayToolTip != null))
            {
                trayToolTip = new ToolTip {
                    Placement = PlacementMode.Mouse,
                    HasDropShadow = false,
                    BorderThickness = new Thickness(0.0),
                    Background = System.Windows.Media.Brushes.Transparent,
                    StaysOpen = true,
                    Content = this.TrayToolTip
                };
            }
            else if ((trayToolTip == null) && !string.IsNullOrEmpty(this.ToolTipText))
            {
                trayToolTip = new ToolTip {
                    Content = this.ToolTipText
                };
            }
            if (trayToolTip != null)
            {
                this.method_23(trayToolTip, null, base.DataContext);
            }
            this.SetTrayToolTipResolved(trayToolTip);
        }

        private void method_4()
        {
            this.notifyIconData_0.ToolTipText = this.ToolTipText;
            if (((this.windowMessageSink_0.Version == NotifyIconVersion.Vista) && string.IsNullOrEmpty(this.notifyIconData_0.ToolTipText)) && (this.TrayToolTipResolved != null))
            {
                this.notifyIconData_0.ToolTipText = "ToolTip";
            }
            Class3.smethod_2(ref this.notifyIconData_0, NotifyCommand.Modify, IconDataMembers.Tip);
        }

        private void method_5()
        {
            Popup trayPopup = this.TrayPopup as Popup;
            if ((trayPopup == null) && (this.TrayPopup != null))
            {
                trayPopup = new Popup {
                    AllowsTransparency = true,
                    PopupAnimation = PopupAnimation.None,
                    Child = this.TrayPopup,
                    Placement = PlacementMode.AbsolutePoint,
                    StaysOpen = false
                };
            }
            if (trayPopup != null)
            {
                this.method_23(trayPopup, null, base.DataContext);
            }
            this.SetTrayPopupResolved(trayPopup);
        }

        private void method_6(Hardcodet.Wpf.TaskbarNotification.Interop.Point point_0)
        {
            if ((!this.IsDisposed && !this.RaisePreviewTrayPopupOpenEvent().Handled) && (this.TrayPopup != null))
            {
                this.TrayPopupResolved.Placement = PlacementMode.AbsolutePoint;
                this.TrayPopupResolved.HorizontalOffset = point_0.X;
                this.TrayPopupResolved.VerticalOffset = point_0.Y;
                this.TrayPopupResolved.IsOpen = true;
                Class5.SetForegroundWindow(this.windowMessageSink_0.IntPtr_0);
                if (this.TrayPopup != null)
                {
                    smethod_26(this.TrayPopup);
                }
                this.RaiseTrayPopupOpenEvent();
            }
        }

        private void method_7(Hardcodet.Wpf.TaskbarNotification.Interop.Point point_0)
        {
            if ((!this.IsDisposed && !this.RaisePreviewTrayContextMenuOpenEvent().Handled) && (base.ContextMenu != null))
            {
                base.ContextMenu.Placement = PlacementMode.AbsolutePoint;
                base.ContextMenu.HorizontalOffset = point_0.X;
                base.ContextMenu.VerticalOffset = point_0.Y;
                base.ContextMenu.IsOpen = true;
                Class5.SetForegroundWindow(this.windowMessageSink_0.IntPtr_0);
                this.RaiseTrayContextMenuOpenEvent();
            }
        }

        private void method_8(bool bool_2)
        {
            if (bool_2)
            {
                this.RaiseTrayBalloonTipShownEvent();
            }
            else
            {
                this.RaiseTrayBalloonTipClosedEvent();
            }
        }

        private void method_9(string string_0, string string_1, BalloonFlags balloonFlags_0, IntPtr intptr_0)
        {
            this.method_15();
            this.notifyIconData_0.BalloonText = string_1 ?? string.Empty;
            this.notifyIconData_0.BalloonTitle = string_0 ?? string.Empty;
            this.notifyIconData_0.BalloonFlags = balloonFlags_0;
            this.notifyIconData_0.CustomBalloonIconHandle = intptr_0;
            Class3.smethod_2(ref this.notifyIconData_0, NotifyCommand.Modify, IconDataMembers.Info | IconDataMembers.Icon);
        }

        protected RoutedEventArgs RaisePreviewTrayContextMenuOpenEvent()
        {
            return smethod_19(this);
        }

        protected RoutedEventArgs RaisePreviewTrayPopupOpenEvent()
        {
            return smethod_21(this);
        }

        protected RoutedEventArgs RaisePreviewTrayToolTipCloseEvent()
        {
            return smethod_25(this);
        }

        protected RoutedEventArgs RaisePreviewTrayToolTipOpenEvent()
        {
            return smethod_23(this);
        }

        protected RoutedEventArgs RaiseTrayBalloonTipClickedEvent()
        {
            return smethod_17(this);
        }

        protected RoutedEventArgs RaiseTrayBalloonTipClosedEvent()
        {
            return smethod_16(this);
        }

        protected RoutedEventArgs RaiseTrayBalloonTipShownEvent()
        {
            return smethod_15(this);
        }

        protected RoutedEventArgs RaiseTrayContextMenuOpenEvent()
        {
            return smethod_18(this);
        }

        protected RoutedEventArgs RaiseTrayLeftMouseDownEvent()
        {
            return smethod_7(this);
        }

        protected RoutedEventArgs RaiseTrayLeftMouseUpEvent()
        {
            return smethod_10(this);
        }

        protected RoutedEventArgs RaiseTrayMiddleMouseDownEvent()
        {
            return smethod_9(this);
        }

        protected RoutedEventArgs RaiseTrayMiddleMouseUpEvent()
        {
            return smethod_12(this);
        }

        protected RoutedEventArgs RaiseTrayMouseDoubleClickEvent()
        {
            this.DoubleClickCommand.smethod_7(this.DoubleClickCommandParameter, this.DoubleClickCommandTarget ?? this);
            return smethod_13(this);
        }

        protected RoutedEventArgs RaiseTrayMouseMoveEvent()
        {
            return smethod_14(this);
        }

        protected RoutedEventArgs RaiseTrayPopupOpenEvent()
        {
            return smethod_20(this);
        }

        protected RoutedEventArgs RaiseTrayRightMouseDownEvent()
        {
            return smethod_8(this);
        }

        protected RoutedEventArgs RaiseTrayRightMouseUpEvent()
        {
            return smethod_11(this);
        }

        protected RoutedEventArgs RaiseTrayToolTipCloseEvent()
        {
            return smethod_24(this);
        }

        protected RoutedEventArgs RaiseTrayToolTipOpenEvent()
        {
            return smethod_22(this);
        }

        public static void RemoveBalloonClosingHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_2(element, BalloonClosingEvent, handler);
        }

        public static void RemoveBalloonShowingHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_2(element, BalloonShowingEvent, handler);
        }

        public static void RemovePopupOpenedHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_2(element, PopupOpenedEvent, handler);
        }

        public static void RemoveToolTipCloseHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_2(element, ToolTipCloseEvent, handler);
        }

        public static void RemoveToolTipOpenedHandler(DependencyObject element, RoutedEventHandler handler)
        {
            Class0.smethod_2(element, ToolTipOpenedEvent, handler);
        }

        public void ResetBalloonCloseTimer()
        {
            if (!this.IsDisposed)
            {
                TaskbarIcon icon = this;
                lock (icon)
                {
                    this.timer_1.Change(-1, -1);
                }
            }
        }

        protected void SetCustomBalloon(Popup value)
        {
            base.SetValue(dependencyPropertyKey_2, value);
        }

        public static void SetParentTaskbarIcon(DependencyObject d, TaskbarIcon value)
        {
            d.SetValue(ParentTaskbarIconProperty, value);
        }

        protected void SetTrayPopupResolved(Popup value)
        {
            base.SetValue(dependencyPropertyKey_0, value);
        }

        protected void SetTrayToolTipResolved(ToolTip value)
        {
            base.SetValue(dependencyPropertyKey_1, value);
        }

        public void ShowBalloonTip(string title, string message, BalloonIcon symbol)
        {
            TaskbarIcon icon = this;
            lock (icon)
            {
                this.method_9(title, message, symbol.smethod_3(), IntPtr.Zero);
            }
        }

        public void ShowBalloonTip(string title, string message, System.Drawing.Icon customIcon)
        {
            if (customIcon == null)
            {
                throw new ArgumentNullException("customIcon");
            }
            TaskbarIcon icon = this;
            lock (icon)
            {
                this.method_9(title, message, BalloonFlags.User, customIcon.Handle);
            }
        }

        public void ShowCustomBalloon(UIElement balloon, PopupAnimation animation, int? timeout)
        {
            Class1 class2 = new Class1 {
                taskbarIcon_0 = this,
                uielement_0 = balloon,
                popupAnimation_0 = animation,
                nullable_0 = timeout
            };
            if (!Application.Current.Dispatcher.CheckAccess())
            {
                Action method = new Action(class2.method_0);
                Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, method);
            }
            else
            {
                if (class2.uielement_0 == null)
                {
                    throw new ArgumentNullException("balloon");
                }
                if (class2.nullable_0.HasValue)
                {
                    int? nullable = class2.nullable_0;
                    if ((nullable.GetValueOrDefault() < 500) ? nullable.HasValue : false)
                    {
                        string format = "Invalid timeout of {0} milliseconds. Timeout must be at least 500 ms";
                        format = string.Format(format, class2.nullable_0);
                        throw new ArgumentOutOfRangeException("timeout", format);
                    }
                }
                this.method_15();
                TaskbarIcon icon = this;
                lock (icon)
                {
                    this.CloseBalloon();
                }
                Popup popup = new Popup {
                    AllowsTransparency = true
                };
                this.method_23(popup, null, base.DataContext);
                popup.PopupAnimation = class2.popupAnimation_0;
                popup.Child = class2.uielement_0;
                popup.Placement = PlacementMode.AbsolutePoint;
                popup.StaysOpen = true;
                Hardcodet.Wpf.TaskbarNotification.Interop.Point trayLocation = TrayInfo.GetTrayLocation();
                popup.HorizontalOffset = trayLocation.X - 1;
                popup.VerticalOffset = trayLocation.Y - 1;
                icon = this;
                lock (icon)
                {
                    this.SetCustomBalloon(popup);
                }
                SetParentTaskbarIcon(class2.uielement_0, this);
                smethod_29(class2.uielement_0, this);
                popup.IsOpen = true;
                if (class2.nullable_0.HasValue)
                {
                    this.timer_1.Change(class2.nullable_0.Value, -1);
                }
            }
        }

        private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_18(dependencyPropertyChangedEventArgs_0);
        }

        private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_19(dependencyPropertyChangedEventArgs_0);
        }

        internal static RoutedEventArgs smethod_10(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayLeftMouseUpEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_11(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayRightMouseUpEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_12(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayMiddleMouseUpEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_13(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayMouseDoubleClickEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_14(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayMouseMoveEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_15(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayBalloonTipShownEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_16(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayBalloonTipClosedEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_17(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayBalloonTipClickedEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_18(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayContextMenuOpenEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_19(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = PreviewTrayContextMenuOpenEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        private static void smethod_2(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_20(dependencyPropertyChangedEventArgs_0);
        }

        internal static RoutedEventArgs smethod_20(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayPopupOpenEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_21(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = PreviewTrayPopupOpenEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_22(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayToolTipOpenEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_23(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = PreviewTrayToolTipOpenEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_24(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayToolTipCloseEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_25(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = PreviewTrayToolTipCloseEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_26(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = PopupOpenedEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_27(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = ToolTipOpenedEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_28(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = ToolTipCloseEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_29(DependencyObject dependencyObject_0, TaskbarIcon taskbarIcon_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs(BalloonShowingEvent, taskbarIcon_0);
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        private static void smethod_3(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_21(dependencyPropertyChangedEventArgs_0);
        }

        internal static RoutedEventArgs smethod_30(DependencyObject dependencyObject_0, TaskbarIcon taskbarIcon_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs(BalloonClosingEvent, taskbarIcon_0);
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        private static void smethod_4(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_22(dependencyPropertyChangedEventArgs_0);
        }

        private static void smethod_5(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_24(dependencyPropertyChangedEventArgs_0);
        }

        private static void smethod_6(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            ((TaskbarIcon) dependencyObject_0).method_25(dependencyPropertyChangedEventArgs_0);
        }

        internal static RoutedEventArgs smethod_7(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayLeftMouseDownEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_8(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayRightMouseDownEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        internal static RoutedEventArgs smethod_9(DependencyObject dependencyObject_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            RoutedEventArgs args = new RoutedEventArgs {
                RoutedEvent = TrayMiddleMouseDownEvent
            };
            Class0.smethod_0(dependencyObject_0, args);
            return args;
        }

        private bool Boolean_0
        {
            get
            {
                Popup trayPopupResolved = this.TrayPopupResolved;
                ContextMenu contextMenu = base.ContextMenu;
                Popup customBalloon = this.CustomBalloon;
                return ((((trayPopupResolved != null) && trayPopupResolved.IsOpen) || ((contextMenu != null) && contextMenu.IsOpen)) || ((customBalloon != null) && customBalloon.IsOpen));
            }
        }

        public Popup CustomBalloon
        {
            get
            {
                return (Popup) base.GetValue(CustomBalloonProperty);
            }
        }

        public ICommand DoubleClickCommand
        {
            get
            {
                return (ICommand) base.GetValue(DoubleClickCommandProperty);
            }
            set
            {
                base.SetValue(DoubleClickCommandProperty, value);
            }
        }

        public object DoubleClickCommandParameter
        {
            get
            {
                return base.GetValue(DoubleClickCommandParameterProperty);
            }
            set
            {
                base.SetValue(DoubleClickCommandParameterProperty, value);
            }
        }

        public IInputElement DoubleClickCommandTarget
        {
            get
            {
                return (IInputElement) base.GetValue(DoubleClickCommandTargetProperty);
            }
            set
            {
                base.SetValue(DoubleClickCommandTargetProperty, value);
            }
        }

        [Browsable(false)]
        public System.Drawing.Icon Icon
        {
            get
            {
                return this.icon_0;
            }
            set
            {
                this.icon_0 = value;
                this.notifyIconData_0.IconHandle = (value == null) ? IntPtr.Zero : this.icon_0.Handle;
                Class3.smethod_2(ref this.notifyIconData_0, NotifyCommand.Modify, IconDataMembers.Icon);
            }
        }

        [Description("Sets the displayed taskbar icon."), Category("NotifyIcon")]
        public ImageSource IconSource
        {
            get
            {
                return (ImageSource) base.GetValue(IconSourceProperty);
            }
            set
            {
                base.SetValue(IconSourceProperty, value);
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

        public bool IsTaskbarIconCreated
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }

        public ICommand LeftClickCommand
        {
            get
            {
                return (ICommand) base.GetValue(LeftClickCommandProperty);
            }
            set
            {
                base.SetValue(LeftClickCommandProperty, value);
            }
        }

        public object LeftClickCommandParameter
        {
            get
            {
                return base.GetValue(LeftClickCommandParameterProperty);
            }
            set
            {
                base.SetValue(LeftClickCommandParameterProperty, value);
            }
        }

        public IInputElement LeftClickCommandTarget
        {
            get
            {
                return (IInputElement) base.GetValue(LeftClickCommandTargetProperty);
            }
            set
            {
                base.SetValue(LeftClickCommandTargetProperty, value);
            }
        }

        [Category("NotifyIcon"), Description("Defines what mouse events display the context menu.")]
        public PopupActivationMode MenuActivation
        {
            get
            {
                return (PopupActivationMode) base.GetValue(MenuActivationProperty);
            }
            set
            {
                base.SetValue(MenuActivationProperty, value);
            }
        }

        [Description("Defines what mouse events display the TaskbarIconPopup."), Category("NotifyIcon")]
        public PopupActivationMode PopupActivation
        {
            get
            {
                return (PopupActivationMode) base.GetValue(PopupActivationProperty);
            }
            set
            {
                base.SetValue(PopupActivationProperty, value);
            }
        }

        public bool SupportsCustomToolTips
        {
            get
            {
                return (this.windowMessageSink_0.Version == NotifyIconVersion.Vista);
            }
        }

        [Category("NotifyIcon"), Description("Alternative to a fully blown ToolTip, which is only displayed on Vista and above.")]
        public string ToolTipText
        {
            get
            {
                return (string) base.GetValue(ToolTipTextProperty);
            }
            set
            {
                base.SetValue(ToolTipTextProperty, value);
            }
        }

        [Description("Displayed as a Popup if the user clicks on the taskbar icon."), Category("NotifyIcon")]
        public UIElement TrayPopup
        {
            get
            {
                return (UIElement) base.GetValue(TrayPopupProperty);
            }
            set
            {
                base.SetValue(TrayPopupProperty, value);
            }
        }

        [Category("NotifyIcon")]
        public Popup TrayPopupResolved
        {
            get
            {
                return (Popup) base.GetValue(TrayPopupResolvedProperty);
            }
        }

        [Category("NotifyIcon"), Description("Custom UI element that is displayed as a tooltip. Only on Vista and above")]
        public UIElement TrayToolTip
        {
            get
            {
                return (UIElement) base.GetValue(TrayToolTipProperty);
            }
            set
            {
                base.SetValue(TrayToolTipProperty, value);
            }
        }

        [Browsable(true), Bindable(true), Category("NotifyIcon")]
        public ToolTip TrayToolTipResolved
        {
            get
            {
                return (ToolTip) base.GetValue(TrayToolTipResolvedProperty);
            }
        }

        [CompilerGenerated]
        private sealed class Class1
        {
            public int? nullable_0;
            public PopupAnimation popupAnimation_0;
            public TaskbarIcon taskbarIcon_0;
            public UIElement uielement_0;

            internal void method_0()
            {
                this.taskbarIcon_0.ShowCustomBalloon(this.uielement_0, this.popupAnimation_0, this.nullable_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class2
        {
            public Hardcodet.Wpf.TaskbarNotification.Interop.Point point_0;
            public TaskbarIcon taskbarIcon_0;

            internal void method_0()
            {
                this.taskbarIcon_0.LeftClickCommand.smethod_7(this.taskbarIcon_0.LeftClickCommandParameter, this.taskbarIcon_0.LeftClickCommandTarget ?? this.taskbarIcon_0);
                this.taskbarIcon_0.method_6(this.point_0);
            }

            internal void method_1()
            {
                this.taskbarIcon_0.LeftClickCommand.smethod_7(this.taskbarIcon_0.LeftClickCommandParameter, this.taskbarIcon_0.LeftClickCommandTarget ?? this.taskbarIcon_0);
                this.taskbarIcon_0.method_7(this.point_0);
            }
        }
    }
}

