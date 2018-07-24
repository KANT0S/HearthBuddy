namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TB05_GiftExchange")]
    public class TB05_GiftExchange : MissionEntity
    {
        public TB05_GiftExchange(IntPtr address) : this(address, "TB05_GiftExchange")
        {
        }

        public TB05_GiftExchange(IntPtr address, string className) : base(address, className)
        {
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public float delayTime
        {
            get
            {
                return base.method_2<float>("delayTime");
            }
        }

        public string FirstGiftVO
        {
            get
            {
                return base.method_4("FirstGiftVO");
            }
        }

        public string FirstStolenVO
        {
            get
            {
                return base.method_4("FirstStolenVO");
            }
        }

        public Triton.Game.Mapping.Notification GameStartPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("GameStartPopup");
            }
        }

        public Triton.Game.Mapping.Notification GiftSpawnedPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("GiftSpawnedPopup");
            }
        }

        public Triton.Game.Mapping.Notification GiftStolenPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("GiftStolenPopup");
            }
        }

        public List<string> GiftVOList
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("GiftVOList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string NextStolenVO
        {
            get
            {
                return base.method_4("NextStolenVO");
            }
        }

        public List<string> PissedVOList
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("PissedVOList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 popUpPos
        {
            get
            {
                return base.method_2<Vector3>("popUpPos");
            }
        }

        public string StartVO
        {
            get
            {
                return base.method_4("StartVO");
            }
        }

        public string textID
        {
            get
            {
                return base.method_4("textID");
            }
        }

        public string VOChoice
        {
            get
            {
                return base.method_4("VOChoice");
            }
        }
    }
}

