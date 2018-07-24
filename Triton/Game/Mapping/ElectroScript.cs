namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ElectroScript")]
    public class ElectroScript : MonoBehaviour
    {
        public ElectroScript(IntPtr address) : this(address, "ElectroScript")
        {
        }

        public ElectroScript(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateArc()
        {
            base.method_8("AnimateArc", Array.Empty<object>());
        }

        public void DrawArc()
        {
            base.method_8("DrawArc", Array.Empty<object>());
        }

        public void RayCast()
        {
            base.method_8("RayCast", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Vector3 deltaV1
        {
            get
            {
                return base.method_2<Vector3>("deltaV1");
            }
        }

        public Vector3 deltaV2
        {
            get
            {
                return base.method_2<Vector3>("deltaV2");
            }
        }

        public Dynamics dynamics
        {
            get
            {
                return base.method_3<Dynamics>("dynamics");
            }
        }

        public float lastUpdate
        {
            get
            {
                return base.method_2<float>("lastUpdate");
            }
        }

        public LineSettings lines
        {
            get
            {
                return base.method_3<LineSettings>("lines");
            }
        }

        public int numVertices
        {
            get
            {
                return base.method_2<int>("numVertices");
            }
        }

        public Prefabs prefabs
        {
            get
            {
                return base.method_3<Prefabs>("prefabs");
            }
        }

        public float srcDstDist
        {
            get
            {
                return base.method_2<float>("srcDstDist");
            }
        }

        public float srcTrgDist
        {
            get
            {
                return base.method_2<float>("srcTrgDist");
            }
        }

        public TextureSettings tex
        {
            get
            {
                return base.method_3<TextureSettings>("tex");
            }
        }

        public Timers timers
        {
            get
            {
                return base.method_3<Timers>("timers");
            }
        }

        [Attribute38("ElectroScript.Dynamics")]
        public class Dynamics : MonoClass
        {
            public Dynamics(IntPtr address) : this(address, "Dynamics")
            {
            }

            public Dynamics(IntPtr address, string className) : base(address, className)
            {
            }

            public float chanceToArc
            {
                get
                {
                    return base.method_2<float>("chanceToArc");
                }
            }
        }

        [Attribute38("ElectroScript.LineSettings")]
        public class LineSettings : MonoClass
        {
            public LineSettings(IntPtr address) : this(address, "LineSettings")
            {
            }

            public LineSettings(IntPtr address, string className) : base(address, className)
            {
            }

            public float keyVertexDist
            {
                get
                {
                    return base.method_2<float>("keyVertexDist");
                }
            }

            public float keyVertexRange
            {
                get
                {
                    return base.method_2<float>("keyVertexRange");
                }
            }

            public float maxBranchLength
            {
                get
                {
                    return base.method_2<float>("maxBranchLength");
                }
            }

            public float minBranchLength
            {
                get
                {
                    return base.method_2<float>("minBranchLength");
                }
            }

            public int numInterpoles
            {
                get
                {
                    return base.method_2<int>("numInterpoles");
                }
            }
        }

        [Attribute38("ElectroScript.Prefabs")]
        public class Prefabs : MonoClass
        {
            public Prefabs(IntPtr address) : this(address, "Prefabs")
            {
            }

            public Prefabs(IntPtr address, string className) : base(address, className)
            {
            }

            public Transform destination
            {
                get
                {
                    return base.method_3<Transform>("destination");
                }
            }

            public Transform source
            {
                get
                {
                    return base.method_3<Transform>("source");
                }
            }

            public Transform sparks
            {
                get
                {
                    return base.method_3<Transform>("sparks");
                }
            }

            public Transform target
            {
                get
                {
                    return base.method_3<Transform>("target");
                }
            }
        }

        [Attribute38("ElectroScript.TextureSettings")]
        public class TextureSettings : MonoClass
        {
            public TextureSettings(IntPtr address) : this(address, "TextureSettings")
            {
            }

            public TextureSettings(IntPtr address, string className) : base(address, className)
            {
            }

            public float animateSpeed
            {
                get
                {
                    return base.method_2<float>("animateSpeed");
                }
            }

            public float offsetY
            {
                get
                {
                    return base.method_2<float>("offsetY");
                }
            }

            public float scaleX
            {
                get
                {
                    return base.method_2<float>("scaleX");
                }
            }

            public float scaleY
            {
                get
                {
                    return base.method_2<float>("scaleY");
                }
            }
        }

        [Attribute38("ElectroScript.Timers")]
        public class Timers : MonoClass
        {
            public Timers(IntPtr address) : this(address, "Timers")
            {
            }

            public Timers(IntPtr address, string className) : base(address, className)
            {
            }

            public float branchLife
            {
                get
                {
                    return base.method_2<float>("branchLife");
                }
            }

            public float timeToPowerUp
            {
                get
                {
                    return base.method_2<float>("timeToPowerUp");
                }
            }

            public float timeToUpdate
            {
                get
                {
                    return base.method_2<float>("timeToUpdate");
                }
            }
        }
    }
}

