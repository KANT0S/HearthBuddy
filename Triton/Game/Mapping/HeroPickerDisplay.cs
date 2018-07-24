namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HeroPickerDisplay")]
    public class HeroPickerDisplay : MonoBehaviour
    {
        public HeroPickerDisplay(IntPtr address) : this(address, "HeroPickerDisplay")
        {
        }

        public HeroPickerDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeckPickerTrayLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("DeckPickerTrayLoaded", objArray1);
        }

        public static HeroPickerDisplay Get()
        {
            return MonoClass.smethod_15<HeroPickerDisplay>(TritonHs.MainAssemblyPath, "", "HeroPickerDisplay", "Get", Array.Empty<object>());
        }

        public void HideTray(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("HideTray", objArray1);
        }

        public bool IsHidden()
        {
            return base.method_11<bool>("IsHidden", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void KillHeroPicker()
        {
            base.method_8("KillHeroPicker", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ShowTray()
        {
            base.method_8("ShowTray", Array.Empty<object>());
        }

        public static Vector3 HERO_PICKER_END_POSITION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "HeroPickerDisplay", "HERO_PICKER_END_POSITION");
            }
        }

        public GameObject m_deckPickerBone
        {
            get
            {
                return base.method_3<GameObject>("m_deckPickerBone");
            }
        }

        public DeckPickerTrayDisplay m_deckPickerTray
        {
            get
            {
                return base.method_3<DeckPickerTrayDisplay>("m_deckPickerTray");
            }
        }
    }
}

