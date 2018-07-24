namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("iTweenFSMEvents")]
    public class iTweenFSMEvents : MonoBehaviour
    {
        public iTweenFSMEvents(IntPtr address) : this(address, "iTweenFSMEvents")
        {
        }

        public iTweenFSMEvents(IntPtr address, string className) : base(address, className)
        {
        }

        public void iTweenOnComplete(int aniTweenID)
        {
            object[] objArray1 = new object[] { aniTweenID };
            base.method_8("iTweenOnComplete", objArray1);
        }

        public void iTweenOnStart(int aniTweenID)
        {
            object[] objArray1 = new object[] { aniTweenID };
            base.method_8("iTweenOnStart", objArray1);
        }

        public bool donotfinish
        {
            get
            {
                return base.method_2<bool>("donotfinish");
            }
        }

        public bool islooping
        {
            get
            {
                return base.method_2<bool>("islooping");
            }
        }

        public int itweenID
        {
            get
            {
                return base.method_2<int>("itweenID");
            }
        }

        public static int itweenIDCount
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "iTweenFSMEvents", "itweenIDCount");
            }
        }
    }
}

