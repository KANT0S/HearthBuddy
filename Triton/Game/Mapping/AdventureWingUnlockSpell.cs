namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureWingUnlockSpell")]
    public class AdventureWingUnlockSpell : MonoBehaviour
    {
        public AdventureWingUnlockSpell(IntPtr address) : this(address, "AdventureWingUnlockSpell")
        {
        }

        public AdventureWingUnlockSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_UnlockDelay
        {
            get
            {
                return base.method_2<float>("m_UnlockDelay");
            }
        }
    }
}

