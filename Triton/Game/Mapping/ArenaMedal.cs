namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ArenaMedal")]
    public class ArenaMedal : PegUIElement
    {
        public ArenaMedal(IntPtr address) : this(address, "ArenaMedal")
        {
        }

        public ArenaMedal(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string GetMedalName()
        {
            return base.method_13("GetMedalName", Array.Empty<object>());
        }

        public string GetNextMedalName()
        {
            return base.method_13("GetNextMedalName", Array.Empty<object>());
        }

        public void MedalOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MedalOut", objArray1);
        }

        public void MedalOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MedalOver", objArray1);
        }

        public void OnTextureLoaded(string assetName, object asset, object callbackData)
        {
            object[] objArray1 = new object[] { assetName, asset, callbackData };
            base.method_8("OnTextureLoaded", objArray1);
        }

        public void SetMedal(int medal)
        {
            object[] objArray1 = new object[] { medal };
            base.method_8("SetMedal", objArray1);
        }

        public int m_medal
        {
            get
            {
                return base.method_2<int>("m_medal");
            }
        }

        public GameObject m_rankMedal
        {
            get
            {
                return base.method_3<GameObject>("m_rankMedal");
            }
        }

        public static string MEDAL_NAME_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ArenaMedal", "MEDAL_NAME_PREFIX");
            }
        }

        public static string MEDAL_TEXTURE_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ArenaMedal", "MEDAL_TEXTURE_PREFIX");
            }
        }
    }
}

