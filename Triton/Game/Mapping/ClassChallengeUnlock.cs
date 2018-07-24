namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ClassChallengeUnlock")]
    public class ClassChallengeUnlock : Reward
    {
        public ClassChallengeUnlock(IntPtr address) : this(address, "ClassChallengeUnlock")
        {
        }

        public ClassChallengeUnlock(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DestroyClassChallengeUnlock()
        {
            base.method_8("DestroyClassChallengeUnlock", Array.Empty<object>());
        }

        public void HideReward()
        {
            base.method_8("HideReward", Array.Empty<object>());
        }

        public void InitData()
        {
            base.method_8("InitData", Array.Empty<object>());
        }

        public void OnClicked(Reward reward, object userData)
        {
            object[] objArray1 = new object[] { reward, userData };
            base.method_8("OnClicked", objArray1);
        }

        public void OnDataSet(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnDataSet", objArray1);
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public string m_appearSound
        {
            get
            {
                return base.method_4("m_appearSound");
            }
        }

        public UIBObjectSpacing m_classFrameContainer
        {
            get
            {
                return base.method_3<UIBObjectSpacing>("m_classFrameContainer");
            }
        }

        public List<GameObject> m_classFrames
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_classFrames");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_headerText
        {
            get
            {
                return base.method_3<UberText>("m_headerText");
            }
        }
    }
}

