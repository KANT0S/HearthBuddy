namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EditorFacebookAccessToken")]
    public class EditorFacebookAccessToken : MonoBehaviour
    {
        public EditorFacebookAccessToken(IntPtr address) : this(address, "EditorFacebookAccessToken")
        {
        }

        public EditorFacebookAccessToken(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void OnGUIDialog(int windowId)
        {
            object[] objArray1 = new object[] { windowId };
            base.method_8("OnGUIDialog", objArray1);
        }

        public string accessToken
        {
            get
            {
                return base.method_4("accessToken");
            }
        }

        public bool isLoggingIn
        {
            get
            {
                return base.method_2<bool>("isLoggingIn");
            }
        }

        public float windowHeight
        {
            get
            {
                return base.method_2<float>("windowHeight");
            }
        }

        public static float windowWidth
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EditorFacebookAccessToken", "windowWidth");
            }
        }
    }
}

