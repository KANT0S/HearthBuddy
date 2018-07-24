namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ClassSpecificVoSpell")]
    public class ClassSpecificVoSpell : CardSoundSpell
    {
        public ClassSpecificVoSpell(IntPtr address) : this(address, "ClassSpecificVoSpell")
        {
        }

        public ClassSpecificVoSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public ClassSpecificVoData m_ClassSpecificVoData
        {
            get
            {
                return base.method_3<ClassSpecificVoData>("m_ClassSpecificVoData");
            }
        }
    }
}

