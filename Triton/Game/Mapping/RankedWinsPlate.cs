namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RankedWinsPlate")]
    public class RankedWinsPlate : PegUIElement
    {
        public RankedWinsPlate(IntPtr address) : this(address, "RankedWinsPlate")
        {
        }

        public RankedWinsPlate(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }
    }
}

