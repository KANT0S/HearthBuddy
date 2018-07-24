namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GeneralStoreContent")]
    public class GeneralStoreContent : MonoBehaviour
    {
        public GeneralStoreContent(IntPtr address) : this(address, "GeneralStoreContent")
        {
        }

        public GeneralStoreContent(IntPtr address, string className) : base(address, className)
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

        public void FireBundleChangedEvent()
        {
            base.method_8("FireBundleChangedEvent", Array.Empty<object>());
        }

        public NoGTAPPTransactionData GetCurrentGoldBundle()
        {
            return base.method_14<NoGTAPPTransactionData>("GetCurrentGoldBundle", Array.Empty<object>());
        }

        public Network.Bundle GetCurrentMoneyBundle()
        {
            return base.method_14<Network.Bundle>("GetCurrentMoneyBundle", Array.Empty<object>());
        }

        public string GetMoneyDisplayOwnedText()
        {
            return base.method_13("GetMoneyDisplayOwnedText", Array.Empty<object>());
        }

        public bool HasBundleSet()
        {
            return base.method_11<bool>("HasBundleSet", Array.Empty<object>());
        }

        public bool IsContentActive()
        {
            return base.method_11<bool>("IsContentActive", Array.Empty<object>());
        }

        public bool IsPurchaseDisabled()
        {
            return base.method_11<bool>("IsPurchaseDisabled", Array.Empty<object>());
        }

        public void OnBundleChanged(NoGTAPPTransactionData goldBundle, Network.Bundle moneyBundle)
        {
            object[] objArray1 = new object[] { goldBundle, moneyBundle };
            base.method_8("OnBundleChanged", objArray1);
        }

        public void OnCoverStateChanged(bool coverActive)
        {
            object[] objArray1 = new object[] { coverActive };
            base.method_8("OnCoverStateChanged", objArray1);
        }

        public void OnRefresh()
        {
            base.method_8("OnRefresh", Array.Empty<object>());
        }

        public void PostStoreFlipIn(bool animatedFlipIn)
        {
            object[] objArray1 = new object[] { animatedFlipIn };
            base.method_8("PostStoreFlipIn", objArray1);
        }

        public void PostStoreFlipOut()
        {
            base.method_8("PostStoreFlipOut", Array.Empty<object>());
        }

        public void PreStoreFlipIn()
        {
            base.method_8("PreStoreFlipIn", Array.Empty<object>());
        }

        public void PreStoreFlipOut()
        {
            base.method_8("PreStoreFlipOut", Array.Empty<object>());
        }

        public void Refresh()
        {
            base.method_8("Refresh", Array.Empty<object>());
        }

        public void SetContentActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("SetContentActive", objArray1);
        }

        public void SetCurrentGoldBundle(NoGTAPPTransactionData bundle)
        {
            object[] objArray1 = new object[] { bundle };
            base.method_8("SetCurrentGoldBundle", objArray1);
        }

        public void SetCurrentMoneyBundle(Network.Bundle bundle, bool force)
        {
            object[] objArray1 = new object[] { bundle, force };
            base.method_8("SetCurrentMoneyBundle", objArray1);
        }

        public void SetParentStore(GeneralStore parentStore)
        {
            object[] objArray1 = new object[] { parentStore };
            base.method_8("SetParentStore", objArray1);
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

        public NoGTAPPTransactionData m_currentGoldBundle
        {
            get
            {
                return base.method_3<NoGTAPPTransactionData>("m_currentGoldBundle");
            }
        }

        public Network.Bundle m_currentMoneyBundle
        {
            get
            {
                return base.method_3<Network.Bundle>("m_currentMoneyBundle");
            }
        }

        public bool m_isContentActive
        {
            get
            {
                return base.method_2<bool>("m_isContentActive");
            }
        }

        public GeneralStore m_parentStore
        {
            get
            {
                return base.method_3<GeneralStore>("m_parentStore");
            }
        }
    }
}

