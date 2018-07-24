namespace Triton.Common.Math
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public static class Misc
    {
        public static List<Vector2i> GetPointsOnSegment(Vector2i start, Vector2i end)
        {
            bool flag;
            Class236 class2 = new Class236 {
                list_0 = new List<Vector2i>()
            };
            PlotFunction function = new PlotFunction(class2.method_0);
            int x = start.X;
            int y = start.Y;
            int num3 = end.X;
            int num4 = end.Y;
            if (flag = Math.Abs((int) (num4 - y)) > Math.Abs((int) (num3 - x)))
            {
                smethod_0<int>(ref x, ref y);
                smethod_0<int>(ref num3, ref num4);
            }
            if (x > num3)
            {
                smethod_0<int>(ref x, ref num3);
                smethod_0<int>(ref y, ref num4);
            }
            int num5 = num3 - x;
            int num6 = Math.Abs((int) (num4 - y));
            int num7 = num5 / 2;
            int num8 = (y < num4) ? 1 : -1;
            int num9 = y;
            for (int i = x; i <= num3; i++)
            {
                if (!(flag ? function(num9, i) : function(i, num9)))
                {
                    return class2.list_0;
                }
                num7 -= num6;
                if (num7 < 0)
                {
                    num9 += num8;
                    num7 += num5;
                }
            }
            Vector2i vectori = class2.list_0[0];
            vectori = class2.list_0[class2.list_0.Count - 1];
            int introduced14 = vectori.Distance(start);
            if (introduced14 > vectori.Distance(start))
            {
                class2.list_0.Reverse();
            }
            return class2.list_0;
        }

        public static List<Vector2i> Humanize(Vector2i start, Vector2i end, int dist = 8)
        {
            List<Vector2i> list = new List<Vector2i>();
            Vector2i vectori = end - start;
            vectori.Normalize();
            int num = (int) Math.Floor((double) (((float) start.Distance(end)) / ((float) dist)));
            for (int i = 1; i < num; i++)
            {
                Vector2i vectori2 = start + (vectori * (dist * i));
                list.Add(new Vector2i(vectori2.X, vectori2.Y));
            }
            list.Add(new Vector2i(end.X, end.Y));
            return list;
        }

        private static void smethod_0<T>(ref T gparam_0, ref T gparam_1)
        {
            T local = gparam_0;
            gparam_0 = gparam_1;
            gparam_1 = local;
        }

        [CompilerGenerated]
        private sealed class Class236
        {
            public List<Vector2i> list_0;

            internal bool method_0(int int_0, int int_1)
            {
                this.list_0.Add(new Vector2i(int_0, int_1));
                return true;
            }
        }

        public delegate bool PlotFunction(int x, int y);
    }
}

