namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM14_Omnotron")]
    public class BRM14_Omnotron : BRM_MissionEntity
    {
        public BRM14_Omnotron(IntPtr address) : this(address, "BRM14_Omnotron")
        {
        }

        public BRM14_Omnotron(IntPtr address, string className) : base(address, className)
        {
        }

        public void CycleNextResponseGroupIndex(MissionEntity.EmoteResponseGroup responseGroup)
        {
            object[] objArray1 = new object[] { responseGroup };
            base.method_8("CycleNextResponseGroupIndex", objArray1);
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool m_cardLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed");
            }
        }

        public bool m_heroPower1LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower1LinePlayed");
            }
        }

        public bool m_heroPower2LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower2LinePlayed");
            }
        }

        public bool m_heroPower3LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower3LinePlayed");
            }
        }

        public bool m_heroPower4LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower4LinePlayed");
            }
        }

        public bool m_heroPower5LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower5LinePlayed");
            }
        }
    }
}

