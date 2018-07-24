namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TimeUtils")]
    public class TimeUtils : MonoClass
    {
        public TimeUtils(IntPtr address) : this(address, "TimeUtils")
        {
        }

        public TimeUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static long BinaryStamp()
        {
            return MonoClass.smethod_14<long>(TritonHs.MainAssemblyPath, "", "TimeUtils", "BinaryStamp", Array.Empty<object>());
        }

        public static DateTime ConvertEpochMicrosecToDateTime(ulong microsec)
        {
            object[] objArray1 = new object[] { microsec };
            return MonoClass.smethod_14<DateTime>(TritonHs.MainAssemblyPath, "", "TimeUtils", "ConvertEpochMicrosecToDateTime", objArray1);
        }

        public static float ForceDevSecFromElapsedTimeString(string timeStr)
        {
            object[] objArray1 = new object[] { timeStr };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "TimeUtils", "ForceDevSecFromElapsedTimeString", objArray1);
        }

        public static string GetDevElapsedTimeString(long ms)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I8 };
            object[] objArray1 = new object[] { ms };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TimeUtils", "GetDevElapsedTimeString", enumArray1, objArray1);
        }

        public static string GetDevElapsedTimeString(float sec)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { sec };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TimeUtils", "GetDevElapsedTimeString", enumArray1, objArray1);
        }

        public static string GetDevElapsedTimeString(TimeSpan span)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { span };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TimeUtils", "GetDevElapsedTimeString", enumArray1, objArray1);
        }

        public static string GetElapsedTimeString(int seconds, ElapsedStringSet stringSet)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.Class };
            object[] objArray1 = new object[] { seconds, stringSet };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TimeUtils", "GetElapsedTimeString", enumArray1, objArray1);
        }

        public static string GetElapsedTimeString(ElapsedTimeType timeType, int time, ElapsedStringSet stringSet)
        {
            object[] objArray1 = new object[] { timeType, time, stringSet };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "TimeUtils", "GetElapsedTimeString", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public static string GetElapsedTimeStringFromEpochMicrosec(ulong microsec, ElapsedStringSet stringSet)
        {
            object[] objArray1 = new object[] { microsec, stringSet };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TimeUtils", "GetElapsedTimeStringFromEpochMicrosec", objArray1);
        }

        public static string ParseTimeUnitsStr(string unitsStr)
        {
            object[] objArray1 = new object[] { unitsStr };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TimeUtils", "ParseTimeUnitsStr", objArray1);
        }

        public static string DEFAULT_TIME_UNITS_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "TimeUtils", "DEFAULT_TIME_UNITS_STR");
            }
        }

        public static DateTime EPOCH_TIME
        {
            get
            {
                return MonoClass.smethod_6<DateTime>(TritonHs.MainAssemblyPath, "", "TimeUtils", "EPOCH_TIME");
            }
        }

        public static int MS_PER_HOUR
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "MS_PER_HOUR");
            }
        }

        public static int MS_PER_MINUTE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "MS_PER_MINUTE");
            }
        }

        public static int MS_PER_SEC
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "MS_PER_SEC");
            }
        }

        public static int SEC_PER_DAY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "SEC_PER_DAY");
            }
        }

        public static int SEC_PER_HOUR
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "SEC_PER_HOUR");
            }
        }

        public static int SEC_PER_MINUTE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "SEC_PER_MINUTE");
            }
        }

        public static int SEC_PER_WEEK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TimeUtils", "SEC_PER_WEEK");
            }
        }

        public static ElapsedStringSet SPLASHSCREEN_DATETIME_STRINGSET
        {
            get
            {
                return MonoClass.smethod_7<ElapsedStringSet>(TritonHs.MainAssemblyPath, "", "TimeUtils", "SPLASHSCREEN_DATETIME_STRINGSET");
            }
        }

        [Attribute38("TimeUtils.ElapsedStringSet")]
        public class ElapsedStringSet : MonoClass
        {
            public ElapsedStringSet(IntPtr address) : this(address, "ElapsedStringSet")
            {
            }

            public ElapsedStringSet(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_days
            {
                get
                {
                    return base.method_4("m_days");
                }
            }

            public string m_hours
            {
                get
                {
                    return base.method_4("m_hours");
                }
            }

            public string m_minutes
            {
                get
                {
                    return base.method_4("m_minutes");
                }
            }

            public string m_monthAgo
            {
                get
                {
                    return base.method_4("m_monthAgo");
                }
            }

            public string m_seconds
            {
                get
                {
                    return base.method_4("m_seconds");
                }
            }

            public string m_weeks
            {
                get
                {
                    return base.method_4("m_weeks");
                }
            }

            public string m_yesterday
            {
                get
                {
                    return base.method_4("m_yesterday");
                }
            }
        }

        public enum ElapsedTimeType
        {
            SECONDS,
            MINUTES,
            HOURS,
            YESTERDAY,
            DAYS,
            WEEKS,
            MONTH_AGO
        }
    }
}

