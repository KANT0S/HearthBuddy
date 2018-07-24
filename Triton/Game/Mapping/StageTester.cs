namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StageTester")]
    public class StageTester : MonoBehaviour
    {
        public StageTester(IntPtr address) : this(address, "StageTester")
        {
        }

        public StageTester(IntPtr address, string className) : base(address, className)
        {
        }

        public void Highlighted()
        {
            base.method_8("Highlighted", Array.Empty<object>());
        }

        public void ManaUsed()
        {
            base.method_8("ManaUsed", Array.Empty<object>());
        }

        public void OnMouseDown()
        {
            base.method_8("OnMouseDown", Array.Empty<object>());
        }

        public void PlayEmitterB()
        {
            base.method_8("PlayEmitterB", Array.Empty<object>());
        }

        public void Released()
        {
            base.method_8("Released", Array.Empty<object>());
        }

        public void Selected()
        {
            base.method_8("Selected", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
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

        public GameObject fxEmitterA
        {
            get
            {
                return base.method_3<GameObject>("fxEmitterA");
            }
        }

        public GameObject fxEmitterB
        {
            get
            {
                return base.method_3<GameObject>("fxEmitterB");
            }
        }

        public GameObject highlightBase
        {
            get
            {
                return base.method_3<GameObject>("highlightBase");
            }
        }

        public GameObject highlightEdge
        {
            get
            {
                return base.method_3<GameObject>("highlightEdge");
            }
        }

        public GameObject inplayObj
        {
            get
            {
                return base.method_3<GameObject>("inplayObj");
            }
        }

        public GameObject rays
        {
            get
            {
                return base.method_3<GameObject>("rays");
            }
        }

        public int stage
        {
            get
            {
                return base.method_2<int>("stage");
            }
        }
    }
}

