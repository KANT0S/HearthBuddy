namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FullScreenAntialiasing")]
    public class FullScreenAntialiasing : MonoBehaviour
    {
        public FullScreenAntialiasing(IntPtr address) : this(address, "FullScreenAntialiasing")
        {
        }

        public FullScreenAntialiasing(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Material FXAA_Material
        {
            get
            {
                return base.method_14<Material>("get_FXAA_Material", Array.Empty<object>());
            }
        }

        public Material m_FXAA_Material
        {
            get
            {
                return base.method_3<Material>("m_FXAA_Material");
            }
        }
    }
}

