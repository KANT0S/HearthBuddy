namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdTrackingManager")]
    public class AdTrackingManager : MonoBehaviour
    {
        public AdTrackingManager(IntPtr address) : this(address, "AdTrackingManager")
        {
        }

        public AdTrackingManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static AdTrackingManager Get()
        {
            return MonoClass.smethod_15<AdTrackingManager>(TritonHs.MainAssemblyPath, "", "AdTrackingManager", "Get", Array.Empty<object>());
        }

        public void GetDeepLink()
        {
            base.method_8("GetDeepLink", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void TrackAccountCreated()
        {
            base.method_8("TrackAccountCreated", Array.Empty<object>());
        }

        public void TrackAdventureProgress(string description)
        {
            object[] objArray1 = new object[] { description };
            base.method_8("TrackAdventureProgress", objArray1);
        }

        public void TrackCreditsLaunch()
        {
            base.method_8("TrackCreditsLaunch", Array.Empty<object>());
        }

        public void TrackFirstLogin()
        {
            base.method_8("TrackFirstLogin", Array.Empty<object>());
        }

        public void TrackLogin()
        {
            base.method_8("TrackLogin", Array.Empty<object>());
        }

        public void TrackSale(string price, string currencyCode, string productId, string transactionId)
        {
            object[] objArray1 = new object[] { price, currencyCode, productId, transactionId };
            base.method_8("TrackSale", objArray1);
        }

        public void TrackTutorialProgress(string description)
        {
            object[] objArray1 = new object[] { description };
            base.method_8("TrackTutorialProgress", objArray1);
        }

        public static AdTrackingManager s_Instance
        {
            get
            {
                return MonoClass.smethod_7<AdTrackingManager>(TritonHs.MainAssemblyPath, "", "AdTrackingManager", "s_Instance");
            }
        }
    }
}

