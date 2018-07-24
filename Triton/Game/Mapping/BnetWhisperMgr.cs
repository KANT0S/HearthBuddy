namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetWhisperMgr")]
    public class BnetWhisperMgr : MonoClass
    {
        public BnetWhisperMgr(IntPtr address) : this(address, "BnetWhisperMgr")
        {
        }

        public BnetWhisperMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanProcessPendingWhispers()
        {
            return base.method_11<bool>("CanProcessPendingWhispers", Array.Empty<object>());
        }

        public static BnetWhisperMgr Get()
        {
            return MonoClass.smethod_15<BnetWhisperMgr>(TritonHs.MainAssemblyPath, "", "BnetWhisperMgr", "Get", Array.Empty<object>());
        }

        public bool HavePendingWhispers()
        {
            return base.method_11<bool>("HavePendingWhispers", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void ProcessPendingWhispers()
        {
            base.method_8("ProcessPendingWhispers", Array.Empty<object>());
        }

        public void ProcessWhisper(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("ProcessWhisper", objArray1);
        }

        public bool SendWhisper(BnetPlayer player, string message)
        {
            object[] objArray1 = new object[] { player, message };
            return base.method_11<bool>("SendWhisper", objArray1);
        }

        public void Shutdown()
        {
            base.method_8("Shutdown", Array.Empty<object>());
        }

        public int m_firstPendingWhisperIndex
        {
            get
            {
                return base.method_2<int>("m_firstPendingWhisperIndex");
            }
        }

        public static int MAX_WHISPERS_PER_PLAYER
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "BnetWhisperMgr", "MAX_WHISPERS_PER_PLAYER");
            }
        }
    }
}

