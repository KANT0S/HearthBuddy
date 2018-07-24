namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Crush")]
    public class Crush : Spell
    {
        public Crush(IntPtr address) : this(address, "Crush")
        {
        }

        public Crush(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public UberText m_attack
        {
            get
            {
                return base.method_3<UberText>("m_attack");
            }
        }

        public UberText m_health
        {
            get
            {
                return base.method_3<UberText>("m_health");
            }
        }

        public MinionPieces m_minionPieces
        {
            get
            {
                return base.method_3<MinionPieces>("m_minionPieces");
            }
        }

        public Material m_premiumEliteMaterial
        {
            get
            {
                return base.method_3<Material>("m_premiumEliteMaterial");
            }
        }

        public Material m_premiumTauntMaterial
        {
            get
            {
                return base.method_3<Material>("m_premiumTauntMaterial");
            }
        }
    }
}

