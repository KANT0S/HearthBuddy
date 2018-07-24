namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialLesson5")]
    public class TutorialLesson5 : MonoBehaviour
    {
        public TutorialLesson5(IntPtr address) : this(address, "TutorialLesson5")
        {
        }

        public TutorialLesson5(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText m_heroPower
        {
            get
            {
                return base.method_3<UberText>("m_heroPower");
            }
        }

        public UberText m_used
        {
            get
            {
                return base.method_3<UberText>("m_used");
            }
        }

        public UberText m_yourTurn
        {
            get
            {
                return base.method_3<UberText>("m_yourTurn");
            }
        }
    }
}

