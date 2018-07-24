namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackPagingArrowPhone")]
    public class CardBackPagingArrowPhone : CardBackPagingArrowBase
    {
        public CardBackPagingArrowPhone(IntPtr address) : this(address, "CardBackPagingArrowPhone")
        {
        }

        public CardBackPagingArrowPhone(IntPtr address, string className) : base(address, className)
        {
        }

        public void EnablePaging(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnablePaging", objArray1);
        }

        public void OnButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnButtonReleased", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public PegUIElement button
        {
            get
            {
                return base.method_3<PegUIElement>("button");
            }
        }
    }
}

