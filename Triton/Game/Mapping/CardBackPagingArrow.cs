namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackPagingArrow")]
    public class CardBackPagingArrow : CardBackPagingArrowBase
    {
        public CardBackPagingArrow(IntPtr address) : this(address, "CardBackPagingArrow")
        {
        }

        public CardBackPagingArrow(IntPtr address, string className) : base(address, className)
        {
        }

        public void EnablePaging(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnablePaging", objArray1);
        }

        public ArrowModeButton button
        {
            get
            {
                return base.method_3<ArrowModeButton>("button");
            }
        }
    }
}

