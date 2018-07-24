namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB_KelthuzadRafaam")]
    public class TB_KelthuzadRafaam : MissionEntity
    {
        public TB_KelthuzadRafaam(IntPtr address) : this(address, "TB_KelthuzadRafaam")
        {
        }

        public TB_KelthuzadRafaam(IntPtr address, string className) : base(address, className)
        {
        }

        public Card m_kelthuzadCard
        {
            get
            {
                return base.method_3<Card>("m_kelthuzadCard");
            }
        }
    }
}

