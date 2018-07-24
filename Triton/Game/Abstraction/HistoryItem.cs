namespace Triton.Game.Abstraction
{
    using ns27;
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class HistoryItem
    {
        [CompilerGenerated]
        private Triton.Game.Abstraction.Actor actor_0;
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Entity entity_0;
        [CompilerGenerated]
        private Triton.Game.Mapping.HistoryItem historyItem_0;
        [CompilerGenerated]
        private int int_0;

        internal HistoryItem(Triton.Game.Mapping.HistoryItem backingObject)
        {
            this.HistoryItem_0 = backingObject;
            this.Dead = this.HistoryItem_0.dead;
            this.DamageAmount = this.HistoryItem_0.m_splatAmount;
            this.Entity = Class274.Class274_0.method_2(this.HistoryItem_0.GetEntity());
            this.IsFatigue = this.HistoryItem_0.isFatigue;
            this.MainCardActor = Class274.Class274_0.method_4(this.HistoryItem_0.m_mainCardActor);
        }

        public int DamageAmount
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            private set
            {
                this.int_0 = value;
            }
        }

        public bool Dead
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }

        public Triton.Game.Abstraction.Entity Entity
        {
            [CompilerGenerated]
            get
            {
                return this.entity_0;
            }
            [CompilerGenerated]
            private set
            {
                this.entity_0 = value;
            }
        }

        internal Triton.Game.Mapping.HistoryItem HistoryItem_0
        {
            [CompilerGenerated]
            get
            {
                return this.historyItem_0;
            }
            [CompilerGenerated]
            set
            {
                this.historyItem_0 = value;
            }
        }

        public bool IsFatigue
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_1 = value;
            }
        }

        public Triton.Game.Abstraction.Actor MainCardActor
        {
            [CompilerGenerated]
            get
            {
                return this.actor_0;
            }
            [CompilerGenerated]
            private set
            {
                this.actor_0 = value;
            }
        }
    }
}

