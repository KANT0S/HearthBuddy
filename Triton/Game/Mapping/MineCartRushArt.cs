namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MineCartRushArt")]
    public class MineCartRushArt : MonoBehaviour
    {
        public MineCartRushArt(IntPtr address) : this(address, "MineCartRushArt")
        {
        }

        public MineCartRushArt(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoPortraitSwap(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
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

