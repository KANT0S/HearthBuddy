namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StoreDisclaimer")]
    public class StoreDisclaimer : MonoBehaviour
    {
        public StoreDisclaimer(IntPtr address) : this(address, "StoreDisclaimer")
        {
        }

        public StoreDisclaimer(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void SetDetailsText(string detailsText)
        {
            object[] objArray1 = new object[] { detailsText };
            base.method_8("SetDetailsText", objArray1);
        }

        public void UpdateTextSize()
        {
            base.method_8("UpdateTextSize", Array.Empty<object>());
        }

        public UberText m_detailsText
        {
            get
            {
                return base.method_3<UberText>("m_detailsText");
            }
        }

        public UberText m_headlineText
        {
            get
            {
                return base.method_3<UberText>("m_headlineText");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public UberText m_warningText
        {
            get
            {
                return base.method_3<UberText>("m_warningText");
            }
        }
    }
}

