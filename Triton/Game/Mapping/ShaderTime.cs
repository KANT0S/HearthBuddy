namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ShaderTime")]
    public class ShaderTime : MonoBehaviour
    {
        public ShaderTime(IntPtr address) : this(address, "ShaderTime")
        {
        }

        public ShaderTime(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateGyro()
        {
            base.method_8("UpdateGyro", Array.Empty<object>());
        }

        public void UpdateShaderAnimationTime()
        {
            base.method_8("UpdateShaderAnimationTime", Array.Empty<object>());
        }

        public float m_maxTime
        {
            get
            {
                return base.method_2<float>("m_maxTime");
            }
        }

        public float m_time
        {
            get
            {
                return base.method_2<float>("m_time");
            }
        }
    }
}

