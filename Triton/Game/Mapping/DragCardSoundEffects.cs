namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DragCardSoundEffects")]
    public class DragCardSoundEffects : MonoBehaviour
    {
        public DragCardSoundEffects(IntPtr address) : this(address, "DragCardSoundEffects")
        {
        }

        public DragCardSoundEffects(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void LoadAirSound()
        {
            base.method_8("LoadAirSound", Array.Empty<object>());
        }

        public void LoadMagicalSound()
        {
            base.method_8("LoadMagicalSound", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void Restart()
        {
            base.method_8("Restart", Array.Empty<object>());
        }

        public void StopSound()
        {
            base.method_8("StopSound", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float AIR_SOUND_MAX_VOLUME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "AIR_SOUND_MAX_VOLUME");
            }
        }

        public static float AIR_SOUND_MOVEMENT_THRESHOLD
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "AIR_SOUND_MOVEMENT_THRESHOLD");
            }
        }

        public static float AIR_SOUND_VOLUME_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "AIR_SOUND_VOLUME_SPEED");
            }
        }

        public static float AIR_SOUND_VOLUME_VELOCITY_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "AIR_SOUND_VOLUME_VELOCITY_SCALE");
            }
        }

        public static string CARD_MOTION_LOOP_AIR_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "CARD_MOTION_LOOP_AIR_SOUND");
            }
        }

        public static string CARD_MOTION_LOOP_MAGICAL_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "CARD_MOTION_LOOP_MAGICAL_SOUND");
            }
        }

        public static float DISABLE_VOLUME_FADE_OUT_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "DISABLE_VOLUME_FADE_OUT_TIME");
            }
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public bool m_AirSoundLoading
        {
            get
            {
                return base.method_2<bool>("m_AirSoundLoading");
            }
        }

        public float m_AirVelocity
        {
            get
            {
                return base.method_2<float>("m_AirVelocity");
            }
        }

        public float m_AirVolume
        {
            get
            {
                return base.method_2<float>("m_AirVolume");
            }
        }

        public Card m_Card
        {
            get
            {
                return base.method_3<Card>("m_Card");
            }
        }

        public bool m_Disabled
        {
            get
            {
                return base.method_2<bool>("m_Disabled");
            }
        }

        public bool m_FadingOut
        {
            get
            {
                return base.method_2<bool>("m_FadingOut");
            }
        }

        public bool m_MagicalSoundLoading
        {
            get
            {
                return base.method_2<bool>("m_MagicalSoundLoading");
            }
        }

        public float m_MagicalVelocity
        {
            get
            {
                return base.method_2<float>("m_MagicalVelocity");
            }
        }

        public float m_MagicalVolume
        {
            get
            {
                return base.method_2<float>("m_MagicalVolume");
            }
        }

        public Vector3 m_PreviousPosition
        {
            get
            {
                return base.method_2<Vector3>("m_PreviousPosition");
            }
        }

        public static float MAGICAL_SOUND_FADE_IN_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "MAGICAL_SOUND_FADE_IN_TIME");
            }
        }

        public static float MAGICAL_SOUND_VOLUME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DragCardSoundEffects", "MAGICAL_SOUND_VOLUME");
            }
        }
    }
}

