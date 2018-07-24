namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventurePurchaseScreen")]
    public class AdventurePurchaseScreen : Store
    {
        public AdventurePurchaseScreen(IntPtr address) : this(address, "AdventurePurchaseScreen")
        {
        }

        public AdventurePurchaseScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BuyWithGold()
        {
            base.method_8("BuyWithGold", Array.Empty<object>());
        }

        public void BuyWithMoney()
        {
            base.method_8("BuyWithMoney", Array.Empty<object>());
        }

        public void FirePurchaseEvent(bool success)
        {
            object[] objArray1 = new object[] { success };
            base.method_8("FirePurchaseEvent", objArray1);
        }

        public void SendToStore()
        {
            base.method_8("SendToStore", Array.Empty<object>());
        }

        public PegUIElement m_BuyDungeonButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_BuyDungeonButton");
            }
        }
    }
}

