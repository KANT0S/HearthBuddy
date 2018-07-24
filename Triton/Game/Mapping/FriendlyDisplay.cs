namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendlyDisplay")]
    public class FriendlyDisplay : MonoBehaviour
    {
        public FriendlyDisplay(IntPtr address) : this(address, "FriendlyDisplay")
        {
        }

        public FriendlyDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisableOtherModeStuff()
        {
            base.method_8("DisableOtherModeStuff", Array.Empty<object>());
        }

        public static FriendlyDisplay Get()
        {
            return MonoClass.smethod_15<FriendlyDisplay>(TritonHs.MainAssemblyPath, "", "FriendlyDisplay", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public DeckPickerTrayDisplay m_deckPickerTray
        {
            get
            {
                return base.method_3<DeckPickerTrayDisplay>("m_deckPickerTray");
            }
        }

        public GameObject m_deckPickerTrayContainer
        {
            get
            {
                return base.method_3<GameObject>("m_deckPickerTrayContainer");
            }
        }
    }
}

