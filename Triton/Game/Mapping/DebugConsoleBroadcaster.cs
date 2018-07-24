namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DebugConsoleBroadcaster")]
    public class DebugConsoleBroadcaster : MonoClass
    {
        public DebugConsoleBroadcaster(IntPtr address) : this(address, "DebugConsoleBroadcaster")
        {
        }

        public DebugConsoleBroadcaster(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnSendTo(IAsyncResult ar)
        {
            object[] objArray1 = new object[] { ar };
            base.method_8("OnSendTo", objArray1);
        }

        public void Start(int destinationPort, string broadCastResponse)
        {
            object[] objArray1 = new object[] { destinationPort, broadCastResponse };
            base.method_8("Start", objArray1);
        }

        public void Stop()
        {
            base.method_8("Stop", Array.Empty<object>());
        }

        public static TimeSpan Interval
        {
            get
            {
                return MonoClass.smethod_6<TimeSpan>(TritonHs.MainAssemblyPath, "", "DebugConsoleBroadcaster", "Interval");
            }
        }

        public List<byte> m_RequestBytes
        {
            get
            {
                Class246<byte> class2 = base.method_3<Class246<byte>>("m_RequestBytes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_started
        {
            get
            {
                return base.method_2<bool>("m_started");
            }
        }
    }
}

