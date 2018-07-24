namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FunctionLib")]
    public class FunctionLib : MonoBehaviour
    {
        public FunctionLib(IntPtr address) : this(address, "FunctionLib")
        {
        }

        public FunctionLib(IntPtr address, string className) : base(address, className)
        {
        }

        public void onAnimaitonEvent()
        {
            base.method_8("onAnimaitonEvent", Array.Empty<object>());
        }

        public GameObject destination
        {
            get
            {
                return base.method_3<GameObject>("destination");
            }
        }

        public LightningCtrl lightningScript
        {
            get
            {
                return base.method_3<LightningCtrl>("lightningScript");
            }
        }

        public GameObject target
        {
            get
            {
                return base.method_3<GameObject>("target");
            }
        }
    }
}

