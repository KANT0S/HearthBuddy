namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GeneralStorePacksContentDisplay")]
    public class GeneralStorePacksContentDisplay : MonoBehaviour
    {
        public GeneralStorePacksContentDisplay(IntPtr address) : this(address, "GeneralStorePacksContentDisplay")
        {
        }

        public GeneralStorePacksContentDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void ClearPacks()
        {
            base.method_8("ClearPacks", Array.Empty<object>());
        }

        public int DeterminePackColumn(int packNumber)
        {
            object[] objArray1 = new object[] { packNumber };
            return base.method_11<int>("DeterminePackColumn", objArray1);
        }

        public void FlyLeavingSoonBanner(int numPacksFlyingIn, int numPacksFlyingOut, float flyInTime, float flyOutTime, float flyInDelay, float flyOutDelay, int numVisiblePacks, bool animated)
        {
            object[] objArray1 = new object[] { numPacksFlyingIn, numPacksFlyingOut, flyInTime, flyOutTime, flyInDelay, flyOutDelay, numVisiblePacks, animated };
            base.method_8("FlyLeavingSoonBanner", objArray1);
        }

        public List<AnimatedLowPolyPack> GetCurrentPacks(int id, int count)
        {
            object[] objArray1 = new object[] { id, count };
            Class247<AnimatedLowPolyPack> class2 = base.method_14<Class247<AnimatedLowPolyPack>>("GetCurrentPacks", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void OnLeavingSoonButtonClicked(string leavingSoonText)
        {
            object[] objArray1 = new object[] { leavingSoonText };
            base.method_8("OnLeavingSoonButtonClicked", objArray1);
        }

        public void SetParent(GeneralStorePacksContent parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void SetupLowPolyPack(AnimatedLowPolyPack pack, int i, bool useVisiblePacksOnly)
        {
            object[] objArray1 = new object[] { pack, i, useVisiblePacksOnly };
            base.method_8("SetupLowPolyPack", objArray1);
        }

        public int ShowPacks(int numVisiblePacks, float flyInTime, float flyOutTime, float flyInDelay, float flyOutDelay, bool forceImmediate)
        {
            object[] objArray1 = new object[] { numVisiblePacks, flyInTime, flyOutTime, flyInDelay, flyOutDelay, forceImmediate };
            return base.method_11<int>("ShowPacks", objArray1);
        }

        public void UpdatePackType(StorePackDef packDef)
        {
            object[] objArray1 = new object[] { packDef };
            base.method_8("UpdatePackType", objArray1);
        }

        public MeshRenderer m_background
        {
            get
            {
                return base.method_3<MeshRenderer>("m_background");
            }
        }

        public int m_lastVisiblePacks
        {
            get
            {
                return base.method_2<int>("m_lastVisiblePacks");
            }
        }

        public string m_leavingSoonBannerPrefab
        {
            get
            {
                return base.method_4("m_leavingSoonBannerPrefab");
            }
        }

        public List<GameObject> m_packStacks
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_packStacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GeneralStorePacksContent m_parent
        {
            get
            {
                return base.method_3<GeneralStorePacksContent>("m_parent");
            }
        }

        public List<AnimatedLeavingSoonSign> m_showingLeavingSoonSigns
        {
            get
            {
                Class267<AnimatedLeavingSoonSign> class2 = base.method_3<Class267<AnimatedLeavingSoonSign>>("m_showingLeavingSoonSigns");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<AnimatedLowPolyPack> m_showingPacks
        {
            get
            {
                Class267<AnimatedLowPolyPack> class2 = base.method_3<Class267<AnimatedLowPolyPack>>("m_showingPacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float PACK_FLY_OUT_X_DEG_VARIATION_MAG
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_FLY_OUT_X_DEG_VARIATION_MAG");
            }
        }

        public static float PACK_FLY_OUT_Z_DEG_VARIATION_MAG
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_FLY_OUT_Z_DEG_VARIATION_MAG");
            }
        }

        public static Vector3 PACK_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_SCALE");
            }
        }

        public static int PACK_STACK_SEED
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_STACK_SEED");
            }
        }

        public static float PACK_X_VARIATION_MAG
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_X_VARIATION_MAG");
            }
        }

        public static float PACK_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_Y_OFFSET");
            }
        }

        public static float PACK_Z_VARIATION_MAG
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContentDisplay", "PACK_Z_VARIATION_MAG");
            }
        }
    }
}

