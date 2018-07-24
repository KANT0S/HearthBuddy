namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialLesson2")]
    public class TutorialLesson2 : MonoBehaviour
    {
        public TutorialLesson2(IntPtr address) : this(address, "TutorialLesson2")
        {
        }

        public TutorialLesson2(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText m_cost
        {
            get
            {
                return base.method_3<UberText>("m_cost");
            }
        }

        public UberText m_yourMana
        {
            get
            {
                return base.method_3<UberText>("m_yourMana");
            }
        }
    }
}

