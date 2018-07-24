namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RemoteActionHandler")]
    public class RemoteActionHandler : MonoBehaviour
    {
        public RemoteActionHandler(IntPtr address) : this(address, "RemoteActionHandler")
        {
        }

        public RemoteActionHandler(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanAnimateHeldCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("CanAnimateHeldCard", objArray1);
        }

        public bool CanSendUI()
        {
            return base.method_11<bool>("CanSendUI", Array.Empty<object>());
        }

        public void DriftLeftAndRight(bool isFriendlySide)
        {
            object[] objArray1 = new object[] { isFriendlySide };
            base.method_8("DriftLeftAndRight", objArray1);
        }

        public static RemoteActionHandler Get()
        {
            return MonoClass.smethod_15<RemoteActionHandler>(TritonHs.MainAssemblyPath, "", "RemoteActionHandler", "Get", Array.Empty<object>());
        }

        public Card GetFriendlyHeldCard()
        {
            return base.method_14<Card>("GetFriendlyHeldCard", Array.Empty<object>());
        }

        public Card GetFriendlyHoverCard()
        {
            return base.method_14<Card>("GetFriendlyHoverCard", Array.Empty<object>());
        }

        public int GetOpponentHandHoverSlot()
        {
            return base.method_11<int>("GetOpponentHandHoverSlot", Array.Empty<object>());
        }

        public Card GetOpponentHeldCard()
        {
            return base.method_14<Card>("GetOpponentHeldCard", Array.Empty<object>());
        }

        public void HandleAction(Network.UserUI newData)
        {
            object[] objArray1 = new object[] { newData };
            base.method_8("HandleAction", objArray1);
        }

        public bool IsCardInHand(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCardInHand", objArray1);
        }

        public bool IsSendingTargetingArrow()
        {
            return base.method_11<bool>("IsSendingTargetingArrow", Array.Empty<object>());
        }

        public void MaybeCreateArrow()
        {
            base.method_8("MaybeCreateArrow", Array.Empty<object>());
        }

        public void MaybeDestroyArrow()
        {
            base.method_8("MaybeDestroyArrow", Array.Empty<object>());
        }

        public void NotifyOpponentOfCardDropped()
        {
            base.method_8("NotifyOpponentOfCardDropped", Array.Empty<object>());
        }

        public void NotifyOpponentOfCardPickedUp(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("NotifyOpponentOfCardPickedUp", objArray1);
        }

        public void NotifyOpponentOfMouseOut()
        {
            base.method_8("NotifyOpponentOfMouseOut", Array.Empty<object>());
        }

        public void NotifyOpponentOfMouseOverEntity(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("NotifyOpponentOfMouseOverEntity", objArray1);
        }

        public void NotifyOpponentOfTargetEnd()
        {
            base.method_8("NotifyOpponentOfTargetEnd", Array.Empty<object>());
        }

        public void NotifyOpponentOfTargetModeBegin(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("NotifyOpponentOfTargetModeBegin", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnTurnChanged(int oldTurn, int newTurn, object userData)
        {
            object[] objArray1 = new object[] { oldTurn, newTurn, userData };
            base.method_8("OnTurnChanged", objArray1);
        }

        public void SetArrowTarget()
        {
            base.method_8("SetArrowTarget", Array.Empty<object>());
        }

        public void StandUpright(bool isFriendlySide)
        {
            object[] objArray1 = new object[] { isFriendlySide };
            base.method_8("StandUpright", objArray1);
        }

        public void StartDrift(bool isFriendlySide)
        {
            object[] objArray1 = new object[] { isFriendlySide };
            base.method_8("StartDrift", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateCardHeld()
        {
            base.method_8("UpdateCardHeld", Array.Empty<object>());
        }

        public void UpdateCardOver()
        {
            base.method_8("UpdateCardOver", Array.Empty<object>());
        }

        public void UpdateTargetArrow()
        {
            base.method_8("UpdateTargetArrow", Array.Empty<object>());
        }

        public static float DRIFT_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RemoteActionHandler", "DRIFT_TIME");
            }
        }

        public UserUI enemyActualUI
        {
            get
            {
                return base.method_3<UserUI>("enemyActualUI");
            }
        }

        public UserUI enemyWantedUI
        {
            get
            {
                return base.method_3<UserUI>("enemyWantedUI");
            }
        }

        public UserUI friendlyActualUI
        {
            get
            {
                return base.method_3<UserUI>("friendlyActualUI");
            }
        }

        public UserUI friendlyWantedUI
        {
            get
            {
                return base.method_3<UserUI>("friendlyWantedUI");
            }
        }

        public static float HIGH_FREQ_SEND_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RemoteActionHandler", "HIGH_FREQ_SEND_TIME");
            }
        }

        public static float LOW_FREQ_SEND_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RemoteActionHandler", "LOW_FREQ_SEND_TIME");
            }
        }

        public float m_lastSendTime
        {
            get
            {
                return base.method_2<float>("m_lastSendTime");
            }
        }

        public UserUI myCurrentUI
        {
            get
            {
                return base.method_3<UserUI>("myCurrentUI");
            }
        }

        public UserUI myLastUI
        {
            get
            {
                return base.method_3<UserUI>("myLastUI");
            }
        }

        public static List<EmoteType> s_validUserEmotes
        {
            get
            {
                Class266<EmoteType> class2 = MonoClass.smethod_7<Class266<EmoteType>>(TritonHs.MainAssemblyPath, "", "RemoteActionHandler", "s_validUserEmotes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string TWEEN_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RemoteActionHandler", "TWEEN_NAME");
            }
        }

        [Attribute38("RemoteActionHandler.CardAndID")]
        public class CardAndID : MonoClass
        {
            public CardAndID(IntPtr address) : this(address, "CardAndID")
            {
            }

            public CardAndID(IntPtr address, string className) : base(address, className)
            {
            }

            public void Clear()
            {
                base.method_8("Clear", Array.Empty<object>());
            }

            public Card card
            {
                get
                {
                    return base.method_14<Card>("get_card", Array.Empty<object>());
                }
            }

            public Triton.Game.Mapping.Entity entity
            {
                get
                {
                    return base.method_14<Triton.Game.Mapping.Entity>("get_entity", Array.Empty<object>());
                }
            }

            public int ID
            {
                get
                {
                    return base.method_11<int>("get_ID", Array.Empty<object>());
                }
            }

            public Card m_card
            {
                get
                {
                    return base.method_3<Card>("m_card");
                }
            }

            public Triton.Game.Mapping.Entity m_entity
            {
                get
                {
                    return base.method_3<Triton.Game.Mapping.Entity>("m_entity");
                }
            }

            public int m_ID
            {
                get
                {
                    return base.method_2<int>("m_ID");
                }
            }
        }

        [Attribute38("RemoteActionHandler.UserUI")]
        public class UserUI : MonoClass
        {
            public UserUI(IntPtr address) : this(address, "UserUI")
            {
            }

            public UserUI(IntPtr address, string className) : base(address, className)
            {
            }

            public void CopyFrom(RemoteActionHandler.UserUI source)
            {
                object[] objArray1 = new object[] { source };
                base.method_8("CopyFrom", objArray1);
            }

            public bool SameAs(RemoteActionHandler.UserUI compare)
            {
                object[] objArray1 = new object[] { compare };
                return base.method_11<bool>("SameAs", objArray1);
            }

            public RemoteActionHandler.CardAndID held
            {
                get
                {
                    return base.method_3<RemoteActionHandler.CardAndID>("held");
                }
            }

            public RemoteActionHandler.CardAndID origin
            {
                get
                {
                    return base.method_3<RemoteActionHandler.CardAndID>("origin");
                }
            }

            public RemoteActionHandler.CardAndID over
            {
                get
                {
                    return base.method_3<RemoteActionHandler.CardAndID>("over");
                }
            }
        }
    }
}

