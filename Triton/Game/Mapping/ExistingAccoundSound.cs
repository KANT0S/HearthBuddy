namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ExistingAccoundSound")]
    public class ExistingAccoundSound : MonoClass
    {
        public ExistingAccoundSound(IntPtr address) : this(address, "ExistingAccoundSound")
        {
        }

        public ExistingAccoundSound(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_buttonClick
        {
            get
            {
                return base.method_4("m_buttonClick");
            }
        }

        public string m_innkeeperWelcome
        {
            get
            {
                return base.method_4("m_innkeeperWelcome");
            }
        }

        public string m_popupHide
        {
            get
            {
                return base.method_4("m_popupHide");
            }
        }

        public string m_popupShow
        {
            get
            {
                return base.method_4("m_popupShow");
            }
        }
    }
}

