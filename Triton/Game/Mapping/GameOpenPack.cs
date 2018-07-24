namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GameOpenPack")]
    public class GameOpenPack : MonoBehaviour
    {
        public GameOpenPack(IntPtr address) : this(address, "GameOpenPack")
        {
        }

        public GameOpenPack(IntPtr address, string className) : base(address, className)
        {
        }

        public void Begin()
        {
            base.method_8("Begin", Array.Empty<object>());
        }

        public void Finish()
        {
            base.method_8("Finish", Array.Empty<object>());
        }

        public void HandleClick()
        {
            base.method_8("HandleClick", Array.Empty<object>());
        }

        public void NotifyOfFullyLoaded()
        {
            base.method_8("NotifyOfFullyLoaded", Array.Empty<object>());
        }

        public void NotifyOfMouseOff()
        {
            base.method_8("NotifyOfMouseOff", Array.Empty<object>());
        }

        public void NotifyOfMouseOver()
        {
            base.method_8("NotifyOfMouseOver", Array.Empty<object>());
        }

        public void PlayHoggerLine()
        {
            base.method_8("PlayHoggerLine", Array.Empty<object>());
        }

        public void PlayJainaLine()
        {
            base.method_8("PlayJainaLine", Array.Empty<object>());
        }

        public void RaiseBoardLights()
        {
            base.method_8("RaiseBoardLights", Array.Empty<object>());
        }

        public bool clickedOnPack
        {
            get
            {
                return base.method_2<bool>("clickedOnPack");
            }
        }

        public bool fullyLoaded
        {
            get
            {
                return base.method_2<bool>("fullyLoaded");
            }
        }
    }
}

