namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Error")]
    public class Error : MonoClass
    {
        public Error(IntPtr address) : this(address, "Error")
        {
        }

        public Error(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AddFatal(string message)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { message };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "Error", "AddFatal", enumArray1, objArray1);
        }

        public static void AddFatal(ErrorParams parms)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { parms };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "Error", "AddFatal", enumArray1, objArray1);
        }

        public static void AddWarning(ErrorParams parms)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { parms };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "Error", "AddWarning", enumArray1, objArray1);
        }

        public static void OnWarningPopupResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Error", "OnWarningPopupResponse", objArray1);
        }

        public static bool ShouldUseWarningDialogForFatalError()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "Error", "ShouldUseWarningDialogForFatalError", Array.Empty<object>());
        }

        public static void ShowWarningDialog(ErrorParams parms)
        {
            object[] objArray1 = new object[] { parms };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "Error", "ShowWarningDialog", objArray1);
        }
    }
}

