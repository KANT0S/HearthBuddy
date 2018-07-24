namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LocalizedTexture")]
    public class LocalizedTexture : MonoBehaviour
    {
        public LocalizedTexture(IntPtr address) : this(address, "LocalizedTexture")
        {
        }

        public LocalizedTexture(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnTextureLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("OnTextureLoaded", objArray1);
        }

        public string m_textureName
        {
            get
            {
                return base.method_4("m_textureName");
            }
        }
    }
}

