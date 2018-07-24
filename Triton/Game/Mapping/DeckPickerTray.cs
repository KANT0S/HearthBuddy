namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckPickerTray")]
    public class DeckPickerTray : MonoClass
    {
        public DeckPickerTray(IntPtr address) : this(address, "DeckPickerTray")
        {
        }

        public DeckPickerTray(IntPtr address, string className) : base(address, className)
        {
        }

        public static DeckPickerTray Get()
        {
            return MonoClass.smethod_15<DeckPickerTray>(TritonHs.MainAssemblyPath, "", "DeckPickerTray", "Get", Array.Empty<object>());
        }

        public bool OnFindGameEvent(FindGameEventData eventData, object userData)
        {
            object[] objArray1 = new object[] { eventData, userData };
            return base.method_11<bool>("OnFindGameEvent", objArray1);
        }

        public void RegisterHandlers()
        {
            base.method_8("RegisterHandlers", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void UnregisterHandlers()
        {
            base.method_8("UnregisterHandlers", Array.Empty<object>());
        }

        public bool m_registeredHandlers
        {
            get
            {
                return base.method_2<bool>("m_registeredHandlers");
            }
        }
    }
}

