namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AnimSpeed")]
    public class AnimSpeed : MonoBehaviour
    {
        public AnimSpeed(IntPtr address) : this(address, "AnimSpeed")
        {
        }

        public AnimSpeed(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float animspeed
        {
            get
            {
                return base.method_2<float>("animspeed");
            }
        }
    }
}

