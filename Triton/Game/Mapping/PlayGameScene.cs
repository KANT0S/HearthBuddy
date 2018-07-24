namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayGameScene")]
    public class PlayGameScene : Scene
    {
        public PlayGameScene(IntPtr address) : this(address, "PlayGameScene")
        {
        }

        public PlayGameScene(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetScreenName()
        {
            return base.method_13("GetScreenName", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public void OnDeckPickerLoaded()
        {
            base.method_8("OnDeckPickerLoaded", Array.Empty<object>());
        }

        public void OnUIScreenLoaded(string name, GameObject screen, object callbackData)
        {
            object[] objArray1 = new object[] { name, screen, callbackData };
            base.method_8("OnUIScreenLoaded", objArray1);
        }

        public void PreUnload()
        {
            base.method_8("PreUnload", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_deckPickerIsLoaded
        {
            get
            {
                return base.method_2<bool>("m_deckPickerIsLoaded");
            }
        }
    }
}

