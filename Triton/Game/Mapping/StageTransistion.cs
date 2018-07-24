namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StageTransistion")]
    public class StageTransistion : MonoBehaviour
    {
        public StageTransistion(IntPtr address) : this(address, "StageTransistion")
        {
        }

        public StageTransistion(IntPtr address, string className) : base(address, className)
        {
        }

        public void ManaUse()
        {
            base.method_8("ManaUse", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void OnMouseDown()
        {
            base.method_8("OnMouseDown", Array.Empty<object>());
        }

        public void OnMouseEnter()
        {
            base.method_8("OnMouseEnter", Array.Empty<object>());
        }

        public void OnMouseExit()
        {
            base.method_8("OnMouseExit", Array.Empty<object>());
        }

        public void OnSelected()
        {
            base.method_8("OnSelected", Array.Empty<object>());
        }

        public void RaysOn()
        {
            base.method_8("RaysOn", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool amountchange
        {
            get
            {
                return base.method_2<bool>("amountchange");
            }
        }

        public bool colorchange
        {
            get
            {
                return base.method_2<bool>("colorchange");
            }
        }

        public Color endColor
        {
            get
            {
                return base.method_2<Color>("endColor");
            }
        }

        public GameObject entireObj
        {
            get
            {
                return base.method_3<GameObject>("entireObj");
            }
        }

        public GameObject flash
        {
            get
            {
                return base.method_3<GameObject>("flash");
            }
        }

        public bool flashchange
        {
            get
            {
                return base.method_2<bool>("flashchange");
            }
        }

        public Color flashendColor
        {
            get
            {
                return base.method_2<Color>("flashendColor");
            }
        }

        public float fxATime
        {
            get
            {
                return base.method_2<float>("fxATime");
            }
        }

        public GameObject fxEmitterA
        {
            get
            {
                return base.method_3<GameObject>("fxEmitterA");
            }
        }

        public float FxEmitterAKillTime
        {
            get
            {
                return base.method_2<float>("FxEmitterAKillTime");
            }
        }

        public bool fxEmitterAScale
        {
            get
            {
                return base.method_2<bool>("fxEmitterAScale");
            }
        }

        public float FxEmitterATimer
        {
            get
            {
                return base.method_2<float>("FxEmitterATimer");
            }
        }

        public float FxEmitterAWaitTime
        {
            get
            {
                return base.method_2<float>("FxEmitterAWaitTime");
            }
        }

        public GameObject fxEmitterB
        {
            get
            {
                return base.method_3<GameObject>("fxEmitterB");
            }
        }

        public bool fxmovefwd
        {
            get
            {
                return base.method_2<bool>("fxmovefwd");
            }
        }

        public bool FxStartAnim
        {
            get
            {
                return base.method_2<bool>("FxStartAnim");
            }
        }

        public bool FxStartStop
        {
            get
            {
                return base.method_2<bool>("FxStartStop");
            }
        }

        public GameObject hlBase
        {
            get
            {
                return base.method_3<GameObject>("hlBase");
            }
        }

        public GameObject hlEdge
        {
            get
            {
                return base.method_3<GameObject>("hlEdge");
            }
        }

        public GameObject inplayObj
        {
            get
            {
                return base.method_3<GameObject>("inplayObj");
            }
        }

        public bool powerchange
        {
            get
            {
                return base.method_2<bool>("powerchange");
            }
        }

        public GameObject rays
        {
            get
            {
                return base.method_3<GameObject>("rays");
            }
        }

        public bool rayschange
        {
            get
            {
                return base.method_2<bool>("rayschange");
            }
        }

        public bool raysdone
        {
            get
            {
                return base.method_2<bool>("raysdone");
            }
        }

        public float RayTime
        {
            get
            {
                return base.method_2<float>("RayTime");
            }
        }

        public int stage
        {
            get
            {
                return base.method_2<int>("stage");
            }
        }

        public bool turnon
        {
            get
            {
                return base.method_2<bool>("turnon");
            }
        }
    }
}

