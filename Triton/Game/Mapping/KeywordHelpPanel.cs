namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("KeywordHelpPanel")]
    public class KeywordHelpPanel : MonoBehaviour
    {
        public KeywordHelpPanel(IntPtr address) : this(address, "KeywordHelpPanel")
        {
        }

        public KeywordHelpPanel(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float GetHeight()
        {
            return base.method_11<float>("GetHeight", Array.Empty<object>());
        }

        public float GetWidth()
        {
            return base.method_11<float>("GetWidth", Array.Empty<object>());
        }

        public void Initialize(string keywordName, string keywordText)
        {
            object[] objArray1 = new object[] { keywordName, keywordText };
            base.method_8("Initialize", objArray1);
        }

        public bool IsTextRendered()
        {
            return base.method_11<bool>("IsTextRendered", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void SetBodyText(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetBodyText", objArray1);
        }

        public void SetName(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetName", objArray1);
        }

        public void SetScale(float newScale)
        {
            object[] objArray1 = new object[] { newScale };
            base.method_8("SetScale", objArray1);
        }

        public static float DECK_HELPER_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanel", "DECK_HELPER_SCALE");
            }
        }

        public static float GAMEPLAY_HERO_POWER_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanel", "GAMEPLAY_HERO_POWER_SCALE");
            }
        }

        public NewThreeSliceElement m_background
        {
            get
            {
                return base.method_3<NewThreeSliceElement>("m_background");
            }
        }

        public UberText m_body
        {
            get
            {
                return base.method_3<UberText>("m_body");
            }
        }

        public float m_initialBackgroundHeight
        {
            get
            {
                return base.method_2<float>("m_initialBackgroundHeight");
            }
        }

        public Vector3 m_initialBackgroundScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialBackgroundScale");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }

        public static float PACK_OPENING_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanel", "PACK_OPENING_SCALE");
            }
        }

        public float scaleToUse
        {
            get
            {
                return base.method_2<float>("scaleToUse");
            }
        }

        public static float UNOPENED_PACK_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "KeywordHelpPanel", "UNOPENED_PACK_SCALE");
            }
        }
    }
}

