namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayMakerAnimatorStateSynchronization")]
    public class PlayMakerAnimatorStateSynchronization : MonoBehaviour
    {
        public PlayMakerAnimatorStateSynchronization(IntPtr address) : this(address, "PlayMakerAnimatorStateSynchronization")
        {
        }

        public PlayMakerAnimatorStateSynchronization(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Synchronize()
        {
            base.method_8("Synchronize", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool debug
        {
            get
            {
                return base.method_2<bool>("debug");
            }
        }

        public bool EveryFrame
        {
            get
            {
                return base.method_2<bool>("EveryFrame");
            }
        }

        public int lastState
        {
            get
            {
                return base.method_2<int>("lastState");
            }
        }

        public int lastTransition
        {
            get
            {
                return base.method_2<int>("lastTransition");
            }
        }

        public int LayerIndex
        {
            get
            {
                return base.method_2<int>("LayerIndex");
            }
        }
    }
}

