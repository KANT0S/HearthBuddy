namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("iTween")]
    public class iTween : MonoClass
    {
        public iTween(IntPtr address) : this(address, "iTween")
        {
        }

        public iTween(IntPtr address, string className) : base(address, className)
        {
        }

        public void ApplyAudioToTargets()
        {
            base.method_8("ApplyAudioToTargets", Array.Empty<object>());
        }

        public void ApplyColorTargets()
        {
            base.method_8("ApplyColorTargets", Array.Empty<object>());
        }

        public void ApplyColorToTargets()
        {
            base.method_8("ApplyColorToTargets", Array.Empty<object>());
        }

        public void ApplyFloatTargets()
        {
            base.method_8("ApplyFloatTargets", Array.Empty<object>());
        }

        public void ApplyLookToTargets()
        {
            base.method_8("ApplyLookToTargets", Array.Empty<object>());
        }

        public void ApplyMoveByTargets()
        {
            base.method_8("ApplyMoveByTargets", Array.Empty<object>());
        }

        public void ApplyMoveToPathTargets()
        {
            base.method_8("ApplyMoveToPathTargets", Array.Empty<object>());
        }

        public void ApplyMoveToTargets()
        {
            base.method_8("ApplyMoveToTargets", Array.Empty<object>());
        }

        public void ApplyPunchPositionTargets()
        {
            base.method_8("ApplyPunchPositionTargets", Array.Empty<object>());
        }

        public void ApplyPunchRotationTargets()
        {
            base.method_8("ApplyPunchRotationTargets", Array.Empty<object>());
        }

        public void ApplyPunchScaleTargets()
        {
            base.method_8("ApplyPunchScaleTargets", Array.Empty<object>());
        }

        public void ApplyRectTargets()
        {
            base.method_8("ApplyRectTargets", Array.Empty<object>());
        }

        public void ApplyRotateAddTargets()
        {
            base.method_8("ApplyRotateAddTargets", Array.Empty<object>());
        }

        public void ApplyRotateToTargets()
        {
            base.method_8("ApplyRotateToTargets", Array.Empty<object>());
        }

        public void ApplyScaleToTargets()
        {
            base.method_8("ApplyScaleToTargets", Array.Empty<object>());
        }

        public void ApplyShakePositionTargets()
        {
            base.method_8("ApplyShakePositionTargets", Array.Empty<object>());
        }

        public void ApplyShakeRotationTargets()
        {
            base.method_8("ApplyShakeRotationTargets", Array.Empty<object>());
        }

        public void ApplyShakeScaleTargets()
        {
            base.method_8("ApplyShakeScaleTargets", Array.Empty<object>());
        }

        public void ApplyStabTargets()
        {
            base.method_8("ApplyStabTargets", Array.Empty<object>());
        }

        public void ApplyVector2Targets()
        {
            base.method_8("ApplyVector2Targets", Array.Empty<object>());
        }

        public void ApplyVector3Targets()
        {
            base.method_8("ApplyVector3Targets", Array.Empty<object>());
        }

        public static void AudioFrom(GameObject target, float volume, float pitch, float time)
        {
            object[] objArray1 = new object[] { target, volume, pitch, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "AudioFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void AudioTo(GameObject target, float volume, float pitch, float time)
        {
            object[] objArray1 = new object[] { target, volume, pitch, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "AudioTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
        {
            object[] objArray1 = new object[] { target, volume, pitch, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "AudioUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CallBack(CallbackType callbackType)
        {
            object[] objArray1 = new object[] { callbackType };
            base.method_8("CallBack", objArray1);
        }

        public static GameObject CameraFadeAdd()
        {
            return MonoClass.smethod_16<GameObject>(TritonHs.MainAssemblyPath, "", "iTween", "CameraFadeAdd", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static void CameraFadeDepth(int depth)
        {
            object[] objArray1 = new object[] { depth };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "CameraFadeDepth", objArray1);
        }

        public static void CameraFadeDestroy()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "iTween", "CameraFadeDestroy");
        }

        public static void CameraFadeFrom(float amount, float time)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "CameraFadeFrom", enumArray1, objArray1);
        }

        public static void CameraFadeTo(float amount, float time)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "CameraFadeTo", enumArray1, objArray1);
        }

        public float clerp(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("clerp", objArray1);
        }

        public static void ColorFrom(GameObject target, Color color, float time)
        {
            object[] objArray1 = new object[] { target, color, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ColorFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ColorTo(GameObject target, Color color, float time)
        {
            object[] objArray1 = new object[] { target, color, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ColorTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ColorUpdate(GameObject target, Color color, float time)
        {
            object[] objArray1 = new object[] { target, color, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ColorUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void ConflictCheck()
        {
            base.method_8("ConflictCheck", Array.Empty<object>());
        }

        public static int Count()
        {
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "iTween", "Count", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static int Count(string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { type };
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "iTween", "Count", enumArray1, objArray1);
        }

        public static int Count(GameObject target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { target };
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "iTween", "Count", enumArray1, objArray1);
        }

        public static int Count(GameObject target, string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { target, type };
            return MonoClass.smethod_11<int>(TritonHs.MainAssemblyPath, "", "iTween", "Count", enumArray1, objArray1);
        }

        public static int CountByName(GameObject target, string name)
        {
            object[] objArray1 = new object[] { target, name };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "iTween", "CountByName", objArray1);
        }

        public static int CountOtherNames(GameObject target, string name)
        {
            object[] objArray1 = new object[] { target, name };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "iTween", "CountOtherNames", objArray1);
        }

        public static int CountOtherTypes(GameObject target, string type)
        {
            object[] objArray1 = new object[] { target, type };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "iTween", "CountOtherTypes", objArray1);
        }

        public void DisableKinematic()
        {
            base.method_8("DisableKinematic", Array.Empty<object>());
        }

        public void Dispose()
        {
            base.method_8("Dispose", Array.Empty<object>());
        }

        public float easeInBack(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInBack", objArray1);
        }

        public float easeInBounce(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInBounce", objArray1);
        }

        public float easeInCirc(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInCirc", objArray1);
        }

        public float easeInCubic(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInCubic", objArray1);
        }

        public float easeInElastic(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInElastic", objArray1);
        }

        public float easeInExpo(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInExpo", objArray1);
        }

        public float easeInExpoFirstHalf(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInExpoFirstHalf", objArray1);
        }

        public float easeInExpoSecondHalf(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInExpoSecondHalf", objArray1);
        }

        public float easeInOutBack(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutBack", objArray1);
        }

        public float easeInOutBounce(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutBounce", objArray1);
        }

        public float easeInOutCirc(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutCirc", objArray1);
        }

        public float easeInOutCubic(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutCubic", objArray1);
        }

        public float easeInOutElastic(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutElastic", objArray1);
        }

        public float easeInOutExpo(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutExpo", objArray1);
        }

        public float easeInOutQuad(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutQuad", objArray1);
        }

        public float easeInOutQuart(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutQuart", objArray1);
        }

        public float easeInOutQuint(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutQuint", objArray1);
        }

        public float easeInOutSine(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInOutSine", objArray1);
        }

        public float easeInQuad(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInQuad", objArray1);
        }

        public float easeInQuart(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInQuart", objArray1);
        }

        public float easeInQuint(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInQuint", objArray1);
        }

        public float easeInSine(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInSine", objArray1);
        }

        public float easeInSineOutExpo(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeInSineOutExpo", objArray1);
        }

        public float easeOutBack(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutBack", objArray1);
        }

        public float easeOutBounce(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutBounce", objArray1);
        }

        public float easeOutCirc(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutCirc", objArray1);
        }

        public float easeOutCubic(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutCubic", objArray1);
        }

        public float easeOutElastic(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutElastic", objArray1);
        }

        public float easeOutElasticLight(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutElasticLight", objArray1);
        }

        public float easeOutExpo(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutExpo", objArray1);
        }

        public float easeOutQuad(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutQuad", objArray1);
        }

        public float easeOutQuart(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutQuart", objArray1);
        }

        public float easeOutQuint(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutQuint", objArray1);
        }

        public float easeOutSine(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("easeOutSine", objArray1);
        }

        public void EnableKinematic()
        {
            base.method_8("EnableKinematic", Array.Empty<object>());
        }

        public static void EnableTween(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "EnableTween", objArray1);
        }

        public static void FadeFrom(GameObject target, float alpha, float time)
        {
            object[] objArray1 = new object[] { target, alpha, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "FadeFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FadeTo(GameObject target, float alpha, float time)
        {
            object[] objArray1 = new object[] { target, alpha, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "FadeTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void FadeUpdate(GameObject target, float alpha, float time)
        {
            object[] objArray1 = new object[] { target, alpha, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "FadeUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void FixedUpdate()
        {
            base.method_8("FixedUpdate", Array.Empty<object>());
        }

        public static float FloatUpdate(float currentValue, float targetValue, float speed)
        {
            object[] objArray1 = new object[] { currentValue, targetValue, speed };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "iTween", "FloatUpdate", objArray1);
        }

        public void GenerateAudioToTargets()
        {
            base.method_8("GenerateAudioToTargets", Array.Empty<object>());
        }

        public void GenerateColorTargets()
        {
            base.method_8("GenerateColorTargets", Array.Empty<object>());
        }

        public void GenerateColorToTargets()
        {
            base.method_8("GenerateColorToTargets", Array.Empty<object>());
        }

        public void GenerateFloatTargets()
        {
            base.method_8("GenerateFloatTargets", Array.Empty<object>());
        }

        public static int GenerateID()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "iTween", "GenerateID", Array.Empty<object>());
        }

        public void GenerateLookToTargets()
        {
            base.method_8("GenerateLookToTargets", Array.Empty<object>());
        }

        public void GenerateMoveByTargets()
        {
            base.method_8("GenerateMoveByTargets", Array.Empty<object>());
        }

        public void GenerateMoveToPathTargets()
        {
            base.method_8("GenerateMoveToPathTargets", Array.Empty<object>());
        }

        public void GenerateMoveToTargets()
        {
            base.method_8("GenerateMoveToTargets", Array.Empty<object>());
        }

        public void GeneratePunchPositionTargets()
        {
            base.method_8("GeneratePunchPositionTargets", Array.Empty<object>());
        }

        public void GeneratePunchRotationTargets()
        {
            base.method_8("GeneratePunchRotationTargets", Array.Empty<object>());
        }

        public void GeneratePunchScaleTargets()
        {
            base.method_8("GeneratePunchScaleTargets", Array.Empty<object>());
        }

        public void GenerateRectTargets()
        {
            base.method_8("GenerateRectTargets", Array.Empty<object>());
        }

        public void GenerateRotateAddTargets()
        {
            base.method_8("GenerateRotateAddTargets", Array.Empty<object>());
        }

        public void GenerateRotateByTargets()
        {
            base.method_8("GenerateRotateByTargets", Array.Empty<object>());
        }

        public void GenerateRotateToTargets()
        {
            base.method_8("GenerateRotateToTargets", Array.Empty<object>());
        }

        public void GenerateScaleAddTargets()
        {
            base.method_8("GenerateScaleAddTargets", Array.Empty<object>());
        }

        public void GenerateScaleByTargets()
        {
            base.method_8("GenerateScaleByTargets", Array.Empty<object>());
        }

        public void GenerateScaleToTargets()
        {
            base.method_8("GenerateScaleToTargets", Array.Empty<object>());
        }

        public void GenerateShakePositionTargets()
        {
            base.method_8("GenerateShakePositionTargets", Array.Empty<object>());
        }

        public void GenerateShakeRotationTargets()
        {
            base.method_8("GenerateShakeRotationTargets", Array.Empty<object>());
        }

        public void GenerateShakeScaleTargets()
        {
            base.method_8("GenerateShakeScaleTargets", Array.Empty<object>());
        }

        public void GenerateStabTargets()
        {
            base.method_8("GenerateStabTargets", Array.Empty<object>());
        }

        public void GenerateTargets()
        {
            base.method_8("GenerateTargets", Array.Empty<object>());
        }

        public void GenerateVector2Targets()
        {
            base.method_8("GenerateVector2Targets", Array.Empty<object>());
        }

        public void GenerateVector3Targets()
        {
            base.method_8("GenerateVector3Targets", Array.Empty<object>());
        }

        public Component GetComponent(System.Type t)
        {
            object[] objArray1 = new object[] { t };
            return base.method_14<Component>("GetComponent", objArray1);
        }

        public void GetEasingFunction()
        {
            base.method_8("GetEasingFunction", Array.Empty<object>());
        }

        public Vector3 GetTargetPosition()
        {
            return base.method_11<Vector3>("GetTargetPosition", Array.Empty<object>());
        }

        public static bool HasName(GameObject target, string name)
        {
            object[] objArray1 = new object[] { target, name };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "iTween", "HasName", objArray1);
        }

        public static bool HasOtherName(GameObject target, string name)
        {
            object[] objArray1 = new object[] { target, name };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "iTween", "HasOtherName", objArray1);
        }

        public static bool HasOtherType(GameObject target, string type)
        {
            object[] objArray1 = new object[] { target, type };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "iTween", "HasOtherType", objArray1);
        }

        public static bool HasTween(GameObject target)
        {
            object[] objArray1 = new object[] { target };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "iTween", "HasTween", objArray1);
        }

        public static bool HasType(GameObject target, string type)
        {
            object[] objArray1 = new object[] { target, type };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "iTween", "HasType", objArray1);
        }

        public static void Init(GameObject target)
        {
            object[] objArray1 = new object[] { target };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "Init", objArray1);
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public float linear(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("linear", objArray1);
        }

        public static void LookFrom(GameObject target, Vector3 looktarget, float time)
        {
            object[] objArray1 = new object[] { target, looktarget, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "LookFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void LookTo(GameObject target, Vector3 looktarget, float time)
        {
            object[] objArray1 = new object[] { target, looktarget, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "LookTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
        {
            object[] objArray1 = new object[] { target, looktarget, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "LookUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void MoveAdd(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "MoveAdd", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void MoveBy(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "MoveBy", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void MoveFrom(GameObject target, Vector3 position, float time)
        {
            object[] objArray1 = new object[] { target, position, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "MoveFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void MoveTo(GameObject target, Vector3 position, float time)
        {
            object[] objArray1 = new object[] { target, position, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "MoveTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void MoveUpdate(GameObject target, Vector3 position, float time)
        {
            object[] objArray1 = new object[] { target, position, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "MoveUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public static void Pause()
        {
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Pause", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static void Pause(string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { type };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Pause", enumArray1, objArray1);
        }

        public static void Pause(GameObject target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Pause", enumArray1, objArray1);
        }

        public static void Pause(GameObject target, bool includechildren)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { target, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Pause", enumArray1, objArray1);
        }

        public static void Pause(GameObject target, string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { target, type };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Pause", enumArray1, objArray1);
        }

        public static void Pause(GameObject target, string type, bool includechildren)
        {
            object[] objArray1 = new object[] { target, type, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Pause", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void PauseTween(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "PauseTween", objArray1);
        }

        public float punch(float amplitude, float value)
        {
            object[] objArray1 = new object[] { amplitude, value };
            return base.method_11<float>("punch", objArray1);
        }

        public static void PunchPosition(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "PunchPosition", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void PunchRotation(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "PunchRotation", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void PunchScale(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "PunchScale", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
        {
            object[] objArray1 = new object[] { currentValue, targetValue, speed };
            return MonoClass.smethod_14<Rect>(TritonHs.MainAssemblyPath, "", "iTween", "RectUpdate", objArray1);
        }

        public void ResetDelay()
        {
            base.method_8("ResetDelay", Array.Empty<object>());
        }

        public static void Resume()
        {
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Resume", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static void Resume(string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { type };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Resume", enumArray1, objArray1);
        }

        public static void Resume(GameObject target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Resume", enumArray1, objArray1);
        }

        public static void Resume(GameObject target, bool includechildren)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { target, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Resume", enumArray1, objArray1);
        }

        public static void Resume(GameObject target, string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { target, type };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Resume", enumArray1, objArray1);
        }

        public static void Resume(GameObject target, string type, bool includechildren)
        {
            object[] objArray1 = new object[] { target, type, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Resume", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void ResumeDelay()
        {
            base.method_8("ResumeDelay", Array.Empty<object>());
        }

        public void RetrieveArgs()
        {
            base.method_8("RetrieveArgs", Array.Empty<object>());
        }

        public static void RotateAdd(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "RotateAdd", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void RotateBy(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "RotateBy", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void RotateFrom(GameObject target, Vector3 rotation, float time)
        {
            object[] objArray1 = new object[] { target, rotation, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "RotateFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void RotateTo(GameObject target, Vector3 rotation, float time)
        {
            object[] objArray1 = new object[] { target, rotation, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "RotateTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
        {
            object[] objArray1 = new object[] { target, rotation, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "RotateUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ScaleAdd(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ScaleAdd", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ScaleBy(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ScaleBy", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ScaleFrom(GameObject target, Vector3 scale, float time)
        {
            object[] objArray1 = new object[] { target, scale, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ScaleFrom", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ScaleTo(GameObject target, Vector3 scale, float time)
        {
            object[] objArray1 = new object[] { target, scale, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ScaleTo", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
        {
            object[] objArray1 = new object[] { target, scale, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ScaleUpdate", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShakePosition(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ShakePosition", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShakeRotation(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ShakeRotation", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShakeScale(GameObject target, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { target, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "ShakeScale", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public float spring(float start, float end, float value)
        {
            object[] objArray1 = new object[] { start, end, value };
            return base.method_11<float>("spring", objArray1);
        }

        public static void Stop()
        {
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Stop", new Class272.Enum20[0], Array.Empty<object>());
        }

        public static void Stop(string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { type };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Stop", enumArray1, objArray1);
        }

        public static void Stop(GameObject target)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { target };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Stop", enumArray1, objArray1);
        }

        public static void Stop(GameObject target, bool includechildren)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { target, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Stop", enumArray1, objArray1);
        }

        public static void Stop(GameObject target, string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { target, type };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Stop", enumArray1, objArray1);
        }

        public static void Stop(GameObject target, string type, bool includechildren)
        {
            object[] objArray1 = new object[] { target, type, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "Stop", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void StopByName(string name)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "StopByName", enumArray1, objArray1);
        }

        public static void StopByName(GameObject target, string name)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.String };
            object[] objArray1 = new object[] { target, name };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "StopByName", enumArray1, objArray1);
        }

        public static void StopByName(GameObject target, string name, bool includechildren)
        {
            object[] objArray1 = new object[] { target, name, includechildren };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "iTween", "StopByName", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void StopOthers(GameObject target, string type, bool includechildren)
        {
            object[] objArray1 = new object[] { target, type, includechildren };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "StopOthers", objArray1);
        }

        public static void StopOthersByName(GameObject target, string name, bool includechildren)
        {
            object[] objArray1 = new object[] { target, name, includechildren };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "StopOthersByName", objArray1);
        }

        public static void StopTween(iTween tween)
        {
            object[] objArray1 = new object[] { tween };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "iTween", "StopTween", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void TweenComplete()
        {
            base.method_8("TweenComplete", Array.Empty<object>());
        }

        public void TweenLoop()
        {
            base.method_8("TweenLoop", Array.Empty<object>());
        }

        public void TweenRestart()
        {
            base.method_8("TweenRestart", Array.Empty<object>());
        }

        public void TweenStart()
        {
            base.method_8("TweenStart", Array.Empty<object>());
        }

        public void TweenUpdate()
        {
            base.method_8("TweenUpdate", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdatePercentage()
        {
            base.method_8("UpdatePercentage", Array.Empty<object>());
        }

        public void Upkeep()
        {
            base.method_8("Upkeep", Array.Empty<object>());
        }

        public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
        {
            object[] objArray1 = new object[] { currentValue, targetValue, speed };
            return MonoClass.smethod_14<Vector2>(TritonHs.MainAssemblyPath, "", "iTween", "Vector2Update", objArray1);
        }

        public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
        {
            object[] objArray1 = new object[] { currentValue, targetValue, speed };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "iTween", "Vector3Update", objArray1);
        }

        public string _name
        {
            get
            {
                return base.method_4("_name");
            }
        }

        public bool activeInHierarchy
        {
            get
            {
                return base.method_11<bool>("get_activeInHierarchy", Array.Empty<object>());
            }
        }

        public bool activeLastTick
        {
            get
            {
                return base.method_2<bool>("activeLastTick");
            }
        }

        public static List<string> CALLBACK_NAMES
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "iTween", "CALLBACK_NAMES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<string> CALLBACK_PARAMS_NAMES
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "iTween", "CALLBACK_PARAMS_NAMES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<string> CALLBACK_TARGET_NAMES
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "iTween", "CALLBACK_TARGET_NAMES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static GameObject cameraFade
        {
            get
            {
                return MonoClass.smethod_7<GameObject>(TritonHs.MainAssemblyPath, "", "iTween", "cameraFade");
            }
        }

        public List<Color> colors
        {
            get
            {
                Class246<Color> class2 = base.method_3<Class246<Color>>("colors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float delay
        {
            get
            {
                return base.method_2<float>("delay");
            }
        }

        public float delayStarted
        {
            get
            {
                return base.method_2<float>("delayStarted");
            }
        }

        public bool destroyed
        {
            get
            {
                return base.method_2<bool>("destroyed");
            }
        }

        public EaseType easeType
        {
            get
            {
                return base.method_2<EaseType>("easeType");
            }
        }

        public bool enabled
        {
            get
            {
                return base.method_2<bool>("enabled");
            }
        }

        public List<float> floats
        {
            get
            {
                Class246<float> class2 = base.method_3<Class246<float>>("floats");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject gameObject
        {
            get
            {
                return base.method_3<GameObject>("gameObject");
            }
        }

        public GUITexture guiTexture
        {
            get
            {
                return base.method_14<GUITexture>("get_guiTexture", Array.Empty<object>());
            }
        }

        public int id
        {
            get
            {
                return base.method_2<int>("id");
            }
        }

        public bool isLocal
        {
            get
            {
                return base.method_2<bool>("isLocal");
            }
        }

        public bool isPaused
        {
            get
            {
                return base.method_2<bool>("isPaused");
            }
        }

        public bool isRunning
        {
            get
            {
                return base.method_2<bool>("isRunning");
            }
        }

        public bool kinematic
        {
            get
            {
                return base.method_2<bool>("kinematic");
            }
        }

        public float lastRealTime
        {
            get
            {
                return base.method_2<float>("lastRealTime");
            }
        }

        public bool loop
        {
            get
            {
                return base.method_2<bool>("loop");
            }
        }

        public LoopType loopType
        {
            get
            {
                return base.method_2<LoopType>("loopType");
            }
        }

        public string method
        {
            get
            {
                return base.method_4("method");
            }
        }

        public NamedValueColor namedcolorvalue
        {
            get
            {
                return base.method_2<NamedValueColor>("namedcolorvalue");
            }
        }

        public string namedColorValueString
        {
            get
            {
                return base.method_4("namedColorValueString");
            }
        }

        public static int nextId
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "iTween", "nextId");
            }
        }

        public CRSpline path
        {
            get
            {
                return base.method_3<CRSpline>("path");
            }
        }

        public float percentage
        {
            get
            {
                return base.method_2<float>("percentage");
            }
        }

        public bool physics
        {
            get
            {
                return base.method_2<bool>("physics");
            }
        }

        public Vector3 postUpdate
        {
            get
            {
                return base.method_2<Vector3>("postUpdate");
            }
        }

        public Vector3 preUpdate
        {
            get
            {
                return base.method_2<Vector3>("preUpdate");
            }
        }

        public List<Rect> rects
        {
            get
            {
                Class246<Rect> class2 = base.method_3<Class246<Rect>>("rects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Renderer renderer
        {
            get
            {
                return base.method_14<Renderer>("get_renderer", Array.Empty<object>());
            }
        }

        public bool reverse
        {
            get
            {
                return base.method_2<bool>("reverse");
            }
        }

        public float runningTime
        {
            get
            {
                return base.method_2<float>("runningTime");
            }
        }

        public Space space
        {
            get
            {
                return base.method_2<Space>("space");
            }
        }

        public float time
        {
            get
            {
                return base.method_2<float>("time");
            }
        }

        public Transform transform
        {
            get
            {
                return base.method_14<Transform>("get_transform", Array.Empty<object>());
            }
        }

        public string type
        {
            get
            {
                return base.method_4("type");
            }
        }

        public bool useRealTime
        {
            get
            {
                return base.method_2<bool>("useRealTime");
            }
        }

        public List<Vector2> vector2s
        {
            get
            {
                Class246<Vector2> class2 = base.method_3<Class246<Vector2>>("vector2s");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector3> vector3s
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("vector3s");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool waitForDelay
        {
            get
            {
                return base.method_2<bool>("waitForDelay");
            }
        }

        public enum CallbackType
        {
            OnStart,
            OnUpdate,
            OnComplete,
            OnConflict
        }

        [Attribute38("iTween.CRSpline")]
        public class CRSpline : MonoClass
        {
            public CRSpline(IntPtr address) : this(address, "CRSpline")
            {
            }

            public CRSpline(IntPtr address, string className) : base(address, className)
            {
            }

            public Vector3 Interp(float t)
            {
                object[] objArray1 = new object[] { t };
                return base.method_11<Vector3>("Interp", objArray1);
            }

            public List<Vector3> pts
            {
                get
                {
                    Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("pts");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("iTween.Defaults")]
        public class Defaults : MonoClass
        {
            public Defaults(IntPtr address) : this(address, "Defaults")
            {
            }

            public Defaults(IntPtr address, string className) : base(address, className)
            {
            }

            public static int cameraFadeDepth
            {
                get
                {
                    return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "cameraFadeDepth");
                }
            }

            public static Color color
            {
                get
                {
                    return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "color");
                }
            }

            public static float delay
            {
                get
                {
                    return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "delay");
                }
            }

            public static iTween.EaseType easeType
            {
                get
                {
                    return MonoClass.smethod_6<iTween.EaseType>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "easeType");
                }
            }

            public static bool isLocal
            {
                get
                {
                    return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "isLocal");
                }
            }

            public static float lookAhead
            {
                get
                {
                    return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "lookAhead");
                }
            }

            public static float lookSpeed
            {
                get
                {
                    return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "lookSpeed");
                }
            }

            public static iTween.LoopType loopType
            {
                get
                {
                    return MonoClass.smethod_6<iTween.LoopType>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "loopType");
                }
            }

            public static iTween.NamedValueColor namedColorValue
            {
                get
                {
                    return MonoClass.smethod_6<iTween.NamedValueColor>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "namedColorValue");
                }
            }

            public static bool orientToPath
            {
                get
                {
                    return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "orientToPath");
                }
            }

            public static Space space
            {
                get
                {
                    return MonoClass.smethod_6<Space>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "space");
                }
            }

            public static float time
            {
                get
                {
                    return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "time");
                }
            }

            public static Vector3 up
            {
                get
                {
                    return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "up");
                }
            }

            public static float updateTime
            {
                get
                {
                    return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "updateTime");
                }
            }

            public static float updateTimePercentage
            {
                get
                {
                    return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "updateTimePercentage");
                }
            }

            public static bool useRealTime
            {
                get
                {
                    return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "iTween/Defaults", "useRealTime");
                }
            }
        }

        public enum EaseType
        {
            easeInQuad,
            easeOutQuad,
            easeInOutQuad,
            easeInCubic,
            easeOutCubic,
            easeInOutCubic,
            easeInQuart,
            easeOutQuart,
            easeInOutQuart,
            easeInQuint,
            easeOutQuint,
            easeInOutQuint,
            easeInSine,
            easeOutSine,
            easeInOutSine,
            easeInExpo,
            easeOutExpo,
            easeInOutExpo,
            easeInCirc,
            easeOutCirc,
            easeInOutCirc,
            linear,
            spring,
            easeInBounce,
            easeOutBounce,
            easeInOutBounce,
            easeInBack,
            easeOutBack,
            easeInOutBack,
            easeInElastic,
            easeOutElastic,
            easeInOutElastic,
            punch,
            easeInSineOutExpo,
            easeOutElasticLight
        }

        public enum LoopType
        {
            none,
            loop,
            pingPong
        }

        public enum NamedValueColor
        {
            _Color,
            _SpecColor,
            _Emission,
            _ReflectColor
        }
    }
}

