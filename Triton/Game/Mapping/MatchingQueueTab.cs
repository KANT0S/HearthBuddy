namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MatchingQueueTab")]
    public class MatchingQueueTab : MonoBehaviour
    {
        public MatchingQueueTab(IntPtr address) : this(address, "MatchingQueueTab")
        {
        }

        public MatchingQueueTab(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetElapsedTimeString(int minSeconds, int maxSeconds)
        {
            object[] objArray1 = new object[] { minSeconds, maxSeconds };
            return base.method_13("GetElapsedTimeString", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void InitTimeStringSet()
        {
            base.method_8("InitTimeStringSet", Array.Empty<object>());
        }

        public void ResetTimer()
        {
            base.method_8("ResetTimer", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateDisplay(int minSeconds, int maxSeconds)
        {
            object[] objArray1 = new object[] { minSeconds, maxSeconds };
            base.method_8("UpdateDisplay", objArray1);
        }

        public UberText m_queueTime
        {
            get
            {
                return base.method_3<UberText>("m_queueTime");
            }
        }

        public float m_timeInQueue
        {
            get
            {
                return base.method_2<float>("m_timeInQueue");
            }
        }

        public TimeUtils.ElapsedStringSet m_timeStringSet
        {
            get
            {
                return base.method_3<TimeUtils.ElapsedStringSet>("m_timeStringSet");
            }
        }

        public UberText m_waitTime
        {
            get
            {
                return base.method_3<UberText>("m_waitTime");
            }
        }

        public static int SUPPRESS_TIME
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MatchingQueueTab", "SUPPRESS_TIME");
            }
        }

        public static string TIME_RANGE_STRING
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "MatchingQueueTab", "TIME_RANGE_STRING");
            }
        }

        public static string TIME_STRING
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "MatchingQueueTab", "TIME_STRING");
            }
        }
    }
}

