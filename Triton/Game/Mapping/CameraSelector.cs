namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CameraSelector")]
    public class CameraSelector : MonoBehaviour
    {
        public CameraSelector(IntPtr address) : this(address, "CameraSelector")
        {
        }

        public CameraSelector(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnMouseDown()
        {
            base.method_8("OnMouseDown", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool activateOnStart
        {
            get
            {
                return base.method_2<bool>("activateOnStart");
            }
        }

        public Vector3 cameraPosition
        {
            get
            {
                return base.method_2<Vector3>("cameraPosition");
            }
        }

        public Vector3 cameraRotation
        {
            get
            {
                return base.method_2<Vector3>("cameraRotation");
            }
        }
    }
}

