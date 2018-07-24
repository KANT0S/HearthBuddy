namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("GamesWonCrown")]
    public class GamesWonCrown : MonoClass
    {
        public GamesWonCrown(IntPtr address) : this(address, "GamesWonCrown")
        {
        }

        public GamesWonCrown(IntPtr address, string className) : base(address, className)
        {
        }

        public void Animate()
        {
            base.method_8("Animate", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public GameObject m_crown
        {
            get
            {
                return base.method_3<GameObject>("m_crown");
            }
        }
    }
}

