namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Zone")]
    public class Zone : MonoBehaviour
    {
        public Zone(IntPtr address) : this(address, "Zone")
        {
        }

        public Zone(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("AddCard", objArray1);
        }

        public void AddInputBlocker()
        {
            base.method_9("AddInputBlocker", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void AddInputBlocker(int count)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { count };
            base.method_9("AddInputBlocker", enumArray1, objArray1);
        }

        public void AddLayoutBlocker()
        {
            base.method_8("AddLayoutBlocker", Array.Empty<object>());
        }

        public void BlockInput(bool block)
        {
            object[] objArray1 = new object[] { block };
            base.method_8("BlockInput", objArray1);
        }

        public bool CanAcceptTags(int controllerId, TAG_ZONE zoneTag, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { controllerId, zoneTag, cardType };
            return base.method_11<bool>("CanAcceptTags", objArray1);
        }

        public static int CardSortComparison(Card card1, Card card2)
        {
            object[] objArray1 = new object[] { card1, card2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "Zone", "CardSortComparison", objArray1);
        }

        public bool ContainsCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("ContainsCard", objArray1);
        }

        public void DirtyLayout()
        {
            base.method_8("DirtyLayout", Array.Empty<object>());
        }

        public int FindCardPos(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<int>("FindCardPos", objArray1);
        }

        public void FireUpdateLayoutCompleteCallbacks()
        {
            base.method_8("FireUpdateLayoutCompleteCallbacks", Array.Empty<object>());
        }

        public Card GetCardAtIndex(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<Card>("GetCardAtIndex", objArray1);
        }

        public Card GetCardAtPos(int pos)
        {
            object[] objArray1 = new object[] { pos };
            return base.method_14<Card>("GetCardAtPos", objArray1);
        }

        public int GetCardCount()
        {
            return base.method_11<int>("GetCardCount", Array.Empty<object>());
        }

        public List<Card> GetCards()
        {
            Class267<Card> class2 = base.method_14<Class267<Card>>("GetCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Player GetController()
        {
            return base.method_14<Player>("GetController", Array.Empty<object>());
        }

        public int GetControllerId()
        {
            return base.method_11<int>("GetControllerId", Array.Empty<object>());
        }

        public Card GetFirstCard()
        {
            return base.method_14<Card>("GetFirstCard", Array.Empty<object>());
        }

        public int GetInputBlockerCount()
        {
            return base.method_11<int>("GetInputBlockerCount", Array.Empty<object>());
        }

        public Card GetLastCard()
        {
            return base.method_14<Card>("GetLastCard", Array.Empty<object>());
        }

        public int GetLastPos()
        {
            return base.method_11<int>("GetLastPos", Array.Empty<object>());
        }

        public int GetLayoutBlockerCount()
        {
            return base.method_11<int>("GetLayoutBlockerCount", Array.Empty<object>());
        }

        public bool InsertCard(int index, Card card)
        {
            object[] objArray1 = new object[] { index, card };
            return base.method_11<bool>("InsertCard", objArray1);
        }

        public bool IsBlockingLayout()
        {
            return base.method_11<bool>("IsBlockingLayout", Array.Empty<object>());
        }

        public bool IsInputEnabled()
        {
            return base.method_11<bool>("IsInputEnabled", Array.Empty<object>());
        }

        public bool IsLayoutDirty()
        {
            return base.method_11<bool>("IsLayoutDirty", Array.Empty<object>());
        }

        public bool IsOnlyCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsOnlyCard", objArray1);
        }

        public bool IsUpdatingLayout()
        {
            return base.method_11<bool>("IsUpdatingLayout", Array.Empty<object>());
        }

        public int RemoveCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<int>("RemoveCard", objArray1);
        }

        public void RemoveInputBlocker()
        {
            base.method_8("RemoveInputBlocker", Array.Empty<object>());
        }

        public void RemoveLayoutBlocker()
        {
            base.method_8("RemoveLayoutBlocker", Array.Empty<object>());
        }

        public void SetController(Player controller)
        {
            object[] objArray1 = new object[] { controller };
            base.method_8("SetController", objArray1);
        }

        public void StartFinishLayoutTimer(float delaySec)
        {
            object[] objArray1 = new object[] { delaySec };
            base.method_8("StartFinishLayoutTimer", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void UpdateInput()
        {
            base.method_8("UpdateInput", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateLayoutFinished()
        {
            base.method_8("UpdateLayoutFinished", Array.Empty<object>());
        }

        public List<Card> m_cards
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_cards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Player m_controller
        {
            get
            {
                return base.method_3<Player>("m_controller");
            }
        }

        public int m_inputBlockerCount
        {
            get
            {
                return base.method_2<int>("m_inputBlockerCount");
            }
        }

        public int m_layoutBlockerCount
        {
            get
            {
                return base.method_2<int>("m_layoutBlockerCount");
            }
        }

        public bool m_layoutDirty
        {
            get
            {
                return base.method_2<bool>("m_layoutDirty");
            }
        }

        public TAG_ZONE m_ServerTag
        {
            get
            {
                return base.method_2<TAG_ZONE>("m_ServerTag");
            }
        }

        public Player.Side m_Side
        {
            get
            {
                return base.method_2<Player.Side>("m_Side");
            }
        }

        public bool m_updatingLayout
        {
            get
            {
                return base.method_2<bool>("m_updatingLayout");
            }
        }

        public static float TRANSITION_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Zone", "TRANSITION_SEC");
            }
        }
    }
}

