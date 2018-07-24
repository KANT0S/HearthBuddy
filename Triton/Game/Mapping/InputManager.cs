namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("InputManager")]
    public class InputManager : MonoBehaviour
    {
        public InputManager(IntPtr address) : this(address, "InputManager")
        {
        }

        public InputManager(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ActivatePlaySpell(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("ActivatePlaySpell", objArray1);
        }

        public bool ActivatePowerUpSpell(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("ActivatePowerUpSpell", objArray1);
        }

        public void ApplyMobileTargettingEffectToActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("ApplyMobileTargettingEffectToActor", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CancelOption()
        {
            return base.method_11<bool>("CancelOption", Array.Empty<object>());
        }

        public bool CancelSubOptionMode()
        {
            return base.method_11<bool>("CancelSubOptionMode", Array.Empty<object>());
        }

        public void CancelSubOptions()
        {
            base.method_8("CancelSubOptions", Array.Empty<object>());
        }

        public bool CancelTargetMode()
        {
            return base.method_11<bool>("CancelTargetMode", Array.Empty<object>());
        }

        public bool CheckDoubleClick()
        {
            return base.method_11<bool>("CheckDoubleClick", Array.Empty<object>());
        }

        public void ClearBattlecrySourceCard()
        {
            base.method_8("ClearBattlecrySourceCard", Array.Empty<object>());
        }

        public void DisableInput()
        {
            base.method_8("DisableInput", Array.Empty<object>());
        }

        public void DisableSkullIfNeeded(Card mousedOverCard)
        {
            object[] objArray1 = new object[] { mousedOverCard };
            base.method_8("DisableSkullIfNeeded", objArray1);
        }

        public void DoEndTurnButton()
        {
            base.method_8("DoEndTurnButton", Array.Empty<object>());
        }

        public void DoEndTurnButton_Option_OnEndTurnRequested()
        {
            base.method_8("DoEndTurnButton_Option_OnEndTurnRequested", Array.Empty<object>());
        }

        public bool DoesHideHandAfterPlayingCard()
        {
            return base.method_11<bool>("DoesHideHandAfterPlayingCard", Array.Empty<object>());
        }

        public bool DoNetworkChoice(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("DoNetworkChoice", objArray1);
        }

        public bool DoNetworkOptions(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("DoNetworkOptions", objArray1);
        }

        public bool DoNetworkOptionTarget(Triton.Game.Mapping.Entity entity, Triton.Game.Mapping.Entity simulatedSourceEntity)
        {
            object[] objArray1 = new object[] { entity, simulatedSourceEntity };
            return base.method_11<bool>("DoNetworkOptionTarget", objArray1);
        }

        public bool DoNetworkResponse(Triton.Game.Mapping.Entity entity, bool checkValidInput)
        {
            object[] objArray1 = new object[] { entity, checkValidInput };
            return base.method_11<bool>("DoNetworkResponse", objArray1);
        }

        public bool DoNetworkSubOptions(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("DoNetworkSubOptions", objArray1);
        }

        public void DoubleClickCard(object obj)
        {
            object[] objArray1 = new object[] { obj };
            base.method_8("DoubleClickCard", objArray1);
        }

        public void DropCanceledHeldCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("DropCanceledHeldCard", objArray1);
        }

        public bool DropHeldCard()
        {
            return base.method_10<bool>("DropHeldCard", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool DropHeldCard(bool wasCancelled)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { wasCancelled };
            return base.method_10<bool>("DropHeldCard", enumArray1, objArray1);
        }

        public void DropSubOptionParentCard()
        {
            base.method_8("DropSubOptionParentCard", Array.Empty<object>());
        }

        public void EnableInput()
        {
            base.method_8("EnableInput", Array.Empty<object>());
        }

        public void EndBattleCryEffect()
        {
            base.method_8("EndBattleCryEffect", Array.Empty<object>());
        }

        public void EndMobileTargetingEffect()
        {
            base.method_8("EndMobileTargetingEffect", Array.Empty<object>());
        }

        public void EnterOptionTargetMode()
        {
            base.method_8("EnterOptionTargetMode", Array.Empty<object>());
        }

        public void FinishBattlecrySourceCard()
        {
            base.method_8("FinishBattlecrySourceCard", Array.Empty<object>());
        }

        public void FinishSubOptions()
        {
            base.method_8("FinishSubOptions", Array.Empty<object>());
        }

        public void ForceManaUpdate(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("ForceManaUpdate", objArray1);
        }

        public static InputManager Get()
        {
            return MonoClass.smethod_15<InputManager>(TritonHs.MainAssemblyPath, "", "InputManager", "Get", Array.Empty<object>());
        }

        public Card GetBattlecrySourceCard()
        {
            return base.method_14<Card>("GetBattlecrySourceCard", Array.Empty<object>());
        }

        public ZoneHand GetFriendlyHand()
        {
            return base.method_14<ZoneHand>("GetFriendlyHand", Array.Empty<object>());
        }

        public Card GetHeldCard()
        {
            return base.method_14<Card>("GetHeldCard", Array.Empty<object>());
        }

        public Card GetMousedOverCard()
        {
            return base.method_14<Card>("GetMousedOverCard", Array.Empty<object>());
        }

        public void GrabCard(GameObject cardObject)
        {
            object[] objArray1 = new object[] { cardObject };
            base.method_8("GrabCard", objArray1);
        }

        public void HandleClickOnCard(GameObject upClickedCard, bool wasMouseDownTarget)
        {
            object[] objArray1 = new object[] { upClickedCard, wasMouseDownTarget };
            base.method_8("HandleClickOnCard", objArray1);
        }

        public void HandleClickOnCardInBattlefield(Triton.Game.Mapping.Entity clickedEntity)
        {
            object[] objArray1 = new object[] { clickedEntity };
            base.method_8("HandleClickOnCardInBattlefield", objArray1);
        }

        public void HandleClickOnChoice(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("HandleClickOnChoice", objArray1);
        }

        public void HandleClickOnSubOption(Triton.Game.Mapping.Entity entity, bool isSimulated)
        {
            object[] objArray1 = new object[] { entity, isSimulated };
            base.method_8("HandleClickOnSubOption", objArray1);
        }

        public bool HandleGameHotkeys()
        {
            return base.method_11<bool>("HandleGameHotkeys", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void HandleLeftMouseDown()
        {
            base.method_8("HandleLeftMouseDown", Array.Empty<object>());
        }

        public void HandleLeftMouseUp()
        {
            base.method_8("HandleLeftMouseUp", Array.Empty<object>());
        }

        public void HandleMemberClick()
        {
            base.method_8("HandleMemberClick", Array.Empty<object>());
        }

        public void HandleMouseMove()
        {
            base.method_8("HandleMouseMove", Array.Empty<object>());
        }

        public void HandleMouseOff()
        {
            base.method_8("HandleMouseOff", Array.Empty<object>());
        }

        public void HandleMouseOffCard()
        {
            base.method_8("HandleMouseOffCard", Array.Empty<object>());
        }

        public void HandleMouseOffLastObject()
        {
            base.method_8("HandleMouseOffLastObject", Array.Empty<object>());
        }

        public void HandleMouseOverCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("HandleMouseOverCard", objArray1);
        }

        public void HandleMouseOverObjectWhileNotHoldingCard(RaycastHit hitInfo)
        {
            object[] objArray1 = new object[] { hitInfo };
            base.method_8("HandleMouseOverObjectWhileNotHoldingCard", objArray1);
        }

        public bool HandleMulliganHotkeys()
        {
            return base.method_11<bool>("HandleMulliganHotkeys", Array.Empty<object>());
        }

        public void HandleRightClick()
        {
            base.method_8("HandleRightClick", Array.Empty<object>());
        }

        public void HandleRightClickOnCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("HandleRightClickOnCard", objArray1);
        }

        public void HandleRightMouseDown()
        {
            base.method_8("HandleRightMouseDown", Array.Empty<object>());
        }

        public void HandleRightMouseUp()
        {
            base.method_8("HandleRightMouseUp", Array.Empty<object>());
        }

        public bool HandleUniversalHotkeys()
        {
            return base.method_11<bool>("HandleUniversalHotkeys", Array.Empty<object>());
        }

        public void HandleUpdateWhileHoldingCard(bool hitBattlefield)
        {
            object[] objArray1 = new object[] { hitBattlefield };
            base.method_8("HandleUpdateWhileHoldingCard", objArray1);
        }

        public void HandleUpdateWhileLeftMouseButtonIsDown()
        {
            base.method_8("HandleUpdateWhileLeftMouseButtonIsDown", Array.Empty<object>());
        }

        public void HandleUpdateWhileNotHoldingCard()
        {
            base.method_8("HandleUpdateWhileNotHoldingCard", Array.Empty<object>());
        }

        public bool HasLocalHandPlays()
        {
            return base.method_11<bool>("HasLocalHandPlays", Array.Empty<object>());
        }

        public void HideBigViewCardBacks()
        {
            base.method_8("HideBigViewCardBacks", Array.Empty<object>());
        }

        public void HidePhoneHand()
        {
            base.method_8("HidePhoneHand", Array.Empty<object>());
        }

        public void HidePhoneHandIfOutOfServerPlays()
        {
            base.method_8("HidePhoneHandIfOutOfServerPlays", Array.Empty<object>());
        }

        public bool IsCancelingBattlecryCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCancelingBattlecryCard", objArray1);
        }

        public bool IsInZone(Card card, TAG_ZONE zoneTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { card, zoneTag };
            return base.method_10<bool>("IsInZone", enumArray1, objArray1);
        }

        public bool IsInZone(Triton.Game.Mapping.Entity entity, TAG_ZONE zoneTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entity, zoneTag };
            return base.method_10<bool>("IsInZone", enumArray1, objArray1);
        }

        public bool MouseIsMoving()
        {
            return base.method_10<bool>("MouseIsMoving", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool MouseIsMoving(float tolerance)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { tolerance };
            return base.method_10<bool>("MouseIsMoving", enumArray1, objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGameOver(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnGameOver", objArray1);
        }

        public void OnHandEnlargeComplete(Zone zone, object userData)
        {
            object[] objArray1 = new object[] { zone, userData };
            base.method_8("OnHandEnlargeComplete", objArray1);
        }

        public void OnManaCrystalMgrManaSpent()
        {
            base.method_8("OnManaCrystalMgrManaSpent", Array.Empty<object>());
        }

        public void OnMulliganEnded()
        {
            base.method_8("OnMulliganEnded", Array.Empty<object>());
        }

        public void OnOptionsReceived(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnOptionsReceived", objArray1);
        }

        public void OnSpectatorNotifyEvent_UpdateHighlights()
        {
            base.method_8("OnSpectatorNotifyEvent_UpdateHighlights", Array.Empty<object>());
        }

        public void OnTurnTimerUpdate(TurnTimerUpdate update, object userData)
        {
            object[] objArray1 = new object[] { update, userData };
            base.method_8("OnTurnTimerUpdate", objArray1);
        }

        public int PlayZoneSlotMousedOver(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<int>("PlayZoneSlotMousedOver", objArray1);
        }

        public void PositionHeldCard()
        {
            base.method_8("PositionHeldCard", Array.Empty<object>());
        }

        public void RemoveMobileTargettingEffectFromActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("RemoveMobileTargettingEffectFromActor", objArray1);
        }

        public void ResetBattlecrySourceCard()
        {
            base.method_8("ResetBattlecrySourceCard", Array.Empty<object>());
        }

        public void ReturnHeldCardToHand()
        {
            base.method_8("ReturnHeldCardToHand", Array.Empty<object>());
        }

        public void ReverseManaUpdate(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("ReverseManaUpdate", objArray1);
        }

        public void SetHandEnlarge(bool set)
        {
            object[] objArray1 = new object[] { set };
            base.method_8("SetHandEnlarge", objArray1);
        }

        public void SetHideHandAfterPlayingCard(bool set)
        {
            object[] objArray1 = new object[] { set };
            base.method_8("SetHideHandAfterPlayingCard", objArray1);
        }

        public void SetMousedOverCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetMousedOverCard", objArray1);
        }

        public void SetShouldShowTooltip()
        {
            base.method_8("SetShouldShowTooltip", Array.Empty<object>());
        }

        public void ShowBullseyeIfNeeded()
        {
            base.method_8("ShowBullseyeIfNeeded", Array.Empty<object>());
        }

        public void ShowPhoneHand()
        {
            base.method_8("ShowPhoneHand", Array.Empty<object>());
        }

        public void ShowSkullIfNeeded()
        {
            base.method_8("ShowSkullIfNeeded", Array.Empty<object>());
        }

        public void ShowTooltipIfNecessary()
        {
            base.method_8("ShowTooltipIfNecessary", Array.Empty<object>());
        }

        public void ShowTooltipZone(GameObject hitObject, TooltipZone tooltip)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { hitObject, tooltip };
            base.method_9("ShowTooltipZone", enumArray1, objArray1);
        }

        public void ShowTooltipZone(TooltipZone tooltip, string headline, string description)
        {
            object[] objArray1 = new object[] { tooltip, headline, description };
            base.method_9("ShowTooltipZone", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartBattleCryEffect(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("StartBattleCryEffect", objArray1);
        }

        public void StartWatchingForInput()
        {
            base.method_8("StartWatchingForInput", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool UseHandEnlarge()
        {
            return base.method_11<bool>("UseHandEnlarge", Array.Empty<object>());
        }

        public static float DOUBLE_CLICK_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "InputManager", "DOUBLE_CLICK_TIME");
            }
        }

        public Vector3 LastMouseDownPosition
        {
            get
            {
                return base.method_11<Vector3>("get_LastMouseDownPosition", Array.Empty<object>());
            }
        }

        public bool LeftMouseButtonDown
        {
            get
            {
                return base.method_11<bool>("get_LeftMouseButtonDown", Array.Empty<object>());
            }
        }

        public Card m_battlecrySourceCard
        {
            get
            {
                return base.method_3<Card>("m_battlecrySourceCard");
            }
        }

        public CardBackManager.LoadCardBackData m_bigViewCardBackFriendly
        {
            get
            {
                return base.method_3<CardBackManager.LoadCardBackData>("m_bigViewCardBackFriendly");
            }
        }

        public CardBackManager.LoadCardBackData m_bigViewCardBackOpposing
        {
            get
            {
                return base.method_3<CardBackManager.LoadCardBackData>("m_bigViewCardBackOpposing");
            }
        }

        public List<Card> m_cancelingBattlecryCards
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_cancelingBattlecryCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_cardWasInsideHandLastFrame
        {
            get
            {
                return base.method_2<bool>("m_cardWasInsideHandLastFrame");
            }
        }

        public bool m_checkForInput
        {
            get
            {
                return base.method_2<bool>("m_checkForInput");
            }
        }

        public object m_clickObject
        {
            get
            {
                return base.method_3<object>("m_clickObject");
            }
        }

        public float m_clickStartTime
        {
            get
            {
                return base.method_2<float>("m_clickStartTime");
            }
        }

        public bool m_doubleClickActive
        {
            get
            {
                return base.method_2<bool>("m_doubleClickActive");
            }
        }

        public bool m_dragging
        {
            get
            {
                return base.method_2<bool>("m_dragging");
            }
        }

        public DragRotatorInfo m_DragRotatorInfo
        {
            get
            {
                return base.method_3<DragRotatorInfo>("m_DragRotatorInfo");
            }
        }

        public Card m_heldCard
        {
            get
            {
                return base.method_3<Card>("m_heldCard");
            }
        }

        public bool m_hideHandAfterPlayingCard
        {
            get
            {
                return base.method_2<bool>("m_hideHandAfterPlayingCard");
            }
        }

        public bool m_ignoreMouseUp
        {
            get
            {
                return base.method_2<bool>("m_ignoreMouseUp");
            }
        }

        public bool m_isInBattleCryEffect
        {
            get
            {
                return base.method_2<bool>("m_isInBattleCryEffect");
            }
        }

        public Vector3 m_lastMouseDownPosition
        {
            get
            {
                return base.method_2<Vector3>("m_lastMouseDownPosition");
            }
        }

        public GameObject m_lastObjectMousedDown
        {
            get
            {
                return base.method_3<GameObject>("m_lastObjectMousedDown");
            }
        }

        public GameObject m_lastObjectRightMousedDown
        {
            get
            {
                return base.method_3<GameObject>("m_lastObjectRightMousedDown");
            }
        }

        public Card m_lastPreviewedCard
        {
            get
            {
                return base.method_3<Card>("m_lastPreviewedCard");
            }
        }

        public ZoneChangeList m_lastZoneChangeList
        {
            get
            {
                return base.method_3<ZoneChangeList>("m_lastZoneChangeList");
            }
        }

        public bool m_leftMouseButtonIsDown
        {
            get
            {
                return base.method_2<bool>("m_leftMouseButtonIsDown");
            }
        }

        public List<Actor> m_mobileTargettingEffectActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_mobileTargettingEffectActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Card m_mousedOverCard
        {
            get
            {
                return base.method_3<Card>("m_mousedOverCard");
            }
        }

        public HistoryCard m_mousedOverHistoryCard
        {
            get
            {
                return base.method_3<HistoryCard>("m_mousedOverHistoryCard");
            }
        }

        public GameObject m_mousedOverObject
        {
            get
            {
                return base.method_3<GameObject>("m_mousedOverObject");
            }
        }

        public float m_mousedOverTimer
        {
            get
            {
                return base.method_2<float>("m_mousedOverTimer");
            }
        }

        public float m_MouseOverDelay
        {
            get
            {
                return base.method_2<float>("m_MouseOverDelay");
            }
        }

        public ZoneHand m_myHandZone
        {
            get
            {
                return base.method_3<ZoneHand>("m_myHandZone");
            }
        }

        public ZonePlay m_myPlayZone
        {
            get
            {
                return base.method_3<ZonePlay>("m_myPlayZone");
            }
        }

        public ZoneWeapon m_myWeaponZone
        {
            get
            {
                return base.method_3<ZoneWeapon>("m_myWeaponZone");
            }
        }

        public uint m_spectatorNotifyCurrentToken
        {
            get
            {
                return base.method_2<uint>("m_spectatorNotifyCurrentToken");
            }
        }

        public bool m_targettingHeroPower
        {
            get
            {
                return base.method_2<bool>("m_targettingHeroPower");
            }
        }

        public bool m_touchDraggingCard
        {
            get
            {
                return base.method_2<bool>("m_touchDraggingCard");
            }
        }

        public bool m_touchedDownOnSmallHand
        {
            get
            {
                return base.method_2<bool>("m_touchedDownOnSmallHand");
            }
        }

        public bool m_useHandEnlarge
        {
            get
            {
                return base.method_2<bool>("m_useHandEnlarge");
            }
        }

        public static float MOBILE_TARGETTING_XY_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "InputManager", "MOBILE_TARGETTING_XY_SCALE");
            }
        }

        public static float MOBILE_TARGETTING_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "InputManager", "MOBILE_TARGETTING_Y_OFFSET");
            }
        }
    }
}

