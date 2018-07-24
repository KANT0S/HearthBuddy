namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialLesson3")]
    public class TutorialLesson3 : MonoBehaviour
    {
        public TutorialLesson3(IntPtr address) : this(address, "TutorialLesson3")
        {
        }

        public TutorialLesson3(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText m_attacker
        {
            get
            {
                return base.method_3<UberText>("m_attacker");
            }
        }

        public UberText m_defender
        {
            get
            {
                return base.method_3<UberText>("m_defender");
            }
        }
    }
}

