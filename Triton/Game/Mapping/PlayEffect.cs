namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayEffect")]
    public class PlayEffect : MonoBehaviour
    {
        public PlayEffect(IntPtr address) : this(address, "PlayEffect")
        {
        }

        public PlayEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public void PlayEmitter1()
        {
            base.method_8("PlayEmitter1", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StopEmitter1()
        {
            base.method_8("StopEmitter1", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public GameObject fxEmitter1
        {
            get
            {
                return base.method_3<GameObject>("fxEmitter1");
            }
        }
    }
}

