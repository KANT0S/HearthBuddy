namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayButton")]
    public class PlayButton : PegUIElement
    {
        public PlayButton(IntPtr address) : this(address, "PlayButton")
        {
        }

        public PlayButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChangeHighlightState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeHighlightState", objArray1);
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void Enable()
        {
            base.method_8("Enable", Array.Empty<object>());
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

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void SetText(string newText)
        {
            object[] objArray1 = new object[] { newText };
            base.method_8("SetText", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool m_isStarted
        {
            get
            {
                return base.method_2<bool>("m_isStarted");
            }
        }

        public UberText m_newPlayButtonText
        {
            get
            {
                return base.method_3<UberText>("m_newPlayButtonText");
            }
        }

        public HighlightState m_playButtonHighlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_playButtonHighlightState");
            }
        }

        public Vector3 m_pressMovement
        {
            get
            {
                return base.method_2<Vector3>("m_pressMovement");
            }
        }
    }
}

