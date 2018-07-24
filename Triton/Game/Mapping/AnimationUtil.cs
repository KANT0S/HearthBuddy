namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AnimationUtil")]
    public class AnimationUtil : MonoBehaviour
    {
        public AnimationUtil(IntPtr address) : this(address, "AnimationUtil")
        {
        }

        public AnimationUtil(IntPtr address, string className) : base(address, className)
        {
        }

        public static void DelayedActivate(GameObject go, float time, bool activate)
        {
            object[] objArray1 = new object[] { go, time, activate };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AnimationUtil", "DelayedActivate", objArray1);
        }

        public static void DriftObject(GameObject go, Vector3 driftOffset)
        {
            object[] objArray1 = new object[] { go, driftOffset };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AnimationUtil", "DriftObject", objArray1);
        }

        public static void FloatyPosition(GameObject go, float radius, float loopTime)
        {
            object[] objArray1 = new object[] { go, radius, loopTime };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "AnimationUtil", "FloatyPosition", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FloatyPosition(GameObject go, Vector3 startPos, float localRadius, float loopTime)
        {
            object[] objArray1 = new object[] { go, startPos, localRadius, loopTime };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "AnimationUtil", "FloatyPosition", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void GrowThenDrift(GameObject go, Vector3 origin, Vector3 driftOffset)
        {
            object[] objArray1 = new object[] { go, origin, driftOffset };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AnimationUtil", "GrowThenDrift", objArray1);
        }

        public static void ScaleFade(GameObject go, Vector3 scale)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { go, scale };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "AnimationUtil", "ScaleFade", enumArray1, objArray1);
        }

        public static void ScaleFade(GameObject go, Vector3 scale, string callbackName)
        {
            object[] objArray1 = new object[] { go, scale, callbackName };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "AnimationUtil", "ScaleFade", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShowPunch(GameObject go, Vector3 scale, string callbackName, GameObject callbackGO, object callbackData)
        {
            object[] objArray1 = new object[] { go, scale, callbackName, callbackGO, callbackData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AnimationUtil", "ShowPunch", objArray1);
        }

        [Attribute38("AnimationUtil.PunchData")]
        public class PunchData : MonoClass
        {
            public PunchData(IntPtr address) : this(address, "PunchData")
            {
            }

            public PunchData(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }

            public GameObject m_callbackGameObject
            {
                get
                {
                    return base.method_3<GameObject>("m_callbackGameObject");
                }
            }

            public string m_callbackName
            {
                get
                {
                    return base.method_4("m_callbackName");
                }
            }

            public GameObject m_gameObject
            {
                get
                {
                    return base.method_3<GameObject>("m_gameObject");
                }
            }

            public Vector3 m_scale
            {
                get
                {
                    return base.method_2<Vector3>("m_scale");
                }
            }
        }
    }
}

