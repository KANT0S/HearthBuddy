namespace ns20
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Xml;

    internal static class Class184
    {
        private const int int_0 = 0x8eac;
        private const int int_1 = 0x23ab1;
        private const int int_2 = 0x5b5;
        private const int int_3 = 0x16d;
        private static readonly int[] int_4 = new int[] { 0, 0x1f, 0x3b, 90, 120, 0x97, 0xb5, 0xd4, 0xf3, 0x111, 0x130, 0x14e, 0x16d };
        private static readonly int[] int_5 = new int[] { 0, 0x1f, 60, 0x5b, 0x79, 0x98, 0xb6, 0xd5, 0xf4, 0x112, 0x131, 0x14f, 0x16e };
        private const long long_0 = 0xc92a69c000L;
        internal static readonly long long_1 = 0x89f7ff5f7b58000L;

        public static TimeSpan smethod_0(this DateTime dateTime_0)
        {
            return TimeZoneInfo.Local.GetUtcOffset(dateTime_0);
        }

        public static XmlDateTimeSerializationMode smethod_1(DateTimeKind dateTimeKind_0)
        {
            switch (dateTimeKind_0)
            {
                case DateTimeKind.Unspecified:
                    return XmlDateTimeSerializationMode.Unspecified;

                case DateTimeKind.Utc:
                    return XmlDateTimeSerializationMode.Utc;

                case DateTimeKind.Local:
                    return XmlDateTimeSerializationMode.Local;
            }
            throw Class193.smethod_1("kind", dateTimeKind_0, "Unexpected DateTimeKind value.");
        }

        private static long smethod_10(long long_2)
        {
            return ((long_2 - long_1) / 0x2710L);
        }

        internal static DateTime smethod_11(long long_2)
        {
            return new DateTime((long_2 * 0x2710L) + long_1, DateTimeKind.Utc);
        }

        internal static bool smethod_12(string string_0, DateParseHandling dateParseHandling_0, DateTimeZoneHandling dateTimeZoneHandling_0, out object object_0)
        {
            Struct26 struct2 = new Struct26();
            if (!struct2.method_0(string_0))
            {
                object_0 = null;
                return false;
            }
            DateTime time = new DateTime(struct2.int_0, struct2.int_1, struct2.int_2, struct2.int_3, struct2.int_4, struct2.int_5);
            time = time.AddTicks((long) struct2.int_6);
            if (dateParseHandling_0 != DateParseHandling.DateTimeOffset)
            {
                long ticks;
                switch (struct2.enum13_0)
                {
                    case Enum13.Utc:
                        time = new DateTime(time.Ticks, DateTimeKind.Utc);
                        break;

                    case Enum13.LocalWestOfUtc:
                    {
                        TimeSpan span2 = new TimeSpan(struct2.int_7, struct2.int_8, 0);
                        ticks = time.Ticks + span2.Ticks;
                        if (ticks > DateTime.MaxValue.Ticks)
                        {
                            ticks += time.smethod_0().Ticks;
                            if (ticks > DateTime.MaxValue.Ticks)
                            {
                                ticks = DateTime.MaxValue.Ticks;
                            }
                            time = new DateTime(ticks, DateTimeKind.Local);
                            break;
                        }
                        time = new DateTime(ticks, DateTimeKind.Utc).ToLocalTime();
                        break;
                    }
                    case Enum13.LocalEastOfUtc:
                    {
                        TimeSpan span3 = new TimeSpan(struct2.int_7, struct2.int_8, 0);
                        ticks = time.Ticks - span3.Ticks;
                        if (ticks < DateTime.MinValue.Ticks)
                        {
                            ticks += time.smethod_0().Ticks;
                            if (ticks < DateTime.MinValue.Ticks)
                            {
                                ticks = DateTime.MinValue.Ticks;
                            }
                            time = new DateTime(ticks, DateTimeKind.Local);
                            break;
                        }
                        time = new DateTime(ticks, DateTimeKind.Utc).ToLocalTime();
                        break;
                    }
                }
            }
            else
            {
                TimeSpan utcOffset;
                switch (struct2.enum13_0)
                {
                    case Enum13.Utc:
                        utcOffset = new TimeSpan(0L);
                        break;

                    case Enum13.LocalWestOfUtc:
                        utcOffset = new TimeSpan(-struct2.int_7, -struct2.int_8, 0);
                        break;

                    case Enum13.LocalEastOfUtc:
                        utcOffset = new TimeSpan(struct2.int_7, struct2.int_8, 0);
                        break;

                    default:
                        utcOffset = TimeZoneInfo.Local.GetUtcOffset(time);
                        break;
                }
                long num = time.Ticks - utcOffset.Ticks;
                if ((num >= 0L) && (num <= 0x2bca2875f4373fffL))
                {
                    object_0 = new DateTimeOffset(time, utcOffset);
                    return true;
                }
                object_0 = null;
                return false;
            }
            object_0 = smethod_2(time, dateTimeZoneHandling_0);
            return true;
        }

        internal static bool smethod_13(string string_0, DateParseHandling dateParseHandling_0, DateTimeZoneHandling dateTimeZoneHandling_0, out object object_0)
        {
            if (string_0.Length > 0)
            {
                if (string_0[0] == '/')
                {
                    if (string_0.StartsWith("/Date(", StringComparison.Ordinal) && string_0.EndsWith(")/", StringComparison.Ordinal))
                    {
                        return smethod_14(string_0, dateParseHandling_0, dateTimeZoneHandling_0, out object_0);
                    }
                }
                else if (((string_0.Length >= 0x13) && (string_0.Length <= 40)) && (char.IsDigit(string_0[0]) && (string_0[10] == 'T')))
                {
                    return smethod_12(string_0, dateParseHandling_0, dateTimeZoneHandling_0, out object_0);
                }
            }
            object_0 = null;
            return false;
        }

        private static bool smethod_14(string string_0, DateParseHandling dateParseHandling_0, DateTimeZoneHandling dateTimeZoneHandling_0, out object object_0)
        {
            DateTime time2;
            string s = string_0.Substring(6, string_0.Length - 8);
            DateTimeKind utc = DateTimeKind.Utc;
            int index = s.IndexOf('+', 1);
            if (index == -1)
            {
                index = s.IndexOf('-', 1);
            }
            TimeSpan zero = TimeSpan.Zero;
            if (index != -1)
            {
                utc = DateTimeKind.Local;
                zero = smethod_15(s.Substring(index));
                s = s.Substring(0, index);
            }
            DateTime time = smethod_11(long.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
            if (dateParseHandling_0 == DateParseHandling.DateTimeOffset)
            {
                object_0 = new DateTimeOffset(time.Add(zero).Ticks, zero);
                return true;
            }
            switch (utc)
            {
                case DateTimeKind.Unspecified:
                    time2 = DateTime.SpecifyKind(time.ToLocalTime(), DateTimeKind.Unspecified);
                    break;

                case DateTimeKind.Local:
                    time2 = time.ToLocalTime();
                    break;

                default:
                    time2 = time;
                    break;
            }
            object_0 = smethod_2(time2, dateTimeZoneHandling_0);
            return true;
        }

        private static TimeSpan smethod_15(string string_0)
        {
            bool flag = string_0[0] == '-';
            int num = int.Parse(string_0.Substring(1, 2), NumberStyles.Integer, CultureInfo.InvariantCulture);
            int num2 = 0;
            if (string_0.Length >= 5)
            {
                num2 = int.Parse(string_0.Substring(3, 2), NumberStyles.Integer, CultureInfo.InvariantCulture);
            }
            TimeSpan span = TimeSpan.FromHours((double) num) + TimeSpan.FromMinutes((double) num2);
            if (flag)
            {
                span = span.Negate();
            }
            return span;
        }

        internal static void smethod_16(TextWriter textWriter_0, DateTime dateTime_0, DateFormatHandling dateFormatHandling_0, string string_0, CultureInfo cultureInfo_0)
        {
            if (string.IsNullOrEmpty(string_0))
            {
                char[] chArray = new char[0x40];
                int count = smethod_17(chArray, 0, dateTime_0, null, dateTime_0.Kind, dateFormatHandling_0);
                textWriter_0.Write(chArray, 0, count);
            }
            else
            {
                textWriter_0.Write(dateTime_0.ToString(string_0, cultureInfo_0));
            }
        }

        internal static int smethod_17(char[] char_0, int int_6, DateTime dateTime_0, TimeSpan? nullable_0, DateTimeKind dateTimeKind_0, DateFormatHandling dateFormatHandling_0)
        {
            int num = int_6;
            if (dateFormatHandling_0 != DateFormatHandling.MicrosoftDateFormat)
            {
                num = smethod_18(char_0, num, dateTime_0);
                switch (dateTimeKind_0)
                {
                    case DateTimeKind.Utc:
                        char_0[num++] = 'Z';
                        return num;

                    case DateTimeKind.Local:
                    {
                        TimeSpan? nullable2 = nullable_0;
                        return smethod_20(char_0, num, nullable2.HasValue ? nullable2.GetValueOrDefault() : dateTime_0.smethod_0(), dateFormatHandling_0);
                    }
                }
                return num;
            }
            TimeSpan? nullable = nullable_0;
            TimeSpan span = nullable.HasValue ? nullable.GetValueOrDefault() : dateTime_0.smethod_0();
            long num2 = smethod_7(dateTime_0, span);
            @"\/Date(".CopyTo(0, char_0, num, 7);
            num += 7;
            string str = num2.ToString(CultureInfo.InvariantCulture);
            str.CopyTo(0, char_0, num, str.Length);
            num += str.Length;
            switch (dateTimeKind_0)
            {
                case DateTimeKind.Unspecified:
                    if ((dateTime_0 != DateTime.MaxValue) && (dateTime_0 != DateTime.MinValue))
                    {
                        num = smethod_20(char_0, num, span, dateFormatHandling_0);
                    }
                    break;

                case DateTimeKind.Local:
                    num = smethod_20(char_0, num, span, dateFormatHandling_0);
                    break;
            }
            @")\/".CopyTo(0, char_0, num, 3);
            return (num + 3);
        }

        internal static int smethod_18(char[] char_0, int int_6, DateTime dateTime_0)
        {
            int num2;
            int num3;
            int num4;
            int num = 0x13;
            smethod_22(dateTime_0, out num2, out num3, out num4);
            smethod_19(char_0, int_6, num2, 4);
            char_0[int_6 + 4] = '-';
            smethod_19(char_0, int_6 + 5, num3, 2);
            char_0[int_6 + 7] = '-';
            smethod_19(char_0, int_6 + 8, num4, 2);
            char_0[int_6 + 10] = 'T';
            smethod_19(char_0, int_6 + 11, dateTime_0.Hour, 2);
            char_0[int_6 + 13] = ':';
            smethod_19(char_0, int_6 + 14, dateTime_0.Minute, 2);
            char_0[int_6 + 0x10] = ':';
            smethod_19(char_0, int_6 + 0x11, dateTime_0.Second, 2);
            int num5 = (int) (dateTime_0.Ticks % 0x989680L);
            if (num5 != 0)
            {
                int num6 = 7;
                while ((num5 % 10) == 0)
                {
                    num6--;
                    num5 /= 10;
                }
                char_0[int_6 + 0x13] = '.';
                smethod_19(char_0, int_6 + 20, num5, num6);
                num += num6 + 1;
            }
            return (int_6 + num);
        }

        private static void smethod_19(char[] char_0, int int_6, int int_7, int int_8)
        {
            while (int_8-- != 0)
            {
                char_0[int_6 + int_8] = (char) ((int_7 % 10) + 0x30);
                int_7 /= 10;
            }
        }

        internal static DateTime smethod_2(DateTime dateTime_0, DateTimeZoneHandling dateTimeZoneHandling_0)
        {
            switch (dateTimeZoneHandling_0)
            {
                case DateTimeZoneHandling.Local:
                    dateTime_0 = smethod_3(dateTime_0);
                    return dateTime_0;

                case DateTimeZoneHandling.Utc:
                    dateTime_0 = smethod_4(dateTime_0);
                    return dateTime_0;

                case DateTimeZoneHandling.Unspecified:
                    dateTime_0 = new DateTime(dateTime_0.Ticks, DateTimeKind.Unspecified);
                    return dateTime_0;

                case DateTimeZoneHandling.RoundtripKind:
                    return dateTime_0;
            }
            throw new ArgumentException("Invalid date time handling value.");
        }

        internal static int smethod_20(char[] char_0, int int_6, TimeSpan timeSpan_0, DateFormatHandling dateFormatHandling_0)
        {
            char_0[int_6++] = (timeSpan_0.Ticks >= 0L) ? '+' : '-';
            int num = Math.Abs(timeSpan_0.Hours);
            smethod_19(char_0, int_6, num, 2);
            int_6 += 2;
            if (dateFormatHandling_0 == DateFormatHandling.IsoDateFormat)
            {
                char_0[int_6++] = ':';
            }
            int num2 = Math.Abs(timeSpan_0.Minutes);
            smethod_19(char_0, int_6, num2, 2);
            int_6 += 2;
            return int_6;
        }

        internal static void smethod_21(TextWriter textWriter_0, DateTimeOffset dateTimeOffset_0, DateFormatHandling dateFormatHandling_0, string string_0, CultureInfo cultureInfo_0)
        {
            if (string.IsNullOrEmpty(string_0))
            {
                char[] chArray = new char[0x40];
                int count = smethod_17(chArray, 0, (dateFormatHandling_0 == DateFormatHandling.IsoDateFormat) ? dateTimeOffset_0.DateTime : dateTimeOffset_0.UtcDateTime, new TimeSpan?(dateTimeOffset_0.Offset), DateTimeKind.Local, dateFormatHandling_0);
                textWriter_0.Write(chArray, 0, count);
            }
            else
            {
                textWriter_0.Write(dateTimeOffset_0.ToString(string_0, cultureInfo_0));
            }
        }

        private static void smethod_22(DateTime dateTime_0, out int int_6, out int int_7, out int int_8)
        {
            int num2 = (int) (dateTime_0.Ticks / 0xc92a69c000L);
            int num3 = num2 / 0x23ab1;
            num2 -= num3 * 0x23ab1;
            int num4 = num2 / 0x8eac;
            if (num4 == 4)
            {
                num4 = 3;
            }
            num2 -= num4 * 0x8eac;
            int num5 = num2 / 0x5b5;
            num2 -= num5 * 0x5b5;
            int num6 = num2 / 0x16d;
            if (num6 == 4)
            {
                num6 = 3;
            }
            int_6 = ((((num3 * 400) + (num4 * 100)) + (num5 * 4)) + num6) + 1;
            num2 -= num6 * 0x16d;
            int[] numArray = ((num6 == 3) && ((num5 != 0x18) || (num4 == 3))) ? int_5 : int_4;
            int index = num2 >> 6;
            while (num2 >= numArray[index])
            {
                index++;
            }
            int_7 = index;
            int_8 = (num2 - numArray[index - 1]) + 1;
        }

        private static DateTime smethod_3(DateTime dateTime_0)
        {
            switch (dateTime_0.Kind)
            {
                case DateTimeKind.Unspecified:
                    return new DateTime(dateTime_0.Ticks, DateTimeKind.Local);

                case DateTimeKind.Utc:
                    return dateTime_0.ToLocalTime();

                case DateTimeKind.Local:
                    return dateTime_0;
            }
            return dateTime_0;
        }

        private static DateTime smethod_4(DateTime dateTime_0)
        {
            switch (dateTime_0.Kind)
            {
                case DateTimeKind.Unspecified:
                    return new DateTime(dateTime_0.Ticks, DateTimeKind.Utc);

                case DateTimeKind.Utc:
                    return dateTime_0;

                case DateTimeKind.Local:
                    return dateTime_0.ToUniversalTime();
            }
            return dateTime_0;
        }

        private static long smethod_5(DateTime dateTime_0)
        {
            if (dateTime_0.Kind == DateTimeKind.Utc)
            {
                return dateTime_0.Ticks;
            }
            return smethod_6(dateTime_0, dateTime_0.smethod_0());
        }

        private static long smethod_6(DateTime dateTime_0, TimeSpan timeSpan_0)
        {
            if (((dateTime_0.Kind == DateTimeKind.Utc) || (dateTime_0 == DateTime.MaxValue)) || (dateTime_0 == DateTime.MinValue))
            {
                return dateTime_0.Ticks;
            }
            long num = dateTime_0.Ticks - timeSpan_0.Ticks;
            if (num > 0x2bca2875f4373fffL)
            {
                return 0x2bca2875f4373fffL;
            }
            if (num < 0L)
            {
                return 0L;
            }
            return num;
        }

        internal static long smethod_7(DateTime dateTime_0, TimeSpan timeSpan_0)
        {
            return smethod_10(smethod_6(dateTime_0, timeSpan_0));
        }

        internal static long smethod_8(DateTime dateTime_0)
        {
            return smethod_9(dateTime_0, true);
        }

        internal static long smethod_9(DateTime dateTime_0, bool bool_0)
        {
            long num = bool_0 ? smethod_5(dateTime_0) : dateTime_0.Ticks;
            return smethod_10(num);
        }
    }
}

