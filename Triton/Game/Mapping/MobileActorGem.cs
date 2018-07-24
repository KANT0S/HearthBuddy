namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MobileActorGem")]
    public class MobileActorGem : MonoBehaviour
    {
        public MobileActorGem(IntPtr address) : this(address, "MobileActorGem")
        {
        }

        public MobileActorGem(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public GemType m_gemType
        {
            get
            {
                return base.method_2<GemType>("m_gemType");
            }
        }

        public UberText m_uberText
        {
            get
            {
                return base.method_3<UberText>("m_uberText");
            }
        }

        public enum GemType
        {
            CardPlay,
            CardHero_Health,
            CardHero_Attack,
            CardHero_Armor,
            CardHeroPower
        }
    }
}

