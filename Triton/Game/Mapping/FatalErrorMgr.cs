namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FatalErrorMgr")]
    public class FatalErrorMgr : MonoClass
    {
        public FatalErrorMgr(IntPtr address) : this(address, "FatalErrorMgr")
        {
        }

        public FatalErrorMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Add(FatalErrorMessage message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("Add", objArray1);
        }

        public bool AddUnique(FatalErrorMessage message)
        {
            object[] objArray1 = new object[] { message };
            return base.method_11<bool>("AddUnique", objArray1);
        }

        public void ClearAllErrors()
        {
            base.method_8("ClearAllErrors", Array.Empty<object>());
        }

        public void FireErrorListeners(FatalErrorMessage message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("FireErrorListeners", objArray1);
        }

        public static FatalErrorMgr Get()
        {
            return MonoClass.smethod_15<FatalErrorMgr>(TritonHs.MainAssemblyPath, "", "FatalErrorMgr", "Get", Array.Empty<object>());
        }

        public string GetFormattedErrorCode()
        {
            return base.method_13("GetFormattedErrorCode", Array.Empty<object>());
        }

        public List<FatalErrorMessage> GetMessages()
        {
            Class267<FatalErrorMessage> class2 = base.method_14<Class267<FatalErrorMessage>>("GetMessages", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasError()
        {
            return base.method_11<bool>("HasError", Array.Empty<object>());
        }

        public void NotifyExitPressed()
        {
            base.method_8("NotifyExitPressed", Array.Empty<object>());
        }

        public void SendAcknowledgements()
        {
            base.method_8("SendAcknowledgements", Array.Empty<object>());
        }

        public void SetErrorCode(string prefixSource, string errorSubset1, string errorSubset2, string errorSubset3)
        {
            object[] objArray1 = new object[] { prefixSource, errorSubset1, errorSubset2, errorSubset3 };
            base.method_8("SetErrorCode", objArray1);
        }

        public string m_generatedErrorCode
        {
            get
            {
                return base.method_4("m_generatedErrorCode");
            }
        }

        public List<FatalErrorMessage> m_messages
        {
            get
            {
                Class267<FatalErrorMessage> class2 = base.method_3<Class267<FatalErrorMessage>>("m_messages");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_text
        {
            get
            {
                return base.method_4("m_text");
            }
        }
    }
}

