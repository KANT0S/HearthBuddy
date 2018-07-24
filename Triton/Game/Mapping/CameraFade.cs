namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CameraFade")]
    public class CameraFade : MonoBehaviour
    {
        public CameraFade(IntPtr address) : this(address, "CameraFade")
        {
        }

        public CameraFade(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CreateRenderPlane()
        {
            base.method_8("CreateRenderPlane", Array.Empty<object>());
        }

        public void SetupCamera()
        {
            base.method_8("SetupCamera", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Camera m_Camera
        {
            get
            {
                return base.method_3<Camera>("m_Camera");
            }
        }

        public float m_CameraDepth
        {
            get
            {
                return base.method_2<float>("m_CameraDepth");
            }
        }

        public Color m_Color
        {
            get
            {
                return base.method_2<Color>("m_Color");
            }
        }

        public float m_Fade
        {
            get
            {
                return base.method_2<float>("m_Fade");
            }
        }

        public Material m_Material
        {
            get
            {
                return base.method_3<Material>("m_Material");
            }
        }

        public GameObject m_PlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_PlaneGameObject");
            }
        }

        public bool m_RenderOverAll
        {
            get
            {
                return base.method_2<bool>("m_RenderOverAll");
            }
        }
    }
}

