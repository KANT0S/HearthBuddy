namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetInvitation")]
    public class BnetInvitation : MonoClass
    {
        public BnetInvitation(IntPtr address) : this(address, "BnetInvitation")
        {
        }

        public BnetInvitation(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Equals(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public bool Equals(BnetInvitationId other)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { other };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public ulong GetCreationTimeMicrosec()
        {
            return base.method_11<ulong>("GetCreationTimeMicrosec", Array.Empty<object>());
        }

        public ulong GetExpirationTimeMicrosec()
        {
            return base.method_11<ulong>("GetExpirationTimeMicrosec", Array.Empty<object>());
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public BnetInvitationId GetId()
        {
            return base.method_14<BnetInvitationId>("GetId", Array.Empty<object>());
        }

        public string GetInviteeName()
        {
            return base.method_13("GetInviteeName", Array.Empty<object>());
        }

        public string GetInviterName()
        {
            return base.method_13("GetInviterName", Array.Empty<object>());
        }

        public string GetMessage()
        {
            return base.method_13("GetMessage", Array.Empty<object>());
        }

        public static bool op_Equality(BnetInvitation a, BnetInvitation b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetInvitation", "op_Equality", objArray1);
        }

        public static bool op_Inequality(BnetInvitation a, BnetInvitation b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetInvitation", "op_Inequality", objArray1);
        }

        public void SetCreationTimeMicrosec(ulong microsec)
        {
            object[] objArray1 = new object[] { microsec };
            base.method_8("SetCreationTimeMicrosec", objArray1);
        }

        public void SetExpirationTimeMicroSec(ulong microsec)
        {
            object[] objArray1 = new object[] { microsec };
            base.method_8("SetExpirationTimeMicroSec", objArray1);
        }

        public void SetId(BnetInvitationId id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetId", objArray1);
        }

        public void SetInviteeName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetInviteeName", objArray1);
        }

        public void SetInviterName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetInviterName", objArray1);
        }

        public void SetMessage(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("SetMessage", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public ulong m_creationTimeMicrosec
        {
            get
            {
                return base.method_2<ulong>("m_creationTimeMicrosec");
            }
        }

        public ulong m_expirationTimeMicrosec
        {
            get
            {
                return base.method_2<ulong>("m_expirationTimeMicrosec");
            }
        }

        public BnetInvitationId m_id
        {
            get
            {
                return base.method_3<BnetInvitationId>("m_id");
            }
        }

        public string m_inviteeName
        {
            get
            {
                return base.method_4("m_inviteeName");
            }
        }

        public string m_inviterName
        {
            get
            {
                return base.method_4("m_inviterName");
            }
        }

        public string m_message
        {
            get
            {
                return base.method_4("m_message");
            }
        }
    }
}

