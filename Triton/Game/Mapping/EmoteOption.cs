namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("EmoteOption")]
    public class EmoteOption : MonoBehaviour
    {
        public EmoteOption(IntPtr address) : this(address, "EmoteOption")
        {
        }

        public EmoteOption(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void DoClick()
        {
            base.method_8("DoClick", Array.Empty<object>());
        }

        public void Enable()
        {
            base.method_8("Enable", Array.Empty<object>());
        }

        public void FinishDisable()
        {
            base.method_8("FinishDisable", Array.Empty<object>());
        }

        public void HandleMouseOut()
        {
            base.method_8("HandleMouseOut", Array.Empty<object>());
        }

        public void HandleMouseOver()
        {
            base.method_8("HandleMouseOver", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public MeshRenderer backplate
        {
            get
            {
                return base.method_3<MeshRenderer>("backplate");
            }
        }

        public UberText displayText
        {
            get
            {
                return base.method_3<UberText>("displayText");
            }
        }

        public EmoteType emoteType
        {
            get
            {
                return base.method_2<EmoteType>("emoteType");
            }
        }

        public Vector3 startingScale
        {
            get
            {
                return base.method_2<Vector3>("startingScale");
            }
        }

        public bool textIsGrey
        {
            get
            {
                return base.method_2<bool>("textIsGrey");
            }
        }

        public string textToDisplay
        {
            get
            {
                return base.method_4("textToDisplay");
            }
        }
    }
}

