namespace ns20
{
    using System;

    internal static class Class192
    {
        public static int smethod_0(ulong ulong_0)
        {
            if (ulong_0 < 0x2540be400L)
            {
                if (ulong_0 < 10L)
                {
                    return 1;
                }
                if (ulong_0 < 100L)
                {
                    return 2;
                }
                if (ulong_0 < 0x3e8L)
                {
                    return 3;
                }
                if (ulong_0 < 0x2710L)
                {
                    return 4;
                }
                if (ulong_0 < 0x186a0L)
                {
                    return 5;
                }
                if (ulong_0 < 0xf4240L)
                {
                    return 6;
                }
                if (ulong_0 < 0x989680L)
                {
                    return 7;
                }
                if (ulong_0 < 0x5f5e100L)
                {
                    return 8;
                }
                if (ulong_0 < 0x3b9aca00L)
                {
                    return 9;
                }
                return 10;
            }
            if (ulong_0 < 0x174876e800L)
            {
                return 11;
            }
            if (ulong_0 < 0xe8d4a51000L)
            {
                return 12;
            }
            if (ulong_0 < 0x9184e72a000L)
            {
                return 13;
            }
            if (ulong_0 < 0x5af3107a4000L)
            {
                return 14;
            }
            if (ulong_0 < 0x38d7ea4c68000L)
            {
                return 15;
            }
            if (ulong_0 < 0x2386f26fc10000L)
            {
                return 0x10;
            }
            if (ulong_0 < 0x16345785d8a0000L)
            {
                return 0x11;
            }
            if (ulong_0 < 0xde0b6b3a7640000L)
            {
                return 0x12;
            }
            if (ulong_0 < 10000000000000000000L)
            {
                return 0x13;
            }
            return 20;
        }

        public static char smethod_1(int int_0)
        {
            if (int_0 <= 9)
            {
                return (char) (int_0 + 0x30);
            }
            return (char) ((int_0 - 10) + 0x61);
        }

        public static int? smethod_2(int? nullable_0, int? nullable_1)
        {
            if (!nullable_0.HasValue)
            {
                return nullable_1;
            }
            if (!nullable_1.HasValue)
            {
                return nullable_0;
            }
            return new int?(Math.Min(nullable_0.Value, nullable_1.Value));
        }

        public static int? smethod_3(int? nullable_0, int? nullable_1)
        {
            if (!nullable_0.HasValue)
            {
                return nullable_1;
            }
            if (!nullable_1.HasValue)
            {
                return nullable_0;
            }
            return new int?(Math.Max(nullable_0.Value, nullable_1.Value));
        }

        public static double? smethod_4(double? nullable_0, double? nullable_1)
        {
            if (!nullable_0.HasValue)
            {
                return nullable_1;
            }
            if (!nullable_1.HasValue)
            {
                return nullable_0;
            }
            return new double?(Math.Max(nullable_0.Value, nullable_1.Value));
        }

        public static bool smethod_5(double double_0, double double_1)
        {
            if (double_0 == double_1)
            {
                return true;
            }
            double num = ((Math.Abs(double_0) + Math.Abs(double_1)) + 10.0) * 2.2204460492503131E-16;
            double num2 = double_0 - double_1;
            return ((-num < num2) && (num > num2));
        }
    }
}

