namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StoreMiniSummary")]
    public class StoreMiniSummary : MonoBehaviour
    {
        public StoreMiniSummary(IntPtr address) : this(address, "StoreMiniSummary")
        {
        }

        public StoreMiniSummary(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string GetItemsText(string productID, int quantity)
        {
            object[] objArray1 = new object[] { productID, quantity };
            return base.method_13("GetItemsText", objArray1);
        }

        public void SetDetails(string productID, int quantity)
        {
            object[] objArray1 = new object[] { productID, quantity };
            base.method_8("SetDetails", objArray1);
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public UberText m_itemsHeadlineText
        {
            get
            {
                return base.method_3<UberText>("m_itemsHeadlineText");
            }
        }

        public UberText m_itemsText
        {
            get
            {
                return base.method_3<UberText>("m_itemsText");
            }
        }
    }
}

