namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TurnStartIndicator")]
    public class TurnStartIndicator : MonoBehaviour
    {
        public TurnStartIndicator(IntPtr address) : this(address, "TurnStartIndicator")
        {
        }

        public TurnStartIndicator(IntPtr address, string className) : base(address, className)
        {
        }

        public void DeactivateTurnStartInstance()
        {
            base.method_8("DeactivateTurnStartInstance", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideTurnStartInstance()
        {
            base.method_8("HideTurnStartInstance", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void PunchTurnStartInstance()
        {
            base.method_8("PunchTurnStartInstance", Array.Empty<object>());
        }

        public void SetReminderText(string newText)
        {
            object[] objArray1 = new object[] { newText };
            base.method_8("SetReminderText", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static float AFTER_PUNCH_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TurnStartIndicator", "AFTER_PUNCH_SCALE_VAL");
            }
        }

        public static float END_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TurnStartIndicator", "END_SCALE_VAL");
            }
        }

        public GameObject m_explosionFX
        {
            get
            {
                return base.method_3<GameObject>("m_explosionFX");
            }
        }

        public GameObject m_godRays
        {
            get
            {
                return base.method_3<GameObject>("m_godRays");
            }
        }

        public UberText m_labelBottom
        {
            get
            {
                return base.method_3<UberText>("m_labelBottom");
            }
        }

        public UberText m_labelMiddle
        {
            get
            {
                return base.method_3<UberText>("m_labelMiddle");
            }
        }

        public UberText m_labelTop
        {
            get
            {
                return base.method_3<UberText>("m_labelTop");
            }
        }

        public UberText m_reminderText
        {
            get
            {
                return base.method_3<UberText>("m_reminderText");
            }
        }

        public static float START_SCALE_VAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "TurnStartIndicator", "START_SCALE_VAL");
            }
        }
    }
}

