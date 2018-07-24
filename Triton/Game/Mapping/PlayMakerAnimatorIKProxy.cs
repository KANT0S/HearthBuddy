namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayMakerAnimatorIKProxy")]
    public class PlayMakerAnimatorIKProxy : MonoBehaviour
    {
        public PlayMakerAnimatorIKProxy(IntPtr address) : this(address, "PlayMakerAnimatorIKProxy")
        {
        }

        public PlayMakerAnimatorIKProxy(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAnimatorIK(int layerIndex)
        {
            object[] objArray1 = new object[] { layerIndex };
            base.method_8("OnAnimatorIK", objArray1);
        }
    }
}

