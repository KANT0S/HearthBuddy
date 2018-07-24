namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TurnStartManager")]
    public class TurnStartManager : MonoBehaviour
    {
        public TurnStartManager(IntPtr address) : this(address, "TurnStartManager")
        {
        }

        public TurnStartManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BeginListeningForTurnEvents()
        {
            base.method_8("BeginListeningForTurnEvents", Array.Empty<object>());
        }

        public void BeginPlayingTurnEvents()
        {
            base.method_8("BeginPlayingTurnEvents", Array.Empty<object>());
        }

        public void DisplayTwoScoops()
        {
            base.method_8("DisplayTwoScoops", Array.Empty<object>());
        }

        public static TurnStartManager Get()
        {
            return MonoClass.smethod_15<TurnStartManager>(TritonHs.MainAssemblyPath, "", "TurnStartManager", "Get", Array.Empty<object>());
        }

        public List<Card> GetCardsToDraw()
        {
            Class267<Card> class2 = base.method_14<Class267<Card>>("GetCardsToDraw", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetNumCardsToDraw()
        {
            return base.method_11<int>("GetNumCardsToDraw", Array.Empty<object>());
        }

        public SpellController GetSpellController()
        {
            return base.method_14<SpellController>("GetSpellController", Array.Empty<object>());
        }

        public void HandleExhaustedChanges()
        {
            base.method_8("HandleExhaustedChanges", Array.Empty<object>());
        }

        public bool HasActionsAfterCardDraw()
        {
            return base.method_11<bool>("HasActionsAfterCardDraw", Array.Empty<object>());
        }

        public bool IsBlockingInput()
        {
            return base.method_11<bool>("IsBlockingInput", Array.Empty<object>());
        }

        public bool IsCardDrawHandled(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCardDrawHandled", objArray1);
        }

        public bool IsListeningForTurnEvents()
        {
            return base.method_11<bool>("IsListeningForTurnEvents", Array.Empty<object>());
        }

        public void NotifyOfCardDrawn(Triton.Game.Mapping.Entity drawnEntity)
        {
            object[] objArray1 = new object[] { drawnEntity };
            base.method_8("NotifyOfCardDrawn", objArray1);
        }

        public void NotifyOfExhaustedChange(Card card, TagDelta tagChange)
        {
            object[] objArray1 = new object[] { card, tagChange };
            base.method_8("NotifyOfExhaustedChange", objArray1);
        }

        public void NotifyOfManaCrystalFilled(int amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("NotifyOfManaCrystalFilled", objArray1);
        }

        public void NotifyOfManaCrystalGained(int amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("NotifyOfManaCrystalGained", objArray1);
        }

        public void NotifyOfSpellController(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            base.method_8("NotifyOfSpellController", objArray1);
        }

        public void NotifyOfTriggerVisual()
        {
            base.method_8("NotifyOfTriggerVisual", Array.Empty<object>());
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

        public bool m_blockingInput
        {
            get
            {
                return base.method_2<bool>("m_blockingInput");
            }
        }

        public List<Card> m_cardsToDraw
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_cardsToDraw");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<CardChange> m_exhaustedChangesToHandle
        {
            get
            {
                Class267<CardChange> class2 = base.method_3<Class267<CardChange>>("m_exhaustedChangesToHandle");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_listeningForTurnEvents
        {
            get
            {
                return base.method_2<bool>("m_listeningForTurnEvents");
            }
        }

        public int m_manaCrystalsFilled
        {
            get
            {
                return base.method_2<int>("m_manaCrystalsFilled");
            }
        }

        public int m_manaCrystalsGained
        {
            get
            {
                return base.method_2<int>("m_manaCrystalsGained");
            }
        }

        public SpellController m_spellController
        {
            get
            {
                return base.method_3<SpellController>("m_spellController");
            }
        }

        public TurnStartIndicator m_turnStartInstance
        {
            get
            {
                return base.method_3<TurnStartIndicator>("m_turnStartInstance");
            }
        }

        public TurnStartIndicator m_turnStartPrefab
        {
            get
            {
                return base.method_3<TurnStartIndicator>("m_turnStartPrefab");
            }
        }

        public bool m_twoScoopsDisplayed
        {
            get
            {
                return base.method_2<bool>("m_twoScoopsDisplayed");
            }
        }

        [Attribute38("TurnStartManager.CardChange")]
        public class CardChange : MonoClass
        {
            public CardChange(IntPtr address) : this(address, "CardChange")
            {
            }

            public CardChange(IntPtr address, string className) : base(address, className)
            {
            }

            public Card m_card
            {
                get
                {
                    return base.method_3<Card>("m_card");
                }
            }

            public TagDelta m_tagDelta
            {
                get
                {
                    return base.method_3<TagDelta>("m_tagDelta");
                }
            }
        }
    }
}

