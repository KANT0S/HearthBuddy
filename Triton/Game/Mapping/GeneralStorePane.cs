namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStorePane")]
    public class GeneralStorePane : MonoBehaviour
    {
        public GeneralStorePane(IntPtr address) : this(address, "GeneralStorePane")
        {
        }

        public GeneralStorePane(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AnimateEntranceEnd()
        {
            return base.method_11<bool>("AnimateEntranceEnd", Array.Empty<object>());
        }

        public bool AnimateEntranceStart()
        {
            return base.method_11<bool>("AnimateEntranceStart", Array.Empty<object>());
        }

        public bool AnimateExitEnd()
        {
            return base.method_11<bool>("AnimateExitEnd", Array.Empty<object>());
        }

        public bool AnimateExitStart()
        {
            return base.method_11<bool>("AnimateExitStart", Array.Empty<object>());
        }

        public void OnPurchaseFinished()
        {
            base.method_8("OnPurchaseFinished", Array.Empty<object>());
        }

        public void OnRefresh()
        {
            base.method_8("OnRefresh", Array.Empty<object>());
        }

        public void PostPaneSwappedIn()
        {
            base.method_8("PostPaneSwappedIn", Array.Empty<object>());
        }

        public void PostPaneSwappedOut()
        {
            base.method_8("PostPaneSwappedOut", Array.Empty<object>());
        }

        public void PrePaneSwappedIn()
        {
            base.method_8("PrePaneSwappedIn", Array.Empty<object>());
        }

        public void PrePaneSwappedOut()
        {
            base.method_8("PrePaneSwappedOut", Array.Empty<object>());
        }

        public void Refresh()
        {
            base.method_8("Refresh", Array.Empty<object>());
        }

        public void StoreHidden(bool isCurrent)
        {
            object[] objArray1 = new object[] { isCurrent };
            base.method_8("StoreHidden", objArray1);
        }

        public void StoreShown(bool isCurrent)
        {
            object[] objArray1 = new object[] { isCurrent };
            base.method_8("StoreShown", objArray1);
        }

        public GameObject m_paneContainer
        {
            get
            {
                return base.method_3<GameObject>("m_paneContainer");
            }
        }

        public GeneralStoreContent m_parentContent
        {
            get
            {
                return base.method_3<GeneralStoreContent>("m_parentContent");
            }
        }
    }
}

