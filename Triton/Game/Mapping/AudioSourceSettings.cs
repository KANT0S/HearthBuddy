namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AudioSourceSettings")]
    public class AudioSourceSettings : MonoClass
    {
        public AudioSourceSettings(IntPtr address) : this(address, "AudioSourceSettings")
        {
        }

        public AudioSourceSettings(IntPtr address, string className) : base(address, className)
        {
        }

        public void LoadDefaults()
        {
            base.method_8("LoadDefaults", Array.Empty<object>());
        }

        public static bool DEFAULT_BYPASS_EFFECTS
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_BYPASS_EFFECTS");
            }
        }

        public static float DEFAULT_DOPPLER_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_DOPPLER_LEVEL");
            }
        }

        public static bool DEFAULT_LOOP
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_LOOP");
            }
        }

        public static float DEFAULT_MAX_DISTANCE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_MAX_DISTANCE");
            }
        }

        public static float DEFAULT_MIN_DISTANCE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_MIN_DISTANCE");
            }
        }

        public static float DEFAULT_PITCH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_PITCH");
            }
        }

        public static int DEFAULT_PRIORITY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_PRIORITY");
            }
        }

        public static float DEFAULT_REVERB_ZONE_MIX
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_REVERB_ZONE_MIX");
            }
        }

        public static float DEFAULT_SPATIAL_BLEND
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_SPATIAL_BLEND");
            }
        }

        public static float DEFAULT_SPREAD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_SPREAD");
            }
        }

        public static float DEFAULT_STEREO_PAN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_STEREO_PAN");
            }
        }

        public static float DEFAULT_VOLUME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "DEFAULT_VOLUME");
            }
        }

        public bool m_bypassEffects
        {
            get
            {
                return base.method_2<bool>("m_bypassEffects");
            }
        }

        public float m_dopplerLevel
        {
            get
            {
                return base.method_2<float>("m_dopplerLevel");
            }
        }

        public bool m_loop
        {
            get
            {
                return base.method_2<bool>("m_loop");
            }
        }

        public float m_maxDistance
        {
            get
            {
                return base.method_2<float>("m_maxDistance");
            }
        }

        public float m_minDistance
        {
            get
            {
                return base.method_2<float>("m_minDistance");
            }
        }

        public float m_pitch
        {
            get
            {
                return base.method_2<float>("m_pitch");
            }
        }

        public int m_priority
        {
            get
            {
                return base.method_2<int>("m_priority");
            }
        }

        public float m_reverbZoneMix
        {
            get
            {
                return base.method_2<float>("m_reverbZoneMix");
            }
        }

        public float m_spatialBlend
        {
            get
            {
                return base.method_2<float>("m_spatialBlend");
            }
        }

        public float m_spread
        {
            get
            {
                return base.method_2<float>("m_spread");
            }
        }

        public float m_stereoPan
        {
            get
            {
                return base.method_2<float>("m_stereoPan");
            }
        }

        public float m_volume
        {
            get
            {
                return base.method_2<float>("m_volume");
            }
        }

        public static float MAX_DOPPLER_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_DOPPLER_LEVEL");
            }
        }

        public static float MAX_PITCH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_PITCH");
            }
        }

        public static int MAX_PRIORITY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_PRIORITY");
            }
        }

        public static float MAX_REVERB_ZONE_MIX
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_REVERB_ZONE_MIX");
            }
        }

        public static float MAX_SPATIAL_BLEND
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_SPATIAL_BLEND");
            }
        }

        public static float MAX_SPREAD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_SPREAD");
            }
        }

        public static float MAX_STEREO_PAN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_STEREO_PAN");
            }
        }

        public static float MAX_VOLUME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MAX_VOLUME");
            }
        }

        public static float MIN_DOPPLER_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_DOPPLER_LEVEL");
            }
        }

        public static float MIN_PITCH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_PITCH");
            }
        }

        public static int MIN_PRIORITY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_PRIORITY");
            }
        }

        public static float MIN_REVERB_ZONE_MIX
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_REVERB_ZONE_MIX");
            }
        }

        public static float MIN_SPATIAL_BLEND
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_SPATIAL_BLEND");
            }
        }

        public static float MIN_SPREAD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_SPREAD");
            }
        }

        public static float MIN_STEREO_PAN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_STEREO_PAN");
            }
        }

        public static float MIN_VOLUME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AudioSourceSettings", "MIN_VOLUME");
            }
        }
    }
}

