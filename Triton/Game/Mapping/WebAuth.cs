namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("WebAuth")]
    public class WebAuth : MonoClass
    {
        public WebAuth(IntPtr address) : this(address, "WebAuth")
        {
        }

        public WebAuth(IntPtr address, string className) : base(address, className)
        {
        }

        public static void ClearBrowserCache()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "ClearBrowserCache");
        }

        public static void ClearLoginData()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "ClearLoginData");
        }

        public static void ClearURLCache()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "ClearURLCache");
        }

        public static void ClearWebViewCookies()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "ClearWebViewCookies");
        }

        public void Close()
        {
            base.method_8("Close", Array.Empty<object>());
        }

        public static void CloseWebView()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "CloseWebView");
        }

        public static void DeleteCookies()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "DeleteCookies");
        }

        public static void DeleteStoredLoginToken()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "DeleteStoredLoginToken");
        }

        public static void DeleteStoredToken()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "DeleteStoredToken");
        }

        public Error GetError()
        {
            return base.method_11<Error>("GetError", Array.Empty<object>());
        }

        public static bool GetIsNewCreatedAccount()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "WebAuth", "GetIsNewCreatedAccount", Array.Empty<object>());
        }

        public string GetLoginCode()
        {
            return base.method_13("GetLoginCode", Array.Empty<object>());
        }

        public Status GetStatus()
        {
            return base.method_11<Status>("GetStatus", Array.Empty<object>());
        }

        public static string GetStoredLoginToken()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "WebAuth", "GetStoredLoginToken", Array.Empty<object>());
        }

        public static string GetStoredToken()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "WebAuth", "GetStoredToken", Array.Empty<object>());
        }

        public static string GetWebViewLoginCode()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "WebAuth", "GetWebViewLoginCode", Array.Empty<object>());
        }

        public static int GetWebViewStatus()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "WebAuth", "GetWebViewStatus", Array.Empty<object>());
        }

        public static void GoBack()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "GoBack");
        }

        public static void GoBackWebPage()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "WebAuth", "GoBackWebPage");
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void Load()
        {
            base.method_8("Load", Array.Empty<object>());
        }

        public static void LoadWebView(string str, float x, float y, float width, float height, string deviceUniqueIdentifier, string gameObjectName)
        {
            object[] objArray1 = new object[] { str, x, y, width, height, deviceUniqueIdentifier, gameObjectName };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "LoadWebView", objArray1);
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public static void SetBreakingNews(string localized_title, string body, string gameObjectName)
        {
            object[] objArray1 = new object[] { localized_title, body, gameObjectName };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "SetBreakingNews", objArray1);
        }

        public void SetCountryCodeCookie(string countryCode, string domain)
        {
            object[] objArray1 = new object[] { countryCode, domain };
            base.method_8("SetCountryCodeCookie", objArray1);
        }

        public static void SetIsNewCreatedAccount(bool isNewCreatedAccount)
        {
            object[] objArray1 = new object[] { isNewCreatedAccount };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "SetIsNewCreatedAccount", objArray1);
        }

        public static void SetRegionSelectVisualState(bool isVisible)
        {
            object[] objArray1 = new object[] { isVisible };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "SetRegionSelectVisualState", objArray1);
        }

        public static bool SetStoredLoginToken(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "WebAuth", "SetStoredLoginToken", objArray1);
        }

        public static bool SetStoredToken(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "WebAuth", "SetStoredToken", objArray1);
        }

        public static void SetWebViewCountryCodeCookie(string countryCode, string domain)
        {
            object[] objArray1 = new object[] { countryCode, domain };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "SetWebViewCountryCodeCookie", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public static void ShowWebView(bool show)
        {
            object[] objArray1 = new object[] { show };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "ShowWebView", objArray1);
        }

        public static void UpdateBreakingNews(string title, string body, string gameObjectName)
        {
            object[] objArray1 = new object[] { title, body, gameObjectName };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "UpdateBreakingNews", objArray1);
        }

        public static void UpdateRegionSelectVisualState(bool isVisible)
        {
            object[] objArray1 = new object[] { isVisible };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "WebAuth", "UpdateRegionSelectVisualState", objArray1);
        }

        public string m_callbackGameObject
        {
            get
            {
                return base.method_4("m_callbackGameObject");
            }
        }

        public static bool m_isNewCreatedAccount
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "WebAuth", "m_isNewCreatedAccount");
            }
        }

        public bool m_show
        {
            get
            {
                return base.method_2<bool>("m_show");
            }
        }

        public string m_url
        {
            get
            {
                return base.method_4("m_url");
            }
        }

        public Rect m_window
        {
            get
            {
                return base.method_2<Rect>("m_window");
            }
        }

        public enum Error
        {
            InternalError
        }

        public enum Status
        {
            Closed,
            Loading,
            ReadyToDisplay,
            Processing,
            Success,
            Error,
            MAX
        }
    }
}

