namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxDiskStateInfo")]
    public class BoxDiskStateInfo : MonoClass
    {
        public BoxDiskStateInfo(IntPtr address) : this(address, "BoxDiskStateInfo")
        {
        }

        public BoxDiskStateInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_LoadingDelaySec
        {
            get
            {
                return base.method_2<float>("m_LoadingDelaySec");
            }
        }

        public iTween.EaseType m_LoadingRotateEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_LoadingRotateEaseType");
            }
        }

        public float m_LoadingRotateSec
        {
            get
            {
                return base.method_2<float>("m_LoadingRotateSec");
            }
        }

        public Vector3 m_LoadingRotation
        {
            get
            {
                return base.method_2<Vector3>("m_LoadingRotation");
            }
        }

        public float m_MainMenuDelaySec
        {
            get
            {
                return base.method_2<float>("m_MainMenuDelaySec");
            }
        }

        public iTween.EaseType m_MainMenuRotateEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_MainMenuRotateEaseType");
            }
        }

        public float m_MainMenuRotateSec
        {
            get
            {
                return base.method_2<float>("m_MainMenuRotateSec");
            }
        }

        public Vector3 m_MainMenuRotation
        {
            get
            {
                return base.method_2<Vector3>("m_MainMenuRotation");
            }
        }
    }
}

