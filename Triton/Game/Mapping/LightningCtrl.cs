namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LightningCtrl")]
    public class LightningCtrl : MonoBehaviour
    {
        public LightningCtrl(IntPtr address) : this(address, "LightningCtrl")
        {
        }

        public LightningCtrl(IntPtr address, string className) : base(address, className)
        {
        }

        public void Spawn(Transform targetTransform, Transform destinationTransform)
        {
            object[] objArray1 = new object[] { targetTransform, destinationTransform };
            base.method_8("Spawn", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public GameObject destination
        {
            get
            {
                return base.method_3<GameObject>("destination");
            }
        }

        public float lifetime
        {
            get
            {
                return base.method_2<float>("lifetime");
            }
        }

        public GameObject lightningObj
        {
            get
            {
                return base.method_3<GameObject>("lightningObj");
            }
        }

        public GameObject mylightning
        {
            get
            {
                return base.method_3<GameObject>("mylightning");
            }
        }

        public float position_X
        {
            get
            {
                return base.method_2<float>("position_X");
            }
        }

        public float position_Y
        {
            get
            {
                return base.method_2<float>("position_Y");
            }
        }

        public float position_Z
        {
            get
            {
                return base.method_2<float>("position_Z");
            }
        }

        public float scale
        {
            get
            {
                return base.method_2<float>("scale");
            }
        }

        public float speed
        {
            get
            {
                return base.method_2<float>("speed");
            }
        }

        public GameObject target
        {
            get
            {
                return base.method_3<GameObject>("target");
            }
        }
    }
}

