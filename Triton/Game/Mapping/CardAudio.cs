namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CardAudio")]
    public class CardAudio : MonoClass
    {
        public CardAudio(IntPtr address) : this(address, "CardAudio")
        {
        }

        public CardAudio(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public string m_path
        {
            get
            {
                return base.method_4("m_path");
            }
        }
    }
}

