namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AccountLicenseMgr")]
    public class AccountLicenseMgr : MonoClass
    {
        public AccountLicenseMgr(IntPtr address) : this(address, "AccountLicenseMgr")
        {
        }

        public AccountLicenseMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public static AccountLicenseMgr Get()
        {
            return MonoClass.smethod_15<AccountLicenseMgr>(TritonHs.MainAssemblyPath, "", "AccountLicenseMgr", "Get", Array.Empty<object>());
        }

        public bool OwnsAccountLicense(long license)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I8 };
            object[] objArray1 = new object[] { license };
            return base.method_10<bool>("OwnsAccountLicense", enumArray1, objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public bool m_registeredForProfileNotices
        {
            get
            {
                return base.method_2<bool>("m_registeredForProfileNotices");
            }
        }
    }
}

