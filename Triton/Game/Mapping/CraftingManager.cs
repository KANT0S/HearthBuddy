namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CraftingManager")]
    public class CraftingManager : MonoBehaviour
    {
        public CraftingManager(IntPtr address) : this(address, "CraftingManager")
        {
        }

        public CraftingManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AdjustLocalArcaneDustBalance(int amt)
        {
            object[] objArray1 = new object[] { amt };
            base.method_8("AdjustLocalArcaneDustBalance", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CancelCraftMode()
        {
            return base.method_11<bool>("CancelCraftMode", Array.Empty<object>());
        }

        public void CreateButtonPressed()
        {
            base.method_8("CreateButtonPressed", Array.Empty<object>());
        }

        public void DisenchantButtonPressed()
        {
            base.method_8("DisenchantButtonPressed", Array.Empty<object>());
        }

        public void EnterCraftMode(Actor cardActor)
        {
            object[] objArray1 = new object[] { cardActor };
            base.method_8("EnterCraftMode", objArray1);
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public void FinishActorMove()
        {
            base.method_8("FinishActorMove", Array.Empty<object>());
        }

        public void FinishBigCardMove()
        {
            base.method_8("FinishBigCardMove", Array.Empty<object>());
        }

        public void FinishCreateAnims()
        {
            base.method_8("FinishCreateAnims", Array.Empty<object>());
        }

        public void FinishFlipCurrentActorEarly()
        {
            base.method_8("FinishFlipCurrentActorEarly", Array.Empty<object>());
        }

        public void FlipCurrentActor()
        {
            base.method_8("FlipCurrentActor", Array.Empty<object>());
        }

        public void FlipUpsideDownCard(Actor oldActor)
        {
            object[] objArray1 = new object[] { oldActor };
            base.method_8("FlipUpsideDownCard", objArray1);
        }

        public void ForceNonGhostFlagOn()
        {
            base.method_8("ForceNonGhostFlagOn", Array.Empty<object>());
        }

        public static CraftingManager Get()
        {
            return MonoClass.smethod_15<CraftingManager>(TritonHs.MainAssemblyPath, "", "CraftingManager", "Get", Array.Empty<object>());
        }

        public Actor GetAndPositionNewActor(Actor oldActor, int numCopies)
        {
            object[] objArray1 = new object[] { oldActor, numCopies };
            return base.method_14<Actor>("GetAndPositionNewActor", objArray1);
        }

        public Actor GetAndPositionNewUpsideDownActor(Actor oldActor, bool fromPage)
        {
            object[] objArray1 = new object[] { oldActor, fromPage };
            return base.method_14<Actor>("GetAndPositionNewUpsideDownActor", objArray1);
        }

        public NetCache.CardValue GetCardValue(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_14<NetCache.CardValue>("GetCardValue", objArray1);
        }

        public CollectionCardVisual GetCurrentCardVisual()
        {
            return base.method_14<CollectionCardVisual>("GetCurrentCardVisual", Array.Empty<object>());
        }

        public Actor GetGhostActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_14<Actor>("GetGhostActor", objArray1);
        }

        public long GetLocalArcaneDustBalance()
        {
            return base.method_11<long>("GetLocalArcaneDustBalance", Array.Empty<object>());
        }

        public Actor GetNonGhostActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_14<Actor>("GetNonGhostActor", objArray1);
        }

        public int GetNumOwnedCopies(string cardID, TAG_PREMIUM premium)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_10<int>("GetNumOwnedCopies", enumArray1, objArray1);
        }

        public int GetNumOwnedCopies(string cardID, TAG_PREMIUM premium, bool includePending)
        {
            object[] objArray1 = new object[] { cardID, premium, includePending };
            return base.method_10<int>("GetNumOwnedCopies", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public int GetNumTransactions()
        {
            return base.method_11<int>("GetNumTransactions", Array.Empty<object>());
        }

        public PendingTransaction GetPendingTransaction()
        {
            return base.method_14<PendingTransaction>("GetPendingTransaction", Array.Empty<object>());
        }

        public Actor GetShownActor()
        {
            return base.method_14<Actor>("GetShownActor", Array.Empty<object>());
        }

        public Actor GetTemplateActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_14<Actor>("GetTemplateActor", objArray1);
        }

        public bool IsCancelling()
        {
            return base.method_11<bool>("IsCancelling", Array.Empty<object>());
        }

        public bool IsCardShowing()
        {
            return base.method_11<bool>("IsCardShowing", Array.Empty<object>());
        }

        public void LoadGhostActorIfNecessary()
        {
            base.method_8("LoadGhostActorIfNecessary", Array.Empty<object>());
        }

        public Actor LoadNewActorAndConstructIt()
        {
            return base.method_14<Actor>("LoadNewActorAndConstructIt", Array.Empty<object>());
        }

        public void MoveCardToBigSpot(Actor cardActor)
        {
            object[] objArray1 = new object[] { cardActor };
            base.method_8("MoveCardToBigSpot", objArray1);
        }

        public void NotifyOfTransaction(int amt)
        {
            object[] objArray1 = new object[] { amt };
            base.method_8("NotifyOfTransaction", objArray1);
        }

        public void OnCardCraftingEventNotActiveError(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardCraftingEventNotActiveError", objArray1);
        }

        public void OnCardCreated(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardCreated", objArray1);
        }

        public void OnCardCreatedPageTransitioned(object callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("OnCardCreatedPageTransitioned", objArray1);
        }

        public void OnCardDisenchanted(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardDisenchanted", objArray1);
        }

        public void OnCardDisenchantedPageTransitioned(object callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("OnCardDisenchantedPageTransitioned", objArray1);
        }

        public void OnCardDisenchantSoulboundError(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardDisenchantSoulboundError", objArray1);
        }

        public void OnCardGenericError(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardGenericError", objArray1);
        }

        public void OnCardPermissionError(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardPermissionError", objArray1);
        }

        public void OnCardUnknownError(Network.CardSaleResult sale)
        {
            object[] objArray1 = new object[] { sale };
            base.method_8("OnCardUnknownError", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnMassDisenchant(int amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("OnMassDisenchant", objArray1);
        }

        public void OnVignetteFinished()
        {
            base.method_8("OnVignetteFinished", Array.Empty<object>());
        }

        public void SetBigActorLayer(bool inCraftingMode)
        {
            object[] objArray1 = new object[] { inCraftingMode };
            base.method_8("SetBigActorLayer", objArray1);
        }

        public Actor SetUpGhostActor(Actor templateActor, Actor actor)
        {
            object[] objArray1 = new object[] { templateActor, actor };
            return base.method_14<Actor>("SetUpGhostActor", objArray1);
        }

        public Actor SetUpNonGhostActor(Actor templateActor, Actor actor)
        {
            object[] objArray1 = new object[] { templateActor, actor };
            return base.method_14<Actor>("SetUpNonGhostActor", objArray1);
        }

        public void ShowCraftingUI(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ShowCraftingUI", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TellServerAboutWhatUserDid()
        {
            base.method_8("TellServerAboutWhatUserDid", Array.Empty<object>());
        }

        public void UpdateBankText()
        {
            base.method_8("UpdateBankText", Array.Empty<object>());
        }

        public void UpdateCardInfoPane()
        {
            base.method_8("UpdateCardInfoPane", Array.Empty<object>());
        }

        public long m_arcaneDustBalance
        {
            get
            {
                return base.method_2<long>("m_arcaneDustBalance");
            }
        }

        public bool m_cancellingCraftMode
        {
            get
            {
                return base.method_2<bool>("m_cancellingCraftMode");
            }
        }

        public Transform m_cardCounterBone
        {
            get
            {
                return base.method_3<Transform>("m_cardCounterBone");
            }
        }

        public CraftCardCountTab m_cardCountTab
        {
            get
            {
                return base.method_3<CraftCardCountTab>("m_cardCountTab");
            }
        }

        public Vector3 m_cardCountTabHideScale
        {
            get
            {
                return base.method_2<Vector3>("m_cardCountTabHideScale");
            }
        }

        public Vector3 m_cardCountTabShowScale
        {
            get
            {
                return base.method_2<Vector3>("m_cardCountTabShowScale");
            }
        }

        public CardInfoPane m_cardInfoPane
        {
            get
            {
                return base.method_3<CardInfoPane>("m_cardInfoPane");
            }
        }

        public Transform m_cardInfoPaneBone
        {
            get
            {
                return base.method_3<Transform>("m_cardInfoPaneBone");
            }
        }

        public CraftingUI m_craftingUI
        {
            get
            {
                return base.method_3<CraftingUI>("m_craftingUI");
            }
        }

        public Vector3 m_craftSourcePosition
        {
            get
            {
                return base.method_2<Vector3>("m_craftSourcePosition");
            }
        }

        public Vector3 m_craftSourceScale
        {
            get
            {
                return base.method_2<Vector3>("m_craftSourceScale");
            }
        }

        public Actor m_currentBigActor
        {
            get
            {
                return base.method_3<Actor>("m_currentBigActor");
            }
        }

        public float m_delayBeforeBackCardMovesUp
        {
            get
            {
                return base.method_2<float>("m_delayBeforeBackCardMovesUp");
            }
        }

        public PegUIElement m_dustJar
        {
            get
            {
                return base.method_3<PegUIElement>("m_dustJar");
            }
        }

        public iTween.EaseType m_easeTypeForCardFlip
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_easeTypeForCardFlip");
            }
        }

        public iTween.EaseType m_easeTypeForCardMoveUp
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_easeTypeForCardMoveUp");
            }
        }

        public Transform m_faceDownCardBone
        {
            get
            {
                return base.method_3<Transform>("m_faceDownCardBone");
            }
        }

        public Transform m_floatingCardBone
        {
            get
            {
                return base.method_3<Transform>("m_floatingCardBone");
            }
        }

        public Actor m_ghostGoldenMinionActor
        {
            get
            {
                return base.method_3<Actor>("m_ghostGoldenMinionActor");
            }
        }

        public Actor m_ghostGoldenSpellActor
        {
            get
            {
                return base.method_3<Actor>("m_ghostGoldenSpellActor");
            }
        }

        public Actor m_ghostGoldenWeaponActor
        {
            get
            {
                return base.method_3<Actor>("m_ghostGoldenWeaponActor");
            }
        }

        public Actor m_ghostMinionActor
        {
            get
            {
                return base.method_3<Actor>("m_ghostMinionActor");
            }
        }

        public Actor m_ghostSpellActor
        {
            get
            {
                return base.method_3<Actor>("m_ghostSpellActor");
            }
        }

        public Actor m_ghostWeaponActor
        {
            get
            {
                return base.method_3<Actor>("m_ghostWeaponActor");
            }
        }

        public Actor m_hiddenActor
        {
            get
            {
                return base.method_3<Actor>("m_hiddenActor");
            }
        }

        public Transform m_hideCraftingUIBone
        {
            get
            {
                return base.method_3<Transform>("m_hideCraftingUIBone");
            }
        }

        public bool m_isCurrentActorAGhost
        {
            get
            {
                return base.method_2<bool>("m_isCurrentActorAGhost");
            }
        }

        public BoxCollider m_offClickCatcher
        {
            get
            {
                return base.method_3<BoxCollider>("m_offClickCatcher");
            }
        }

        public PendingTransaction m_pendingTransaction
        {
            get
            {
                return base.method_3<PendingTransaction>("m_pendingTransaction");
            }
        }

        public Transform m_showCraftingUIBone
        {
            get
            {
                return base.method_3<Transform>("m_showCraftingUIBone");
            }
        }

        public Actor m_templateGoldenMinionActor
        {
            get
            {
                return base.method_3<Actor>("m_templateGoldenMinionActor");
            }
        }

        public Actor m_templateGoldenSpellActor
        {
            get
            {
                return base.method_3<Actor>("m_templateGoldenSpellActor");
            }
        }

        public Actor m_templateGoldenWeaponActor
        {
            get
            {
                return base.method_3<Actor>("m_templateGoldenWeaponActor");
            }
        }

        public Actor m_templateHeroSkinActor
        {
            get
            {
                return base.method_3<Actor>("m_templateHeroSkinActor");
            }
        }

        public Actor m_templateMinionActor
        {
            get
            {
                return base.method_3<Actor>("m_templateMinionActor");
            }
        }

        public Actor m_templateSpellActor
        {
            get
            {
                return base.method_3<Actor>("m_templateSpellActor");
            }
        }

        public Actor m_templateWeaponActor
        {
            get
            {
                return base.method_3<Actor>("m_templateWeaponActor");
            }
        }

        public float m_timeForBackCardToMoveUp
        {
            get
            {
                return base.method_2<float>("m_timeForBackCardToMoveUp");
            }
        }

        public float m_timeForCardToFlipUp
        {
            get
            {
                return base.method_2<float>("m_timeForCardToFlipUp");
            }
        }

        public int m_transactions
        {
            get
            {
                return base.method_2<int>("m_transactions");
            }
        }

        public Actor m_upsideDownActor
        {
            get
            {
                return base.method_3<Actor>("m_upsideDownActor");
            }
        }
    }
}

