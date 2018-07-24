namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BreakingNews")]
    public class BreakingNews : MonoBehaviour
    {
        public BreakingNews(IntPtr address) : this(address, "BreakingNews")
        {
        }

        public BreakingNews(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Fetch()
        {
            base.method_8("Fetch", Array.Empty<object>());
        }

        public static BreakingNews Get()
        {
            return MonoClass.smethod_15<BreakingNews>(TritonHs.MainAssemblyPath, "", "BreakingNews", "Get", Array.Empty<object>());
        }

        public string GetError()
        {
            return base.method_13("GetError", Array.Empty<object>());
        }

        public Status GetStatus()
        {
            return base.method_11<Status>("GetStatus", Array.Empty<object>());
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public void OnBreakingNewsError(string error)
        {
            object[] objArray1 = new object[] { error };
            base.method_8("OnBreakingNewsError", objArray1);
        }

        public void OnBreakingNewsResponse(string response)
        {
            object[] objArray1 = new object[] { response };
            base.method_8("OnBreakingNewsResponse", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public string m_error
        {
            get
            {
                return base.method_4("m_error");
            }
        }

        public Status m_status
        {
            get
            {
                return base.method_2<Status>("m_status");
            }
        }

        public string m_text
        {
            get
            {
                return base.method_4("m_text");
            }
        }

        public float m_timeFetched
        {
            get
            {
                return base.method_2<float>("m_timeFetched");
            }
        }

        public static bool SHOWS_BREAKING_NEWS
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "BreakingNews", "SHOWS_BREAKING_NEWS");
            }
        }

        public static float TIMEOUT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BreakingNews", "TIMEOUT");
            }
        }

        public enum Status
        {
            Fetching,
            Available,
            TimedOut
        }
    }
}

