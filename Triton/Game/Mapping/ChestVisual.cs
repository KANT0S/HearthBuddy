namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ChestVisual")]
    public class ChestVisual : MonoClass
    {
        public ChestVisual(IntPtr address) : this(address, "ChestVisual")
        {
        }

        public ChestVisual(IntPtr address, string className) : base(address, className)
        {
        }

        public string chestChangeAnimation
        {
            get
            {
                return base.method_4("chestChangeAnimation");
            }
        }

        public string chestName
        {
            get
            {
                return base.method_4("chestName");
            }
        }

        public string levelUpAnimation
        {
            get
            {
                return base.method_4("levelUpAnimation");
            }
        }

        public Material m_chestMaterial
        {
            get
            {
                return base.method_3<Material>("m_chestMaterial");
            }
        }

        public Mesh m_chestMesh
        {
            get
            {
                return base.method_3<Mesh>("m_chestMesh");
            }
        }

        public Material m_glowMaterial
        {
            get
            {
                return base.method_3<Material>("m_glowMaterial");
            }
        }

        public GameObject m_glowMesh
        {
            get
            {
                return base.method_3<GameObject>("m_glowMesh");
            }
        }
    }
}

