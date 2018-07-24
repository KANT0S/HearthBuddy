namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HighlightExclude")]
    public class HighlightExclude : MonoBehaviour
    {
        public HighlightExclude(IntPtr address) : this(address, "HighlightExclude")
        {
        }

        public HighlightExclude(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ExcludeChildren
        {
            get
            {
                return base.method_2<bool>("ExcludeChildren");
            }
        }
    }
}

