namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TrackMouseMovement")]
    public class TrackMouseMovement : MonoBehaviour
    {
        public TrackMouseMovement(IntPtr address) : this(address, "TrackMouseMovement")
        {
        }

        public TrackMouseMovement(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }
    }
}

