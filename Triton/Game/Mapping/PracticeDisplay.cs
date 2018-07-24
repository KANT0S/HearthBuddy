namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PracticeDisplay")]
    public class PracticeDisplay : MonoBehaviour
    {
        public PracticeDisplay(IntPtr address) : this(address, "PracticeDisplay")
        {
        }

        public PracticeDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static PracticeDisplay Get()
        {
            return MonoClass.smethod_15<PracticeDisplay>(TritonHs.MainAssemblyPath, "", "PracticeDisplay", "Get", Array.Empty<object>());
        }

        public Vector3 GetPracticePickerHidePosition()
        {
            return base.method_11<Vector3>("GetPracticePickerHidePosition", Array.Empty<object>());
        }

        public Vector3 GetPracticePickerShowPosition()
        {
            return base.method_11<Vector3>("GetPracticePickerShowPosition", Array.Empty<object>());
        }

        public void InitializeTrays()
        {
            base.method_8("InitializeTrays", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnTrayPartLoaded()
        {
            base.method_8("OnTrayPartLoaded", Array.Empty<object>());
        }

        public DeckPickerTrayDisplay m_deckPickerTray
        {
            get
            {
                return base.method_3<DeckPickerTrayDisplay>("m_deckPickerTray");
            }
        }

        public GameObject m_deckPickerTrayContainer
        {
            get
            {
                return base.method_3<GameObject>("m_deckPickerTrayContainer");
            }
        }

        public PracticePickerTrayDisplay m_practicePickerTray
        {
            get
            {
                return base.method_3<PracticePickerTrayDisplay>("m_practicePickerTray");
            }
        }

        public GameObject m_practicePickerTrayContainer
        {
            get
            {
                return base.method_3<GameObject>("m_practicePickerTrayContainer");
            }
        }

        public Vector3 m_practicePickerTrayShowPos
        {
            get
            {
                return base.method_2<Vector3>("m_practicePickerTrayShowPos");
            }
        }
    }
}

