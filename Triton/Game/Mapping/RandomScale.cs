namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RandomScale")]
    public class RandomScale : MonoBehaviour
    {
        public RandomScale(IntPtr address) : this(address, "RandomScale")
        {
        }

        public RandomScale(IntPtr address, string className) : base(address, className)
        {
        }

        public void PlayRandomScale()
        {
            base.method_8("PlayRandomScale", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float maxRange
        {
            get
            {
                return base.method_2<float>("maxRange");
            }
        }

        public float minRange
        {
            get
            {
                return base.method_2<float>("minRange");
            }
        }

        public GameObject tester
        {
            get
            {
                return base.method_3<GameObject>("tester");
            }
        }
    }
}

