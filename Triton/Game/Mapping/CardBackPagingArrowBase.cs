namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackPagingArrowBase")]
    public class CardBackPagingArrowBase : MonoBehaviour
    {
        public CardBackPagingArrowBase(IntPtr address) : this(address, "CardBackPagingArrowBase")
        {
        }

        public CardBackPagingArrowBase(IntPtr address, string className) : base(address, className)
        {
        }

        public void EnablePaging(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnablePaging", objArray1);
        }
    }
}

