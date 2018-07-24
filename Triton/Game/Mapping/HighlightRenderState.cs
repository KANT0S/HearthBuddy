namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("HighlightRenderState")]
    public class HighlightRenderState : MonoClass
    {
        public HighlightRenderState(IntPtr address) : this(address, "HighlightRenderState")
        {
        }

        public HighlightRenderState(IntPtr address, string className) : base(address, className)
        {
        }

        public Material m_Material
        {
            get
            {
                return base.method_3<Material>("m_Material");
            }
        }

        public ActorStateType m_StateType
        {
            get
            {
                return base.method_2<ActorStateType>("m_StateType");
            }
        }
    }
}

