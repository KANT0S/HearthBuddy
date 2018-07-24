namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureChooserSubButton")]
    public class AdventureChooserSubButton : AdventureGenericButton
    {
        public AdventureChooserSubButton(IntPtr address) : this(address, "AdventureChooserSubButton")
        {
        }

        public AdventureChooserSubButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Flash()
        {
            base.method_8("Flash", Array.Empty<object>());
        }

        public AdventureDbId GetAdventure()
        {
            return base.method_11<AdventureDbId>("GetAdventure", Array.Empty<object>());
        }

        public AdventureModeDbId GetMode()
        {
            return base.method_11<AdventureModeDbId>("GetMode", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void SetAdventure(AdventureDbId id, AdventureModeDbId mode)
        {
            object[] objArray1 = new object[] { id, mode };
            base.method_8("SetAdventure", objArray1);
        }

        public void SetHighlight(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetHighlight", objArray1);
        }

        public void SetNewGlow(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetNewGlow", objArray1);
        }

        public void ShowRemainingProgressCount()
        {
            base.method_8("ShowRemainingProgressCount", Array.Empty<object>());
        }

        public bool m_Glow
        {
            get
            {
                return base.method_2<bool>("m_Glow");
            }
        }

        public GameObject m_heroicSkull
        {
            get
            {
                return base.method_3<GameObject>("m_heroicSkull");
            }
        }

        public GameObject m_progressCounter
        {
            get
            {
                return base.method_3<GameObject>("m_progressCounter");
            }
        }

        public UberText m_progressCounterText
        {
            get
            {
                return base.method_3<UberText>("m_progressCounterText");
            }
        }

        public StateEventTable m_StateTable
        {
            get
            {
                return base.method_3<StateEventTable>("m_StateTable");
            }
        }

        public AdventureDbId m_TargetAdventure
        {
            get
            {
                return base.method_2<AdventureDbId>("m_TargetAdventure");
            }
        }

        public AdventureModeDbId m_TargetMode
        {
            get
            {
                return base.method_2<AdventureModeDbId>("m_TargetMode");
            }
        }

        public static string s_EventFlash
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureChooserSubButton", "s_EventFlash");
            }
        }
    }
}

