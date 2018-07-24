namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SoundUtils")]
    public class SoundUtils : MonoClass
    {
        public SoundUtils(IntPtr address) : this(address, "SoundUtils")
        {
        }

        public SoundUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool CanDetectVolume()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "CanDetectVolume", Array.Empty<object>());
        }

        public static void CopyDuckedCategoryDef(SoundDuckedCategoryDef src, SoundDuckedCategoryDef dst)
        {
            object[] objArray1 = new object[] { src, dst };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SoundUtils", "CopyDuckedCategoryDef", objArray1);
        }

        public static void CopySoundDef(SoundDef src, SoundDef dst)
        {
            object[] objArray1 = new object[] { src, dst };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SoundUtils", "CopySoundDef", objArray1);
        }

        public static Triton.Game.Mapping.Option GetCategoryEnabledOption(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<Triton.Game.Mapping.Option>(TritonHs.MainAssemblyPath, "", "SoundUtils", "GetCategoryEnabledOption", objArray1);
        }

        public static float GetCategoryVolume(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "SoundUtils", "GetCategoryVolume", objArray1);
        }

        public static Triton.Game.Mapping.Option GetCategoryVolumeOption(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<Triton.Game.Mapping.Option>(TritonHs.MainAssemblyPath, "", "SoundUtils", "GetCategoryVolumeOption", objArray1);
        }

        public static float GetRandomPitchFromDef(SoundDef def)
        {
            object[] objArray1 = new object[] { def };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "SoundUtils", "GetRandomPitchFromDef", objArray1);
        }

        public static float GetRandomVolumeFromDef(SoundDef def)
        {
            object[] objArray1 = new object[] { def };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "SoundUtils", "GetRandomVolumeFromDef", objArray1);
        }

        public static bool IsBackgroundMusicPlaying()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsBackgroundMusicPlaying", Array.Empty<object>());
        }

        public static bool IsCategoryAudible(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsCategoryAudible", objArray1);
        }

        public static bool IsCategoryEnabled(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsCategoryEnabled", objArray1);
        }

        public static bool IsFxAudible()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsFxAudible", Array.Empty<object>());
        }

        public static bool IsFxEnabled()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsFxEnabled", Array.Empty<object>());
        }

        public static bool IsMusicAudible()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsMusicAudible", Array.Empty<object>());
        }

        public static bool IsMusicCategory(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsMusicCategory", objArray1);
        }

        public static bool IsMusicEnabled()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsMusicEnabled", Array.Empty<object>());
        }

        public static bool IsVOClip(RandomAudioClip randomClip)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { randomClip };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsVOClip", enumArray1, objArray1);
        }

        public static bool IsVOFileName(string name)
        {
            object[] objArray1 = new object[] { name };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsVOFileName", objArray1);
        }

        public static bool IsVOFilePath(string path)
        {
            object[] objArray1 = new object[] { path };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsVOFilePath", objArray1);
        }

        public static bool IsVoiceAudible()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsVoiceAudible", Array.Empty<object>());
        }

        public static bool IsVoiceCategory(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsVoiceCategory", objArray1);
        }

        public static bool IsVoiceEnabled()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "SoundUtils", "IsVoiceEnabled", Array.Empty<object>());
        }

        public static void SetSourceVolumes(Component c, float volume, bool includeInactive)
        {
            object[] objArray1 = new object[] { c, volume, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SoundUtils", "SetSourceVolumes", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetSourceVolumes(GameObject go, float volume, bool includeInactive)
        {
            object[] objArray1 = new object[] { go, volume, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SoundUtils", "SetSourceVolumes", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetVolumes(Component c, float volume, bool includeInactive)
        {
            object[] objArray1 = new object[] { c, volume, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SoundUtils", "SetVolumes", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void SetVolumes(GameObject go, float volume, bool includeInactive)
        {
            object[] objArray1 = new object[] { go, volume, includeInactive };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "SoundUtils", "SetVolumes", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }
    }
}

