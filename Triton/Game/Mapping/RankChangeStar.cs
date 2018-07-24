namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RankChangeStar")]
    public class RankChangeStar : MonoBehaviour
    {
        public RankChangeStar(IntPtr address) : this(address, "RankChangeStar")
        {
        }

        public RankChangeStar(IntPtr address, string className) : base(address, className)
        {
        }

        public void BlackOut()
        {
            base.method_8("BlackOut", Array.Empty<object>());
        }

        public void Blink(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("Blink", objArray1);
        }

        public void Burst(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("Burst", objArray1);
        }

        public void Despawn()
        {
            base.method_8("Despawn", Array.Empty<object>());
        }

        public void FadeIn()
        {
            base.method_8("FadeIn", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void Spawn()
        {
            base.method_8("Spawn", Array.Empty<object>());
        }

        public void UnBlackOut()
        {
            base.method_8("UnBlackOut", Array.Empty<object>());
        }

        public void Wipe(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("Wipe", objArray1);
        }

        public MeshRenderer m_bottomGlowRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_bottomGlowRenderer");
            }
        }

        public MeshRenderer m_starMeshRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_starMeshRenderer");
            }
        }

        public MeshRenderer m_topGlowRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_topGlowRenderer");
            }
        }
    }
}

