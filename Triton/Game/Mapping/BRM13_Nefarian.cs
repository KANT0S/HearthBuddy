namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM13_Nefarian")]
    public class BRM13_Nefarian : BRM_MissionEntity
    {
        public BRM13_Nefarian(IntPtr address) : this(address, "BRM13_Nefarian")
        {
        }

        public BRM13_Nefarian(IntPtr address, string className) : base(address, className)
        {
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }

        public int m_ragLine
        {
            get
            {
                return base.method_2<int>("m_ragLine");
            }
        }

        public Vector3 ragLinePosition
        {
            get
            {
                return base.method_2<Vector3>("ragLinePosition");
            }
        }
    }
}

