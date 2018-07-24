namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Hub")]
    public class Hub : Scene
    {
        public Hub(IntPtr address) : this(address, "Hub")
        {
        }

        public Hub(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoTavernBrawlAnimsCB()
        {
            base.method_8("DoTavernBrawlAnimsCB", Array.Empty<object>());
        }

        public static void DoTavernBrawlIntroVO()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "Hub", "DoTavernBrawlIntroVO");
        }

        public void HideTooltipNotification(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("HideTooltipNotification", objArray1);
        }

        public void OnAdventureBundlePurchase(Network.Bundle bundle, PaymentMethod purchaseMethod, object userData)
        {
            object[] objArray1 = new object[] { bundle, purchaseMethod, userData };
            base.method_8("OnAdventureBundlePurchase", objArray1);
        }

        public void OnBoxButtonPressed(Box.ButtonType buttonType, object userData)
        {
            object[] objArray1 = new object[] { buttonType, userData };
            base.method_8("OnBoxButtonPressed", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnSceneUnloaded(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnSceneUnloaded", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Notification m_PracticeNotification
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_PracticeNotification");
            }
        }

        public static bool s_hasAlreadyShownTBAnimation
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "Hub", "s_hasAlreadyShownTBAnimation");
            }
        }
    }
}

