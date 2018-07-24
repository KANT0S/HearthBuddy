namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ZoneHand")]
    public class ZoneHand : Zone
    {
        public ZoneHand(IntPtr address) : this(address, "ZoneHand")
        {
        }

        public ZoneHand(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("AddCard", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BlowUpOldStandins()
        {
            base.method_8("BlowUpOldStandins", Array.Empty<object>());
        }

        public bool CanAnimateCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("CanAnimateCard", objArray1);
        }

        public bool CanPlaySpellPowerHint(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("CanPlaySpellPowerHint", objArray1);
        }

        public void CardColliderLoadedCallback(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("CardColliderLoadedCallback", objArray1);
        }

        public void DuplicateColliderAndStuffItIn(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("DuplicateColliderAndStuffItIn", objArray1);
        }

        public void ForceStandInUpdate()
        {
            base.method_8("ForceStandInUpdate", Array.Empty<object>());
        }

        public Vector3 GetCardPosition(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<Vector3>("GetCardPosition", enumArray1, objArray1);
        }

        public Vector3 GetCardPosition(Card card, int overrideCardCount)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { card, overrideCardCount };
            return base.method_10<Vector3>("GetCardPosition", enumArray1, objArray1);
        }

        public Vector3 GetCardRotation(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<Vector3>("GetCardRotation", enumArray1, objArray1);
        }

        public Vector3 GetCardRotation(Card card, int overrideCardCount)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { card, overrideCardCount };
            return base.method_10<Vector3>("GetCardRotation", enumArray1, objArray1);
        }

        public Vector3 GetCardScale(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<Vector3>("GetCardScale", objArray1);
        }

        public float GetCardSpacing()
        {
            return base.method_11<float>("GetCardSpacing", Array.Empty<object>());
        }

        public float GetCardWidth(int nCards)
        {
            object[] objArray1 = new object[] { nCards };
            return base.method_11<float>("GetCardWidth", objArray1);
        }

        public float GetDefaultCardSpacing()
        {
            return base.method_11<float>("GetDefaultCardSpacing", Array.Empty<object>());
        }

        public int GetLastMousedOverCard()
        {
            return base.method_11<int>("GetLastMousedOverCard", Array.Empty<object>());
        }

        public Vector3 GetMouseOverCardPosition(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<Vector3>("GetMouseOverCardPosition", objArray1);
        }

        public CardStandIn GetStandIn(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<CardStandIn>("GetStandIn", objArray1);
        }

        public bool HandEnlarged()
        {
            return base.method_11<bool>("HandEnlarged", Array.Empty<object>());
        }

        public void HandleInput()
        {
            base.method_8("HandleInput", Array.Empty<object>());
        }

        public void HideCards()
        {
            base.method_8("HideCards", Array.Empty<object>());
        }

        public void HideManaGems()
        {
            base.method_8("HideManaGems", Array.Empty<object>());
        }

        public bool IsCardNotInEnemyHandAnymore(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCardNotInEnemyHandAnymore", objArray1);
        }

        public bool IsDoNotUpdateLayout()
        {
            return base.method_11<bool>("IsDoNotUpdateLayout", Array.Empty<object>());
        }

        public bool IsHandScrunched()
        {
            return base.method_11<bool>("IsHandScrunched", Array.Empty<object>());
        }

        public void MakeStandInInteractive(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("MakeStandInInteractive", objArray1);
        }

        public float MaxHandWidth()
        {
            return base.method_11<float>("MaxHandWidth", Array.Empty<object>());
        }

        public void OnSpellPowerEntityEnteredPlay()
        {
            base.method_8("OnSpellPowerEntityEnteredPlay", Array.Empty<object>());
        }

        public void OnSpellPowerEntityMousedOut()
        {
            base.method_8("OnSpellPowerEntityMousedOut", Array.Empty<object>());
        }

        public void OnSpellPowerEntityMousedOver()
        {
            base.method_8("OnSpellPowerEntityMousedOver", Array.Empty<object>());
        }

        public void SetDoNotUpdateLayout(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetDoNotUpdateLayout", objArray1);
        }

        public void SetFriendlyHeroTargetingMode(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetFriendlyHeroTargetingMode", objArray1);
        }

        public void SetHandEnlarged(bool enlarged)
        {
            object[] objArray1 = new object[] { enlarged };
            base.method_8("SetHandEnlarged", objArray1);
        }

        public void ShowCards()
        {
            base.method_8("ShowCards", Array.Empty<object>());
        }

        public void ShowManaGems()
        {
            base.method_8("ShowManaGems", Array.Empty<object>());
        }

        public bool TouchReceived()
        {
            return base.method_11<bool>("TouchReceived", Array.Empty<object>());
        }

        public void UpdateCenterAndWidth()
        {
            base.method_8("UpdateCenterAndWidth", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_9("UpdateLayout", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateLayout(int slotMousedOver)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { slotMousedOver };
            base.method_9("UpdateLayout", enumArray1, objArray1);
        }

        public void UpdateLayout(int slotMousedOver, bool forced)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { slotMousedOver, forced };
            base.method_9("UpdateLayout", enumArray1, objArray1);
        }

        public void UpdateLayout(int slotMousedOver, bool forced, int overrideCardCount)
        {
            object[] objArray1 = new object[] { slotMousedOver, forced, overrideCardCount };
            base.method_9("UpdateLayout", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public void UpdateLayoutImpl(int slotMousedOver, int overrideCardCount)
        {
            object[] objArray1 = new object[] { slotMousedOver, overrideCardCount };
            base.method_8("UpdateLayoutImpl", objArray1);
        }

        public static float ANGLE_OF_CARDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "ANGLE_OF_CARDS");
            }
        }

        public static List<float> CARD_PIXEL_WIDTHS_PHONE
        {
            get
            {
                Class246<float> class2 = MonoClass.smethod_7<Class246<float>>(TritonHs.MainAssemblyPath, "", "ZoneHand", "CARD_PIXEL_WIDTHS_PHONE");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<float> CARD_PIXEL_WIDTHS_TABLET
        {
            get
            {
                Class246<float> class2 = MonoClass.smethod_7<Class246<float>>(TritonHs.MainAssemblyPath, "", "ZoneHand", "CARD_PIXEL_WIDTHS_TABLET");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float CARD_WIDTH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "CARD_WIDTH");
            }
        }

        public Vector3 centerOfHand
        {
            get
            {
                return base.method_2<Vector3>("centerOfHand");
            }
        }

        public CardStandIn CurrentStandIn
        {
            get
            {
                return base.method_14<CardStandIn>("get_CurrentStandIn", Array.Empty<object>());
            }
        }

        public static float DEFAULT_ANIMATE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "DEFAULT_ANIMATE_TIME");
            }
        }

        public static float DRIFT_AMOUNT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "DRIFT_AMOUNT");
            }
        }

        public bool enemyHand
        {
            get
            {
                return base.method_2<bool>("enemyHand");
            }
        }

        public static float HAND_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "HAND_SCALE");
            }
        }

        public static float HAND_SCALE_OPPONENT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "HAND_SCALE_OPPONENT");
            }
        }

        public static float HAND_SCALE_OPPONENT_Y
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "HAND_SCALE_OPPONENT_Y");
            }
        }

        public static float HAND_SCALE_Y
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "HAND_SCALE_Y");
            }
        }

        public int lastMousedOver
        {
            get
            {
                return base.method_2<int>("lastMousedOver");
            }
        }

        public bool m_doNotUpdateLayout
        {
            get
            {
                return base.method_2<bool>("m_doNotUpdateLayout");
            }
        }

        public float m_enlargedHandCardMaxX
        {
            get
            {
                return base.method_2<float>("m_enlargedHandCardMaxX");
            }
        }

        public float m_enlargedHandCardMinX
        {
            get
            {
                return base.method_2<float>("m_enlargedHandCardMinX");
            }
        }

        public Vector3 m_enlargedHandCardScale
        {
            get
            {
                return base.method_2<Vector3>("m_enlargedHandCardScale");
            }
        }

        public float m_enlargedHandDefaultCardSpacing
        {
            get
            {
                return base.method_2<float>("m_enlargedHandDefaultCardSpacing");
            }
        }

        public Vector3 m_enlargedHandPosition
        {
            get
            {
                return base.method_2<Vector3>("m_enlargedHandPosition");
            }
        }

        public Vector3 m_enlargedHandScale
        {
            get
            {
                return base.method_2<Vector3>("m_enlargedHandScale");
            }
        }

        public bool m_flipHandCards
        {
            get
            {
                return base.method_2<bool>("m_flipHandCards");
            }
        }

        public bool m_handEnlarged
        {
            get
            {
                return base.method_2<bool>("m_handEnlarged");
            }
        }

        public float m_handHidingDistance
        {
            get
            {
                return base.method_2<float>("m_handHidingDistance");
            }
        }

        public bool m_handMoving
        {
            get
            {
                return base.method_2<bool>("m_handMoving");
            }
        }

        public GameObject m_heroHitbox
        {
            get
            {
                return base.method_3<GameObject>("m_heroHitbox");
            }
        }

        public float m_heroWidthInHand
        {
            get
            {
                return base.method_2<float>("m_heroWidthInHand");
            }
        }

        public CardStandIn m_hiddenStandIn
        {
            get
            {
                return base.method_3<CardStandIn>("m_hiddenStandIn");
            }
        }

        public GameObject m_iPhoneCardPosition
        {
            get
            {
                return base.method_3<GameObject>("m_iPhoneCardPosition");
            }
        }

        public GameObject m_iPhonePreviewBone
        {
            get
            {
                return base.method_3<GameObject>("m_iPhonePreviewBone");
            }
        }

        public GameObject m_leftArrow
        {
            get
            {
                return base.method_3<GameObject>("m_leftArrow");
            }
        }

        public ManaCrystalMgr m_manaGemMgr
        {
            get
            {
                return base.method_3<ManaCrystalMgr>("m_manaGemMgr");
            }
        }

        public GameObject m_manaGemPosition
        {
            get
            {
                return base.method_3<GameObject>("m_manaGemPosition");
            }
        }

        public float m_maxWidth
        {
            get
            {
                return base.method_2<float>("m_maxWidth");
            }
        }

        public GameObject m_playCardButton
        {
            get
            {
                return base.method_3<GameObject>("m_playCardButton");
            }
        }

        public GameObject m_rightArrow
        {
            get
            {
                return base.method_3<GameObject>("m_rightArrow");
            }
        }

        public Vector3 m_startingPosition
        {
            get
            {
                return base.method_2<Vector3>("m_startingPosition");
            }
        }

        public Vector3 m_startingScale
        {
            get
            {
                return base.method_2<Vector3>("m_startingScale");
            }
        }

        public bool m_targetingMode
        {
            get
            {
                return base.method_2<bool>("m_targetingMode");
            }
        }

        public int m_touchedSlot
        {
            get
            {
                return base.method_2<int>("m_touchedSlot");
            }
        }

        public static int MAX_CARDS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ZoneHand", "MAX_CARDS");
            }
        }

        public static float MOUSE_OVER_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "MOUSE_OVER_SCALE");
            }
        }

        public static float RESISTANCE_BASE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "RESISTANCE_BASE");
            }
        }

        public List<CardStandIn> standIns
        {
            get
            {
                Class267<CardStandIn> class2 = base.method_3<Class267<CardStandIn>>("standIns");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float Z_ROTATION_ON_LEFT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "Z_ROTATION_ON_LEFT");
            }
        }

        public static float Z_ROTATION_ON_RIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneHand", "Z_ROTATION_ON_RIGHT");
            }
        }
    }
}

