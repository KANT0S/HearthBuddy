namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBack")]
    public class CardBack : MonoBehaviour
    {
        public CardBack(IntPtr address) : this(address, "CardBack")
        {
        }

        public CardBack(IntPtr address, string className) : base(address, className)
        {
        }

        public Material m_CardBackMaterial
        {
            get
            {
                return base.method_3<Material>("m_CardBackMaterial");
            }
        }

        public Material m_CardBackMaterial1
        {
            get
            {
                return base.method_3<Material>("m_CardBackMaterial1");
            }
        }

        public Mesh m_CardBackMesh
        {
            get
            {
                return base.method_3<Mesh>("m_CardBackMesh");
            }
        }

        public GameObject m_DragEffect
        {
            get
            {
                return base.method_3<GameObject>("m_DragEffect");
            }
        }

        public float m_EffectMaxVelocity
        {
            get
            {
                return base.method_2<float>("m_EffectMaxVelocity");
            }
        }

        public float m_EffectMinVelocity
        {
            get
            {
                return base.method_2<float>("m_EffectMinVelocity");
            }
        }
    }
}

