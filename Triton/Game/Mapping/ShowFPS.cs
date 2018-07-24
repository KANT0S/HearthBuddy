namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ShowFPS")]
    public class ShowFPS : MonoBehaviour
    {
        public ShowFPS(IntPtr address) : this(address, "ShowFPS")
        {
        }

        public ShowFPS(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearFrameCount()
        {
            base.method_8("ClearFrameCount", Array.Empty<object>());
        }

        public static ShowFPS Get()
        {
            return MonoClass.smethod_15<ShowFPS>(TritonHs.MainAssemblyPath, "", "ShowFPS", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnHudOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnHudOptionChanged", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartFrameCount()
        {
            base.method_8("StartFrameCount", Array.Empty<object>());
        }

        public void StopFrameCount()
        {
            base.method_8("StopFrameCount", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateEnabled()
        {
            base.method_8("UpdateEnabled", Array.Empty<object>());
        }

        public int frames
        {
            get
            {
                return base.method_2<int>("frames");
            }
        }

        public string m_fpsText
        {
            get
            {
                return base.method_4("m_fpsText");
            }
        }

        public int m_FrameCount
        {
            get
            {
                return base.method_2<int>("m_FrameCount");
            }
        }

        public bool m_FrameCountActive
        {
            get
            {
                return base.method_2<bool>("m_FrameCountActive");
            }
        }

        public float m_FrameCountLastTime
        {
            get
            {
                return base.method_2<float>("m_FrameCountLastTime");
            }
        }

        public float m_FrameCountTime
        {
            get
            {
                return base.method_2<float>("m_FrameCountTime");
            }
        }

        public double m_LastInterval
        {
            get
            {
                return base.method_2<double>("m_LastInterval");
            }
        }

        public float m_UpdateInterval
        {
            get
            {
                return base.method_2<float>("m_UpdateInterval");
            }
        }

        public bool m_verbose
        {
            get
            {
                return base.method_2<bool>("m_verbose");
            }
        }
    }
}

