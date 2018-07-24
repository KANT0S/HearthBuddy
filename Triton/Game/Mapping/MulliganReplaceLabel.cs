namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MulliganReplaceLabel")]
    public class MulliganReplaceLabel : MonoBehaviour
    {
        public MulliganReplaceLabel(IntPtr address) : this(address, "MulliganReplaceLabel")
        {
        }

        public MulliganReplaceLabel(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText m_labelText
        {
            get
            {
                return base.method_3<UberText>("m_labelText");
            }
        }
    }
}

