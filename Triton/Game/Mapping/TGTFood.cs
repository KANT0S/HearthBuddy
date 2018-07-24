namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("TGTFood")]
    public class TGTFood : MonoBehaviour
    {
        public TGTFood(IntPtr address) : this(address, "TGTFood")
        {
        }

        public TGTFood(IntPtr address, string className) : base(address, className)
        {
        }

        public void BellAnimation()
        {
            base.method_8("BellAnimation", Array.Empty<object>());
        }

        public void HandleHits()
        {
            base.method_8("HandleHits", Array.Empty<object>());
        }

        public bool IsOver(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsOver", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public FoodItem m_CurrentFoodItem
        {
            get
            {
                return base.method_3<FoodItem>("m_CurrentFoodItem");
            }
        }

        public FoodItem m_Drink
        {
            get
            {
                return base.method_3<FoodItem>("m_Drink");
            }
        }

        public List<FoodItem> m_Food
        {
            get
            {
                Class267<FoodItem> class2 = base.method_3<Class267<FoodItem>>("m_Food");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_isAnimating
        {
            get
            {
                return base.method_2<bool>("m_isAnimating");
            }
        }

        public int m_lastFoodIdx
        {
            get
            {
                return base.method_2<int>("m_lastFoodIdx");
            }
        }

        public float m_NewFoodDelay
        {
            get
            {
                return base.method_2<float>("m_NewFoodDelay");
            }
        }

        public bool m_Phone
        {
            get
            {
                return base.method_2<bool>("m_Phone");
            }
        }

        public float m_phoneNextCheckTime
        {
            get
            {
                return base.method_2<float>("m_phoneNextCheckTime");
            }
        }

        public int m_StartingFoodIndex
        {
            get
            {
                return base.method_2<int>("m_StartingFoodIndex");
            }
        }

        public GameObject m_Triangle
        {
            get
            {
                return base.method_3<GameObject>("m_Triangle");
            }
        }

        public string m_TriangleSoundPrefab
        {
            get
            {
                return base.method_4("m_TriangleSoundPrefab");
            }
        }

        [Attribute38("TGTFood.FoodItem")]
        public class FoodItem : MonoClass
        {
            public FoodItem(IntPtr address) : this(address, "FoodItem")
            {
            }

            public FoodItem(IntPtr address, string className) : base(address, className)
            {
            }
        }
    }
}

