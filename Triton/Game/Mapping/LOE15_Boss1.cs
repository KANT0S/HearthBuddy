namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("LOE15_Boss1")]
    public class LOE15_Boss1 : LOE_MissionEntity
    {
        public LOE15_Boss1(IntPtr address) : this(address, "LOE15_Boss1")
        {
        }

        public LOE15_Boss1(IntPtr address, string className) : base(address, className)
        {
        }

        public bool DoAlternateMulliganIntro()
        {
            return base.method_11<bool>("DoAlternateMulliganIntro", Array.Empty<object>());
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool m_lowHealth
        {
            get
            {
                return base.method_2<bool>("m_lowHealth");
            }
        }

        public bool m_magmaRagerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_magmaRagerLinePlayed");
            }
        }

        public List<Zone> m_zonesToHide
        {
            get
            {
                Class267<Zone> class2 = base.method_3<Class267<Zone>>("m_zonesToHide");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

