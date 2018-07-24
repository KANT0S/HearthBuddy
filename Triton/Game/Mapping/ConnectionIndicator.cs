namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ConnectionIndicator")]
    public class ConnectionIndicator : MonoBehaviour
    {
        public ConnectionIndicator(IntPtr address) : this(address, "ConnectionIndicator")
        {
        }

        public ConnectionIndicator(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static ConnectionIndicator Get()
        {
            return MonoClass.smethod_15<ConnectionIndicator>(TritonHs.MainAssemblyPath, "", "ConnectionIndicator", "Get", Array.Empty<object>());
        }

        public bool IsVisible()
        {
            return base.method_11<bool>("IsVisible", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetIndicator(bool val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetIndicator", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float LATENCY_TOLERANCE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ConnectionIndicator", "LATENCY_TOLERANCE");
            }
        }

        public bool m_active
        {
            get
            {
                return base.method_2<bool>("m_active");
            }
        }

        public GameObject m_indicator
        {
            get
            {
                return base.method_3<GameObject>("m_indicator");
            }
        }
    }
}

