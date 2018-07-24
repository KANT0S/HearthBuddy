namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AnimationEventSetParent")]
    public class AnimationEventSetParent : MonoBehaviour
    {
        public AnimationEventSetParent(IntPtr address) : this(address, "AnimationEventSetParent")
        {
        }

        public AnimationEventSetParent(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetParent()
        {
            base.method_8("SetParent", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_Parent
        {
            get
            {
                return base.method_3<GameObject>("m_Parent");
            }
        }
    }
}

