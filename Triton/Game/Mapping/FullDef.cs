namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FullDef")]
    public class FullDef : MonoClass
    {
        public FullDef(IntPtr address) : this(address, "FullDef")
        {
        }

        public FullDef(IntPtr address, string className) : base(address, className)
        {
        }

        public CardDef GetCardDef()
        {
            return base.method_14<CardDef>("GetCardDef", Array.Empty<object>());
        }

        public EntityDef GetEntityDef()
        {
            return base.method_14<EntityDef>("GetEntityDef", Array.Empty<object>());
        }

        public bool IsEmpty()
        {
            return base.method_11<bool>("IsEmpty", Array.Empty<object>());
        }

        public void SetCardDef(CardDef cardDef)
        {
            object[] objArray1 = new object[] { cardDef };
            base.method_8("SetCardDef", objArray1);
        }

        public void SetEntityDef(EntityDef entityDef)
        {
            object[] objArray1 = new object[] { entityDef };
            base.method_8("SetEntityDef", objArray1);
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }
    }
}

