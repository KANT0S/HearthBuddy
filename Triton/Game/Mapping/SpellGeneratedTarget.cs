namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SpellGeneratedTarget")]
    public class SpellGeneratedTarget : MonoBehaviour
    {
        public SpellGeneratedTarget(IntPtr address) : this(address, "SpellGeneratedTarget")
        {
        }

        public SpellGeneratedTarget(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

