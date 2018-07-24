namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureMissionDeckPickerDisplay")]
    public class AdventureMissionDeckPickerDisplay : MonoBehaviour
    {
        public AdventureMissionDeckPickerDisplay(IntPtr address) : this(address, "AdventureMissionDeckPickerDisplay")
        {
        }

        public AdventureMissionDeckPickerDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnTrayLoaded()
        {
            base.method_8("OnTrayLoaded", Array.Empty<object>());
        }

        public DeckPickerTrayDisplay m_deckPickerTray
        {
            get
            {
                return base.method_3<DeckPickerTrayDisplay>("m_deckPickerTray");
            }
        }

        public GameObject m_deckPickerTrayContainer
        {
            get
            {
                return base.method_3<GameObject>("m_deckPickerTrayContainer");
            }
        }
    }
}

