namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DrawMorphedCardSpell")]
    public class DrawMorphedCardSpell : SuperSpell
    {
        public DrawMorphedCardSpell(IntPtr address) : this(address, "DrawMorphedCardSpell")
        {
        }

        public DrawMorphedCardSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void BeginEffects()
        {
            base.method_8("BeginEffects", Array.Empty<object>());
        }

        public void DoActionNow()
        {
            base.method_8("DoActionNow", Array.Empty<object>());
        }

        public void FindOldAndNewCards()
        {
            base.method_8("FindOldAndNewCards", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnAllTasksComplete(PowerTaskList taskList, int startIndex, int count, object userData)
        {
            object[] objArray1 = new object[] { taskList, startIndex, count, userData };
            base.method_8("OnAllTasksComplete", objArray1);
        }

        public void OnRevealTasksComplete(PowerTaskList taskList, int startIndex, int count, object userData)
        {
            object[] objArray1 = new object[] { taskList, startIndex, count, userData };
            base.method_8("OnRevealTasksComplete", objArray1);
        }

        public Card m_newCard
        {
            get
            {
                return base.method_3<Card>("m_newCard");
            }
        }

        public float m_NewCardHoldTime
        {
            get
            {
                return base.method_2<float>("m_NewCardHoldTime");
            }
        }

        public Card m_oldCard
        {
            get
            {
                return base.method_3<Card>("m_oldCard");
            }
        }

        public float m_OldCardHoldTime
        {
            get
            {
                return base.method_2<float>("m_OldCardHoldTime");
            }
        }

        public int m_revealTaskIndex
        {
            get
            {
                return base.method_2<int>("m_revealTaskIndex");
            }
        }
    }
}

