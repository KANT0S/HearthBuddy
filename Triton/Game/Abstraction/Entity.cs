namespace Triton.Game.Abstraction
{
    using ns27;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class Entity : Triton.Game.Abstraction.EntityBase
    {
        [CompilerGenerated]
        private Triton.Game.Mapping.Entity entity_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.EntityDef entityDef_0;
        [CompilerGenerated]
        private int int_24;
        [CompilerGenerated]
        private int int_25;
        [CompilerGenerated]
        private int int_26;
        [CompilerGenerated]
        private int int_27;
        [CompilerGenerated]
        private int int_28;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Entity> list_0;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private TAG_CLASS tag_CLASS_0;
        [CompilerGenerated]
        private TAG_RACE tag_RACE_0;

        internal Entity(Triton.Game.Mapping.Entity backingObject) : base(backingObject)
        {
            this.Entity_0 = backingObject;
            this.EntityDef = Class274.Class274_0.method_3(this.Entity_0.GetEntityDef());
            this.Name = this.Entity_0.GetName();
            this.Id = this.Entity_0.GetCardId();
            this.Class = this.Entity_0.GetClass();
            this.Race = this.Entity_0.GetRace();
            this.RealTimeCost = this.Entity_0.GetRealTimeCost();
            this.RealTimeRemainingHP = this.Entity_0.GetRealTimeRemainingHP();
            this.RealTimeAttack = this.Entity_0.GetRealTimeAttack();
            this.RealTimeArmor = this.Entity_0.m_realTimeArmor;
            this.RealTimeDamage = this.Entity_0.m_realTimeDamage;
            this.Attachments = new List<Triton.Game.Abstraction.Entity>();
            foreach (Triton.Game.Mapping.Entity entity in this.Entity_0.GetAttachments())
            {
                this.Attachments.Add(Class274.Class274_0.method_2(entity));
            }
        }

        public List<Triton.Game.Abstraction.Entity> Attachments
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }

        public TAG_CLASS Class
        {
            [CompilerGenerated]
            get
            {
                return this.tag_CLASS_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_CLASS_0 = value;
            }
        }

        internal Triton.Game.Mapping.Entity Entity_0
        {
            [CompilerGenerated]
            get
            {
                return this.entity_0;
            }
            [CompilerGenerated]
            set
            {
                this.entity_0 = value;
            }
        }

        public Triton.Game.Abstraction.EntityDef EntityDef
        {
            [CompilerGenerated]
            get
            {
                return this.entityDef_0;
            }
            [CompilerGenerated]
            private set
            {
                this.entityDef_0 = value;
            }
        }

        public string Id
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }

        public string Name
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }

        public TAG_RACE Race
        {
            [CompilerGenerated]
            get
            {
                return this.tag_RACE_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_RACE_0 = value;
            }
        }

        public int RealTimeArmor
        {
            [CompilerGenerated]
            get
            {
                return this.int_27;
            }
            [CompilerGenerated]
            private set
            {
                this.int_27 = value;
            }
        }

        public int RealTimeAttack
        {
            [CompilerGenerated]
            get
            {
                return this.int_26;
            }
            [CompilerGenerated]
            private set
            {
                this.int_26 = value;
            }
        }

        public int RealTimeCost
        {
            [CompilerGenerated]
            get
            {
                return this.int_24;
            }
            [CompilerGenerated]
            private set
            {
                this.int_24 = value;
            }
        }

        public int RealTimeDamage
        {
            [CompilerGenerated]
            get
            {
                return this.int_28;
            }
            [CompilerGenerated]
            private set
            {
                this.int_28 = value;
            }
        }

        public int RealTimeRemainingHP
        {
            [CompilerGenerated]
            get
            {
                return this.int_25;
            }
            [CompilerGenerated]
            private set
            {
                this.int_25 = value;
            }
        }
    }
}

