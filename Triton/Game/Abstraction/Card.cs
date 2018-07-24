namespace Triton.Game.Abstraction
{
    using ns27;
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game;
    using Triton.Game.Mapping;

    public class Card
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private Triton.Game.Mapping.Card card_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Entity entity_0;
        [CompilerGenerated]
        private Vector3 vector3_0;

        internal Card(Triton.Game.Mapping.Card backingObject)
        {
            this.Card_0 = backingObject;
            this.InteractPoint = Client.CardInteractPoint(this.Card_0);
            this.IsTransitioningZones = this.Card_0.IsTransitioningZones();
            this.Entity = Class274.Class274_0.method_2(this.Card_0.GetEntity());
        }

        internal Triton.Game.Mapping.Card Card_0
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

        public Vector3 InteractPoint
        {
            [CompilerGenerated]
            get
            {
                return this.vector3_0;
            }
            [CompilerGenerated]
            private set
            {
                this.vector3_0 = value;
            }
        }

        public bool IsTransitioningZones
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
    }
}

