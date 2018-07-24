namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TGTArrow")]
    public class TGTArrow : MonoBehaviour
    {
        public TGTArrow(IntPtr address) : this(address, "TGTArrow")
        {
        }

        public TGTArrow(IntPtr address, string className) : base(address, className)
        {
        }

        public void ArrowAnimation()
        {
            base.method_8("ArrowAnimation", Array.Empty<object>());
        }

        public void Bullseye()
        {
            base.method_8("Bullseye", Array.Empty<object>());
        }

        public void FireArrow(bool randomRotation)
        {
            object[] objArray1 = new object[] { randomRotation };
            base.method_8("FireArrow", objArray1);
        }

        public void OnAnimationComplete()
        {
            base.method_8("OnAnimationComplete", Array.Empty<object>());
        }

        public void onEnable()
        {
            base.method_8("onEnable", Array.Empty<object>());
        }

        public GameObject m_ArrowMesh
        {
            get
            {
                return base.method_3<GameObject>("m_ArrowMesh");
            }
        }

        public GameObject m_ArrowRoot
        {
            get
            {
                return base.method_3<GameObject>("m_ArrowRoot");
            }
        }

        public GameObject m_Trail
        {
            get
            {
                return base.method_3<GameObject>("m_Trail");
            }
        }
    }
}

