namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DisconnectMgr")]
    public class DisconnectMgr : MonoBehaviour
    {
        public DisconnectMgr(IntPtr address) : this(address, "DisconnectMgr")
        {
        }

        public DisconnectMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisconnectFromGameplay()
        {
            base.method_8("DisconnectFromGameplay", Array.Empty<object>());
        }

        public static DisconnectMgr Get()
        {
            return MonoClass.smethod_15<DisconnectMgr>(TritonHs.MainAssemblyPath, "", "DisconnectMgr", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnGameplayDialogProcessed(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnGameplayDialogProcessed", objArray1);
        }

        public void OnGameplayDialogResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnGameplayDialogResponse", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void ShowGameplayDialog(SceneMgr.Mode nextMode)
        {
            object[] objArray1 = new object[] { nextMode };
            base.method_8("ShowGameplayDialog", objArray1);
        }

        public void UpdateGameplayDialog()
        {
            base.method_8("UpdateGameplayDialog", Array.Empty<object>());
        }

        public AlertPopup m_dialog
        {
            get
            {
                return base.method_3<AlertPopup>("m_dialog");
            }
        }
    }
}

