namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxSpinner")]
    public class BoxSpinner : MonoBehaviour
    {
        public BoxSpinner(IntPtr address) : this(address, "BoxSpinner")
        {
        }

        public BoxSpinner(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public BoxSpinnerStateInfo GetInfo()
        {
            return base.method_14<BoxSpinnerStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public bool IsSpinning()
        {
            return base.method_11<bool>("IsSpinning", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void SetInfo(BoxSpinnerStateInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void SetParent(Box parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void Spin()
        {
            base.method_8("Spin", Array.Empty<object>());
        }

        public void Stop()
        {
            base.method_8("Stop", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public BoxSpinnerStateInfo m_info
        {
            get
            {
                return base.method_3<BoxSpinnerStateInfo>("m_info");
            }
        }

        public Box m_parent
        {
            get
            {
                return base.method_3<Box>("m_parent");
            }
        }

        public Material m_spinnerMat
        {
            get
            {
                return base.method_3<Material>("m_spinnerMat");
            }
        }

        public bool m_spinning
        {
            get
            {
                return base.method_2<bool>("m_spinning");
            }
        }

        public float m_spinY
        {
            get
            {
                return base.method_2<float>("m_spinY");
            }
        }
    }
}

