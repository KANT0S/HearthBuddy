namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PackOpening")]
    public class PackOpening : MonoBehaviour
    {
        public PackOpening(IntPtr address) : this(address, "PackOpening")
        {
        }

        public PackOpening(IntPtr address, string className) : base(address, className)
        {
        }

        public void AutomaticallyOpenPack()
        {
            base.method_8("AutomaticallyOpenPack", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanOpenPackAutomatically()
        {
            return base.method_11<bool>("CanOpenPackAutomatically", Array.Empty<object>());
        }

        public void CreateDirector()
        {
            base.method_8("CreateDirector", Array.Empty<object>());
        }

        public void CreateDraggedPack(UnopenedPack creatorPack)
        {
            object[] objArray1 = new object[] { creatorPack };
            base.method_8("CreateDraggedPack", objArray1);
        }

        public void DestroyDraggedPack()
        {
            base.method_8("DestroyDraggedPack", Array.Empty<object>());
        }

        public void DestroyHint()
        {
            base.method_8("DestroyHint", Array.Empty<object>());
        }

        public void DropPack()
        {
            base.method_8("DropPack", Array.Empty<object>());
        }

        public void FixArrowScale(Transform parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("FixArrowScale", objArray1);
        }

        public static PackOpening Get()
        {
            return MonoClass.smethod_15<PackOpening>(TritonHs.MainAssemblyPath, "", "PackOpening", "Get", Array.Empty<object>());
        }

        public GameObject GetPackOpeningCardEffects()
        {
            return base.method_14<GameObject>("GetPackOpeningCardEffects", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideHint()
        {
            base.method_8("HideHint", Array.Empty<object>());
        }

        public void HideUnopenedPackTooltip()
        {
            base.method_8("HideUnopenedPackTooltip", Array.Empty<object>());
        }

        public void HoldPack(UnopenedPack selectedPack)
        {
            object[] objArray1 = new object[] { selectedPack };
            base.method_8("HoldPack", objArray1);
        }

        public void InitializeNet()
        {
            base.method_8("InitializeNet", Array.Empty<object>());
        }

        public void InitializeUI()
        {
            base.method_8("InitializeUI", Array.Empty<object>());
        }

        public void LayoutPacks(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("LayoutPacks", objArray1);
        }

        public void NotifySceneLoadedWhenReady()
        {
            base.method_8("NotifySceneLoadedWhenReady", Array.Empty<object>());
        }

        public void OnBackButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBackButtonPressed", objArray1);
        }

        public void OnBoosterOpened()
        {
            base.method_8("OnBoosterOpened", Array.Empty<object>());
        }

        public void OnBoxTransitionFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxTransitionFinished", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDirectorFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnDirectorFinished", objArray1);
        }

        public void OnDraggedPackRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDraggedPackRelease", objArray1);
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OnNetDataReceived()
        {
            base.method_8("OnNetDataReceived", Array.Empty<object>());
        }

        public void OnPackOpeningFXLoaded(string name, GameObject gameObject, object callbackData)
        {
            object[] objArray1 = new object[] { name, gameObject, callbackData };
            base.method_8("OnPackOpeningFXLoaded", objArray1);
        }

        public void OnStoreButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnStoreButtonReleased", objArray1);
        }

        public void OnUnopenedPackHold(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnUnopenedPackHold", objArray1);
        }

        public void OnUnopenedPackLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnUnopenedPackLoaded", objArray1);
        }

        public void OnUnopenedPackReleaseAll(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnUnopenedPackReleaseAll", objArray1);
        }

        public void OnUnopenedPackRollout(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnUnopenedPackRollout", objArray1);
        }

        public void OnUnopenedPackRollover(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnUnopenedPackRollover", objArray1);
        }

        public void OpenBooster(UnopenedPack pack)
        {
            object[] objArray1 = new object[] { pack };
            base.method_8("OpenBooster", objArray1);
        }

        public void PickUpBooster()
        {
            base.method_8("PickUpBooster", Array.Empty<object>());
        }

        public void PutBackBooster()
        {
            base.method_8("PutBackBooster", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowHintOnSlot()
        {
            base.method_8("ShowHintOnSlot", Array.Empty<object>());
        }

        public void ShowHintOnUnopenedPack()
        {
            base.method_8("ShowHintOnUnopenedPack", Array.Empty<object>());
        }

        public void ShutdownNet()
        {
            base.method_8("ShutdownNet", Array.Empty<object>());
        }

        public void UnregisterUIEvents()
        {
            base.method_8("UnregisterUIEvents", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateDraggedPack()
        {
            base.method_8("UpdateDraggedPack", Array.Empty<object>());
        }

        public void UpdatePack(UnopenedPack pack, NetCache.BoosterStack boosterStack)
        {
            object[] objArray1 = new object[] { pack, boosterStack };
            base.method_8("UpdatePack", objArray1);
        }

        public void UpdatePacks()
        {
            base.method_8("UpdatePacks", Array.Empty<object>());
        }

        public void UpdateUIEvents()
        {
            base.method_8("UpdateUIEvents", Array.Empty<object>());
        }

        public bool m_autoOpenPending
        {
            get
            {
                return base.method_2<bool>("m_autoOpenPending");
            }
        }

        public UIBButton m_BackButton
        {
            get
            {
                return base.method_3<UIBButton>("m_BackButton");
            }
        }

        public PackOpeningBones m_Bones
        {
            get
            {
                return base.method_3<PackOpeningBones>("m_Bones");
            }
        }

        public PackOpeningDirector m_director
        {
            get
            {
                return base.method_3<PackOpeningDirector>("m_director");
            }
        }

        public PackOpeningDirector m_DirectorPrefab
        {
            get
            {
                return base.method_3<PackOpeningDirector>("m_DirectorPrefab");
            }
        }

        public UnopenedPack m_draggedPack
        {
            get
            {
                return base.method_3<UnopenedPack>("m_draggedPack");
            }
        }

        public GameObject m_DragPlane
        {
            get
            {
                return base.method_3<GameObject>("m_DragPlane");
            }
        }

        public bool m_enableBackButton
        {
            get
            {
                return base.method_2<bool>("m_enableBackButton");
            }
        }

        public static bool m_hasAcknowledgedKoreanWarning
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "PackOpening", "m_hasAcknowledgedKoreanWarning");
            }
        }

        public UberText m_HeaderText
        {
            get
            {
                return base.method_3<UberText>("m_HeaderText");
            }
        }

        public Triton.Game.Mapping.Notification m_hintArrow
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_hintArrow");
            }
        }

        public GameObject m_InputBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_InputBlocker");
            }
        }

        public int m_lastOpenedBoosterId
        {
            get
            {
                return base.method_2<int>("m_lastOpenedBoosterId");
            }
        }

        public bool m_loadingUnopenedPack
        {
            get
            {
                return base.method_2<bool>("m_loadingUnopenedPack");
            }
        }

        public bool m_OnePackCentered
        {
            get
            {
                return base.method_2<bool>("m_OnePackCentered");
            }
        }

        public int m_packCount
        {
            get
            {
                return base.method_2<int>("m_packCount");
            }
        }

        public GameObject m_PackOpeningCardFX
        {
            get
            {
                return base.method_3<GameObject>("m_PackOpeningCardFX");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public PackOpeningSocket m_Socket
        {
            get
            {
                return base.method_3<PackOpeningSocket>("m_Socket");
            }
        }

        public PackOpeningSocket m_SocketAccent
        {
            get
            {
                return base.method_3<PackOpeningSocket>("m_SocketAccent");
            }
        }

        public StoreButton m_StoreButton
        {
            get
            {
                return base.method_3<StoreButton>("m_StoreButton");
            }
        }

        public Vector3 m_StoreButtonOffset
        {
            get
            {
                return base.method_2<Vector3>("m_StoreButtonOffset");
            }
        }

        public UIBObjectSpacing m_UnopenedPackContainer
        {
            get
            {
                return base.method_3<UIBObjectSpacing>("m_UnopenedPackContainer");
            }
        }

        public float m_UnopenedPackPadding
        {
            get
            {
                return base.method_2<float>("m_UnopenedPackPadding");
            }
        }

        public UIBScrollable m_UnopenedPackScroller
        {
            get
            {
                return base.method_3<UIBScrollable>("m_UnopenedPackScroller");
            }
        }

        public bool m_waitingForInitialNetData
        {
            get
            {
                return base.method_2<bool>("m_waitingForInitialNetData");
            }
        }

        public static int PACKS_TO_LOAD_BEFORE_CACHE_RESET
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "PackOpening", "PACKS_TO_LOAD_BEFORE_CACHE_RESET");
            }
        }
    }
}

