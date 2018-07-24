namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CameraMask")]
    public class CameraMask : MonoBehaviour
    {
        public CameraMask(IntPtr address) : this(address, "CameraMask")
        {
        }

        public CameraMask(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Init()
        {
            return base.method_11<bool>("Init", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnDrawGizmos()
        {
            base.method_8("OnDrawGizmos", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateCameraClipping()
        {
            base.method_8("UpdateCameraClipping", Array.Empty<object>());
        }

        public void UpdateMask()
        {
            base.method_8("UpdateMask", Array.Empty<object>());
        }

        public GameLayer m_CameraFromLayer
        {
            get
            {
                return base.method_2<GameLayer>("m_CameraFromLayer");
            }
        }

        public GameObject m_ClipObjects
        {
            get
            {
                return base.method_3<GameObject>("m_ClipObjects");
            }
        }

        public List<GameLayer> m_CullingMasks
        {
            get
            {
                Class266<GameLayer> class2 = base.method_3<Class266<GameLayer>>("m_CullingMasks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_Height
        {
            get
            {
                return base.method_2<float>("m_Height");
            }
        }

        public Camera m_MaskCamera
        {
            get
            {
                return base.method_3<Camera>("m_MaskCamera");
            }
        }

        public GameObject m_MaskCameraGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_MaskCameraGameObject");
            }
        }

        public bool m_RealtimeUpdate
        {
            get
            {
                return base.method_2<bool>("m_RealtimeUpdate");
            }
        }

        public Camera m_RenderCamera
        {
            get
            {
                return base.method_3<Camera>("m_RenderCamera");
            }
        }

        public CAMERA_MASK_UP_VECTOR m_UpVector
        {
            get
            {
                return base.method_2<CAMERA_MASK_UP_VECTOR>("m_UpVector");
            }
        }

        public bool m_UseCameraFromLayer
        {
            get
            {
                return base.method_2<bool>("m_UseCameraFromLayer");
            }
        }

        public float m_Width
        {
            get
            {
                return base.method_2<float>("m_Width");
            }
        }

        public enum CAMERA_MASK_UP_VECTOR
        {
            Y,
            Z
        }
    }
}

