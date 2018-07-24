namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB01_RagVsNef")]
    public class TB01_RagVsNef : MissionEntity
    {
        public TB01_RagVsNef(IntPtr address) : this(address, "TB01_RagVsNef")
        {
        }

        public TB01_RagVsNef(IntPtr address, string className) : base(address, className)
        {
        }

        public Card m_ragnarosCard
        {
            get
            {
                return base.method_3<Card>("m_ragnarosCard");
            }
        }
    }
}

