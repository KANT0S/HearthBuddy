namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Glow")]
    public class Glow : MonoBehaviour
    {
        public Glow(IntPtr address) : this(address, "Glow")
        {
        }

        public Glow(IntPtr address, string className) : base(address, className)
        {
        }

        public void UpdateAlpha(float alpha)
        {
            object[] objArray1 = new object[] { alpha };
            base.method_8("UpdateAlpha", objArray1);
        }
    }
}

