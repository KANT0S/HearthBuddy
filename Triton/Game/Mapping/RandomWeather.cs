namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RandomWeather")]
    public class RandomWeather : MonoBehaviour
    {
        public RandomWeather(IntPtr address) : this(address, "RandomWeather")
        {
        }

        public RandomWeather(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartWeather()
        {
            base.method_8("StartWeather", Array.Empty<object>());
        }

        public void StopWeather()
        {
            base.method_8("StopWeather", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_active
        {
            get
            {
                return base.method_2<bool>("m_active");
            }
        }

        public float m_runEndTime
        {
            get
            {
                return base.method_2<float>("m_runEndTime");
            }
        }

        public float m_StartDelayMaxMinutes
        {
            get
            {
                return base.method_2<float>("m_StartDelayMaxMinutes");
            }
        }

        public float m_StartDelayMinMinutes
        {
            get
            {
                return base.method_2<float>("m_StartDelayMinMinutes");
            }
        }

        public float m_startTime
        {
            get
            {
                return base.method_2<float>("m_startTime");
            }
        }

        public float m_WeatherMaxMinutes
        {
            get
            {
                return base.method_2<float>("m_WeatherMaxMinutes");
            }
        }

        public float m_WeatherMinMinutes
        {
            get
            {
                return base.method_2<float>("m_WeatherMinMinutes");
            }
        }
    }
}

