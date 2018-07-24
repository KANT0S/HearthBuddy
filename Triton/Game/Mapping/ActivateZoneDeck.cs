namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ActivateZoneDeck")]
    public class ActivateZoneDeck : MonoBehaviour
    {
        public ActivateZoneDeck(IntPtr address) : this(address, "ActivateZoneDeck")
        {
        }

        public ActivateZoneDeck(IntPtr address, string className) : base(address, className)
        {
        }

        public void ToggleActive()
        {
            base.method_8("ToggleActive", Array.Empty<object>());
        }

        public bool m_friendlyDeck
        {
            get
            {
                return base.method_2<bool>("m_friendlyDeck");
            }
        }

        public bool onoff
        {
            get
            {
                return base.method_2<bool>("onoff");
            }
        }
    }
}

