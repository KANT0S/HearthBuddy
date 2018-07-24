namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AdventureMission")]
    public class AdventureMission : MonoClass
    {
        public AdventureMission(IntPtr address) : this(address, "AdventureMission")
        {
        }

        public AdventureMission(IntPtr address, string className) : base(address, className)
        {
        }

        public bool HasGrantedProgress()
        {
            return base.method_11<bool>("HasGrantedProgress", Array.Empty<object>());
        }

        public bool HasRequiredProgress()
        {
            return base.method_11<bool>("HasRequiredProgress", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public string Description
        {
            get
            {
                return base.method_13("get_Description", Array.Empty<object>());
            }
        }

        public WingProgress GrantedProgress
        {
            get
            {
                return base.method_14<WingProgress>("get_GrantedProgress", Array.Empty<object>());
            }
        }

        public string m_description
        {
            get
            {
                return base.method_4("m_description");
            }
        }

        public WingProgress m_grantedProgress
        {
            get
            {
                return base.method_3<WingProgress>("m_grantedProgress");
            }
        }

        public WingProgress m_requiredProgress
        {
            get
            {
                return base.method_3<WingProgress>("m_requiredProgress");
            }
        }

        public int m_scenarioID
        {
            get
            {
                return base.method_2<int>("m_scenarioID");
            }
        }

        public WingProgress RequiredProgress
        {
            get
            {
                return base.method_14<WingProgress>("get_RequiredProgress", Array.Empty<object>());
            }
        }

        public int ScenarioID
        {
            get
            {
                return base.method_11<int>("get_ScenarioID", Array.Empty<object>());
            }
        }

        [Attribute38("AdventureMission.WingProgress")]
        public class WingProgress : MonoClass
        {
            public WingProgress(IntPtr address) : this(address, "WingProgress")
            {
            }

            public WingProgress(IntPtr address, string className) : base(address, className)
            {
            }

            public AdventureMission.WingProgress Clone()
            {
                return base.method_14<AdventureMission.WingProgress>("Clone", Array.Empty<object>());
            }

            public bool IsEmpty()
            {
                return base.method_11<bool>("IsEmpty", Array.Empty<object>());
            }

            public bool IsOwned()
            {
                return base.method_11<bool>("IsOwned", Array.Empty<object>());
            }

            public bool MeetsFlagsRequirement(ulong requiredFlags)
            {
                object[] objArray1 = new object[] { requiredFlags };
                return base.method_11<bool>("MeetsFlagsRequirement", objArray1);
            }

            public bool MeetsProgressAndFlagsRequirements(AdventureMission.WingProgress requiredProgress)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { requiredProgress };
                return base.method_10<bool>("MeetsProgressAndFlagsRequirements", enumArray1, objArray1);
            }

            public bool MeetsProgressAndFlagsRequirements(int requiredProgress, ulong requiredFlags)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.U8 };
                object[] objArray1 = new object[] { requiredProgress, requiredFlags };
                return base.method_10<bool>("MeetsProgressAndFlagsRequirements", enumArray1, objArray1);
            }

            public bool MeetsProgressRequirement(int requiredProgress)
            {
                object[] objArray1 = new object[] { requiredProgress };
                return base.method_11<bool>("MeetsProgressRequirement", objArray1);
            }

            public void SetFlags(ulong flags)
            {
                object[] objArray1 = new object[] { flags };
                base.method_8("SetFlags", objArray1);
            }

            public void SetProgress(int progress)
            {
                object[] objArray1 = new object[] { progress };
                base.method_8("SetProgress", objArray1);
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public ulong Flags
            {
                get
                {
                    return base.method_11<ulong>("get_Flags", Array.Empty<object>());
                }
            }

            public ulong m_flags
            {
                get
                {
                    return base.method_2<ulong>("m_flags");
                }
            }

            public int m_progress
            {
                get
                {
                    return base.method_2<int>("m_progress");
                }
            }

            public int m_wing
            {
                get
                {
                    return base.method_2<int>("m_wing");
                }
            }

            public int Progress
            {
                get
                {
                    return base.method_11<int>("get_Progress", Array.Empty<object>());
                }
            }

            public int Wing
            {
                get
                {
                    return base.method_11<int>("get_Wing", Array.Empty<object>());
                }
            }
        }
    }
}

