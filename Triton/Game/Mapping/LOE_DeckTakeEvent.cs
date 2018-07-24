namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE_DeckTakeEvent")]
    public class LOE_DeckTakeEvent : MonoBehaviour
    {
        public LOE_DeckTakeEvent(IntPtr address) : this(address, "LOE_DeckTakeEvent")
        {
        }

        public LOE_DeckTakeEvent(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AnimIsPlaying()
        {
            return base.method_11<bool>("AnimIsPlaying", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool m_animIsPlaying
        {
            get
            {
                return base.method_2<bool>("m_animIsPlaying");
            }
        }

        public Renderer m_friendlyDeckRenderer
        {
            get
            {
                return base.method_3<Renderer>("m_friendlyDeckRenderer");
            }
        }

        public string m_replacementDeckAnimName
        {
            get
            {
                return base.method_4("m_replacementDeckAnimName");
            }
        }

        public string m_replacementDeckSoundPrefab
        {
            get
            {
                return base.method_4("m_replacementDeckSoundPrefab");
            }
        }

        public string m_takeDeckAnimName
        {
            get
            {
                return base.method_4("m_takeDeckAnimName");
            }
        }

        public string m_takeDeckSoundPrefab
        {
            get
            {
                return base.method_4("m_takeDeckSoundPrefab");
            }
        }
    }
}

