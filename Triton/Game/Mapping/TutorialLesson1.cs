namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialLesson1")]
    public class TutorialLesson1 : MonoBehaviour
    {
        public TutorialLesson1(IntPtr address) : this(address, "TutorialLesson1")
        {
        }

        public TutorialLesson1(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText m_attack
        {
            get
            {
                return base.method_3<UberText>("m_attack");
            }
        }

        public UberText m_health
        {
            get
            {
                return base.method_3<UberText>("m_health");
            }
        }

        public UberText m_minion
        {
            get
            {
                return base.method_3<UberText>("m_minion");
            }
        }
    }
}

