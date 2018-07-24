namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionCardVisual")]
    public class CollectionCardVisual : PegUIElement
    {
        public CollectionCardVisual(IntPtr address) : this(address, "CollectionCardVisual")
        {
        }

        public CollectionCardVisual(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanPickUpCard()
        {
            return base.method_11<bool>("CanPickUpCard", Array.Empty<object>());
        }

        public bool CheckCardSeen()
        {
            return base.method_11<bool>("CheckCardSeen", Array.Empty<object>());
        }

        public void EnterCraftingMode()
        {
            base.method_8("EnterCraftingMode", Array.Empty<object>());
        }

        public Actor GetActor()
        {
            return base.method_14<Actor>("GetActor", Array.Empty<object>());
        }

        public CollectionCardCount GetCardCountObject()
        {
            return base.method_14<CollectionCardCount>("GetCardCountObject", Array.Empty<object>());
        }

        public int GetCMRow()
        {
            return base.method_11<int>("GetCMRow", Array.Empty<object>());
        }

        public CollectionManagerDisplay.ViewMode GetVisualType()
        {
            return base.method_11<CollectionManagerDisplay.ViewMode>("GetVisualType", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsInCollection()
        {
            return base.method_11<bool>("IsInCollection", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsTransactionPendingOnThisCard()
        {
            return base.method_11<bool>("IsTransactionPendingOnThisCard", Array.Empty<object>());
        }

        public bool IsUnlocked()
        {
            return base.method_11<bool>("IsUnlocked", Array.Empty<object>());
        }

        public void OnDoneCrafting()
        {
            base.method_8("OnDoneCrafting", Array.Empty<object>());
        }

        public void OnHold()
        {
            base.method_8("OnHold", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void OnRightClick()
        {
            base.method_8("OnRightClick", Array.Empty<object>());
        }

        public void SetActor(Actor actor, CollectionManagerDisplay.ViewMode type)
        {
            object[] objArray1 = new object[] { actor, type };
            base.method_8("SetActor", objArray1);
        }

        public void SetCMRow(int rowNum)
        {
            object[] objArray1 = new object[] { rowNum };
            base.method_8("SetCMRow", objArray1);
        }

        public void SetDefaultBoxCollider()
        {
            base.method_8("SetDefaultBoxCollider", Array.Empty<object>());
        }

        public void SetHeroSkinBoxCollider()
        {
            base.method_8("SetHeroSkinBoxCollider", Array.Empty<object>());
        }

        public bool ShouldIgnoreAllInput()
        {
            return base.method_11<bool>("ShouldIgnoreAllInput", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public static void ShowActorShadow(Actor actor, bool show)
        {
            object[] objArray1 = new object[] { actor, show };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "CollectionCardVisual", "ShowActorShadow", objArray1);
        }

        public void ShowLock(LockType type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { type };
            base.method_9("ShowLock", enumArray1, objArray1);
        }

        public void ShowLock(LockType lockType, string reason, bool playSound)
        {
            object[] objArray1 = new object[] { lockType, reason, playSound };
            base.method_9("ShowLock", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public void ShowNewItemCallout(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowNewItemCallout", objArray1);
        }

        public void UpdateCardCount()
        {
            base.method_8("UpdateCardCount", Array.Empty<object>());
        }

        public void UpdateCardCountVisibility()
        {
            base.method_8("UpdateCardCountVisibility", Array.Empty<object>());
        }

        public static string ADD_CARD_TO_DECK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionCardVisual", "ADD_CARD_TO_DECK_SOUND");
            }
        }

        public static string CARD_LIMIT_LOCK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionCardVisual", "CARD_LIMIT_LOCK_SOUND");
            }
        }

        public static string CARD_LIMIT_UNLOCK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionCardVisual", "CARD_LIMIT_UNLOCK_SOUND");
            }
        }

        public static string CARD_MOUSE_OVER_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionCardVisual", "CARD_MOUSE_OVER_SOUND");
            }
        }

        public static string CARD_MOVE_INVALID_OR_CLICK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionCardVisual", "CARD_MOVE_INVALID_OR_CLICK_SOUND");
            }
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public Vector3 m_boxColliderCenter
        {
            get
            {
                return base.method_2<Vector3>("m_boxColliderCenter");
            }
        }

        public Vector3 m_boxColliderSize
        {
            get
            {
                return base.method_2<Vector3>("m_boxColliderSize");
            }
        }

        public CollectionCardCount m_cardCount
        {
            get
            {
                return base.method_3<CollectionCardCount>("m_cardCount");
            }
        }

        public CollectionCardLock m_cardLock
        {
            get
            {
                return base.method_3<CollectionCardLock>("m_cardLock");
            }
        }

        public int m_cmRow
        {
            get
            {
                return base.method_2<int>("m_cmRow");
            }
        }

        public Vector3 m_heroSkinBoxColliderCenter
        {
            get
            {
                return base.method_2<Vector3>("m_heroSkinBoxColliderCenter");
            }
        }

        public Vector3 m_heroSkinBoxColliderSize
        {
            get
            {
                return base.method_2<Vector3>("m_heroSkinBoxColliderSize");
            }
        }

        public LockType m_lockType
        {
            get
            {
                return base.method_2<LockType>("m_lockType");
            }
        }

        public GameObject m_newCardCallout
        {
            get
            {
                return base.method_3<GameObject>("m_newCardCallout");
            }
        }

        public Vector3 m_originalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalPosition");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public CollectionManagerDisplay.ViewMode m_visualType
        {
            get
            {
                return base.method_2<CollectionManagerDisplay.ViewMode>("m_visualType");
            }
        }

        public enum LockType
        {
            NONE,
            MAX_COPIES_IN_DECK,
            NO_MORE_INSTANCES
        }
    }
}

