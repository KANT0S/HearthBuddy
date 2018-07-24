namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayMakerAnimatorMoveProxy")]
    public class PlayMakerAnimatorMoveProxy : MonoBehaviour
    {
        public PlayMakerAnimatorMoveProxy(IntPtr address) : this(address, "PlayMakerAnimatorMoveProxy")
        {
        }

        public PlayMakerAnimatorMoveProxy(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAnimatorMove()
        {
            base.method_8("OnAnimatorMove", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool applyRootMotion
        {
            get
            {
                return base.method_2<bool>("applyRootMotion");
            }
        }
    }
}

