namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("RandomAudioClip")]
    public class RandomAudioClip : MonoClass
    {
        public RandomAudioClip(IntPtr address) : this(address, "RandomAudioClip")
        {
        }

        public RandomAudioClip(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_Weight
        {
            get
            {
                return base.method_2<float>("m_Weight");
            }
        }
    }
}

