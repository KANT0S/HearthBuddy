namespace Triton.Game.Abstraction
{
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class EntityDef
    {
        [CompilerGenerated]
        private Triton.Game.Mapping.EntityDef entityDef_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private int int_2;
        [CompilerGenerated]
        private int int_3;
        [CompilerGenerated]
        private int int_4;
        [CompilerGenerated]
        private int int_5;
        [CompilerGenerated]
        private int int_6;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private string string_2;
        [CompilerGenerated]
        private string string_3;
        [CompilerGenerated]
        private TAG_CARDTYPE tag_CARDTYPE_0;
        [CompilerGenerated]
        private TAG_CLASS tag_CLASS_0;
        [CompilerGenerated]
        private TAG_RACE tag_RACE_0;
        [CompilerGenerated]
        private TAG_RARITY tag_RARITY_0;

        public EntityDef(Triton.Game.Mapping.EntityDef backingObject)
        {
            this.EntityDef_0 = backingObject;
            this.CardId = this.EntityDef_0.GetCardId();
            this.Class = this.EntityDef_0.GetClass();
            this.Race = this.EntityDef_0.GetRace();
            this.Rarity = this.EntityDef_0.GetRarity();
            this.Name = this.EntityDef_0.GetName();
            this.FlavorText = this.EntityDef_0.GetFlavorText();
            this.CardType = this.EntityDef_0.GetCardType();
            this.Cost = this.EntityDef_0.GetTag(GAME_TAG.COST);
            this.Attack = this.EntityDef_0.GetTag(GAME_TAG.ATK);
            this.Health = this.EntityDef_0.GetTag(GAME_TAG.HEALTH);
            this.Charge = this.EntityDef_0.GetTag(GAME_TAG.CHARGE);
            this.Silence = this.EntityDef_0.GetTag(GAME_TAG.SILENCE);
            this.Taunt = this.EntityDef_0.GetTag(GAME_TAG.TAUNT);
            this.Battlecry = this.EntityDef_0.GetTag(GAME_TAG.BATTLECRY);
            this.CardText = this.EntityDef_0.GetStringTag(GAME_TAG.CARDTEXT_INHAND);
        }

        public int Attack
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            private set
            {
                this.int_1 = value;
            }
        }

        public int Battlecry
        {
            [CompilerGenerated]
            get
            {
                return this.int_6;
            }
            [CompilerGenerated]
            private set
            {
                this.int_6 = value;
            }
        }

        public string CardId
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

        public string CardText
        {
            [CompilerGenerated]
            get
            {
                return this.string_3;
            }
            [CompilerGenerated]
            private set
            {
                this.string_3 = value;
            }
        }

        public TAG_CARDTYPE CardType
        {
            [CompilerGenerated]
            get
            {
                return this.tag_CARDTYPE_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_CARDTYPE_0 = value;
            }
        }

        public int Charge
        {
            [CompilerGenerated]
            get
            {
                return this.int_3;
            }
            [CompilerGenerated]
            private set
            {
                this.int_3 = value;
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

        public int Cost
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

        internal Triton.Game.Mapping.EntityDef EntityDef_0
        {
            [CompilerGenerated]
            get
            {
                return this.entityDef_0;
            }
            [CompilerGenerated]
            set
            {
                this.entityDef_0 = value;
            }
        }

        public string FlavorText
        {
            [CompilerGenerated]
            get
            {
                return this.string_2;
            }
            [CompilerGenerated]
            private set
            {
                this.string_2 = value;
            }
        }

        public int Health
        {
            [CompilerGenerated]
            get
            {
                return this.int_2;
            }
            [CompilerGenerated]
            private set
            {
                this.int_2 = value;
            }
        }

        public string Name
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

        public TAG_RARITY Rarity
        {
            [CompilerGenerated]
            get
            {
                return this.tag_RARITY_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_RARITY_0 = value;
            }
        }

        public int Silence
        {
            [CompilerGenerated]
            get
            {
                return this.int_4;
            }
            [CompilerGenerated]
            private set
            {
                this.int_4 = value;
            }
        }

        public int Taunt
        {
            [CompilerGenerated]
            get
            {
                return this.int_5;
            }
            [CompilerGenerated]
            private set
            {
                this.int_5 = value;
            }
        }
    }
}

