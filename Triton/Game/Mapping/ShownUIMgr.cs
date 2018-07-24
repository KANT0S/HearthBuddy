namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ShownUIMgr")]
    public class ShownUIMgr : MonoBehaviour
    {
        public ShownUIMgr(IntPtr address) : this(address, "ShownUIMgr")
        {
        }

        public ShownUIMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearShownUI()
        {
            base.method_8("ClearShownUI", Array.Empty<object>());
        }

        public static ShownUIMgr Get()
        {
            return MonoClass.smethod_15<ShownUIMgr>(TritonHs.MainAssemblyPath, "", "ShownUIMgr", "Get", Array.Empty<object>());
        }

        public UI_WINDOW GetShownUI()
        {
            return base.method_11<UI_WINDOW>("GetShownUI", Array.Empty<object>());
        }

        public bool HasShownUI()
        {
            return base.method_11<bool>("HasShownUI", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void SetShownUI(UI_WINDOW uiWindow)
        {
            object[] objArray1 = new object[] { uiWindow };
            base.method_8("SetShownUI", objArray1);
        }

        public UI_WINDOW m_shownUI
        {
            get
            {
                return base.method_2<UI_WINDOW>("m_shownUI");
            }
        }

        public enum UI_WINDOW
        {
            NONE,
            GENERAL_STORE,
            QUEST_LOG
        }
    }
}

