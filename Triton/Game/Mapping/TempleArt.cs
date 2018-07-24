namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TempleArt")]
    public class TempleArt : MonoBehaviour
    {
        public TempleArt(IntPtr address) : this(address, "TempleArt")
        {
        }

        public TempleArt(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoPortraitSwap(Actor actor, int turn)
        {
            object[] objArray1 = new object[] { actor, turn };
            base.method_8("DoPortraitSwap", objArray1);
        }

        public float m_portraitSwapDelay
        {
            get
            {
                return base.method_2<float>("m_portraitSwapDelay");
            }
        }

        public Spell m_portraitSwapSpell
        {
            get
            {
                return base.method_3<Spell>("m_portraitSwapSpell");
            }
        }
    }
}

