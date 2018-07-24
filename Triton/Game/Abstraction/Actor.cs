namespace Triton.Game.Abstraction
{
    using ns27;
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class Actor
    {
        [CompilerGenerated]
        private Triton.Game.Mapping.Actor actor_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Card card_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Entity entity_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.EntityDef entityDef_0;
        [CompilerGenerated]
        private Vector3 vector3_0;

        internal Actor(Triton.Game.Mapping.Actor backingObject)
        {
            this.Actor_0 = backingObject;
            this.InteractPoint = backingObject.Transform.Position;
            this.Card = Class274.Class274_0.method_1(this.Actor_0.GetCard());
            this.Entity = Class274.Class274_0.method_2(this.Actor_0.GetEntity());
            this.EntityDef = Class274.Class274_0.method_3(this.Actor_0.GetEntityDef());
        }

        internal Triton.Game.Mapping.Actor Actor_0
        {
            [CompilerGenerated]
            get
            {
                return this.actor_0;
            }
            [CompilerGenerated]
            set
            {
                this.actor_0 = value;
            }
        }

        public Triton.Game.Abstraction.Card Card
        {
            [CompilerGenerated]
            get
            {
                return this.card_0;
            }
            [CompilerGenerated]
            private set
            {
                this.card_0 = value;
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

        public Vector3 InteractPoint
        {
            [CompilerGenerated]
            get
            {
                return this.vector3_0;
            }
            [CompilerGenerated]
            set
            {
                this.vector3_0 = value;
            }
        }
    }
}

