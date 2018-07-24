namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayerPortrait")]
    public class PlayerPortrait : MonoBehaviour
    {
        public PlayerPortrait(IntPtr address) : this(address, "PlayerPortrait")
        {
        }

        public PlayerPortrait(IntPtr address, string className) : base(address, className)
        {
        }

        public bool IsIconLoading()
        {
            return base.method_11<bool>("IsIconLoading", Array.Empty<object>());
        }

        public bool IsIconReady()
        {
            return base.method_11<bool>("IsIconReady", Array.Empty<object>());
        }

        public void OnTextureLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("OnTextureLoaded", objArray1);
        }

        public void UpdateIcon()
        {
            base.method_8("UpdateIcon", Array.Empty<object>());
        }

        public string m_currentTextureName
        {
            get
            {
                return base.method_4("m_currentTextureName");
            }
        }

        public string m_loadingTextureName
        {
            get
            {
                return base.method_4("m_loadingTextureName");
            }
        }
    }
}

