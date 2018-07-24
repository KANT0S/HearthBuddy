namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GUISkinContainer")]
    public class GUISkinContainer : MonoBehaviour
    {
        public GUISkinContainer(IntPtr address) : this(address, "GUISkinContainer")
        {
        }

        public GUISkinContainer(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

