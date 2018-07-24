namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroSkinHeroPower")]
    public class HeroSkinHeroPower : MonoBehaviour
    {
        public HeroSkinHeroPower(IntPtr address) : this(address, "HeroSkinHeroPower")
        {
        }

        public HeroSkinHeroPower(IntPtr address, string className) : base(address, className)
        {
        }

        public Texture GetBackTexture()
        {
            return base.method_14<Texture>("GetBackTexture", Array.Empty<object>());
        }

        public Texture GetFrontTexture()
        {
            return base.method_14<Texture>("GetFrontTexture", Array.Empty<object>());
        }

        public void OnBackTextureLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("OnBackTextureLoaded", objArray1);
        }

        public void OnFrontTextureLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("OnFrontTextureLoaded", objArray1);
        }

        public void RestoreOriginalTextures()
        {
            base.method_8("RestoreOriginalTextures", Array.Empty<object>());
        }

        public void SetBackTexture(Texture tex)
        {
            object[] objArray1 = new object[] { tex };
            base.method_8("SetBackTexture", objArray1);
        }

        public void SetBackTextureFromPath(string path)
        {
            object[] objArray1 = new object[] { path };
            base.method_8("SetBackTextureFromPath", objArray1);
        }

        public void SetFrontTexture(Texture tex)
        {
            object[] objArray1 = new object[] { tex };
            base.method_8("SetFrontTexture", objArray1);
        }

        public void SetFrontTextureFromPath(string path)
        {
            object[] objArray1 = new object[] { path };
            base.method_8("SetFrontTextureFromPath", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public Texture m_OriginalBackTexture
        {
            get
            {
                return base.method_3<Texture>("m_OriginalBackTexture");
            }
        }

        public Texture m_OriginalFrontTexture
        {
            get
            {
                return base.method_3<Texture>("m_OriginalFrontTexture");
            }
        }
    }
}

