namespace ns27
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game;
    using Triton.Game.Abstraction;
    using Triton.Game.Mapping;

    internal class Class274
    {
        private readonly Dictionary<IntPtr, Triton.Game.Abstraction.Card> dictionary_0 = new Dictionary<IntPtr, Triton.Game.Abstraction.Card>();
        private readonly Dictionary<IntPtr, Triton.Game.Abstraction.Entity> dictionary_1 = new Dictionary<IntPtr, Triton.Game.Abstraction.Entity>();
        private readonly Dictionary<IntPtr, Triton.Game.Abstraction.EntityDef> dictionary_2 = new Dictionary<IntPtr, Triton.Game.Abstraction.EntityDef>();
        private readonly Dictionary<IntPtr, Triton.Game.Abstraction.Actor> dictionary_3 = new Dictionary<IntPtr, Triton.Game.Abstraction.Actor>();
        private readonly Dictionary<IntPtr, Triton.Game.Abstraction.Player> dictionary_4 = new Dictionary<IntPtr, Triton.Game.Abstraction.Player>();
        private static readonly PerFrameCachedValue<Class274> perFrameCachedValue_0 = new PerFrameCachedValue<Class274>(new Func<Class274>(Class275.<>9.method_0));

        internal Triton.Game.Abstraction.Player method_0(Triton.Game.Mapping.Player player_0)
        {
            Triton.Game.Abstraction.Player player;
            if (player_0 == null)
            {
                return null;
            }
            if (!this.dictionary_4.TryGetValue(player_0.Address, out player))
            {
                player = new Triton.Game.Abstraction.Player(player_0);
                this.dictionary_4.Add(player_0.Address, player);
            }
            return player;
        }

        internal Triton.Game.Abstraction.Card method_1(Triton.Game.Mapping.Card card_0)
        {
            Triton.Game.Abstraction.Card card;
            if (card_0 == null)
            {
                return null;
            }
            if (!this.dictionary_0.TryGetValue(card_0.Address, out card))
            {
                card = new Triton.Game.Abstraction.Card(card_0);
                this.dictionary_0.Add(card_0.Address, card);
            }
            return card;
        }

        internal Triton.Game.Abstraction.Entity method_2(Triton.Game.Mapping.Entity entity_0)
        {
            Triton.Game.Abstraction.Entity entity;
            if (entity_0 == null)
            {
                return null;
            }
            if (!this.dictionary_1.TryGetValue(entity_0.Address, out entity))
            {
                entity = new Triton.Game.Abstraction.Entity(entity_0);
                this.dictionary_1.Add(entity_0.Address, entity);
            }
            return entity;
        }

        internal Triton.Game.Abstraction.EntityDef method_3(Triton.Game.Mapping.EntityDef entityDef_0)
        {
            Triton.Game.Abstraction.EntityDef def;
            if (entityDef_0 == null)
            {
                return null;
            }
            if (!this.dictionary_2.TryGetValue(entityDef_0.Address, out def))
            {
                def = new Triton.Game.Abstraction.EntityDef(entityDef_0);
                this.dictionary_2.Add(entityDef_0.Address, def);
            }
            return def;
        }

        internal Triton.Game.Abstraction.Actor method_4(Triton.Game.Mapping.Actor actor_0)
        {
            Triton.Game.Abstraction.Actor actor;
            if (actor_0 == null)
            {
                return null;
            }
            if (!this.dictionary_3.TryGetValue(actor_0.Address, out actor))
            {
                actor = new Triton.Game.Abstraction.Actor(actor_0);
                this.dictionary_3.Add(actor_0.Address, actor);
            }
            return actor;
        }

        public static Class274 Class274_0
        {
            get
            {
                return (Class274) perFrameCachedValue_0;
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class275
        {
            public static readonly Class274.Class275 <>9 = new Class274.Class275();

            internal Class274 method_0()
            {
                return new Class274();
            }
        }
    }
}

