namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StrippingUtil")]
    public class StrippingUtil : MonoBehaviour
    {
        public StrippingUtil(IntPtr address) : this(address, "StrippingUtil")
        {
        }

        public StrippingUtil(IntPtr address, string className) : base(address, className)
        {
        }

        public void SeedMonotouchAheadOfTimeCompile()
        {
            base.method_8("SeedMonotouchAheadOfTimeCompile", Array.Empty<object>());
        }

        public Behaviour dummy_11
        {
            get
            {
                return base.method_3<Behaviour>("dummy_11");
            }
        }

        public Camera dummy_19
        {
            get
            {
                return base.method_3<Camera>("dummy_19");
            }
        }

        public MeshRenderer dummy_2
        {
            get
            {
                return base.method_3<MeshRenderer>("dummy_2");
            }
        }

        public Material dummy_20
        {
            get
            {
                return base.method_3<Material>("dummy_20");
            }
        }

        public MeshRenderer dummy_21
        {
            get
            {
                return base.method_3<MeshRenderer>("dummy_21");
            }
        }

        public Renderer dummy_22
        {
            get
            {
                return base.method_3<Renderer>("dummy_22");
            }
        }

        public Texture dummy_24
        {
            get
            {
                return base.method_3<Texture>("dummy_24");
            }
        }

        public Mesh dummy_30
        {
            get
            {
                return base.method_3<Mesh>("dummy_30");
            }
        }

        public Collider dummy_38
        {
            get
            {
                return base.method_3<Collider>("dummy_38");
            }
        }

        public MeshCollider dummy_41
        {
            get
            {
                return base.method_3<MeshCollider>("dummy_41");
            }
        }

        public BoxCollider dummy_42
        {
            get
            {
                return base.method_3<BoxCollider>("dummy_42");
            }
        }

        public GameObject dummy_5
        {
            get
            {
                return base.method_3<GameObject>("dummy_5");
            }
        }

        public Component dummy_6
        {
            get
            {
                return base.method_3<Component>("dummy_6");
            }
        }

        public Transform dummy_8
        {
            get
            {
                return base.method_3<Transform>("dummy_8");
            }
        }
    }
}

