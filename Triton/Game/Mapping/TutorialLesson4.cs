namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialLesson4")]
    public class TutorialLesson4 : MonoBehaviour
    {
        public TutorialLesson4(IntPtr address) : this(address, "TutorialLesson4")
        {
        }

        public TutorialLesson4(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public UberText m_taunt
        {
            get
            {
                return base.method_3<UberText>("m_taunt");
            }
        }

        public UberText m_tauntDescription
        {
            get
            {
                return base.method_3<UberText>("m_tauntDescription");
            }
        }

        public UberText m_tauntDescriptionTitle
        {
            get
            {
                return base.method_3<UberText>("m_tauntDescriptionTitle");
            }
        }
    }
}

