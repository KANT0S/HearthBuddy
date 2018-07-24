namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("RandomSpawnTimed")]
    public class RandomSpawnTimed : MonoBehaviour
    {
        public RandomSpawnTimed(IntPtr address) : this(address, "RandomSpawnTimed")
        {
        }

        public RandomSpawnTimed(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float killX
        {
            get
            {
                return base.method_2<float>("killX");
            }
        }

        public float killZ
        {
            get
            {
                return base.method_2<float>("killZ");
            }
        }

        public List<GameObject> listOfObjs
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("listOfObjs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float maxWaitTime
        {
            get
            {
                return base.method_2<float>("maxWaitTime");
            }
        }

        public float minWaitTime
        {
            get
            {
                return base.method_2<float>("minWaitTime");
            }
        }

        public GameObject objPrefab
        {
            get
            {
                return base.method_3<GameObject>("objPrefab");
            }
        }
    }
}

