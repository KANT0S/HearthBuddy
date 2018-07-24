namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureClassChallengeButton")]
    public class AdventureClassChallengeButton : PegUIElement
    {
        public AdventureClassChallengeButton(IntPtr address) : this(address, "AdventureClassChallengeButton")
        {
        }

        public AdventureClassChallengeButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Depress()
        {
            base.method_8("Depress", Array.Empty<object>());
        }

        public void Deselect()
        {
            base.method_8("Deselect", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void Raise(float time)
        {
            object[] objArray1 = new object[] { time };
            base.method_8("Raise", objArray1);
        }

        public void Select(bool playSound)
        {
            object[] objArray1 = new object[] { playSound };
            base.method_8("Select", objArray1);
        }

        public void SetPortraitMaterial(Material portraitMat)
        {
            object[] objArray1 = new object[] { portraitMat };
            base.method_8("SetPortraitMaterial", objArray1);
        }

        public GameObject m_Checkmark
        {
            get
            {
                return base.method_3<GameObject>("m_Checkmark");
            }
        }

        public GameObject m_Chest
        {
            get
            {
                return base.method_3<GameObject>("m_Chest");
            }
        }

        public Transform m_DownBone
        {
            get
            {
                return base.method_3<Transform>("m_DownBone");
            }
        }

        public HighlightState m_Highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_Highlight");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }

        public int m_ScenarioID
        {
            get
            {
                return base.method_2<int>("m_ScenarioID");
            }
        }

        public UberText m_Text
        {
            get
            {
                return base.method_3<UberText>("m_Text");
            }
        }

        public Transform m_UpBone
        {
            get
            {
                return base.method_3<Transform>("m_UpBone");
            }
        }
    }
}

