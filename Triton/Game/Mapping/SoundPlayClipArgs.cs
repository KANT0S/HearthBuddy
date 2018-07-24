namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SoundPlayClipArgs")]
    public class SoundPlayClipArgs : MonoClass
    {
        public SoundPlayClipArgs(IntPtr address) : this(address, "SoundPlayClipArgs")
        {
        }

        public SoundPlayClipArgs(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_parentObject
        {
            get
            {
                return base.method_3<GameObject>("m_parentObject");
            }
        }
    }
}

