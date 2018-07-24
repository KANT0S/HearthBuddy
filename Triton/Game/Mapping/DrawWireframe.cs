namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DrawWireframe")]
    public class DrawWireframe : MonoBehaviour
    {
        public DrawWireframe(IntPtr address) : this(address, "DrawWireframe")
        {
        }

        public DrawWireframe(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnPostRender()
        {
            base.method_8("OnPostRender", Array.Empty<object>());
        }

        public void OnPreRender()
        {
            base.method_8("OnPreRender", Array.Empty<object>());
        }
    }
}

