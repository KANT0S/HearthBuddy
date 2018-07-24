namespace Hardcodet.Wpf.TaskbarNotification.Interop
{
    using ns1;
    using System;
    using System.Drawing;

    public static class TrayInfo
    {
        public static Hardcodet.Wpf.TaskbarNotification.Interop.Point GetTrayLocation()
        {
            Class4 class2 = new Class4();
            class2.method_1();
            Rectangle rectangle = class2.Rectangle_0;
            int right = 0;
            int bottom = 0;
            if (class2.Enum0_0 == Class4.Enum0.Left)
            {
                right = rectangle.Left + 2;
                bottom = rectangle.Bottom;
            }
            else if (class2.Enum0_0 == Class4.Enum0.Bottom)
            {
                right = rectangle.Right;
                bottom = rectangle.Bottom;
            }
            else if (class2.Enum0_0 == Class4.Enum0.Top)
            {
                right = rectangle.Right;
                bottom = rectangle.Top;
            }
            else if (class2.Enum0_0 == Class4.Enum0.Right)
            {
                right = rectangle.Right;
                bottom = rectangle.Bottom;
            }
            return new Hardcodet.Wpf.TaskbarNotification.Interop.Point { X = right, Y = bottom };
        }
    }
}

