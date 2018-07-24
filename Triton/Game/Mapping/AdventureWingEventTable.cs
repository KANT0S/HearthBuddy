namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureWingEventTable")]
    public class AdventureWingEventTable : StateEventTable
    {
        public AdventureWingEventTable(IntPtr address) : this(address, "AdventureWingEventTable")
        {
        }

        public AdventureWingEventTable(IntPtr address, string className) : base(address, className)
        {
        }

        public void BigChestCover()
        {
            base.method_8("BigChestCover", Array.Empty<object>());
        }

        public void BigChestOpen()
        {
            base.method_8("BigChestOpen", Array.Empty<object>());
        }

        public void BigChestShow()
        {
            base.method_8("BigChestShow", Array.Empty<object>());
        }

        public void BigChestStayOpen()
        {
            base.method_8("BigChestStayOpen", Array.Empty<object>());
        }

        public bool IsPlateBuy()
        {
            return base.method_11<bool>("IsPlateBuy", Array.Empty<object>());
        }

        public bool IsPlateInitialText()
        {
            return base.method_11<bool>("IsPlateInitialText", Array.Empty<object>());
        }

        public bool IsPlateInOrGoingToAnActiveState()
        {
            return base.method_11<bool>("IsPlateInOrGoingToAnActiveState", Array.Empty<object>());
        }

        public void PlateActivate()
        {
            base.method_8("PlateActivate", Array.Empty<object>());
        }

        public void PlateBuy(bool initial)
        {
            object[] objArray1 = new object[] { initial };
            base.method_8("PlateBuy", objArray1);
        }

        public void PlateCoverPreviewChest()
        {
            base.method_8("PlateCoverPreviewChest", Array.Empty<object>());
        }

        public void PlateDeactivate()
        {
            base.method_8("PlateDeactivate", Array.Empty<object>());
        }

        public void PlateInitialText()
        {
            base.method_8("PlateInitialText", Array.Empty<object>());
        }

        public void PlateKey(bool initial)
        {
            object[] objArray1 = new object[] { initial };
            base.method_8("PlateKey", objArray1);
        }

        public void PlateOpen(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("PlateOpen", objArray1);
        }

        public static string s_EventBigChestCover
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventBigChestCover");
            }
        }

        public static string s_EventBigChestOpen
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventBigChestOpen");
            }
        }

        public static string s_EventBigChestShow
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventBigChestShow");
            }
        }

        public static string s_EventBigChestStayOpen
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventBigChestStayOpen");
            }
        }

        public static string s_EventPlateActivate
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateActivate");
            }
        }

        public static string s_EventPlateBuy
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateBuy");
            }
        }

        public static string s_EventPlateCoverPreviewChest
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateCoverPreviewChest");
            }
        }

        public static string s_EventPlateDeactivate
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateDeactivate");
            }
        }

        public static string s_EventPlateInitialBuy
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateInitialBuy");
            }
        }

        public static string s_EventPlateInitialKey
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateInitialKey");
            }
        }

        public static string s_EventPlateInitialText
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateInitialText");
            }
        }

        public static string s_EventPlateKey
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateKey");
            }
        }

        public static string s_EventPlateOpen
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingEventTable", "s_EventPlateOpen");
            }
        }
    }
}

