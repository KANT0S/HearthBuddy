namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Secret")]
    public class Secret : MonoBehaviour
    {
        public Secret(IntPtr address) : this(address, "Secret")
        {
        }

        public Secret(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public UberText secretLabelBottom
        {
            get
            {
                return base.method_3<UberText>("secretLabelBottom");
            }
        }

        public UberText secretLabelMiddle
        {
            get
            {
                return base.method_3<UberText>("secretLabelMiddle");
            }
        }

        public UberText secretLabelTop
        {
            get
            {
                return base.method_3<UberText>("secretLabelTop");
            }
        }
    }
}

