namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("WeaponSocketMgr")]
    public class WeaponSocketMgr : MonoBehaviour
    {
        public WeaponSocketMgr(IntPtr address) : this(address, "WeaponSocketMgr")
        {
        }

        public WeaponSocketMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool ShouldSeeWeaponSocket(TAG_CLASS tagVal)
        {
            object[] objArray1 = new object[] { tagVal };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "WeaponSocketMgr", "ShouldSeeWeaponSocket", objArray1);
        }

        public void UpdateSockets()
        {
            base.method_8("UpdateSockets", Array.Empty<object>());
        }

        public List<WeaponSocketDecoration> m_Decorations
        {
            get
            {
                Class267<WeaponSocketDecoration> class2 = base.method_3<Class267<WeaponSocketDecoration>>("m_Decorations");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

