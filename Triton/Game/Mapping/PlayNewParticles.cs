namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayNewParticles")]
    public class PlayNewParticles : MonoBehaviour
    {
        public PlayNewParticles(IntPtr address) : this(address, "PlayNewParticles")
        {
        }

        public PlayNewParticles(IntPtr address, string className) : base(address, className)
        {
        }

        public void PlayNewParticles3()
        {
            base.method_8("PlayNewParticles3", Array.Empty<object>());
        }

        public void PlayNewParticles3andChilds()
        {
            base.method_8("PlayNewParticles3andChilds", Array.Empty<object>());
        }

        public void PlayNewParticles3andChilds2()
        {
            base.method_8("PlayNewParticles3andChilds2", Array.Empty<object>());
        }

        public void PlayNewParticles3andChilds3()
        {
            base.method_8("PlayNewParticles3andChilds3", Array.Empty<object>());
        }

        public void StopNewParticles3()
        {
            base.method_8("StopNewParticles3", Array.Empty<object>());
        }

        public void StopNewParticles3andChilds()
        {
            base.method_8("StopNewParticles3andChilds", Array.Empty<object>());
        }

        public void StopNewParticles3andChilds2()
        {
            base.method_8("StopNewParticles3andChilds2", Array.Empty<object>());
        }

        public void StopNewParticles3andChilds3()
        {
            base.method_8("StopNewParticles3andChilds3", Array.Empty<object>());
        }

        public GameObject m_Target
        {
            get
            {
                return base.method_3<GameObject>("m_Target");
            }
        }

        public GameObject m_Target2
        {
            get
            {
                return base.method_3<GameObject>("m_Target2");
            }
        }

        public GameObject m_Target3
        {
            get
            {
                return base.method_3<GameObject>("m_Target3");
            }
        }

        public GameObject m_Target4
        {
            get
            {
                return base.method_3<GameObject>("m_Target4");
            }
        }
    }
}

