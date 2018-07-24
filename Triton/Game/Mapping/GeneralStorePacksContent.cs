namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GeneralStorePacksContent")]
    public class GeneralStorePacksContent : GeneralStoreContent
    {
        public GeneralStorePacksContent(IntPtr address) : this(address, "GeneralStorePacksContent")
        {
        }

        public GeneralStorePacksContent(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateAndUpdateDisplay(int id, bool forceImmediate)
        {
            object[] objArray1 = new object[] { id, forceImmediate };
            base.method_8("AnimateAndUpdateDisplay", objArray1);
        }

        public void AnimateBuyBar()
        {
            base.method_8("AnimateBuyBar", Array.Empty<object>());
        }

        public void AnimateLogo(bool animateLogo)
        {
            object[] objArray1 = new object[] { animateLogo };
            base.method_8("AnimateLogo", objArray1);
        }

        public void AnimatePacksFlying(int numVisiblePacks, bool forceImmediate)
        {
            object[] objArray1 = new object[] { numVisiblePacks, forceImmediate };
            base.method_8("AnimatePacksFlying", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public GeneralStorePackBuyButton CreatePackBuyButton(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<GeneralStorePackBuyButton>("CreatePackBuyButton", objArray1);
        }

        public int GetBoosterId()
        {
            return base.method_11<int>("GetBoosterId", Array.Empty<object>());
        }

        public GeneralStorePacksContentDisplay GetCurrentDisplay()
        {
            return base.method_14<GeneralStorePacksContentDisplay>("GetCurrentDisplay", Array.Empty<object>());
        }

        public GameObject GetCurrentDisplayContainer()
        {
            return base.method_14<GameObject>("GetCurrentDisplayContainer", Array.Empty<object>());
        }

        public MeshRenderer GetCurrentGlowLogo()
        {
            return base.method_14<MeshRenderer>("GetCurrentGlowLogo", Array.Empty<object>());
        }

        public NoGTAPPTransactionData GetCurrentGTAPPTransactionData()
        {
            return base.method_14<NoGTAPPTransactionData>("GetCurrentGTAPPTransactionData", Array.Empty<object>());
        }

        public MeshRenderer GetCurrentLogo()
        {
            return base.method_14<MeshRenderer>("GetCurrentLogo", Array.Empty<object>());
        }

        public string GetMoneyDisplayOwnedText()
        {
            return base.method_13("GetMoneyDisplayOwnedText", Array.Empty<object>());
        }

        public GameObject GetNextDisplayContainer()
        {
            return base.method_14<GameObject>("GetNextDisplayContainer", Array.Empty<object>());
        }

        public GeneralStorePackBuyButton GetPackBuyButton(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<GeneralStorePackBuyButton>("GetPackBuyButton", objArray1);
        }

        public StorePackDef GetStorePackDef(int packDbId)
        {
            object[] objArray1 = new object[] { packDbId };
            return base.method_14<StorePackDef>("GetStorePackDef", objArray1);
        }

        public void HandleGoldPackBuyButtonClick()
        {
            base.method_8("HandleGoldPackBuyButtonClick", Array.Empty<object>());
        }

        public void HandleGoldPackBuyButtonDoubleClick(GeneralStorePackBuyButton button)
        {
            object[] objArray1 = new object[] { button };
            base.method_8("HandleGoldPackBuyButtonDoubleClick", objArray1);
        }

        public void HandleMoneyPackBuyButtonClick(int bundleIndex)
        {
            object[] objArray1 = new object[] { bundleIndex };
            base.method_8("HandleMoneyPackBuyButtonClick", objArray1);
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

        public void OnChinaKoreaInfoPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnChinaKoreaInfoPressed", objArray1);
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

        public void PreStoreFlipOut()
        {
            base.method_8("PreStoreFlipOut", Array.Empty<object>());
        }

        public void ResetAnimations()
        {
            base.method_8("ResetAnimations", Array.Empty<object>());
        }

        public void SelectPackBuyButton(GeneralStorePackBuyButton packBuyBtn)
        {
            object[] objArray1 = new object[] { packBuyBtn };
            base.method_8("SelectPackBuyButton", objArray1);
        }

        public void SetBoosterId(int id, bool forceImmediate)
        {
            object[] objArray1 = new object[] { id, forceImmediate };
            base.method_8("SetBoosterId", objArray1);
        }

        public void ShakeStore(int numPacks, float maxXRotation, float delay)
        {
            object[] objArray1 = new object[] { numPacks, maxXRotation, delay };
            base.method_8("ShakeStore", objArray1);
        }

        public void ShowPreorderBuyButtons(Network.Bundle preOrderBundle)
        {
            object[] objArray1 = new object[] { preOrderBundle };
            base.method_8("ShowPreorderBuyButtons", objArray1);
        }

        public void ShowStandardBuyButtons()
        {
            base.method_8("ShowStandardBuyButtons", Array.Empty<object>());
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

        public void UpdateChinaKoreaInfoButton()
        {
            base.method_8("UpdateChinaKoreaInfoButton", Array.Empty<object>());
        }

        public void UpdatePackBuyButtons()
        {
            base.method_8("UpdatePackBuyButtons", Array.Empty<object>());
        }

        public void UpdatePacksDescription()
        {
            base.method_8("UpdatePacksDescription", Array.Empty<object>());
        }

        public void UpdatePacksTypeMusic()
        {
            base.method_8("UpdatePacksTypeMusic", Array.Empty<object>());
        }

        public void UpdateSelectedBundle(bool forceUpdate)
        {
            object[] objArray1 = new object[] { forceUpdate };
            base.method_8("UpdateSelectedBundle", objArray1);
        }

        public bool m_animatingLogo
        {
            get
            {
                return base.method_2<bool>("m_animatingLogo");
            }
        }

        public bool m_animatingPacks
        {
            get
            {
                return base.method_2<bool>("m_animatingPacks");
            }
        }

        public UberText m_availableDateText
        {
            get
            {
                return base.method_3<UberText>("m_availableDateText");
            }
        }

        public Vector3 m_availableDateTextOrigScale
        {
            get
            {
                return base.method_2<Vector3>("m_availableDateTextOrigScale");
            }
        }

        public float m_backgroundFlipAnimTime
        {
            get
            {
                return base.method_2<float>("m_backgroundFlipAnimTime");
            }
        }

        public float m_backgroundFlipShake
        {
            get
            {
                return base.method_2<float>("m_backgroundFlipShake");
            }
        }

        public float m_backgroundFlipShakeDelay
        {
            get
            {
                return base.method_2<float>("m_backgroundFlipShakeDelay");
            }
        }

        public string m_backgroundFlipSound
        {
            get
            {
                return base.method_4("m_backgroundFlipSound");
            }
        }

        public UIBButton m_ChinaInfoButton
        {
            get
            {
                return base.method_3<UIBButton>("m_ChinaInfoButton");
            }
        }

        public int m_currentDisplay
        {
            get
            {
                return base.method_2<int>("m_currentDisplay");
            }
        }

        public int m_currentGoldPackQuantity
        {
            get
            {
                return base.method_2<int>("m_currentGoldPackQuantity");
            }
        }

        public bool m_hasLogo
        {
            get
            {
                return base.method_2<bool>("m_hasLogo");
            }
        }

        public int m_lastBundleIndex
        {
            get
            {
                return base.method_2<int>("m_lastBundleIndex");
            }
        }

        public LogoAnimation m_logoAnimation
        {
            get
            {
                return base.method_2<LogoAnimation>("m_logoAnimation");
            }
        }

        public GameObject m_logoAnimationEndBone
        {
            get
            {
                return base.method_3<GameObject>("m_logoAnimationEndBone");
            }
        }

        public GameObject m_logoAnimationStartBone
        {
            get
            {
                return base.method_3<GameObject>("m_logoAnimationStartBone");
            }
        }

        public Vector3 m_logoAppearOffset
        {
            get
            {
                return base.method_2<Vector3>("m_logoAppearOffset");
            }
        }

        public float m_logoDisplayPunchTime
        {
            get
            {
                return base.method_2<float>("m_logoDisplayPunchTime");
            }
        }

        public MeshRenderer m_logoGlowMesh
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logoGlowMesh");
            }
        }

        public MeshRenderer m_logoGlowMesh1
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logoGlowMesh1");
            }
        }

        public MeshRenderer m_logoGlowMesh2
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logoGlowMesh2");
            }
        }

        public float m_logoHoldTime
        {
            get
            {
                return base.method_2<float>("m_logoHoldTime");
            }
        }

        public float m_logoIntroTime
        {
            get
            {
                return base.method_2<float>("m_logoIntroTime");
            }
        }

        public MeshRenderer m_logoMesh
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logoMesh");
            }
        }

        public MeshRenderer m_logoMesh1
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logoMesh1");
            }
        }

        public MeshRenderer m_logoMesh2
        {
            get
            {
                return base.method_3<MeshRenderer>("m_logoMesh2");
            }
        }

        public float m_logoOutroTime
        {
            get
            {
                return base.method_2<float>("m_logoOutroTime");
            }
        }

        public int m_maxPackBuyButtons
        {
            get
            {
                return base.method_2<int>("m_maxPackBuyButtons");
            }
        }

        public float m_maxPackFlyInXShake
        {
            get
            {
                return base.method_2<float>("m_maxPackFlyInXShake");
            }
        }

        public float m_maxPackFlyOutXShake
        {
            get
            {
                return base.method_2<float>("m_maxPackFlyOutXShake");
            }
        }

        public MultiSliceElement m_packBuyButtonContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_packBuyButtonContainer");
            }
        }

        public GeneralStorePackBuyButton m_packBuyButtonPrefab
        {
            get
            {
                return base.method_3<GeneralStorePackBuyButton>("m_packBuyButtonPrefab");
            }
        }

        public List<GeneralStorePackBuyButton> m_packBuyButtons
        {
            get
            {
                Class267<GeneralStorePackBuyButton> class2 = base.method_3<Class267<GeneralStorePackBuyButton>>("m_packBuyButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_packBuyContainer
        {
            get
            {
                return base.method_3<GameObject>("m_packBuyContainer");
            }
        }

        public MultiSliceElement m_packBuyFrameContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_packBuyFrameContainer");
            }
        }

        public GeneralStorePackBuyButton m_packBuyPreorderButton
        {
            get
            {
                return base.method_3<GeneralStorePackBuyButton>("m_packBuyPreorderButton");
            }
        }

        public GameObject m_packBuyPreorderContainer
        {
            get
            {
                return base.method_3<GameObject>("m_packBuyPreorderContainer");
            }
        }

        public GameObject m_packContainer
        {
            get
            {
                return base.method_3<GameObject>("m_packContainer");
            }
        }

        public GeneralStorePacksContentDisplay m_packDisplay
        {
            get
            {
                return base.method_3<GeneralStorePacksContentDisplay>("m_packDisplay");
            }
        }

        public GeneralStorePacksContentDisplay m_packDisplay1
        {
            get
            {
                return base.method_3<GeneralStorePacksContentDisplay>("m_packDisplay1");
            }
        }

        public GeneralStorePacksContentDisplay m_packDisplay2
        {
            get
            {
                return base.method_3<GeneralStorePacksContentDisplay>("m_packDisplay2");
            }
        }

        public GameObject m_packEmptyDisplay
        {
            get
            {
                return base.method_3<GameObject>("m_packEmptyDisplay");
            }
        }

        public float m_packFlyInAnimTime
        {
            get
            {
                return base.method_2<float>("m_packFlyInAnimTime");
            }
        }

        public float m_packFlyInDelay
        {
            get
            {
                return base.method_2<float>("m_packFlyInDelay");
            }
        }

        public float m_packFlyOutAnimTime
        {
            get
            {
                return base.method_2<float>("m_packFlyOutAnimTime");
            }
        }

        public float m_packFlyOutDelay
        {
            get
            {
                return base.method_2<float>("m_packFlyOutDelay");
            }
        }

        public float m_packFlyShakeTime
        {
            get
            {
                return base.method_2<float>("m_packFlyShakeTime");
            }
        }

        public float m_PackYDegreeVariationMag
        {
            get
            {
                return base.method_2<float>("m_PackYDegreeVariationMag");
            }
        }

        public GeneralStoreRewardsCardBack m_preorderCardBackReward
        {
            get
            {
                return base.method_3<GeneralStoreRewardsCardBack>("m_preorderCardBackReward");
            }
        }

        public Vector3 m_punchAmount
        {
            get
            {
                return base.method_2<Vector3>("m_punchAmount");
            }
        }

        public StoreQuantityPrompt m_quantityPrompt
        {
            get
            {
                return base.method_3<StoreQuantityPrompt>("m_quantityPrompt");
            }
        }

        public Vector3 m_savedLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_savedLocalPosition");
            }
        }

        public int m_selectedBoosterId
        {
            get
            {
                return base.method_2<int>("m_selectedBoosterId");
            }
        }

        public float m_shakeObjectDelayMultiplier
        {
            get
            {
                return base.method_2<float>("m_shakeObjectDelayMultiplier");
            }
        }

        public List<ToggleableButtonFrame> m_toggleableButtonFrames
        {
            get
            {
                Class267<ToggleableButtonFrame> class2 = base.method_3<Class267<ToggleableButtonFrame>>("m_toggleableButtonFrames");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_visiblePackCount
        {
            get
            {
                return base.method_2<int>("m_visiblePackCount");
            }
        }

        public static int MAX_QUANTITY_BOUGHT_WITH_GOLD
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContent", "MAX_QUANTITY_BOUGHT_WITH_GOLD");
            }
        }

        public static string PREV_PLAYLIST_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GeneralStorePacksContent", "PREV_PLAYLIST_NAME");
            }
        }

        public enum LogoAnimation
        {
            None,
            Slam,
            Fade
        }

        [Attribute38("GeneralStorePacksContent.ToggleableButtonFrame")]
        public class ToggleableButtonFrame : MonoClass
        {
            public ToggleableButtonFrame(IntPtr address) : this(address, "ToggleableButtonFrame")
            {
            }

            public ToggleableButtonFrame(IntPtr address, string className) : base(address, className)
            {
            }

            public GameObject m_IBar
            {
                get
                {
                    return base.method_3<GameObject>("m_IBar");
                }
            }

            public GameObject m_Middle
            {
                get
                {
                    return base.method_3<GameObject>("m_Middle");
                }
            }
        }
    }
}

