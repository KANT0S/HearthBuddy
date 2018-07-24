namespace ns0
{
    using Hardcodet.Wpf.TaskbarNotification;
    using Hardcodet.Wpf.TaskbarNotification.Interop;
    using ns1;
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Resources;

    internal static class Class3
    {
        private static readonly bool bool_0 = ((bool) DependencyPropertyDescriptor.FromProperty(DesignerProperties.IsInDesignModeProperty, typeof(FrameworkElement)).Metadata.DefaultValue);
        public static readonly object object_0 = new object();

        public static Window smethod_0()
        {
            return new Window { Width = 0.0, Height = 0.0, ShowInTaskbar = false, WindowStyle = WindowStyle.None, AllowsTransparency = true, Opacity = 0.0 };
        }

        public static bool smethod_1(ref NotifyIconData notifyIconData_0, NotifyCommand notifyCommand_0)
        {
            return smethod_2(ref notifyIconData_0, notifyCommand_0, notifyIconData_0.ValidMembers);
        }

        public static bool smethod_2(ref NotifyIconData notifyIconData_0, NotifyCommand notifyCommand_0, IconDataMembers iconDataMembers_0)
        {
            if (Boolean_0)
            {
                return true;
            }
            notifyIconData_0.ValidMembers = iconDataMembers_0;
            object obj2 = object_0;
            lock (obj2)
            {
                return Class5.Shell_NotifyIcon(notifyCommand_0, ref notifyIconData_0);
            }
        }

        public static BalloonFlags smethod_3(this BalloonIcon balloonIcon_0)
        {
            switch (balloonIcon_0)
            {
                case BalloonIcon.None:
                    return BalloonFlags.None;

                case BalloonIcon.Info:
                    return BalloonFlags.Info;

                case BalloonIcon.Warning:
                    return BalloonFlags.Warning;

                case BalloonIcon.Error:
                    return BalloonFlags.Error;
            }
            throw new ArgumentOutOfRangeException("icon");
        }

        public static Icon smethod_4(this ImageSource imageSource_0)
        {
            if (imageSource_0 == null)
            {
                return null;
            }
            StreamResourceInfo resourceStream = Application.GetResourceStream(new Uri(imageSource_0.ToString()));
            if (resourceStream == null)
            {
                throw new ArgumentException(string.Format("The supplied image source '{0}' could not be resolved.", imageSource_0));
            }
            return new Icon(resourceStream.Stream);
        }

        public static bool smethod_5<T>(this T gparam_0, params T[] gparam_1)
        {
            if (gparam_1 != null)
            {
                foreach (T local in gparam_1)
                {
                    if (gparam_0.Equals(local))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool smethod_6(this MouseEvent mouseEvent_0, PopupActivationMode popupActivationMode_0)
        {
            switch (popupActivationMode_0)
            {
                case PopupActivationMode.LeftClick:
                    return (mouseEvent_0 == MouseEvent.IconLeftMouseUp);

                case PopupActivationMode.RightClick:
                    return (mouseEvent_0 == MouseEvent.IconRightMouseUp);

                case PopupActivationMode.DoubleClick:
                {
                    MouseEvent[] eventArray1 = new MouseEvent[] { MouseEvent.IconDoubleClick };
                    return mouseEvent_0.smethod_5<MouseEvent>(eventArray1);
                }
                case PopupActivationMode.LeftOrRightClick:
                {
                    MouseEvent[] eventArray2 = new MouseEvent[] { MouseEvent.IconLeftMouseUp, MouseEvent.IconRightMouseUp };
                    return mouseEvent_0.smethod_5<MouseEvent>(eventArray2);
                }
                case PopupActivationMode.LeftOrDoubleClick:
                {
                    MouseEvent[] eventArray3 = new MouseEvent[] { MouseEvent.IconLeftMouseUp, MouseEvent.IconDoubleClick };
                    return mouseEvent_0.smethod_5<MouseEvent>(eventArray3);
                }
                case PopupActivationMode.MiddleClick:
                    return (mouseEvent_0 == MouseEvent.IconMiddleMouseUp);

                case PopupActivationMode.All:
                    return (mouseEvent_0 > MouseEvent.MouseMove);
            }
            throw new ArgumentOutOfRangeException("activationMode");
        }

        public static void smethod_7(this ICommand icommand_0, object object_1, IInputElement iinputElement_0)
        {
            if (icommand_0 != null)
            {
                RoutedCommand command = icommand_0 as RoutedCommand;
                if (command != null)
                {
                    if (command.CanExecute(object_1, iinputElement_0))
                    {
                        command.Execute(object_1, iinputElement_0);
                    }
                }
                else if (icommand_0.CanExecute(object_1))
                {
                    icommand_0.Execute(object_1);
                }
            }
        }

        public static bool smethod_8(this FrameworkElement frameworkElement_0)
        {
            if (frameworkElement_0 == null)
            {
                throw new ArgumentNullException("element");
            }
            return (frameworkElement_0.GetBindingExpression(FrameworkElement.DataContextProperty) > null);
        }

        public static bool Boolean_0
        {
            get
            {
                return bool_0;
            }
        }
    }
}

