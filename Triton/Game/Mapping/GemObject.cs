namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GemObject")]
    public class GemObject : MonoBehaviour
    {
        public GemObject(IntPtr address) : this(address, "GemObject")
        {
        }

        public GemObject(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Enlarge(float scaleFactor)
        {
            object[] objArray1 = new object[] { scaleFactor };
            base.method_8("Enlarge", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsNumberHidden()
        {
            return base.method_11<bool>("IsNumberHidden", Array.Empty<object>());
        }

        public void Jiggle()
        {
            base.method_8("Jiggle", Array.Empty<object>());
        }

        public void ScaleToZero()
        {
            base.method_8("ScaleToZero", Array.Empty<object>());
        }

        public void SetHideNumberFlag(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetHideNumberFlag", objArray1);
        }

        public void SetToZeroThenEnlarge()
        {
            base.method_8("SetToZeroThenEnlarge", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Shrink()
        {
            base.method_8("Shrink", Array.Empty<object>());
        }

        public bool initialized
        {
            get
            {
                return base.method_2<bool>("initialized");
            }
        }

        public float jiggleAmount
        {
            get
            {
                return base.method_2<float>("jiggleAmount");
            }
        }

        public bool m_hiddenFlag
        {
            get
            {
                return base.method_2<bool>("m_hiddenFlag");
            }
        }

        public Vector3 startingScale
        {
            get
            {
                return base.method_2<Vector3>("startingScale");
            }
        }
    }
}

