namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AssignActorPortraitToChildren")]
    public class AssignActorPortraitToChildren : MonoBehaviour
    {
        public AssignActorPortraitToChildren(IntPtr address) : this(address, "AssignActorPortraitToChildren")
        {
        }

        public AssignActorPortraitToChildren(IntPtr address, string className) : base(address, className)
        {
        }

        public void AssignPortraitToAllChildren()
        {
            base.method_8("AssignPortraitToAllChildren", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }
    }
}

