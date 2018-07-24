namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("WeaponSocketDecoration")]
    public class WeaponSocketDecoration : MonoBehaviour
    {
        public WeaponSocketDecoration(IntPtr address) : this(address, "WeaponSocketDecoration")
        {
        }

        public WeaponSocketDecoration(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreVisibilityRequirementsMet()
        {
            return base.method_11<bool>("AreVisibilityRequirementsMet", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void UpdateVisibility()
        {
            base.method_8("UpdateVisibility", Array.Empty<object>());
        }

        public List<WeaponSocketRequirement> m_VisibilityRequirements
        {
            get
            {
                Class267<WeaponSocketRequirement> class2 = base.method_3<Class267<WeaponSocketRequirement>>("m_VisibilityRequirements");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

