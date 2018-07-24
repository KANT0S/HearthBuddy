namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ZonePlay")]
    public class ZonePlay : Zone
    {
        public ZonePlay(IntPtr address) : this(address, "ZonePlay")
        {
        }

        public ZonePlay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanAcceptTags(int controllerId, TAG_ZONE zoneTag, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { controllerId, zoneTag, cardType };
            return base.method_11<bool>("CanAcceptTags", objArray1);
        }

        public bool CanAnimateCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("CanAnimateCard", objArray1);
        }

        public Vector3 GetCardPosition(int index)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { index };
            return base.method_10<Vector3>("GetCardPosition", enumArray1, objArray1);
        }

        public Vector3 GetCardPosition(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<Vector3>("GetCardPosition", enumArray1, objArray1);
        }

        public int GetSlotMousedOver()
        {
            return base.method_11<int>("GetSlotMousedOver", Array.Empty<object>());
        }

        public float GetSlotWidth()
        {
            return base.method_11<float>("GetSlotWidth", Array.Empty<object>());
        }

        public float GetTransitionTime()
        {
            return base.method_11<float>("GetTransitionTime", Array.Empty<object>());
        }

        public void ResetTransitionTime()
        {
            base.method_8("ResetTransitionTime", Array.Empty<object>());
        }

        public void SetTransitionTime(float transitionTime)
        {
            object[] objArray1 = new object[] { transitionTime };
            base.method_8("SetTransitionTime", objArray1);
        }

        public void SortWithSpotForHeldCard(int slot)
        {
            object[] objArray1 = new object[] { slot };
            base.method_8("SortWithSpotForHeldCard", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public static float DEFAULT_TRANSITION_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZonePlay", "DEFAULT_TRANSITION_TIME");
            }
        }

        public int m_MaxSlots
        {
            get
            {
                return base.method_2<int>("m_MaxSlots");
            }
        }

        public int m_slotMousedOver
        {
            get
            {
                return base.method_2<int>("m_slotMousedOver");
            }
        }

        public float m_slotWidth
        {
            get
            {
                return base.method_2<float>("m_slotWidth");
            }
        }

        public float m_transitionTime
        {
            get
            {
                return base.method_2<float>("m_transitionTime");
            }
        }

        public static Vector3 PHONE_ACTOR_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "ZonePlay", "PHONE_ACTOR_SCALE");
            }
        }

        public List<float> PHONE_WIDTH_MODIFIERS
        {
            get
            {
                Class246<float> class2 = base.method_3<Class246<float>>("PHONE_WIDTH_MODIFIERS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

